// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Roslyn.Utilities
{
    internal static class YieldAwaitableExtensions
    {
        public static ConfiguredYieldAwaitable ConfigureAwait(this YieldAwaitable awaitable, bool continueOnCapturedContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(399, 915, 1141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(399, 1056, 1130);

                return f_399_1063_1129(awaitable, continueOnCapturedContext);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(399, 915, 1141);

                Roslyn.Utilities.ConfiguredYieldAwaitable
                f_399_1063_1129(System.Runtime.CompilerServices.YieldAwaitable
                awaitable, bool
                continueOnCapturedContext)
                {
                    var return_v = new Roslyn.Utilities.ConfiguredYieldAwaitable(awaitable, continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(399, 1063, 1129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(399, 915, 1141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(399, 915, 1141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static YieldAwaitableExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(399, 316, 1148);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(399, 316, 1148);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(399, 316, 1148);
        }

    }
}
