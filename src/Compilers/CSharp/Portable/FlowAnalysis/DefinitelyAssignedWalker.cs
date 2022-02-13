// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

// See comment in DefiniteAssignment.
#define REFERENCE_STATE

using System;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class DefinitelyAssignedWalker : AbstractRegionDataFlowPass
    {
        private readonly HashSet<Symbol> _definitelyAssignedOnEntry;

        private readonly HashSet<Symbol> _definitelyAssignedOnExit;

        private DefinitelyAssignedWalker(
                    CSharpCompilation compilation,
                    Symbol member,
                    BoundNode node,
                    BoundNode firstInRegion,
                    BoundNode lastInRegion)
        : base(f_10892_1107_1118_C(compilation), member, node, firstInRegion, lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10892, 877, 1184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 721, 771);
                this._definitelyAssignedOnEntry = f_10892_750_771(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 815, 864);
                this._definitelyAssignedOnExit = f_10892_843_864(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10892, 877, 1184);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10892, 877, 1184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10892, 877, 1184);
            }
        }

        internal static (HashSet<Symbol> entry, HashSet<Symbol> exit) Analyze(
                    CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10892, 1196, 1960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 1415, 1513);

                var
                walker = f_10892_1428_1512(compilation, member, node, firstInRegion, lastInRegion)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 1563, 1586);

                    bool
                    badRegion = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 1604, 1653);

                    f_10892_1604_1652(walker, ref badRegion, diagnostics: null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 1671, 1851);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10892, 1678, 1687) || ((badRegion
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10892, 1711, 1757)) || DynAbs.Tracing.TraceSender.Conditional_F3(10892, 1781, 1850))) ? (f_10892_1712_1733(), f_10892_1735_1756())
                    : (walker._definitelyAssignedOnEntry, walker._definitelyAssignedOnExit);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10892, 1880, 1949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 1920, 1934);

                    f_10892_1920_1933(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10892, 1880, 1949);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10892, 1196, 1960);

                Microsoft.CodeAnalysis.CSharp.DefinitelyAssignedWalker
                f_10892_1428_1512(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DefinitelyAssignedWalker(compilation, member, node, firstInRegion, lastInRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 1428, 1512);
                    return return_v;
                }


                int
                f_10892_1604_1652(Microsoft.CodeAnalysis.CSharp.DefinitelyAssignedWalker
                this_param, ref bool
                badRegion, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.Analyze(ref badRegion, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 1604, 1652);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10892_1712_1733()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 1712, 1733);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10892_1735_1756()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 1735, 1756);
                    return return_v;
                }


                int
                f_10892_1920_1933(Microsoft.CodeAnalysis.CSharp.DefinitelyAssignedWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 1920, 1933);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10892, 1196, 1960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10892, 1196, 1960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void EnterRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10892, 1972, 2120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 2034, 2076);

                f_10892_2034_2075(this, _definitelyAssignedOnEntry);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 2090, 2109);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EnterRegion(), 10892, 2090, 2108);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10892, 1972, 2120);

                int
                f_10892_2034_2075(Microsoft.CodeAnalysis.CSharp.DefinitelyAssignedWalker
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                definitelyAssigned)
                {
                    this_param.ProcessRegion(definitelyAssigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 2034, 2075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10892, 1972, 2120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10892, 1972, 2120);
            }
        }

        protected override void LeaveRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10892, 2132, 2279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 2194, 2235);

                f_10892_2194_2234(this, _definitelyAssignedOnExit);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 2249, 2268);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.LeaveRegion(), 10892, 2249, 2267);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10892, 2132, 2279);

                int
                f_10892_2194_2234(Microsoft.CodeAnalysis.CSharp.DefinitelyAssignedWalker
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                definitelyAssigned)
                {
                    this_param.ProcessRegion(definitelyAssigned);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 2194, 2234);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10892, 2132, 2279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10892, 2132, 2279);
            }
        }

        private void ProcessRegion(HashSet<Symbol> definitelyAssigned)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10892, 2291, 3131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 2541, 2568);

                f_10892_2541_2567(            // this can happen multiple times as flow analysis is multi-pass.  Always 
                                              // take the latest data and use that to determine our result.
                            definitelyAssigned);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 2584, 3120) || true) && (this.IsConditionalState)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10892, 2584, 3120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 2893, 2972);

                    f_10892_2893_2971(                // We're in a state where there are different flow paths (i.e. when-true and when-false).
                                                      // In that case, a variable is only definitely assigned if it's definitely assigned through
                                                      // both paths.
                                    this, definitelyAssigned, this.StateWhenTrue, this.StateWhenFalse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10892, 2584, 3120);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10892, 2584, 3120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 3038, 3105);

                    f_10892_3038_3104(this, definitelyAssigned, this.State, state2opt: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10892, 2584, 3120);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10892, 2291, 3131);

                int
                f_10892_2541_2567(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 2541, 2567);
                    return 0;
                }


                int
                f_10892_2893_2971(Microsoft.CodeAnalysis.CSharp.DefinitelyAssignedWalker
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                definitelyAssigned, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state1, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state2opt)
                {
                    this_param.ProcessState(definitelyAssigned, state1, state2opt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 2893, 2971);
                    return 0;
                }


                int
                f_10892_3038_3104(Microsoft.CodeAnalysis.CSharp.DefinitelyAssignedWalker
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                definitelyAssigned, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state1, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState
                state2opt)
                {
                    this_param.ProcessState(definitelyAssigned, state1, state2opt: state2opt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 3038, 3104);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10892, 2291, 3131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10892, 2291, 3131);
            }
        }

        private void ProcessState(HashSet<Symbol> definitelyAssigned, LocalState state1, LocalState state2opt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10892, 3164, 3832);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 3419, 3821);
                    foreach (var slot in f_10892_3440_3466_I(state1.Assigned.TrueBits()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10892, 3419, 3821);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 3500, 3806) || true) && (slot < f_10892_3511_3531(variableBySlot) && (DynAbs.Tracing.TraceSender.Expression_True(10892, 3504, 3592) && f_10892_3556_3583_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(state2opt, 10892, 3556, 3583)?.IsAssigned(slot)) != false) && (DynAbs.Tracing.TraceSender.Expression_True(10892, 3504, 3658) && variableBySlot[slot].Symbol is { } symbol) && (DynAbs.Tracing.TraceSender.Expression_True(10892, 3504, 3714) && f_10892_3683_3694(symbol) != SymbolKind.Field))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10892, 3500, 3806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10892, 3756, 3787);

                            f_10892_3756_3786(definitelyAssigned, symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10892, 3500, 3806);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10892, 3419, 3821);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10892, 1, 403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10892, 1, 403);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10892, 3164, 3832);

                int
                f_10892_3511_3531(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.VariableIdentifier>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10892, 3511, 3531);
                    return return_v;
                }


                bool?
                f_10892_3556_3583_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 3556, 3583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10892_3683_3694(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10892, 3683, 3694);
                    return return_v;
                }


                bool
                f_10892_3756_3786(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 3756, 3786);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<int>
                f_10892_3440_3466_I(System.Collections.Generic.IEnumerable<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 3440, 3466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10892, 3164, 3832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10892, 3164, 3832);
            }
        }

        static DefinitelyAssignedWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10892, 596, 3839);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10892, 596, 3839);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10892, 596, 3839);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10892, 596, 3839);

        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10892_750_771()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 750, 771);
            return return_v;
        }


        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10892_843_864()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10892, 843, 864);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10892_1107_1118_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10892, 877, 1184);
            return return_v;
        }

    }
}
