// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    internal static class SpanUtilities
    {
        public static bool All<TElement, TParam>(this ReadOnlySpan<TElement> span, TParam param, Func<TElement, TParam, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(367, 318, 679);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(367, 471, 640);
                    foreach (var e in f_367_489_493_I(span))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(367, 471, 640);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(367, 527, 625) || true) && (!f_367_532_551(predicate, e, param))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(367, 527, 625);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(367, 593, 606);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(367, 527, 625);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(367, 471, 640);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(367, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(367, 1, 170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(367, 656, 668);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(367, 318, 679);

                bool
                f_367_532_551(System.Func<TElement, TParam, bool>
                this_param, TElement?
                arg1, TParam?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(367, 532, 551);
                    return return_v;
                }


                System.ReadOnlySpan<TElement>
                f_367_489_493_I(System.ReadOnlySpan<TElement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(367, 489, 493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(367, 318, 679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(367, 318, 679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SpanUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(367, 266, 686);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(367, 266, 686);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(367, 266, 686);
        }

    }
}
