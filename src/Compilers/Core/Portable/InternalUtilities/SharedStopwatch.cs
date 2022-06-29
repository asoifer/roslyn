// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;

namespace Roslyn.Utilities
{

    internal readonly struct SharedStopwatch
    {

        private static readonly Stopwatch s_stopwatch;

        private readonly TimeSpan _started;

        private SharedStopwatch(TimeSpan started)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(366, 493, 589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(366, 559, 578);

                _started = started;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(366, 493, 589);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(366, 493, 589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(366, 493, 589);
            }
        }

        public TimeSpan Elapsed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(366, 625, 658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(366, 628, 658);
                    return f_366_628_647(s_stopwatch) - _started; DynAbs.Tracing.TraceSender.TraceExitMethod(366, 625, 658);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(366, 625, 658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(366, 625, 658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static SharedStopwatch StartNew()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(366, 725, 768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(366, 728, 768);
                return f_366_728_768(f_366_748_767(s_stopwatch)); DynAbs.Tracing.TraceSender.TraceExitMethod(366, 725, 768);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(366, 725, 768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(366, 725, 768);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.TimeSpan
            f_366_748_767(System.Diagnostics.Stopwatch
            this_param)
            {
                var return_v = this_param.Elapsed;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(366, 748, 767);
                return return_v;
            }


            Roslyn.Utilities.SharedStopwatch
            f_366_728_768(System.TimeSpan
            started)
            {
                var return_v = new Roslyn.Utilities.SharedStopwatch(started);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(366, 728, 768);
                return return_v;
            }

        }
        static SharedStopwatch()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(366, 308, 776);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(366, 399, 433);
            s_stopwatch = f_366_413_433(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(366, 308, 776);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(366, 308, 776);
        }

        static System.Diagnostics.Stopwatch
        f_366_413_433()
        {
            var return_v = Stopwatch.StartNew();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(366, 413, 433);
            return return_v;
        }


        System.TimeSpan
        f_366_628_647(System.Diagnostics.Stopwatch
        this_param)
        {
            var return_v = this_param.Elapsed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(366, 628, 647);
            return return_v;
        }

    }
}
