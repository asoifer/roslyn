// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Roslyn.Utilities
{
    internal sealed class WeakList<T> : IEnumerable<T>
            where T : class
    {
        private WeakReference<T>[] _items;

        private int _size;

        public WeakList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(396, 587, 681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 540, 546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 569, 574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 629, 670);

                _items = f_396_638_669();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(396, 587, 681);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 587, 681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 587, 681);
            }
        }

        private void Resize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 693, 2703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 739, 776);

                f_396_739_775(_size == f_396_761_774(_items));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 790, 863);

                f_396_790_862(f_396_803_816(_items) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(396, 803, 861) || f_396_825_838(_items) >= MinimalNonEmptySize));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 879, 905);

                int
                alive = f_396_891_904(_items)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 919, 938);

                int
                firstDead = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 961, 966);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 952, 1272) || true) && (i < f_396_972_985(_items))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 987, 990)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(396, 952, 1272))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 952, 1272);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 1024, 1257) || true) && (!f_396_1029_1058(_items[i], out _))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 1024, 1257);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 1100, 1206) || true) && (firstDead == -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 1100, 1206);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 1169, 1183);

                                firstDead = i;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(396, 1100, 1206);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 1230, 1238);

                            alive--;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(396, 1024, 1257);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(396, 1, 321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(396, 1, 321);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 1288, 2563) || true) && (alive < f_396_1300_1313(_items) / 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 1288, 2563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 1540, 1565);

                    f_396_1540_1564(this, firstDead, alive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(396, 1288, 2563);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 1288, 2563);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 1599, 2563) || true) && (alive >= 3 * f_396_1616_1629(_items) / 4)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 1599, 2563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 1885, 1953);

                        var
                        newItems = new WeakReference<T>[f_396_1921_1951(f_396_1937_1950(_items))]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 1973, 2272) || true) && (firstDead >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 1973, 2272);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 2033, 2062);

                            f_396_2033_2061(this, firstDead, newItems);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(396, 1973, 2272);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 1973, 2272);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 2144, 2194);

                            f_396_2144_2193(_items, 0, newItems, 0, f_396_2179_2192(_items));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 2216, 2253);

                            f_396_2216_2252(_size == f_396_2238_2251(_items));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(396, 1973, 2272);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 2292, 2310);

                        _items = newItems;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(396, 1599, 2563);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 1599, 2563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 2521, 2548);

                        f_396_2521_2547(this, firstDead, _items);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(396, 1599, 2563);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(396, 1288, 2563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 2579, 2692);

                f_396_2579_2691(f_396_2592_2605(_items) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(396, 2592, 2642) && _size < 3 * f_396_2625_2638(_items) / 4), "length: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_396_2657_2670(_items)).ToString(), 396, 2657, 2670) + " size: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_size).ToString(), 396, 2685, 2690));
                DynAbs.Tracing.TraceSender.TraceExitMethod(396, 693, 2703);

                int
                f_396_761_774(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 761, 774);
                    return return_v;
                }


                int
                f_396_739_775(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 739, 775);
                    return 0;
                }


                int
                f_396_803_816(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 803, 816);
                    return return_v;
                }


                int
                f_396_825_838(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 825, 838);
                    return return_v;
                }


                int
                f_396_790_862(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 790, 862);
                    return 0;
                }


                int
                f_396_891_904(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 891, 904);
                    return return_v;
                }


                int
                f_396_972_985(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 972, 985);
                    return return_v;
                }


                bool
                f_396_1029_1058(System.WeakReference<T>
                this_param, out T
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 1029, 1058);
                    return return_v;
                }


                int
                f_396_1300_1313(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 1300, 1313);
                    return return_v;
                }


                int
                f_396_1540_1564(Roslyn.Utilities.WeakList<T>
                this_param, int
                firstDead, int
                alive)
                {
                    this_param.Shrink(firstDead, alive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 1540, 1564);
                    return 0;
                }


                int
                f_396_1616_1629(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 1616, 1629);
                    return return_v;
                }


                int
                f_396_1937_1950(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 1937, 1950);
                    return return_v;
                }


                int
                f_396_1921_1951(int
                baseSize)
                {
                    var return_v = GetExpandedSize(baseSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 1921, 1951);
                    return return_v;
                }


                int
                f_396_2033_2061(Roslyn.Utilities.WeakList<T>
                this_param, int
                firstDead, System.WeakReference<T>[]
                result)
                {
                    this_param.Compact(firstDead, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 2033, 2061);
                    return 0;
                }


                int
                f_396_2179_2192(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 2179, 2192);
                    return return_v;
                }


                int
                f_396_2144_2193(System.WeakReference<T>[]
                sourceArray, int
                sourceIndex, System.WeakReference<T>[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 2144, 2193);
                    return 0;
                }


                int
                f_396_2238_2251(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 2238, 2251);
                    return return_v;
                }


                int
                f_396_2216_2252(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 2216, 2252);
                    return 0;
                }


                int
                f_396_2521_2547(Roslyn.Utilities.WeakList<T>
                this_param, int
                firstDead, System.WeakReference<T>[]
                result)
                {
                    this_param.Compact(firstDead, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 2521, 2547);
                    return 0;
                }


                int
                f_396_2592_2605(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 2592, 2605);
                    return return_v;
                }


                int
                f_396_2625_2638(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 2625, 2638);
                    return return_v;
                }


                int
                f_396_2657_2670(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 2657, 2670);
                    return return_v;
                }


                int
                f_396_2579_2691(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 2579, 2691);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 693, 2703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 693, 2703);
            }
        }

        private void Shrink(int firstDead, int alive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 2715, 3005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 2785, 2822);

                int
                newSize = f_396_2799_2821(alive)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 2836, 2919);

                var
                newItems = (DynAbs.Tracing.TraceSender.Conditional_F1(396, 2851, 2877) || (((newSize == f_396_2863_2876(_items)) && DynAbs.Tracing.TraceSender.Conditional_F2(396, 2880, 2886)) || DynAbs.Tracing.TraceSender.Conditional_F3(396, 2889, 2918))) ? _items : new WeakReference<T>[newSize]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 2933, 2962);

                f_396_2933_2961(this, firstDead, newItems);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 2976, 2994);

                _items = newItems;
                DynAbs.Tracing.TraceSender.TraceExitMethod(396, 2715, 3005);

                int
                f_396_2799_2821(int
                baseSize)
                {
                    var return_v = GetExpandedSize(baseSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 2799, 2821);
                    return return_v;
                }


                int
                f_396_2863_2876(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 2863, 2876);
                    return return_v;
                }


                int
                f_396_2933_2961(Roslyn.Utilities.WeakList<T>
                this_param, int
                firstDead, System.WeakReference<T>[]
                result)
                {
                    this_param.Compact(firstDead, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 2933, 2961);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 2715, 3005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 2715, 3005);
            }
        }

        private const int
        MinimalNonEmptySize = 4
        ;

        private static int GetExpandedSize(int baseSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(396, 3071, 3212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3144, 3201);

                return f_396_3151_3200((baseSize * 2) + 1, MinimalNonEmptySize);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(396, 3071, 3212);

                int
                f_396_3151_3200(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 3151, 3200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 3071, 3212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 3071, 3212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Copies all live references from <see cref="_items"/> to <paramref name="result"/>.
        /// Assumes that all references prior <paramref name="firstDead"/> are alive.
        /// </summary>
        private void Compact(int firstDead, WeakReference<T>[] result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 3454, 4323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3541, 3582);

                f_396_3541_3581(f_396_3554_3580(_items[firstDead]));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3598, 3727) || true) && (!f_396_3603_3634(_items, result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 3598, 3727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3668, 3712);

                    f_396_3668_3711(_items, 0, result, 0, firstDead);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(396, 3598, 3727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3743, 3763);

                int
                oldSize = _size
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3777, 3795);

                int
                j = firstDead
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3818, 3835);
                    for (int
        i = firstDead + 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3809, 4051) || true) && (i < oldSize)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3850, 3853)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(396, 3809, 4051))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 3809, 4051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3887, 3908);

                        var
                        item = _items[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3928, 4036) || true) && (f_396_3932_3956(item, out _))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 3928, 4036);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3998, 4017);

                            result[j++] = item;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(396, 3928, 4036);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(396, 1, 243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(396, 1, 243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4067, 4077);

                _size = j;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4129, 4312) || true) && (f_396_4133_4164(_items, result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 4129, 4312);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4198, 4297) || true) && (j < oldSize)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 4198, 4297);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4258, 4278);

                            _items[j++] = null!;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(396, 4198, 4297);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(396, 4198, 4297);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(396, 4198, 4297);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(396, 4129, 4312);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(396, 3454, 4323);

                bool
                f_396_3554_3580(System.WeakReference<T>
                reference)
                {
                    var return_v = reference.IsNull<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 3554, 3580);
                    return return_v;
                }


                int
                f_396_3541_3581(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 3541, 3581);
                    return 0;
                }


                bool
                f_396_3603_3634(System.WeakReference<T>[]
                objA, System.WeakReference<T>[]
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 3603, 3634);
                    return return_v;
                }


                int
                f_396_3668_3711(System.WeakReference<T>[]
                sourceArray, int
                sourceIndex, System.WeakReference<T>[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 3668, 3711);
                    return 0;
                }


                bool
                f_396_3932_3956(System.WeakReference<T>
                this_param, out T
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 3932, 3956);
                    return return_v;
                }


                bool
                f_396_4133_4164(System.WeakReference<T>[]
                objA, System.WeakReference<T>[]
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 4133, 4164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 3454, 4323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 3454, 4323);
            }
        }

        public int WeakCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 4570, 4591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4576, 4589);

                    return _size;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(396, 4570, 4591);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 4525, 4602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 4525, 4602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public WeakReference<T> GetWeakReference(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 4614, 4871);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4690, 4823) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(396, 4694, 4721) || index >= _size))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 4690, 4823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4755, 4808);

                    throw f_396_4761_4807(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(396, 4690, 4823);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4839, 4860);

                return _items[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(396, 4614, 4871);

                System.ArgumentOutOfRangeException
                f_396_4761_4807(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 4761, 4807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 4614, 4871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 4614, 4871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Add(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 4883, 5137);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4931, 5015) || true) && (_size == f_396_4944_4957(_items))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 4931, 5015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 4991, 5000);

                    f_396_4991_4999(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(396, 4931, 5015);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5031, 5067);

                f_396_5031_5066(_size < f_396_5052_5065(_items));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5081, 5126);

                _items[_size++] = f_396_5099_5125(item);
                DynAbs.Tracing.TraceSender.TraceExitMethod(396, 4883, 5137);

                int
                f_396_4944_4957(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 4944, 4957);
                    return return_v;
                }


                int
                f_396_4991_4999(Roslyn.Utilities.WeakList<T>
                this_param)
                {
                    this_param.Resize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 4991, 4999);
                    return 0;
                }


                int
                f_396_5052_5065(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 5052, 5065);
                    return return_v;
                }


                int
                f_396_5031_5066(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 5031, 5066);
                    return 0;
                }


                System.WeakReference<T>
                f_396_5099_5125(T
                target)
                {
                    var return_v = new System.WeakReference<T>(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 5099, 5125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 4883, 5137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 4883, 5137);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 5149, 6156);

                var listYield = new List<T>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5211, 5229);

                int
                count = _size
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5243, 5261);

                int
                alive = _size
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5275, 5294);

                int
                firstDead = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5319, 5324);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5310, 5801) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5337, 5340)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(396, 5310, 5801))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 5310, 5801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5374, 5382);

                        T?
                        item
                        = default(T?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5400, 5786) || true) && (f_396_5404_5436(_items[i], out item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 5400, 5786);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5478, 5496);

                            listYield.Add(item);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(396, 5400, 5786);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 5400, 5786);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5631, 5735) || true) && (firstDead < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 5631, 5735);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5698, 5712);

                                firstDead = i;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(396, 5631, 5735);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5759, 5767);

                            alive--;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(396, 5400, 5786);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(396, 1, 492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(396, 1, 492);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5817, 6145) || true) && (alive == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 5817, 6145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5865, 5906);

                    _items = f_396_5874_5905();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5924, 5934);

                    _size = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(396, 5817, 6145);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 5817, 6145);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 5968, 6145) || true) && (alive < f_396_5980_5993(_items) / 4)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(396, 5968, 6145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 6105, 6130);

                        f_396_6105_6129(this, firstDead, alive);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(396, 5968, 6145);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(396, 5817, 6145);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(396, 5149, 6156);

                return listYield.GetEnumerator();

                bool
                f_396_5404_5436(System.WeakReference<T>
                this_param, out T?
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 5404, 5436);
                    return return_v;
                }


                System.WeakReference<T>[]
                f_396_5874_5905()
                {
                    var return_v = Array.Empty<WeakReference<T>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 5874, 5905);
                    return return_v;
                }


                int
                f_396_5980_5993(System.WeakReference<T>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(396, 5980, 5993);
                    return return_v;
                }


                int
                f_396_6105_6129(Roslyn.Utilities.WeakList<T>
                this_param, int
                firstDead, int
                alive)
                {
                    this_param.Shrink(firstDead, alive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 6105, 6129);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 5149, 6156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 5149, 6156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 6168, 6304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 6270, 6293);

                return f_396_6277_6292(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(396, 6168, 6304);

                System.Collections.Generic.IEnumerator<T>
                f_396_6277_6292(Roslyn.Utilities.WeakList<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 6277, 6292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 6168, 6304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 6168, 6304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal WeakReference<T>[] TestOnly_UnderlyingArray
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(396, 6371, 6393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 6377, 6391);

                    return _items;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(396, 6371, 6393);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(396, 6316, 6395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 6316, 6395);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static WeakList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(396, 421, 6402);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(396, 3035, 3058);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(396, 421, 6402);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(396, 421, 6402);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(396, 421, 6402);

        static System.WeakReference<T>[]
        f_396_638_669()
        {
            var return_v = Array.Empty<WeakReference<T>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(396, 638, 669);
            return return_v;
        }

    }
}
