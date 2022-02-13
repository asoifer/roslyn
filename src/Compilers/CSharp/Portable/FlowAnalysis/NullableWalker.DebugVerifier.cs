// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class NullableWalker
    {
        private sealed class DebugVerifier : BoundTreeWalker
        {
            private readonly ImmutableDictionary<BoundExpression, (NullabilityInfo Info, TypeSymbol? Type)> _analyzedNullabilityMap;

            private readonly SnapshotManager? _snapshotManager;

            private readonly HashSet<BoundExpression> _visitedExpressions;

            private int _recursionDepth;

            private DebugVerifier(ImmutableDictionary<BoundExpression, (NullabilityInfo Info, TypeSymbol? Type)> analyzedNullabilityMap, SnapshotManager? snapshotManager)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10900, 1124, 1432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 868, 891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 940, 956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 1013, 1065);
                    this._visitedExpressions = f_10900_1035_1065(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 1092, 1107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 1315, 1364);

                    _analyzedNullabilityMap = analyzedNullabilityMap;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 1382, 1417);

                    _snapshotManager = snapshotManager;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10900, 1124, 1432);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 1124, 1432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 1124, 1432);
                }
            }

            protected override bool ConvertInsufficientExecutionStackExceptionToCancelledByStackGuardException()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 1448, 1644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 1581, 1594);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 1448, 1644);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 1448, 1644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 1448, 1644);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static void Verify(ImmutableDictionary<BoundExpression, (NullabilityInfo Info, TypeSymbol? Type)> analyzedNullabilityMap, SnapshotManager? snapshotManagerOpt, BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10900, 1660, 2424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 1874, 1951);

                    var
                    verifier = f_10900_1889_1950(analyzedNullabilityMap, snapshotManagerOpt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 1969, 1990);

                    f_10900_1969_1989(verifier, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 2008, 2051);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(snapshotManagerOpt, 10900, 2008, 2050)?.VerifyUpdatedSymbols(), 10900, 2027, 2050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 2203, 2409);

                    f_10900_2203_2408(f_10900_2216_2254(verifier._analyzedNullabilityMap) == f_10900_2258_2292(verifier._visitedExpressions), $"Visited {f_10900_2305_2339(verifier._visitedExpressions)} nodes, expected to visit {f_10900_2367_2405(verifier._analyzedNullabilityMap)}");
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10900, 1660, 2424);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    f_10900_1889_1950(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundExpression, (Microsoft.CodeAnalysis.NullabilityInfo Info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol? Type)>
                    analyzedNullabilityMap, Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager?
                    snapshotManager)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier(analyzedNullabilityMap, snapshotManager);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 1889, 1950);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_1969_1989(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = this_param.Visit(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 1969, 1989);
                        return return_v;
                    }


                    int
                    f_10900_2216_2254(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundExpression, (Microsoft.CodeAnalysis.NullabilityInfo Info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol? Type)>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 2216, 2254);
                        return return_v;
                    }


                    int
                    f_10900_2258_2292(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 2258, 2292);
                        return return_v;
                    }


                    int
                    f_10900_2305_2339(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 2305, 2339);
                        return return_v;
                    }


                    int
                    f_10900_2367_2405(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundExpression, (Microsoft.CodeAnalysis.NullabilityInfo Info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol? Type)>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 2367, 2405);
                        return return_v;
                    }


                    int
                    f_10900_2203_2408(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 2203, 2408);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 1660, 2424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 1660, 2424);
                }
            }

            private void VerifyExpression(BoundExpression expression, bool overrideSkippedExpression = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 2440, 2910);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 2570, 2895) || true) && (overrideSkippedExpression || (DynAbs.Tracing.TraceSender.Expression_False(10900, 2574, 2650) || !s_skippedExpressions.Contains(f_10900_2634_2649(expression))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 2570, 2895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 2692, 2818);

                        f_10900_2692_2817(f_10900_2705_2752(_analyzedNullabilityMap, expression), $"Did not find {expression} `{expression.Syntax}` in the map.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 2840, 2876);

                        f_10900_2840_2875(_visitedExpressions, expression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 2570, 2895);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 2440, 2910);

                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10900_2634_2649(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 2634, 2649);
                        return return_v;
                    }


                    bool
                    f_10900_2705_2752(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundExpression, (Microsoft.CodeAnalysis.NullabilityInfo Info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol? Type)>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 2705, 2752);
                        return return_v;
                    }


                    int
                    f_10900_2692_2817(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 2692, 2817);
                        return 0;
                    }


                    bool
                    f_10900_2840_2875(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 2840, 2875);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 2440, 2910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 2440, 2910);
                }
            }

            protected override BoundExpression? VisitExpressionWithoutStackGuard(BoundExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 2926, 3146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 3049, 3072);

                    f_10900_3049_3071(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 3090, 3131);

                    return (BoundExpression)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10900, 3114, 3130);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 2926, 3146);

                    int
                    f_10900_3049_3071(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression)
                    {
                        this_param.VerifyExpression(expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 3049, 3071);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 2926, 3146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 2926, 3146);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? Visit(BoundNode? node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 3162, 3825);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 3611, 3768) || true) && (node is BoundExpression expr)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 3611, 3768);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 3685, 3749);

                        return f_10900_3692_3748(this, ref _recursionDepth, expr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 3611, 3768);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 3786, 3810);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10900, 3793, 3809);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 3162, 3825);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10900_3692_3748(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, ref int
                    recursionDepth, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.VisitExpressionWithStackGuard(ref recursionDepth, node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 3692, 3748);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 3162, 3825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 3162, 3825);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitDeconstructionAssignmentOperator(BoundDeconstructionAssignmentOperator node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 3841, 4083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 4056, 4068);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 3841, 4083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 3841, 4083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 3841, 4083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitBadExpression(BoundBadExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 4099, 4845);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 4408, 4798);
                        foreach (var child in f_10900_4430_4450_I(f_10900_4430_4450(node)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 4408, 4798);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 4492, 4779) || true) && (!s_skippedExpressions.Contains(f_10900_4527_4537(child)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 4492, 4779);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 4588, 4601);

                                f_10900_4588_4600(this, child);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 4492, 4779);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 4492, 4779);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 4699, 4756);

                                f_10900_4699_4755(this, child, overrideSkippedExpression: true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 4492, 4779);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 4408, 4798);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10900, 1, 391);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10900, 1, 391);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 4818, 4830);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 4099, 4845);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10900_4430_4450(Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                    this_param)
                    {
                        var return_v = this_param.ChildBoundNodes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 4430, 4450);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10900_4527_4537(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 4527, 4537);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_4588_4600(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 4588, 4600);
                        return return_v;
                    }


                    int
                    f_10900_4699_4755(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression, bool
                    overrideSkippedExpression)
                    {
                        this_param.VerifyExpression(expression, overrideSkippedExpression: overrideSkippedExpression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 4699, 4755);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10900_4430_4450_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 4430, 4450);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 4099, 4845);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 4099, 4845);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitQueryClause(BoundQueryClause node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 4861, 5047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 4960, 5002);

                    f_10900_4960_5001(this, f_10900_4966_4986(node) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10900, 4966, 5000) ?? f_10900_4990_5000(node)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5020, 5032);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 4861, 5047);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10900_4966_4986(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                    this_param)
                    {
                        var return_v = this_param.UnoptimizedForm;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 4966, 4986);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10900_4990_5000(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 4990, 5000);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_4960_5001(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 4960, 5001);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 4861, 5047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 4861, 5047);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitUnboundLambda(UnboundLambda node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 5063, 5246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5161, 5201);

                    f_10900_5161_5200(this, f_10900_5167_5199(f_10900_5167_5194(node)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5219, 5231);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 5063, 5246);

                    Microsoft.CodeAnalysis.CSharp.BoundLambda
                    f_10900_5167_5194(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                    this_param)
                    {
                        var return_v = this_param.BindForErrorRecovery();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 5167, 5194);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10900_5167_5199(Microsoft.CodeAnalysis.CSharp.BoundLambda
                    this_param)
                    {
                        var return_v = this_param.Body;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5167, 5199);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_5161_5200(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 5161, 5200);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 5063, 5246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 5063, 5246);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitForEachStatement(BoundForEachStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 5262, 6207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5371, 5405);

                    f_10900_5371_5404(this, f_10900_5377_5403(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5423, 5444);

                    f_10900_5423_5443(this, f_10900_5429_5442(node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5462, 5938) || true) && (f_10900_5466_5488(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 5462, 5938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5538, 5589);

                        f_10900_5538_5588(this, f_10900_5544_5566(node).DisposeAwaitableInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5611, 5919) || true) && (f_10900_5615_5680(f_10900_5615_5662(f_10900_5615_5637(node).GetEnumeratorInfo)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 5611, 5919);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5730, 5896);
                                foreach (var arg in f_10900_5750_5800_I(f_10900_5750_5800(f_10900_5750_5772(node).GetEnumeratorInfo)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 5730, 5896);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5858, 5869);

                                    f_10900_5858_5868(this, arg);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 5730, 5896);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10900, 1, 167);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10900, 1, 167);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 5611, 5919);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 5462, 5938);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 5956, 5979);

                    f_10900_5956_5978(this, f_10900_5962_5977(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 6145, 6162);

                    f_10900_6145_6161(this, f_10900_6151_6160(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 6180, 6192);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 5262, 6207);

                    Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    f_10900_5377_5403(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                    this_param)
                    {
                        var return_v = this_param.IterationVariableType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5377, 5403);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_5371_5404(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 5371, 5404);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                    f_10900_5429_5442(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                    this_param)
                    {
                        var return_v = this_param.AwaitOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5429, 5442);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_5423_5443(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 5423, 5443);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo?
                    f_10900_5466_5488(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                    this_param)
                    {
                        var return_v = this_param.EnumeratorInfoOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5466, 5488);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo
                    f_10900_5544_5566(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                    this_param)
                    {
                        var return_v = this_param.EnumeratorInfoOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5544, 5566);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_5538_5588(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 5538, 5588);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo
                    f_10900_5615_5637(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                    this_param)
                    {
                        var return_v = this_param.EnumeratorInfoOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5615, 5637);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10900_5615_5662(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                    this_param)
                    {
                        var return_v = this_param.Method;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5615, 5662);
                        return return_v;
                    }


                    bool
                    f_10900_5615_5680(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtensionMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5615, 5680);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo
                    f_10900_5750_5772(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                    this_param)
                    {
                        var return_v = this_param.EnumeratorInfoOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5750, 5772);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10900_5750_5800(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
                    this_param)
                    {
                        var return_v = this_param.Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5750, 5800);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_5858_5868(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 5858, 5868);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10900_5750_5800_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 5750, 5800);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10900_5962_5977(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 5962, 5977);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_5956_5978(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 5956, 5978);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10900_6151_6160(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                    this_param)
                    {
                        var return_v = this_param.Body;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 6151, 6160);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_6145_6161(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 6145, 6161);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 5262, 6207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 5262, 6207);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitGotoStatement(BoundGotoStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 6223, 6459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 6432, 6444);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 6223, 6459);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 6223, 6459);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 6223, 6459);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitTypeOrValueExpression(BoundTypeOrValueExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 6475, 6705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 6594, 6627);

                    f_10900_6594_6626(this, node.Data.ValueExpression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 6645, 6690);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitTypeOrValueExpression(node), 10900, 6652, 6689);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 6475, 6705);

                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_6594_6626(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 6594, 6626);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 6475, 6705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 6475, 6705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitDynamicCollectionElementInitializer(BoundDynamicCollectionElementInitializer node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 6721, 7098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 6997, 7053);

                    f_10900_6997_7052(this, node, overrideSkippedExpression: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 7071, 7083);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 6721, 7098);

                    int
                    f_10900_6997_7052(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDynamicCollectionElementInitializer
                    expression, bool
                    overrideSkippedExpression)
                    {
                        this_param.VerifyExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, overrideSkippedExpression: overrideSkippedExpression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 6997, 7052);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 6721, 7098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 6721, 7098);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitAssignmentOperator(BoundAssignmentOperator node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 7114, 7757);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 7455, 7680) || true) && (f_10900_7459_7468(node) is BoundObjectInitializerMember { MemberSymbol: null })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 7455, 7680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 7565, 7588);

                        f_10900_7565_7587(this, node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 7610, 7627);

                        f_10900_7610_7626(this, f_10900_7616_7625(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 7649, 7661);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 7455, 7680);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 7700, 7742);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOperator(node), 10900, 7707, 7741);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 7114, 7757);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10900_7459_7468(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 7459, 7468);
                        return return_v;
                    }


                    int
                    f_10900_7565_7587(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    expression)
                    {
                        this_param.VerifyExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 7565, 7587);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10900_7616_7625(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 7616, 7625);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_7610_7626(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 7610, 7626);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 7114, 7757);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 7114, 7757);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitBinaryOperator(BoundBinaryOperator node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 7773, 7957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 7878, 7912);

                    f_10900_7878_7911(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 7930, 7942);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 7773, 7957);

                    int
                    f_10900_7878_7911(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    node)
                    {
                        this_param.VisitBinaryOperatorChildren((Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 7878, 7911);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 7773, 7957);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 7773, 7957);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitUserDefinedConditionalLogicalOperator(BoundUserDefinedConditionalLogicalOperator node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 7973, 8203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8124, 8158);

                    f_10900_8124_8157(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8176, 8188);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 7973, 8203);

                    int
                    f_10900_8124_8157(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                    node)
                    {
                        this_param.VisitBinaryOperatorChildren((Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 8124, 8157);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 7973, 8203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 7973, 8203);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void VisitBinaryOperatorChildren(BoundBinaryOperatorBase node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 8219, 8822);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8437, 8807) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 8437, 8807);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8490, 8513);

                            f_10900_8490_8512(this, node);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8537, 8555);

                            f_10900_8537_8554(this, f_10900_8543_8553(node));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8579, 8751) || true) && (!(f_10900_8585_8594(node) is BoundBinaryOperatorBase child))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 8579, 8751);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8678, 8695);

                                f_10900_8678_8694(this, f_10900_8684_8693(node));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8721, 8728);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 8579, 8751);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8775, 8788);

                            node = child;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 8437, 8807);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10900, 8437, 8807);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10900, 8437, 8807);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 8219, 8822);

                    int
                    f_10900_8490_8512(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                    expression)
                    {
                        this_param.VerifyExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 8490, 8512);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10900_8543_8553(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                    this_param)
                    {
                        var return_v = this_param.Right;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 8543, 8553);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_8537_8554(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 8537, 8554);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10900_8585_8594(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 8585, 8594);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10900_8684_8693(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                    this_param)
                    {
                        var return_v = this_param.Left;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 8684, 8693);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_8678_8694(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 8678, 8694);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 8219, 8822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 8219, 8822);
                }
            }

            public override BoundNode? VisitConvertedTupleLiteral(BoundConvertedTupleLiteral node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 8838, 9059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8957, 8981);

                    f_10900_8957_8980(this, f_10900_8963_8979(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 8999, 9044);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConvertedTupleLiteral(node), 10900, 9006, 9043);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 8838, 9059);

                    Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral?
                    f_10900_8963_8979(Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                    this_param)
                    {
                        var return_v = this_param.SourceTuple;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 8963, 8979);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_8957_8980(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral?
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 8957, 8980);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 8838, 9059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 8838, 9059);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitTypeExpression(BoundTypeExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 9075, 9343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 9222, 9245);

                    f_10900_9222_9244(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 9263, 9298);

                    f_10900_9263_9297(this, f_10900_9269_9296(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 9316, 9328);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 9075, 9343);

                    int
                    f_10900_9222_9244(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    expression)
                    {
                        this_param.VerifyExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 9222, 9244);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?
                    f_10900_9269_9296(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                    this_param)
                    {
                        var return_v = this_param.BoundContainingTypeOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 9269, 9296);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_9263_9297(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 9263, 9297);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 9075, 9343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 9075, 9343);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitSwitchExpressionArm(BoundSwitchExpressionArm node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 9359, 9994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 9474, 9499);

                    f_10900_9474_9498(this, f_10900_9485_9497(node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 9763, 9908) || true) && (f_10900_9767_9797_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10900_9767_9782(node), 10900, 9767, 9797)?.ConstantValue) != f_10900_9801_9819())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 9763, 9908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 9861, 9889);

                        f_10900_9861_9888(this, f_10900_9872_9887(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 9763, 9908);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 9926, 9949);

                    f_10900_9926_9948(this, f_10900_9937_9947(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 9967, 9979);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 9359, 9994);

                    Microsoft.CodeAnalysis.CSharp.BoundPattern
                    f_10900_9485_9497(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.Pattern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 9485, 9497);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_9474_9498(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 9474, 9498);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10900_9767_9782(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.WhenClause;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 9767, 9782);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10900_9767_9797_M(Microsoft.CodeAnalysis.ConstantValue?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 9767, 9797);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10900_9801_9819()
                    {
                        var return_v = ConstantValue.True;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 9801, 9819);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10900_9872_9887(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.WhenClause;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 9872, 9887);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_9861_9888(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 9861, 9888);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10900_9937_9947(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 9937, 9947);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10900_9926_9948(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 9926, 9948);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 9359, 9994);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 9359, 9994);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode? VisitNoPiaObjectCreationExpression(BoundNoPiaObjectCreationExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10900, 10010, 10513);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 10283, 10468) || true) && (f_10900_10287_10316(node) is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10900, 10283, 10468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 10368, 10449);

                        f_10900_10368_10448(this, f_10900_10385_10414(node), overrideSkippedExpression: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10900, 10283, 10468);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10900, 10486, 10498);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10900, 10010, 10513);

                    Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                    f_10900_10287_10316(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.InitializerExpressionOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 10287, 10316);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                    f_10900_10385_10414(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.InitializerExpressionOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10900, 10385, 10414);
                        return return_v;
                    }


                    int
                    f_10900_10368_10448(Microsoft.CodeAnalysis.CSharp.NullableWalker.DebugVerifier
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                    expression, bool
                    overrideSkippedExpression)
                    {
                        this_param.VerifyExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, overrideSkippedExpression: overrideSkippedExpression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 10368, 10448);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10900, 10010, 10513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 10010, 10513);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static DebugVerifier()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10900, 695, 10524);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10900, 695, 10524);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10900, 695, 10524);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10900, 695, 10524);

            System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundExpression>
            f_10900_1035_1065()
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10900, 1035, 1065);
                return return_v;
            }

        }
    }
}
