// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    internal partial class ControlFlowGraphBuilder
    {
        internal sealed class BasicBlockBuilder
        {
            public int Ordinal;

            public readonly BasicBlockKind Kind;

            private ArrayBuilder<IOperation>? _statements;

            private BasicBlockBuilder? _predecessor1;

            private BasicBlockBuilder? _predecessor2;

            private PooledHashSet<BasicBlockBuilder>? _predecessors;

            public IOperation? BranchValue;

            public ControlFlowConditionKind ConditionKind;

            public Branch Conditional;

            public Branch FallThrough;

            public bool IsReachable;

            public ControlFlowRegion? Region;

            public BasicBlockBuilder(BasicBlockKind kind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(452, 1311, 1485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 576, 583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 629, 633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 682, 693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 882, 895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 937, 950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1007, 1020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1056, 1067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1114, 1127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1236, 1247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1288, 1294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1389, 1401);

                    Kind = kind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1419, 1432);

                    Ordinal = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1450, 1470);

                    IsReachable = false;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(452, 1311, 1485);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 1311, 1485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 1311, 1485);
                }
            }

            [MemberNotNullWhen(true, nameof(StatementsOpt))]
#pragma warning disable CS8775
            public bool HasStatements
            {
                [MemberNotNullWhen(true, nameof(StatementsOpt))]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 1621, 1646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1624, 1646);
                        return f_452_1624_1642_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_statements, 452, 1624, 1642)?.Count) > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(452, 1621, 1646);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 1621, 1646);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 1621, 1646);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ArrayBuilder<IOperation>? StatementsOpt
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 1735, 1749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1738, 1749);
                        return _statements; DynAbs.Tracing.TraceSender.TraceExitMethod(452, 1735, 1749);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 1735, 1749);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 1735, 1749);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void AddStatement(IOperation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 1766, 2096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1845, 1877);

                    f_452_1845_1876(operation != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1897, 2034) || true) && (_statements == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 1897, 2034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 1962, 2015);

                        _statements = f_452_1976_2014();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 1897, 2034);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 2054, 2081);

                    f_452_2054_2080(
                                    _statements, operation);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(452, 1766, 2096);

                    int
                    f_452_1845_1876(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 1845, 1876);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                    f_452_1976_2014()
                    {
                        var return_v = ArrayBuilder<IOperation>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 1976, 2014);
                        return return_v;
                    }


                    int
                    f_452_2054_2080(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                    this_param, Microsoft.CodeAnalysis.IOperation
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 2054, 2080);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 1766, 2096);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 1766, 2096);
                }
            }

            public void MoveStatementsFrom(BasicBlockBuilder other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 2112, 2668);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 2200, 2653) || true) && (other._statements == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 2200, 2653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 2271, 2278);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 2200, 2653);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 2200, 2653);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 2320, 2653) || true) && (_statements == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 2320, 2653);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 2385, 2417);

                            _statements = other._statements;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 2439, 2464);

                            other._statements = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 2320, 2653);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 2320, 2653);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 2546, 2586);

                            f_452_2546_2585(_statements, other._statements);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 2608, 2634);

                            f_452_2608_2633(other._statements);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 2320, 2653);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 2200, 2653);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(452, 2112, 2668);

                    int
                    f_452_2546_2585(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 2546, 2585);
                        return 0;
                    }


                    int
                    f_452_2608_2633(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 2608, 2633);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 2112, 2668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 2112, 2668);
                }
            }

            public BasicBlock ToImmutable()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 2684, 3304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 2748, 2777);

                    f_452_2748_2776(Region != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 2795, 3221);

                    var
                    block = f_452_2807_3220(Kind, f_452_2872_2905_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_statements, 452, 2872, 2905)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>?>(452, 2872, 2941) ?? ImmutableArray<IOperation>.Empty), BranchValue, ConditionKind, Ordinal, IsReachable, Region)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 3239, 3258);

                    _statements = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 3276, 3289);

                    return block;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(452, 2684, 3304);

                    int
                    f_452_2748_2776(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 2748, 2776);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>?
                    f_452_2872_2905_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 2872, 2905);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                    f_452_2807_3220(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlockKind
                    kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                    operations, Microsoft.CodeAnalysis.IOperation?
                    branchValue, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowConditionKind
                    conditionKind, int
                    ordinal, bool
                    isReachable, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowRegion
                    region)
                    {
                        var return_v = new Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock(kind, operations, branchValue, conditionKind, ordinal, isReachable, region);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 2807, 3220);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 2684, 3304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 2684, 3304);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool HasPredecessors
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 3380, 3848);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 3424, 3829) || true) && (_predecessors != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 3424, 3829);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 3499, 3535);

                            f_452_3499_3534(_predecessor1 == null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 3561, 3597);

                            f_452_3561_3596(_predecessor2 == null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 3623, 3654);

                            return f_452_3630_3649(_predecessors) > 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 3424, 3829);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 3424, 3829);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 3752, 3806);

                            return _predecessor1 != null || (DynAbs.Tracing.TraceSender.Expression_False(452, 3759, 3805) || _predecessor2 != null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 3424, 3829);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(452, 3380, 3848);

                        int
                        f_452_3499_3534(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 3499, 3534);
                            return 0;
                        }


                        int
                        f_452_3561_3596(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 3561, 3596);
                            return 0;
                        }


                        int
                        f_452_3630_3649(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 3630, 3649);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 3320, 3863);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 3320, 3863);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            [MemberNotNullWhen(true, nameof(BranchValue))]
            public bool HasCondition
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 3996, 4223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4040, 4101);

                        bool
                        result = ConditionKind != ControlFlowConditionKind.None
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4123, 4168);

                        f_452_4123_4167(!result || (DynAbs.Tracing.TraceSender.Expression_False(452, 4136, 4166) || BranchValue != null));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4190, 4204);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(452, 3996, 4223);

                        int
                        f_452_4123_4167(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 4123, 4167);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 3879, 4238);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 3879, 4238);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public BasicBlockBuilder? GetSingletonPredecessorOrDefault()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 4254, 4953);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4347, 4938) || true) && (_predecessors != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 4347, 4938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4414, 4450);

                        f_452_4414_4449(_predecessor1 == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4472, 4508);

                        f_452_4472_4507(_predecessor2 == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4530, 4565);

                        return f_452_4537_4564(_predecessors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 4347, 4938);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 4347, 4938);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4607, 4938) || true) && (_predecessor2 == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 4607, 4938);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4674, 4695);

                            return _predecessor1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 4607, 4938);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 4607, 4938);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4737, 4938) || true) && (_predecessor1 == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 4737, 4938);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4804, 4825);

                                return _predecessor2;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(452, 4737, 4938);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 4737, 4938);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 4907, 4919);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(452, 4737, 4938);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 4607, 4938);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 4347, 4938);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(452, 4254, 4953);

                    int
                    f_452_4414_4449(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 4414, 4449);
                        return 0;
                    }


                    int
                    f_452_4472_4507(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 4472, 4507);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder?
                    f_452_4537_4564(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    source)
                    {
                        var return_v = source.AsSingleton<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 4537, 4564);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 4254, 4953);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 4254, 4953);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void AddPredecessor(BasicBlockBuilder predecessor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 4969, 6336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5059, 5093);

                    f_452_5059_5092(predecessor != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5113, 6321) || true) && (_predecessors != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 5113, 6321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5180, 5216);

                        f_452_5180_5215(_predecessor1 == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5238, 5274);

                        f_452_5238_5273(_predecessor2 == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5296, 5327);

                        f_452_5296_5326(_predecessors, predecessor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 5113, 6321);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 5113, 6321);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5369, 6321) || true) && (_predecessor1 == predecessor)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 5369, 6321);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5443, 5450);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 5369, 6321);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 5369, 6321);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5492, 6321) || true) && (_predecessor2 == predecessor)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 5492, 6321);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5566, 5573);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(452, 5492, 6321);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 5492, 6321);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5615, 6321) || true) && (_predecessor1 == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 5615, 6321);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5682, 5710);

                                    _predecessor1 = predecessor;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(452, 5615, 6321);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 5615, 6321);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5752, 6321) || true) && (_predecessor2 == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 5752, 6321);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5819, 5847);

                                        _predecessor2 = predecessor;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 5752, 6321);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 5752, 6321);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 5929, 5992);

                                        _predecessors = f_452_5945_5991();
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6014, 6047);

                                        f_452_6014_6046(_predecessors, _predecessor1);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6069, 6102);

                                        f_452_6069_6101(_predecessors, _predecessor2);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6124, 6155);

                                        f_452_6124_6154(_predecessors, predecessor);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6177, 6216);

                                        f_452_6177_6215(f_452_6190_6209(_predecessors) == 3);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6238, 6259);

                                        _predecessor1 = null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6281, 6302);

                                        _predecessor2 = null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 5752, 6321);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(452, 5615, 6321);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(452, 5492, 6321);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 5369, 6321);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 5113, 6321);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(452, 4969, 6336);

                    int
                    f_452_5059_5092(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 5059, 5092);
                        return 0;
                    }


                    int
                    f_452_5180_5215(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 5180, 5215);
                        return 0;
                    }


                    int
                    f_452_5238_5273(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 5238, 5273);
                        return 0;
                    }


                    bool
                    f_452_5296_5326(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 5296, 5326);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    f_452_5945_5991()
                    {
                        var return_v = PooledHashSet<BasicBlockBuilder>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 5945, 5991);
                        return return_v;
                    }


                    bool
                    f_452_6014_6046(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 6014, 6046);
                        return return_v;
                    }


                    bool
                    f_452_6069_6101(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 6069, 6101);
                        return return_v;
                    }


                    bool
                    f_452_6124_6154(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 6124, 6154);
                        return return_v;
                    }


                    int
                    f_452_6190_6209(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 6190, 6209);
                        return return_v;
                    }


                    int
                    f_452_6177_6215(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 6177, 6215);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 4969, 6336);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 4969, 6336);
                }
            }

            public void RemovePredecessor(BasicBlockBuilder predecessor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 6352, 7024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6445, 6479);

                    f_452_6445_6478(predecessor != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6499, 7009) || true) && (_predecessors != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 6499, 7009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6566, 6602);

                        f_452_6566_6601(_predecessor1 == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6624, 6660);

                        f_452_6624_6659(_predecessor2 == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6682, 6716);

                        f_452_6682_6715(_predecessors, predecessor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 6499, 7009);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 6499, 7009);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6758, 7009) || true) && (_predecessor1 == predecessor)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 6758, 7009);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6832, 6853);

                            _predecessor1 = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 6758, 7009);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 6758, 7009);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6895, 7009) || true) && (_predecessor2 == predecessor)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 6895, 7009);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 6969, 6990);

                                _predecessor2 = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(452, 6895, 7009);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 6758, 7009);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 6499, 7009);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(452, 6352, 7024);

                    int
                    f_452_6445_6478(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 6445, 6478);
                        return 0;
                    }


                    int
                    f_452_6566_6601(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 6566, 6601);
                        return 0;
                    }


                    int
                    f_452_6624_6659(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 6624, 6659);
                        return 0;
                    }


                    bool
                    f_452_6682_6715(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    item)
                    {
                        var return_v = this_param.Remove(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 6682, 6715);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 6352, 7024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 6352, 7024);
                }
            }

            public void GetPredecessors(ArrayBuilder<BasicBlockBuilder> builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 7040, 7810);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7141, 7529) || true) && (_predecessors != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 7141, 7529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7208, 7244);

                        f_452_7208_7243(_predecessor1 == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7266, 7302);

                        f_452_7266_7301(_predecessor2 == null);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7326, 7479);
                            foreach (BasicBlockBuilder predecessor in f_452_7368_7381_I(_predecessors))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 7326, 7479);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7431, 7456);

                                f_452_7431_7455(builder, predecessor);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(452, 7326, 7479);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(452, 1, 154);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(452, 1, 154);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7503, 7510);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 7141, 7529);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7549, 7662) || true) && (_predecessor1 != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 7549, 7662);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7616, 7643);

                        f_452_7616_7642(builder, _predecessor1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 7549, 7662);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7682, 7795) || true) && (_predecessor2 != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 7682, 7795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7749, 7776);

                        f_452_7749_7775(builder, _predecessor2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 7682, 7795);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(452, 7040, 7810);

                    int
                    f_452_7208_7243(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 7208, 7243);
                        return 0;
                    }


                    int
                    f_452_7266_7301(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 7266, 7301);
                        return 0;
                    }


                    int
                    f_452_7431_7455(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 7431, 7455);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    f_452_7368_7381_I(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 7368, 7381);
                        return return_v;
                    }


                    int
                    f_452_7616_7642(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 7616, 7642);
                        return 0;
                    }


                    int
                    f_452_7749_7775(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 7749, 7775);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 7040, 7810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 7040, 7810);
                }
            }

            public ImmutableArray<ControlFlowBranch> ConvertPredecessorsToBranches(ArrayBuilder<BasicBlock> blocks)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 7826, 10764);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 7962, 8177) || true) && (f_452_7966_7982_M(!HasPredecessors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 7962, 8177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8024, 8046);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_predecessors, 452, 8024, 8045)?.Free(), 452, 8038, 8045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8068, 8089);

                        _predecessors = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8111, 8158);

                        return ImmutableArray<ControlFlowBranch>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 7962, 8177);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8197, 8232);

                    BasicBlock
                    block = f_452_8216_8231(blocks, Ordinal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8252, 8338);

                    var
                    branches = f_452_8267_8337(f_452_8311_8331_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_predecessors, 452, 8311, 8331)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(452, 8311, 8336) ?? 2))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8358, 9277) || true) && (_predecessors != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 8358, 9277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8425, 8461);

                        f_452_8425_8460(_predecessor1 == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8483, 8519);

                        f_452_8483_8518(_predecessor2 == null);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8543, 8720);
                            foreach (BasicBlockBuilder predecessorBlockBuilder in f_452_8597_8610_I(_predecessors))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 8543, 8720);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8660, 8697);

                                f_452_8660_8696(predecessorBlockBuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(452, 8543, 8720);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(452, 1, 178);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(452, 1, 178);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8744, 8765);

                        f_452_8744_8764(
                                            _predecessors);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8787, 8808);

                        _predecessors = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 8358, 9277);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 8358, 9277);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8890, 9062) || true) && (_predecessor1 != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 8890, 9062);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 8965, 8992);

                            f_452_8965_8991(_predecessor1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 9018, 9039);

                            _predecessor1 = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 8890, 9062);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 9086, 9258) || true) && (_predecessor2 != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 9086, 9258);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 9161, 9188);

                            f_452_9161_9187(_predecessor2);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 9214, 9235);

                            _predecessor2 = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(452, 9086, 9258);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(452, 8358, 9277);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 9422, 10010);

                    f_452_9422_10009(
                                    // Order predecessors by source ordinal and conditional first to ensure deterministic predecessor ordering.
                                    branches, (x, y) =>
                                    {
                                        int result = x.Source.Ordinal - y.Source.Ordinal;
                                        if (result == 0 && x.IsConditionalSuccessor != y.IsConditionalSuccessor)
                                        {
                                            if (x.IsConditionalSuccessor)
                                            {
                                                result = -1;
                                            }
                                            else
                                            {
                                                result = 1;
                                            }
                                        }

                                        return result;
                                    });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10030, 10067);

                    return f_452_10037_10066(branches);

                    void addBranches(BasicBlockBuilder predecessorBlockBuilder)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 10087, 10749);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10187, 10252);

                            BasicBlock
                            predecessor = f_452_10212_10251(blocks, predecessorBlockBuilder.Ordinal)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10274, 10329);

                            f_452_10274_10328(f_452_10287_10319(predecessor) != null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10351, 10528) || true) && (f_452_10355_10399(f_452_10355_10387(predecessor)) == block)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 10351, 10528);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10458, 10505);

                                f_452_10458_10504(branches, f_452_10471_10503(predecessor));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(452, 10351, 10528);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10552, 10730) || true) && (f_452_10556_10601_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_452_10556_10588(predecessor), 452, 10556, 10601)?.Destination) == block)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(452, 10552, 10730);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10660, 10707);

                                f_452_10660_10706(branches, f_452_10673_10705(predecessor));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(452, 10552, 10730);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(452, 10087, 10749);

                            Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                            f_452_10212_10251(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock>
                            this_param, int
                            i0)
                            {
                                var return_v = this_param[i0];
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 10212, 10251);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                            f_452_10287_10319(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                            this_param)
                            {
                                var return_v = this_param.FallThroughSuccessor;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 10287, 10319);
                                return return_v;
                            }


                            int
                            f_452_10274_10328(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 10274, 10328);
                                return 0;
                            }


                            Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                            f_452_10355_10387(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                            this_param)
                            {
                                var return_v = this_param.FallThroughSuccessor;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 10355, 10387);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                            f_452_10355_10399(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                            this_param)
                            {
                                var return_v = this_param.Destination;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 10355, 10399);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                            f_452_10471_10503(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                            this_param)
                            {
                                var return_v = this_param.FallThroughSuccessor;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 10471, 10503);
                                return return_v;
                            }


                            int
                            f_452_10458_10504(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                            this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                            item)
                            {
                                this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 10458, 10504);
                                return 0;
                            }


                            Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch?
                            f_452_10556_10588(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                            this_param)
                            {
                                var return_v = this_param.ConditionalSuccessor;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 10556, 10588);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                            f_452_10556_10601_M(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock?
                            i)
                            {
                                var return_v = i;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 10556, 10601);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                            f_452_10673_10705(Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                            this_param)
                            {
                                var return_v = this_param.ConditionalSuccessor;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 10673, 10705);
                                return return_v;
                            }


                            int
                            f_452_10660_10706(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                            this_param, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch
                            item)
                            {
                                this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 10660, 10706);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 10087, 10749);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 10087, 10749);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(452, 7826, 10764);

                    bool
                    f_452_7966_7982_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 7966, 7982);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock
                    f_452_8216_8231(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 8216, 8231);
                        return return_v;
                    }


                    int?
                    f_452_8311_8331_M(int?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 8311, 8331);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                    f_452_8267_8337(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<ControlFlowBranch>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 8267, 8337);
                        return return_v;
                    }


                    int
                    f_452_8425_8460(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 8425, 8460);
                        return 0;
                    }


                    int
                    f_452_8483_8518(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 8483, 8518);
                        return 0;
                    }


                    int
                    f_452_8660_8696(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    predecessorBlockBuilder)
                    {
                        addBranches(predecessorBlockBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 8660, 8696);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    f_452_8597_8610_I(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 8597, 8610);
                        return return_v;
                    }


                    int
                    f_452_8744_8764(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 8744, 8764);
                        return 0;
                    }


                    int
                    f_452_8965_8991(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    predecessorBlockBuilder)
                    {
                        addBranches(predecessorBlockBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 8965, 8991);
                        return 0;
                    }


                    int
                    f_452_9161_9187(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraphBuilder.BasicBlockBuilder
                    predecessorBlockBuilder)
                    {
                        addBranches(predecessorBlockBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 9161, 9187);
                        return 0;
                    }


                    int
                    f_452_9422_10009(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                    this_param, System.Comparison<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                    compare)
                    {
                        this_param.Sort(compare);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 9422, 10009);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                    f_452_10037_10066(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowBranch>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(452, 10037, 10066);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 7826, 10764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 7826, 10764);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(452, 10780, 11091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10831, 10844);

                    Ordinal = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10862, 10882);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_statements, 452, 10862, 10881)?.Free(), 452, 10874, 10881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10900, 10919);

                    _statements = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10937, 10959);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_predecessors, 452, 10937, 10958)?.Free(), 452, 10951, 10958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 10977, 10998);

                    _predecessors = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 11016, 11037);

                    _predecessor1 = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(452, 11055, 11076);

                    _predecessor2 = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(452, 10780, 11091);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(452, 10780, 11091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 10780, 11091);
                }
            }

            internal struct Branch
            {

                public ControlFlowBranchSemantics Kind { get; set; }

                public BasicBlockBuilder? Destination { get; set; }
                static Branch()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(452, 11107, 11298);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(452, 11107, 11298);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 11107, 11298);
                }
            }

            static BasicBlockBuilder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(452, 501, 11309);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(452, 501, 11309);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 501, 11309);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(452, 501, 11309);

            int?
            f_452_1624_1642_M(int?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(452, 1624, 1642);
                return return_v;
            }

        }

        static ControlFlowGraphBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(452, 438, 11316);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(452, 438, 11316);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(452, 438, 11316);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(452, 438, 11316);
    }
}
