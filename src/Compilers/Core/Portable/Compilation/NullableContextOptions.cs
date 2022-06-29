// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents the default state of nullable analysis in this compilation.
    /// </summary>
    [Flags]
    public enum NullableContextOptions
    {
        /// <summary>
        /// The nullable analysis feature is disabled.
        /// </summary>
        Disable = 0,

        /// <summary>
        /// Nullable warnings are enabled and will be reported by default.
        /// </summary>
        Warnings = 1,

        /// <summary>
        /// Nullable annotations are enabled and will be shown when APIs
        /// defined in this project are used in other contexts.
        /// </summary>
        Annotations = 1 << 1,

        /// <summary>
        /// The nullable analysis feature is fully enabled.
        /// </summary>
        Enable = Warnings | Annotations,
    }
    public static class NullableContextOptionsExtensions
    {
        private static bool IsFlagSet(NullableContextOptions context, NullableContextOptions flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(156, 1258, 1298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(156, 1274, 1298);
                return (context & flag) == flag; DynAbs.Tracing.TraceSender.TraceExitMethod(156, 1258, 1298);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(156, 1258, 1298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(156, 1258, 1298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool WarningsEnabled(this NullableContextOptions context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(156, 1490, 1557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(156, 1506, 1557);
                return f_156_1506_1557(context, NullableContextOptions.Warnings); DynAbs.Tracing.TraceSender.TraceExitMethod(156, 1490, 1557);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(156, 1490, 1557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(156, 1490, 1557);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_156_1506_1557(Microsoft.CodeAnalysis.NullableContextOptions
            context, Microsoft.CodeAnalysis.NullableContextOptions
            flag)
            {
                var return_v = IsFlagSet(context, flag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(156, 1506, 1557);
                return return_v;
            }

        }

        public static bool AnnotationsEnabled(this NullableContextOptions context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(156, 1755, 1825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(156, 1771, 1825);
                return f_156_1771_1825(context, NullableContextOptions.Annotations); DynAbs.Tracing.TraceSender.TraceExitMethod(156, 1755, 1825);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(156, 1755, 1825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(156, 1755, 1825);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_156_1771_1825(Microsoft.CodeAnalysis.NullableContextOptions
            context, Microsoft.CodeAnalysis.NullableContextOptions
            flag)
            {
                var return_v = IsFlagSet(context, flag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(156, 1771, 1825);
                return return_v;
            }

        }

        static NullableContextOptionsExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(156, 1098, 1833);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(156, 1098, 1833);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(156, 1098, 1833);
        }

    }
}
