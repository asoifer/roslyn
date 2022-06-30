// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    public sealed class BasicBlock
    {
        private bool _successorsAreSealed;

        private bool _predecessorsAreSealed;

        private ControlFlowBranch? _lazySuccessor;

        private ControlFlowBranch? _lazyConditionalSuccessor;

        private ImmutableArray<ControlFlowBranch> _lazyPredecessors;

        internal BasicBlock(
                    BasicBlockKind kind,
                    ImmutableArray<IOperation> operations,
                    IOperation? branchValue,
                    ControlFlowConditionKind conditionKind,
                    int ordinal,
                    bool isReachable,
                    ControlFlowRegion region)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(441, 1183, 1757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 909, 929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 953, 975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 1023, 1037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 1075, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 1871, 1906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 2573, 2612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 2752, 2806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 4507, 4534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 4694, 4726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 4816, 4865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 1501, 1513);

                Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 1527, 1551);

                Operations = operations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 1565, 1591);

                BranchValue = branchValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 1605, 1635);

                ConditionKind = conditionKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 1649, 1667);

                Ordinal = ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 1681, 1707);

                IsReachable = isReachable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 1721, 1746);

                EnclosingRegion = region;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(441, 1183, 1757);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(441, 1183, 1757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(441, 1183, 1757);
            }
        }

        public BasicBlockKind Kind { get; }

        public ImmutableArray<IOperation> Operations { get; }

        public IOperation? BranchValue { get; }

        public ControlFlowConditionKind ConditionKind { get; }

        public ControlFlowBranch? FallThroughSuccessor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(441, 3108, 3255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 3155, 3190);

                    f_441_3155_3189(_successorsAreSealed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 3218, 3240);

                    return _lazySuccessor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(441, 3108, 3255);

                    int
                    f_441_3155_3189(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(441, 3155, 3189);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(441, 3037, 3266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(441, 3037, 3266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ControlFlowBranch? ConditionalSuccessor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(441, 3627, 3785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 3674, 3709);

                    f_441_3674_3708(_successorsAreSealed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 3737, 3770);

                    return _lazyConditionalSuccessor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(441, 3627, 3785);

                    int
                    f_441_3674_3708(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(441, 3674, 3708);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(441, 3556, 3796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(441, 3556, 3796);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ControlFlowBranch> Predecessors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(441, 4111, 4261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 4158, 4195);

                    f_441_4158_4194(_predecessorsAreSealed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 4221, 4246);

                    return _lazyPredecessors;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(441, 4111, 4261);

                    int
                    f_441_4158_4194(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(441, 4158, 4194);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(441, 4033, 4272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(441, 4033, 4272);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Ordinal { get; }

        public bool IsReachable { get; }

        public ControlFlowRegion EnclosingRegion { get; }

        internal void SetSuccessors(ControlFlowBranch? successor, ControlFlowBranch? conditionalSuccessor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(441, 4877, 5348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5011, 5047);

                f_441_5011_5046(!_successorsAreSealed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5061, 5098);

                f_441_5061_5097(_lazySuccessor == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5112, 5160);

                f_441_5112_5159(_lazyConditionalSuccessor == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5184, 5211);

                _lazySuccessor = successor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5225, 5274);

                _lazyConditionalSuccessor = conditionalSuccessor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5301, 5329);

                _successorsAreSealed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(441, 4877, 5348);

                int
                f_441_5011_5046(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(441, 5011, 5046);
                    return 0;
                }


                int
                f_441_5061_5097(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(441, 5061, 5097);
                    return 0;
                }


                int
                f_441_5112_5159(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(441, 5112, 5159);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(441, 4877, 5348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(441, 4877, 5348);
            }
        }

        internal void SetPredecessors(ImmutableArray<ControlFlowBranch> predecessors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(441, 5360, 5752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5473, 5511);

                f_441_5473_5510(!_predecessorsAreSealed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5525, 5567);

                f_441_5525_5566(_lazyPredecessors.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5581, 5619);

                f_441_5581_5618(f_441_5594_5617_M(!predecessors.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5643, 5676);

                _lazyPredecessors = predecessors;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(441, 5703, 5733);

                _predecessorsAreSealed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(441, 5360, 5752);

                int
                f_441_5473_5510(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(441, 5473, 5510);
                    return 0;
                }


                int
                f_441_5525_5566(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(441, 5525, 5566);
                    return 0;
                }


                bool
                f_441_5594_5617_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(441, 5594, 5617);
                    return return_v;
                }


                int
                f_441_5581_5618(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(441, 5581, 5618);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(441, 5360, 5752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(441, 5360, 5752);
            }
        }

        static BasicBlock()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(441, 838, 5759);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(441, 838, 5759);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(441, 838, 5759);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(441, 838, 5759);
    }
}
