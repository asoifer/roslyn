// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class PatternExplainer
    {
        private static ImmutableArray<BoundDecisionDagNode> ShortestPathToNode(
                    ImmutableArray<BoundDecisionDagNode> nodes,
                    BoundDecisionDagNode node,
                    bool nullPaths,
                    out bool requiresFalseWhenClause)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10362, 1196, 4783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 1534, 1641);

                var
                dist = f_10362_1545_1640()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 1655, 1684);

                int
                nodeCount = nodes.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 1698, 1731);

                int
                infinity = 2 * nodeCount + 2
                ;

                int distance(BoundDecisionDagNode x)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 1745, 2059);
                        (int distance, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode next) v = default((int distance, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode next));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 1814, 1866) || true) && (x == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 1814, 1866);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 1850, 1866);

                            return infinity;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 1814, 1866);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 1884, 1959) || true) && (f_10362_1888_1918(dist, x, out v))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 1884, 1959);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 1941, 1959);

                            return v.distance;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 1884, 1959);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 1977, 2010);

                        f_10362_1977_2009(!nodes.Contains(x));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2028, 2044);

                        return infinity;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 1745, 2059);

                        bool
                        f_10362_1888_1918(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, (int distance, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode next)>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                        key, out (int distance, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode next)
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 1888, 1918);
                            return return_v;
                        }


                        int
                        f_10362_1977_2009(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 1977, 2009);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 1745, 2059);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 1745, 2059);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2084, 2101);

                    for (int
        i = nodeCount - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2075, 3495) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2111, 2114)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 2075, 3495))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 2075, 3495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2148, 2165);

                        var
                        n = nodes[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2183, 3480);

                        f_10362_2183_3479(dist, n, n switch
                        {
                            BoundEvaluationDecisionDagNode e when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2244, 2306) && DynAbs.Tracing.TraceSender.Expression_True(10362, 2244, 2306))
        => (f_10362_2281_2297(f_10362_2290_2296(e)), f_10362_2299_2305(e)),
                            BoundTestDecisionDagNode { Test: BoundDagNonNullTest _ } t when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2388, 2403) || true) && (!nullPaths) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 2388, 2403) || true)
        => (1 + f_10362_2412_2432(f_10362_2421_2431(t)), f_10362_2434_2444(t)),
                            BoundTestDecisionDagNode { Test: BoundDagExplicitNullTest _ } t when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2532, 2547) || true) && (!nullPaths) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 2532, 2547) || true)
        => (1 + f_10362_2556_2577(f_10362_2565_2576(t)), f_10362_2579_2590(t)),
                            BoundTestDecisionDagNode t when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2641, 2726) || true) && (f_10362_2646_2666(f_10362_2655_2665(t)) is var trueDist1 && (DynAbs.Tracing.TraceSender.Expression_True(10362, 2646, 2726) && f_10362_2687_2708(f_10362_2696_2707(t)) is var falseDist1)) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 2641, 2726) || true)
        =>
        (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 2755, 2780) || (((trueDist1 <= falseDist1) && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 2783, 2810)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 2813, 2842))) ? (1 + trueDist1, f_10362_2799_2809(t)) : (1 + falseDist1, f_10362_2830_2841(t)),
                            BoundWhenDecisionDagNode w when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 2892, 2977) || true) && (f_10362_2897_2917(f_10362_2906_2916(w)) is var trueDist2 && (DynAbs.Tracing.TraceSender.Expression_True(10362, 2897, 2977) && f_10362_2938_2959(f_10362_2947_2958(w)) is var falseDist2)) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 2892, 2977) || true)
        =>
        (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 3131, 3156) || ((                        // add nodeCount to the distance if we need to flag that the path requires failure of a when clause
                                (trueDist2 <= falseDist2) && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 3159, 3186)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 3189, 3261))) ? (1 + trueDist2, f_10362_3175_3185(w)) : (1 + ((DynAbs.Tracing.TraceSender.Conditional_F1(10362, 3195, 3217) || ((falseDist2 < nodeCount && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 3220, 3229)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 3232, 3233))) ? nodeCount : 0) + falseDist2, f_10362_3249_3260(w)),
                            // treat the endpoint as distance 1.
                            // treat other nodes as not on the path to the endpoint
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 3419, 3458) && DynAbs.Tracing.TraceSender.Expression_True(10362, 3419, 3458))
        => ((DynAbs.Tracing.TraceSender.Conditional_F1(10362, 3425, 3436) || (((n == node) && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 3439, 3440)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 3443, 3451))) ? 1 : infinity, null),
                        });
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10362, 1, 1421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10362, 1, 1421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 3583, 3628);

                var
                distanceToNode = dist[nodes[0]].distance
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 3642, 3695);

                requiresFalseWhenClause = distanceToNode > nodeCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 3709, 3795);

                var
                result = f_10362_3722_3794(capacity: distanceToNode)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 3835, 3847);
                    for (BoundDecisionDagNode
        n = nodes[0]
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 3809, 4695) || true) && (n != node)
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 3809, 4695))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 3809, 4695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 3893, 3907);

                        f_10362_3893_3906(result, n);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 3925, 4680);

                        switch (n)
                        {

                            case BoundEvaluationDecisionDagNode e:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 3925, 4680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 4040, 4051);

                                n = f_10362_4044_4050(e);
                                DynAbs.Tracing.TraceSender.TraceBreak(10362, 4077, 4083);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 3925, 4680);

                            case BoundTestDecisionDagNode t:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 3925, 4680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 4163, 4208);

                                (int d, BoundDecisionDagNode next) = f_10362_4200_4207(dist, t);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 4234, 4261);

                                f_10362_4234_4260(next != null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 4287, 4327);

                                f_10362_4287_4326(f_10362_4300_4314(next) == (d - 1));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 4353, 4362);

                                n = next;
                                DynAbs.Tracing.TraceSender.TraceBreak(10362, 4388, 4394);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 3925, 4680);

                            case BoundWhenDecisionDagNode w:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 3925, 4680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 4474, 4494);

                                f_10362_4474_4493(result);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 4520, 4536);

                                n = f_10362_4524_4535(w);
                                DynAbs.Tracing.TraceSender.TraceBreak(10362, 4562, 4568);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 3925, 4680);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 3925, 4680);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 4624, 4661);

                                throw f_10362_4630_4660();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 3925, 4680);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10362, 1, 887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10362, 1, 887);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 4711, 4723);

                f_10362_4711_4722(
                            dist);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 4737, 4772);

                return f_10362_4744_4771(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10362, 1196, 4783);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, (int distance, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode next)>
                f_10362_1545_1640()
                {
                    var return_v = PooledDictionary<BoundDecisionDagNode, (int distance, BoundDecisionDagNode next)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 1545, 1640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2290_2296(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2290, 2296);
                    return return_v;
                }


                int
                f_10362_2281_2297(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                x)
                {
                    var return_v = distance(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 2281, 2297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2299_2305(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2299, 2305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2421_2431(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2421, 2431);
                    return return_v;
                }


                int
                f_10362_2412_2432(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                x)
                {
                    var return_v = distance(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 2412, 2432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2434_2444(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2434, 2444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2565_2576(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2565, 2576);
                    return return_v;
                }


                int
                f_10362_2556_2577(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                x)
                {
                    var return_v = distance(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 2556, 2577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2579_2590(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2579, 2590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2655_2665(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2655, 2665);
                    return return_v;
                }


                int
                f_10362_2646_2666(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                x)
                {
                    var return_v = distance(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 2646, 2666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2696_2707(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2696, 2707);
                    return return_v;
                }


                int
                f_10362_2687_2708(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                x)
                {
                    var return_v = distance(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 2687, 2708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2799_2809(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2799, 2809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2830_2841(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2830, 2841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_2906_2916(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2906, 2916);
                    return return_v;
                }


                int
                f_10362_2897_2917(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                x)
                {
                    var return_v = distance(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 2897, 2917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10362_2947_2958(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 2947, 2958);
                    return return_v;
                }


                int
                f_10362_2938_2959(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                x)
                {
                    var return_v = distance(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 2938, 2959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_3175_3185(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 3175, 3185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10362_3249_3260(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 3249, 3260);
                    return return_v;
                }


                int
                f_10362_2183_3479(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, (int distance, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode next)>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                key, (int, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?)
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 2183, 3479);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10362_3722_3794(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundDecisionDagNode>.GetInstance(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 3722, 3794);
                    return return_v;
                }


                int
                f_10362_3893_3906(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 3893, 3906);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_4044_4050(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 4044, 4050);
                    return return_v;
                }


                (int distance, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode next)
                f_10362_4200_4207(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, (int distance, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode next)>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 4200, 4207);
                    return return_v;
                }


                int
                f_10362_4234_4260(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 4234, 4260);
                    return 0;
                }


                int
                f_10362_4300_4314(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                x)
                {
                    var return_v = distance(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 4300, 4314);
                    return return_v;
                }


                int
                f_10362_4287_4326(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 4287, 4326);
                    return 0;
                }


                int
                f_10362_4474_4493(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param)
                {
                    this_param.RemoveLast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 4474, 4493);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10362_4524_4535(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 4524, 4535);
                    return return_v;
                }


                System.Exception
                f_10362_4630_4660()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 4630, 4660);
                    return return_v;
                }


                int
                f_10362_4711_4722(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, (int distance, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode next)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 4711, 4722);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10362_4744_4771(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 4744, 4771);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 1196, 4783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 1196, 4783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string SamplePatternForPathToDagNode(
                    BoundDagTemp rootIdentifier,
                    ImmutableArray<BoundDecisionDagNode> nodes,
                    BoundDecisionDagNode targetNode,
                    bool nullPaths,
                    out bool requiresFalseWhenClause,
                    out bool unnamedEnumValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10362, 5290, 8259);
                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)> constraintBuilder = default(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>);
                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation> evaluationBuilder = default(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 5629, 5654);

                unnamedEnumValue = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 5743, 5838);

                var
                pathToNode = f_10362_5760_5837(nodes, targetNode, nullPaths, out requiresFalseWhenClause)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 5854, 5939);

                var
                constraints = f_10362_5872_5938()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 5953, 6036);

                var
                evaluations = f_10362_5971_6035()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6059, 6064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6066, 6087);
                    for (int
        i = 0
        ,
        n = pathToNode.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6050, 8115) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6096, 6099)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 6050, 8115))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 6050, 8115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6133, 6175);

                        BoundDecisionDagNode
                        node = pathToNode[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6193, 8100);

                        switch (node)
                        {

                            case BoundTestDecisionDagNode t:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 6193, 8100);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6336, 6413);

                                    BoundDecisionDagNode
                                    nextNode = (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 6368, 6379) || (((i < n - 1) && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 6382, 6399)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 6402, 6412))) ? pathToNode[i + 1] : targetNode
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6443, 6550);

                                    bool
                                    sense = f_10362_6456_6466(t) == nextNode || (DynAbs.Tracing.TraceSender.Expression_False(10362, 6456, 6549) || (f_10362_6483_6494(t) != nextNode && (DynAbs.Tracing.TraceSender.Expression_True(10362, 6483, 6548) && f_10362_6510_6520(t) is BoundWhenDecisionDagNode)))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6580, 6607);

                                    BoundDagTest
                                    test = f_10362_6600_6606(t)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6637, 6668);

                                    BoundDagTemp
                                    temp = f_10362_6657_6667(test)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 6698, 7471) || true) && (test is BoundDagTypeTest && (DynAbs.Tracing.TraceSender.Expression_True(10362, 6702, 6744) && sense == false))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 6698, 7471);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 6698, 7471);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 6698, 7471);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 7115, 7369) || true) && (!f_10362_7120_7176(constraints, temp, out constraintBuilder))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 7115, 7369);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 7250, 7334);

                                            f_10362_7250_7333(constraints, temp, constraintBuilder = f_10362_7292_7332());
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 7115, 7369);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 7403, 7440);

                                        f_10362_7403_7439(constraintBuilder, (test, sense));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 6698, 7471);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10362, 7524, 7530);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 6193, 8100);

                            case BoundEvaluationDecisionDagNode e:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 6193, 8100);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 7647, 7686);

                                    BoundDagTemp
                                    temp = f_10362_7667_7685(f_10362_7667_7679(e))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 7716, 7956) || true) && (!f_10362_7721_7777(evaluations, temp, out evaluationBuilder))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 7716, 7956);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 7843, 7925);

                                        f_10362_7843_7924(evaluations, temp, evaluationBuilder = f_10362_7885_7923());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 7716, 7956);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 7986, 8022);

                                    f_10362_7986_8021(evaluationBuilder, f_10362_8008_8020(e));
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10362, 8075, 8081);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 6193, 8100);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10362, 1, 2066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10362, 1, 2066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 8131, 8248);

                return f_10362_8138_8247(rootIdentifier, constraints, evaluations, requireExactType: false, ref unnamedEnumValue);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10362, 5290, 8259);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10362_5760_5837(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                nodes, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                node, bool
                nullPaths, out bool
                requiresFalseWhenClause)
                {
                    var return_v = ShortestPathToNode(nodes, node, nullPaths, out requiresFalseWhenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 5760, 5837);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>>
                f_10362_5872_5938()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 5872, 5938);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                f_10362_5971_6035()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 5971, 6035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_6456_6466(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 6456, 6466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_6483_6494(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 6483, 6494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10362_6510_6520(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 6510, 6520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTest
                f_10362_6600_6606(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 6600, 6606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10362_6657_6667(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 6657, 6667);
                    return return_v;
                }


                bool
                f_10362_7120_7176(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 7120, 7176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>
                f_10362_7292_7332()
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 7292, 7332);
                    return return_v;
                }


                int
                f_10362_7250_7333(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 7250, 7333);
                    return 0;
                }


                int
                f_10362_7403_7439(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>
                this_param, (Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)
                item)
                {
                    this_param.Add(((Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 7403, 7439);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                f_10362_7667_7679(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Evaluation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 7667, 7679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10362_7667_7685(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 7667, 7685);
                    return return_v;
                }


                bool
                f_10362_7721_7777(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 7721, 7777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                f_10362_7885_7923()
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 7885, 7923);
                    return return_v;
                }


                int
                f_10362_7843_7924(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 7843, 7924);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                f_10362_8008_8020(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Evaluation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 8008, 8020);
                    return return_v;
                }


                int
                f_10362_7986_8021(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 7986, 8021);
                    return 0;
                }


                string
                f_10362_8138_8247(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest, bool)>>
                constraintMap, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                evaluationMap, bool
                requireExactType, ref bool
                unnamedEnumValue)
                {
                    var return_v = SamplePatternForTemp(input, constraintMap, evaluationMap, requireExactType: requireExactType, ref unnamedEnumValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 8138, 8247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 5290, 8259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 5290, 8259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string SamplePatternForTemp(
                    BoundDagTemp input,
                    Dictionary<BoundDagTemp, ArrayBuilder<(BoundDagTest test, bool sense)>> constraintMap,
                    Dictionary<BoundDagTemp, ArrayBuilder<BoundDagEvaluation>> evaluationMap,
                    bool requireExactType,
                    ref bool unnamedEnumValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10362, 8271, 20936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 8635, 8684);

                var
                constraints = f_10362_8653_8683(constraintMap, input)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 8698, 8747);

                var
                evaluations = f_10362_8716_8746(evaluationMap, input)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 8763, 9202);

                return
                f_10362_8787_8808() ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10362, 8787, 9201) ?? f_10362_8829_8885(ref unnamedEnumValue) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10362, 8829, 9201) ?? f_10362_8906_8959(ref unnamedEnumValue) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10362, 8906, 9201) ?? f_10362_8980_9023(ref unnamedEnumValue) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10362, 8980, 9201) ?? f_10362_9044_9088(ref unnamedEnumValue) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10362, 9044, 9201) ?? f_10362_9109_9156(ref unnamedEnumValue) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10362, 9109, 9201) ?? f_10362_9177_9201()))))));

                static ImmutableArray<T> getArray<T>(Dictionary<BoundDagTemp, ArrayBuilder<T>> map, BoundDagTemp temp)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10362, 9218, 9464);
                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T> builder = default(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 9353, 9449);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 9360, 9398) || ((f_10362_9360_9398(map, temp, out builder) && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 9401, 9422)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 9425, 9448))) ? f_10362_9401_9422(builder) : ImmutableArray<T>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10362, 9218, 9464);

                        bool
                        f_10362_9360_9398<T>(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 9360, 9398);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<T>
                        f_10362_9401_9422<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 9401, 9422);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 9218, 9464);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 9218, 9464);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string tryHandleSingleTest()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 9558, 10493);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 9619, 10446) || true) && (evaluations.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10362, 9623, 9669) && constraints.Length == 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 9619, 10446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 9711, 10427);

                            switch (constraints[0])
                            {

                                case (test: BoundDagNonNullTest _, sense: var sense):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 9711, 10427);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 9866, 9952);

                                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 9873, 9879) || ((!sense && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 9882, 9888)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 9891, 9951))) ? "null" : (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 9891, 9907) || ((requireExactType && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 9910, 9938)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 9941, 9951))) ? f_10362_9910_9938(f_10362_9910_9920(input)) : "not null";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 9711, 10427);

                                case (test: BoundDagExplicitNullTest _, sense: var sense):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 9711, 10427);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 10066, 10151);

                                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 10073, 10078) || ((sense && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 10081, 10087)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 10090, 10150))) ? "null" : (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 10090, 10106) || ((requireExactType && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 10109, 10137)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 10140, 10150))) ? f_10362_10109_10137(f_10362_10109_10119(input)) : "not null";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 9711, 10427);

                                case (test: BoundDagTypeTest { Type: var testedType }, sense: var sense):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 9711, 10427);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 10280, 10300);

                                    f_10362_10280_10299(sense);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 10368, 10404);

                                    return f_10362_10375_10403(testedType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 9711, 10427);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 9619, 10446);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 10466, 10478);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 9558, 10493);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_9910_9920(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 9910, 9920);
                            return return_v;
                        }


                        string
                        f_10362_9910_9938(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ToDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 9910, 9938);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_10109_10119(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 10109, 10119);
                            return return_v;
                        }


                        string
                        f_10362_10109_10137(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ToDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 10109, 10137);
                            return return_v;
                        }


                        int
                        f_10362_10280_10299(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 10280, 10299);
                            return 0;
                        }


                        string
                        f_10362_10375_10403(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ToDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 10375, 10403);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 9558, 10493);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 9558, 10493);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string tryHandleTypeTestAndTypeEvaluation(ref bool unnamedEnumValue)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 10587, 11333);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 10688, 11286) || true) && (evaluations.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10362, 10692, 10742) && constraints.Length == 1) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 10692, 10838) && constraints[0] is (BoundDagTypeTest { Type: var constraintType }, true)) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 10692, 10935) && evaluations[0] is BoundDagTypeEvaluation { Type: var evaluationType } te) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 10692, 11031) && f_10362_10960_11031(constraintType, evaluationType, TypeCompareKind.AllIgnoreOptions)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 10688, 11286);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 11073, 11130);

                            var
                            typedTemp = f_10362_11089_11129(te.Syntax, f_10362_11117_11124(te), te)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 11152, 11267);

                            return f_10362_11159_11266(typedTemp, constraintMap, evaluationMap, requireExactType: true, ref unnamedEnumValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 10688, 11286);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 11306, 11318);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 10587, 11333);

                        bool
                        f_10362_10960_11031(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        t2, Microsoft.CodeAnalysis.TypeCompareKind
                        compareKind)
                        {
                            var return_v = this_param.Equals(t2, compareKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 10960, 11031);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_11117_11124(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 11117, 11124);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10362_11089_11129(Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type, Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                        source)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 11089, 11129);
                            return return_v;
                        }


                        string
                        f_10362_11159_11266(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        input, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)>>
                        constraintMap, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                        evaluationMap, bool
                        requireExactType, ref bool
                        unnamedEnumValue)
                        {
                            var return_v = SamplePatternForTemp(input, constraintMap, evaluationMap, requireExactType: requireExactType, ref unnamedEnumValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 11159, 11266);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 10587, 11333);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 10587, 11333);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string tryHandleUnboxNullableValueType(ref bool unnamedEnumValue)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 11457, 12390);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 11555, 12343) || true) && (evaluations.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10362, 11559, 11609) && constraints.Length == 1) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 11559, 11681) && constraints[0] is (BoundDagNonNullTest _, true)) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 11559, 11778) && evaluations[0] is BoundDagTypeEvaluation { Type: var evaluationType } te) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 11559, 11830) && f_10362_11803_11830(f_10362_11803_11813(input))) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 11559, 11929) && f_10362_11834_11929(f_10362_11834_11872(f_10362_11834_11844(input)), evaluationType, TypeCompareKind.AllIgnoreOptions)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 11555, 12343);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 11971, 12028);

                            var
                            typedTemp = f_10362_11987_12027(te.Syntax, f_10362_12015_12022(te), te)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 12050, 12172);

                            var
                            result = f_10362_12063_12171(typedTemp, constraintMap, evaluationMap, requireExactType: false, ref unnamedEnumValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 12279, 12324);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 12286, 12301) || (((result == "_") && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 12304, 12314)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 12317, 12323))) ? "not null" : result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 11555, 12343);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 12363, 12375);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 11457, 12390);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_11803_11813(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 11803, 11813);
                            return return_v;
                        }


                        bool
                        f_10362_11803_11830(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsNullableType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 11803, 11830);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_11834_11844(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 11834, 11844);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_11834_11872(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.GetNullableUnderlyingType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 11834, 11872);
                            return return_v;
                        }


                        bool
                        f_10362_11834_11929(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        t2, Microsoft.CodeAnalysis.TypeCompareKind
                        compareKind)
                        {
                            var return_v = this_param.Equals(t2, compareKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 11834, 11929);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_12015_12022(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 12015, 12022);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10362_11987_12027(Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type, Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                        source)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 11987, 12027);
                            return return_v;
                        }


                        string
                        f_10362_12063_12171(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        input, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)>>
                        constraintMap, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                        evaluationMap, bool
                        requireExactType, ref bool
                        unnamedEnumValue)
                        {
                            var return_v = SamplePatternForTemp(input, constraintMap, evaluationMap, requireExactType: requireExactType, ref unnamedEnumValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 12063, 12171);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 11457, 12390);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 11457, 12390);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string tryHandleTuplePattern(ref bool unnamedEnumValue)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 12465, 14173);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 12553, 13833) || true) && (f_10362_12557_12579(f_10362_12557_12567(input)) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 12557, 12623) && constraints.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 12557, 12745) && evaluations.All(e => e is BoundDagFieldEvaluation { Field: var field } && field.IsTupleElement())))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 12553, 13833);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 12787, 12827);

                            var
                            elements = f_10362_12802_12826(f_10362_12802_12812(input))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 12849, 12883);

                            int
                            cardinality = elements.Length
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 12905, 12961);

                            var
                            subpatterns = f_10362_12923_12960(cardinality)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 12983, 13021);

                            f_10362_12983_13020(subpatterns, "_", cardinality);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13043, 13697);
                                foreach (BoundDagFieldEvaluation e in f_10362_13081_13092_I(evaluations))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 13043, 13697);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13142, 13204);

                                    var
                                    elementTemp = f_10362_13160_13203(e.Syntax, f_10362_13187_13199(f_10362_13187_13194(e)), e)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13230, 13268);

                                    var
                                    index = f_10362_13242_13267(f_10362_13242_13249(e))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13294, 13374) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(10362, 13298, 13331) || index >= cardinality))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 13294, 13374);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13362, 13374);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 13294, 13374);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13400, 13436);

                                    var
                                    oldPattern = f_10362_13417_13435(subpatterns, index)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13462, 13590);

                                    var
                                    newPattern = f_10362_13479_13589(elementTemp, constraintMap, evaluationMap, requireExactType: false, ref unnamedEnumValue)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13616, 13674);

                                    subpatterns[index] = f_10362_13637_13673(oldPattern, newPattern);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 13043, 13697);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10362, 1, 655);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10362, 1, 655);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13721, 13814);

                            return "(" + f_10362_13734_13764(", ", subpatterns) + ")" + ((DynAbs.Tracing.TraceSender.Conditional_F1(10362, 13774, 13796) || ((f_10362_13774_13791(subpatterns) == 1 && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 13799, 13805)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 13808, 13812))) ? " { }" : null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 12553, 13833);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13853, 13865);

                        return null;

                        static string makeConjunct(string oldPattern, string newPattern)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 13950, 14157);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 13953, 14157);
                                return (oldPattern, newPattern) switch
                                {
                                    ("_", var x) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 14025, 14042) && DynAbs.Tracing.TraceSender.Expression_True(10362, 14025, 14042))
                => x,
                                    (var x, "_") when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 14065, 14082) && DynAbs.Tracing.TraceSender.Expression_True(10362, 14065, 14082))
                => x,
                                    (var x, var y) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 14105, 14138) && DynAbs.Tracing.TraceSender.Expression_True(10362, 14105, 14138))
                => x + " and " + y
                                }; DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 13950, 14157);
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 13950, 14157);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 13950, 14157);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 12465, 14173);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_12557_12567(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 12557, 12567);
                            return return_v;
                        }


                        bool
                        f_10362_12557_12579(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsTupleType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 12557, 12579);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_12802_12812(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 12802, 12812);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                        f_10362_12802_12826(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.TupleElements;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 12802, 12826);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                        f_10362_12923_12960(int
                        size)
                        {
                            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>(size);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 12923, 12960);
                            return return_v;
                        }


                        int
                        f_10362_12983_13020(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                        this_param, string
                        item, int
                        count)
                        {
                            this_param.AddMany(item, count);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 12983, 13020);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10362_13187_13194(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                        this_param)
                        {
                            var return_v = this_param.Field;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 13187, 13194);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_13187_13199(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 13187, 13199);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10362_13160_13203(Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type, Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                        source)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 13160, 13203);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10362_13242_13249(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                        this_param)
                        {
                            var return_v = this_param.Field;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 13242, 13249);
                            return return_v;
                        }


                        int
                        f_10362_13242_13267(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        this_param)
                        {
                            var return_v = this_param.TupleElementIndex;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 13242, 13267);
                            return return_v;
                        }


                        string
                        f_10362_13417_13435(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 13417, 13435);
                            return return_v;
                        }


                        string
                        f_10362_13479_13589(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        input, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)>>
                        constraintMap, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                        evaluationMap, bool
                        requireExactType, ref bool
                        unnamedEnumValue)
                        {
                            var return_v = SamplePatternForTemp(input, constraintMap, evaluationMap, requireExactType: requireExactType, ref unnamedEnumValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 13479, 13589);
                            return return_v;
                        }


                        string
                        f_10362_13637_13673(string
                        oldPattern, string
                        newPattern)
                        {
                            var return_v = makeConjunct(oldPattern, newPattern);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 13637, 13673);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                        f_10362_13081_13092_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 13081, 13092);
                            return return_v;
                        }


                        string
                        f_10362_13734_13764(string
                        separator, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                        values)
                        {
                            var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 13734, 13764);
                            return return_v;
                        }


                        int
                        f_10362_13774_13791(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 13774, 13791);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 12465, 14173);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 12465, 14173);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string tryHandleNumericLimits(ref bool unnamedEnumValue)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 14247, 16429);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 14336, 16382) || true) && (evaluations.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10362, 14340, 14753) && constraints.All(t => t switch
                             {
                                 (BoundDagValueTest _, _) => true,
                                 (BoundDagRelationalTest _, _) => true,
                                 (BoundDagExplicitNullTest _, false) => true,
                                 (BoundDagNonNullTest _, true) => true,
                                 _ => false
                             })) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 14340, 14824) && f_10362_14778_14813(f_10362_14802_14812(input)) is { } fac))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 14336, 16382);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 14972, 15008);

                            var
                            remainingValues = f_10362_14994_15007(fac)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 15030, 16107);
                                foreach (var constraint in f_10362_15057_15068_I(constraints))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 15030, 16107);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 15118, 15149);

                                    var (test, sense) = constraint;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 15175, 15585);

                                    switch (test)
                                    {

                                        case BoundDagValueTest v:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 15175, 15585);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 15304, 15351);

                                            f_10362_15304_15350(BinaryOperatorKind.Equal, f_10362_15342_15349(v));
                                            DynAbs.Tracing.TraceSender.TraceBreak(10362, 15385, 15391);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 15175, 15585);

                                        case BoundDagRelationalTest r:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 15175, 15585);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 15485, 15518);

                                            f_10362_15485_15517(f_10362_15497_15507(r), f_10362_15509_15516(r));
                                            DynAbs.Tracing.TraceSender.TraceBreak(10362, 15552, 15558);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 15175, 15585);
                                    }


                                    int
                                    f_10362_15304_15350(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                                    relation, Microsoft.CodeAnalysis.ConstantValue
                                    value)
                                    {
                                        addRelation(relation, value);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 15304, 15350);
                                        return 0;
                                    }


                                    int
                                    f_10362_15485_15517(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                                    relation, Microsoft.CodeAnalysis.ConstantValue
                                    value)
                                    {
                                        addRelation(relation, value);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 15485, 15517);
                                        return 0;
                                    }


                                    void addRelation(BinaryOperatorKind relation, ConstantValue value)
                                    {
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 15611, 16084);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 15734, 15791) || true) && (f_10362_15738_15749(value))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 15734, 15791);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 15784, 15791);

                                                return;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 15734, 15791);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 15821, 15865);

                                            var
                                            filtered = f_10362_15836_15864(fac, relation, value)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 15895, 15973) || true) && (!sense)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 15895, 15973);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 15940, 15973);

                                                filtered = f_10362_15951_15972(filtered);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 15895, 15973);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 16003, 16057);

                                            remainingValues = f_10362_16021_16056(remainingValues, filtered);
                                            DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 15611, 16084);

                                            bool
                                            f_10362_15738_15749(Microsoft.CodeAnalysis.ConstantValue
                                            this_param)
                                            {
                                                var return_v = this_param.IsBad;
                                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 15738, 15749);
                                                return return_v;
                                            }


                                            Microsoft.CodeAnalysis.CSharp.IValueSet
                                            f_10362_15836_15864(Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                                            this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                                            relation, Microsoft.CodeAnalysis.ConstantValue
                                            value)
                                            {
                                                var return_v = this_param.Related(relation, value);
                                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 15836, 15864);
                                                return return_v;
                                            }


                                            Microsoft.CodeAnalysis.CSharp.IValueSet
                                            f_10362_15951_15972(Microsoft.CodeAnalysis.CSharp.IValueSet
                                            this_param)
                                            {
                                                var return_v = this_param.Complement();
                                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 15951, 15972);
                                                return return_v;
                                            }


                                            Microsoft.CodeAnalysis.CSharp.IValueSet
                                            f_10362_16021_16056(Microsoft.CodeAnalysis.CSharp.IValueSet
                                            this_param, Microsoft.CodeAnalysis.CSharp.IValueSet
                                            other)
                                            {
                                                var return_v = this_param.Intersect(other);
                                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 16021, 16056);
                                                return return_v;
                                            }

                                        }
                                        catch
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 15611, 16084);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 15611, 16084);
                                        }
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 15030, 16107);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10362, 1, 1078);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10362, 1, 1078);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 16131, 16209) || true) && (f_10362_16135_16171(f_10362_16135_16163(remainingValues)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 16131, 16209);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 16198, 16209);

                                return "_";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 16131, 16209);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 16233, 16363);

                            return f_10362_16240_16362(remainingValues, f_10362_16275_16285(input), requireExactType: requireExactType, unnamedEnumValue: ref unnamedEnumValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 14336, 16382);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 16402, 16414);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 14247, 16429);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_14802_14812(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 14802, 14812);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.IValueSetFactory?
                        f_10362_14778_14813(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = ValueSetFactory.ForType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 14778, 14813);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.IValueSet
                        f_10362_14994_15007(Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                        this_param)
                        {
                            var return_v = this_param.AllValues;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 14994, 15007);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue
                        f_10362_15342_15349(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 15342, 15349);
                            return return_v;
                        }



                        Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        f_10362_15497_15507(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                        this_param)
                        {
                            var return_v = this_param.Relation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 15497, 15507);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValue
                        f_10362_15509_15516(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 15509, 15516);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)>
                        f_10362_15057_15068_I(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 15057, 15068);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.IValueSet
                        f_10362_16135_16163(Microsoft.CodeAnalysis.CSharp.IValueSet
                        this_param)
                        {
                            var return_v = this_param.Complement();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 16135, 16163);
                            return return_v;
                        }


                        bool
                        f_10362_16135_16171(Microsoft.CodeAnalysis.CSharp.IValueSet
                        this_param)
                        {
                            var return_v = this_param.IsEmpty;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 16135, 16171);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_16275_16285(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 16275, 16285);
                            return return_v;
                        }


                        string
                        f_10362_16240_16362(Microsoft.CodeAnalysis.CSharp.IValueSet
                        remainingValues, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type, bool
                        requireExactType, ref bool
                        unnamedEnumValue)
                        {
                            var return_v = SampleValueString(remainingValues, type, requireExactType: requireExactType, unnamedEnumValue: ref unnamedEnumValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 16240, 16362);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 14247, 16429);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 14247, 16429);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string tryHandleRecursivePattern(ref bool unnamedEnumValue)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 16508, 20668);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 16600, 16681) || true) && (constraints.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10362, 16604, 16646) && evaluations.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 16600, 16681);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 16669, 16681);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 16600, 16681);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 16701, 17124) || true) && (!constraints.All(c => c switch
                                          {
                    // not-null tests are implicitly incorporated into a recursive pattern
                    (test: BoundDagNonNullTest _, sense: true) => true,
                                              (test: BoundDagExplicitNullTest _, sense: false) => true,
                                              _ => false,
                                          }))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 16701, 17124);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17093, 17105);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 16701, 17124);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17144, 17173);

                        string
                        deconstruction = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17191, 17241);

                        var
                        properties = f_10362_17208_17240()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17259, 17292);

                        bool
                        needsPropertyString = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17312, 20090);
                            foreach (var eval in f_10362_17333_17344_I(evaluations))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 17312, 20090);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17386, 20071);

                                switch (eval)
                                {

                                    case BoundDagDeconstructEvaluation e:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 17386, 20071);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17515, 17548);

                                        var
                                        method = f_10362_17528_17547(e)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17578, 17639);

                                        int
                                        extensionExtra = (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 17599, 17630) || ((f_10362_17599_17630(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 17633, 17634)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 17637, 17638))) ? 0 : 1
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17669, 17723);

                                        int
                                        count = method.Parameters.Length - extensionExtra
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17753, 17800);

                                        var
                                        subpatternBuilder = f_10362_17777_17799("(")
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17839, 17844);
                                            for (int
                j = 0
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17830, 18399) || true) && (j < count)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17857, 17860)
                , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 17830, 18399))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 17830, 18399);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 17926, 18021);

                                                var
                                                elementTemp = f_10362_17944_18020(e.Syntax, f_10362_17971_18013(f_10362_17971_17988(method)[j + extensionExtra]), e, j)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18055, 18183);

                                                var
                                                newPattern = f_10362_18072_18182(elementTemp, constraintMap, evaluationMap, requireExactType: false, ref unnamedEnumValue)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18217, 18297) || true) && (j != 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 18217, 18297);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18266, 18297);

                                                    f_10362_18266_18296(subpatternBuilder, ", ");
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 18217, 18297);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18331, 18368);

                                                f_10362_18331_18367(subpatternBuilder, newPattern);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10362, 1, 570);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10362, 1, 570);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18429, 18459);

                                        f_10362_18429_18458(subpatternBuilder, ")");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18489, 18531);

                                        var
                                        result = f_10362_18502_18530(subpatternBuilder)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18561, 18826) || true) && (deconstruction != null && (DynAbs.Tracing.TraceSender.Expression_True(10362, 18565, 18610) && needsPropertyString))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 18561, 18826);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18676, 18717);

                                            deconstruction = deconstruction + " { }";
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18751, 18795);

                                            needsPropertyString = f_10362_18773_18789(properties) != 0;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 18561, 18826);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18858, 18945);

                                        deconstruction = (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 18875, 18899) || (((deconstruction is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 18902, 18908)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 18911, 18944))) ? result : deconstruction + " and " + result;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 18975, 19009);

                                        needsPropertyString |= count == 1;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10362, 19039, 19045);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 17386, 20071);

                                    case BoundDagFieldEvaluation e:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 17386, 20071);
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 19167, 19226);

                                            var
                                            subInput = f_10362_19182_19225(e.Syntax, f_10362_19209_19221(f_10362_19209_19216(e)), e)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 19260, 19367);

                                            var
                                            subPattern = f_10362_19277_19366(subInput, constraintMap, evaluationMap, false, ref unnamedEnumValue)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 19401, 19437);

                                            f_10362_19401_19436(properties, f_10362_19416_19423(e), subPattern);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10362, 19498, 19504);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 17386, 20071);

                                    case BoundDagPropertyEvaluation e:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 17386, 20071);
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 19629, 19691);

                                            var
                                            subInput = f_10362_19644_19690(e.Syntax, f_10362_19671_19686(f_10362_19671_19681(e)), e)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 19725, 19832);

                                            var
                                            subPattern = f_10362_19742_19831(subInput, constraintMap, evaluationMap, false, ref unnamedEnumValue)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 19866, 19905);

                                            f_10362_19866_19904(properties, f_10362_19881_19891(e), subPattern);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10362, 19966, 19972);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 17386, 20071);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 17386, 20071);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 20036, 20048);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 17386, 20071);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 17312, 20090);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10362, 1, 2779);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10362, 1, 2779);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 20110, 20183);

                        string
                        typeName = (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 20128, 20144) || ((requireExactType && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 20147, 20175)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 20178, 20182))) ? f_10362_20147_20175(f_10362_20147_20157(input)) : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 20201, 20292);

                        needsPropertyString |= deconstruction == null && (DynAbs.Tracing.TraceSender.Expression_True(10362, 20224, 20266) && typeName == null) || (DynAbs.Tracing.TraceSender.Expression_False(10362, 20224, 20291) || f_10362_20270_20286(properties) != 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 20310, 20484);

                        var
                        propertyString = (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 20331, 20350) || ((needsPropertyString && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 20353, 20476)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 20479, 20483))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(10362, 20354, 20376) || ((deconstruction != null && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 20379, 20383)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 20386, 20389))) ? " {" : "{") + f_10362_20393_20469(", ", f_10362_20411_20468(properties, kvp => $" {kvp.Key.Name}: {kvp.Value}")) + " }" : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 20502, 20585);

                        f_10362_20502_20584(typeName != null || (DynAbs.Tracing.TraceSender.Expression_False(10362, 20515, 20557) || deconstruction != null) || (DynAbs.Tracing.TraceSender.Expression_False(10362, 20515, 20583) || propertyString != null));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 20603, 20653);

                        return typeName + deconstruction + propertyString;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 16508, 20668);

                        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, string>
                        f_10362_17208_17240()
                        {
                            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, string>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 17208, 17240);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10362_17528_17547(Microsoft.CodeAnalysis.CSharp.BoundDagDeconstructEvaluation
                        this_param)
                        {
                            var return_v = this_param.DeconstructMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 17528, 17547);
                            return return_v;
                        }


                        bool
                        f_10362_17599_17630(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.RequiresInstanceReceiver;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 17599, 17630);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_10362_17777_17799(string
                        value)
                        {
                            var return_v = new System.Text.StringBuilder(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 17777, 17799);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10362_17971_17988(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 17971, 17988);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_17971_18013(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 17971, 18013);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10362_17944_18020(Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type, Microsoft.CodeAnalysis.CSharp.BoundDagDeconstructEvaluation
                        source, int
                        index)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source, index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 17944, 18020);
                            return return_v;
                        }


                        string
                        f_10362_18072_18182(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        input, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)>>
                        constraintMap, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                        evaluationMap, bool
                        requireExactType, ref bool
                        unnamedEnumValue)
                        {
                            var return_v = SamplePatternForTemp(input, constraintMap, evaluationMap, requireExactType: requireExactType, ref unnamedEnumValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 18072, 18182);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_10362_18266_18296(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 18266, 18296);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_10362_18331_18367(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 18331, 18367);
                            return return_v;
                        }


                        System.Text.StringBuilder
                        f_10362_18429_18458(System.Text.StringBuilder
                        this_param, string
                        value)
                        {
                            var return_v = this_param.Append(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 18429, 18458);
                            return return_v;
                        }


                        string
                        f_10362_18502_18530(System.Text.StringBuilder
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 18502, 18530);
                            return return_v;
                        }


                        int
                        f_10362_18773_18789(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, string>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 18773, 18789);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10362_19209_19216(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                        this_param)
                        {
                            var return_v = this_param.Field;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 19209, 19216);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_19209_19221(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 19209, 19221);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10362_19182_19225(Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type, Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                        source)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 19182, 19225);
                            return return_v;
                        }


                        string
                        f_10362_19277_19366(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        input, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)>>
                        constraintMap, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                        evaluationMap, bool
                        requireExactType, ref bool
                        unnamedEnumValue)
                        {
                            var return_v = SamplePatternForTemp(input, constraintMap, evaluationMap, requireExactType, ref unnamedEnumValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 19277, 19366);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10362_19416_19423(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                        this_param)
                        {
                            var return_v = this_param.Field;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 19416, 19423);
                            return return_v;
                        }


                        int
                        f_10362_19401_19436(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, string>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        key, string
                        value)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 19401, 19436);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        f_10362_19671_19681(Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                        this_param)
                        {
                            var return_v = this_param.Property;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 19671, 19681);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_19671_19686(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 19671, 19686);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10362_19644_19690(Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type, Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                        source)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 19644, 19690);
                            return return_v;
                        }


                        string
                        f_10362_19742_19831(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        input, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)>>
                        constraintMap, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                        evaluationMap, bool
                        requireExactType, ref bool
                        unnamedEnumValue)
                        {
                            var return_v = SamplePatternForTemp(input, constraintMap, evaluationMap, requireExactType, ref unnamedEnumValue);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 19742, 19831);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        f_10362_19881_19891(Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                        this_param)
                        {
                            var return_v = this_param.Property;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 19881, 19891);
                            return return_v;
                        }


                        int
                        f_10362_19866_19904(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, string>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                        key, string
                        value)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 19866, 19904);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                        f_10362_17333_17344_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 17333, 17344);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_20147_20157(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 20147, 20157);
                            return return_v;
                        }


                        string
                        f_10362_20147_20175(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ToDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 20147, 20175);
                            return return_v;
                        }


                        int
                        f_10362_20270_20286(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, string>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 20270, 20286);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<string>
                        f_10362_20411_20468(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, string>
                        source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.Symbol, string>, string>
                        selector)
                        {
                            var return_v = source.Select<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.Symbol, string>, string>(selector);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 20411, 20468);
                            return return_v;
                        }


                        string
                        f_10362_20393_20469(string
                        separator, System.Collections.Generic.IEnumerable<string>
                        values)
                        {
                            var return_v = string.Join(separator, values);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 20393, 20469);
                            return return_v;
                        }


                        int
                        f_10362_20502_20584(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 20502, 20584);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 16508, 20668);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 16508, 20668);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                string produceFallbackPattern()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 20785, 20925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 20849, 20910);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 20856, 20872) || ((requireExactType && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 20875, 20903)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 20906, 20909))) ? f_10362_20875_20903(f_10362_20875_20885(input)) : "_";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 20785, 20925);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10362_20875_20885(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 20875, 20885);
                            return return_v;
                        }


                        string
                        f_10362_20875_20903(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.ToDisplayString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 20875, 20903);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 20785, 20925);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 20785, 20925);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10362, 8271, 20936);

                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)>
                f_10362_8653_8683(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundDagTest test, bool sense)>>
                map, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                temp)
                {
                    var return_v = getArray(map, temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 8653, 8683);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                f_10362_8716_8746(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>>
                map, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                temp)
                {
                    var return_v = getArray(map, temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 8716, 8746);
                    return return_v;
                }


                string
                f_10362_8787_8808()
                {
                    var return_v = tryHandleSingleTest();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 8787, 8808);
                    return return_v;
                }


                string
                f_10362_8829_8885(ref bool
                unnamedEnumValue)
                {
                    var return_v = tryHandleTypeTestAndTypeEvaluation(ref unnamedEnumValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 8829, 8885);
                    return return_v;
                }


                string
                f_10362_8906_8959(ref bool
                unnamedEnumValue)
                {
                    var return_v = tryHandleUnboxNullableValueType(ref unnamedEnumValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 8906, 8959);
                    return return_v;
                }


                string
                f_10362_8980_9023(ref bool
                unnamedEnumValue)
                {
                    var return_v = tryHandleTuplePattern(ref unnamedEnumValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 8980, 9023);
                    return return_v;
                }


                string
                f_10362_9044_9088(ref bool
                unnamedEnumValue)
                {
                    var return_v = tryHandleNumericLimits(ref unnamedEnumValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 9044, 9088);
                    return return_v;
                }


                string
                f_10362_9109_9156(ref bool
                unnamedEnumValue)
                {
                    var return_v = tryHandleRecursivePattern(ref unnamedEnumValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 9109, 9156);
                    return return_v;
                }


                string
                f_10362_9177_9201()
                {
                    var return_v = produceFallbackPattern();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 9177, 9201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 8271, 20936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 8271, 20936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string SampleValueString(IValueSet remainingValues, TypeSymbol type, bool requireExactType, ref bool unnamedEnumValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10362, 20948, 23492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 21219, 21258);

                f_10362_21219_21257(f_10362_21232_21256_M(!remainingValues.IsEmpty));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 21438, 22126) || true) && (type is NamedTypeSymbol { TypeKind: TypeKind.Enum } e)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 21438, 22126);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 21529, 22067);
                        foreach (var declaredMember in f_10362_21560_21574_I(f_10362_21560_21574(e)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 21529, 22067);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 21616, 22048) || true) && (declaredMember is FieldSymbol { IsConst: true, IsStatic: true, DeclaredAccessibility: Accessibility.Public } field && (DynAbs.Tracing.TraceSender.Expression_True(10362, 21620, 21855) && f_10362_21763_21824(field, ConstantFieldsInProgress.Empty, false) is ConstantValue constantValue) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 21620, 21944) && f_10362_21884_21944(remainingValues, BinaryOperatorKind.Equal, constantValue)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 21616, 22048);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 21994, 22025);

                                return f_10362_22001_22024(field);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 21616, 22048);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 21529, 22067);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10362, 1, 539);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10362, 1, 539);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 22087, 22111);

                    unnamedEnumValue = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 21438, 22126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 22142, 22178);

                var
                sample = f_10362_22155_22177(remainingValues)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 22192, 22280) || true) && (sample != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 22192, 22280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 22229, 22280);

                    return f_10362_22236_22279(sample, type, requireExactType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 22192, 22280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 22548, 22601);

                var
                underlyingType = f_10362_22569_22600(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 22615, 22664);

                f_10362_22615_22663(f_10362_22628_22662(underlyingType));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 22678, 23428) || true) && (f_10362_22682_22708(underlyingType) == SpecialType.System_IntPtr)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 22678, 23428);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 22771, 22936) || true) && (f_10362_22775_22862(remainingValues, BinaryOperatorKind.GreaterThan, f_10362_22827_22861(int.MaxValue)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 22771, 22936);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 22885, 22936);

                        return $"> ({f_10362_22898_22920(type)})int.MaxValue";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 22771, 22936);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 22956, 23118) || true) && (f_10362_22960_23044(remainingValues, BinaryOperatorKind.LessThan, f_10362_23009_23043(int.MinValue)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 22956, 23118);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 23067, 23118);

                        return $"< ({f_10362_23080_23102(type)})int.MinValue";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 22956, 23118);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 22678, 23428);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 22678, 23428);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 23152, 23428) || true) && (f_10362_23156_23182(underlyingType) == SpecialType.System_UIntPtr)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 23152, 23428);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 23246, 23413) || true) && (f_10362_23250_23338(remainingValues, BinaryOperatorKind.GreaterThan, f_10362_23302_23337(uint.MaxValue)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 23246, 23413);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 23361, 23413);

                            return $"> ({f_10362_23374_23396(type)})uint.MaxValue";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 23246, 23413);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 23152, 23428);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 22678, 23428);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 23444, 23481);

                throw f_10362_23450_23480();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10362, 20948, 23492);

                bool
                f_10362_21232_21256_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 21232, 21256);
                    return return_v;
                }


                int
                f_10362_21219_21257(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 21219, 21257);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10362_21560_21574(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 21560, 21574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10362_21763_21824(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 21763, 21824);
                    return return_v;
                }


                bool
                f_10362_21884_21944(Microsoft.CodeAnalysis.CSharp.IValueSet
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                relation, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    var return_v = this_param.Any(relation, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 21884, 21944);
                    return return_v;
                }


                string
                f_10362_22001_22024(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 22001, 22024);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10362_21560_21574_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 21560, 21574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10362_22155_22177(Microsoft.CodeAnalysis.CSharp.IValueSet
                this_param)
                {
                    var return_v = this_param.Sample;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 22155, 22177);
                    return return_v;
                }


                string
                f_10362_22236_22279(Microsoft.CodeAnalysis.ConstantValue
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                requireExactType)
                {
                    var return_v = ValueString(value, type, requireExactType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 22236, 22279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10362_22569_22600(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.EnumUnderlyingTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 22569, 22600);
                    return return_v;
                }


                bool
                f_10362_22628_22662(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 22628, 22662);
                    return return_v;
                }


                int
                f_10362_22615_22663(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 22615, 22663);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10362_22682_22708(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 22682, 22708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10362_22827_22861(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 22827, 22861);
                    return return_v;
                }


                bool
                f_10362_22775_22862(Microsoft.CodeAnalysis.CSharp.IValueSet
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                relation, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    var return_v = this_param.Any(relation, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 22775, 22862);
                    return return_v;
                }


                string
                f_10362_22898_22920(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 22898, 22920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10362_23009_23043(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 23009, 23043);
                    return return_v;
                }


                bool
                f_10362_22960_23044(Microsoft.CodeAnalysis.CSharp.IValueSet
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                relation, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    var return_v = this_param.Any(relation, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 22960, 23044);
                    return return_v;
                }


                string
                f_10362_23080_23102(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 23080, 23102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10362_23156_23182(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 23156, 23182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10362_23302_23337(uint
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 23302, 23337);
                    return return_v;
                }


                bool
                f_10362_23250_23338(Microsoft.CodeAnalysis.CSharp.IValueSet
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                relation, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    var return_v = this_param.Any(relation, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 23250, 23338);
                    return return_v;
                }


                string
                f_10362_23374_23396(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 23374, 23396);
                    return return_v;
                }


                System.Exception
                f_10362_23450_23480()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 23450, 23480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 20948, 23492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 20948, 23492);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ValueString(ConstantValue value, TypeSymbol type, bool requireExactType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10362, 23504, 24654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 23623, 23781);

                bool
                requiresCast = (f_10362_23644_23661(type) || (DynAbs.Tracing.TraceSender.Expression_False(10362, 23644, 23681) || requireExactType) || (DynAbs.Tracing.TraceSender.Expression_False(10362, 23644, 23709) || f_10362_23685_23709(type))) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 23643, 23780) && !(f_10362_23733_23762(type) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 23733, 23779) && f_10362_23766_23779_M(!value.IsNull))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 23795, 23877);

                string
                valueString = f_10362_23816_23876(value, f_10362_23844_23875(type))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 23891, 23970);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10362, 23898, 23910) || ((requiresCast && DynAbs.Tracing.TraceSender.Conditional_F2(10362, 23913, 23955)) || DynAbs.Tracing.TraceSender.Conditional_F3(10362, 23958, 23969))) ? $"({f_10362_23917_23939(type)}){valueString}" : valueString;

                static bool typeHasExactTypeLiteral(TypeSymbol type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10362, 24039, 24642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24042, 24642);
                        return f_10362_24042_24058(type) switch
                        {
                            SpecialType.System_Int32 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24098, 24130) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24098, 24130))
            => true,
                            SpecialType.System_Int64 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24149, 24181) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24149, 24181))
            => true,
                            SpecialType.System_UInt32 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24200, 24233) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24200, 24233))
            => true,
                            SpecialType.System_UInt64 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24252, 24285) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24252, 24285))
            => true,
                            SpecialType.System_String when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24304, 24337) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24304, 24337))
            => true,
                            SpecialType.System_Decimal when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24356, 24390) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24356, 24390))
            => true,
                            SpecialType.System_Single when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24409, 24442) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24409, 24442))
            => true,
                            SpecialType.System_Double when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24461, 24494) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24461, 24494))
            => true,
                            SpecialType.System_Boolean when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24513, 24547) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24513, 24547))
            => true,
                            SpecialType.System_Char when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24566, 24597) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24566, 24597))
            => true,
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24616, 24626) && DynAbs.Tracing.TraceSender.Expression_True(10362, 24616, 24626))
            => false,
                        }; DynAbs.Tracing.TraceSender.TraceExitMethod(10362, 24039, 24642);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 24039, 24642);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 24039, 24642);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10362, 23504, 24654);

                bool
                f_10362_23644_23661(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 23644, 23661);
                    return return_v;
                }


                bool
                f_10362_23685_23709(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 23685, 23709);
                    return return_v;
                }


                bool
                f_10362_23733_23762(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = typeHasExactTypeLiteral(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 23733, 23762);
                    return return_v;
                }


                bool
                f_10362_23766_23779_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 23766, 23779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10362_23844_23875(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.EnumUnderlyingTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 23844, 23875);
                    return return_v;
                }


                string
                f_10362_23816_23876(Microsoft.CodeAnalysis.ConstantValue
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = PrimitiveValueString(value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 23816, 23876);
                    return return_v;
                }


                string
                f_10362_23917_23939(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 23917, 23939);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.SpecialType
                f_10362_24042_24058(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 24042, 24058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 23504, 24654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 23504, 24654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string PrimitiveValueString(ConstantValue value, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10362, 24666, 26833);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24771, 24820) || true) && (f_10362_24775_24787(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 24771, 24820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24806, 24820);

                    return "null";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 24771, 24820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 24836, 26822);

                switch (f_10362_24844_24860(type))
                {

                    case SpecialType.System_Boolean:
                    case SpecialType.System_Byte:
                    case SpecialType.System_SByte:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Int64:
                    case SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 25361, 25390) || true) && (f_10362_25366_25390(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 25361, 25390) || true)
                :
                    case SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 25441, 25470) || true) && (f_10362_25446_25470(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10362, 25441, 25470) || true)
                :
                    case SpecialType.System_Decimal:
                    case SpecialType.System_Char:
                    case SpecialType.System_String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 24836, 26822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 25639, 25814);

                        return f_10362_25646_25813(f_10362_25676_25687(value), ObjectDisplayOptions.EscapeNonPrintableCharacters | ObjectDisplayOptions.IncludeTypeSuffix | ObjectDisplayOptions.UseQuotes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 24836, 26822);

                    case SpecialType.System_Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 24836, 26822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 25887, 26277);

                        return f_10362_25894_25911(value) switch
                        {
                            float.NaN when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 25967, 25991) && DynAbs.Tracing.TraceSender.Expression_True(10362, 25967, 25991))
    => "float.NaN",
                            float.NegativeInfinity when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 26018, 26068) && DynAbs.Tracing.TraceSender.Expression_True(10362, 26018, 26068))
    => "float.NegativeInfinity",
                            float.PositiveInfinity when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 26095, 26145) && DynAbs.Tracing.TraceSender.Expression_True(10362, 26095, 26145))
    => "float.PositiveInfinity",
                            var x when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 26172, 26253) && DynAbs.Tracing.TraceSender.Expression_True(10362, 26172, 26253))
    => f_10362_26181_26253(x, ObjectDisplayOptions.IncludeTypeSuffix)
                        };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 24836, 26822);

                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 24836, 26822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 26350, 26746);

                        return f_10362_26357_26374(value) switch
                        {
                            double.NaN when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 26430, 26456) && DynAbs.Tracing.TraceSender.Expression_True(10362, 26430, 26456))
    => "double.NaN",
                            double.NegativeInfinity when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 26483, 26535) && DynAbs.Tracing.TraceSender.Expression_True(10362, 26483, 26535))
    => "double.NegativeInfinity",
                            double.PositiveInfinity when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 26562, 26614) && DynAbs.Tracing.TraceSender.Expression_True(10362, 26562, 26614))
    => "double.PositiveInfinity",
                            var x when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 26641, 26722) && DynAbs.Tracing.TraceSender.Expression_True(10362, 26641, 26722))
    => f_10362_26650_26722(x, ObjectDisplayOptions.IncludeTypeSuffix)
                        };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 24836, 26822);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10362, 24836, 26822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10362, 26796, 26807);

                        return "_";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10362, 24836, 26822);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10362, 24666, 26833);

                bool
                f_10362_24775_24787(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 24775, 24787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10362_24844_24860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 24844, 24860);
                    return return_v;
                }


                bool
                f_10362_25366_25390(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 25366, 25390);
                    return return_v;
                }


                bool
                f_10362_25446_25470(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 25446, 25470);
                    return return_v;
                }


                object?
                f_10362_25676_25687(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 25676, 25687);
                    return return_v;
                }


                string
                f_10362_25646_25813(object?
                obj, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatPrimitive(obj, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 25646, 25813);
                    return return_v;
                }


                float
                f_10362_25894_25911(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SingleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 25894, 25911);
                    return return_v;
                }


                string
                f_10362_26181_26253(float
                obj, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatPrimitive((object)obj, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 26181, 26253);
                    return return_v;
                }


                double
                f_10362_26357_26374(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DoubleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10362, 26357, 26374);
                    return return_v;
                }


                string
                f_10362_26650_26722(double
                obj, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatPrimitive((object)obj, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10362, 26650, 26722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10362, 24666, 26833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 24666, 26833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PatternExplainer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10362, 549, 26840);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10362, 549, 26840);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10362, 549, 26840);
        }

    }
}
