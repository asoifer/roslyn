// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Roslyn.Utilities
{
    internal static class DateTimeUtilities
    {
        private const long
        TicksMask = 0x3FFFFFFFFFFFFFFF
        ;

        internal static DateTime ToDateTime(double raw)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24010, 429, 810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24010, 690, 754);

                var
                tickCount = f_24010_706_741(raw) & TicksMask
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24010, 768, 799);

                return f_24010_775_798(tickCount);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24010, 429, 810);

                long
                f_24010_706_741(double
                value)
                {
                    var return_v = BitConverter.DoubleToInt64Bits(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24010, 706, 741);
                    return return_v;
                }


                System.DateTime
                f_24010_775_798(long
                ticks)
                {
                    var return_v = new System.DateTime(ticks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24010, 775, 798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24010, 429, 810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24010, 429, 810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DateTimeUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24010, 281, 817);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24010, 386, 416);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24010, 281, 817);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24010, 281, 817);
        }

    }
}
