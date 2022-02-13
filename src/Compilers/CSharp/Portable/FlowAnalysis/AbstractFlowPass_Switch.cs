// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class AbstractFlowPass<TLocalState, TLocalFunctionState>
    {
        public override BoundNode VisitSwitchStatement(BoundSwitchStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10880, 590, 1544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 736, 810);

                var (initialState, afterSwitchState) = f_10880_775_809(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 864, 905);

                var
                switchSections = f_10880_885_904(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 919, 966);

                var
                iLastSection = (switchSections.Length - 1)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 989, 1001);
                    for (var
        iSection = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 980, 1440) || true) && (iSection <= iLastSection)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 1029, 1039)
        , iSection++, DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 980, 1440))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 980, 1440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 1073, 1144);

                        f_10880_1073_1143(this, switchSections[iSection], iSection == iLastSection);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 1382, 1425);

                        f_10880_1382_1424(this, ref afterSwitchState, ref this.State);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10880, 1, 461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10880, 1, 461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 1456, 1505);

                f_10880_1456_1504(this, afterSwitchState, f_10880_1488_1503(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 1521, 1533);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10880, 590, 1544);

                (TLocalState initialState, TLocalState afterSwitchState)
                f_10880_775_809(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                node)
                {
                    var return_v = this_param.VisitSwitchStatementDispatch(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 775, 809);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10880_885_904(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.SwitchSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 885, 904);
                    return return_v;
                }


                int
                f_10880_1073_1143(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                node, bool
                isLastSection)
                {
                    this_param.VisitSwitchSection(node, isLastSection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 1073, 1143);
                    return 0;
                }


                bool
                f_10880_1382_1424(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 1382, 1424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10880_1488_1503(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 1488, 1503);
                    return return_v;
                }


                int
                f_10880_1456_1504(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                breakState, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    this_param.ResolveBreaks(breakState, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 1456, 1504);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10880, 590, 1544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10880, 590, 1544);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual (TLocalState initialState, TLocalState afterSwitchState) VisitSwitchStatementDispatch(BoundSwitchStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10880, 1556, 3342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 1747, 1776);

                f_10880_1747_1775(this, f_10880_1759_1774(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 1792, 1838);

                TLocalState
                initialState = f_10880_1819_1837(this.State)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 1854, 1909);

                var
                reachableLabels = f_10880_1876_1908(f_10880_1876_1892(node))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 1923, 2921);
                    foreach (var section in f_10880_1947_1966_I(f_10880_1947_1966(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 1923, 2921);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2000, 2906);
                            foreach (var label in f_10880_2022_2042_I(f_10880_2022_2042(section)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 2000, 2906);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2084, 2488) || true) && (f_10880_2088_2125(reachableLabels, f_10880_2113_2124(label)) || (DynAbs.Tracing.TraceSender.Expression_False(10880, 2088, 2144) || f_10880_2129_2144(label)) || (DynAbs.Tracing.TraceSender.Expression_False(10880, 2088, 2269) || label == f_10880_2182_2199(node) && (DynAbs.Tracing.TraceSender.Expression_True(10880, 2173, 2240) && f_10880_2203_2232(f_10880_2203_2218(node)) == null) && (DynAbs.Tracing.TraceSender.Expression_True(10880, 2173, 2269) && f_10880_2244_2269(this, node))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 2084, 2488);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2319, 2350);

                                    f_10880_2319_2349(this, f_10880_2328_2348(initialState));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 2084, 2488);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 2084, 2488);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2448, 2465);

                                    f_10880_2448_2464(this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 2084, 2488);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2512, 2540);

                                f_10880_2512_2539(this, f_10880_2525_2538(label));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2562, 2586);

                                f_10880_2562_2585(this, StateWhenTrue);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2608, 2792) || true) && (f_10880_2612_2628(label) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 2608, 2792);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2686, 2719);

                                    f_10880_2686_2718(this, f_10880_2701_2717(label));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2745, 2769);

                                    f_10880_2745_2768(this, StateWhenTrue);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 2608, 2792);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2816, 2887);

                                f_10880_2816_2886(f_10880_2816_2831(), f_10880_2836_2885(label, this.State, f_10880_2873_2884(label)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 2000, 2906);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10880, 1, 907);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10880, 1, 907);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 1923, 2921);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10880, 1, 999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10880, 1, 999);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 2937, 2987);

                TLocalState
                afterSwitchState = f_10880_2968_2986(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 3001, 3275) || true) && (f_10880_3005_3063(f_10880_3005_3037(f_10880_3005_3021(node)), f_10880_3047_3062(node)) || (DynAbs.Tracing.TraceSender.Expression_False(10880, 3005, 3181) || (f_10880_3085_3102(node) == null && (DynAbs.Tracing.TraceSender.Expression_True(10880, 3085, 3151) && f_10880_3114_3143(f_10880_3114_3129(node)) == null) && (DynAbs.Tracing.TraceSender.Expression_True(10880, 3085, 3180) && f_10880_3155_3180(this, node)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 3001, 3275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 3215, 3260);

                    f_10880_3215_3259(this, ref afterSwitchState, ref initialState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 3001, 3275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 3291, 3331);

                return (initialState, afterSwitchState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10880, 1556, 3342);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10880_1759_1774(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 1759, 1774);
                    return return_v;
                }


                int
                f_10880_1747_1775(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 1747, 1775);
                    return 0;
                }


                TLocalState
                f_10880_1819_1837(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 1819, 1837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10880_1876_1892(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.DecisionDag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 1876, 1892);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10880_1876_1908(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.ReachableLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 1876, 1908);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10880_1947_1966(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.SwitchSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 1947, 1966);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10880_2022_2042(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.SwitchLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2022, 2042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10880_2113_2124(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2113, 2124);
                    return return_v;
                }


                bool
                f_10880_2088_2125(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2088, 2125);
                    return return_v;
                }


                bool
                f_10880_2129_2144(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2129, 2144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel?
                f_10880_2182_2199(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2182, 2199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10880_2203_2218(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2203, 2218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10880_2203_2232(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2203, 2232);
                    return return_v;
                }


                bool
                f_10880_2244_2269(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                node)
                {
                    var return_v = this_param.IsTraditionalSwitch(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2244, 2269);
                    return return_v;
                }


                TLocalState
                f_10880_2328_2348(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2328, 2348);
                    return return_v;
                }


                int
                f_10880_2319_2349(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2319, 2349);
                    return 0;
                }


                int
                f_10880_2448_2464(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2448, 2464);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10880_2525_2538(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2525, 2538);
                    return return_v;
                }


                int
                f_10880_2512_2539(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.VisitPattern(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2512, 2539);
                    return 0;
                }


                int
                f_10880_2562_2585(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2562, 2585);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10880_2612_2628(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2612, 2628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10880_2701_2717(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2701, 2717);
                    return return_v;
                }


                int
                f_10880_2686_2718(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2686, 2718);
                    return 0;
                }


                int
                f_10880_2745_2768(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2745, 2768);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10880_2816_2831()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2816, 2831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10880_2873_2884(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 2873, 2884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10880_2836_2885(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2836, 2885);
                    return return_v;
                }


                int
                f_10880_2816_2886(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2816, 2886);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10880_2022_2042_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2022, 2042);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10880_1947_1966_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 1947, 1966);
                    return return_v;
                }


                TLocalState
                f_10880_2968_2986(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 2968, 2986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10880_3005_3021(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.DecisionDag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 3005, 3021);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10880_3005_3037(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.ReachableLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 3005, 3037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10880_3047_3062(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 3047, 3062);
                    return return_v;
                }


                bool
                f_10880_3005_3063(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 3005, 3063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel?
                f_10880_3085_3102(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 3085, 3102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10880_3114_3129(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 3114, 3129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10880_3114_3143(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 3114, 3143);
                    return return_v;
                }


                bool
                f_10880_3155_3180(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                node)
                {
                    var return_v = this_param.IsTraditionalSwitch(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 3155, 3180);
                    return return_v;
                }


                bool
                f_10880_3215_3259(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 3215, 3259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10880, 1556, 3342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10880, 1556, 3342);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsTraditionalSwitch(BoundSwitchStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10880, 3507, 5031);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 4323, 4476) || true) && (f_10880_4327_4354(compilation) >= f_10880_4358_4414(MessageID.IDS_FeatureRecursivePatterns))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 4323, 4476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 4448, 4461);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 4323, 4476);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 4492, 4610) || true) && (!f_10880_4497_4548(f_10880_4497_4517(f_10880_4497_4512(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 4492, 4610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 4582, 4595);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 4492, 4610);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 4626, 4992);
                    foreach (var sectionSyntax in f_10880_4656_4701_I(f_10880_4656_4701(((SwitchStatementSyntax)node.Syntax))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 4626, 4992);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 4735, 4977);
                            foreach (var label in f_10880_4757_4777_I(f_10880_4757_4777(sectionSyntax)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 4735, 4977);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 4819, 4958) || true) && (f_10880_4823_4835(label) == SyntaxKind.CasePatternSwitchLabel)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 4819, 4958);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 4922, 4935);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 4819, 4958);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 4735, 4977);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10880, 1, 243);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10880, 1, 243);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 4626, 4992);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10880, 1, 367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10880, 1, 367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5008, 5020);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10880, 3507, 5031);

                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10880_4327_4354(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 4327, 4354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10880_4358_4414(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 4358, 4414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10880_4497_4512(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 4497, 4512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10880_4497_4517(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 4497, 4517);
                    return return_v;
                }


                bool
                f_10880_4497_4548(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsValidV6SwitchGoverningType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 4497, 4548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10880_4656_4701(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Sections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 4656, 4701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                f_10880_4757_4777(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                this_param)
                {
                    var return_v = this_param.Labels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 4757, 4777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10880_4823_4835(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 4823, 4835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                f_10880_4757_4777_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 4757, 4777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10880_4656_4701_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 4656, 4701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10880, 3507, 5031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10880, 3507, 5031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void VisitSwitchSection(BoundSwitchSection node, bool isLastSection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10880, 5043, 5367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5154, 5183);

                f_10880_5154_5182(this, f_10880_5163_5181(this));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5197, 5315);
                    foreach (var label in f_10880_5219_5236_I(f_10880_5219_5236(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 5197, 5315);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5270, 5300);

                        f_10880_5270_5299(this, f_10880_5281_5292(label), node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 5197, 5315);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10880, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10880, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5331, 5356);

                f_10880_5331_5355(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10880, 5043, 5367);

                TLocalState
                f_10880_5163_5181(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5163, 5181);
                    return return_v;
                }


                int
                f_10880_5154_5182(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5154, 5182);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10880_5219_5236(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.SwitchLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 5219, 5236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10880_5281_5292(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 5281, 5292);
                    return return_v;
                }


                int
                f_10880_5270_5299(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                node)
                {
                    this_param.VisitLabel(label, (Microsoft.CodeAnalysis.CSharp.BoundStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5270, 5299);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10880_5219_5236_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5219, 5236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10880_5331_5355(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                node)
                {
                    var return_v = this_param.VisitStatementList((Microsoft.CodeAnalysis.CSharp.BoundStatementList)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5331, 5355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10880, 5043, 5367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10880, 5043, 5367);
            }
        }

        public override BoundNode VisitSwitchDispatch(BoundSwitchDispatch node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10880, 5379, 5871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5475, 5504);

                f_10880_5475_5503(this, f_10880_5487_5502(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5518, 5549);

                var
                state = f_10880_5530_5548(this.State)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5563, 5634);

                f_10880_5563_5633(f_10880_5563_5578(), f_10880_5583_5632(node, state, f_10880_5614_5631(node)));
                foreach ((_, LabelSymbol label) in f_10880_5683_5693(node))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5727, 5786);

                    f_10880_5727_5785(f_10880_5727_5742(), f_10880_5747_5784(node, state, label));
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5817, 5834);

                f_10880_5817_5833(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 5848, 5860);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10880, 5379, 5871);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10880_5487_5502(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 5487, 5502);
                    return return_v;
                }


                int
                f_10880_5475_5503(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5475, 5503);
                    return 0;
                }


                TLocalState
                f_10880_5530_5548(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5530, 5548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10880_5563_5578()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 5563, 5578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10880_5614_5631(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 5614, 5631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10880_5583_5632(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5583, 5632);
                    return return_v;
                }


                int
                f_10880_5563_5633(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5563, 5633);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                f_10880_5683_5693(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Cases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 5683, 5693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10880_5727_5742()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 5727, 5742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10880_5747_5784(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5747, 5784);
                    return return_v;
                }


                int
                f_10880_5727_5785(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5727, 5785);
                    return 0;
                }


                int
                f_10880_5817_5833(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 5817, 5833);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10880, 5379, 5871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10880, 5379, 5871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConvertedSwitchExpression(BoundConvertedSwitchExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10880, 5883, 6052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6001, 6041);

                return f_10880_6008_6040(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10880, 5883, 6052);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10880_6008_6040(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                node)
                {
                    var return_v = this_param.VisitSwitchExpression((Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6008, 6040);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10880, 5883, 6052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10880, 5883, 6052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUnconvertedSwitchExpression(BoundUnconvertedSwitchExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10880, 6064, 6237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6186, 6226);

                return f_10880_6193_6225(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10880, 6064, 6237);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10880_6193_6225(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                node)
                {
                    var return_v = this_param.VisitSwitchExpression((Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6193, 6225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10880, 6064, 6237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10880, 6064, 6237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode VisitSwitchExpression(BoundSwitchExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10880, 6249, 7261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6341, 6370);

                f_10880_6341_6369(this, f_10880_6353_6368(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6384, 6415);

                var
                dispatchState = this.State
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6429, 6463);

                var
                endState = f_10880_6444_6462(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6477, 6532);

                var
                reachableLabels = f_10880_6499_6531(f_10880_6499_6515(node))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6546, 7189);
                    foreach (var arm in f_10880_6566_6581_I(f_10880_6566_6581(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 6546, 7189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6615, 6647);

                        f_10880_6615_6646(this, f_10880_6624_6645(dispatchState));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6665, 6691);

                        f_10880_6665_6690(this, f_10880_6678_6689(arm));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6709, 6733);

                        f_10880_6709_6732(this, StateWhenTrue);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6751, 6894) || true) && (!f_10880_6756_6791(reachableLabels, f_10880_6781_6790(arm)) || (DynAbs.Tracing.TraceSender.Expression_False(10880, 6755, 6816) || f_10880_6795_6816(f_10880_6795_6806(arm))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 6751, 6894);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6858, 6875);

                            f_10880_6858_6874(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 6751, 6894);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6914, 7078) || true) && (f_10880_6918_6932(arm) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10880, 6914, 7078);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 6982, 7013);

                            f_10880_6982_7012(this, f_10880_6997_7011(arm));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 7035, 7059);

                            f_10880_7035_7058(this, StateWhenTrue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 6914, 7078);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 7098, 7121);

                        f_10880_7098_7120(this, f_10880_7110_7119(arm));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 7139, 7174);

                        f_10880_7139_7173(this, ref endState, ref this.State);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10880, 6546, 7189);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10880, 1, 644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10880, 1, 644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 7205, 7224);

                f_10880_7205_7223(this, endState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10880, 7238, 7250);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10880, 6249, 7261);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10880_6353_6368(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 6353, 6368);
                    return return_v;
                }


                int
                f_10880_6341_6369(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6341, 6369);
                    return 0;
                }


                TLocalState
                f_10880_6444_6462(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6444, 6462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10880_6499_6515(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.DecisionDag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 6499, 6515);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10880_6499_6531(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.ReachableLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 6499, 6531);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10880_6566_6581(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpression
                this_param)
                {
                    var return_v = this_param.SwitchArms;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 6566, 6581);
                    return return_v;
                }


                TLocalState
                f_10880_6624_6645(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6624, 6645);
                    return return_v;
                }


                int
                f_10880_6615_6646(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6615, 6646);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10880_6678_6689(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 6678, 6689);
                    return return_v;
                }


                int
                f_10880_6665_6690(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.VisitPattern(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6665, 6690);
                    return 0;
                }


                int
                f_10880_6709_6732(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6709, 6732);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10880_6781_6790(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 6781, 6790);
                    return return_v;
                }


                bool
                f_10880_6756_6791(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6756, 6791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10880_6795_6806(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 6795, 6806);
                    return return_v;
                }


                bool
                f_10880_6795_6816(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 6795, 6816);
                    return return_v;
                }


                int
                f_10880_6858_6874(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6858, 6874);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10880_6918_6932(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 6918, 6932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10880_6997_7011(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 6997, 7011);
                    return return_v;
                }


                int
                f_10880_6982_7012(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6982, 7012);
                    return 0;
                }


                int
                f_10880_7035_7058(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 7035, 7058);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10880_7110_7119(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10880, 7110, 7119);
                    return return_v;
                }


                int
                f_10880_7098_7120(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 7098, 7120);
                    return 0;
                }


                bool
                f_10880_7139_7173(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 7139, 7173);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10880_6566_6581_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 6566, 6581);
                    return return_v;
                }


                int
                f_10880_7205_7223(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10880, 7205, 7223);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10880, 6249, 7261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10880, 6249, 7261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
