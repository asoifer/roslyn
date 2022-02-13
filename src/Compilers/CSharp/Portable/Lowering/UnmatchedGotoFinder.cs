// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class UnmatchedGotoFinder : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
    {
        private readonly Dictionary<BoundNode, HashSet<LabelSymbol>> _unmatchedLabelsCache;

        private HashSet<LabelSymbol> _gotos;

        private HashSet<LabelSymbol> _targets;

        private UnmatchedGotoFinder(Dictionary<BoundNode, HashSet<LabelSymbol>> unmatchedLabelsCache, int recursionDepth)
        : base(f_10441_1139_1153_C(recursionDepth))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10441, 1005, 1292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 852, 873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 938, 944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 984, 992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 1179, 1222);

                f_10441_1179_1221(unmatchedLabelsCache != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 1236, 1281);

                _unmatchedLabelsCache = unmatchedLabelsCache;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10441, 1005, 1292);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10441, 1005, 1292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 1005, 1292);
            }
        }

        public static HashSet<LabelSymbol> Find(BoundNode node, Dictionary<BoundNode, HashSet<LabelSymbol>> unmatchedLabelsCache, int recursionDepth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10441, 1304, 1874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 1470, 1561);

                UnmatchedGotoFinder
                finder = f_10441_1499_1560(unmatchedLabelsCache, recursionDepth)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 1575, 1594);

                f_10441_1575_1593(finder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 1608, 1651);

                HashSet<LabelSymbol>
                gotos = finder._gotos
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 1665, 1712);

                HashSet<LabelSymbol>
                targets = finder._targets
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 1726, 1836) || true) && (gotos != null && (DynAbs.Tracing.TraceSender.Expression_True(10441, 1730, 1762) && targets != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10441, 1726, 1836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 1796, 1821);

                    f_10441_1796_1820(gotos, targets);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10441, 1726, 1836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 1850, 1863);

                return gotos;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10441, 1304, 1874);

                Microsoft.CodeAnalysis.CSharp.UnmatchedGotoFinder
                f_10441_1499_1560(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                unmatchedLabelsCache, int
                recursionDepth)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnmatchedGotoFinder(unmatchedLabelsCache, recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 1499, 1560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10441_1575_1593(Microsoft.CodeAnalysis.CSharp.UnmatchedGotoFinder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 1575, 1593);
                    return return_v;
                }


                bool
                f_10441_1796_1820(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                set, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                values)
                {
                    var return_v = set.RemoveAll<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 1796, 1820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10441, 1304, 1874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 1304, 1874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode Visit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10441, 1886, 2443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 1958, 1989);

                HashSet<LabelSymbol>
                unmatched
                = default(HashSet<LabelSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2003, 2392) || true) && (node != null && (DynAbs.Tracing.TraceSender.Expression_True(10441, 2007, 2077) && f_10441_2023_2077(_unmatchedLabelsCache, node, out unmatched)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10441, 2003, 2392);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2111, 2320) || true) && (unmatched != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10441, 2111, 2320);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2174, 2301);
                            foreach (LabelSymbol label in f_10441_2204_2213_I(unmatched))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10441, 2174, 2301);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2263, 2278);

                                f_10441_2263_2277(this, label);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10441, 2174, 2301);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10441, 1, 128);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10441, 1, 128);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10441, 2111, 2320);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2340, 2352);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10441, 2003, 2392);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2408, 2432);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10441, 2415, 2431);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10441, 1886, 2443);

                bool
                f_10441_2023_2077(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundNode, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                key, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 2023, 2077);
                    return return_v;
                }


                int
                f_10441_2263_2277(Microsoft.CodeAnalysis.CSharp.UnmatchedGotoFinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.AddGoto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 2263, 2277);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10441_2204_2213_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 2204, 2213);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10441, 1886, 2443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 1886, 2443);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitGotoStatement(BoundGotoStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10441, 2455, 2631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2549, 2569);

                f_10441_2549_2568(this, f_10441_2557_2567(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2583, 2620);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitGotoStatement(node), 10441, 2590, 2619);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10441, 2455, 2631);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10441_2557_2567(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10441, 2557, 2567);
                    return return_v;
                }


                int
                f_10441_2549_2568(Microsoft.CodeAnalysis.CSharp.UnmatchedGotoFinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.AddGoto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 2549, 2568);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10441, 2455, 2631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 2455, 2631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalGoto(BoundConditionalGoto node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10441, 2643, 2825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2741, 2761);

                f_10441_2741_2760(this, f_10441_2749_2759(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2775, 2814);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConditionalGoto(node), 10441, 2782, 2813);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10441, 2643, 2825);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10441_2749_2759(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10441, 2749, 2759);
                    return return_v;
                }


                int
                f_10441_2741_2760(Microsoft.CodeAnalysis.CSharp.UnmatchedGotoFinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.AddGoto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 2741, 2760);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10441, 2643, 2825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 2643, 2825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSwitchDispatch(BoundSwitchDispatch node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10441, 2837, 3148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 2933, 2960);

                f_10441_2933_2959(this, f_10441_2941_2958(node));
                foreach ((_, LabelSymbol label) in f_10441_3009_3019(node))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3053, 3068);

                    f_10441_3053_3067(this, label);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3099, 3137);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSwitchDispatch(node), 10441, 3106, 3136);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10441, 2837, 3148);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10441_2941_2958(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10441, 2941, 2958);
                    return return_v;
                }


                int
                f_10441_2933_2959(Microsoft.CodeAnalysis.CSharp.UnmatchedGotoFinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.AddGoto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 2933, 2959);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                f_10441_3009_3019(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Cases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10441, 3009, 3019);
                    return return_v;
                }


                int
                f_10441_3053_3067(Microsoft.CodeAnalysis.CSharp.UnmatchedGotoFinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.AddGoto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 3053, 3067);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10441, 2837, 3148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 2837, 3148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLabelStatement(BoundLabelStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10441, 3160, 3341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3256, 3278);

                f_10441_3256_3277(this, f_10441_3266_3276(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3292, 3330);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLabelStatement(node), 10441, 3299, 3329);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10441, 3160, 3341);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10441_3266_3276(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10441, 3266, 3276);
                    return return_v;
                }


                int
                f_10441_3256_3277(Microsoft.CodeAnalysis.CSharp.UnmatchedGotoFinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.AddTarget(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 3256, 3277);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10441, 3160, 3341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 3160, 3341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLabeledStatement(BoundLabeledStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10441, 3353, 3540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3453, 3475);

                f_10441_3453_3474(this, f_10441_3463_3473(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3489, 3529);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLabeledStatement(node), 10441, 3496, 3528);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10441, 3353, 3540);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10441_3463_3473(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10441, 3463, 3473);
                    return return_v;
                }


                int
                f_10441_3453_3474(Microsoft.CodeAnalysis.CSharp.UnmatchedGotoFinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.AddTarget(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 3453, 3474);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10441, 3353, 3540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 3353, 3540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddGoto(LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10441, 3552, 3764);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3616, 3719) || true) && (_gotos == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10441, 3616, 3719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3668, 3704);

                    _gotos = f_10441_3677_3703();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10441, 3616, 3719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3735, 3753);

                f_10441_3735_3752(
                            _gotos, label);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10441, 3552, 3764);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10441_3677_3703()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 3677, 3703);
                    return return_v;
                }


                bool
                f_10441_3735_3752(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 3735, 3752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10441, 3552, 3764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 3552, 3764);
            }
        }

        private void AddTarget(LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10441, 3776, 3996);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3842, 3949) || true) && (_targets == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10441, 3842, 3949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3896, 3934);

                    _targets = f_10441_3907_3933();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10441, 3842, 3949);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10441, 3965, 3985);

                f_10441_3965_3984(
                            _targets, label);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10441, 3776, 3996);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10441_3907_3933()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 3907, 3933);
                    return return_v;
                }


                bool
                f_10441_3965_3984(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 3965, 3984);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10441, 3776, 3996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 3776, 3996);
            }
        }

        static UnmatchedGotoFinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10441, 660, 4003);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10441, 660, 4003);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10441, 660, 4003);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10441, 660, 4003);

        int
        f_10441_1179_1221(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10441, 1179, 1221);
            return 0;
        }


        static int
        f_10441_1139_1153_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10441, 1005, 1292);
            return return_v;
        }

    }
}
