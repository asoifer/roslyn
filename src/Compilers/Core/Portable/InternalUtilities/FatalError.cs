// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Microsoft.CodeAnalysis
{
    internal static class FatalError
    {
        private static Action<Exception>? s_fatalHandler;

        private static Action<Exception>? s_nonFatalHandler;

        private static Exception? s_reportedException;

        private static string? s_reportedExceptionMessage;

        [DisallowNull]
        public static Action<Exception>? Handler
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 1162, 1235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 1198, 1220);

                    return s_fatalHandler;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 1162, 1235);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 1073, 1506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 1073, 1506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 1251, 1495);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 1287, 1480) || true) && (s_fatalHandler != value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(329, 1287, 1480);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 1356, 1416);

                        f_329_1356_1415(s_fatalHandler == null, "Handler already set");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 1438, 1461);

                        s_fatalHandler = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(329, 1287, 1480);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 1251, 1495);

                    int
                    f_329_1356_1415(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 1356, 1415);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 1073, 1506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 1073, 1506);
                }
            }
        }

        [DisallowNull]
        public static Action<Exception>? NonFatalHandler
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 1800, 1876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 1836, 1861);

                    return s_nonFatalHandler;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 1800, 1876);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 1703, 2156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 1703, 2156);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 1892, 2145);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 1928, 2130) || true) && (s_nonFatalHandler != value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(329, 1928, 2130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 2000, 2063);

                        f_329_2000_2062(s_nonFatalHandler == null, "Handler already set");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 2085, 2111);

                        s_nonFatalHandler = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(329, 1928, 2130);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 1892, 2145);

                    int
                    f_329_2000_2062(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 2000, 2062);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 1703, 2156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 1703, 2156);
                }
            }
        }

        public static void OverwriteHandler(Action<Exception>? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 2410, 2530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 2496, 2519);

                s_fatalHandler = value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 2410, 2530);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 2410, 2530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 2410, 2530);
            }
        }

        private static bool IsCurrentOperationBeingCancelled(Exception exception, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(329, 2666, 2753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 2669, 2753);
                return exception is OperationCanceledException && (DynAbs.Tracing.TraceSender.Expression_True(329, 2669, 2753) && cancellationToken.IsCancellationRequested); DynAbs.Tracing.TraceSender.TraceExitMethod(329, 2666, 2753);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 2666, 2753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 2666, 2753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerHidden]
        public static bool ReportAndPropagateUnlessCanceled(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 3134, 3426);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 3257, 3362) || true) && (exception is OperationCanceledException)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(329, 3257, 3362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 3334, 3347);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(329, 3257, 3362);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 3378, 3415);

                return f_329_3385_3414(exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 3134, 3426);

                bool
                f_329_3385_3414(System.Exception
                exception)
                {
                    var return_v = ReportAndPropagate(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 3385, 3414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 3134, 3426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 3134, 3426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerHidden]
        public static bool ReportAndPropagateUnlessCanceled(Exception exception, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 3778, 4130);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 3938, 4066) || true) && (f_329_3942_4004(exception, cancellationToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(329, 3938, 4066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 4038, 4051);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(329, 3938, 4066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 4082, 4119);

                return f_329_4089_4118(exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 3778, 4130);

                bool
                f_329_3942_4004(System.Exception
                exception, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = IsCurrentOperationBeingCancelled(exception, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 3942, 4004);
                    return return_v;
                }


                bool
                f_329_4089_4118(System.Exception
                exception)
                {
                    var return_v = ReportAndPropagate(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 4089, 4118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 3778, 4130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 3778, 4130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerHidden]
        public static bool ReportAndCatchUnlessCanceled(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 4514, 4798);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 4633, 4738) || true) && (exception is OperationCanceledException)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(329, 4633, 4738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 4710, 4723);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(329, 4633, 4738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 4754, 4787);

                return f_329_4761_4786(exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 4514, 4798);

                bool
                f_329_4761_4786(System.Exception
                exception)
                {
                    var return_v = ReportAndCatch(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 4761, 4786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 4514, 4798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 4514, 4798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerHidden]
        public static bool ReportAndCatchUnlessCanceled(Exception exception, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 5154, 5498);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 5310, 5438) || true) && (f_329_5314_5376(exception, cancellationToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(329, 5310, 5438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 5410, 5423);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(329, 5310, 5438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 5454, 5487);

                return f_329_5461_5486(exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 5154, 5498);

                bool
                f_329_5314_5376(System.Exception
                exception, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = IsCurrentOperationBeingCancelled(exception, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 5314, 5376);
                    return return_v;
                }


                bool
                f_329_5461_5486(System.Exception
                exception)
                {
                    var return_v = ReportAndCatch(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 5461, 5486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 5154, 5498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 5154, 5498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerHidden]
        public static bool ReportAndPropagate(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 5795, 5976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 5904, 5938);

                f_329_5904_5937(exception, s_fatalHandler);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 5952, 5965);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 5795, 5976);

                int
                f_329_5904_5937(System.Exception
                exception, System.Action<System.Exception>?
                handler)
                {
                    Report(exception, handler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 5904, 5937);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 5795, 5976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 5795, 5976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerHidden]
        public static bool ReportAndCatch(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 6670, 6849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 6775, 6812);

                f_329_6775_6811(exception, s_nonFatalHandler);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 6826, 6838);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 6670, 6849);

                int
                f_329_6775_6811(System.Exception
                exception, System.Action<System.Exception>?
                handler)
                {
                    Report(exception, handler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 6775, 6811);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 6670, 6849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 6670, 6849);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly object s_reportedMarker;

        private static void Report(Exception exception, Action<Exception>? handler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(329, 6929, 7883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7099, 7131);

                s_reportedException = exception;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7145, 7195);

                s_reportedExceptionMessage = f_329_7174_7194(exception);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7211, 7286) || true) && (handler == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(329, 7211, 7286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7264, 7271);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(329, 7211, 7286);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7345, 7445) || true) && (f_329_7349_7381(f_329_7349_7363(exception), s_reportedMarker) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(329, 7345, 7445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7423, 7430);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(329, 7345, 7445);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7473, 7677) || true) && (exception is AggregateException aggregate && (DynAbs.Tracing.TraceSender.Expression_True(329, 7477, 7558) && f_329_7522_7553(f_329_7522_7547(aggregate)) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(329, 7477, 7621) && f_329_7562_7613(f_329_7562_7595(f_329_7562_7590(f_329_7562_7587(aggregate), 0)), s_reportedMarker) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(329, 7473, 7677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7655, 7662);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(329, 7473, 7677);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7699, 7830) || true) && (f_329_7703_7729_M(!f_329_7704_7718(exception).IsReadOnly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(329, 7699, 7830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7763, 7815);

                    f_329_7763_7777(exception)[s_reportedMarker] = s_reportedMarker;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(329, 7699, 7830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 7846, 7872);

                f_329_7846_7871(
                            handler, exception);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(329, 6929, 7883);

                string
                f_329_7174_7194(System.Exception
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 7174, 7194);
                    return return_v;
                }


                System.Collections.IDictionary
                f_329_7349_7363(System.Exception
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7349, 7363);
                    return return_v;
                }


                object?
                f_329_7349_7381(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7349, 7381);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                f_329_7522_7547(System.AggregateException
                this_param)
                {
                    var return_v = this_param.InnerExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7522, 7547);
                    return return_v;
                }


                int
                f_329_7522_7553(System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7522, 7553);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                f_329_7562_7587(System.AggregateException
                this_param)
                {
                    var return_v = this_param.InnerExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7562, 7587);
                    return return_v;
                }


                System.Exception
                f_329_7562_7590(System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7562, 7590);
                    return return_v;
                }


                System.Collections.IDictionary
                f_329_7562_7595(System.Exception
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7562, 7595);
                    return return_v;
                }


                object?
                f_329_7562_7613(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7562, 7613);
                    return return_v;
                }


                System.Collections.IDictionary
                f_329_7704_7718(System.Exception
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7704, 7718);
                    return return_v;
                }


                bool
                f_329_7703_7729_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7703, 7729);
                    return return_v;
                }


                System.Collections.IDictionary
                f_329_7763_7777(System.Exception
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(329, 7763, 7777);
                    return return_v;
                }


                int
                f_329_7846_7871(System.Action<System.Exception>
                this_param, System.Exception
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(329, 7846, 7871);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(329, 6929, 7883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 6929, 7883);
            }
        }

        static FatalError()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(329, 440, 7890);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 523, 537);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 582, 599);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 771, 790);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 824, 850);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(329, 6892, 6916);
            s_reportedMarker = new(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(329, 440, 7890);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(329, 440, 7890);
        }

    }
}
