// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Operations
{
    public abstract partial class OperationVisitor
    {
        internal virtual void VisitFixed(IFixedOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(472, 639, 786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(472, 757, 786);
                f_472_757_786(this, operation); DynAbs.Tracing.TraceSender.TraceExitMethod(472, 639, 786);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(472, 639, 786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(472, 639, 786);
            }

            int
            f_472_757_786(Microsoft.CodeAnalysis.Operations.OperationVisitor
            this_param, Microsoft.CodeAnalysis.Operations.IFixedOperation
            operation)
            {
                this_param.VisitNoneOperation((Microsoft.CodeAnalysis.IOperation)operation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(472, 757, 786);
                return 0;
            }

        }
    }
    public abstract partial class OperationVisitor<TArgument, TResult>
    {        // Make public after review: https://github.com/dotnet/roslyn/issues/21281
        internal virtual TResult? VisitFixed(IFixedOperation operation, TArgument argument) =>
            // https://github.com/dotnet/roslyn/issues/21281
            //return DefaultVisit(operation, argument);
            VisitNoneOperation(operation, argument);
    }
}
