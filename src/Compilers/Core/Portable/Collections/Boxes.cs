// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    internal static class Boxes
    {
        public static readonly object BoxedTrue;

        public static readonly object BoxedFalse;

        public static readonly object BoxedByteZero;

        public static readonly object BoxedSByteZero;

        public static readonly object BoxedInt16Zero;

        public static readonly object BoxedUInt16Zero;

        public static readonly object BoxedInt32Zero;

        public static readonly object BoxedInt32One;

        public static readonly object BoxedUInt32Zero;

        public static readonly object BoxedInt64Zero;

        public static readonly object BoxedUInt64Zero;

        public static readonly object BoxedSingleZero;

        public static readonly object BoxedDoubleZero;

        public static readonly object BoxedDecimalZero;

        private static readonly object?[] s_boxedAsciiChars;

        public static object Box(bool b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 1262, 1364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1319, 1353);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 1326, 1327) || ((b && DynAbs.Tracing.TraceSender.Conditional_F2(94, 1330, 1339)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 1342, 1352))) ? BoxedTrue : BoxedFalse;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 1262, 1364);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 1262, 1364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 1262, 1364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object Box(byte b)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 1376, 1478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1433, 1467);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 1440, 1446) || ((b == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(94, 1449, 1462)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 1465, 1466))) ? BoxedByteZero : b;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 1376, 1478);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 1376, 1478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 1376, 1478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object Box(sbyte sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 1490, 1597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1549, 1586);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 1556, 1563) || ((sb == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(94, 1566, 1580)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 1583, 1585))) ? BoxedSByteZero : sb;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 1490, 1597);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 1490, 1597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 1490, 1597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object Box(short s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 1609, 1713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1667, 1702);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 1674, 1680) || ((s == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(94, 1683, 1697)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 1700, 1701))) ? BoxedInt16Zero : s;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 1609, 1713);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 1609, 1713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 1609, 1713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object Box(ushort us)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 1725, 1834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1785, 1823);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 1792, 1799) || ((us == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(94, 1802, 1817)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 1820, 1822))) ? BoxedUInt16Zero : us;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 1725, 1834);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 1725, 1834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 1725, 1834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object Box(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 1846, 2084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1902, 2073);

                switch (i)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(94, 1902, 2073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1953, 1975);

                        return BoxedInt32Zero;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(94, 1902, 2073);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(94, 1902, 2073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 2001, 2022);

                        return BoxedInt32One;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(94, 1902, 2073);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(94, 1902, 2073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 2049, 2058);

                        return i;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(94, 1902, 2073);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 1846, 2084);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 1846, 2084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 1846, 2084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object Box(uint u)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 2096, 2200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 2153, 2189);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 2160, 2166) || ((u == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(94, 2169, 2184)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 2187, 2188))) ? BoxedUInt32Zero : u;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 2096, 2200);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 2096, 2200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 2096, 2200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object Box(long l)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 2212, 2315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 2269, 2304);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 2276, 2282) || ((l == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(94, 2285, 2299)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 2302, 2303))) ? BoxedInt64Zero : l;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 2212, 2315);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 2212, 2315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 2212, 2315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object Box(ulong ul)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 2327, 2435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 2386, 2424);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 2393, 2400) || ((ul == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(94, 2403, 2418)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 2421, 2423))) ? BoxedUInt64Zero : ul;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 2327, 2435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 2327, 2435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 2327, 2435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static unsafe object Box(float f)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 2447, 2717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 2660, 2706);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 2667, 2683) || ((*(int*)(&f) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(94, 2686, 2701)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 2704, 2705))) ? BoxedSingleZero : f;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 2447, 2717);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 2447, 2717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 2447, 2717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object Box(double d)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 2729, 3015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 2936, 3004);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 2943, 2981) || ((f_94_2943_2976(d) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(94, 2984, 2999)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 3002, 3003))) ? BoxedDoubleZero : d;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 2729, 3015);

                long
                f_94_2943_2976(double
                value)
                {
                    var return_v = BitConverter.DoubleToInt64Bits(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(94, 2943, 2976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 2729, 3015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 2729, 3015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static object Box(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 3027, 3201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 3084, 3190);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 3091, 3098) || ((c < 128
                && DynAbs.Tracing.TraceSender.Conditional_F2(94, 3118, 3168)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 3188, 3189))) ? s_boxedAsciiChars[c] ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(94, 3118, 3168) ?? (s_boxedAsciiChars[c] = c)
                ) : c;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 3027, 3201);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 3027, 3201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 3027, 3201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static unsafe object Box(decimal d)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(94, 3213, 3532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 3426, 3450);

                ulong*
                ptr = (ulong*)&d
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 3464, 3521);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(94, 3471, 3497) || ((ptr[0] == 0 && (DynAbs.Tracing.TraceSender.Expression_True(94, 3471, 3497) && ptr[1] == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(94, 3500, 3516)) || DynAbs.Tracing.TraceSender.Conditional_F3(94, 3519, 3520))) ? BoxedDecimalZero : d;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(94, 3213, 3532);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(94, 3213, 3532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 3213, 3532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Boxes()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(94, 266, 3539);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 340, 356);
            BoxedTrue = true; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 397, 415);
            BoxedFalse = false; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 456, 479);
            BoxedByteZero = (byte)0; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 520, 545);
            BoxedSByteZero = (sbyte)0; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 586, 611);
            BoxedInt16Zero = (short)0; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 652, 679);
            BoxedUInt16Zero = (ushort)0; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 720, 738);
            BoxedInt32Zero = 0; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 779, 796);
            BoxedInt32One = 1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 837, 857);
            BoxedUInt32Zero = 0U; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 898, 917);
            BoxedInt64Zero = 0L; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 958, 979);
            BoxedUInt64Zero = 0UL; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1020, 1042);
            BoxedSingleZero = 0.0f; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1083, 1104);
            BoxedDoubleZero = 0.0; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1145, 1166);
            BoxedDecimalZero = 0m; DynAbs.Tracing.TraceSender.TraceSimpleStatement(94, 1213, 1249);
            s_boxedAsciiChars = new object?[128]; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(94, 266, 3539);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(94, 266, 3539);
        }

    }
}
