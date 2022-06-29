// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Roslyn.Utilities
{
    internal static class DecimalUtilities
    {
        public static int GetScale(this decimal value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(320, 298, 438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(320, 369, 427);

                return unchecked((byte)(f_320_393_415(value)[3] >> 16));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(320, 298, 438);

                int[]
                f_320_393_415(decimal
                d)
                {
                    var return_v = decimal.GetBits(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(320, 393, 415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(320, 298, 438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(320, 298, 438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void GetBits(this decimal value, out bool isNegative, out byte scale, out uint low, out uint mid, out uint high)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(320, 450, 1614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(320, 601, 637);

                int[]
                bits = f_320_614_636(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(320, 885, 916);

                low = unchecked((uint)bits[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(320, 930, 961);

                mid = unchecked((uint)bits[1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(320, 975, 1007);

                high = unchecked((uint)bits[2]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(320, 1507, 1548);

                scale = unchecked((byte)(bits[3] >> 16));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(320, 1562, 1603);

                isNegative = (bits[3] & 0x80000000) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(320, 450, 1614);

                int[]
                f_320_614_636(decimal
                d)
                {
                    var return_v = decimal.GetBits(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(320, 614, 636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(320, 450, 1614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(320, 450, 1614);
            }
        }

        static DecimalUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(320, 243, 1621);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(320, 243, 1621);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(320, 243, 1621);
        }

    }
}
