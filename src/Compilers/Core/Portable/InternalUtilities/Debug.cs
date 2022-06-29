// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal static class RoslynDebug
    {
        [Conditional("DEBUG")]
        public static void Assert([DoesNotReturnIf(false)] bool b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(319, 506, 524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(319, 509, 524);
                f_319_509_524(b); DynAbs.Tracing.TraceSender.TraceExitMethod(319, 506, 524);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(319, 506, 524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(319, 506, 524);
            }

            int
            f_319_509_524(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(319, 509, 524);
                return 0;
            }

        }

        [Conditional("DEBUG")]
        public static void Assert([DoesNotReturnIf(false)] bool b, string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(319, 718, 745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(319, 721, 745);
                f_319_721_745(b, message); DynAbs.Tracing.TraceSender.TraceExitMethod(319, 718, 745);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(319, 718, 745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(319, 718, 745);
            }

            int
            f_319_721_745(bool
            condition, string
            message)
            {
                Debug.Assert(condition, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(319, 721, 745);
                return 0;
            }

        }

        [Conditional("DEBUG")]
        public static void AssertNotNull<T>([NotNull] T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(319, 758, 933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(319, 869, 922);

                f_319_869_921(value is object, "Unexpected null reference");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(319, 758, 933);

                int
                f_319_869_921(bool
                b, string
                message)
                {
                    Assert(b, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(319, 869, 921);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(319, 758, 933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(319, 758, 933);
            }
        }

        static RoslynDebug()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(319, 312, 940);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(319, 312, 940);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(319, 312, 940);
        }

    }
}
