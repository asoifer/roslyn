// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class AbstractRegionControlFlowPass : ControlFlowPass
    {
        internal AbstractRegionControlFlowPass(
                    CSharpCompilation compilation,
                    Symbol member,
                    BoundNode node,
                    BoundNode firstInRegion,
                    BoundNode lastInRegion)
        : base(f_10881_686_697_C(compilation), member, node, firstInRegion, lastInRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10881, 450, 763);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10881, 450, 763);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10881, 450, 763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10881, 450, 763);
            }
        }

        public override BoundNode Visit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10881, 775, 902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 847, 865);

                f_10881_847_864(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 879, 891);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10881, 775, 902);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10881_847_864(Microsoft.CodeAnalysis.CSharp.AbstractRegionControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.VisitAlways(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 847, 864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10881, 775, 902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10881, 775, 902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10881, 1019, 1893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1099, 1130);

                var
                oldPending = f_10881_1116_1129(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1191, 1226);

                LocalState
                finalState = this.State
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1240, 1264);

                this.State = f_10881_1253_1263(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1278, 1310);

                var
                oldPending2 = f_10881_1296_1309(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1324, 1347);

                f_10881_1324_1346(this, f_10881_1336_1345(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1361, 1389);

                f_10881_1361_1388(this, oldPending2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1458, 1521);

                ImmutableArray<PendingBranch>
                pendingReturns = f_10881_1505_1520(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1535, 1562);

                f_10881_1535_1561(this, oldPending);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1576, 1613);

                f_10881_1576_1612(this, ref finalState, ref this.State);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1627, 1816);
                    foreach (PendingBranch returnBranch in f_10881_1666_1680_I(pendingReturns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10881, 1627, 1816);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1714, 1746);

                        this.State = returnBranch.State;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1764, 1801);

                        f_10881_1764_1800(this, ref finalState, ref this.State);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10881, 1627, 1816);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10881, 1, 190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10881, 1, 190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1832, 1856);

                this.State = finalState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10881, 1870, 1882);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10881, 1019, 1893);

                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                f_10881_1116_1129(Microsoft.CodeAnalysis.CSharp.AbstractRegionControlFlowPass
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 1116, 1129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
                f_10881_1253_1263(Microsoft.CodeAnalysis.CSharp.AbstractRegionControlFlowPass
                this_param)
                {
                    var return_v = this_param.TopState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 1253, 1263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                f_10881_1296_1309(Microsoft.CodeAnalysis.CSharp.AbstractRegionControlFlowPass
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 1296, 1309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10881_1336_1345(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10881, 1336, 1345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10881_1324_1346(Microsoft.CodeAnalysis.CSharp.AbstractRegionControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.VisitAlways((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 1324, 1346);
                    return return_v;
                }


                int
                f_10881_1361_1388(Microsoft.CodeAnalysis.CSharp.AbstractRegionControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 1361, 1388);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10881_1505_1520(Microsoft.CodeAnalysis.CSharp.AbstractRegionControlFlowPass
                this_param)
                {
                    var return_v = this_param.RemoveReturns();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 1505, 1520);
                    return return_v;
                }


                int
                f_10881_1535_1561(Microsoft.CodeAnalysis.CSharp.AbstractRegionControlFlowPass
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 1535, 1561);
                    return 0;
                }


                bool
                f_10881_1576_1612(Microsoft.CodeAnalysis.CSharp.AbstractRegionControlFlowPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
                self, ref Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 1576, 1612);
                    return return_v;
                }


                bool
                f_10881_1764_1800(Microsoft.CodeAnalysis.CSharp.AbstractRegionControlFlowPass
                this_param, ref Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
                self, ref Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 1764, 1800);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                f_10881_1666_1680_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalState, Microsoft.CodeAnalysis.CSharp.ControlFlowPass.LocalFunctionState>.PendingBranch>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10881, 1666, 1680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10881, 1019, 1893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10881, 1019, 1893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AbstractRegionControlFlowPass()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10881, 362, 1900);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10881, 362, 1900);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10881, 362, 1900);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10881, 362, 1900);

        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10881_686_697_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10881, 450, 763);
            return return_v;
        }

    }
}
