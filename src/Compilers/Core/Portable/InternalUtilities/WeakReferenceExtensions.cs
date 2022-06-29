// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Roslyn.Utilities
{
    internal static class WeakReferenceExtensions
    {
        public static T? GetTarget<T>(this WeakReference<T> reference) where T : class?
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(397, 382, 564);
                T target = default(T);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(397, 486, 525);

                f_397_486_524(reference, out target);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(397, 539, 553);

                return target;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(397, 382, 564);

                bool
                f_397_486_524(System.WeakReference<T>
                this_param, out T?
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(397, 486, 524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(397, 382, 564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(397, 382, 564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNull<T>(this WeakReference<T> reference) where T : class?
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(397, 576, 728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(397, 679, 717);

                return !f_397_687_716(reference, out _);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(397, 576, 728);

                bool
                f_397_687_716(System.WeakReference<T>
                this_param, out T?
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(397, 687, 716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(397, 576, 728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(397, 576, 728);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static WeakReferenceExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(397, 320, 735);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(397, 320, 735);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(397, 320, 735);
        }

    }
}
