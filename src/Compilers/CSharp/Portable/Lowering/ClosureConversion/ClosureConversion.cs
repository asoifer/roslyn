// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

//#define CHECK_LOCALS // define CHECK_LOCALS to help debug some rewriting problems that would otherwise cause code-gen failures


using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class ClosureConversion : MethodToClassRewriter
    {
        private readonly Analysis _analysis;

        private readonly MethodSymbol _topLevelMethod;

        private readonly MethodSymbol _substitutedSourceMethod;

        private readonly int _topLevelMethodOrdinal;

        private SynthesizedClosureEnvironment _lazyStaticLambdaFrame;

        private readonly Dictionary<ParameterSymbol, ParameterSymbol> _parameterMap;

        private readonly Dictionary<BoundNode, Analysis.ClosureEnvironment> _frames;

        private readonly Dictionary<NamedTypeSymbol, Symbol> _framePointers;

        private readonly HashSet<LocalSymbol> _assignLocals;

        private MethodSymbol _currentMethod;

        private ParameterSymbol _currentFrameThis;

        private readonly ArrayBuilder<LambdaDebugInfo> _lambdaDebugInfoBuilder;

        private int _synthesizedFieldNameIdDispenser;

        private Symbol _innermostFramePointer;

        private TypeMap _currentLambdaBodyTypeMap;

        private ImmutableArray<TypeParameterSymbol> _currentTypeParameters;

        private BoundExpression _thisProxyInitDeferred;

        private bool _seenBaseCall;

        private bool _inExpressionLambda;

        private ArrayBuilder<LocalSymbol> _addedLocals;

        private ArrayBuilder<BoundStatement> _addedStatements;

        private ArrayBuilder<TypeCompilationState.MethodWithBody> _synthesizedMethods;

        private readonly ImmutableHashSet<Symbol> _allCapturedVariables;

        private ClosureConversion(
                    Analysis analysis,
                    NamedTypeSymbol thisType,
                    ParameterSymbol thisParameterOpt,
                    MethodSymbol method,
                    int methodOrdinal,
                    MethodSymbol substitutedSourceMethod,
                    ArrayBuilder<LambdaDebugInfo> lambdaDebugInfoBuilder,
                    VariableSlotAllocator slotAllocatorOpt,
                    TypeCompilationState compilationState,
                    DiagnosticBag diagnostics,
                    HashSet<LocalSymbol> assignLocals)
        : base(f_10453_9200_9216_C(slotAllocatorOpt), compilationState, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10453, 8658, 10614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 4560, 4569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 4610, 4625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 4666, 4690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 4722, 4744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 4921, 4943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 5109, 5175);
                this._parameterMap = f_10453_5125_5175(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 5346, 5412);
                this._frames = f_10453_5356_5412(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 5693, 5751);
                this._framePointers = f_10453_5710_5751(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 5997, 6010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 6102, 6116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 6207, 6224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 6284, 6307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 6393, 6425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 6521, 6543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 6643, 6668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 7036, 7058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 7183, 7196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 7301, 7320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 7599, 7611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 7825, 7841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 8129, 8148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 8604, 8625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9273, 9310);

                f_10453_9273_9309(analysis != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9324, 9369);

                f_10453_9324_9368((object)thisType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9383, 9418);

                f_10453_9383_9417(method != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9432, 9477);

                f_10453_9432_9476(compilationState != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9491, 9531);

                f_10453_9491_9530(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9547, 9572);

                _topLevelMethod = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9586, 9637);

                _substitutedSourceMethod = substitutedSourceMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9651, 9690);

                _topLevelMethodOrdinal = methodOrdinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9704, 9753);

                _lambdaDebugInfoBuilder = lambdaDebugInfoBuilder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9767, 9791);

                _currentMethod = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9805, 9826);

                _analysis = analysis;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9840, 9869);

                _assignLocals = assignLocals;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9883, 9930);

                _currentTypeParameters = f_10453_9908_9929(method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 9944, 9986);

                _currentLambdaBodyTypeMap = f_10453_9972_9985();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 10000, 10062);

                _innermostFramePointer = _currentFrameThis = thisParameterOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 10076, 10120);

                _framePointers[thisType] = thisParameterOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 10134, 10194);

                _seenBaseCall = f_10453_10150_10167(method) != MethodKind.Constructor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 10231, 10268);

                _synthesizedFieldNameIdDispenser = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 10284, 10347);

                var
                allCapturedVars = f_10453_10306_10346()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 10361, 10535);

                f_10453_10361_10534(analysis.ScopeTree, (scope, function) =>
                            {
                                allCapturedVars.UnionWith(function.CapturedVariables);
                            });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 10549, 10603);

                _allCapturedVariables = f_10453_10573_10602(allCapturedVars);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10453, 8658, 10614);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 8658, 10614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 8658, 10614);
            }
        }

        protected override bool NeedsProxy(Symbol localOrParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 10647, 11052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 10754, 10971);

                f_10453_10754_10970(localOrParameter is LocalSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10453, 10767, 10837) || localOrParameter is ParameterSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10453, 10767, 10969) || ((localOrParameter is MethodSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10453, 10859, 10968) && f_10453_10897_10940(((MethodSymbol)localOrParameter)) == MethodKind.LocalFunction))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 10985, 11041);

                return f_10453_10992_11040(_allCapturedVariables, localOrParameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 10647, 11052);

                Microsoft.CodeAnalysis.MethodKind
                f_10453_10897_10940(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 10897, 10940);
                    return return_v;
                }


                int
                f_10453_10754_10970(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 10754, 10970);
                    return 0;
                }


                bool
                f_10453_10992_11040(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 10992, 11040);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 10647, 11052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 10647, 11052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundStatement Rewrite(
                    BoundStatement loweredBody,
                    NamedTypeSymbol thisType,
                    ParameterSymbol thisParameter,
                    MethodSymbol method,
                    int methodOrdinal,
                    MethodSymbol substitutedSourceMethod,
                    ArrayBuilder<LambdaDebugInfo> lambdaDebugInfoBuilder,
                    ArrayBuilder<ClosureDebugInfo> closureDebugInfoBuilder,
                    VariableSlotAllocator slotAllocatorOpt,
                    TypeCompilationState compilationState,
                    DiagnosticBag diagnostics,
                    HashSet<LocalSymbol> assignLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10453, 12834, 15427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 13466, 13505);

                f_10453_13466_13504((object)thisType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 13519, 13655);

                f_10453_13519_13654(((object)thisParameter == null) || (DynAbs.Tracing.TraceSender.Expression_False(10453, 13532, 13653) || (f_10453_13568_13652(f_10453_13586_13604(thisParameter), thisType, TypeCompareKind.ConsiderEverything2))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 13669, 13725);

                f_10453_13669_13724(compilationState.ModuleBuilderOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 13741, 14045);

                var
                analysis = f_10453_13756_14044(loweredBody, method, methodOrdinal, substitutedSourceMethod, slotAllocatorOpt, compilationState, closureDebugInfoBuilder, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 14061, 14093);

                f_10453_14061_14092(loweredBody);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 14107, 14502);

                var
                rewriter = f_10453_14122_14501(analysis, thisType, thisParameter, method, methodOrdinal, substitutedSourceMethod, lambdaDebugInfoBuilder, slotAllocatorOpt, compilationState, diagnostics, assignLocals)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 14518, 14582);

                f_10453_14518_14581(
                            rewriter, closureDebugInfoBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 14596, 14632);

                f_10453_14596_14631(rewriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 14648, 14753);

                var
                body = f_10453_14659_14752(rewriter, f_10453_14724_14751(rewriter, loweredBody))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 14836, 15315) || true) && (rewriter._synthesizedMethods != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 14836, 15315);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 14910, 15300) || true) && (f_10453_14914_14949(compilationState) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 14910, 15300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 14999, 15066);

                        compilationState.SynthesizedMethods = rewriter._synthesizedMethods;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 14910, 15300);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 14910, 15300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15148, 15223);

                        f_10453_15148_15222(f_10453_15148_15183(compilationState), rewriter._synthesizedMethods);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15245, 15281);

                        f_10453_15245_15280(rewriter._synthesizedMethods);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 14910, 15300);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 14836, 15315);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15331, 15356);

                f_10453_15331_15355(body);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15372, 15388);

                f_10453_15372_15387(
                            analysis);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15404, 15416);

                return body;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10453, 12834, 15427);

                int
                f_10453_13466_13504(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 13466, 13504);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_13586_13604(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 13586, 13604);
                    return return_v;
                }


                bool
                f_10453_13568_13652(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 13568, 13652);
                    return return_v;
                }


                int
                f_10453_13519_13654(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 13519, 13654);
                    return 0;
                }


                int
                f_10453_13669_13724(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 13669, 13724);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                f_10453_13756_14044(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                topLevelMethodOrdinal, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                substitutedSourceMethod, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfo, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Analysis.Analyze((Microsoft.CodeAnalysis.CSharp.BoundNode)node, method, topLevelMethodOrdinal, substitutedSourceMethod, slotAllocatorOpt, compilationState, closureDebugInfo, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 13756, 14044);
                    return return_v;
                }


                int
                f_10453_14061_14092(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    CheckLocalsDefined((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 14061, 14092);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ClosureConversion
                f_10453_14122_14501(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                analysis, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                thisType, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                thisParameterOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, int
                methodOrdinal, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                substitutedSourceMethod, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdaDebugInfoBuilder, Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                slotAllocatorOpt, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                assignLocals)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ClosureConversion(analysis, thisType, thisParameterOpt, method, methodOrdinal, substitutedSourceMethod, lambdaDebugInfoBuilder, slotAllocatorOpt, compilationState, diagnostics, assignLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 14122, 14501);
                    return return_v;
                }


                int
                f_10453_14518_14581(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closureDebugInfo)
                {
                    this_param.SynthesizeClosureEnvironments(closureDebugInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 14518, 14581);
                    return 0;
                }


                int
                f_10453_14596_14631(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param)
                {
                    this_param.SynthesizeClosureMethods();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 14596, 14631);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10453_14724_14751(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 14724, 14751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10453_14659_14752(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode?
                body)
                {
                    var return_v = this_param.AddStatementsIfNeeded((Microsoft.CodeAnalysis.CSharp.BoundStatement?)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 14659, 14752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>?
                f_10453_14914_14949(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.SynthesizedMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 14914, 14949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                f_10453_15148_15183(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.SynthesizedMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 15148, 15183);
                    return return_v;
                }


                int
                f_10453_15148_15222(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 15148, 15222);
                    return 0;
                }


                int
                f_10453_15245_15280(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 15245, 15280);
                    return 0;
                }


                int
                f_10453_15331_15355(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    CheckLocalsDefined((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 15331, 15355);
                    return 0;
                }


                int
                f_10453_15372_15387(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 15372, 15387);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 12834, 15427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 12834, 15427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement AddStatementsIfNeeded(BoundStatement body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 15439, 16012);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15529, 15973) || true) && (_addedLocals != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 15529, 15973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15587, 15614);

                    f_10453_15587_15613(_addedStatements, body);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15632, 15773);

                    body = new BoundBlock(body.Syntax, f_10453_15667_15700(_addedLocals), f_10453_15702_15739(_addedStatements)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10453, 15639, 15772) };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15791, 15811);

                    _addedLocals = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15829, 15853);

                    _addedStatements = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 15529, 15973);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 15529, 15973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15919, 15958);

                    f_10453_15919_15957(_addedStatements == null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 15529, 15973);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 15989, 16001);

                return body;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 15439, 16012);

                int
                f_10453_15587_15613(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 15587, 15613);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_15667_15700(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 15667, 15700);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_15702_15739(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 15702, 15739);
                    return return_v;
                }


                int
                f_10453_15919_15957(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 15919, 15957);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 15439, 16012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 15439, 16012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeMap TypeMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 16083, 16124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 16089, 16122);

                    return _currentLambdaBodyTypeMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 16083, 16124);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 16024, 16135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 16024, 16135);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override MethodSymbol CurrentMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 16217, 16247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 16223, 16245);

                    return _currentMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 16217, 16247);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 16147, 16258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 16147, 16258);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 16344, 16390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 16350, 16388);

                    return f_10453_16357_16387(_topLevelMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 16344, 16390);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10453_16357_16387(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 16357, 16387);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 16270, 16401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 16270, 16401);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static partial void CheckLocalsDefined(BoundNode node);

        private void SynthesizeClosureEnvironments(ArrayBuilder<ClosureDebugInfo> closureDebugInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 16917, 19737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 17033, 18013);

                f_10453_17033_18012(_analysis.ScopeTree, scope =>
                            {
                                if (scope.DeclaredEnvironment is { } env)
                                {
                                    Debug.Assert(!_frames.ContainsKey(scope.BoundNode));

                                    var frame = MakeFrame(scope, env);
                                    env.SynthesizedEnvironment = frame;

                                    CompilationState.ModuleBuilderOpt.AddSynthesizedDefinition(ContainingType, frame.GetCciAdapter());
                                    if (frame.Constructor != null)
                                    {
                                        AddSynthesizedMethod(
                                            frame.Constructor,
                                            FlowAnalysisPass.AppendImplicitReturn(
                                                MethodCompiler.BindMethodBody(frame.Constructor, CompilationState, Diagnostics),
                                                frame.Constructor));
                                    }

                                    _frames.Add(scope.BoundNode, env);
                                }
                            });

                SynthesizedClosureEnvironment MakeFrame(Analysis.Scope scope, Analysis.ClosureEnvironment env)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 18029, 19726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 18156, 18193);

                        var
                        scopeBoundNode = scope.BoundNode
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 18213, 18248);

                        var
                        syntax = scopeBoundNode.Syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 18266, 18295);

                        f_10453_18266_18294(syntax != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 18315, 18366);

                        DebugId
                        methodId = f_10453_18334_18365(_analysis)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 18384, 18453);

                        DebugId
                        closureId = f_10453_18404_18452(_analysis, syntax, closureDebugInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 18473, 18565);

                        var
                        containingMethod = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(scope.ContainingFunctionOpt, 10453, 18496, 18545)?.OriginalMethodSymbol ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>(10453, 18496, 18564) ?? _topLevelMethod)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 18583, 18771) || true) && ((object)_substitutedSourceMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10453, 18587, 18666) && containingMethod == _topLevelMethod))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 18583, 18771);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 18708, 18752);

                            containingMethod = _substitutedSourceMethod;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 18583, 18771);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 18791, 19051);

                        var
                        synthesizedEnv = f_10453_18812_19050(_topLevelMethod, containingMethod, env.IsStruct, syntax, methodId, closureId)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 19071, 19669);
                            foreach (var captured in f_10453_19096_19117_I(env.CapturedVariables))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 19071, 19669);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 19159, 19204);

                                f_10453_19159_19203(!f_10453_19173_19202(proxies, captured));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 19228, 19341);

                                var
                                hoistedField = f_10453_19247_19340(synthesizedEnv, captured, ref _synthesizedFieldNameIdDispenser)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 19363, 19456);

                                f_10453_19363_19455(proxies, captured, f_10453_19385_19454(hoistedField, isReusable: false));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 19478, 19523);

                                f_10453_19478_19522(synthesizedEnv, hoistedField);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 19545, 19650);

                                f_10453_19545_19649(CompilationState.ModuleBuilderOpt, synthesizedEnv, f_10453_19620_19648(hoistedField));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 19071, 19669);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 599);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 599);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 19689, 19711);

                        return synthesizedEnv;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 18029, 19726);

                        int
                        f_10453_18266_18294(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 18266, 18294);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CodeGen.DebugId
                        f_10453_18334_18365(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                        this_param)
                        {
                            var return_v = this_param.GetTopLevelMethodId();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 18334, 18365);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CodeGen.DebugId
                        f_10453_18404_18452(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                        this_param, Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                        closureDebugInfo)
                        {
                            var return_v = this_param.GetClosureId(syntax, closureDebugInfo);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 18404, 18452);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                        f_10453_18812_19050(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        topLevelMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        containingMethod, bool
                        isStruct, Microsoft.CodeAnalysis.SyntaxNode
                        scopeSyntaxOpt, Microsoft.CodeAnalysis.CodeGen.DebugId
                        methodId, Microsoft.CodeAnalysis.CodeGen.DebugId
                        closureId)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment(topLevelMethod, containingMethod, isStruct, scopeSyntaxOpt, methodId, closureId);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 18812, 19050);
                            return return_v;
                        }


                        bool
                        f_10453_19173_19202(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        key)
                        {
                            var return_v = this_param.ContainsKey(key);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 19173, 19202);
                            return return_v;
                        }


                        int
                        f_10453_19159_19203(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 19159, 19203);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                        f_10453_19247_19340(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                        frame, Microsoft.CodeAnalysis.CSharp.Symbol
                        captured, ref int
                        uniqueId)
                        {
                            var return_v = LambdaCapturedVariable.Create(frame, captured, ref uniqueId);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 19247, 19340);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CapturedToFrameSymbolReplacement
                        f_10453_19385_19454(Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                        hoistedField, bool
                        isReusable)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CapturedToFrameSymbolReplacement(hoistedField, isReusable: isReusable);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 19385, 19454);
                            return return_v;
                        }


                        int
                        f_10453_19363_19455(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        key, Microsoft.CodeAnalysis.CSharp.CapturedToFrameSymbolReplacement
                        value)
                        {
                            this_param.Add(key, (Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement)value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 19363, 19455);
                            return 0;
                        }


                        int
                        f_10453_19478_19522(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                        this_param, Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                        captured)
                        {
                            this_param.AddHoistedField(captured);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 19478, 19522);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                        f_10453_19620_19648(Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                        this_param)
                        {
                            var return_v = this_param.GetCciAdapter();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 19620, 19648);
                            return return_v;
                        }


                        int
                        f_10453_19545_19649(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                        this_param, Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                        container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                        field)
                        {
                            this_param.AddSynthesizedDefinition((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container, (Microsoft.Cci.IFieldDefinition)field);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 19545, 19649);
                            return 0;
                        }


                        Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10453_19096_19117_I(Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 19096, 19117);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 18029, 19726);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 18029, 19726);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 16917, 19737);

                int
                f_10453_17033_18012(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                treeRoot, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                action)
                {
                    Analysis.VisitScopeTree(treeRoot, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 17033, 18012);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 16917, 19737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 16917, 19737);
            }
        }

        private void SynthesizeClosureMethods()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 19862, 24234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 19926, 23649);

                f_10453_19926_23648(_analysis.ScopeTree, (scope, nestedFunction) =>
                            {
                                var originalMethod = nestedFunction.OriginalMethodSymbol;
                                var syntax = originalMethod.DeclaringSyntaxReferences[0].GetSyntax();

                                int closureOrdinal;
                                ClosureKind closureKind;
                                NamedTypeSymbol translatedLambdaContainer;
                                SynthesizedClosureEnvironment containerAsFrame;
                                DebugId topLevelMethodId;
                                DebugId lambdaId;

                                if (nestedFunction.ContainingEnvironmentOpt != null)
                                {
                                    containerAsFrame = nestedFunction.ContainingEnvironmentOpt.SynthesizedEnvironment;

                                    closureKind = ClosureKind.General;
                                    translatedLambdaContainer = containerAsFrame;
                                    closureOrdinal = containerAsFrame.ClosureOrdinal;
                                }
                                else if (nestedFunction.CapturesThis)
                                {
                                    containerAsFrame = null;
                                    translatedLambdaContainer = _topLevelMethod.ContainingType;
                                    closureKind = ClosureKind.ThisOnly;
                                    closureOrdinal = LambdaDebugInfo.ThisOnlyClosureOrdinal;
                                }
                                else if ((nestedFunction.CapturedEnvironments.Count == 0 &&
                                          originalMethod.MethodKind == MethodKind.LambdaMethod &&
                                          _analysis.MethodsConvertedToDelegates.Contains(originalMethod)) ||
                                         // If we are in a variant interface, runtime might not consider the 
                                         // method synthesized directly within the interface as variant safe.
                                         // For simplicity we do not perform precise analysis whether this would
                                         // definitely be the case. If we are in a variant interface, we always force
                                         // creation of a display class.
                                         VarianceSafety.GetEnclosingVariantInterface(_topLevelMethod) is object)
                                {
                                    translatedLambdaContainer = containerAsFrame = GetStaticFrame(Diagnostics, syntax);
                                    closureKind = ClosureKind.Singleton;
                                    closureOrdinal = LambdaDebugInfo.StaticClosureOrdinal;
                                }
                                else
                                {
                    // Lower directly onto the containing type
                    translatedLambdaContainer = _topLevelMethod.ContainingType;
                                    containerAsFrame = null;
                                    closureKind = ClosureKind.Static;
                                    closureOrdinal = LambdaDebugInfo.StaticClosureOrdinal;
                                }

                                Debug.Assert((object)translatedLambdaContainer != _topLevelMethod.ContainingType ||
                                             VarianceSafety.GetEnclosingVariantInterface(_topLevelMethod) is null);

                // Move the body of the lambda to a freshly generated synthetic method on its frame.
                topLevelMethodId = _analysis.GetTopLevelMethodId();
                                lambdaId = GetLambdaId(syntax, closureKind, closureOrdinal);

                                var synthesizedMethod = new SynthesizedClosureMethod(
                                    translatedLambdaContainer,
                                    getStructEnvironments(nestedFunction),
                                    closureKind,
                                    _topLevelMethod,
                                    topLevelMethodId,
                                    originalMethod,
                                    nestedFunction.BlockSyntax,
                                    lambdaId);
                                nestedFunction.SynthesizedLoweredMethod = synthesizedMethod;
                            });

                static ImmutableArray<SynthesizedClosureEnvironment> getStructEnvironments(Analysis.NestedFunction function)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10453, 23665, 24223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 23806, 23883);

                        var
                        environments = f_10453_23825_23882()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 23903, 24147);
                            foreach (var env in f_10453_23923_23952_I(function.CapturedEnvironments))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 23903, 24147);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 23994, 24128) || true) && (env.IsStruct)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 23994, 24128);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 24060, 24105);

                                    f_10453_24060_24104(environments, env.SynthesizedEnvironment);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 23994, 24128);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 23903, 24147);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 245);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 245);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 24167, 24208);

                        return f_10453_24174_24207(environments);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10453, 23665, 24223);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment>
                        f_10453_23825_23882()
                        {
                            var return_v = ArrayBuilder<SynthesizedClosureEnvironment>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 23825, 23882);
                            return return_v;
                        }


                        int
                        f_10453_24060_24104(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment>
                        this_param, Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 24060, 24104);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                        f_10453_23923_23952_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 23923, 23952);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment>
                        f_10453_24174_24207(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 24174, 24207);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 23665, 24223);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 23665, 24223);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 19862, 24234);

                int
                f_10453_19926_23648(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                scope, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                action)
                {
                    Analysis.VisitNestedFunctions(scope, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 19926, 23648);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 19862, 24234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 19862, 24234);
            }
        }

        private SynthesizedClosureEnvironment GetStaticFrame(DiagnosticBag diagnostics, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 24719, 27911);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 24842, 27854) || true) && ((object)_lazyStaticLambdaFrame == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 24842, 27854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 24918, 24970);

                    var
                    isNonGeneric = f_10453_24937_24969_M(!_topLevelMethod.IsGenericMethod)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 24988, 25125) || true) && (isNonGeneric)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 24988, 25125);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 25046, 25106);

                        _lazyStaticLambdaFrame = CompilationState.StaticLambdaFrame;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 24988, 25125);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 25145, 27839) || true) && ((object)_lazyStaticLambdaFrame == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 25145, 27839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 25229, 25246);

                        DebugId
                        methodId
                        = default(DebugId);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 25268, 25607) || true) && (isNonGeneric)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 25268, 25607);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 25334, 25443);

                            methodId = f_10453_25345_25442(DebugId.UndefinedOrdinal, f_10453_25383_25441(CompilationState.ModuleBuilderOpt));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 25268, 25607);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 25268, 25607);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 25541, 25584);

                            methodId = f_10453_25552_25583(_analysis);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 25268, 25607);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 25631, 25668);

                        DebugId
                        closureId = default(DebugId)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 25850, 25941);

                        var
                        containingMethod = (DynAbs.Tracing.TraceSender.Conditional_F1(10453, 25873, 25885) || ((isNonGeneric && DynAbs.Tracing.TraceSender.Conditional_F2(10453, 25888, 25892)) || DynAbs.Tracing.TraceSender.Conditional_F3(10453, 25895, 25940))) ? null : (_substitutedSourceMethod ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(10453, 25896, 25939) ?? _topLevelMethod))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 25963, 26289);

                        _lazyStaticLambdaFrame = f_10453_25988_26288(_topLevelMethod, containingMethod, isStruct: false, scopeSyntaxOpt: null, methodId: methodId, closureId: closureId);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 26384, 26533) || true) && (isNonGeneric)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 26384, 26533);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 26450, 26510);

                            CompilationState.StaticLambdaFrame = _lazyStaticLambdaFrame;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 26384, 26533);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 26557, 26592);

                        var
                        frame = _lazyStaticLambdaFrame
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 26671, 26774);

                        f_10453_26671_26773(
                                            // add frame type and cache field
                                            CompilationState.ModuleBuilderOpt, f_10453_26730_26749(this), f_10453_26751_26772(frame));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 26948, 27237);

                        f_10453_26948_27236(this, f_10453_26995_27012(frame), f_10453_27039_27235(f_10453_27107_27186(f_10453_27137_27154(frame), CompilationState, diagnostics), f_10453_27217_27234(frame)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 27344, 27446);

                        var
                        F = f_10453_27352_27445(frame.StaticConstructor, syntax, CompilationState, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 27468, 27744);

                        var
                        body = f_10453_27479_27743(F, f_10453_27517_27659(F, f_10453_27564_27599(F, null, frame.SingletonCache), f_10453_27634_27658(F, f_10453_27640_27657(frame))), f_10453_27690_27742(syntax, RefKind.None, null))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 27768, 27820);

                        f_10453_27768_27819(this, frame.StaticConstructor, body);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 25145, 27839);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 24842, 27854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 27870, 27900);

                return _lazyStaticLambdaFrame;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 24719, 27911);

                bool
                f_10453_24937_24969_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 24937, 24969);
                    return return_v;
                }


                int
                f_10453_25383_25441(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param)
                {
                    var return_v = this_param.CurrentGenerationOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 25383, 25441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.DebugId
                f_10453_25345_25442(int
                ordinal, int
                generation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.DebugId(ordinal, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 25345, 25442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.DebugId
                f_10453_25552_25583(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                this_param)
                {
                    var return_v = this_param.GetTopLevelMethodId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 25552, 25583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                f_10453_25988_26288(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                containingMethod, bool
                isStruct, Microsoft.CodeAnalysis.SyntaxNode
                scopeSyntaxOpt, Microsoft.CodeAnalysis.CodeGen.DebugId
                methodId, Microsoft.CodeAnalysis.CodeGen.DebugId
                closureId)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment(topLevelMethod, containingMethod, isStruct: isStruct, scopeSyntaxOpt: scopeSyntaxOpt, methodId: methodId, closureId: closureId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 25988, 26288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_26730_26749(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 26730, 26749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10453_26751_26772(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 26751, 26772);
                    return return_v;
                }


                int
                f_10453_26671_26773(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                nestedType)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.INestedTypeDefinition)nestedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 26671, 26773);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_26995_27012(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 26995, 27012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_27137_27154(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 27137, 27154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10453_27107_27186(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = MethodCompiler.BindMethodBody(method, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 27107, 27186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_27217_27234(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 27217, 27234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10453_27039_27235(Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = FlowAnalysisPass.AppendImplicitReturn(body, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 27039, 27235);
                    return return_v;
                }


                int
                f_10453_26948_27236(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.AddSynthesizedMethod(method, (Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 26948, 27236);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10453_27352_27445(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory(topLevelMethod, node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 27352, 27445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10453_27564_27599(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field(receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 27564, 27599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_27640_27657(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 27640, 27657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10453_27634_27658(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.New(ctor, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 27634, 27658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10453_27517_27659(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 27517, 27659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10453_27690_27742(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expressionOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundReturnStatement(syntax, refKind, expressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 27690, 27742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10453_27479_27743(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 27479, 27743);
                    return return_v;
                }


                int
                f_10453_27768_27819(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.AddSynthesizedMethod(method, (Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 27768, 27819);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 24719, 27911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 24719, 27911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression FrameOfType(SyntaxNode syntax, NamedTypeSymbol frameType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 28334, 28662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 28440, 28516);

                BoundExpression
                result = f_10453_28465_28515(this, syntax, f_10453_28486_28514(frameType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 28530, 28623);

                f_10453_28530_28622(f_10453_28543_28621(f_10453_28561_28572(result), frameType, TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 28637, 28651);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 28334, 28662);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_28486_28514(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 28486, 28514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_28465_28515(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                frameClass)
                {
                    var return_v = this_param.FramePointer(syntax, frameClass);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 28465, 28515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10453_28561_28572(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 28561, 28572);
                    return return_v;
                }


                bool
                f_10453_28543_28621(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 28543, 28621);
                    return return_v;
                }


                int
                f_10453_28530_28622(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 28530, 28622);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 28334, 28662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 28334, 28662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BoundExpression FramePointer(SyntaxNode syntax, NamedTypeSymbol frameClass)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 29284, 31387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 29403, 29441);

                f_10453_29403_29440(f_10453_29416_29439(frameClass));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 29556, 29786) || true) && ((object)_currentFrameThis != null && (DynAbs.Tracing.TraceSender.Expression_True(10453, 29560, 29687) && f_10453_29597_29687(f_10453_29615_29637(_currentFrameThis), frameClass, TypeCompareKind.ConsiderEverything2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 29556, 29786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 29721, 29771);

                    return f_10453_29728_29770(syntax, frameClass);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 29556, 29786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 29914, 29970);

                var
                lambda = _currentMethod as SynthesizedClosureMethod
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 29984, 30563) || true) && (lambda != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 29984, 30563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 30036, 30110);

                    var
                    start = f_10453_30048_30069(lambda) - f_10453_30072_30109(lambda)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 30137, 30146);
                        for (var
        i = start
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 30128, 30548) || true) && (i < f_10453_30152_30173(lambda))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 30175, 30178)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 30128, 30548))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 30128, 30548);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 30220, 30266);

                            var
                            potentialParameter = f_10453_30245_30262(lambda)[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 30288, 30529) || true) && (f_10453_30292_30402(f_10453_30310_30352(f_10453_30310_30333(potentialParameter)), frameClass, TypeCompareKind.ConsiderEverything2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 30288, 30529);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 30452, 30506);

                                return f_10453_30459_30505(syntax, potentialParameter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 30288, 30529);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 421);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 421);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 29984, 30563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 30672, 30721);

                Symbol
                framePointer = f_10453_30694_30720(_framePointers, frameClass)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 30735, 30772);

                CapturedSymbolReplacement
                proxyField
                = default(CapturedSymbolReplacement);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 30786, 31238) || true) && (f_10453_30790_30839(proxies, framePointer, out proxyField))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 30786, 31238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 31139, 31223);

                    return f_10453_31146_31222(proxyField, syntax, frameType => FramePointer(syntax, frameType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 30786, 31238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 31254, 31297);

                var
                localFrame = (LocalSymbol)framePointer
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 31311, 31376);

                return f_10453_31318_31375(syntax, localFrame, null, f_10453_31359_31374(localFrame));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 29284, 31387);

                bool
                f_10453_29416_29439(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 29416, 29439);
                    return return_v;
                }


                int
                f_10453_29403_29440(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 29403, 29440);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_29615_29637(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 29615, 29637);
                    return return_v;
                }


                bool
                f_10453_29597_29687(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 29597, 29687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10453_29728_29770(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundThisReference(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 29728, 29770);
                    return return_v;
                }


                int
                f_10453_30048_30069(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 30048, 30069);
                    return return_v;
                }


                int
                f_10453_30072_30109(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ExtraSynthesizedParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 30072, 30109);
                    return return_v;
                }


                int
                f_10453_30152_30173(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 30152, 30173);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10453_30245_30262(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 30245, 30262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_30310_30333(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 30310, 30333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_30310_30352(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 30310, 30352);
                    return return_v;
                }


                bool
                f_10453_30292_30402(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 30292, 30402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10453_30459_30505(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameterSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundParameter(syntax, parameterSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 30459, 30505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10453_30694_30720(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 30694, 30720);
                    return return_v;
                }


                bool
                f_10453_30790_30839(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 30790, 30839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_31146_31222(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 31146, 31222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_31359_31374(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 31359, 31374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10453_31318_31375(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal(syntax, localSymbol, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 31318, 31375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 29284, 31387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 29284, 31387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void InsertAndFreePrologue<T>(ArrayBuilder<BoundStatement> result, ArrayBuilder<T> prologue) where T : BoundNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10453, 31399, 31951);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 31551, 31908);
                    foreach (var node in f_10453_31572_31580_I<T>(prologue))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 31551, 31908);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 31614, 31893) || true) && (node is BoundStatement stmt)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 31614, 31893);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 31687, 31704);

                            f_10453_31687_31703<T>(result, stmt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 31614, 31893);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 31614, 31893);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 31786, 31874);

                            f_10453_31786_31873<T>(result, f_10453_31797_31872<T>(node.Syntax, (BoundExpression)(BoundNode)node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 31614, 31893);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 31551, 31908);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 358);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 31924, 31940);

                f_10453_31924_31939<T>(
                            prologue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10453, 31399, 31951);

                int
                f_10453_31687_31703<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item) where T : BoundNode

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 31687, 31703);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10453_31797_31872<T>(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundNode
                expression) where T : BoundNode

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 31797, 31872);
                    return return_v;
                }


                int
                f_10453_31786_31873<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item) where T : BoundNode

                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 31786, 31873);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_10453_31572_31580_I<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                i) where T : BoundNode

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 31572, 31580);
                    return return_v;
                }


                int
                f_10453_31924_31939<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param) where T : BoundNode

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 31924, 31939);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 31399, 31951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 31399, 31951);
            }
        }

        private BoundNode IntroduceFrame(BoundNode node, Analysis.ClosureEnvironment env, Func<ArrayBuilder<BoundExpression>, ArrayBuilder<LocalSymbol>, BoundNode> F)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 32494, 36712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 32677, 32716);

                var
                frame = env.SynthesizedEnvironment
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 32730, 32868);

                var
                frameTypeParameters = f_10453_32756_32867(_currentTypeParameters.SelectAsArray(t => TypeWithAnnotations.Create(t)), 0, f_10453_32855_32866(frame))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 32882, 32956);

                NamedTypeSymbol
                frameType = frame.ConstructIfGeneric(frameTypeParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 32972, 33015);

                f_10453_32972_33014(frame.ScopeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 33029, 33196);

                LocalSymbol
                framePointer = f_10453_33056_33195(_topLevelMethod, TypeWithAnnotations.Create(frameType), SynthesizedLocalKind.LambdaDisplayClass, frame.ScopeSyntaxOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 33212, 33244);

                SyntaxNode
                syntax = node.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 33317, 33376);

                var
                prologue = f_10453_33332_33375()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 33392, 33945) || true) && ((object)f_10453_33404_33421(frame) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 33392, 33945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 33463, 33528);

                    MethodSymbol
                    constructor = f_10453_33490_33527(f_10453_33490_33507(frame), frameType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 33546, 33654);

                    f_10453_33546_33653(f_10453_33559_33652(frameType, f_10453_33588_33614(constructor), TypeCompareKind.ConsiderEverything2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 33674, 33930);

                    f_10453_33674_33929(
                                    prologue, f_10453_33687_33928(syntax, f_10453_33744_33797(syntax, framePointer, null, frameType), f_10453_33820_33895(syntax: syntax, constructor: constructor), frameType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 33392, 33945);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 33961, 34017);

                CapturedSymbolReplacement
                oldInnermostFrameProxy = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34031, 35459) || true) && ((object)_innermostFramePointer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 34031, 35459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34107, 34179);

                    f_10453_34107_34178(proxies, _innermostFramePointer, out oldInnermostFrameProxy);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34197, 35444) || true) && (env.CapturesParent)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 34197, 35444);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34261, 34380);

                        var
                        capturedFrame = f_10453_34281_34379(frame, _innermostFramePointer, ref _synthesizedFieldNameIdDispenser)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34402, 34462);

                        FieldSymbol
                        frameParent = f_10453_34428_34461(capturedFrame, frameType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34484, 34610);

                        BoundExpression
                        left = f_10453_34507_34609(syntax, f_10453_34536_34589(syntax, framePointer, null, frameType), frameParent, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34632, 34713);

                        BoundExpression
                        right = f_10453_34656_34712(this, syntax, f_10453_34676_34692(frameParent) as NamedTypeSymbol)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34735, 34824);

                        BoundExpression
                        assignment = f_10453_34764_34823(syntax, left, right, f_10453_34813_34822(left))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34846, 34871);

                        f_10453_34846_34870(prologue, assignment);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34895, 35296) || true) && (f_10453_34899_34924(CompilationState))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 34895, 35296);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 34974, 35023);

                            f_10453_34974_35022(f_10453_34987_35021(f_10453_34987_35005(capturedFrame)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 35113, 35150);

                            f_10453_35113_35149(frame, capturedFrame);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 35176, 35273);

                            f_10453_35176_35272(CompilationState.ModuleBuilderOpt, frame, f_10453_35242_35271(capturedFrame));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 34895, 35296);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 35320, 35425);

                        proxies[_innermostFramePointer] = f_10453_35354_35424(capturedFrame, isReusable: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 34197, 35444);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 34031, 35459);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 35638, 35793);
                    foreach (var variable in f_10453_35663_35684_I(env.CapturedVariables))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 35638, 35793);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 35718, 35778);

                        f_10453_35718_35777(this, syntax, variable, framePointer, prologue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 35638, 35793);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 35809, 35866);

                Symbol
                oldInnermostFramePointer = _innermostFramePointer
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 35880, 36001) || true) && (f_10453_35884_35914_M(!f_10453_35885_35902(framePointer).IsValueType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 35880, 36001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 35948, 35986);

                    _innermostFramePointer = framePointer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 35880, 36001);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36015, 36073);

                var
                addedLocals = f_10453_36033_36072()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36087, 36117);

                f_10453_36087_36116(addedLocals, framePointer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36131, 36171);

                f_10453_36131_36170(_framePointers, frame, framePointer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36187, 36225);

                var
                result = f_10453_36200_36224(F, prologue, addedLocals)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36241, 36291);

                _innermostFramePointer = oldInnermostFramePointer;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36307, 36671) || true) && ((object)_innermostFramePointer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 36307, 36671);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36383, 36656) || true) && (oldInnermostFrameProxy != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 36383, 36656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36459, 36516);

                        proxies[_innermostFramePointer] = oldInnermostFrameProxy;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 36383, 36656);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 36383, 36656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36598, 36637);

                        f_10453_36598_36636(proxies, _innermostFramePointer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 36383, 36656);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 36307, 36671);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36687, 36701);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 32494, 36712);

                int
                f_10453_32855_32866(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 32855, 32866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10453_32756_32867(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items, int
                start, int
                length)
                {
                    var return_v = ImmutableArray.Create(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 32756, 32867);
                    return return_v;
                }


                int
                f_10453_32972_33014(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 32972, 33014);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                f_10453_33056_33195(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind, syntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 33056, 33195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_33332_33375()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 33332, 33375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_33404_33421(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 33404, 33421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_33490_33507(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 33490, 33507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_33490_33527(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 33490, 33527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_33588_33614(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 33588, 33614);
                    return return_v;
                }


                bool
                f_10453_33559_33652(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 33559, 33652);
                    return return_v;
                }


                int
                f_10453_33546_33653(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 33546, 33653);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10453_33744_33797(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal(syntax, localSymbol, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 33744, 33797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10453_33820_33895(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression(syntax: syntax, constructor: constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 33820, 33895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10453_33687_33928(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 33687, 33928);
                    return return_v;
                }


                int
                f_10453_33674_33929(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 33674, 33929);
                    return 0;
                }


                bool
                f_10453_34107_34178(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 34107, 34178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                f_10453_34281_34379(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                frame, Microsoft.CodeAnalysis.CSharp.Symbol
                captured, ref int
                uniqueId)
                {
                    var return_v = LambdaCapturedVariable.Create(frame, captured, ref uniqueId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 34281, 34379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10453_34428_34461(Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 34428, 34461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10453_34536_34589(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal(syntax, localSymbol, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 34536, 34589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10453_34507_34609(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundLocal
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, fieldSymbol, constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 34507, 34609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_34676_34692(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 34676, 34692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_34656_34712(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                frameType)
                {
                    var return_v = this_param.FrameOfType(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?)frameType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 34656, 34712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10453_34813_34822(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 34813, 34822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10453_34764_34823(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator(syntax, left, right, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 34764, 34823);
                    return return_v;
                }


                int
                f_10453_34846_34870(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 34846, 34870);
                    return 0;
                }


                bool
                f_10453_34899_34924(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.Emitting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 34899, 34924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_34987_35005(Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 34987, 35005);
                    return return_v;
                }


                bool
                f_10453_34987_35021(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 34987, 35021);
                    return return_v;
                }


                int
                f_10453_34974_35022(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 34974, 35022);
                    return 0;
                }


                int
                f_10453_35113_35149(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param, Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                captured)
                {
                    this_param.AddHoistedField(captured);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 35113, 35149);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10453_35242_35271(Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 35242, 35271);
                    return return_v;
                }


                int
                f_10453_35176_35272(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                field)
                {
                    this_param.AddSynthesizedDefinition((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container, (Microsoft.Cci.IFieldDefinition)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 35176, 35272);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CapturedToFrameSymbolReplacement
                f_10453_35354_35424(Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                hoistedField, bool
                isReusable)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CapturedToFrameSymbolReplacement(hoistedField, isReusable: isReusable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 35354, 35424);
                    return return_v;
                }


                int
                f_10453_35718_35777(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                framePointer, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                prologue)
                {
                    this_param.InitVariableProxy(syntax, symbol, framePointer, prologue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 35718, 35777);
                    return 0;
                }


                Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10453_35663_35684_I(Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 35663, 35684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_35885_35902(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 35885, 35902);
                    return return_v;
                }


                bool
                f_10453_35884_35914_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 35884, 35914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_36033_36072()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 36033, 36072);
                    return return_v;
                }


                int
                f_10453_36087_36116(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 36087, 36116);
                    return 0;
                }


                int
                f_10453_36131_36170(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                key, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)key, (Microsoft.CodeAnalysis.CSharp.Symbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 36131, 36170);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10453_36200_36224(System.Func<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>, Microsoft.CodeAnalysis.CSharp.BoundNode>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arg1, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 36200, 36224);
                    return return_v;
                }


                bool
                f_10453_36598_36636(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 36598, 36636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 32494, 36712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 32494, 36712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InitVariableProxy(SyntaxNode syntax, Symbol symbol, LocalSymbol framePointer, ArrayBuilder<BoundExpression> prologue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 36724, 39260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36879, 36911);

                CapturedSymbolReplacement
                proxy
                = default(CapturedSymbolReplacement);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 36925, 39249) || true) && (f_10453_36929_36967(proxies, symbol, out proxy))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 36925, 39249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37001, 37023);

                    BoundExpression
                    value
                    = default(BoundExpression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37041, 38328);

                    switch (f_10453_37049_37060(symbol))
                    {

                        case SymbolKind.Parameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 37041, 38328);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37154, 37194);

                            var
                            parameter = (ParameterSymbol)symbol
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37220, 37251);

                            ParameterSymbol
                            parameterToUse
                            = default(ParameterSymbol);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37277, 37450) || true) && (!f_10453_37282_37338(_parameterMap, parameter, out parameterToUse))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 37277, 37450);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37396, 37423);

                                parameterToUse = parameter;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 37277, 37450);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37478, 37529);

                            value = f_10453_37486_37528(syntax, parameterToUse);
                            DynAbs.Tracing.TraceSender.TraceBreak(10453, 37555, 37561);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 37041, 38328);

                        case SymbolKind.Local:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 37041, 38328);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37633, 37665);

                            var
                            local = (LocalSymbol)symbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37691, 37842) || true) && (_assignLocals == null || (DynAbs.Tracing.TraceSender.Expression_False(10453, 37695, 37750) || !f_10453_37721_37750(_assignLocals, local)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 37691, 37842);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37808, 37815);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 37691, 37842);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37870, 37893);

                            LocalSymbol
                            localToUse
                            = default(LocalSymbol);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 37919, 38071) || true) && (!f_10453_37924_37967(localMap, local, out localToUse))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 37919, 38071);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 38025, 38044);

                                localToUse = local;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 37919, 38071);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 38099, 38165);

                            value = f_10453_38107_38164(syntax, localToUse, null, f_10453_38148_38163(localToUse));
                            DynAbs.Tracing.TraceSender.TraceBreak(10453, 38191, 38197);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 37041, 38328);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 37041, 38328);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 38255, 38309);

                            throw f_10453_38261_38308(f_10453_38296_38307(symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 37041, 38328);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 38348, 38462);

                    var
                    left = f_10453_38359_38461(proxy, syntax, frameType1 => new BoundLocal(syntax, framePointer, null, framePointer.Type))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 38480, 38561);

                    var
                    assignToProxy = f_10453_38500_38560(syntax, left, value, f_10453_38549_38559(value))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 38579, 39234) || true) && (f_10453_38583_38608(_currentMethod) == MethodKind.Constructor && (DynAbs.Tracing.TraceSender.Expression_True(10453, 38583, 38697) && symbol == f_10453_38669_38697(_currentMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10453, 38583, 38736) && !_seenBaseCall))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 38579, 39234);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 38999, 39044);

                        f_10453_38999_39043(_thisProxyInitDeferred == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 39066, 39105);

                        _thisProxyInitDeferred = assignToProxy;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 38579, 39234);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 38579, 39234);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 39187, 39215);

                        f_10453_39187_39214(prologue, assignToProxy);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 38579, 39234);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 36925, 39249);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 36724, 39260);

                bool
                f_10453_36929_36967(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 36929, 36967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10453_37049_37060(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 37049, 37060);
                    return return_v;
                }


                bool
                f_10453_37282_37338(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 37282, 37338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10453_37486_37528(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameterSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundParameter(syntax, parameterSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 37486, 37528);
                    return return_v;
                }


                bool
                f_10453_37721_37750(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 37721, 37750);
                    return return_v;
                }


                bool
                f_10453_37924_37967(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 37924, 37967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_38148_38163(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 38148, 38163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10453_38107_38164(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal(syntax, localSymbol, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 38107, 38164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10453_38296_38307(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 38296, 38307);
                    return return_v;
                }


                System.Exception
                f_10453_38261_38308(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 38261, 38308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_38359_38461(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 38359, 38461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10453_38549_38559(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 38549, 38559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10453_38500_38560(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator(syntax, left, right, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 38500, 38560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10453_38583_38608(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 38583, 38608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10453_38669_38697(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 38669, 38697);
                    return return_v;
                }


                int
                f_10453_38999_39043(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 38999, 39043);
                    return 0;
                }


                int
                f_10453_39187_39214(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 39187, 39214);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 36724, 39260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 36724, 39260);
            }
        }

        protected override BoundNode VisitUnhoistedParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 39305, 39726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 39403, 39440);

                ParameterSymbol
                replacementParameter
                = default(ParameterSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 39454, 39657) || true) && (f_10453_39458_39531(_parameterMap, f_10453_39484_39504(node), out replacementParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 39454, 39657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 39565, 39642);

                    return f_10453_39572_39641(node.Syntax, replacementParameter, f_10453_39626_39640(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 39454, 39657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 39673, 39715);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitUnhoistedParameter(node), 10453, 39680, 39714);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 39305, 39726);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10453_39484_39504(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 39484, 39504);
                    return return_v;
                }


                bool
                f_10453_39458_39531(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 39458, 39531);
                    return return_v;
                }


                bool
                f_10453_39626_39640(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 39626, 39640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10453_39572_39641(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameterSymbol, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundParameter(syntax, parameterSymbol, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 39572, 39641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 39305, 39726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 39305, 39726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThisReference(BoundThisReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 39738, 40708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 40516, 40697);

                return ((DynAbs.Tracing.TraceSender.Conditional_F1(10453, 40524, 40598) || ((_currentMethod == _topLevelMethod || (DynAbs.Tracing.TraceSender.Expression_False(10453, 40524, 40598) || f_10453_40561_40590(_topLevelMethod) == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10453, 40618, 40622)) || DynAbs.Tracing.TraceSender.Conditional_F3(10453, 40642, 40695))) ? node : f_10453_40642_40695(this, node.Syntax, f_10453_40685_40694(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 39738, 40708);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10453_40561_40590(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 40561, 40590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_40685_40694(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 40685, 40694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_40642_40695(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                frameClass)
                {
                    var return_v = this_param.FramePointer(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)frameClass);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 40642, 40695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 39738, 40708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 39738, 40708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBaseReference(BoundBaseReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 40720, 41125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 40814, 41070);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10453, 40821, 40968) || (((f_10453_40822_40846_M(!_currentMethod.IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10453, 40822, 40967) && f_10453_40850_40967(f_10453_40868_40897(_currentMethod), f_10453_40899_40929(_topLevelMethod), TypeCompareKind.ConsiderEverything2)))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10453, 40988, 40992)) || DynAbs.Tracing.TraceSender.Conditional_F3(10453, 41012, 41069))) ? node
                : f_10453_41012_41069(this, node.Syntax, f_10453_41038_41068(_topLevelMethod));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 40720, 41125);

                bool
                f_10453_40822_40846_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 40822, 40846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_40868_40897(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 40868, 40897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_40899_40929(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 40899, 40929);
                    return return_v;
                }


                bool
                f_10453_40850_40967(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 40850, 40967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_41038_41068(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 41038, 41068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_41012_41069(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                frameClass)
                {
                    var return_v = this_param.FramePointer(syntax, frameClass);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 41012, 41069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 40720, 41125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 40720, 41125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RemapLocalFunction(
                    SyntaxNode syntax,
                    MethodSymbol localFunc,
                    out BoundExpression receiver,
                    out MethodSymbol method,
                    ref ImmutableArray<BoundExpression> arguments,
                    ref ImmutableArray<RefKind> argRefKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 41299, 44797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 41620, 41683);

                f_10453_41620_41682(f_10453_41633_41653(localFunc) == MethodKind.LocalFunction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 41699, 41798);

                var
                function = f_10453_41714_41797(_analysis.ScopeTree, f_10453_41768_41796(localFunc))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 41812, 41866);

                var
                loweredSymbol = function.SynthesizedLoweredMethod
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42044, 42106);

                var
                frameCount = f_10453_42061_42105(loweredSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42120, 44258) || true) && (frameCount != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 42120, 44258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42173, 42208);

                    f_10453_42173_42207(f_10453_42186_42206_M(!arguments.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42376, 42471);

                    var
                    argumentsBuilder = f_10453_42399_42470(f_10453_42441_42469(loweredSymbol))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42489, 42526);

                    f_10453_42489_42525(argumentsBuilder, arguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42546, 42600);

                    var
                    start = f_10453_42558_42586(loweredSymbol) - frameCount
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42627, 42636);
                        for (int
        i = start
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42618, 43553) || true) && (i < f_10453_42642_42670(loweredSymbol))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42672, 42675)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 42618, 43553))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 42618, 43553);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42799, 42884);

                            var
                            frameType = (NamedTypeSymbol)f_10453_42832_42883(f_10453_42832_42864(f_10453_42832_42856(loweredSymbol)[i]))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42908, 42965);

                            f_10453_42908_42964(frameType is SynthesizedClosureEnvironment);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 42989, 43417) || true) && (f_10453_42993_43008(frameType) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 42989, 43417);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 43062, 43156);

                                var
                                typeParameters = f_10453_43083_43155(((SynthesizedClosureEnvironment)frameType))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 43182, 43237);

                                f_10453_43182_43236(typeParameters.Length == f_10453_43220_43235(frameType));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 43263, 43329);

                                var
                                subst = f_10453_43275_43328(f_10453_43275_43287(this), typeParameters)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 43355, 43394);

                                frameType = f_10453_43367_43393(frameType, subst);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 42989, 43417);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 43441, 43484);

                            var
                            frame = f_10453_43453_43483(this, syntax, frameType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 43506, 43534);

                            f_10453_43506_43533(argumentsBuilder, frame);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 936);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 936);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 43674, 43754);

                    var
                    refkindsBuilder = f_10453_43696_43753(f_10453_43730_43752(argumentsBuilder))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 43772, 44035) || true) && (f_10453_43776_43798_M(!argRefKinds.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 43772, 44035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 43840, 43878);

                        f_10453_43840_43877(refkindsBuilder, argRefKinds);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 43772, 44035);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 43772, 44035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 43960, 44016);

                        f_10453_43960_44015(refkindsBuilder, RefKind.None, arguments.Length);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 43772, 44035);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 44055, 44104);

                    f_10453_44055_44103(
                                    refkindsBuilder, RefKind.Ref, frameCount);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 44124, 44174);

                    arguments = f_10453_44136_44173(argumentsBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 44192, 44243);

                    argRefKinds = f_10453_44206_44242(refkindsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 42120, 44258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 44274, 44297);

                method = loweredSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 44311, 44344);

                NamedTypeSymbol
                constructedFrame
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 44360, 44786);

                f_10453_44360_44785(this, syntax, localFunc, f_10453_44486_44549(this, f_10453_44510_44548(localFunc)), f_10453_44591_44616(loweredSymbol), ref method, out receiver, out constructedFrame);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 41299, 44797);

                Microsoft.CodeAnalysis.MethodKind
                f_10453_41633_41653(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 41633, 41653);
                    return return_v;
                }


                int
                f_10453_41620_41682(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 41620, 41682);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_41768_41796(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 41768, 41796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                f_10453_41714_41797(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                treeRoot, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                functionSymbol)
                {
                    var return_v = Analysis.GetNestedFunctionInTree(treeRoot, functionSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 41714, 41797);
                    return return_v;
                }


                int
                f_10453_42061_42105(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ExtraSynthesizedParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 42061, 42105);
                    return return_v;
                }


                bool
                f_10453_42186_42206_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 42186, 42206);
                    return return_v;
                }


                int
                f_10453_42173_42207(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 42173, 42207);
                    return 0;
                }


                int
                f_10453_42441_42469(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 42441, 42469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_42399_42470(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 42399, 42470);
                    return return_v;
                }


                int
                f_10453_42489_42525(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 42489, 42525);
                    return 0;
                }


                int
                f_10453_42558_42586(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 42558, 42586);
                    return return_v;
                }


                int
                f_10453_42642_42670(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 42642, 42670);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10453_42832_42856(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 42832, 42856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_42832_42864(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 42832, 42864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_42832_42883(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 42832, 42883);
                    return return_v;
                }


                int
                f_10453_42908_42964(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 42908, 42964);
                    return 0;
                }


                int
                f_10453_42993_43008(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 42993, 43008);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10453_43083_43155(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.ConstructedFromTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 43083, 43155);
                    return return_v;
                }


                int
                f_10453_43220_43235(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 43220, 43235);
                    return return_v;
                }


                int
                f_10453_43182_43236(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 43182, 43236);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10453_43275_43287(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 43275, 43287);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10453_43275_43328(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                original)
                {
                    var return_v = this_param.SubstituteTypeParameters(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 43275, 43328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_43367_43393(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeArguments)
                {
                    var return_v = this_param.Construct((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>)typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 43367, 43393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_43453_43483(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                frameType)
                {
                    var return_v = this_param.FrameOfType(syntax, frameType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 43453, 43483);
                    return return_v;
                }


                int
                f_10453_43506_43533(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 43506, 43533);
                    return 0;
                }


                int
                f_10453_43730_43752(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 43730, 43752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                f_10453_43696_43753(int
                capacity)
                {
                    var return_v = ArrayBuilder<RefKind>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 43696, 43753);
                    return return_v;
                }


                bool
                f_10453_43776_43798_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 43776, 43798);
                    return return_v;
                }


                int
                f_10453_43840_43877(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 43840, 43877);
                    return 0;
                }


                int
                f_10453_43960_44015(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item, int
                count)
                {
                    this_param.AddMany(item, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 43960, 44015);
                    return 0;
                }


                int
                f_10453_44055_44103(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item, int
                count)
                {
                    this_param.AddMany(item, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 44055, 44103);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_44136_44173(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 44136, 44173);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10453_44206_44242(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 44206, 44242);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10453_44510_44548(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 44510, 44548);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10453_44486_44549(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.SubstituteTypeArguments(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 44486, 44549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClosureKind
                f_10453_44591_44616(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ClosureKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 44591, 44616);
                    return return_v;
                }


                int
                f_10453_44360_44785(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                originalMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsOpt, Microsoft.CodeAnalysis.CSharp.ClosureKind
                closureKind, ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                synthesizedMethod, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                constructedFrame)
                {
                    this_param.RemapLambdaOrLocalFunction(syntax, originalMethod, typeArgumentsOpt, closureKind, ref synthesizedMethod, out receiver, out constructedFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 44360, 44785);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 41299, 44797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 41299, 44797);
            }
        }

        private ImmutableArray<TypeWithAnnotations> SubstituteTypeArguments(ImmutableArray<TypeWithAnnotations> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 45577, 48078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 45720, 45759);

                f_10453_45720_45758(f_10453_45733_45757_M(!typeArguments.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 45775, 45870) || true) && (typeArguments.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 45775, 45870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 45834, 45855);

                    return typeArguments;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 45775, 45870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 46854, 46936);

                var
                builder = f_10453_46868_46935(typeArguments.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 46950, 48015);
                    foreach (var typeArg in f_10453_46974_46987_I(typeArguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 46950, 48015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 47021, 47052);

                        TypeWithAnnotations
                        oldTypeArg
                        = default(TypeWithAnnotations);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 47070, 47111);

                        TypeWithAnnotations
                        newTypeArg = typeArg
                        ;
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 47129, 47405);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 47172, 47196);

                                    oldTypeArg = newTypeArg;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 47218, 47271);

                                    newTypeArg = f_10453_47231_47270(f_10453_47231_47243(this), oldTypeArg);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 47129, 47405);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 47129, 47405) || true) && (!f_10453_47316_47403(oldTypeArg.Type, newTypeArg.Type, TypeCompareKind.ConsiderEverything))
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 47129, 47405);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 47129, 47405);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 47641, 47698);

                        f_10453_47641_47697((object)oldTypeArg.Type == newTypeArg.Type);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 47879, 47956);

                        f_10453_47879_47955(oldTypeArg.NullableAnnotation == newTypeArg.NullableAnnotation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 47976, 48000);

                        f_10453_47976_47999(
                                        builder, newTypeArg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 46950, 48015);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 1066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 1066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 48031, 48067);

                return f_10453_48038_48066(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 45577, 48078);

                bool
                f_10453_45733_45757_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 45733, 45757);
                    return return_v;
                }


                int
                f_10453_45720_45758(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 45720, 45758);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10453_46868_46935(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 46868, 46935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10453_47231_47243(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 47231, 47243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10453_47231_47270(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 47231, 47270);
                    return return_v;
                }


                bool
                f_10453_47316_47403(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 47316, 47403);
                    return return_v;
                }


                int
                f_10453_47641_47697(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 47641, 47697);
                    return 0;
                }


                int
                f_10453_47879_47955(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 47879, 47955);
                    return 0;
                }


                int
                f_10453_47976_47999(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 47976, 47999);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10453_46974_46987_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 46974, 46987);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10453_48038_48066(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 48038, 48066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 45577, 48078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 45577, 48078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RemapLambdaOrLocalFunction(
                    SyntaxNode syntax,
                    MethodSymbol originalMethod,
                    ImmutableArray<TypeWithAnnotations> typeArgumentsOpt,
                    ClosureKind closureKind,
                    ref MethodSymbol synthesizedMethod,
                    out BoundExpression receiver,
                    out NamedTypeSymbol constructedFrame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 48090, 51047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 48477, 48542);

                var
                translatedLambdaContainer = f_10453_48509_48541(synthesizedMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 48556, 48638);

                var
                containerAsFrame = translatedLambdaContainer as SynthesizedClosureEnvironment
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 48803, 48934);

                f_10453_48803_48933((typeArgumentsOpt.IsDefault && (DynAbs.Tracing.TraceSender.Expression_True(10453, 48817, 48878) && f_10453_48847_48878_M(!originalMethod.IsGenericMethod))) || (DynAbs.Tracing.TraceSender.Expression_False(10453, 48816, 48932) || (typeArgumentsOpt.Length == f_10453_48911_48931(originalMethod))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 48948, 49034);

                var
                totalTypeArgumentCount = (f_10453_48978_49001_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(containerAsFrame, 10453, 48978, 49001)?.Arity) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10453, 48978, 49006) ?? 0)) + f_10453_49010_49033(synthesizedMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 49048, 49218);

                var
                realTypeArguments = f_10453_49072_49217(_currentTypeParameters.SelectAsArray(t => TypeWithAnnotations.Create(t)), 0, totalTypeArgumentCount - f_10453_49196_49216(originalMethod))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 49232, 49375) || true) && (f_10453_49236_49263_M(!typeArgumentsOpt.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 49232, 49375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 49297, 49360);

                    realTypeArguments = realTypeArguments.Concat(typeArgumentsOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 49232, 49375);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 49391, 49957) || true) && ((object)containerAsFrame != null && (DynAbs.Tracing.TraceSender.Expression_True(10453, 49395, 49458) && f_10453_49431_49453(containerAsFrame) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 49391, 49957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 49492, 49589);

                    var
                    containerTypeArguments = f_10453_49521_49588(realTypeArguments, 0, f_10453_49565_49587(containerAsFrame))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 49607, 49743);

                    realTypeArguments = f_10453_49627_49742(realTypeArguments, f_10453_49668_49690(containerAsFrame), realTypeArguments.Length - f_10453_49719_49741(containerAsFrame));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 49761, 49831);

                    constructedFrame = f_10453_49780_49830(containerAsFrame, containerTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 49391, 49957);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 49391, 49957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 49897, 49942);

                    constructedFrame = translatedLambdaContainer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 49391, 49957);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 49973, 50038);

                synthesizedMethod = f_10453_49993_50037(synthesizedMethod, constructedFrame);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 50052, 50315) || true) && (f_10453_50056_50089(synthesizedMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 50052, 50315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 50123, 50190);

                    synthesizedMethod = f_10453_50143_50189(synthesizedMethod, realTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 50052, 50315);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 50052, 50315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 50256, 50300);

                    f_10453_50256_50299(realTypeArguments.Length == 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 50052, 50315);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 50454, 51036) || true) && (closureKind == ClosureKind.Singleton)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 50454, 51036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 50528, 50599);

                    var
                    field = f_10453_50540_50598(containerAsFrame.SingletonCache, constructedFrame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 50617, 50694);

                    receiver = f_10453_50628_50693(syntax, null, field, constantValueOpt: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 50454, 51036);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 50454, 51036);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 50728, 51036) || true) && (closureKind == ClosureKind.Static)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 50728, 51036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 50799, 50882);

                        receiver = f_10453_50810_50881(syntax, null, f_10453_50848_50880(synthesizedMethod));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 50728, 51036);
                    }

                    else // ThisOnly and General

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 50728, 51036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 50972, 51021);

                        receiver = f_10453_50983_51020(this, syntax, constructedFrame);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 50728, 51036);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 50454, 51036);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 48090, 51047);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_48509_48541(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 48509, 48541);
                    return return_v;
                }


                bool
                f_10453_48847_48878_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 48847, 48878);
                    return return_v;
                }


                int
                f_10453_48911_48931(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 48911, 48931);
                    return return_v;
                }


                int
                f_10453_48803_48933(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 48803, 48933);
                    return 0;
                }


                int?
                f_10453_48978_49001_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 48978, 49001);
                    return return_v;
                }


                int
                f_10453_49010_49033(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 49010, 49033);
                    return return_v;
                }


                int
                f_10453_49196_49216(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 49196, 49216);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10453_49072_49217(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items, int
                start, int
                length)
                {
                    var return_v = ImmutableArray.Create(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 49072, 49217);
                    return return_v;
                }


                bool
                f_10453_49236_49263_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 49236, 49263);
                    return return_v;
                }


                int
                f_10453_49431_49453(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 49431, 49453);
                    return return_v;
                }


                int
                f_10453_49565_49587(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 49565, 49587);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10453_49521_49588(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items, int
                start, int
                length)
                {
                    var return_v = ImmutableArray.Create(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 49521, 49588);
                    return return_v;
                }


                int
                f_10453_49668_49690(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 49668, 49690);
                    return return_v;
                }


                int
                f_10453_49719_49741(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 49719, 49741);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10453_49627_49742(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items, int
                start, int
                length)
                {
                    var return_v = ImmutableArray.Create(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 49627, 49742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_49780_49830(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 49780, 49830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_49993_50037(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 49993, 50037);
                    return return_v;
                }


                bool
                f_10453_50056_50089(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 50056, 50089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_50143_50189(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 50143, 50189);
                    return return_v;
                }


                int
                f_10453_50256_50299(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 50256, 50299);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10453_50540_50598(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 50540, 50598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10453_50628_50693(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess(syntax, receiver, fieldSymbol, constantValueOpt: constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 50628, 50693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_50848_50880(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 50848, 50880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10453_50810_50881(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
                aliasOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeExpression(syntax, aliasOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 50810, 50881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_50983_51020(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                frameType)
                {
                    var return_v = this_param.FrameOfType(syntax, frameType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 50983, 51020);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 48090, 51047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 48090, 51047);
            }
        }

        public override BoundNode VisitCall(BoundCall node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 51059, 53460);
                Microsoft.CodeAnalysis.CSharp.BoundExpression receiver = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol method = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 51135, 52241) || true) && (f_10453_51139_51161(f_10453_51139_51150(node)) == MethodKind.LocalFunction)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 51135, 52241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 51223, 51260);

                    var
                    args = f_10453_51234_51259(this, f_10453_51244_51258(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 51278, 51321);

                    var
                    argRefKinds = f_10453_51296_51320(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 51339, 51371);

                    var
                    type = f_10453_51350_51370(this, f_10453_51360_51369(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 51391, 51486);

                    f_10453_51391_51485(node.ArgsToParamsOpt.IsDefault, "should be done with argument reordering by now");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 51506, 51739);

                    f_10453_51506_51738(this, node.Syntax, f_10453_51581_51592(node), out receiver, out method, ref args, ref argRefKinds);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 51759, 52226);

                    return f_10453_51766_52225(node, receiver, method, args, f_10453_51887_51908(node), argRefKinds, f_10453_51965_51984(node), f_10453_52007_52020(node), f_10453_52043_52072(node), f_10453_52095_52115(node), f_10453_52138_52159(node), f_10453_52182_52197(node), type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 51135, 52241);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 52257, 52292);

                var
                visited = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCall(node), 10453, 52271, 52291)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 52306, 52404) || true) && (f_10453_52310_52322(visited) != BoundKind.Call)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 52306, 52404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 52374, 52389);

                    return visited;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 52306, 52404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 52420, 52455);

                var
                rewritten = (BoundCall)visited
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 52544, 53416) || true) && (!_seenBaseCall)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 52544, 53416);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 52596, 53401) || true) && (_currentMethod == _topLevelMethod && (DynAbs.Tracing.TraceSender.Expression_True(10453, 52600, 52668) && f_10453_52637_52668(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 52596, 53401);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 52710, 52731);

                        _seenBaseCall = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 52753, 53382) || true) && (_thisProxyInitDeferred != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 52753, 53382);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 53007, 53359);

                            return f_10453_53014_53358(syntax: node.Syntax, locals: ImmutableArray<LocalSymbol>.Empty, sideEffects: f_10453_53197_53246(rewritten), value: _thisProxyInitDeferred, type: f_10453_53343_53357(rewritten));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 52753, 53382);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 52596, 53401);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 52544, 53416);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 53432, 53449);

                return rewritten;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 51059, 53460);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_51139_51150(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 51139, 51150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10453_51139_51161(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 51139, 51161);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_51244_51258(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 51244, 51258);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_51234_51259(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 51234, 51259);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10453_51296_51320(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 51296, 51320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_51360_51369(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 51360, 51369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_51350_51370(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 51350, 51370);
                    return return_v;
                }


                int
                f_10453_51391_51485(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 51391, 51485);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_51581_51592(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 51581, 51592);
                    return return_v;
                }


                int
                f_10453_51506_51738(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                localFunc, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKinds)
                {
                    this_param.RemapLocalFunction(syntax, localFunc, out receiver, out method, ref arguments, ref argRefKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 51506, 51738);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10453_51887_51908(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 51887, 51908);
                    return return_v;
                }


                bool
                f_10453_51965_51984(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.IsDelegateCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 51965, 51984);
                    return return_v;
                }


                bool
                f_10453_52007_52020(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 52007, 52020);
                    return return_v;
                }


                bool
                f_10453_52043_52072(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 52043, 52072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10453_52095_52115(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 52095, 52115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10453_52138_52159(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 52138, 52159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10453_52182_52197(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 52182, 52197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10453_51766_52225(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                isDelegateCall, bool
                expanded, bool
                invokedAsExtensionMethod, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall, expanded, invokedAsExtensionMethod, argsToParamsOpt, defaultArguments, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 51766, 52225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10453_52310_52322(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 52310, 52322);
                    return return_v;
                }


                bool
                f_10453_52637_52668(Microsoft.CodeAnalysis.CSharp.BoundCall
                call)
                {
                    var return_v = call.IsConstructorInitializer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 52637, 52668);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_53197_53246(Microsoft.CodeAnalysis.CSharp.BoundCall
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 53197, 53246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_53343_53357(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 53343, 53357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10453_53014_53358(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence(syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 53014, 53358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 51059, 53460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 51059, 53460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundSequence RewriteSequence(BoundSequence node, ArrayBuilder<BoundExpression> prologue, ArrayBuilder<LocalSymbol> newLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 53472, 54149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 53631, 53669);

                f_10453_53631_53668(this, f_10453_53645_53656(node), newLocals);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 53685, 53896);
                    foreach (var effect in f_10453_53708_53724_I(f_10453_53708_53724(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 53685, 53896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 53758, 53812);

                        var
                        replacement = (BoundExpression)f_10453_53793_53811(this, effect)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 53830, 53881) || true) && (replacement != null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 53830, 53881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 53855, 53881);

                            f_10453_53855_53880(prologue, replacement);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 53830, 53881);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 53685, 53896);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 53912, 53967);

                var
                newValue = (BoundExpression)f_10453_53944_53966(this, f_10453_53955_53965(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 53981, 54021);

                var
                newType = f_10453_53995_54020(this, f_10453_54010_54019(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 54037, 54138);

                return f_10453_54044_54137(node, f_10453_54056_54086(newLocals), f_10453_54088_54117(prologue), newValue, newType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 53472, 54149);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_53645_53656(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 53645, 53656);
                    return return_v;
                }


                int
                f_10453_53631_53668(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                newLocals)
                {
                    this_param.RewriteLocals(locals, newLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 53631, 53668);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_53708_53724(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.SideEffects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 53708, 53724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10453_53793_53811(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 53793, 53811);
                    return return_v;
                }


                int
                f_10453_53855_53880(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 53855, 53880);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_53708_53724_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 53708, 53724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_53955_53965(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 53955, 53965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10453_53944_53966(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 53944, 53966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_54010_54019(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 54010, 54019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_53995_54020(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 53995, 54020);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_54056_54086(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 54056, 54086);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_54088_54117(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 54088, 54117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10453_54044_54137(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(locals, sideEffects, value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 54044, 54137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 53472, 54149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 53472, 54149);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBlock(BoundBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 54161, 54807);
                Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment frame = default(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 54347, 54796) || true) && (f_10453_54351_54391(_frames, node, out frame))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 54347, 54796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 54425, 54603);

                    return f_10453_54432_54602(this, node, frame, (ArrayBuilder<BoundExpression> prologue, ArrayBuilder<LocalSymbol> newLocals) =>
                                        RewriteBlock(node, prologue, newLocals));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 54347, 54796);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 54347, 54796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 54669, 54781);

                    return f_10453_54676_54780(this, node, f_10453_54695_54738(), f_10453_54740_54779());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 54347, 54796);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 54161, 54807);

                bool
                f_10453_54351_54391(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                key, out Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.BoundNode)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 54351, 54391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10453_54432_54602(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment
                env, System.Func<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>, Microsoft.CodeAnalysis.CSharp.BoundNode>
                F)
                {
                    var return_v = this_param.IntroduceFrame((Microsoft.CodeAnalysis.CSharp.BoundNode)node, env, F);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 54432, 54602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_54695_54738()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 54695, 54738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_54740_54779()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 54740, 54779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10453_54676_54780(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                prologue, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                newLocals)
                {
                    var return_v = this_param.RewriteBlock(node, prologue, newLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 54676, 54780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 54161, 54807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 54161, 54807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundBlock RewriteBlock(BoundBlock node, ArrayBuilder<BoundExpression> prologue, ArrayBuilder<LocalSymbol> newLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 54819, 55800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 54969, 55007);

                f_10453_54969_55006(this, f_10453_54983_54994(node), newLocals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55023, 55086);

                var
                newStatements = f_10453_55043_55085()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55102, 55226) || true) && (f_10453_55106_55120(prologue) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 55102, 55226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55158, 55211);

                    f_10453_55158_55210(newStatements, f_10453_55176_55209());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 55102, 55226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55242, 55289);

                f_10453_55242_55288(newStatements, prologue);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55305, 55584);
                    foreach (var statement in f_10453_55331_55346_I(f_10453_55331_55346(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 55305, 55584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55380, 55436);

                        var
                        replacement = (BoundStatement)f_10453_55414_55435(this, statement)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55454, 55569) || true) && (replacement != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 55454, 55569);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55519, 55550);

                            f_10453_55519_55549(newStatements, replacement);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 55454, 55569);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 55305, 55584);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55681, 55789);

                return f_10453_55688_55788(node, f_10453_55700_55730(newLocals), f_10453_55732_55751(node), f_10453_55753_55787(newStatements));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 54819, 55800);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_54983_54994(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 54983, 54994);
                    return return_v;
                }


                int
                f_10453_54969_55006(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                newLocals)
                {
                    this_param.RewriteLocals(locals, newLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 54969, 55006);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_55043_55085()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55043, 55085);
                    return return_v;
                }


                int
                f_10453_55106_55120(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 55106, 55120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10453_55176_55209()
                {
                    var return_v = BoundSequencePoint.CreateHidden();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55176, 55209);
                    return return_v;
                }


                int
                f_10453_55158_55210(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55158, 55210);
                    return 0;
                }


                int
                f_10453_55242_55288(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                result, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                prologue)
                {
                    InsertAndFreePrologue(result, prologue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55242, 55288);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_55331_55346(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 55331, 55346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10453_55414_55435(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55414, 55435);
                    return return_v;
                }


                int
                f_10453_55519_55549(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55519, 55549);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_55331_55346_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55331, 55346);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_55700_55730(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55700, 55730);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10453_55732_55751(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 55732, 55751);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_55753_55787(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55753, 55787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10453_55688_55788(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                localFunctions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, localFunctions, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55688, 55788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 54819, 55800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 54819, 55800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitScope(BoundScope node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 55812, 56374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55890, 55925);

                f_10453_55890_55924(f_10453_55903_55923_M(!node.Locals.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 55939, 55995);

                var
                newLocals = f_10453_55955_55994()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 56009, 56047);

                f_10453_56009_56046(this, f_10453_56023_56034(node), newLocals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 56063, 56107);

                var
                statements = f_10453_56080_56106(this, f_10453_56090_56105(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 56121, 56284) || true) && (f_10453_56125_56140(newLocals) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 56121, 56284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 56179, 56196);

                    f_10453_56179_56195(newLocals);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 56214, 56269);

                    return f_10453_56221_56268(node.Syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 56121, 56284);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 56300, 56363);

                return f_10453_56307_56362(node, f_10453_56319_56349(newLocals), statements);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 55812, 56374);

                bool
                f_10453_55903_55923_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 55903, 55923);
                    return return_v;
                }


                int
                f_10453_55890_55924(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55890, 55924);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_55955_55994()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 55955, 55994);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_56023_56034(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 56023, 56034);
                    return return_v;
                }


                int
                f_10453_56009_56046(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                newLocals)
                {
                    this_param.RewriteLocals(locals, newLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 56009, 56046);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_56090_56105(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 56090, 56105);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_56080_56106(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundStatement>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 56080, 56106);
                    return return_v;
                }


                int
                f_10453_56125_56140(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 56125, 56140);
                    return return_v;
                }


                int
                f_10453_56179_56195(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 56179, 56195);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10453_56221_56268(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStatementList(syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 56221, 56268);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_56319_56349(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 56319, 56349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundScope
                f_10453_56307_56362(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 56307, 56362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 55812, 56374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 55812, 56374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCatchBlock(BoundCatchBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 56386, 57088);
                Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment frame = default(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 56582, 57077) || true) && (f_10453_56586_56626(_frames, node, out frame))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 56582, 57077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 56660, 56884);

                    return f_10453_56667_56883(this, node, frame, (ArrayBuilder<BoundExpression> prologue, ArrayBuilder<LocalSymbol> newLocals) =>
                                    {
                                        return RewriteCatch(node, prologue, newLocals);
                                    });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 56582, 57077);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 56582, 57077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 56950, 57062);

                    return f_10453_56957_57061(this, node, f_10453_56976_57019(), f_10453_57021_57060());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 56582, 57077);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 56386, 57088);

                bool
                f_10453_56586_56626(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                key, out Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.BoundNode)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 56586, 56626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10453_56667_56883(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                node, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment
                env, System.Func<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>, Microsoft.CodeAnalysis.CSharp.BoundNode>
                F)
                {
                    var return_v = this_param.IntroduceFrame((Microsoft.CodeAnalysis.CSharp.BoundNode)node, env, F);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 56667, 56883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_56976_57019()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 56976, 57019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_57021_57060()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 57021, 57060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10453_56957_57061(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                node, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                prologue, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                newLocals)
                {
                    var return_v = this_param.RewriteCatch(node, prologue, newLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 56957, 57061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 56386, 57088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 56386, 57088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode RewriteCatch(BoundCatchBlock node, ArrayBuilder<BoundExpression> prologue, ArrayBuilder<LocalSymbol> newLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 57100, 59909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 57254, 57292);

                f_10453_57254_57291(this, f_10453_57268_57279(node), newLocals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 57306, 57364);

                var
                rewrittenCatchLocals = f_10453_57333_57363(newLocals)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 57673, 57721);

                BoundExpression
                rewrittenExceptionSource = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 57735, 57829);

                var
                rewrittenFilterPrologue = (BoundStatementList)f_10453_57785_57828(this, f_10453_57796_57827(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 57843, 57918);

                var
                rewrittenFilter = (BoundExpression)f_10453_57882_57917(this, f_10453_57893_57916(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 57932, 59246) || true) && (f_10453_57936_57959(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 57932, 59246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 58001, 58076);

                    rewrittenExceptionSource = (BoundExpression)f_10453_58045_58075(this, f_10453_58051_58074(node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 58094, 58500) || true) && (f_10453_58098_58112(prologue) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 58094, 58500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 58158, 58481);

                        rewrittenExceptionSource = f_10453_58185_58480(rewrittenExceptionSource.Syntax, f_10453_58287_58323(), f_10453_58350_58372(prologue), rewrittenExceptionSource, f_10453_58450_58479(rewrittenExceptionSource));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 58094, 58500);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 57932, 59246);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 57932, 59246);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 58534, 59246) || true) && (f_10453_58538_58552(prologue) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 58534, 59246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 58590, 58628);

                        f_10453_58590_58627(rewrittenFilter != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 58646, 58725);

                        var
                        prologueBuilder = f_10453_58668_58724(f_10453_58709_58723(prologue))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 58743, 58925);
                            foreach (var p in f_10453_58761_58769_I(prologue))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 58743, 58925);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 58811, 58906);

                                f_10453_58811_58905(prologueBuilder, new BoundExpressionStatement(p.Syntax, p) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10453, 58831, 58904) });
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 58743, 58925);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 183);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 183);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 58943, 59100) || true) && (rewrittenFilterPrologue != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 58943, 59100);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 59020, 59081);

                            f_10453_59020_59080(prologueBuilder, f_10453_59045_59079(rewrittenFilterPrologue));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 58943, 59100);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 59120, 59231);

                        rewrittenFilterPrologue = f_10453_59146_59230(rewrittenFilter.Syntax, f_10453_59193_59229(prologueBuilder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 58534, 59246);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 57932, 59246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 59294, 59310);

                f_10453_59294_59309(
                            // done with this.
                            prologue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 59456, 59517);

                var
                exceptionTypeOpt = f_10453_59479_59516(this, f_10453_59494_59515(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 59531, 59586);

                var
                rewrittenBlock = (BoundBlock)f_10453_59564_59585(this, f_10453_59575_59584(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 59602, 59898);

                return f_10453_59609_59897(node, rewrittenCatchLocals, rewrittenExceptionSource, exceptionTypeOpt, rewrittenFilterPrologue, rewrittenFilter, rewrittenBlock, f_10453_59865_59896(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 57100, 59909);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_57268_57279(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 57268, 57279);
                    return return_v;
                }


                int
                f_10453_57254_57291(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                newLocals)
                {
                    this_param.RewriteLocals(locals, newLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 57254, 57291);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_57333_57363(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 57333, 57363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                f_10453_57796_57827(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 57796, 57827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10453_57785_57828(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 57785, 57828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10453_57893_57916(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 57893, 57916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10453_57882_57917(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 57882, 57917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10453_57936_57959(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 57936, 57959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_58051_58074(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 58051, 58074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10453_58045_58075(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 58045, 58075);
                    return return_v;
                }


                int
                f_10453_58098_58112(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 58098, 58112);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_58287_58323()
                {
                    var return_v = ImmutableArray.Create<LocalSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 58287, 58323);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_58350_58372(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 58350, 58372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10453_58450_58479(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 58450, 58479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10453_58185_58480(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence(syntax, locals, sideEffects, value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 58185, 58480);
                    return return_v;
                }


                int
                f_10453_58538_58552(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 58538, 58552);
                    return return_v;
                }


                int
                f_10453_58590_58627(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 58590, 58627);
                    return 0;
                }


                int
                f_10453_58709_58723(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 58709, 58723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_58668_58724(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 58668, 58724);
                    return return_v;
                }


                int
                f_10453_58811_58905(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 58811, 58905);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_58761_58769_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 58761, 58769);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_59045_59079(Microsoft.CodeAnalysis.CSharp.BoundStatementList
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 59045, 59079);
                    return return_v;
                }


                int
                f_10453_59020_59080(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 59020, 59080);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_59193_59229(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 59193, 59229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10453_59146_59230(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStatementList(syntax, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 59146, 59230);
                    return return_v;
                }


                int
                f_10453_59294_59309(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 59294, 59309);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10453_59494_59515(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 59494, 59515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_59479_59516(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 59479, 59516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10453_59575_59584(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 59575, 59584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10453_59564_59585(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 59564, 59585);
                    return return_v;
                }


                bool
                f_10453_59865_59896(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.IsSynthesizedAsyncCatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 59865, 59896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10453_59609_59897(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionSourceOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                exceptionTypeOpt, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                exceptionFilterPrologueOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                exceptionFilterOpt, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                body, bool
                isSynthesizedAsyncCatchAll)
                {
                    var return_v = this_param.Update(locals, exceptionSourceOpt, exceptionTypeOpt, exceptionFilterPrologueOpt, exceptionFilterOpt, body, isSynthesizedAsyncCatchAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 59609, 59897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 57100, 59909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 57100, 59909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSequence(BoundSequence node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 59921, 60625);
                Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment frame = default(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 60113, 60614) || true) && (f_10453_60117_60157(_frames, node, out frame))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 60113, 60614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 60191, 60418);

                    return f_10453_60198_60417(this, node, frame, (ArrayBuilder<BoundExpression> prologue, ArrayBuilder<LocalSymbol> newLocals) =>
                                    {
                                        return RewriteSequence(node, prologue, newLocals);
                                    });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 60113, 60614);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 60113, 60614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 60484, 60599);

                    return f_10453_60491_60598(this, node, f_10453_60513_60556(), f_10453_60558_60597());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 60113, 60614);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 59921, 60625);

                bool
                f_10453_60117_60157(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                key, out Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.BoundNode)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 60117, 60157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10453_60198_60417(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                node, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment
                env, System.Func<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>, Microsoft.CodeAnalysis.CSharp.BoundNode>
                F)
                {
                    var return_v = this_param.IntroduceFrame((Microsoft.CodeAnalysis.CSharp.BoundNode)node, env, F);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 60198, 60417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_60513_60556()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 60513, 60556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_60558_60597()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 60558, 60597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10453_60491_60598(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                node, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                prologue, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                newLocals)
                {
                    var return_v = this_param.RewriteSequence(node, prologue, newLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 60491, 60598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 59921, 60625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 59921, 60625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitStatementList(BoundStatementList node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 60637, 61789);
                Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment frame = default(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 60951, 61778) || true) && (f_10453_60955_60995(_frames, node, out frame))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 60951, 61778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 61029, 61660);

                    return f_10453_61036_61659(this, node, frame, (ArrayBuilder<BoundExpression> prologue, ArrayBuilder<LocalSymbol> newLocals) =>
                                    {
                                        var newStatements = ArrayBuilder<BoundStatement>.GetInstance();
                                        InsertAndFreePrologue(newStatements, prologue);

                                        foreach (var s in node.Statements)
                                        {
                                            newStatements.Add((BoundStatement)this.Visit(s));
                                        }

                                        return new BoundBlock(node.Syntax, newLocals.ToImmutableAndFree(), newStatements.ToImmutableAndFree(), node.HasErrors);
                                    });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 60951, 61778);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 60951, 61778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 61726, 61763);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitStatementList(node), 10453, 61733, 61762);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 60951, 61778);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 60637, 61789);

                bool
                f_10453_60955_60995(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                key, out Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.BoundNode)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 60955, 60995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10453_61036_61659(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                node, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment
                env, System.Func<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>, Microsoft.CodeAnalysis.CSharp.BoundNode>
                F)
                {
                    var return_v = this_param.IntroduceFrame((Microsoft.CodeAnalysis.CSharp.BoundNode)node, env, F);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 61036, 61659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 60637, 61789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 60637, 61789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDelegateCreationExpression(BoundDelegateCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 61801, 63041);
                Microsoft.CodeAnalysis.CSharp.BoundExpression receiver = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol method = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 62060, 62210) || true) && (f_10453_62064_62082(f_10453_62064_62077(node)) == BoundKind.Lambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 62060, 62210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 62136, 62195);

                    return f_10453_62143_62194(this, f_10453_62180_62193(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 62060, 62210);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 62226, 62966) || true) && (f_10453_62230_62256_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10453_62230_62244(node), 10453, 62230, 62256)?.MethodKind) == MethodKind.LocalFunction)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 62226, 62966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 62318, 62375);

                    var
                    arguments = default(ImmutableArray<BoundExpression>)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 62393, 62444);

                    var
                    argRefKinds = default(ImmutableArray<RefKind>)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 62464, 62705);

                    f_10453_62464_62704(this, node.Syntax, f_10453_62539_62553(node), out receiver, out method, ref arguments, ref argRefKinds);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 62725, 62951);

                    return f_10453_62732_62950(node.Syntax, receiver, method, f_10453_62884_62906(node), f_10453_62929_62949(this, f_10453_62939_62948(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 62226, 62966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 62980, 63030);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDelegateCreationExpression(node), 10453, 62987, 63029);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 61801, 63041);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_62064_62077(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 62064, 62077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10453_62064_62082(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 62064, 62082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_62180_62193(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 62180, 62193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10453_62143_62194(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.RewriteLambdaConversion((Microsoft.CodeAnalysis.CSharp.BoundLambda)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 62143, 62194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10453_62230_62244(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 62230, 62244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind?
                f_10453_62230_62256_M(Microsoft.CodeAnalysis.MethodKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 62230, 62256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_62539_62553(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 62539, 62553);
                    return return_v;
                }


                int
                f_10453_62464_62704(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                localFunc, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKinds)
                {
                    this_param.RemapLocalFunction(syntax, localFunc, out receiver, out method, ref arguments, ref argRefKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 62464, 62704);
                    return 0;
                }


                bool
                f_10453_62884_62906(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 62884, 62906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_62939_62948(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 62939, 62948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_62929_62949(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 62929, 62949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                f_10453_62732_62950(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOpt, bool
                isExtensionMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression(syntax, argument, methodOpt, isExtensionMethod, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 62732, 62950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 61801, 63041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 61801, 63041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFunctionPointerLoad(BoundFunctionPointerLoad node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 63053, 64205);
                Microsoft.CodeAnalysis.CSharp.BoundExpression receiver = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol remappedMethod = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 63159, 64135) || true) && (f_10453_63163_63191(f_10453_63163_63180(node)) == MethodKind.LocalFunction)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 63159, 64135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 63253, 63340);

                    f_10453_63253_63339(f_10453_63266_63283(node) is { RequiresInstanceReceiver: false, IsStatic: true });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 63358, 63410);

                    ImmutableArray<BoundExpression>
                    arguments = default
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 63428, 63474);

                    ImmutableArray<RefKind>
                    argRefKinds = default
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 63494, 63767);

                    f_10453_63494_63766(this, node.Syntax, f_10453_63569_63586(node), out receiver, out remappedMethod, ref arguments, ref argRefKinds);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 63787, 64054);

                    f_10453_63787_64053(arguments.IsDefault && (DynAbs.Tracing.TraceSender.Expression_True(10453, 63800, 63874) && argRefKinds.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10453, 63800, 63949) && f_10453_63908_63921(receiver) == BoundKind.TypeExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10453, 63800, 64052) && remappedMethod is { RequiresInstanceReceiver: false, IsStatic: true }));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 64074, 64120);

                    return f_10453_64081_64119(node, remappedMethod, f_10453_64109_64118(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 63159, 64135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 64151, 64194);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFunctionPointerLoad(node), 10453, 64158, 64193);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 63053, 64205);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_63163_63180(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                this_param)
                {
                    var return_v = this_param.TargetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 63163, 63180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10453_63163_63191(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 63163, 63191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_63266_63283(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                this_param)
                {
                    var return_v = this_param.TargetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 63266, 63283);
                    return return_v;
                }


                int
                f_10453_63253_63339(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 63253, 63339);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_63569_63586(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                this_param)
                {
                    var return_v = this_param.TargetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 63569, 63586);
                    return return_v;
                }


                int
                f_10453_63494_63766(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                localFunc, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKinds)
                {
                    this_param.RemapLocalFunction(syntax, localFunc, out receiver, out method, ref arguments, ref argRefKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 63494, 63766);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10453_63908_63921(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 63908, 63921);
                    return return_v;
                }


                int
                f_10453_63787_64053(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 63787, 64053);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_64109_64118(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 64109, 64118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                f_10453_64081_64119(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                targetMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(targetMethod, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 64081, 64119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 63053, 64205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 63053, 64205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConversion(BoundConversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 64217, 65546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 64404, 64484);

                f_10453_64404_64483(_inExpressionLambda || (DynAbs.Tracing.TraceSender.Expression_False(10453, 64417, 64482) || conversion.Conversion.MethodSymbol is null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 64500, 64570);

                f_10453_64500_64569(f_10453_64513_64538(conversion) != ConversionKind.MethodGroup);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 64584, 65479) || true) && (f_10453_64588_64613(conversion) == ConversionKind.AnonymousFunction)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 64584, 65479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 64683, 64770);

                    var
                    result = (BoundExpression)f_10453_64713_64769(this, f_10453_64750_64768(conversion))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 64790, 65430) || true) && (_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10453, 64794, 64846) && f_10453_64817_64846(conversion)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 64790, 65430);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 64888, 65411);

                        result = f_10453_64897_65410(syntax: conversion.Syntax, operand: result, conversion: f_10453_65049_65070(conversion), isBaseConversion: false, @checked: false, explicitCastInCode: true, conversionGroupOpt: f_10453_65260_65289(conversion), constantValueOpt: f_10453_65334_65361(conversion), type: f_10453_65394_65409(conversion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 64790, 65430);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 65450, 65464);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 64584, 65479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 65495, 65535);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConversion(conversion), 10453, 65502, 65534);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 64217, 65546);

                int
                f_10453_64404_64483(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 64404, 64483);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10453_64513_64538(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 64513, 64538);
                    return return_v;
                }


                int
                f_10453_64500_64569(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 64500, 64569);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10453_64588_64613(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 64588, 64613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_64750_64768(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 64750, 64768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10453_64713_64769(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.RewriteLambdaConversion((Microsoft.CodeAnalysis.CSharp.BoundLambda)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 64713, 64769);
                    return return_v;
                }


                bool
                f_10453_64817_64846(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 64817, 64846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10453_65049_65070(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 65049, 65070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                f_10453_65260_65289(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionGroupOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 65260, 65289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10453_65334_65361(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 65334, 65361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_65394_65409(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 65394, 65409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10453_64897_65410(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isBaseConversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax: syntax, operand: operand, conversion: conversion, isBaseConversion: isBaseConversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 64897, 65410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 64217, 65546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 64217, 65546);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 65558, 66308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 65670, 65694);

                ClosureKind
                closureKind
                = default(ClosureKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 65708, 65750);

                NamedTypeSymbol
                translatedLambdaContainer
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 65764, 65811);

                SynthesizedClosureEnvironment
                containerAsFrame
                = default(SynthesizedClosureEnvironment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 65825, 65847);

                BoundNode
                lambdaScope
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 65861, 65886);

                DebugId
                topLevelMethodId
                = default(DebugId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 65900, 65917);

                DebugId
                lambdaId
                = default(DebugId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 65931, 66209);

                f_10453_65931_66208(this, node, out closureKind, out translatedLambdaContainer, out containerAsFrame, out lambdaScope, out topLevelMethodId, out lambdaId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 66225, 66297);

                return f_10453_66232_66296(node.Syntax, NoOpStatementFlavor.Default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 65558, 66308);

                Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                f_10453_65931_66208(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                node, out Microsoft.CodeAnalysis.CSharp.ClosureKind
                closureKind, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                translatedLambdaContainer, out Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                containerAsFrame, out Microsoft.CodeAnalysis.CSharp.BoundNode
                lambdaScope, out Microsoft.CodeAnalysis.CodeGen.DebugId
                topLevelMethodId, out Microsoft.CodeAnalysis.CodeGen.DebugId
                lambdaId)
                {
                    var return_v = this_param.RewriteLambdaOrLocalFunction((Microsoft.CodeAnalysis.CSharp.IBoundLambdaOrFunction)node, out closureKind, out translatedLambdaContainer, out containerAsFrame, out lambdaScope, out topLevelMethodId, out lambdaId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 65931, 66208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement
                f_10453_66232_66296(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.NoOpStatementFlavor
                flavor)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement(syntax, flavor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 66232, 66296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 65558, 66308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 65558, 66308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DebugId GetLambdaId(SyntaxNode syntax, ClosureKind closureKind, int closureOrdinal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 66320, 68735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 66436, 66465);

                f_10453_66436_66464(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 66481, 66517);

                SyntaxNode
                lambdaOrLambdaBodySyntax
                = default(SyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 66531, 66549);

                bool
                isLambdaBody
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 66565, 67764) || true) && (syntax is AnonymousFunctionExpressionSyntax anonymousFunction)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 66565, 67764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 66664, 66714);

                    lambdaOrLambdaBodySyntax = f_10453_66691_66713(anonymousFunction);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 66732, 66752);

                    isLambdaBody = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 66565, 67764);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 66565, 67764);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 66786, 67764) || true) && (syntax is LocalFunctionStatementSyntax localFunction)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 66786, 67764);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 66876, 66978);

                        lambdaOrLambdaBodySyntax = (SyntaxNode)f_10453_66915_66933(localFunction) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SyntaxNode?>(10453, 66903, 66977) ?? f_10453_66937_66977_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10453_66937_66965(localFunction), 10453, 66937, 66977)?.Expression));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 66998, 67281) || true) && (lambdaOrLambdaBodySyntax is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 66998, 67281);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67076, 67117);

                            lambdaOrLambdaBodySyntax = localFunction;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67139, 67160);

                            isLambdaBody = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 66998, 67281);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 66998, 67281);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67242, 67262);

                            isLambdaBody = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 66998, 67281);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 66786, 67764);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 66786, 67764);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67315, 67764) || true) && (f_10453_67319_67360(syntax))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 67315, 67764);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67435, 67469);

                            lambdaOrLambdaBodySyntax = syntax;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67487, 67508);

                            isLambdaBody = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67526, 67577);

                            f_10453_67526_67576(closureKind == ClosureKind.Singleton);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 67315, 67764);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 67315, 67764);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67677, 67711);

                            lambdaOrLambdaBodySyntax = syntax;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67729, 67749);

                            isLambdaBody = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 67315, 67764);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 66786, 67764);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 66565, 67764);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67780, 67866);

                f_10453_67780_67865(!isLambdaBody || (DynAbs.Tracing.TraceSender.Expression_False(10453, 67793, 67864) || f_10453_67810_67864(lambdaOrLambdaBodySyntax)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67953, 67970);

                DebugId
                lambdaId
                = default(DebugId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 67984, 68009);

                DebugId
                previousLambdaId
                = default(DebugId);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 68023, 68411) || true) && (slotAllocatorOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10453, 68027, 68154) && f_10453_68055_68154(slotAllocatorOpt, lambdaOrLambdaBodySyntax, isLambdaBody, out previousLambdaId)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 68023, 68411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 68188, 68216);

                    lambdaId = previousLambdaId;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 68023, 68411);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 68023, 68411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 68282, 68396);

                    lambdaId = f_10453_68293_68395(f_10453_68305_68334(_lambdaDebugInfoBuilder), f_10453_68336_68394(CompilationState.ModuleBuilderOpt));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 68023, 68411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 68427, 68591);

                int
                syntaxOffset = f_10453_68446_68590(_topLevelMethod, f_10453_68489_68552(lambdaOrLambdaBodySyntax), f_10453_68554_68589(lambdaOrLambdaBodySyntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 68605, 68694);

                f_10453_68605_68693(_lambdaDebugInfoBuilder, f_10453_68633_68692(syntaxOffset, lambdaId, closureOrdinal));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 68708, 68724);

                return lambdaId;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 66320, 68735);

                int
                f_10453_66436_66464(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 66436, 66464);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10453_66691_66713(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 66691, 66713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10453_66915_66933(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 66915, 66933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10453_66937_66965(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 66937, 66965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10453_66937_66977_M(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 66937, 66977);
                    return return_v;
                }


                bool
                f_10453_67319_67360(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = LambdaUtilities.IsQueryPairLambda(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 67319, 67360);
                    return return_v;
                }


                int
                f_10453_67526_67576(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 67526, 67576);
                    return 0;
                }


                bool
                f_10453_67810_67864(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = LambdaUtilities.IsLambdaBody(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 67810, 67864);
                    return return_v;
                }


                int
                f_10453_67780_67865(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 67780, 67865);
                    return 0;
                }


                bool
                f_10453_68055_68154(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                lambdaOrLambdaBodySyntax, bool
                isLambdaBody, out Microsoft.CodeAnalysis.CodeGen.DebugId
                lambdaId)
                {
                    var return_v = this_param.TryGetPreviousLambda(lambdaOrLambdaBodySyntax, isLambdaBody, out lambdaId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 68055, 68154);
                    return return_v;
                }


                int
                f_10453_68305_68334(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 68305, 68334);
                    return return_v;
                }


                int
                f_10453_68336_68394(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param)
                {
                    var return_v = this_param.CurrentGenerationOrdinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 68336, 68394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.DebugId
                f_10453_68293_68395(int
                ordinal, int
                generation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.DebugId(ordinal, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 68293, 68395);
                    return return_v;
                }


                int
                f_10453_68489_68552(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = LambdaUtilities.GetDeclaratorPosition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 68489, 68552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10453_68554_68589(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 68554, 68589);
                    return return_v;
                }


                int
                f_10453_68446_68590(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                localPosition, Microsoft.CodeAnalysis.SyntaxTree
                localTree)
                {
                    var return_v = this_param.CalculateLocalSyntaxOffset(localPosition, localTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 68446, 68590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo
                f_10453_68633_68692(int
                syntaxOffset, Microsoft.CodeAnalysis.CodeGen.DebugId
                lambdaId, int
                closureOrdinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo(syntaxOffset, lambdaId, closureOrdinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 68633, 68692);
                    return return_v;
                }


                int
                f_10453_68605_68693(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                this_param, Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 68605, 68693);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 66320, 68735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 66320, 68735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SynthesizedClosureMethod RewriteLambdaOrLocalFunction(
                    IBoundLambdaOrFunction node,
                    out ClosureKind closureKind,
                    out NamedTypeSymbol translatedLambdaContainer,
                    out SynthesizedClosureEnvironment containerAsFrame,
                    out BoundNode lambdaScope,
                    out DebugId topLevelMethodId,
                    out DebugId lambdaId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 68747, 72841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69161, 69263);

                Analysis.NestedFunction
                function = f_10453_69196_69262(_analysis.ScopeTree, f_10453_69250_69261(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69277, 69335);

                var
                synthesizedMethod = function.SynthesizedLoweredMethod
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69349, 69389);

                f_10453_69349_69388(synthesizedMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69405, 69449);

                closureKind = f_10453_69419_69448(synthesizedMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69463, 69524);

                translatedLambdaContainer = f_10453_69491_69523(synthesizedMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69538, 69616);

                containerAsFrame = translatedLambdaContainer as SynthesizedClosureEnvironment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69630, 69681);

                topLevelMethodId = f_10453_69649_69680(_analysis);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69695, 69733);

                lambdaId = synthesizedMethod.LambdaId;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69749, 70408) || true) && (function.ContainingEnvironmentOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 69749, 70408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69893, 69919);

                    BoundNode
                    tmpScope = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 69937, 70218);

                    f_10453_69937_70217(_analysis.ScopeTree, scope =>
                                    {
                                        if (scope.DeclaredEnvironment == function.ContainingEnvironmentOpt)
                                        {
                                            tmpScope = scope.BoundNode;
                                        }
                                    });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 70236, 70267);

                    f_10453_70236_70266(tmpScope != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 70285, 70308);

                    lambdaScope = tmpScope;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 69749, 70408);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 69749, 70408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 70374, 70393);

                    lambdaScope = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 69749, 70408);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 70424, 70545);

                f_10453_70424_70544(
                            CompilationState.ModuleBuilderOpt, translatedLambdaContainer, f_10453_70510_70543(synthesizedMethod));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 70561, 70736);
                    foreach (var parameter in f_10453_70587_70609_I(f_10453_70587_70609(f_10453_70587_70598(node))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 70561, 70736);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 70643, 70721);

                        f_10453_70643_70720(_parameterMap, parameter, f_10453_70672_70700(synthesizedMethod)[f_10453_70701_70718(parameter)]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 70561, 70736);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 1, 176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 1, 176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 70823, 70854);

                var
                oldMethod = _currentMethod
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 70868, 70905);

                var
                oldFrameThis = _currentFrameThis
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 70919, 70966);

                var
                oldTypeParameters = _currentTypeParameters
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 70980, 71034);

                var
                oldInnermostFramePointer = _innermostFramePointer
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71048, 71091);

                var
                oldTypeMap = _currentLambdaBodyTypeMap
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71105, 71147);

                var
                oldAddedStatements = _addedStatements
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71161, 71195);

                var
                oldAddedLocals = _addedLocals
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71209, 71233);

                _addedStatements = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71247, 71267);

                _addedLocals = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71332, 71367);

                _currentMethod = synthesizedMethod;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71381, 71841) || true) && (closureKind == ClosureKind.Static || (DynAbs.Tracing.TraceSender.Expression_False(10453, 71385, 71458) || closureKind == ClosureKind.Singleton))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 71381, 71841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71558, 71608);

                    _innermostFramePointer = _currentFrameThis = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 71381, 71841);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 71381, 71841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71674, 71726);

                    _currentFrameThis = f_10453_71694_71725(synthesizedMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71744, 71826);

                    f_10453_71744_71825(_framePointers, translatedLambdaContainer, out _innermostFramePointer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 71381, 71841);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 71880, 72045);

                _currentTypeParameters = ((DynAbs.Tracing.TraceSender.Conditional_F1(10453, 71906, 71933) || ((!(containerAsFrame is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10453, 71936, 72008)) || DynAbs.Tracing.TraceSender.Conditional_F3(10453, 72011, 72043))) ? containerAsFrame.TypeParameters.Concat(f_10453_71975_72007(synthesizedMethod)) : f_10453_72011_72043(synthesizedMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72059, 72113);

                _currentLambdaBodyTypeMap = f_10453_72087_72112(synthesizedMethod);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72129, 72386) || true) && (f_10453_72133_72142(node) is BoundBlock block)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 72129, 72386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72196, 72264);

                    var
                    body = f_10453_72207_72263(this, f_10453_72245_72262(this, block))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72282, 72307);

                    f_10453_72282_72306(body);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72325, 72371);

                    f_10453_72325_72370(this, synthesizedMethod, body);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 72129, 72386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72445, 72472);

                _currentMethod = oldMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72486, 72519);

                _currentFrameThis = oldFrameThis;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72533, 72576);

                _currentTypeParameters = oldTypeParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72590, 72640);

                _innermostFramePointer = oldInnermostFramePointer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72654, 72693);

                _currentLambdaBodyTypeMap = oldTypeMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72707, 72737);

                _addedLocals = oldAddedLocals;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72751, 72789);

                _addedStatements = oldAddedStatements;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72805, 72830);

                return synthesizedMethod;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 68747, 72841);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_69250_69261(Microsoft.CodeAnalysis.CSharp.IBoundLambdaOrFunction
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 69250, 69261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                f_10453_69196_69262(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                treeRoot, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                functionSymbol)
                {
                    var return_v = Analysis.GetNestedFunctionInTree(treeRoot, functionSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 69196, 69262);
                    return return_v;
                }


                int
                f_10453_69349_69388(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 69349, 69388);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ClosureKind
                f_10453_69419_69448(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ClosureKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 69419, 69448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10453_69491_69523(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 69491, 69523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.DebugId
                f_10453_69649_69680(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis
                this_param)
                {
                    var return_v = this_param.GetTopLevelMethodId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 69649, 69680);
                    return return_v;
                }


                int
                f_10453_69937_70217(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                treeRoot, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                action)
                {
                    Analysis.VisitScopeTree(treeRoot, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 69937, 70217);
                    return 0;
                }


                int
                f_10453_70236_70266(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 70236, 70266);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10453_70510_70543(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 70510, 70543);
                    return return_v;
                }


                int
                f_10453_70424_70544(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 70424, 70544);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10453_70587_70598(Microsoft.CodeAnalysis.CSharp.IBoundLambdaOrFunction
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 70587, 70598);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10453_70587_70609(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 70587, 70609);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10453_70672_70700(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 70672, 70700);
                    return return_v;
                }


                int
                f_10453_70701_70718(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 70701, 70718);
                    return return_v;
                }


                int
                f_10453_70643_70720(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 70643, 70720);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10453_70587_70609_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 70587, 70609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10453_71694_71725(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 71694, 71725);
                    return return_v;
                }


                bool
                f_10453_71744_71825(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 71744, 71825);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10453_71975_72007(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 71975, 72007);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10453_72011_72043(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 72011, 72043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10453_72087_72112(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 72087, 72112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10453_72133_72142(Microsoft.CodeAnalysis.CSharp.IBoundLambdaOrFunction
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 72133, 72142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10453_72245_72262(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.VisitBlock(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 72245, 72262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10453_72207_72263(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                body)
                {
                    var return_v = this_param.AddStatementsIfNeeded((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 72207, 72263);
                    return return_v;
                }


                int
                f_10453_72282_72306(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    CheckLocalsDefined((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 72282, 72306);
                    return 0;
                }


                int
                f_10453_72325_72370(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                method, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.AddSynthesizedMethod((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 72325, 72370);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 68747, 72841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 68747, 72841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddSynthesizedMethod(MethodSymbol method, BoundStatement body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 72853, 73344);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 72953, 73119) || true) && (_synthesizedMethods == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 72953, 73119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 73018, 73104);

                    _synthesizedMethods = f_10453_73040_73103();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 72953, 73119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 73135, 73333);

                f_10453_73135_73332(
                            _synthesizedMethods, f_10453_73177_73331(method, body, CompilationState.CurrentImportChain));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 72853, 73344);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                f_10453_73040_73103()
                {
                    var return_v = ArrayBuilder<TypeCompilationState.MethodWithBody>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 73040, 73103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody
                f_10453_73177_73331(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.ImportChain?
                importChain)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody(method, body, importChain);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 73177, 73331);
                    return return_v;
                }


                int
                f_10453_73135_73332(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 73135, 73332);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 72853, 73344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 72853, 73344);
            }
        }

        private BoundNode RewriteLambdaConversion(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 73356, 80158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 73440, 73488);

                var
                wasInExpressionLambda = _inExpressionLambda
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 73502, 73576);

                _inExpressionLambda = _inExpressionLambda || (DynAbs.Tracing.TraceSender.Expression_False(10453, 73524, 73575) || f_10453_73547_73575(f_10453_73547_73556(node)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 73592, 74138) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 73592, 74138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 73649, 73684);

                    var
                    newType = f_10453_73663_73683(this, f_10453_73673_73682(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 73702, 73745);

                    var
                    newBody = (BoundBlock)f_10453_73728_73744(this, f_10453_73734_73743(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 73763, 73864);

                    node = f_10453_73770_73863(node, f_10453_73782_73800(node), f_10453_73802_73813(node), newBody, f_10453_73824_73840(node), f_10453_73842_73853(node), newType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 73882, 74028);

                    var
                    result0 = (DynAbs.Tracing.TraceSender.Conditional_F1(10453, 73896, 73917) || ((wasInExpressionLambda && DynAbs.Tracing.TraceSender.Conditional_F2(10453, 73920, 73924)) || DynAbs.Tracing.TraceSender.Conditional_F3(10453, 73927, 74027))) ? node : f_10453_73927_74027(node, CompilationState, f_10453_73990_73997(), f_10453_73999_74013(), Diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74046, 74090);

                    _inExpressionLambda = wasInExpressionLambda;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74108, 74123);

                    return result0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 73592, 74138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74154, 74178);

                ClosureKind
                closureKind
                = default(ClosureKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74192, 74234);

                NamedTypeSymbol
                translatedLambdaContainer
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74248, 74295);

                SynthesizedClosureEnvironment
                containerAsFrame
                = default(SynthesizedClosureEnvironment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74309, 74331);

                BoundNode
                lambdaScope
                = default(BoundNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74345, 74370);

                DebugId
                topLevelMethodId
                = default(DebugId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74384, 74401);

                DebugId
                lambdaId
                = default(DebugId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74415, 74738);

                SynthesizedClosureMethod
                synthesizedMethod = f_10453_74460_74737(this, node, out closureKind, out translatedLambdaContainer, out containerAsFrame, out lambdaScope, out topLevelMethodId, out lambdaId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74754, 74804);

                MethodSymbol
                referencedMethod = synthesizedMethod
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74818, 74843);

                BoundExpression
                receiver
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74857, 74890);

                NamedTypeSymbol
                constructedFrame
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 74904, 75074);

                f_10453_74904_75073(this, node.Syntax, f_10453_74944_74955(node), default(ImmutableArray<TypeWithAnnotations>), closureKind, ref referencedMethod, out receiver, out constructedFrame);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 75220, 75264);

                TypeSymbol
                type = f_10453_75238_75263(this, f_10453_75253_75262(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 75577, 75803);

                BoundExpression
                result = f_10453_75602_75802(node.Syntax, receiver, referencedMethod, isExtensionMethod: false, type: type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 76092, 76294);

                var
                shouldCacheForStaticMethod = closureKind == ClosureKind.Singleton && (DynAbs.Tracing.TraceSender.Expression_True(10453, 76125, 76239) && f_10453_76182_76207(_currentMethod) != MethodKind.StaticConstructor) && (DynAbs.Tracing.TraceSender.Expression_True(10453, 76125, 76293) && f_10453_76260_76293_M(!referencedMethod.IsGenericMethod))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 76478, 76691);

                var
                shouldCacheInLoop = lambdaScope != null && (DynAbs.Tracing.TraceSender.Expression_True(10453, 76502, 76622) && lambdaScope != f_10453_76557_76612(_analysis.ScopeTree, f_10453_76602_76611(node)).BoundNode) && (DynAbs.Tracing.TraceSender.Expression_True(10453, 76502, 76690) && f_10453_76643_76690(node.Syntax, lambdaScope.Syntax))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 76707, 80117) || true) && (shouldCacheForStaticMethod || (DynAbs.Tracing.TraceSender.Expression_False(10453, 76711, 76758) || shouldCacheInLoop))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 76707, 80117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 76919, 77017);

                    var
                    F = f_10453_76927_77016(_currentMethod, node.Syntax, CompilationState, Diagnostics)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 77079, 77101);

                        BoundExpression
                        cache
                        = default(BoundExpression);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 77123, 79651) || true) && (shouldCacheForStaticMethod || (DynAbs.Tracing.TraceSender.Expression_False(10453, 77127, 77210) || shouldCacheInLoop && (DynAbs.Tracing.TraceSender.Expression_True(10453, 77157, 77210) && (object)containerAsFrame != null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 77123, 79651);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 77664, 77744);

                            var
                            cacheVariableType = f_10453_77688_77738(f_10453_77688_77712(containerAsFrame), f_10453_77728_77737(node)).Type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 77772, 78354);

                            var
                            cacheVariableName = f_10453_77796_78353((DynAbs.Tracing.TraceSender.Conditional_F1(10453, 78129, 78165) || ((                            // If we are generating the field into a display class created exclusively for the lambda the lambdaOrdinal itself is unique already, 
                                                                                                                                                                     // no need to include the top-level method ordinal in the field name.
                                                        (closureKind == ClosureKind.General) && DynAbs.Tracing.TraceSender.Conditional_F2(10453, 78168, 78170)) || DynAbs.Tracing.TraceSender.Conditional_F3(10453, 78173, 78197))) ? -1 : topLevelMethodId.Ordinal, topLevelMethodId.Generation, lambdaId.Ordinal, lambdaId.Generation)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 78382, 78586);

                            var
                            cacheField = f_10453_78399_78585(translatedLambdaContainer, cacheVariableType, cacheVariableName, _topLevelMethod, isReadOnly: false, isStatic: closureKind == ClosureKind.Singleton)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 78612, 78726);

                            f_10453_78612_78725(CompilationState.ModuleBuilderOpt, translatedLambdaContainer, f_10453_78698_78724(cacheField));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 78752, 78817);

                            cache = f_10453_78760_78816(F, receiver, f_10453_78778_78815(cacheField, constructedFrame));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 77123, 79651);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 77123, 79651);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79112, 79212);

                            var
                            cacheLocal = f_10453_79129_79211(F, type, kind: SynthesizedLocalKind.CachedAnonymousMethodDelegate)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79238, 79319) || true) && (_addedLocals == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 79238, 79319);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79264, 79319);

                                _addedLocals = f_10453_79279_79318();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 79238, 79319);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79345, 79374);

                            f_10453_79345_79373(_addedLocals, cacheLocal);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79400, 79492) || true) && (_addedStatements == null)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 79400, 79492);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79430, 79492);

                                _addedStatements = f_10453_79449_79491();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 79400, 79492);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79518, 79546);

                            cache = f_10453_79526_79545(F, cacheLocal);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79572, 79628);

                            f_10453_79572_79627(_addedStatements, f_10453_79593_79626(F, cache, f_10453_79613_79625(F, type)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 77123, 79651);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79675, 79741);

                        result = f_10453_79684_79740(F, cache, f_10453_79702_79739(F, cache, result));
                    }
                    catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10453, 79778, 80102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79879, 79910);

                        f_10453_79879_79909(Diagnostics, f_10453_79895_79908(ex));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 79932, 80083);

                        return f_10453_79939_80082(f_10453_79962_79970(F), LookupResultKind.Empty, ImmutableArray<Symbol>.Empty, f_10453_80026_80070(node), f_10453_80072_80081(node));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10453, 79778, 80102);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 76707, 80117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 80133, 80147);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 73356, 80158);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10453_73547_73556(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 73547, 73556);
                    return return_v;
                }


                bool
                f_10453_73547_73575(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                _type)
                {
                    var return_v = _type.IsExpressionTree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 73547, 73575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10453_73673_73682(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 73673, 73682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_73663_73683(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 73663, 73683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10453_73734_73743(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 73734, 73743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10453_73728_73744(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 73728, 73744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10453_73782_73800(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.UnboundLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 73782, 73800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10453_73802_73813(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 73802, 73813);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10453_73824_73840(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 73824, 73840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10453_73842_73853(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 73842, 73853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10453_73770_73863(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                unboundLambda, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                body, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(unboundLambda, symbol, body, diagnostics, binder, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 73770, 73863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10453_73990_73997()
                {
                    var return_v = TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 73990, 73997);
                    return return_v;
                }


                int
                f_10453_73999_74013()
                {
                    var return_v = RecursionDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 73999, 74013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10453_73927_74027(Microsoft.CodeAnalysis.CSharp.BoundLambda
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap, int
                recursionDepth, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ExpressionLambdaRewriter.RewriteLambda(node, compilationState, typeMap, recursionDepth, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 73927, 74027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SynthesizedClosureMethod
                f_10453_74460_74737(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node, out Microsoft.CodeAnalysis.CSharp.ClosureKind
                closureKind, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                translatedLambdaContainer, out Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                containerAsFrame, out Microsoft.CodeAnalysis.CSharp.BoundNode
                lambdaScope, out Microsoft.CodeAnalysis.CodeGen.DebugId
                topLevelMethodId, out Microsoft.CodeAnalysis.CodeGen.DebugId
                lambdaId)
                {
                    var return_v = this_param.RewriteLambdaOrLocalFunction((Microsoft.CodeAnalysis.CSharp.IBoundLambdaOrFunction)node, out closureKind, out translatedLambdaContainer, out containerAsFrame, out lambdaScope, out topLevelMethodId, out lambdaId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 74460, 74737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10453_74944_74955(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 74944, 74955);
                    return return_v;
                }


                int
                f_10453_74904_75073(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                originalMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsOpt, Microsoft.CodeAnalysis.CSharp.ClosureKind
                closureKind, ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                synthesizedMethod, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                constructedFrame)
                {
                    this_param.RemapLambdaOrLocalFunction(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)originalMethod, typeArgumentsOpt, closureKind, ref synthesizedMethod, out receiver, out constructedFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 74904, 75073);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10453_75253_75262(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 75253, 75262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10453_75238_75263(Microsoft.CodeAnalysis.CSharp.ClosureConversion
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 75238, 75263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                f_10453_75602_75802(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOpt, bool
                isExtensionMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression(syntax, argument, methodOpt, isExtensionMethod: isExtensionMethod, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 75602, 75802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10453_76182_76207(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 76182, 76207);
                    return return_v;
                }


                bool
                f_10453_76260_76293_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 76260, 76293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10453_76602_76611(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 76602, 76611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                f_10453_76557_76612(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                treeRoot, Microsoft.CodeAnalysis.CSharp.BoundBlock
                scopeNode)
                {
                    var return_v = Analysis.GetScopeParent(treeRoot, (Microsoft.CodeAnalysis.CSharp.BoundNode)scopeNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 76557, 76612);
                    return return_v;
                }


                bool
                f_10453_76643_76690(Microsoft.CodeAnalysis.SyntaxNode
                lambdaSyntax, Microsoft.CodeAnalysis.SyntaxNode
                scopeSyntax)
                {
                    var return_v = InLoopOrLambda(lambdaSyntax, scopeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 76643, 76690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10453_76927_77016(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory(topLevelMethod, node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 76927, 77016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10453_77688_77712(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 77688, 77712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10453_77728_77737(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 77728, 77737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10453_77688_77738(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 77688, 77738);
                    return return_v;
                }


                string
                f_10453_77796_78353(int
                methodOrdinal, int
                generation, int
                lambdaOrdinal, int
                lambdaGeneration)
                {
                    var return_v = GeneratedNames.MakeLambdaCacheFieldName(methodOrdinal, generation, lambdaOrdinal, lambdaGeneration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 77796, 78353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLambdaCacheFieldSymbol
                f_10453_78399_78585(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, bool
                isReadOnly, bool
                isStatic)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLambdaCacheFieldSymbol(containingType, type, name, topLevelMethod, isReadOnly: isReadOnly, isStatic: isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 78399, 78585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10453_78698_78724(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLambdaCacheFieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 78698, 78724);
                    return return_v;
                }


                int
                f_10453_78612_78725(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                field)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IFieldDefinition)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 78612, 78725);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10453_78778_78815(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLambdaCacheFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 78778, 78815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10453_78760_78816(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field(receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 78760, 78816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10453_79129_79211(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = this_param.SynthesizedLocal(type, kind: kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79129, 79211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10453_79279_79318()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79279, 79318);
                    return return_v;
                }


                int
                f_10453_79345_79373(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79345, 79373);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10453_79449_79491()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79449, 79491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10453_79526_79545(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79526, 79545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_79613_79625(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Null(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79613, 79625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10453_79593_79626(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79593, 79626);
                    return return_v;
                }


                int
                f_10453_79572_79627(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79572, 79627);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10453_79702_79739(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.AssignmentExpression(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79702, 79739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10453_79684_79740(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                right)
                {
                    var return_v = this_param.Coalesce(left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79684, 79740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10453_79895_79908(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 79895, 79908);
                    return return_v;
                }


                int
                f_10453_79879_79909(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79879, 79909);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10453_79962_79970(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 79962, 79970);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10453_80026_80070(Microsoft.CodeAnalysis.CSharp.BoundLambda
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 80026, 80070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10453_80072_80081(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 80072, 80081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10453_79939_80082(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 79939, 80082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 73356, 80158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 73356, 80158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool InLoopOrLambda(SyntaxNode lambdaSyntax, SyntaxNode scopeSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10453, 81391, 82241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 81499, 81535);

                var
                curSyntax = f_10453_81515_81534(lambdaSyntax)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 81549, 82201) || true) && (curSyntax != null && (DynAbs.Tracing.TraceSender.Expression_True(10453, 81556, 81601) && curSyntax != scopeSyntax))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 81549, 82201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 81635, 82137);

                        switch (f_10453_81643_81659(curSyntax))
                        {

                            case SyntaxKind.ForStatement:
                            case SyntaxKind.ForEachStatement:
                            case SyntaxKind.ForEachVariableStatement:
                            case SyntaxKind.WhileStatement:
                            case SyntaxKind.DoStatement:
                            case SyntaxKind.SimpleLambdaExpression:
                            case SyntaxKind.ParenthesizedLambdaExpression:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10453, 81635, 82137);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 82106, 82118);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 81635, 82137);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 82157, 82186);

                        curSyntax = f_10453_82169_82185(curSyntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10453, 81549, 82201);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10453, 81549, 82201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10453, 81549, 82201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 82217, 82230);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10453, 81391, 82241);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10453_81515_81534(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 81515, 81534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10453_81643_81659(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 81643, 81659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10453_82169_82185(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 82169, 82185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 81391, 82241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 81391, 82241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10453, 82253, 82488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10453, 82440, 82477);

                throw f_10453_82446_82476();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10453, 82253, 82488);

                System.Exception
                f_10453_82446_82476()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 82446, 82476);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10453, 82253, 82488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10453, 82253, 82488);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10453_5125_5175()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 5125, 5175);
            return return_v;
        }


        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
        f_10453_5356_5412()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 5356, 5412);
            return return_v;
        }


        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10453_5710_5751()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 5710, 5751);
            return return_v;
        }


        int
        f_10453_9273_9309(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 9273, 9309);
            return 0;
        }


        int
        f_10453_9324_9368(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 9324, 9368);
            return 0;
        }


        int
        f_10453_9383_9417(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 9383, 9417);
            return 0;
        }


        int
        f_10453_9432_9476(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 9432, 9476);
            return 0;
        }


        int
        f_10453_9491_9530(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 9491, 9530);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10453_9908_9929(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 9908, 9929);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10453_9972_9985()
        {
            var return_v = TypeMap.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 9972, 9985);
            return return_v;
        }


        Microsoft.CodeAnalysis.MethodKind
        f_10453_10150_10167(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.MethodKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10453, 10150, 10167);
            return return_v;
        }


        System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
        f_10453_10306_10346()
        {
            var return_v = ImmutableHashSet.CreateBuilder<Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 10306, 10346);
            return return_v;
        }


        int
        f_10453_10361_10534(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
        scope, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
        action)
        {
            Analysis.VisitNestedFunctions(scope, action);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 10361, 10534);
            return 0;
        }


        System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10453_10573_10602(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
        this_param)
        {
            var return_v = this_param.ToImmutable();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10453, 10573, 10602);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
        f_10453_9200_9216_C(Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10453, 8658, 10614);
            return return_v;
        }

    }
}
