// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal static class RoslynString
    {
        public static bool IsNullOrEmpty([NotNullWhen(returnValue: false)] string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(363, 494, 524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(363, 497, 524);
                return f_363_497_524(value); DynAbs.Tracing.TraceSender.TraceExitMethod(363, 494, 524);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(363, 494, 524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(363, 494, 524);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_363_497_524(string?
            value)
            {
                var return_v = string.IsNullOrEmpty(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(363, 497, 524);
                return return_v;
            }

        }

        public static bool IsNullOrWhiteSpace([NotNullWhen(returnValue: false)] string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(363, 717, 752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(363, 720, 752);
                return f_363_720_752(value); DynAbs.Tracing.TraceSender.TraceExitMethod(363, 717, 752);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(363, 717, 752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(363, 717, 752);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_363_720_752(string?
            value)
            {
                var return_v = string.IsNullOrWhiteSpace(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(363, 720, 752);
                return return_v;
            }

        }

        static RoslynString()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(363, 285, 768);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(363, 285, 768);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(363, 285, 768);
        }

    }
}
