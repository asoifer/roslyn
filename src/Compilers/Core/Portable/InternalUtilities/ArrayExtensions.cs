// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Roslyn.Utilities
{
    internal static class ArrayExtensions
    {
        internal static T[] Copy<T>(this T[] array, int start, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 341, 909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 560, 585);

                f_307_560_584(start >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 599, 635);

                f_307_599_634(start <= f_307_621_633(array));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 651, 763) || true) && (start + length > f_307_672_684(array))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 651, 763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 718, 748);

                    length = f_307_727_739(array) - start;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(307, 651, 763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 779, 808);

                T[]
                newArray = new T[length]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 822, 868);

                f_307_822_867(array, start, newArray, 0, length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 882, 898);

                return newArray;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 341, 909);

                int
                f_307_560_584(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 560, 584);
                    return 0;
                }


                int
                f_307_621_633(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 621, 633);
                    return return_v;
                }


                int
                f_307_599_634(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 599, 634);
                    return 0;
                }


                int
                f_307_672_684(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 672, 684);
                    return return_v;
                }


                int
                f_307_727_739(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 727, 739);
                    return return_v;
                }


                int
                f_307_822_867(T[]
                sourceArray, int
                sourceIndex, T[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 822, 867);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 341, 909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 341, 909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] InsertAt<T>(this T[] array, int position, T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 921, 1423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1015, 1054);

                T[]
                newArray = new T[f_307_1036_1048(array) + 1]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1068, 1171) || true) && (position > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 1068, 1171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1118, 1156);

                    f_307_1118_1155(array, newArray, position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(307, 1068, 1171);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1187, 1340) || true) && (position < f_307_1202_1214(array))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 1187, 1340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1248, 1325);

                    f_307_1248_1324(array, position, newArray, position + 1, f_307_1300_1312(array) - position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(307, 1187, 1340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1356, 1382);

                newArray[position] = item;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1396, 1412);

                return newArray;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 921, 1423);

                int
                f_307_1036_1048(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 1036, 1048);
                    return return_v;
                }


                int
                f_307_1118_1155(T[]
                sourceArray, T[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 1118, 1155);
                    return 0;
                }


                int
                f_307_1202_1214(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 1202, 1214);
                    return return_v;
                }


                int
                f_307_1300_1312(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 1300, 1312);
                    return return_v;
                }


                int
                f_307_1248_1324(T[]
                sourceArray, int
                sourceIndex, T[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 1248, 1324);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 921, 1423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 921, 1423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] Append<T>(this T[] array, T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 1435, 1567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1513, 1556);

                return f_307_1520_1555(array, f_307_1536_1548(array), item);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 1435, 1567);

                int
                f_307_1536_1548(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 1536, 1548);
                    return return_v;
                }


                T[]
                f_307_1520_1555(T[]
                array, int
                position, T?
                item)
                {
                    var return_v = array.InsertAt<T>(position, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 1520, 1555);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 1435, 1567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 1435, 1567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] InsertAt<T>(this T[] array, int position, T[] items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 1579, 2113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1676, 1726);

                T[]
                newArray = new T[f_307_1697_1709(array) + f_307_1712_1724(items)]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1740, 1843) || true) && (position > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 1740, 1843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1790, 1828);

                    f_307_1790_1827(array, newArray, position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(307, 1740, 1843);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1859, 2023) || true) && (position < f_307_1874_1886(array))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 1859, 2023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 1920, 2008);

                    f_307_1920_2007(array, position, newArray, position + f_307_1969_1981(items), f_307_1983_1995(array) - position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(307, 1859, 2023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2039, 2072);

                f_307_2039_2071(
                            items, newArray, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2086, 2102);

                return newArray;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 1579, 2113);

                int
                f_307_1697_1709(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 1697, 1709);
                    return return_v;
                }


                int
                f_307_1712_1724(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 1712, 1724);
                    return return_v;
                }


                int
                f_307_1790_1827(T[]
                sourceArray, T[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 1790, 1827);
                    return 0;
                }


                int
                f_307_1874_1886(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 1874, 1886);
                    return return_v;
                }


                int
                f_307_1969_1981(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 1969, 1981);
                    return return_v;
                }


                int
                f_307_1983_1995(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 1983, 1995);
                    return return_v;
                }


                int
                f_307_1920_2007(T[]
                sourceArray, int
                sourceIndex, T[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 1920, 2007);
                    return 0;
                }


                int
                f_307_2039_2071(T[]
                this_param, T[]
                array, int
                index)
                {
                    this_param.CopyTo((System.Array)array, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 2039, 2071);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 1579, 2113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 1579, 2113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] Append<T>(this T[] array, T[] items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 2125, 2261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2206, 2250);

                return f_307_2213_2249(array, f_307_2229_2241(array), items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 2125, 2261);

                int
                f_307_2229_2241(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 2229, 2241);
                    return return_v;
                }


                T[]
                f_307_2213_2249(T[]
                array, int
                position, T[]
                items)
                {
                    var return_v = array.InsertAt<T>(position, items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 2213, 2249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 2125, 2261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 2125, 2261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] RemoveAt<T>(this T[] array, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 2273, 2406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2359, 2395);

                return f_307_2366_2394(array, position, 1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 2273, 2406);

                T[]
                f_307_2366_2394(T[]
                array, int
                position, int
                length)
                {
                    var return_v = array.RemoveAt<T>(position, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 2366, 2394);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 2273, 2406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 2273, 2406);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] RemoveAt<T>(this T[] array, int position, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 2418, 3034);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2516, 2634) || true) && (position + length > f_307_2540_2552(array))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 2516, 2634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2586, 2619);

                    length = f_307_2595_2607(array) - position;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(307, 2516, 2634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2650, 2694);

                T[]
                newArray = new T[f_307_2671_2683(array) - length]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2708, 2811) || true) && (position > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 2708, 2811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2758, 2796);

                    f_307_2758_2795(array, newArray, position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(307, 2708, 2811);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2827, 2991) || true) && (position < f_307_2842_2857(newArray))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 2827, 2991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 2891, 2976);

                    f_307_2891_2975(array, position + length, newArray, position, f_307_2948_2963(newArray) - position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(307, 2827, 2991);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3007, 3023);

                return newArray;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 2418, 3034);

                int
                f_307_2540_2552(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 2540, 2552);
                    return return_v;
                }


                int
                f_307_2595_2607(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 2595, 2607);
                    return return_v;
                }


                int
                f_307_2671_2683(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 2671, 2683);
                    return return_v;
                }


                int
                f_307_2758_2795(T[]
                sourceArray, T[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 2758, 2795);
                    return 0;
                }


                int
                f_307_2842_2857(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 2842, 2857);
                    return return_v;
                }


                int
                f_307_2948_2963(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 2948, 2963);
                    return return_v;
                }


                int
                f_307_2891_2975(T[]
                sourceArray, int
                sourceIndex, T[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 2891, 2975);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 2418, 3034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 2418, 3034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] ReplaceAt<T>(this T[] array, int position, T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 3046, 3313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3141, 3176);

                T[]
                newArray = new T[f_307_3162_3174(array)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3190, 3232);

                f_307_3190_3231(array, newArray, f_307_3218_3230(array));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3246, 3272);

                newArray[position] = item;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3286, 3302);

                return newArray;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 3046, 3313);

                int
                f_307_3162_3174(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 3162, 3174);
                    return return_v;
                }


                int
                f_307_3218_3230(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 3218, 3230);
                    return return_v;
                }


                int
                f_307_3190_3231(T[]
                sourceArray, T[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 3190, 3231);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 3046, 3313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 3046, 3313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] ReplaceAt<T>(this T[] array, int position, int length, T[] items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 3325, 3514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3435, 3503);

                return f_307_3442_3502(f_307_3451_3484(array, position, length), position, items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 3325, 3514);

                T[]
                f_307_3451_3484(T[]
                array, int
                position, int
                length)
                {
                    var return_v = array.RemoveAt<T>(position, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 3451, 3484);
                    return return_v;
                }


                T[]
                f_307_3442_3502(T[]
                array, int
                position, T[]
                items)
                {
                    var return_v = array.InsertAt<T>(position, items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 3442, 3502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 3325, 3514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 3325, 3514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ReverseContents<T>(this T[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 3526, 3657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3606, 3646);

                f_307_3606_3645(array, 0, f_307_3632_3644(array));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 3526, 3657);

                int
                f_307_3632_3644(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 3632, 3644);
                    return return_v;
                }


                int
                f_307_3606_3645(T[]
                array, int
                start, int
                count)
                {
                    array.ReverseContents<T>(start, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(307, 3606, 3645);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 3526, 3657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 3526, 3657);
            }
        }

        internal static void ReverseContents<T>(this T[] array, int start, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 3669, 4005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3771, 3799);

                int
                end = start + count - 1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3822, 3831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3833, 3840);
                    for (int
        i = start
        ,
        j = end
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3813, 3994) || true) && (i < j)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3849, 3852)
        , i++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3854, 3857)
        , j--, DynAbs.Tracing.TraceSender.TraceExitCondition(307, 3813, 3994))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 3813, 3994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3891, 3908);

                        T
                        tmp = array[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3926, 3946);

                        array[i] = array[j];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 3964, 3979);

                        array[j] = tmp;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(307, 1, 182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(307, 1, 182);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 3669, 4005);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 3669, 4005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 3669, 4005);
            }
        }

        internal static int BinarySearch(this int[] array, int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 4101, 4786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4187, 4199);

                var
                low = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4213, 4241);

                var
                high = f_307_4224_4236(array) - 1
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4257, 4747) || true) && (low <= high)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 4257, 4747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4309, 4348);

                        var
                        middle = low + ((high - low) >> 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4366, 4395);

                        var
                        midValue = array[middle]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4415, 4732) || true) && (midValue == value)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 4415, 4732);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4478, 4492);

                            return middle;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(307, 4415, 4732);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 4415, 4732);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4534, 4732) || true) && (midValue > value)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 4534, 4732);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4596, 4614);

                                high = middle - 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(307, 4534, 4732);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 4534, 4732);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4696, 4713);

                                low = middle + 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(307, 4534, 4732);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(307, 4415, 4732);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(307, 4257, 4747);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(307, 4257, 4747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(307, 4257, 4747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 4763, 4775);

                return ~low;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 4101, 4786);

                int
                f_307_4224_4236(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 4224, 4236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 4101, 4786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 4101, 4786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int BinarySearchUpperBound(this int[] array, int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(307, 5524, 6055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 5620, 5632);

                int
                low = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 5646, 5674);

                int
                high = f_307_5657_5669(array) - 1
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 5690, 6017) || true) && (low <= high)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 5690, 6017);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 5742, 5781);

                        int
                        middle = low + ((high - low) >> 1)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 5799, 6002) || true) && (array[middle] > value)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 5799, 6002);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 5866, 5884);

                            high = middle - 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(307, 5799, 6002);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(307, 5799, 6002);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 5966, 5983);

                            low = middle + 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(307, 5799, 6002);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(307, 5690, 6017);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(307, 5690, 6017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(307, 5690, 6017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(307, 6033, 6044);

                return low;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(307, 5524, 6055);

                int
                f_307_5657_5669(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(307, 5657, 5669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(307, 5524, 6055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 5524, 6055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ArrayExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(307, 287, 6062);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(307, 287, 6062);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(307, 287, 6062);
        }

    }
}
