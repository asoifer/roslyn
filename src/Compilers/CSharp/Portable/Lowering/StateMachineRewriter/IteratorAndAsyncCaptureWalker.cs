// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class IteratorAndAsyncCaptureWalker : DefiniteAssignmentPass
    {
        private readonly OrderedSet<Symbol> _variablesToHoist;

        private MultiDictionary<Symbol, SyntaxNode> _lazyDisallowedCaptures;

        private bool _seenYieldInCurrentTry;

        private readonly Dictionary<LocalSymbol, BoundExpression> _boundRefLocalInitializers;

        private IteratorAndAsyncCaptureWalker(CSharpCompilation compilation, MethodSymbol method, BoundNode node, HashSet<Symbol> initiallyAssignedVariables)
        : base(f_10539_2345_2356_C(compilation), method, node, f_10539_2429_2468(), trackUnassignments: true, initiallyAssignedVariables: initiallyAssignedVariables)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10539, 2175, 2611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 1456, 1500);
                this._variablesToHoist = f_10539_1476_1500(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 1739, 1762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 1788, 1810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 2087, 2162);
                this._boundRefLocalInitializers = f_10539_2116_2162(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10539, 2175, 2611);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 2175, 2611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 2175, 2611);
            }
        }

        public static OrderedSet<Symbol> Analyze(CSharpCompilation compilation, MethodSymbol method, BoundNode node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10539, 2713, 5925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 2873, 3049);

                var
                initiallyAssignedVariables = f_10539_2906_3048(compilation, method, node, convertInsufficientExecutionStackExceptionToCancelledByStackGuardException: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 3063, 3165);

                var
                walker = f_10539_3076_3164(compilation, method, node, initiallyAssignedVariables)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 3181, 3271);

                walker._convertInsufficientExecutionStackExceptionToCancelledByStackGuardException = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 3287, 3310);

                bool
                badRegion = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 3324, 3354);

                f_10539_3324_3353(walker, ref badRegion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 3368, 3393);

                f_10539_3368_3392(!badRegion);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 3409, 3810) || true) && (f_10539_3413_3429_M(!method.IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10539, 3413, 3482) && f_10539_3433_3463(f_10539_3433_3454(method)) == TypeKind.Struct))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 3409, 3810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 3737, 3795);

                    f_10539_3737_3794(                // It is possible that the enclosing method only *writes* to the enclosing struct, but in that
                                                      // case it should be considered captured anyway so that we have a proxy for it to write to.
                                    walker, f_10539_3760_3780(method), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 3409, 3810);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 3826, 3886);

                var
                lazyDisallowedCaptures = walker._lazyDisallowedCaptures
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 3900, 3941);

                var
                allVariables = walker.variableBySlot
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 3957, 5132) || true) && (lazyDisallowedCaptures != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 3957, 5132);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 4025, 5117);
                        foreach (var kvp in f_10539_4045_4067_I(lazyDisallowedCaptures))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 4025, 5117);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 4109, 4132);

                            var
                            variable = kvp.Key
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 4154, 4267);

                            var
                            type = (DynAbs.Tracing.TraceSender.Conditional_F1(10539, 4165, 4200) || (((f_10539_4166_4179(variable) == SymbolKind.Local) && DynAbs.Tracing.TraceSender.Conditional_F2(10539, 4203, 4231)) || DynAbs.Tracing.TraceSender.Conditional_F3(10539, 4234, 4266))) ? f_10539_4203_4231(((LocalSymbol)variable)) : f_10539_4234_4266(((ParameterSymbol)variable))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 4291, 5098) || true) && (variable is SynthesizedLocal local && (DynAbs.Tracing.TraceSender.Expression_True(10539, 4295, 4384) && f_10539_4333_4354(local) == SynthesizedLocalKind.Spill))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 4291, 5098);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 4434, 4493);

                                f_10539_4434_4492(local.TypeWithAnnotations.IsRestrictedType());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 4519, 4615);

                                f_10539_4519_4614(diagnostics, ErrorCode.ERR_ByRefTypeAndAwait, f_10539_4568_4583(local)[0], f_10539_4588_4613(local));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 4291, 5098);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 4291, 5098);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 4713, 5075);
                                    foreach (CSharpSyntaxNode syntax in f_10539_4749_4758_I(kvp.Value))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 4713, 5075);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 4973, 5048);

                                        f_10539_4973_5047(                            // CS4013: Instance of type '{0}' cannot be used inside an anonymous function, query expression, iterator block or async method
                                                                    diagnostics, ErrorCode.ERR_SpecialByRefInLambda, f_10539_5025_5040(syntax), type);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 4713, 5075);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10539, 1, 363);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10539, 1, 363);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 4291, 5098);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 4025, 5117);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10539, 1, 1093);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10539, 1, 1093);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 3957, 5132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 5148, 5196);

                var
                variablesToHoist = f_10539_5171_5195()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 5210, 5698) || true) && (f_10539_5214_5251(f_10539_5214_5233(compilation)) != OptimizationLevel.Release)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 5210, 5698);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 5391, 5683);
                        foreach (var v in f_10539_5409_5421_I(allVariables))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 5391, 5683);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 5463, 5485);

                            var
                            symbol = v.Symbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 5507, 5664) || true) && ((object)symbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10539, 5511, 5562) && f_10539_5537_5562(symbol)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 5507, 5664);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 5612, 5641);

                                f_10539_5612_5640(variablesToHoist, symbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 5507, 5664);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 5391, 5683);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10539, 1, 293);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10539, 1, 293);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 5210, 5698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 5792, 5844);

                f_10539_5792_5843(
                            // Hoist anything determined to be live across an await or yield
                            variablesToHoist, walker._variablesToHoist);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 5860, 5874);

                f_10539_5860_5873(
                            walker);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 5890, 5914);

                return variablesToHoist;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10539, 2713, 5925);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10539_2906_3048(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, bool
                convertInsufficientExecutionStackExceptionToCancelledByStackGuardException)
                {
                    var return_v = UnassignedVariablesWalker.Analyze(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)member, node, convertInsufficientExecutionStackExceptionToCancelledByStackGuardException: convertInsufficientExecutionStackExceptionToCancelledByStackGuardException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 2906, 3048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                f_10539_3076_3164(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                initiallyAssignedVariables)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker(compilation, method, node, initiallyAssignedVariables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 3076, 3164);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.PendingBranch>
                f_10539_3324_3353(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 3324, 3353);
                    return return_v;
                }


                int
                f_10539_3368_3392(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 3368, 3392);
                    return 0;
                }


                bool
                f_10539_3413_3429_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 3413, 3429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10539_3433_3454(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 3433, 3454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10539_3433_3463(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 3433, 3463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10539_3760_3780(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 3760, 3780);
                    return return_v;
                }


                int
                f_10539_3737_3794(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.CaptureVariable((Microsoft.CodeAnalysis.CSharp.Symbol)variable, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 3737, 3794);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10539_4166_4179(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 4166, 4179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10539_4203_4231(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 4203, 4231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10539_4234_4266(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 4234, 4266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10539_4333_4354(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 4333, 4354);
                    return return_v;
                }


                int
                f_10539_4434_4492(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 4434, 4492);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10539_4568_4583(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 4568, 4583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10539_4588_4613(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 4588, 4613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10539_4519_4614(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 4519, 4614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10539_5025_5040(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 5025, 5040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10539_4973_5047(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 4973, 5047);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.SyntaxNode>.ValueSet
                f_10539_4749_4758_I(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.SyntaxNode>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 4749, 4758);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.SyntaxNode>
                f_10539_4045_4067_I(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.SyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 4045, 4067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10539_5171_5195()
                {
                    var return_v = new Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 5171, 5195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10539_5214_5233(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 5214, 5233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_10539_5214_5251(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 5214, 5251);
                    return return_v;
                }


                bool
                f_10539_5537_5562(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = HoistInDebugBuild(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 5537, 5562);
                    return return_v;
                }


                bool
                f_10539_5612_5640(Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 5612, 5640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                f_10539_5409_5421_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 5409, 5421);
                    return return_v;
                }


                int
                f_10539_5792_5843(Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 5792, 5843);
                    return 0;
                }


                int
                f_10539_5860_5873(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 5860, 5873);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 2713, 5925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 2713, 5925);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HoistInDebugBuild(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10539, 5937, 6609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 6014, 6598);

                return (symbol) switch
                {
                    ParameterSymbol parameter when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 6069, 6234) && DynAbs.Tracing.TraceSender.Expression_True(10539, 6069, 6234))
    =>
                        // in Debug build hoist all parameters that can be hoisted:
                        !f_10539_6201_6234(f_10539_6201_6215(parameter)),
                    LocalSymbol { IsConst: false, IsPinned: false, IsRef: false } local when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 6253, 6553) && DynAbs.Tracing.TraceSender.Expression_True(10539, 6253, 6553))
    =>
    f_10539_6441_6498(f_10539_6441_6462(local)) && (DynAbs.Tracing.TraceSender.Expression_True(10539, 6441, 6553) && !f_10539_6524_6553(f_10539_6524_6534(local))),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 6572, 6582) && DynAbs.Tracing.TraceSender.Expression_True(10539, 6572, 6582))
    => false
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10539, 5937, 6609);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10539_6201_6215(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 6201, 6215);
                    return return_v;
                }


                bool
                f_10539_6201_6234(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 6201, 6234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10539_6441_6462(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 6441, 6462);
                    return return_v;
                }


                bool
                f_10539_6441_6498(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.MustSurviveStateMachineSuspension();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 6441, 6498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10539_6524_6534(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 6524, 6534);
                    return return_v;
                }


                bool
                f_10539_6524_6553(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 6524, 6553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 5937, 6609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 5937, 6609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void MarkLocalsUnassigned()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 6621, 7798);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 6690, 6695);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 6681, 7787) || true) && (i < f_10539_6701_6721(variableBySlot))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 6723, 6726)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 6681, 7787))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 6681, 7787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 6760, 6798);

                        var
                        symbol = variableBySlot[i].Symbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 6818, 7772) || true) && ((object)symbol != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 6818, 7772);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 6886, 7753);

                            switch (f_10539_6894_6905(symbol))
                            {

                                case SymbolKind.Local:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 6886, 7753);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 7007, 7161) || true) && (f_10539_7011_7041_M(!((LocalSymbol)symbol).IsConst))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 7007, 7161);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 7107, 7130);

                                        f_10539_7107_7129(this, i, false);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 7007, 7161);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10539, 7191, 7197);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 6886, 7753);

                                case SymbolKind.Parameter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 6886, 7753);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 7281, 7304);

                                    f_10539_7281_7303(this, i, false);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10539, 7334, 7340);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 6886, 7753);

                                case SymbolKind.Field:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 6886, 7753);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 7420, 7574) || true) && (f_10539_7424_7454_M(!((FieldSymbol)symbol).IsConst))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 7420, 7574);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 7520, 7543);

                                        f_10539_7520_7542(this, i, false);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 7420, 7574);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10539, 7604, 7610);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 6886, 7753);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 6886, 7753);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 7676, 7730);

                                    throw f_10539_7682_7729(f_10539_7717_7728(symbol));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 6886, 7753);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 6818, 7772);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10539, 1, 1107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10539, 1, 1107);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 6621, 7798);

                int
                f_10539_6701_6721(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 6701, 6721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10539_6894_6905(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 6894, 6905);
                    return return_v;
                }


                bool
                f_10539_7011_7041_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 7011, 7041);
                    return return_v;
                }


                int
                f_10539_7107_7129(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 7107, 7129);
                    return 0;
                }


                int
                f_10539_7281_7303(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 7281, 7303);
                    return 0;
                }


                bool
                f_10539_7424_7454_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 7424, 7454);
                    return return_v;
                }


                int
                f_10539_7520_7542(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, int
                slot, bool
                assigned)
                {
                    this_param.SetSlotState(slot, assigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 7520, 7542);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10539_7717_7728(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 7717, 7728);
                    return return_v;
                }


                System.Exception
                f_10539_7682_7729(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 7682, 7729);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 6621, 7798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 6621, 7798);
            }
        }

        public override BoundNode VisitAwaitExpression(BoundAwaitExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 7810, 8014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 7908, 7940);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAwaitExpression(node), 10539, 7908, 7939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 7954, 7977);

                f_10539_7954_7976(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 7991, 8003);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 7810, 8014);

                int
                f_10539_7954_7976(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param)
                {
                    this_param.MarkLocalsUnassigned();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 7954, 7976);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 7810, 8014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 7810, 8014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitYieldReturnStatement(BoundYieldReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 8026, 8289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8134, 8171);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitYieldReturnStatement(node), 10539, 8134, 8170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8185, 8208);

                f_10539_8185_8207(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8222, 8252);

                _seenYieldInCurrentTry = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8266, 8278);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 8026, 8289);

                int
                f_10539_8185_8207(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param)
                {
                    this_param.MarkLocalsUnassigned();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 8185, 8207);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 8026, 8289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 8026, 8289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<PendingBranch> Scan(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 8301, 8531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8399, 8425);

                f_10539_8399_8424(_variablesToHoist);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8439, 8472);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyDisallowedCaptures, 10539, 8439, 8471)?.Clear(), 10539, 8463, 8471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8488, 8520);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Scan(ref badRegion), 10539, 8495, 8519);
                var temp2 = base.Scan(ref badRegion);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 8495, 8519);
                return temp2;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 8301, 8531);

                int
                f_10539_8399_8424(Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 8399, 8424);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 8301, 8531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 8301, 8531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CaptureVariable(Symbol variable, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 8543, 9226);
                Microsoft.CodeAnalysis.CSharp.BoundExpression variableInitializer = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8632, 8745);

                var
                type = (DynAbs.Tracing.TraceSender.Conditional_F1(10539, 8643, 8678) || (((f_10539_8644_8657(variable) == SymbolKind.Local) && DynAbs.Tracing.TraceSender.Conditional_F2(10539, 8681, 8709)) || DynAbs.Tracing.TraceSender.Conditional_F3(10539, 8712, 8744))) ? f_10539_8681_8709(((LocalSymbol)variable)) : f_10539_8712_8744(((ParameterSymbol)variable))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8759, 9215) || true) && (f_10539_8763_8786(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 8759, 9215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8820, 8914);

                    // LAFHIS
                    if (_lazyDisallowedCaptures is null)
                        DynAbs.Tracing.TraceSender.TraceEnterExpression(10539, 8820, 8914);

                    f_10539_8820_8913((_lazyDisallowedCaptures ??= f_10539_8849_8890()), variable, syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 8759, 9215);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 8759, 9215);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 8980, 9200) || true) && (f_10539_8984_9015(_variablesToHoist, variable) && (DynAbs.Tracing.TraceSender.Expression_True(10539, 8984, 9048) && variable is LocalSymbol local) && (DynAbs.Tracing.TraceSender.Expression_True(10539, 8984, 9126) && f_10539_9052_9126(_boundRefLocalInitializers, local, out variableInitializer)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 8980, 9200);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 9149, 9200);

                        f_10539_9149_9199(this, variableInitializer, syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 8980, 9200);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 8759, 9215);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 8543, 9226);

                Microsoft.CodeAnalysis.SymbolKind
                f_10539_8644_8657(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 8644, 8657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10539_8681_8709(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 8681, 8709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10539_8712_8744(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 8712, 8744);
                    return return_v;
                }


                bool
                f_10539_8763_8786(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 8763, 8786);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.SyntaxNode>
                f_10539_8849_8890()
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 8849, 8890);
                    return return_v;
                }


                bool
                f_10539_8820_8913(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                k, Microsoft.CodeAnalysis.SyntaxNode
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 8820, 8913);
                    return return_v;
                }


                bool
                f_10539_8984_9015(Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 8984, 9015);
                    return return_v;
                }


                bool
                f_10539_9052_9126(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 9052, 9126);
                    return return_v;
                }


                int
                f_10539_9149_9199(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                variableInitializer, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.CaptureRefInitializer(variableInitializer, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 9149, 9199);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 8543, 9226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 8543, 9226);
            }
        }

        private void CaptureRefInitializer(BoundExpression variableInitializer, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 9238, 9963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 9353, 9952);

                switch (variableInitializer)
                {

                    case BoundLocal { LocalSymbol: var symbol }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 9353, 9952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 9480, 9512);

                        f_10539_9480_9511(this, symbol, syntax);
                        DynAbs.Tracing.TraceSender.TraceBreak(10539, 9534, 9540);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 9353, 9952);

                    case BoundParameter { ParameterSymbol: var symbol }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 9353, 9952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 9632, 9664);

                        f_10539_9632_9663(this, symbol, syntax);
                        DynAbs.Tracing.TraceSender.TraceBreak(10539, 9686, 9692);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 9353, 9952);

                    case BoundFieldAccess { FieldSymbol: { IsStatic: false, ContainingType: { IsValueType: true } }, ReceiverOpt: BoundExpression receiver }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 9353, 9952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 9869, 9909);

                        f_10539_9869_9908(this, receiver, syntax);
                        DynAbs.Tracing.TraceSender.TraceBreak(10539, 9931, 9937);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 9353, 9952);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 9238, 9963);

                int
                f_10539_9480_9511(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                variable, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.CaptureVariable((Microsoft.CodeAnalysis.CSharp.Symbol)variable, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 9480, 9511);
                    return 0;
                }


                int
                f_10539_9632_9663(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.CaptureVariable((Microsoft.CodeAnalysis.CSharp.Symbol)variable, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 9632, 9663);
                    return 0;
                }


                int
                f_10539_9869_9908(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                variableInitializer, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.CaptureRefInitializer(variableInitializer, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 9869, 9908);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 9238, 9963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 9238, 9963);
            }
        }

        protected override void EnterParameter(ParameterSymbol parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 9975, 10411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 10152, 10220);

                f_10539_10152_10219(f_10539_10165_10181(parameter) || (DynAbs.Tracing.TraceSender.Expression_False(10539, 10165, 10218) || f_10539_10185_10202(parameter) == RefKind.None));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 10373, 10400);

                f_10539_10373_10399(this, parameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 9975, 10411);

                bool
                f_10539_10165_10181(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsThis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 10165, 10181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10539_10185_10202(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 10185, 10202);
                    return return_v;
                }


                int
                f_10539_10152_10219(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 10152, 10219);
                    return 0;
                }


                int
                f_10539_10373_10399(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.GetOrCreateSlot((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 10373, 10399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 9975, 10411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 9975, 10411);
            }
        }

        protected override void ReportUnassigned(Symbol symbol, SyntaxNode node, int slot, bool skipIfUseBeforeDeclaration)
        {
            switch (symbol.Kind)
            {
                case SymbolKind.Field:
                    symbol = GetNonMemberSymbol(slot);
                    goto case SymbolKind.Local;

                case SymbolKind.Local:
                case SymbolKind.Parameter:
                    CaptureVariable(symbol, node);
                    break;
            }
        }

        protected override void VisitLvalueParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 10947, 11126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 11037, 11069);

                f_10539_11037_11068(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 11083, 11115);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLvalueParameter(node), 10539, 11083, 11114);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 10947, 11126);

                int
                f_10539_11037_11068(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                node)
                {
                    this_param.TryHoistTopLevelParameter(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 11037, 11068);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 10947, 11126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 10947, 11126);
            }
        }

        public override BoundNode VisitParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 11138, 11314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 11224, 11256);

                f_10539_11224_11255(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 11270, 11303);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitParameter(node), 10539, 11277, 11302);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 11138, 11314);

                int
                f_10539_11224_11255(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                node)
                {
                    this_param.TryHoistTopLevelParameter(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 11224, 11255);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 11138, 11314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 11138, 11314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void TryHoistTopLevelParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 11326, 11580);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 11410, 11569) || true) && (f_10539_11414_11451(f_10539_11414_11434(node)) == topLevelMethod)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 11410, 11569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 11503, 11554);

                    f_10539_11503_11553(this, f_10539_11519_11539(node), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 11410, 11569);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 11326, 11580);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10539_11414_11434(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 11414, 11434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10539_11414_11451(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 11414, 11451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10539_11519_11539(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 11519, 11539);
                    return return_v;
                }


                int
                f_10539_11503_11553(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.CaptureVariable((Microsoft.CodeAnalysis.CSharp.Symbol)variable, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 11503, 11553);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 11326, 11580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 11326, 11580);
            }
        }

        public override BoundNode VisitFieldAccess(BoundFieldAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 11592, 11978);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 11682, 11916) || true) && (f_10539_11686_11702(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(10539, 11686, 11762) && f_10539_11714_11735(f_10539_11714_11730(node)) == BoundKind.ThisReference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 11682, 11916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 11796, 11842);

                    var
                    thisSymbol = f_10539_11813_11841(topLevelMethod)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 11860, 11901);

                    f_10539_11860_11900(this, thisSymbol, node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 11682, 11916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 11932, 11967);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFieldAccess(node), 10539, 11939, 11966);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 11592, 11978);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10539_11686_11702(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 11686, 11702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10539_11714_11730(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 11714, 11730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10539_11714_11735(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 11714, 11735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10539_11813_11841(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 11813, 11841);
                    return return_v;
                }


                int
                f_10539_11860_11900(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.CaptureVariable((Microsoft.CodeAnalysis.CSharp.Symbol)variable, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 11860, 11900);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 11592, 11978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 11592, 11978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThisReference(BoundThisReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 11990, 12205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 12084, 12143);

                f_10539_12084_12142(this, f_10539_12100_12128(topLevelMethod), node.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 12157, 12194);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitThisReference(node), 10539, 12164, 12193);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 11990, 12205);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10539_12100_12128(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 12100, 12128);
                    return return_v;
                }


                int
                f_10539_12084_12142(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.CaptureVariable((Microsoft.CodeAnalysis.CSharp.Symbol)variable, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 12084, 12142);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 11990, 12205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 11990, 12205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBaseReference(BoundBaseReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 12217, 12432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 12311, 12370);

                f_10539_12311_12369(this, f_10539_12327_12355(topLevelMethod), node.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 12384, 12421);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBaseReference(node), 10539, 12391, 12420);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 12217, 12432);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10539_12327_12355(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 12327, 12355);
                    return return_v;
                }


                int
                f_10539_12311_12369(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                variable, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.CaptureVariable((Microsoft.CodeAnalysis.CSharp.Symbol)variable, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 12311, 12369);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 12217, 12432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 12217, 12432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTryStatement(BoundTryStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 12444, 12782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 12536, 12591);

                var
                origSeenYieldInCurrentTry = _seenYieldInCurrentTry
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 12605, 12636);

                _seenYieldInCurrentTry = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 12650, 12679);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitTryStatement(node), 10539, 12650, 12678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 12693, 12745);

                _seenYieldInCurrentTry |= origSeenYieldInCurrentTry;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 12759, 12771);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 12444, 12782);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 12444, 12782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 12444, 12782);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void VisitFinallyBlock(BoundStatement finallyBlock, ref LocalState unsetInFinally)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 12794, 13357);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 12920, 13273) || true) && (_seenYieldInCurrentTry)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 12920, 13273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 13174, 13258);

                    f_10539_13174_13257(f_10539_13174_13237(this, this.topLevelMethod, this), finallyBlock);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 12920, 13273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 13289, 13346);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFinallyBlock(finallyBlock, ref unsetInFinally), 10539, 13289, 13345);
                base.VisitFinallyBlock(finallyBlock, ref unsetInFinally); 
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 13289, 13345);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 12794, 13357);

                Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside
                f_10539_13174_13237(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                analyzer, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                parent)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside(analyzer, topLevelMethod, parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 13174, 13237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10539_13174_13257(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 13174, 13257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 12794, 13357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 12794, 13357);
            }
        }

        public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 13369, 13812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 13473, 13508);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOperator(node), 10539, 13473, 13507);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 13599, 13775) || true) && (node is { IsRef: true, Left: BoundLocal { LocalSymbol: LocalSymbol { IsCompilerGenerated: true } local } })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 13599, 13775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 13728, 13775);

                    _boundRefLocalInitializers[local] = f_10539_13764_13774(node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 13599, 13775);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 13789, 13801);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 13369, 13812);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10539_13764_13774(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 13764, 13774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 13369, 13812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 13369, 13812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class OutsideVariablesUsedInside : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
        {
            private readonly HashSet<Symbol> _localsInScope;

            private readonly IteratorAndAsyncCaptureWalker _analyzer;

            private readonly MethodSymbol _topLevelMethod;

            private readonly IteratorAndAsyncCaptureWalker _parent;

            public OutsideVariablesUsedInside(IteratorAndAsyncCaptureWalker analyzer, MethodSymbol topLevelMethod, IteratorAndAsyncCaptureWalker parent)
            : base(f_10539_14398_14420_C(parent._recursionDepth))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10539, 14233, 14633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 14002, 14016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 14078, 14087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 14132, 14147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 14209, 14216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 14454, 14475);

                    _analyzer = analyzer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 14493, 14526);

                    _topLevelMethod = topLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 14544, 14583);

                    _localsInScope = f_10539_14561_14582();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 14601, 14618);

                    _parent = parent;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10539, 14233, 14633);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 14233, 14633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 14233, 14633);
                }
            }

            protected override bool ConvertInsufficientExecutionStackExceptionToCancelledByStackGuardException()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 14649, 14889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 14782, 14874);

                    return f_10539_14789_14873(_parent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 14649, 14889);

                    bool
                    f_10539_14789_14873(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                    this_param)
                    {
                        var return_v = this_param.ConvertInsufficientExecutionStackExceptionToCancelledByStackGuardException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 14789, 14873);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 14649, 14889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 14649, 14889);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitBlock(BoundBlock node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 14905, 15079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 14991, 15017);

                    f_10539_14991_15016(this, f_10539_15004_15015(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 15035, 15064);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBlock(node), 10539, 15042, 15063);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 14905, 15079);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10539_15004_15015(Microsoft.CodeAnalysis.CSharp.BoundBlock
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 15004, 15015);
                        return return_v;
                    }


                    int
                    f_10539_14991_15016(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddVariables(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 14991, 15016);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 14905, 15079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 14905, 15079);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void AddVariables(ImmutableArray<LocalSymbol> locals)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 15095, 15312);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 15189, 15297);
                        foreach (var local in f_10539_15211_15217_I(locals))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 15189, 15297);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 15259, 15278);

                            f_10539_15259_15277(this, local);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 15189, 15297);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10539, 1, 109);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10539, 1, 109);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 15095, 15312);

                    int
                    f_10539_15259_15277(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        this_param.AddVariable((Microsoft.CodeAnalysis.CSharp.Symbol)local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 15259, 15277);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10539_15211_15217_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 15211, 15217);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 15095, 15312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 15095, 15312);
                }
            }

            public override BoundNode VisitCatchBlock(BoundCatchBlock node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 15328, 15517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 15424, 15450);

                    f_10539_15424_15449(this, f_10539_15437_15448(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 15468, 15502);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(node), 10539, 15475, 15501);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 15328, 15517);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10539_15437_15448(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 15437, 15448);
                        return return_v;
                    }


                    int
                    f_10539_15424_15449(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddVariables(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 15424, 15449);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 15328, 15517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 15328, 15517);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void AddVariable(Symbol local)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 15533, 15672);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 15604, 15657) || true) && ((object)local != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 15604, 15657);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 15631, 15657);

                        f_10539_15631_15656(_localsInScope, local);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 15604, 15657);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 15533, 15672);

                    bool
                    f_10539_15631_15656(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 15631, 15656);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 15533, 15672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 15533, 15672);
                }
            }

            public override BoundNode VisitSequence(BoundSequence node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 15688, 15871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 15780, 15806);

                    f_10539_15780_15805(this, f_10539_15793_15804(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 15824, 15856);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSequence(node), 10539, 15831, 15855);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 15688, 15871);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10539_15793_15804(Microsoft.CodeAnalysis.CSharp.BoundSequence
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 15793, 15804);
                        return return_v;
                    }


                    int
                    f_10539_15780_15805(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals)
                    {
                        this_param.AddVariables(locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 15780, 15805);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 15688, 15871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 15688, 15871);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitThisReference(BoundThisReference node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 15887, 16111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 15989, 16041);

                    f_10539_15989_16040(this, f_10539_15997_16026(_topLevelMethod), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 16059, 16096);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitThisReference(node), 10539, 16066, 16095);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 15887, 16111);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10539_15997_16026(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ThisParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 15997, 16026);
                        return return_v;
                    }


                    int
                    f_10539_15989_16040(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    s, Microsoft.CodeAnalysis.SyntaxNode
                    syntax)
                    {
                        this_param.Capture((Microsoft.CodeAnalysis.CSharp.Symbol)s, syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 15989, 16040);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 15887, 16111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 15887, 16111);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitBaseReference(BoundBaseReference node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 16127, 16351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 16229, 16281);

                    f_10539_16229_16280(this, f_10539_16237_16266(_topLevelMethod), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 16299, 16336);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBaseReference(node), 10539, 16306, 16335);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 16127, 16351);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10539_16237_16266(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ThisParameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 16237, 16266);
                        return return_v;
                    }


                    int
                    f_10539_16229_16280(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    s, Microsoft.CodeAnalysis.SyntaxNode
                    syntax)
                    {
                        this_param.Capture((Microsoft.CodeAnalysis.CSharp.Symbol)s, syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 16229, 16280);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 16127, 16351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 16127, 16351);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitLocal(BoundLocal node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 16367, 16554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 16453, 16492);

                    f_10539_16453_16491(this, f_10539_16461_16477(node), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 16510, 16539);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocal(node), 10539, 16517, 16538);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 16367, 16554);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10539_16461_16477(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 16461, 16477);
                        return return_v;
                    }


                    int
                    f_10539_16453_16491(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    s, Microsoft.CodeAnalysis.SyntaxNode
                    syntax)
                    {
                        this_param.Capture((Microsoft.CodeAnalysis.CSharp.Symbol)s, syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 16453, 16491);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 16367, 16554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 16367, 16554);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitParameter(BoundParameter node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 16570, 16773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 16664, 16707);

                    f_10539_16664_16706(this, f_10539_16672_16692(node), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 16725, 16758);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitParameter(node), 10539, 16732, 16757);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 16570, 16773);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10539_16672_16692(Microsoft.CodeAnalysis.CSharp.BoundParameter
                    this_param)
                    {
                        var return_v = this_param.ParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10539, 16672, 16692);
                        return return_v;
                    }


                    int
                    f_10539_16664_16706(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker.OutsideVariablesUsedInside
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    s, Microsoft.CodeAnalysis.SyntaxNode
                    syntax)
                    {
                        this_param.Capture((Microsoft.CodeAnalysis.CSharp.Symbol)s, syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 16664, 16706);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 16570, 16773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 16570, 16773);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void Capture(Symbol s, SyntaxNode syntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10539, 16789, 17036);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 16871, 17021) || true) && ((object)s != null && (DynAbs.Tracing.TraceSender.Expression_True(10539, 16875, 16923) && !f_10539_16897_16923(_localsInScope, s)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10539, 16871, 17021);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10539, 16965, 17002);

                        f_10539_16965_17001(_analyzer, s, syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10539, 16871, 17021);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10539, 16789, 17036);

                    bool
                    f_10539_16897_16923(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 16897, 16923);
                        return return_v;
                    }


                    int
                    f_10539_16965_17001(Microsoft.CodeAnalysis.CSharp.IteratorAndAsyncCaptureWalker
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    variable, Microsoft.CodeAnalysis.SyntaxNode
                    syntax)
                    {
                        this_param.CaptureVariable(variable, syntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 16965, 17001);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10539, 16789, 17036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 16789, 17036);
                }
            }

            static OutsideVariablesUsedInside()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10539, 13824, 17047);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10539, 13824, 17047);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 13824, 17047);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10539, 13824, 17047);

            System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10539_14561_14582()
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 14561, 14582);
                return return_v;
            }


            static int
            f_10539_14398_14420_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10539, 14233, 14633);
                return return_v;
            }

        }

        static IteratorAndAsyncCaptureWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10539, 1147, 17054);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10539, 1147, 17054);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10539, 1147, 17054);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10539, 1147, 17054);

        Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10539_1476_1500()
        {
            var return_v = new Microsoft.CodeAnalysis.Collections.OrderedSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 1476, 1500);
            return return_v;
        }


        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10539_2116_2162()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 2116, 2162);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
        f_10539_2429_2468()
        {
            var return_v = EmptyStructTypeCache.CreateNeverEmpty();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10539, 2429, 2468);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10539_2345_2356_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10539, 2175, 2611);
            return return_v;
        }

    }
}
