// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Operations
{
    public abstract class OperationWalker : OperationVisitor
    {
        private int _recursionDepth;

        private void VisitChildOperations(IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(473, 606, 819);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(473, 686, 808);
                    foreach (var child in f_473_708_746_I(f_473_708_746(((Operation)operation))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(473, 686, 808);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(473, 780, 793);

                        f_473_780_792(this, child);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(473, 686, 808);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(473, 1, 123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(473, 1, 123);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(473, 606, 819);

                Microsoft.CodeAnalysis.Operation.Enumerable
                f_473_708_746(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.ChildOperations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(473, 708, 746);
                    return return_v;
                }


                int
                f_473_780_792(Microsoft.CodeAnalysis.Operations.OperationWalker
                this_param, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    this_param.Visit(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(473, 780, 792);
                    return 0;
                }


                Microsoft.CodeAnalysis.Operation.Enumerable
                f_473_708_746_I(Microsoft.CodeAnalysis.Operation.Enumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(473, 708, 746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(473, 606, 819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(473, 606, 819);
            }
        }

        public override void Visit(IOperation? operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(473, 831, 1292);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(473, 905, 1281) || true) && (operation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(473, 905, 1281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(473, 960, 978);

                    _recursionDepth++;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(473, 1040, 1099);

                        f_473_1040_1098(_recursionDepth);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(473, 1121, 1144);

                        f_473_1121_1143(operation, this);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(473, 1181, 1266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(473, 1229, 1247);

                        _recursionDepth--;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(473, 1181, 1266);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(473, 905, 1281);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(473, 831, 1292);

                int
                f_473_1040_1098(int
                recursionDepth)
                {
                    StackGuard.EnsureSufficientExecutionStack(recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(473, 1040, 1098);
                    return 0;
                }


                int
                f_473_1121_1143(Microsoft.CodeAnalysis.IOperation
                this_param, Microsoft.CodeAnalysis.Operations.OperationWalker
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.Operations.OperationVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(473, 1121, 1143);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(473, 831, 1292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(473, 831, 1292);
            }
        }

        public override void DefaultVisit(IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(473, 1304, 1427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(473, 1384, 1416);

                f_473_1384_1415(this, operation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(473, 1304, 1427);

                int
                f_473_1384_1415(Microsoft.CodeAnalysis.Operations.OperationWalker
                this_param, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    this_param.VisitChildOperations(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(473, 1384, 1415);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(473, 1304, 1427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(473, 1304, 1427);
            }
        }

        internal override void VisitNoneOperation(IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(473, 1439, 1570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(473, 1527, 1559);

                f_473_1527_1558(this, operation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(473, 1439, 1570);

                int
                f_473_1527_1558(Microsoft.CodeAnalysis.Operations.OperationWalker
                this_param, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    this_param.VisitChildOperations(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(473, 1527, 1558);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(473, 1439, 1570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(473, 1439, 1570);
            }
        }

        public OperationWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(473, 493, 1577);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(473, 578, 593);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(473, 493, 1577);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(473, 493, 1577);
        }


        static OperationWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(473, 493, 1577);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(473, 493, 1577);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(473, 493, 1577);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(473, 493, 1577);
    }
    public abstract class OperationWalker<TArgument> : OperationVisitor<TArgument, object?>
    {
        private int _recursionDepth;

        private void VisitChildrenOperations(IOperation operation, TArgument argument)
        {
            foreach (var child in ((Operation)operation).ChildOperations)
            {
                Visit(child, argument);
            }
        }

        public override object? Visit(IOperation? operation, TArgument argument)
        {
            if (operation != null)
            {
                _recursionDepth++;
                try
                {
                    StackGuard.EnsureSufficientExecutionStack(_recursionDepth);
                    operation.Accept(this, argument);
                }
                finally
                {
                    _recursionDepth--;
                }
            }

            return null;
        }

        public override object? DefaultVisit(IOperation operation, TArgument argument)
        {
            VisitChildrenOperations(operation, argument);
            return null;
        }

        internal override object? VisitNoneOperation(IOperation operation, TArgument argument)
        {
            VisitChildrenOperations(operation, argument);
            return null;
        }
    }
}
