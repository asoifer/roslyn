// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal static class FailFast
    {
        [DebuggerHidden]
        [DoesNotReturn]
        internal static void OnFatalException(Exception exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(328, 405, 1374);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 768, 857) || true) && (f_328_772_791())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(328, 768, 857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 825, 842);

                    f_328_825_841();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(328, 768, 857);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 976, 1151) || true) && (exception is AggregateException aggregate && (DynAbs.Tracing.TraceSender.Expression_True(328, 980, 1061) && f_328_1025_1056(f_328_1025_1050(aggregate)) == 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(328, 976, 1151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 1095, 1136);

                    exception = f_328_1107_1135(f_328_1107_1132(aggregate), 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(328, 976, 1151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 1175, 1212);

                f_328_1175_1211(exception: exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 1228, 1282);

                f_328_1228_1281(f_328_1249_1269(exception), exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 1296, 1333);

                throw f_328_1302_1332();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(328, 405, 1374);

                bool
                f_328_772_791()
                {
                    var return_v = Debugger.IsAttached;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 772, 791);
                    return return_v;
                }


                int
                f_328_825_841()
                {
                    Debugger.Break();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 825, 841);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                f_328_1025_1050(System.AggregateException
                this_param)
                {
                    var return_v = this_param.InnerExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 1025, 1050);
                    return return_v;
                }


                int
                f_328_1025_1056(System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 1025, 1056);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                f_328_1107_1132(System.AggregateException
                this_param)
                {
                    var return_v = this_param.InnerExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 1107, 1132);
                    return return_v;
                }


                System.Exception
                f_328_1107_1135(System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 1107, 1135);
                    return return_v;
                }


                int
                f_328_1175_1211(System.Exception
                exception)
                {
                    DumpStackTrace(exception: exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 1175, 1211);
                    return 0;
                }


                string
                f_328_1249_1269(System.Exception
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 1249, 1269);
                    return return_v;
                }


                int
                f_328_1228_1281(string
                message, System.Exception
                exception)
                {
                    Environment.FailFast(message, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 1228, 1281);
                    return 0;
                }


                System.Exception
                f_328_1302_1332()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 1302, 1332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(328, 405, 1374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(328, 405, 1374);
            }
        }

        [DebuggerHidden]
        [DoesNotReturn]
        internal static void Fail(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(328, 1386, 1672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 1503, 1536);

                f_328_1503_1535(message: message);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 1550, 1580);

                f_328_1550_1579(message);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 1594, 1631);

                throw f_328_1600_1630();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(328, 1386, 1672);

                int
                f_328_1503_1535(string
                message)
                {
                    DumpStackTrace(message: message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 1503, 1535);
                    return 0;
                }


                int
                f_328_1550_1579(string
                message)
                {
                    Environment.FailFast(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 1550, 1579);
                    return 0;
                }


                System.Exception
                f_328_1600_1630()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 1600, 1630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(328, 1386, 1672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(328, 1386, 1672);
            }
        }

        [Conditional("DEBUG")]
        internal static void DumpStackTrace(Exception? exception = null, string? message = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(328, 1895, 2844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2040, 2098);

                f_328_2040_2097("Dumping info before call to failfast");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2112, 2209) || true) && (message is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(328, 2112, 2209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2167, 2194);

                    f_328_2167_2193(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(328, 2112, 2209);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2225, 2595) || true) && (exception is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(328, 2225, 2595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2282, 2318);

                    f_328_2282_2317("Exception info");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2352, 2371);
                        for (Exception?
        current = exception
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2336, 2580) || true) && (current is object)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2392, 2424)
        , current = f_328_2402_2424(current), DynAbs.Tracing.TraceSender.TraceExitCondition(328, 2336, 2580))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(328, 2336, 2580);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2466, 2501);

                            f_328_2466_2500(f_328_2484_2499(current));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2523, 2561);

                            f_328_2523_2560(f_328_2541_2559(current));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(328, 1, 245);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(328, 1, 245);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(328, 2225, 2595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2642, 2686);

                f_328_2642_2685("Stack trace of handler");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2700, 2734);

                var
                stackTrace = f_328_2717_2733()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2748, 2789);

                f_328_2748_2788(f_328_2766_2787(stackTrace));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 2813, 2833);

                f_328_2813_2832(f_328_2813_2824());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(328, 1895, 2844);

                int
                f_328_2040_2097(string
                value)
                {
                    Console.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 2040, 2097);
                    return 0;
                }


                int
                f_328_2167_2193(string
                value)
                {
                    Console.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 2167, 2193);
                    return 0;
                }


                int
                f_328_2282_2317(string
                value)
                {
                    Console.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 2282, 2317);
                    return 0;
                }


                System.Exception?
                f_328_2402_2424(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 2402, 2424);
                    return return_v;
                }


                string
                f_328_2484_2499(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 2484, 2499);
                    return return_v;
                }


                int
                f_328_2466_2500(string
                value)
                {
                    Console.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 2466, 2500);
                    return 0;
                }


                string?
                f_328_2541_2559(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 2541, 2559);
                    return return_v;
                }


                int
                f_328_2523_2560(string?
                value)
                {
                    Console.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 2523, 2560);
                    return 0;
                }


                int
                f_328_2642_2685(string
                value)
                {
                    Console.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 2642, 2685);
                    return 0;
                }


                System.Diagnostics.StackTrace
                f_328_2717_2733()
                {
                    var return_v = new System.Diagnostics.StackTrace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 2717, 2733);
                    return return_v;
                }


                string
                f_328_2766_2787(System.Diagnostics.StackTrace
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 2766, 2787);
                    return return_v;
                }


                int
                f_328_2748_2788(string
                value)
                {
                    Console.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 2748, 2788);
                    return 0;
                }


                System.IO.TextWriter
                f_328_2813_2824()
                {
                    var return_v =
                                Console.Out;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 2813, 2824);
                    return return_v;
                }


                int
                f_328_2813_2832(System.IO.TextWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 2813, 2832);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(328, 1895, 2844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(328, 1895, 2844);
            }
        }

        [Conditional("DEBUG")]
        [DebuggerHidden]
        internal static void Assert([DoesNotReturnIf(false)] bool condition, string? message = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(328, 3497, 3990);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 3672, 3741) || true) && (condition)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(328, 3672, 3741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 3719, 3726);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(328, 3672, 3741);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 3757, 3846) || true) && (f_328_3761_3780())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(328, 3757, 3846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 3814, 3831);

                    f_328_3814_3830();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(328, 3757, 3846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 3862, 3895);

                f_328_3862_3894(message: message);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(328, 3909, 3979);

                f_328_3909_3978("ASSERT FAILED" + f_328_3948_3967() + message);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(328, 3497, 3990);

                bool
                f_328_3761_3780()
                {
                    var return_v = Debugger.IsAttached;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 3761, 3780);
                    return return_v;
                }


                int
                f_328_3814_3830()
                {
                    Debugger.Break();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 3814, 3830);
                    return 0;
                }


                int
                f_328_3862_3894(string?
                message)
                {
                    DumpStackTrace(message: message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 3862, 3894);
                    return 0;
                }


                string
                f_328_3948_3967()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(328, 3948, 3967);
                    return return_v;
                }


                int
                f_328_3909_3978(string
                message)
                {
                    Environment.FailFast(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(328, 3909, 3978);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(328, 3497, 3990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(328, 3497, 3990);
            }
        }

        static FailFast()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(328, 358, 3997);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(328, 358, 3997);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(328, 358, 3997);
        }

    }
}
