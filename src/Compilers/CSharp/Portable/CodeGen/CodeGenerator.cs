// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.CodeGen
{
    internal sealed partial class CodeGenerator
    {
        private readonly MethodSymbol _method;

        private readonly SyntaxNode _methodBodySyntaxOpt;

        private readonly BoundStatement _boundBody;

        private readonly ILBuilder _builder;

        private readonly PEModuleBuilder _module;

        private readonly DiagnosticBag _diagnostics;

        private readonly ILEmitStyle _ilEmitStyle;

        private readonly bool _emitPdbSequencePoints;

        private readonly HashSet<LocalSymbol> _stackLocals;

        private ArrayBuilder<LocalDefinition> _expressionTemps;

        private int _tryNestingLevel;

        private readonly SynthesizedLocalOrdinalsDispenser _synthesizedLocalOrdinals;

        private int _uniqueNameId;

        private static readonly object s_returnLabel;

        private int _asyncCatchHandlerOffset;

        private ArrayBuilder<int> _asyncYieldPoints;

        private ArrayBuilder<int> _asyncResumePoints;

        private IndirectReturnState _indirectReturnState;

        private PooledDictionary<object, TextSpan> _savedSequencePoints;

        private enum IndirectReturnState : byte
        {
            NotNeeded = 0,  // did not see indirect returns
            Needed = 1,  // saw indirect return and need to emit return sequence
            Emitted = 2,  // return sequence has been emitted
        }

        private LocalDefinition _returnTemp;

        private bool _sawStackalloc;

        public CodeGenerator(
                    MethodSymbol method,
                    BoundStatement boundBody,
                    ILBuilder builder,
                    PEModuleBuilder moduleBuilder,
                    DiagnosticBag diagnostics,
                    OptimizationLevel optimizations,
                    bool emittingPdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10960, 3464, 6373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 765, 772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1021, 1041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1086, 1096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1134, 1142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1186, 1193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1235, 1247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1287, 1299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1332, 1354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1405, 1417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1696, 1712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1799, 1815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1879, 1946);
                this._synthesizedLocalOrdinals = f_10960_1907_1946(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 1969, 1982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 2149, 2178);
                this._asyncCatchHandlerOffset = -1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 2215, 2232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 2269, 2287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 2513, 2533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 2765, 2785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 3101, 3112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 3437, 3451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 682, 697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 3776, 3813);

                f_10960_3776_3812((object)method != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 3827, 3859);

                f_10960_3827_3858(boundBody != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 3873, 3903);

                f_10960_3873_3902(builder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 3917, 3953);

                f_10960_3917_3952(moduleBuilder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 3967, 4001);

                f_10960_3967_4000(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 4017, 4034);

                _method = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 4048, 4071);

                _boundBody = boundBody;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 4085, 4104);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 4118, 4142);

                _module = moduleBuilder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 4156, 4183);

                _diagnostics = diagnostics;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 4199, 5132) || true) && (f_10960_4203_4228_M(!method.GenerateDebugInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 4199, 5132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 4660, 4695);

                    _ilEmitStyle = ILEmitStyle.Release;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 4199, 5132);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 4199, 5132);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 4761, 5117) || true) && (optimizations == OptimizationLevel.Debug)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 4761, 5117);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 4847, 4880);

                        _ilEmitStyle = ILEmitStyle.Debug;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 4761, 5117);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 4761, 5117);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 4962, 5098);

                        _ilEmitStyle = (DynAbs.Tracing.TraceSender.Conditional_F1(10960, 4977, 4990) || ((f_10960_4977_4990(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10960, 5018, 5050)) || DynAbs.Tracing.TraceSender.Conditional_F3(10960, 5078, 5097))) ? ILEmitStyle.DebugFriendlyRelease : ILEmitStyle.Release;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 4761, 5117);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 4199, 5132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 5561, 5626);

                _emitPdbSequencePoints = emittingPdb && (DynAbs.Tracing.TraceSender.Expression_True(10960, 5586, 5625) && f_10960_5601_5625(method));

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 5678, 5868);

                    _boundBody = f_10960_5691_5867(boundBody, debugFriendly: _ilEmitStyle != ILEmitStyle.Release, stackLocals: out _stackLocals);
                }
                catch (BoundTreeVisitor.CancelledByStackGuardException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10960, 5897, 6071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 5988, 6015);

                    f_10960_5988_6014(ex, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 6033, 6056);

                    _boundBody = boundBody;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10960, 5897, 6071);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 6087, 6141);

                var
                sourceMethod = method as SourceMemberMethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 6155, 6257);

                (BlockSyntax blockBody, ArrowExpressionClauseSyntax expressionBody) = f_10960_6225_6245_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceMethod, 10960, 6225, 6245)?.Bodies) ?? (DynAbs.Tracing.TraceSender.Expression_Null<(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax blockBody, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax arrowBody)?>(10960, 6225, 6256) ?? default);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 6271, 6362);

                _methodBodySyntaxOpt = (SyntaxNode)blockBody ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SyntaxNode>(10960, 6294, 6361) ?? expressionBody ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax>(10960, 6319, 6361) ?? f_10960_6337_6361_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceMethod, 10960, 6337, 6361)?.SyntaxNode)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10960, 3464, 6373);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 3464, 6373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 3464, 6373);
            }
        }

        private bool IsDebugPlus()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 6385, 6496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 6436, 6485);

                return f_10960_6443_6484(f_10960_6443_6470(_module.Compilation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 6385, 6496);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10960_6443_6470(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 6443, 6470);
                    return return_v;
                }


                bool
                f_10960_6443_6484(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.DebugPlusMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 6443, 6484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 6385, 6496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 6385, 6496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsPeVerifyCompatEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 6547, 6593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 6550, 6593);
                return f_10960_6550_6593(_module.Compilation); DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 6547, 6593);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 6547, 6593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 6547, 6593);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10960_6550_6593(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            this_param)
            {
                var return_v = this_param.IsPeVerifyCompatEnabled;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 6550, 6593);
                return return_v;
            }

        }

        private LocalDefinition LazyReturnTemp
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 6669, 8628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 6705, 6730);

                    var
                    result = _returnTemp
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 6748, 8581) || true) && (result == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 6748, 8581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 6808, 6884);

                        f_10960_6808_6883(f_10960_6821_6841_M(!_method.ReturnsVoid), "returning something from void method?");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 6906, 7067);

                        var
                        slotConstraints = (DynAbs.Tracing.TraceSender.Conditional_F1(10960, 6928, 6959) || ((f_10960_6928_6943(_method) == RefKind.None
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10960, 6987, 7012)) || DynAbs.Tracing.TraceSender.Conditional_F3(10960, 7040, 7066))) ? LocalSlotConstraints.None
                        : LocalSlotConstraints.ByRef
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 7093, 7131);

                        var
                        bodySyntax = _methodBodySyntaxOpt
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 7153, 8517) || true) && (_ilEmitStyle == ILEmitStyle.Debug && (DynAbs.Tracing.TraceSender.Expression_True(10960, 7157, 7212) && bodySyntax != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 7153, 8517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 7262, 7390);

                            int
                            syntaxOffset = f_10960_7281_7389(_method, f_10960_7316_7365(bodySyntax), f_10960_7367_7388(bodySyntax))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 7416, 7553);

                            var
                            localSymbol = f_10960_7434_7552(_method, f_10960_7464_7497(_method), SynthesizedLocalKind.FunctionReturnValue, bodySyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 7581, 8318);

                            result = f_10960_7590_8317(_builder.LocalSlotManager, type: f_10960_7665_7726(_module, f_10960_7683_7699(localSymbol), bodySyntax, _diagnostics), symbol: localSymbol, name: null, kind: f_10960_7854_7881(localSymbol), id: f_10960_7916_7958(syntaxOffset, ordinal: 0), pdbAttributes: f_10960_8004_8047(f_10960_8004_8031(localSymbol)), constraints: slotConstraints, dynamicTransformFlags: ImmutableArray<bool>.Empty, tupleElementNames: ImmutableArray<string>.Empty, isSlotReusable: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 7153, 8517);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 7153, 8517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 8416, 8494);

                            result = f_10960_8425_8493(this, f_10960_8438_8456(_method), _boundBody.Syntax, slotConstraints);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 7153, 8517);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 8541, 8562);

                        _returnTemp = result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 6748, 8581);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 8599, 8613);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 6669, 8628);

                    bool
                    f_10960_6821_6841_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 6821, 6841);
                        return return_v;
                    }


                    int
                    f_10960_6808_6883(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 6808, 6883);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10960_6928_6943(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 6928, 6943);
                        return return_v;
                    }


                    int
                    f_10960_7316_7365(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = LambdaUtilities.GetDeclaratorPosition(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 7316, 7365);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10960_7367_7388(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 7367, 7388);
                        return return_v;
                    }


                    int
                    f_10960_7281_7389(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, int
                    localPosition, Microsoft.CodeAnalysis.SyntaxTree
                    localTree)
                    {
                        var return_v = this_param.CalculateLocalSyntaxOffset(localPosition, localTree);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 7281, 7389);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10960_7464_7497(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 7464, 7497);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    f_10960_7434_7552(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                    kind, Microsoft.CodeAnalysis.SyntaxNode
                    syntaxOpt)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal(containingMethodOpt, type, kind, syntaxOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 7434, 7552);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10960_7683_7699(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 7683, 7699);
                        return return_v;
                    }


                    Microsoft.Cci.ITypeReference
                    f_10960_7665_7726(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 7665, 7726);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SynthesizedLocalKind
                    f_10960_7854_7881(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    this_param)
                    {
                        var return_v = this_param.SynthesizedKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 7854, 7881);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                    f_10960_7916_7958(int
                    syntaxOffset, int
                    ordinal)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalDebugId(syntaxOffset, ordinal: ordinal);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 7916, 7958);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SynthesizedLocalKind
                    f_10960_8004_8031(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    this_param)
                    {
                        var return_v = this_param.SynthesizedKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 8004, 8031);
                        return return_v;
                    }


                    System.Reflection.Metadata.LocalVariableAttributes
                    f_10960_8004_8047(Microsoft.CodeAnalysis.SynthesizedLocalKind
                    kind)
                    {
                        var return_v = kind.PdbAttributes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 8004, 8047);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                    f_10960_7590_8317(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                    this_param, Microsoft.Cci.ITypeReference
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    symbol, string
                    name, Microsoft.CodeAnalysis.SynthesizedLocalKind
                    kind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                    id, System.Reflection.Metadata.LocalVariableAttributes
                    pdbAttributes, Microsoft.CodeAnalysis.LocalSlotConstraints
                    constraints, System.Collections.Immutable.ImmutableArray<bool>
                    dynamicTransformFlags, System.Collections.Immutable.ImmutableArray<string>
                    tupleElementNames, bool
                    isSlotReusable)
                    {
                        var return_v = this_param.DeclareLocal(type: type, symbol: (Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal)symbol, name: name, kind: kind, id: id, pdbAttributes: pdbAttributes, constraints: constraints, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames, isSlotReusable: isSlotReusable);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 7590, 8317);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10960_8438_8456(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 8438, 8456);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                    f_10960_8425_8493(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.SyntaxNode
                    syntaxNode, Microsoft.CodeAnalysis.LocalSlotConstraints
                    slotConstraints)
                    {
                        var return_v = this_param.AllocateTemp(type, syntaxNode, slotConstraints);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 8425, 8493);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 6606, 8639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 6606, 8639);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool IsStackLocal(LocalSymbol local, HashSet<LocalSymbol> stackLocalsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 8754, 8797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 8757, 8797);
                return f_10960_8757_8788_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(stackLocalsOpt, 10960, 8757, 8788)?.Contains(local)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10960, 8757, 8797) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 8754, 8797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 8754, 8797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 8754, 8797);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool?
            f_10960_8757_8788_I(bool?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 8757, 8788);
                return return_v;
            }

        }

        private bool IsStackLocal(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 8855, 8891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 8858, 8891);
                return f_10960_8858_8891(local, _stackLocals); DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 8855, 8891);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 8855, 8891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 8855, 8891);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10960_8858_8891(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
            local, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
            stackLocalsOpt)
            {
                var return_v = IsStackLocal(local, stackLocalsOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 8858, 8891);
                return return_v;
            }

        }

        public void Generate(out bool hasStackalloc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 8904, 9217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 8973, 8993);

                f_10960_8973_8992(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9007, 9038);

                hasStackalloc = _sawStackalloc;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9054, 9097);

                f_10960_9054_9096(_asyncCatchHandlerOffset < 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9111, 9151);

                f_10960_9111_9150(_asyncYieldPoints == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9165, 9206);

                f_10960_9165_9205(_asyncResumePoints == null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 8904, 9217);

                int
                f_10960_8973_8992(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.GenerateImpl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 8973, 8992);
                    return 0;
                }


                int
                f_10960_9054_9096(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 9054, 9096);
                    return 0;
                }


                int
                f_10960_9111_9150(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 9111, 9150);
                    return 0;
                }


                int
                f_10960_9165_9205(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 9165, 9205);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 8904, 9217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 8904, 9217);
            }
        }

        public void Generate(
                    out int asyncCatchHandlerOffset,
                    out ImmutableArray<int> asyncYieldPoints,
                    out ImmutableArray<int> asyncResumePoints,
                    out bool hasStackAlloc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 9229, 11314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9469, 9489);

                f_10960_9469_9488(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9503, 9534);

                hasStackAlloc = _sawStackalloc;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9548, 9592);

                f_10960_9548_9591(_asyncCatchHandlerOffset >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9608, 9691);

                asyncCatchHandlerOffset = f_10960_9634_9690(_builder, _asyncCatchHandlerOffset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9707, 9757);

                ArrayBuilder<int>
                yieldPoints = _asyncYieldPoints
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9771, 9823);

                ArrayBuilder<int>
                resumePoints = _asyncResumePoints
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9839, 9901);

                f_10960_9839_9900((yieldPoints == null) == (resumePoints == null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9917, 11303) || true) && (yieldPoints == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 9917, 11303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 9974, 10019);

                    asyncYieldPoints = ImmutableArray<int>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10037, 10083);

                    asyncResumePoints = ImmutableArray<int>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 9917, 11303);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 9917, 11303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10149, 10205);

                    var
                    yieldPointBuilder = f_10960_10173_10204()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10223, 10280);

                    var
                    resumePointBuilder = f_10960_10248_10279()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10298, 10324);

                    int
                    n = f_10960_10306_10323(yieldPoints)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10351, 10356);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10342, 11055) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10365, 10368)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 10342, 11055))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 10342, 11055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10410, 10475);

                            int
                            yieldOffset = f_10960_10428_10474(_builder, f_10960_10459_10473(yieldPoints, i))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10497, 10564);

                            int
                            resumeOffset = f_10960_10516_10563(_builder, f_10960_10547_10562(resumePoints, i))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10586, 10618);

                            f_10960_10586_10617(resumeOffset >= 0);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10846, 11036) || true) && (yieldOffset > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 10846, 11036);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10915, 10950);

                                f_10960_10915_10949(yieldPointBuilder, yieldOffset);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 10976, 11013);

                                f_10960_10976_11012(resumePointBuilder, resumeOffset);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 10846, 11036);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10960, 1, 714);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10960, 1, 714);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 11075, 11133);

                    asyncYieldPoints = f_10960_11094_11132(yieldPointBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 11151, 11211);

                    asyncResumePoints = f_10960_11171_11210(resumePointBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 11231, 11250);

                    f_10960_11231_11249(
                                    yieldPoints);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 11268, 11288);

                    f_10960_11268_11287(resumePoints);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 9917, 11303);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 9229, 11314);

                int
                f_10960_9469_9488(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.GenerateImpl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 9469, 9488);
                    return 0;
                }


                int
                f_10960_9548_9591(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 9548, 9591);
                    return 0;
                }


                int
                f_10960_9634_9690(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                ilMarker)
                {
                    var return_v = this_param.GetILOffsetFromMarker(ilMarker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 9634, 9690);
                    return return_v;
                }


                int
                f_10960_9839_9900(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 9839, 9900);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10960_10173_10204()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 10173, 10204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10960_10248_10279()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 10248, 10279);
                    return return_v;
                }


                int
                f_10960_10306_10323(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 10306, 10323);
                    return return_v;
                }


                int
                f_10960_10459_10473(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 10459, 10473);
                    return return_v;
                }


                int
                f_10960_10428_10474(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                ilMarker)
                {
                    var return_v = this_param.GetILOffsetFromMarker(ilMarker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 10428, 10474);
                    return return_v;
                }


                int
                f_10960_10547_10562(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>?
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 10547, 10562);
                    return return_v;
                }


                int
                f_10960_10516_10563(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                ilMarker)
                {
                    var return_v = this_param.GetILOffsetFromMarker(ilMarker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 10516, 10563);
                    return return_v;
                }


                int
                f_10960_10586_10617(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 10586, 10617);
                    return 0;
                }


                int
                f_10960_10915_10949(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 10915, 10949);
                    return 0;
                }


                int
                f_10960_10976_11012(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 10976, 11012);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10960_11094_11132(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 11094, 11132);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10960_11171_11210(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 11171, 11210);
                    return return_v;
                }


                int
                f_10960_11231_11249(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 11231, 11249);
                    return 0;
                }


                int
                f_10960_11268_11287(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>?
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 11268, 11287);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 9229, 11314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 9229, 11314);
            }
        }

        private void GenerateImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 11326, 12742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 11378, 11404);

                f_10960_11378_11403(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 11550, 11701) || true) && (_emitPdbSequencePoints && (DynAbs.Tracing.TraceSender.Expression_True(10960, 11554, 11608) && f_10960_11580_11608(_method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 11550, 11701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 11642, 11686);

                    f_10960_11642_11685(_builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 11550, 11701);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 11753, 11779);

                    f_10960_11753_11778(this, _boundBody);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 11799, 12229) || true) && (_indirectReturnState == IndirectReturnState.Needed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 11799, 12229);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12195, 12210);

                        f_10960_12195_12209(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 11799, 12229);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12249, 12361) || true) && (!f_10960_12254_12281(_diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 12249, 12361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12323, 12342);

                        f_10960_12323_12341(_builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 12249, 12361);
                    }
                }
                catch (EmitCancelledException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10960, 12390, 12510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12453, 12495);

                    f_10960_12453_12494(f_10960_12466_12493(_diagnostics));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10960, 12390, 12510);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12526, 12559);

                f_10960_12526_12558(
                            _synthesizedLocalOrdinals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12575, 12649);

                f_10960_12575_12648(!(f_10960_12590_12613_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_expressionTemps, 10960, 12590, 12613)?.Count) > 0), "leaking expression temps?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12663, 12688);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_expressionTemps, 10960, 12663, 12687)?.Free(), 10960, 12680, 12687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12702, 12731);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_savedSequencePoints, 10960, 12702, 12730)?.Free(), 10960, 12723, 12730);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 11326, 12742);

                int
                f_10960_11378_11403(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.SetInitialDebugDocument();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 11378, 11403);
                    return 0;
                }


                bool
                f_10960_11580_11608(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 11580, 11608);
                    return return_v;
                }


                int
                f_10960_11642_11685(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.DefineInitialHiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 11642, 11685);
                    return 0;
                }


                int
                f_10960_11753_11778(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.EmitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 11753, 11778);
                    return 0;
                }


                int
                f_10960_12195_12209(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.HandleReturn();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 12195, 12209);
                    return 0;
                }


                bool
                f_10960_12254_12281(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 12254, 12281);
                    return return_v;
                }


                int
                f_10960_12323_12341(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.Realize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 12323, 12341);
                    return 0;
                }


                bool
                f_10960_12466_12493(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 12466, 12493);
                    return return_v;
                }


                int
                f_10960_12453_12494(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 12453, 12494);
                    return 0;
                }


                int
                f_10960_12526_12558(Microsoft.CodeAnalysis.CodeGen.SynthesizedLocalOrdinalsDispenser
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 12526, 12558);
                    return 0;
                }


                int?
                f_10960_12590_12613_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 12590, 12613);
                    return return_v;
                }


                int
                f_10960_12575_12648(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 12575, 12648);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 11326, 12742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 11326, 12742);
            }
        }

        private void HandleReturn()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 12754, 13967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12806, 12840);

                f_10960_12806_12839(_builder, s_returnLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12856, 12915);

                f_10960_12856_12914(f_10960_12869_12888(_method) == (_returnTemp == null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 12931, 13631) || true) && (_emitPdbSequencePoints && (DynAbs.Tracing.TraceSender.Expression_True(10960, 12935, 12980) && f_10960_12961_12980_M(!_method.IsIterator)) && (DynAbs.Tracing.TraceSender.Expression_True(10960, 12935, 13000) && f_10960_12984_13000_M(!_method.IsAsync)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 12931, 13631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 13376, 13438);

                    BlockSyntax
                    blockSyntax = _methodBodySyntaxOpt as BlockSyntax
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 13456, 13616) || true) && (blockSyntax != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 13456, 13616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 13521, 13597);

                        f_10960_13521_13596(this, f_10960_13539_13561(blockSyntax), blockSyntax.CloseBraceToken.Span);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 13456, 13616);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 12931, 13631);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 13647, 13889) || true) && (_returnTemp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 13647, 13889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 13704, 13743);

                    f_10960_13704_13742(_builder, f_10960_13727_13741());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 13761, 13785);

                    f_10960_13761_13784(_builder, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 13647, 13889);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 13647, 13889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 13851, 13874);

                    f_10960_13851_13873(_builder, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 13647, 13889);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 13905, 13956);

                _indirectReturnState = IndirectReturnState.Emitted;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 12754, 13967);

                int
                f_10960_12806_12839(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 12806, 12839);
                    return 0;
                }


                bool
                f_10960_12869_12888(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 12869, 12888);
                    return return_v;
                }


                int
                f_10960_12856_12914(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 12856, 12914);
                    return 0;
                }


                bool
                f_10960_12961_12980_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 12961, 12980);
                    return return_v;
                }


                bool
                f_10960_12984_13000_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 12984, 13000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10960_13539_13561(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 13539, 13561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10960_13521_13596(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.EmitSequencePoint(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 13521, 13596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10960_13727_13741()
                {
                    var return_v = LazyReturnTemp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 13727, 13741);
                    return return_v;
                }


                int
                f_10960_13704_13742(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalLoad(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 13704, 13742);
                    return 0;
                }


                int
                f_10960_13761_13784(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, bool
                isVoid)
                {
                    this_param.EmitRet(isVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 13761, 13784);
                    return 0;
                }


                int
                f_10960_13851_13873(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, bool
                isVoid)
                {
                    this_param.EmitRet(isVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 13851, 13873);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 12754, 13967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 12754, 13967);
            }
        }

        private void EmitTypeReferenceToken(Cci.ITypeReference symbol, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 13979, 14153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 14089, 14142);

                f_10960_14089_14141(_builder, symbol, syntaxNode, _diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 13979, 14153);

                int
                f_10960_14089_14141(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.ITypeReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.IReference)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 14089, 14141);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 13979, 14153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 13979, 14153);
            }
        }

        private void EmitSymbolToken(TypeSymbol symbol, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 14165, 14359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 14260, 14348);

                f_10960_14260_14347(this, f_10960_14283_14334(_module, symbol, syntaxNode, _diagnostics), syntaxNode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 14165, 14359);

                Microsoft.Cci.ITypeReference
                f_10960_14283_14334(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 14283, 14334);
                    return return_v;
                }


                int
                f_10960_14260_14347(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.Cci.ITypeReference
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitTypeReferenceToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 14260, 14347);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 14165, 14359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 14165, 14359);
            }
        }

        private void EmitSymbolToken(MethodSymbol method, SyntaxNode syntaxNode, BoundArgListOperator optArgList, bool encodeAsRawDefinitionToken = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 14371, 14736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 14542, 14725);

                f_10960_14542_14724(_builder, f_10960_14561_14669(_module, method, syntaxNode, _diagnostics, optArgList, needDeclaration: encodeAsRawDefinitionToken), syntaxNode, _diagnostics, encodeAsRawDefinitionToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 14371, 14736);

                Microsoft.Cci.IMethodReference
                f_10960_14561_14669(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(methodSymbol, syntaxNodeOpt, diagnostics, optArgList, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 14561, 14669);
                    return return_v;
                }


                int
                f_10960_14542_14724(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IMethodReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                encodeAsRawToken)
                {
                    this_param.EmitToken((Microsoft.Cci.IReference)value, syntaxNode, diagnostics, encodeAsRawToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 14542, 14724);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 14371, 14736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 14371, 14736);
            }
        }

        private void EmitSymbolToken(FieldSymbol symbol, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 14748, 14953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 14844, 14942);

                f_10960_14844_14941(_builder, f_10960_14863_14914(_module, symbol, syntaxNode, _diagnostics), syntaxNode, _diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 14748, 14953);

                Microsoft.Cci.IFieldReference
                f_10960_14863_14914(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(fieldSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 14863, 14914);
                    return return_v;
                }


                int
                f_10960_14844_14941(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IFieldReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.IReference)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 14844, 14941);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 14748, 14953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 14748, 14953);
            }
        }

        private void EmitSignatureToken(FunctionPointerTypeSymbol symbol, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 14965, 15171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15078, 15160);

                f_10960_15078_15159(_builder, f_10960_15097_15132(f_10960_15097_15122(_module, symbol)), syntaxNode, _diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 14965, 15171);

                Microsoft.Cci.IFunctionPointerTypeReference
                f_10960_15097_15122(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                symbol)
                {
                    var return_v = this_param.Translate(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 15097, 15122);
                    return return_v;
                }


                Microsoft.Cci.ISignature
                f_10960_15097_15132(Microsoft.Cci.IFunctionPointerTypeReference
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 15097, 15132);
                    return return_v;
                }


                int
                f_10960_15078_15159(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.ISignature
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken(value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 15078, 15159);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 14965, 15171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 14965, 15171);
            }
        }

        private void EmitSequencePointStatement(BoundSequencePoint node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 15183, 16326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15272, 15304);

                SyntaxNode
                syntax = node.Syntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15318, 15693) || true) && (_emitPdbSequencePoints)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 15318, 15693);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15378, 15678) || true) && (syntax == null)
                    ) //Null syntax indicates hidden sequence point (not equivalent to WasCompilerGenerated)

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 15378, 15678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15525, 15551);

                        f_10960_15525_15550(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 15378, 15678);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 15378, 15678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15633, 15659);

                        f_10960_15633_15658(this, syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 15378, 15678);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 15318, 15693);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15709, 15754);

                BoundStatement
                statement = f_10960_15736_15753(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15768, 15796);

                int
                instructionsEmitted = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15810, 15952) || true) && (statement != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 15810, 15952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15865, 15937);

                    instructionsEmitted = f_10960_15887_15936(this, statement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 15810, 15952);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 15968, 16315) || true) && (instructionsEmitted == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10960, 15972, 16014) && syntax != null) && (DynAbs.Tracing.TraceSender.Expression_True(10960, 15972, 16051) && _ilEmitStyle == ILEmitStyle.Debug))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 15968, 16315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 16266, 16300);

                    f_10960_16266_16299(                // if there was no code emitted, then emit nop 
                                                        // otherwise this point could get associated with some random statement, possibly in a wrong scope
                                    _builder, ILOpCode.Nop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 15968, 16315);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 15183, 16326);

                int
                f_10960_15525_15550(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.EmitHiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 15525, 15550);
                    return 0;
                }


                int
                f_10960_15633_15658(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.EmitSequencePoint(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 15633, 15658);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10960_15736_15753(Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                this_param)
                {
                    var return_v = this_param.StatementOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 15736, 15753);
                    return return_v;
                }


                int
                f_10960_15887_15936(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = this_param.EmitStatementAndCountInstructions(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 15887, 15936);
                    return return_v;
                }


                int
                f_10960_16266_16299(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 16266, 16299);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 15183, 16326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 15183, 16326);
            }
        }

        private void EmitSequencePointStatement(BoundSequencePointWithSpan node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 16338, 17269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 16435, 16461);

                TextSpan
                span = f_10960_16451_16460(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 16475, 16625) || true) && (span != default(TextSpan) && (DynAbs.Tracing.TraceSender.Expression_True(10960, 16479, 16530) && _emitPdbSequencePoints))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 16475, 16625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 16564, 16610);

                    f_10960_16564_16609(this, f_10960_16587_16602(node), span);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 16475, 16625);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 16641, 16686);

                BoundStatement
                statement = f_10960_16668_16685(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 16700, 16728);

                int
                instructionsEmitted = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 16742, 16884) || true) && (statement != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 16742, 16884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 16797, 16869);

                    instructionsEmitted = f_10960_16819_16868(this, statement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 16742, 16884);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 16900, 17258) || true) && (instructionsEmitted == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10960, 16904, 16957) && span != default(TextSpan)) && (DynAbs.Tracing.TraceSender.Expression_True(10960, 16904, 16994) && _ilEmitStyle == ILEmitStyle.Debug))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 16900, 17258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17209, 17243);

                    f_10960_17209_17242(                // if there was no code emitted, then emit nop 
                                                        // otherwise this point could get associated with some random statement, possibly in a wrong scope
                                    _builder, ILOpCode.Nop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 16900, 17258);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 16338, 17269);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_10960_16451_16460(Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 16451, 16460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10960_16587_16602(Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 16587, 16602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10960_16564_16609(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.EmitSequencePoint(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 16564, 16609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10960_16668_16685(Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                this_param)
                {
                    var return_v = this_param.StatementOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 16668, 16685);
                    return return_v;
                }


                int
                f_10960_16819_16868(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = this_param.EmitStatementAndCountInstructions(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 16819, 16868);
                    return return_v;
                }


                int
                f_10960_17209_17242(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 17209, 17242);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 16338, 17269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 16338, 17269);
            }
        }

        private void EmitSavePreviousSequencePoint(BoundSavePreviousSequencePoint statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 17281, 18123);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17390, 17443) || true) && (!_emitPdbSequencePoints)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 17390, 17443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17436, 17443);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 17390, 17443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17459, 17529);

                ArrayBuilder<RawSequencePoint>
                sequencePoints = _builder.SeqPointsOpt
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17543, 17595) || true) && (sequencePoints is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 17543, 17595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17588, 17595);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 17543, 17595);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17620, 17648);

                    for (int
        i = f_10960_17624_17644(sequencePoints) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17611, 18112) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17658, 17661)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 17611, 18112))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 17611, 18112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17695, 17729);

                        var
                        span = sequencePoints[i].Span
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17747, 17831) || true) && (span == RawSequencePoint.HiddenSequencePointSpan)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 17747, 17831);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17822, 17831);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 17747, 17831);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 17927, 18001);

                        _savedSequencePoints ??= f_10960_17952_18000();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 18019, 18072);

                        f_10960_18019_18071(_savedSequencePoints, f_10960_18044_18064(statement), span);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 18090, 18097);

                        return;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10960, 1, 502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10960, 1, 502);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 17281, 18123);

                int
                f_10960_17624_17644(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.RawSequencePoint>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 17624, 17644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<object, Microsoft.CodeAnalysis.Text.TextSpan>
                f_10960_17952_18000()
                {
                    var return_v = PooledDictionary<object, TextSpan>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 17952, 18000);
                    return return_v;
                }


                object
                f_10960_18044_18064(Microsoft.CodeAnalysis.CSharp.BoundSavePreviousSequencePoint
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 18044, 18064);
                    return return_v;
                }


                int
                f_10960_18019_18071(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<object, Microsoft.CodeAnalysis.Text.TextSpan>
                this_param, object
                key, Microsoft.CodeAnalysis.Text.TextSpan
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 18019, 18071);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 17281, 18123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 17281, 18123);
            }
        }

        private void EmitRestorePreviousSequencePoint(BoundRestorePreviousSequencePoint node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 18135, 18504);
                Microsoft.CodeAnalysis.Text.TextSpan span = default(Microsoft.CodeAnalysis.Text.TextSpan);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 18245, 18278);

                f_10960_18245_18277(node.Syntax is { });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 18292, 18418) || true) && (_savedSequencePoints is null || (DynAbs.Tracing.TraceSender.Expression_False(10960, 18296, 18392) || !f_10960_18329_18392(_savedSequencePoints, f_10960_18362_18377(node), out span)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 18292, 18418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 18411, 18418);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 18292, 18418);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 18434, 18493);

                f_10960_18434_18492(this, f_10960_18463_18485(node.Syntax), span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 18135, 18504);

                int
                f_10960_18245_18277(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 18245, 18277);
                    return 0;
                }


                object
                f_10960_18362_18377(Microsoft.CodeAnalysis.CSharp.BoundRestorePreviousSequencePoint
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 18362, 18377);
                    return return_v;
                }


                bool
                f_10960_18329_18392(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<object, Microsoft.CodeAnalysis.Text.TextSpan>
                this_param, object
                key, out Microsoft.CodeAnalysis.Text.TextSpan
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 18329, 18392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10960_18463_18485(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 18463, 18485);
                    return return_v;
                }


                int
                f_10960_18434_18492(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    this_param.EmitStepThroughSequencePoint(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 18434, 18492);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 18135, 18504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 18135, 18504);
            }
        }

        private void EmitStepThroughSequencePoint(BoundStepThroughSequencePoint node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 18516, 18693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 18618, 18682);

                f_10960_18618_18681(this, f_10960_18647_18669(node.Syntax), f_10960_18671_18680(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 18516, 18693);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10960_18647_18669(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 18647, 18669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10960_18671_18680(Microsoft.CodeAnalysis.CSharp.BoundStepThroughSequencePoint
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 18671, 18680);
                    return return_v;
                }


                int
                f_10960_18618_18681(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    this_param.EmitStepThroughSequencePoint(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 18618, 18681);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 18516, 18693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 18516, 18693);
            }
        }

        private void EmitStepThroughSequencePoint(SyntaxTree syntaxTree, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 18705, 19378);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 18809, 18862) || true) && (!_emitPdbSequencePoints)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 18809, 18862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 18855, 18862);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 18809, 18862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 18878, 18903);

                var
                label = f_10960_18890_18902()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 19076, 19131);

                f_10960_19076_19130(            // The IL builder is eager to discard unreachable code, so
                                                // we fool it by branching on a condition that is always true at runtime.
                            _builder, f_10960_19103_19129(true));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 19145, 19189);

                f_10960_19145_19188(_builder, ILOpCode.Brtrue, label);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 19203, 19239);

                f_10960_19203_19238(this, syntaxTree, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 19253, 19287);

                f_10960_19253_19286(_builder, ILOpCode.Nop);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 19301, 19327);

                f_10960_19301_19326(_builder, label);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 19341, 19367);

                f_10960_19341_19366(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 18705, 19378);

                object
                f_10960_18890_18902()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 18890, 18902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10960_19103_19129(bool
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 19103, 19129);
                    return return_v;
                }


                int
                f_10960_19076_19130(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    this_param.EmitConstantValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 19076, 19130);
                    return 0;
                }


                int
                f_10960_19145_19188(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 19145, 19188);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10960_19203_19238(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.EmitSequencePoint(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 19203, 19238);
                    return return_v;
                }


                int
                f_10960_19253_19286(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 19253, 19286);
                    return 0;
                }


                int
                f_10960_19301_19326(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 19301, 19326);
                    return 0;
                }


                int
                f_10960_19341_19366(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.EmitHiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 19341, 19366);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 18705, 19378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 18705, 19378);
            }
        }

        private void SetInitialDebugDocument()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 19390, 20229);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 19453, 20218) || true) && (_emitPdbSequencePoints && (DynAbs.Tracing.TraceSender.Expression_True(10960, 19457, 19511) && _methodBodySyntaxOpt != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 19453, 20218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 20137, 20203);

                    f_10960_20137_20202(                // If methodBlockSyntax is available (i.e. we're in a SourceMethodSymbol), then
                                                        // provide the IL builder with our best guess at the appropriate debug document.
                                                        // If we don't and this is hidden sequence point precedes all non-hidden sequence
                                                        // points, then the IL Builder will drop the sequence point for lack of a document.
                                                        // This negatively impacts the scenario where we insert hidden sequence points at
                                                        // the beginnings of methods so that step-into (F11) will handle them correctly.
                                    _builder, f_10960_20170_20201(_methodBodySyntaxOpt));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 19453, 20218);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 19390, 20229);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10960_20170_20201(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 20170, 20201);
                    return return_v;
                }


                int
                f_10960_20137_20202(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                initialSequencePointTree)
                {
                    this_param.SetInitialDebugDocument(initialSequencePointTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 20137, 20202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 19390, 20229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 19390, 20229);
            }
        }

        private void EmitHiddenSequencePoint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 20241, 20403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 20304, 20341);

                f_10960_20304_20340(_emitPdbSequencePoints);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 20355, 20392);

                f_10960_20355_20391(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 20241, 20403);

                int
                f_10960_20304_20340(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 20304, 20340);
                    return 0;
                }


                int
                f_10960_20355_20391(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.DefineHiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 20355, 20391);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 20241, 20403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 20241, 20403);
            }
        }

        private void EmitSequencePoint(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 20415, 20550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 20489, 20539);

                f_10960_20489_20538(this, f_10960_20507_20524(syntax), f_10960_20526_20537(syntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 20415, 20550);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10960_20507_20524(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 20507, 20524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10960_20526_20537(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 20526, 20537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10960_20489_20538(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.EmitSequencePoint(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 20489, 20538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 20415, 20550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 20415, 20550);
            }
        }

        private TextSpan EmitSequencePoint(SyntaxTree syntaxTree, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 20562, 20843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 20659, 20692);

                f_10960_20659_20691(syntaxTree != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 20706, 20743);

                f_10960_20706_20742(_emitPdbSequencePoints);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 20759, 20806);

                f_10960_20759_20805(
                            _builder, syntaxTree, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 20820, 20832);

                return span;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 20562, 20843);

                int
                f_10960_20659_20691(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 20659, 20691);
                    return 0;
                }


                int
                f_10960_20706_20742(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 20706, 20742);
                    return 0;
                }


                int
                f_10960_20759_20805(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    this_param.DefineSequencePoint(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 20759, 20805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 20562, 20843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 20562, 20843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddExpressionTemp(LocalDefinition temp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 20855, 21444);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21009, 21081) || true) && (temp == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 21009, 21081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21059, 21066);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 21009, 21081);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21097, 21156);

                ArrayBuilder<LocalDefinition>
                exprTemps = _expressionTemps
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21170, 21343) || true) && (exprTemps == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 21170, 21343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21225, 21281);

                    exprTemps = f_10960_21237_21280();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21299, 21328);

                    _expressionTemps = exprTemps;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 21170, 21343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21359, 21399);

                f_10960_21359_21398(!f_10960_21373_21397(exprTemps, temp));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21413, 21433);

                f_10960_21413_21432(exprTemps, temp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 20855, 21444);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                f_10960_21237_21280()
                {
                    var return_v = ArrayBuilder<LocalDefinition>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 21237, 21280);
                    return return_v;
                }


                bool
                f_10960_21373_21397(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 21373, 21397);
                    return return_v;
                }


                int
                f_10960_21359_21398(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 21359, 21398);
                    return 0;
                }


                int
                f_10960_21413_21432(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 21413, 21432);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 20855, 21444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 20855, 21444);
            }
        }

        private void ReleaseExpressionTemps()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10960, 21456, 21936);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21518, 21925) || true) && (f_10960_21522_21545_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_expressionTemps, 10960, 21522, 21545)?.Count) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 21518, 21925);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21693, 21723);
                        // release in reverse order to keep same temps on top of the temp stack if possible
                        for (int
        i = f_10960_21697_21719(_expressionTemps) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21684, 21865) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21733, 21736)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 21684, 21865))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10960, 21684, 21865);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21778, 21809);

                            var
                            temp = f_10960_21789_21808(_expressionTemps, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21831, 21846);

                            f_10960_21831_21845(this, temp);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10960, 1, 182);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10960, 1, 182);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 21885, 21910);

                    f_10960_21885_21909(
                                    _expressionTemps);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10960, 21518, 21925);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10960, 21456, 21936);

                int?
                f_10960_21522_21545_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 21522, 21545);
                    return return_v;
                }


                int
                f_10960_21697_21719(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 21697, 21719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10960_21789_21808(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 21789, 21808);
                    return return_v;
                }


                int
                f_10960_21831_21845(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 21831, 21845);
                    return 0;
                }


                int
                f_10960_21885_21909(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.LocalDefinition>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 21885, 21909);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10960, 21456, 21936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 21456, 21936);
            }
        }

        static CodeGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10960, 675, 21943);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10960, 2096, 2124);
            s_returnLabel = f_10960_2112_2124(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 9623, 10019);
            s_compOpCodes = new ILOpCode[]
                    {
            //  <            <=               >                >=
            ILOpCode.Clt,    ILOpCode.Cgt,    ILOpCode.Cgt,    ILOpCode.Clt,     // Signed
            ILOpCode.Clt_un, ILOpCode.Cgt_un, ILOpCode.Cgt_un, ILOpCode.Clt_un,  // Unsigned
            ILOpCode.Clt,    ILOpCode.Cgt_un, ILOpCode.Cgt,    ILOpCode.Clt_un,  // Float
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 10188, 10213);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 10261, 10959);
            s_condJumpOpCodes = new ILOpCode[]
                    {
            //  <            <=               >                >=
            ILOpCode.Blt,    ILOpCode.Ble,    ILOpCode.Bgt,    ILOpCode.Bge,     // Signed
            ILOpCode.Bge,    ILOpCode.Bgt,    ILOpCode.Ble,    ILOpCode.Blt,     // Signed Invert
            ILOpCode.Blt_un, ILOpCode.Ble_un, ILOpCode.Bgt_un, ILOpCode.Bge_un,  // Unsigned
            ILOpCode.Bge_un, ILOpCode.Bgt_un, ILOpCode.Ble_un, ILOpCode.Blt_un,  // Unsigned Invert
            ILOpCode.Blt,    ILOpCode.Ble,    ILOpCode.Bgt,    ILOpCode.Bge,     // Float
            ILOpCode.Bge_un, ILOpCode.Bgt_un, ILOpCode.Ble_un, ILOpCode.Blt_un,  // Float Invert
                    }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10960, 675, 21943);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10960, 675, 21943);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10960, 675, 21943);

        Microsoft.CodeAnalysis.CodeGen.SynthesizedLocalOrdinalsDispenser
        f_10960_1907_1946()
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.SynthesizedLocalOrdinalsDispenser();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 1907, 1946);
            return return_v;
        }


        static object
        f_10960_2112_2124()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 2112, 2124);
            return return_v;
        }


        int
        f_10960_3776_3812(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 3776, 3812);
            return 0;
        }


        int
        f_10960_3827_3858(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 3827, 3858);
            return 0;
        }


        int
        f_10960_3873_3902(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 3873, 3902);
            return 0;
        }


        int
        f_10960_3917_3952(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 3917, 3952);
            return 0;
        }


        int
        f_10960_3967_4000(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 3967, 4000);
            return 0;
        }


        bool
        f_10960_4203_4228_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 4203, 4228);
            return return_v;
        }


        bool
        f_10960_4977_4990(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
        this_param)
        {
            var return_v = this_param.IsDebugPlus();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 4977, 4990);
            return return_v;
        }


        bool
        f_10960_5601_5625(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.GenerateDebugInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 5601, 5625);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundStatement
        f_10960_5691_5867(Microsoft.CodeAnalysis.CSharp.BoundStatement
        src, bool
        debugFriendly, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
        stackLocals)
        {
            var return_v = Optimizer.Optimize(src, debugFriendly: debugFriendly, out stackLocals);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 5691, 5867);
            return return_v;
        }


        int
        f_10960_5988_6014(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException
        this_param, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.AddAnError(diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10960, 5988, 6014);
            return 0;
        }


        (Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax blockBody, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax arrowBody)?
        f_10960_6225_6245_M((Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax blockBody, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax arrowBody)?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 6225, 6245);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
        f_10960_6337_6361_M(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10960, 6337, 6361);
            return return_v;
        }

    }
}
