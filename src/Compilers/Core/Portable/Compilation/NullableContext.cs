// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents the state of the nullable analysis at a specific point in a file. Bits one and
    /// two correspond to whether the nullable feature is enabled. Bits three and four correspond
    /// to whether the context was inherited from the global context.
    /// </summary>
    [Flags]
    public enum NullableContext
    {
        /// <summary>
        /// Nullable warnings and annotations are explicitly turned off at this location.
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// Nullable warnings are enabled and will be reported at this file location.
        /// </summary>
        WarningsEnabled = 1,

        /// <summary>
        /// Nullable annotations are enabled and will be shown when APIs defined at
        /// this location are used in other contexts.
        /// </summary>
        AnnotationsEnabled = 1 << 1,

        /// <summary>
        /// The nullable feature is fully enabled.
        /// </summary>
        Enabled = WarningsEnabled | AnnotationsEnabled,

        /// <summary>
        /// The nullable warning state is inherited from the project default.
        /// </summary>
        /// <remarks>
        /// The project default can change depending on the file type. Generated
        /// files have nullable off by default, regardless of the project-level
        /// default setting.
        /// </remarks>
        WarningsContextInherited = 1 << 2,

        /// <summary>
        /// The nullable annotation state is inherited from the project default.
        /// </summary>
        /// <remarks>
        /// The project default can change depending on the file type. Generated
        /// files have nullable off by default, regardless of the project-level
        /// default setting.
        /// </remarks>
        AnnotationsContextInherited = 1 << 3,

        /// <summary>
        /// The current state of both warnings and annotations are inherited from
        /// the project default.
        /// </summary>
        /// <remarks>
        /// This flag is set by default at the start of all files.
        ///
        /// The project default can change depending on the file type. Generated
        /// files have nullable off by default, regardless of the project-level
        /// default setting.
        /// </remarks>
        ContextInherited = WarningsContextInherited | AnnotationsContextInherited
    }
    public static class NullableContextExtensions
    {
        private static bool IsFlagSet(NullableContext context, NullableContext flag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(155, 2887, 2927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(155, 2903, 2927);
                return (context & flag) == flag; DynAbs.Tracing.TraceSender.TraceExitMethod(155, 2887, 2927);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(155, 2887, 2927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(155, 2887, 2927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool WarningsEnabled(this NullableContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(155, 3129, 3196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(155, 3145, 3196);
                return f_155_3145_3196(context, NullableContext.WarningsEnabled); DynAbs.Tracing.TraceSender.TraceExitMethod(155, 3129, 3196);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(155, 3129, 3196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(155, 3129, 3196);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_155_3145_3196(Microsoft.CodeAnalysis.NullableContext
            context, Microsoft.CodeAnalysis.NullableContext
            flag)
            {
                var return_v = IsFlagSet(context, flag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(155, 3145, 3196);
                return return_v;
            }

        }

        public static bool AnnotationsEnabled(this NullableContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(155, 3404, 3474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(155, 3420, 3474);
                return f_155_3420_3474(context, NullableContext.AnnotationsEnabled); DynAbs.Tracing.TraceSender.TraceExitMethod(155, 3404, 3474);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(155, 3404, 3474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(155, 3404, 3474);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_155_3420_3474(Microsoft.CodeAnalysis.NullableContext
            context, Microsoft.CodeAnalysis.NullableContext
            flag)
            {
                var return_v = IsFlagSet(context, flag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(155, 3420, 3474);
                return return_v;
            }

        }

        public static bool WarningsInherited(this NullableContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(155, 3716, 3792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(155, 3732, 3792);
                return f_155_3732_3792(context, NullableContext.WarningsContextInherited); DynAbs.Tracing.TraceSender.TraceExitMethod(155, 3716, 3792);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(155, 3716, 3792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(155, 3716, 3792);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_155_3732_3792(Microsoft.CodeAnalysis.NullableContext
            context, Microsoft.CodeAnalysis.NullableContext
            flag)
            {
                var return_v = IsFlagSet(context, flag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(155, 3732, 3792);
                return return_v;
            }

        }

        public static bool AnnotationsInherited(this NullableContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(155, 4040, 4119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(155, 4056, 4119);
                return f_155_4056_4119(context, NullableContext.AnnotationsContextInherited); DynAbs.Tracing.TraceSender.TraceExitMethod(155, 4040, 4119);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(155, 4040, 4119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(155, 4040, 4119);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_155_4056_4119(Microsoft.CodeAnalysis.NullableContext
            context, Microsoft.CodeAnalysis.NullableContext
            flag)
            {
                var return_v = IsFlagSet(context, flag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(155, 4056, 4119);
                return return_v;
            }

        }

        static NullableContextExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(155, 2748, 4127);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(155, 2748, 4127);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(155, 2748, 4127);
        }

    }
}
