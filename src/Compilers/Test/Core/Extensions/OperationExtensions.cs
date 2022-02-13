// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    internal static class OperationTestExtensions
    {
        public static bool MustHaveNullType(this IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25009, 347, 785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25009, 434, 774);

                switch (f_25009_442_456(operation))
                {

                    case OperationKind.ArrayInitializer:
                    case OperationKind.Argument:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25009, 434, 774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25009, 684, 696);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25009, 434, 774);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25009, 434, 774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25009, 746, 759);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25009, 434, 774);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25009, 347, 785);

                Microsoft.CodeAnalysis.OperationKind
                f_25009_442_456(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25009, 442, 456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25009, 347, 785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25009, 347, 785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OperationTestExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25009, 285, 792);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25009, 285, 792);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25009, 285, 792);
        }

    }
}
