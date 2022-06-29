// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis
{
    internal static class TopologicalSort
    {
        public static bool TryIterativeSort<TNode>(IEnumerable<TNode> nodes, Func<TNode, ImmutableArray<TNode>> successors, out ImmutableArray<TNode> result)
                    where TNode : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(115, 1526, 3390);
                System.Collections.Immutable.ImmutableArray<TNode> allNodes = default(System.Collections.Immutable.ImmutableArray<TNode>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 1794, 1916);

                PooledDictionary<TNode, int>
                predecessorCounts = f_115_1843_1915(nodes, successors, out allNodes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2016, 2062);

                var
                ready = f_115_2028_2061()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2076, 2266);
                    foreach (TNode node in f_115_2099_2107_I(allNodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 2076, 2266);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2141, 2251) || true) && (f_115_2145_2168(predecessorCounts, node) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 2141, 2251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2215, 2232);

                            f_115_2215_2231(ready, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(115, 2141, 2251);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(115, 2076, 2266);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(115, 1, 191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(115, 1, 191);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2391, 2445);

                var
                resultBuilder = f_115_2411_2444()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2459, 2979) || true) && (f_115_2466_2477(ready) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 2459, 2979);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2516, 2539);

                        var
                        node = f_115_2527_2538(ready)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2557, 2581);

                        f_115_2557_2580(resultBuilder, node);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2599, 2964);
                            foreach (var succ in f_115_2620_2636_I(f_115_2620_2636(successors, node)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 2599, 2964);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2678, 2714);

                                var
                                count = f_115_2690_2713(predecessorCounts, succ)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2736, 2761);

                                f_115_2736_2760(count != 0);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2783, 2819);

                                predecessorCounts[succ] = count - 1;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2841, 2945) || true) && (count == 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 2841, 2945);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 2905, 2922);

                                    f_115_2905_2921(ready, succ);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(115, 2841, 2945);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(115, 2599, 2964);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(115, 1, 366);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(115, 1, 366);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(115, 2459, 2979);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(115, 2459, 2979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(115, 2459, 2979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3092, 3155);

                bool
                hadCycle = f_115_3108_3131(predecessorCounts) != f_115_3135_3154(resultBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3169, 3247);

                result = (DynAbs.Tracing.TraceSender.Conditional_F1(115, 3178, 3186) || ((hadCycle && DynAbs.Tracing.TraceSender.Conditional_F2(115, 3189, 3216)) || DynAbs.Tracing.TraceSender.Conditional_F3(115, 3219, 3246))) ? ImmutableArray<TNode>.Empty : f_115_3219_3246(resultBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3261, 3286);

                f_115_3261_3285(predecessorCounts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3300, 3313);

                f_115_3300_3312(ready);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3327, 3348);

                f_115_3327_3347(resultBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3362, 3379);

                return !hadCycle;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(115, 1526, 3390);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TNode, int>
                f_115_1843_1915(System.Collections.Generic.IEnumerable<TNode>
                nodes, System.Func<TNode, System.Collections.Immutable.ImmutableArray<TNode>>
                successors, out System.Collections.Immutable.ImmutableArray<TNode>
                allNodes)
                {
                    var return_v = PredecessorCounts(nodes, successors, out allNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 1843, 1915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                f_115_2028_2061()
                {
                    var return_v = ArrayBuilder<TNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2028, 2061);
                    return return_v;
                }


                int
                f_115_2145_2168(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TNode, int>
                this_param, TNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(115, 2145, 2168);
                    return return_v;
                }


                int
                f_115_2215_2231(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                builder, TNode
                e)
                {
                    builder.Push<TNode>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2215, 2231);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TNode>
                f_115_2099_2107_I(System.Collections.Immutable.ImmutableArray<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2099, 2107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                f_115_2411_2444()
                {
                    var return_v = ArrayBuilder<TNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2411, 2444);
                    return return_v;
                }


                int
                f_115_2466_2477(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(115, 2466, 2477);
                    return return_v;
                }


                TNode
                f_115_2527_2538(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                builder)
                {
                    var return_v = builder.Pop<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2527, 2538);
                    return return_v;
                }


                int
                f_115_2557_2580(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param, TNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2557, 2580);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TNode>
                f_115_2620_2636(System.Func<TNode, System.Collections.Immutable.ImmutableArray<TNode>>
                this_param, TNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2620, 2636);
                    return return_v;
                }


                int
                f_115_2690_2713(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TNode, int>
                this_param, TNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(115, 2690, 2713);
                    return return_v;
                }


                int
                f_115_2736_2760(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2736, 2760);
                    return 0;
                }


                int
                f_115_2905_2921(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                builder, TNode
                e)
                {
                    builder.Push<TNode>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2905, 2921);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TNode>
                f_115_2620_2636_I(System.Collections.Immutable.ImmutableArray<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 2620, 2636);
                    return return_v;
                }


                int
                f_115_3108_3131(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TNode, int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(115, 3108, 3131);
                    return return_v;
                }


                int
                f_115_3135_3154(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(115, 3135, 3154);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TNode>
                f_115_3219_3246(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3219, 3246);
                    return return_v;
                }


                int
                f_115_3261_3285(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TNode, int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3261, 3285);
                    return 0;
                }


                int
                f_115_3300_3312(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3300, 3312);
                    return 0;
                }


                int
                f_115_3327_3347(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3327, 3347);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115, 1526, 3390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115, 1526, 3390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PooledDictionary<TNode, int> PredecessorCounts<TNode>(
                    IEnumerable<TNode> nodes,
                    Func<TNode, ImmutableArray<TNode>> successors,
                    out ImmutableArray<TNode> allNodes)
                    where TNode : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(115, 3402, 5033);
                int succPredecessorCount = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3679, 3746);

                var
                predecessorCounts = f_115_3703_3745()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3760, 3809);

                var
                counted = f_115_3774_3808()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3823, 3871);

                var
                toCount = f_115_3837_3870()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3885, 3941);

                var
                allNodesBuilder = f_115_3907_3940()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3955, 3979);

                f_115_3955_3978(toCount, nodes);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 3993, 4861) || true) && (f_115_4000_4013(toCount) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 3993, 4861);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4052, 4074);

                        var
                        n = f_115_4060_4073(toCount)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4092, 4181) || true) && (!f_115_4097_4111(counted, n))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 4092, 4181);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4153, 4162);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(115, 4092, 4181);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4201, 4224);

                        f_115_4201_4223(
                                        allNodesBuilder, n);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4242, 4368) || true) && (!f_115_4247_4279(predecessorCounts, n))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 4242, 4368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4321, 4349);

                            f_115_4321_4348(predecessorCounts, n, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(115, 4242, 4368);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4388, 4846);
                            foreach (var succ in f_115_4409_4422_I(f_115_4409_4422(successors, n)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 4388, 4846);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4464, 4483);

                                f_115_4464_4482(toCount, succ);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4505, 4827) || true) && (f_115_4509_4574(predecessorCounts, succ, out succPredecessorCount))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 4505, 4827);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4624, 4675);

                                    predecessorCounts[succ] = succPredecessorCount + 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(115, 4505, 4827);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(115, 4505, 4827);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4773, 4804);

                                    f_115_4773_4803(predecessorCounts, succ, 1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(115, 4505, 4827);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(115, 4388, 4846);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(115, 1, 459);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(115, 1, 459);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(115, 3993, 4861);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(115, 3993, 4861);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(115, 3993, 4861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4877, 4892);

                f_115_4877_4891(
                            counted);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4906, 4921);

                f_115_4906_4920(toCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4935, 4983);

                allNodes = f_115_4946_4982(allNodesBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(115, 4997, 5022);

                return predecessorCounts;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(115, 3402, 5033);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TNode, int>
                f_115_3703_3745()
                {
                    var return_v = PooledDictionary<TNode, int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3703, 3745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TNode>
                f_115_3774_3808()
                {
                    var return_v = PooledHashSet<TNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3774, 3808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                f_115_3837_3870()
                {
                    var return_v = ArrayBuilder<TNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3837, 3870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                f_115_3907_3940()
                {
                    var return_v = ArrayBuilder<TNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3907, 3940);
                    return return_v;
                }


                int
                f_115_3955_3978(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param, System.Collections.Generic.IEnumerable<TNode>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 3955, 3978);
                    return 0;
                }


                int
                f_115_4000_4013(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(115, 4000, 4013);
                    return return_v;
                }


                TNode
                f_115_4060_4073(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                builder)
                {
                    var return_v = builder.Pop<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4060, 4073);
                    return return_v;
                }


                bool
                f_115_4097_4111(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TNode>
                this_param, TNode
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4097, 4111);
                    return return_v;
                }


                int
                f_115_4201_4223(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param, TNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4201, 4223);
                    return 0;
                }


                bool
                f_115_4247_4279(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TNode, int>
                this_param, TNode
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4247, 4279);
                    return return_v;
                }


                int
                f_115_4321_4348(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TNode, int>
                this_param, TNode
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4321, 4348);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TNode>
                f_115_4409_4422(System.Func<TNode, System.Collections.Immutable.ImmutableArray<TNode>>
                this_param, TNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4409, 4422);
                    return return_v;
                }


                int
                f_115_4464_4482(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                builder, TNode
                e)
                {
                    builder.Push<TNode>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4464, 4482);
                    return 0;
                }


                bool
                f_115_4509_4574(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TNode, int>
                this_param, TNode
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4509, 4574);
                    return return_v;
                }


                int
                f_115_4773_4803(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TNode, int>
                this_param, TNode
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4773, 4803);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TNode>
                f_115_4409_4422_I(System.Collections.Immutable.ImmutableArray<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4409, 4422);
                    return return_v;
                }


                int
                f_115_4877_4891(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TNode>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4877, 4891);
                    return 0;
                }


                int
                f_115_4906_4920(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4906, 4920);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TNode>
                f_115_4946_4982(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNode>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(115, 4946, 4982);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(115, 3402, 5033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115, 3402, 5033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TopologicalSort()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(115, 537, 5040);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(115, 537, 5040);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(115, 537, 5040);
        }

    }
}
