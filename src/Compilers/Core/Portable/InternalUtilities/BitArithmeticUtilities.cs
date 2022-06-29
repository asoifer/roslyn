// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Roslyn.Utilities
{
    internal static class BitArithmeticUtilities
    {
        public static int CountBits(int v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(309, 333, 440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 392, 429);

                return f_309_399_428(unchecked(v));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(309, 333, 440);

                int
                f_309_399_428(int
                v)
                {
                    var return_v = CountBits((uint)v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(309, 399, 428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(309, 333, 440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(309, 333, 440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int CountBits(uint v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(309, 452, 756);
                unchecked
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 554, 584);

                    v -= ((v >> 1) & 0x55555555u);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 602, 651);

                    v = (v & 0x33333333u) + ((v >> 2) & 0x33333333u);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 669, 730);

                    return (int)((v + (v >> 4) & 0xF0F0F0Fu) * 0x1010101u) >> 24;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(309, 452, 756);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(309, 452, 756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(309, 452, 756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int CountBits(long v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(309, 768, 877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 828, 866);

                return f_309_835_865(unchecked(v));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(309, 768, 877);

                int
                f_309_835_865(long
                v)
                {
                    var return_v = CountBits((ulong)v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(309, 835, 865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(309, 768, 877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(309, 768, 877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int CountBits(ulong v)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(309, 889, 2294);
                unchecked
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 992, 1065);

                    const ulong
                    MASK_01010101010101010101010101010101 = 0x5555555555555555UL
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 1083, 1156);

                    const ulong
                    MASK_00110011001100110011001100110011 = 0x3333333333333333UL
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 1174, 1247);

                    const ulong
                    MASK_00001111000011110000111100001111 = 0x0F0F0F0F0F0F0F0FUL
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 1265, 1338);

                    const ulong
                    MASK_00000000111111110000000011111111 = 0x00FF00FF00FF00FFUL
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 1356, 1429);

                    const ulong
                    MASK_00000000000000001111111111111111 = 0x0000FFFF0000FFFFUL
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 1447, 1520);

                    const ulong
                    MASK_11111111111111111111111111111111 = 0x00000000FFFFFFFFUL
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 1538, 1639);

                    v = (v & MASK_01010101010101010101010101010101) + ((v >> 1) & MASK_01010101010101010101010101010101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 1657, 1758);

                    v = (v & MASK_00110011001100110011001100110011) + ((v >> 2) & MASK_00110011001100110011001100110011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 1776, 1877);

                    v = (v & MASK_00001111000011110000111100001111) + ((v >> 4) & MASK_00001111000011110000111100001111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 1895, 1996);

                    v = (v & MASK_00000000111111110000000011111111) + ((v >> 8) & MASK_00000000111111110000000011111111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2014, 2116);

                    v = (v & MASK_00000000000000001111111111111111) + ((v >> 16) & MASK_00000000000000001111111111111111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2134, 2236);

                    v = (v & MASK_11111111111111111111111111111111) + ((v >> 32) & MASK_11111111111111111111111111111111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2254, 2268);

                    return (int)v;
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(309, 889, 2294);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(309, 889, 2294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(309, 889, 2294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static uint Align(uint position, uint alignment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(309, 2306, 2638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2388, 2428);

                f_309_2388_2427(f_309_2401_2421(alignment) == 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2444, 2486);

                uint
                result = position & ~(alignment - 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2500, 2585) || true) && (result == position)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(309, 2500, 2585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2556, 2570);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(309, 2500, 2585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2601, 2627);

                return result + alignment;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(309, 2306, 2638);

                int
                f_309_2401_2421(uint
                v)
                {
                    var return_v = CountBits(v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(309, 2401, 2421);
                    return return_v;
                }


                int
                f_309_2388_2427(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(309, 2388, 2427);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(309, 2306, 2638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(309, 2306, 2638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int Align(int position, int alignment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(309, 2650, 3037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2729, 2774);

                f_309_2729_2773(position >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(309, 2742, 2772) && alignment > 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2788, 2828);

                f_309_2788_2827(f_309_2801_2821(alignment) == 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2844, 2885);

                int
                result = position & ~(alignment - 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2899, 2984) || true) && (result == position)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(309, 2899, 2984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 2955, 2969);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(309, 2899, 2984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(309, 3000, 3026);

                return result + alignment;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(309, 2650, 3037);

                int
                f_309_2729_2773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(309, 2729, 2773);
                    return 0;
                }


                int
                f_309_2801_2821(int
                v)
                {
                    var return_v = CountBits(v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(309, 2801, 2821);
                    return return_v;
                }


                int
                f_309_2788_2827(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(309, 2788, 2827);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(309, 2650, 3037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(309, 2650, 3037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BitArithmeticUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(309, 272, 3044);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(309, 272, 3044);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(309, 272, 3044);
        }

    }
}
