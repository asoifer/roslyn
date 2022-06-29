// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.CodeAnalysis
{
    internal static class StackGuard
    {
        public const int
        MaxUncheckedRecursionDepth = 20
        ;

        [DebuggerStepThrough]
        public static void EnsureSufficientExecutionStack(int recursionDepth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(383, 914, 1194);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(383, 1039, 1183) || true) && (recursionDepth > MaxUncheckedRecursionDepth)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(383, 1039, 1183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(383, 1120, 1168);

                    f_383_1120_1167();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(383, 1039, 1183);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(383, 914, 1194);

                int
                f_383_1120_1167()
                {
                    RuntimeHelpers.EnsureSufficientExecutionStack();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(383, 1120, 1167);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(383, 914, 1194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(383, 914, 1194);
            }
        }

        static StackGuard()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(383, 333, 1201);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(383, 399, 430);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(383, 333, 1201);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(383, 333, 1201);
        }

    }
}
