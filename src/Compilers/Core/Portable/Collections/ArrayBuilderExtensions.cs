// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis
{
    internal static class ArrayBuilderExtensions
    {
        public static bool Any<T>(this ArrayBuilder<T> builder, Func<T, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 449, 761);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 554, 723);
                    foreach (var item in f_91_575_582_I(builder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 554, 723);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 616, 708) || true) && (f_91_620_635(predicate, item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 616, 708);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 677, 689);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(91, 616, 708);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 554, 723);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(91, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(91, 1, 170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 737, 750);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 449, 761);

                bool
                f_91_620_635(System.Func<T, bool>
                this_param, T?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 620, 635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_91_575_582_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 575, 582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 449, 761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 449, 761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Any<T, A>(this ArrayBuilder<T> builder, Func<T, A, bool> predicate, A arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 773, 1103);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 891, 1065);
                    foreach (var item in f_91_912_919_I(builder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 891, 1065);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 953, 1050) || true) && (f_91_957_977(predicate, item, arg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 953, 1050);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 1019, 1031);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(91, 953, 1050);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 891, 1065);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(91, 1, 175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(91, 1, 175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 1079, 1092);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 773, 1103);

                bool
                f_91_957_977(System.Func<T, A, bool>
                this_param, T?
                arg1, A?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 957, 977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_91_912_919_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 912, 919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 773, 1103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 773, 1103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool All<T>(this ArrayBuilder<T> builder, Func<T, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 1115, 1428);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 1220, 1391);
                    foreach (var item in f_91_1241_1248_I(builder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 1220, 1391);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 1282, 1376) || true) && (!f_91_1287_1302(predicate, item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 1282, 1376);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 1344, 1357);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(91, 1282, 1376);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 1220, 1391);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(91, 1, 172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(91, 1, 172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 1405, 1417);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 1115, 1428);

                bool
                f_91_1287_1302(System.Func<T, bool>
                this_param, T?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 1287, 1302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_91_1241_1248_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 1241, 1248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 1115, 1428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 1115, 1428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool All<T, A>(this ArrayBuilder<T> builder, Func<T, A, bool> predicate, A arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 1440, 1771);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 1558, 1734);
                    foreach (var item in f_91_1579_1586_I(builder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 1558, 1734);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 1620, 1719) || true) && (!f_91_1625_1645(predicate, item, arg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 1620, 1719);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 1687, 1700);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(91, 1620, 1719);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 1558, 1734);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(91, 1, 177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(91, 1, 177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 1748, 1760);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 1440, 1771);

                bool
                f_91_1625_1645(System.Func<T, A, bool>
                this_param, T?
                arg1, A?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 1625, 1645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_91_1579_1586_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 1579, 1586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 1440, 1771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 1440, 1771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<TResult> SelectAsArray<TItem, TResult>(this ArrayBuilder<TItem> items, Func<TItem, TResult> map)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 2207, 3279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 2357, 3268);

                switch (f_91_2365_2376(items))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 2357, 3268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 2439, 2476);

                        return ImmutableArray<TResult>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 2357, 3268);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 2357, 3268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 2525, 2569);

                        return f_91_2532_2568(f_91_2554_2567(map, f_91_2558_2566(items, 0)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 2357, 3268);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 2357, 3268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 2618, 2677);

                        return f_91_2625_2676(f_91_2647_2660(map, f_91_2651_2659(items, 0)), f_91_2662_2675(map, f_91_2666_2674(items, 1)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 2357, 3268);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 2357, 3268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 2726, 2800);

                        return f_91_2733_2799(f_91_2755_2768(map, f_91_2759_2767(items, 0)), f_91_2770_2783(map, f_91_2774_2782(items, 1)), f_91_2785_2798(map, f_91_2789_2797(items, 2)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 2357, 3268);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 2357, 3268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 2849, 2938);

                        return f_91_2856_2937(f_91_2878_2891(map, f_91_2882_2890(items, 0)), f_91_2893_2906(map, f_91_2897_2905(items, 1)), f_91_2908_2921(map, f_91_2912_2920(items, 2)), f_91_2923_2936(map, f_91_2927_2935(items, 3)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 2357, 3268);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 2357, 3268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 2988, 3049);

                        var
                        builder = f_91_3002_3048(f_91_3036_3047(items))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 3071, 3193);
                            foreach (var item in f_91_3092_3097_I(items))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 3071, 3193);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 3147, 3170);

                                f_91_3147_3169(builder, f_91_3159_3168(map, item));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(91, 3071, 3193);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(91, 1, 123);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(91, 1, 123);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 3217, 3253);

                        return f_91_3224_3252(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 2357, 3268);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 2207, 3279);

                int
                f_91_2365_2376(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2365, 2376);
                    return return_v;
                }


                TItem?
                f_91_2558_2566(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2558, 2566);
                    return return_v;
                }


                TResult
                f_91_2554_2567(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2554, 2567);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_91_2532_2568(TResult?
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2532, 2568);
                    return return_v;
                }


                TItem?
                f_91_2651_2659(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2651, 2659);
                    return return_v;
                }


                TResult
                f_91_2647_2660(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2647, 2660);
                    return return_v;
                }


                TItem?
                f_91_2666_2674(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2666, 2674);
                    return return_v;
                }


                TResult
                f_91_2662_2675(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2662, 2675);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_91_2625_2676(TResult?
                item1, TResult?
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2625, 2676);
                    return return_v;
                }


                TItem?
                f_91_2759_2767(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2759, 2767);
                    return return_v;
                }


                TResult
                f_91_2755_2768(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2755, 2768);
                    return return_v;
                }


                TItem?
                f_91_2774_2782(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2774, 2782);
                    return return_v;
                }


                TResult
                f_91_2770_2783(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2770, 2783);
                    return return_v;
                }


                TItem?
                f_91_2789_2797(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2789, 2797);
                    return return_v;
                }


                TResult
                f_91_2785_2798(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2785, 2798);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_91_2733_2799(TResult?
                item1, TResult?
                item2, TResult?
                item3)
                {
                    var return_v = ImmutableArray.Create(item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2733, 2799);
                    return return_v;
                }


                TItem?
                f_91_2882_2890(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2882, 2890);
                    return return_v;
                }


                TResult
                f_91_2878_2891(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2878, 2891);
                    return return_v;
                }


                TItem?
                f_91_2897_2905(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2897, 2905);
                    return return_v;
                }


                TResult
                f_91_2893_2906(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2893, 2906);
                    return return_v;
                }


                TItem?
                f_91_2912_2920(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2912, 2920);
                    return return_v;
                }


                TResult
                f_91_2908_2921(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2908, 2921);
                    return return_v;
                }


                TItem?
                f_91_2927_2935(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 2927, 2935);
                    return return_v;
                }


                TResult
                f_91_2923_2936(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2923, 2936);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_91_2856_2937(TResult?
                item1, TResult?
                item2, TResult?
                item3, TResult?
                item4)
                {
                    var return_v = ImmutableArray.Create(item1, item2, item3, item4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 2856, 2937);
                    return return_v;
                }


                int
                f_91_3036_3047(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 3036, 3047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                f_91_3002_3048(int
                capacity)
                {
                    var return_v = ArrayBuilder<TResult>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 3002, 3048);
                    return return_v;
                }


                TResult
                f_91_3159_3168(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 3159, 3168);
                    return return_v;
                }


                int
                f_91_3147_3169(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param, TResult?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 3147, 3169);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                f_91_3092_3097_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 3092, 3097);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_91_3224_3252(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 3224, 3252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 2207, 3279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 2207, 3279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<TResult> SelectAsArray<TItem, TArg, TResult>(this ArrayBuilder<TItem> items, Func<TItem, TArg, TResult> map, TArg arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 3848, 4997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 4020, 4986);

                switch (f_91_4028_4039(items))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 4020, 4986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 4102, 4139);

                        return ImmutableArray<TResult>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 4020, 4986);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 4020, 4986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 4188, 4237);

                        return f_91_4195_4236(f_91_4217_4235(map, f_91_4221_4229(items, 0), arg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 4020, 4986);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 4020, 4986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 4286, 4355);

                        return f_91_4293_4354(f_91_4315_4333(map, f_91_4319_4327(items, 0), arg), f_91_4335_4353(map, f_91_4339_4347(items, 1), arg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 4020, 4986);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 4020, 4986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 4404, 4493);

                        return f_91_4411_4492(f_91_4433_4451(map, f_91_4437_4445(items, 0), arg), f_91_4453_4471(map, f_91_4457_4465(items, 1), arg), f_91_4473_4491(map, f_91_4477_4485(items, 2), arg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 4020, 4986);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 4020, 4986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 4542, 4651);

                        return f_91_4549_4650(f_91_4571_4589(map, f_91_4575_4583(items, 0), arg), f_91_4591_4609(map, f_91_4595_4603(items, 1), arg), f_91_4611_4629(map, f_91_4615_4623(items, 2), arg), f_91_4631_4649(map, f_91_4635_4643(items, 3), arg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 4020, 4986);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 4020, 4986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 4701, 4762);

                        var
                        builder = f_91_4715_4761(f_91_4749_4760(items))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 4784, 4911);
                            foreach (var item in f_91_4805_4810_I(items))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 4784, 4911);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 4860, 4888);

                                f_91_4860_4887(builder, f_91_4872_4886(map, item, arg));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(91, 4784, 4911);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(91, 1, 128);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(91, 1, 128);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 4935, 4971);

                        return f_91_4942_4970(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 4020, 4986);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 3848, 4997);

                int
                f_91_4028_4039(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4028, 4039);
                    return return_v;
                }


                TItem?
                f_91_4221_4229(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4221, 4229);
                    return return_v;
                }


                TResult
                f_91_4217_4235(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4217, 4235);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_91_4195_4236(TResult?
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4195, 4236);
                    return return_v;
                }


                TItem?
                f_91_4319_4327(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4319, 4327);
                    return return_v;
                }


                TResult
                f_91_4315_4333(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4315, 4333);
                    return return_v;
                }


                TItem?
                f_91_4339_4347(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4339, 4347);
                    return return_v;
                }


                TResult
                f_91_4335_4353(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4335, 4353);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_91_4293_4354(TResult?
                item1, TResult?
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4293, 4354);
                    return return_v;
                }


                TItem?
                f_91_4437_4445(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4437, 4445);
                    return return_v;
                }


                TResult
                f_91_4433_4451(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4433, 4451);
                    return return_v;
                }


                TItem?
                f_91_4457_4465(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4457, 4465);
                    return return_v;
                }


                TResult
                f_91_4453_4471(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4453, 4471);
                    return return_v;
                }


                TItem?
                f_91_4477_4485(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4477, 4485);
                    return return_v;
                }


                TResult
                f_91_4473_4491(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4473, 4491);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_91_4411_4492(TResult?
                item1, TResult?
                item2, TResult?
                item3)
                {
                    var return_v = ImmutableArray.Create(item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4411, 4492);
                    return return_v;
                }


                TItem?
                f_91_4575_4583(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4575, 4583);
                    return return_v;
                }


                TResult
                f_91_4571_4589(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4571, 4589);
                    return return_v;
                }


                TItem?
                f_91_4595_4603(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4595, 4603);
                    return return_v;
                }


                TResult
                f_91_4591_4609(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4591, 4609);
                    return return_v;
                }


                TItem?
                f_91_4615_4623(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4615, 4623);
                    return return_v;
                }


                TResult
                f_91_4611_4629(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4611, 4629);
                    return return_v;
                }


                TItem?
                f_91_4635_4643(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4635, 4643);
                    return return_v;
                }


                TResult
                f_91_4631_4649(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4631, 4649);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_91_4549_4650(TResult?
                item1, TResult?
                item2, TResult?
                item3, TResult?
                item4)
                {
                    var return_v = ImmutableArray.Create(item1, item2, item3, item4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4549, 4650);
                    return return_v;
                }


                int
                f_91_4749_4760(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 4749, 4760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                f_91_4715_4761(int
                capacity)
                {
                    var return_v = ArrayBuilder<TResult>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4715, 4761);
                    return return_v;
                }


                TResult
                f_91_4872_4886(System.Func<TItem, TArg, TResult>
                this_param, TItem?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4872, 4886);
                    return return_v;
                }


                int
                f_91_4860_4887(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param, TResult?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4860, 4887);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                f_91_4805_4810_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4805, 4810);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_91_4942_4970(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 4942, 4970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 3848, 4997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 3848, 4997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void AddOptional<T>(this ArrayBuilder<T> builder, T? item)
                    where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 5009, 5229);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 5135, 5218) || true) && (item != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 5135, 5218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 5185, 5203);

                    f_91_5185_5202(builder, item);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(91, 5135, 5218);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 5009, 5229);

                int
                f_91_5185_5202(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 5185, 5202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 5009, 5229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 5009, 5229);
            }
        }

        public static void Push<T>(this ArrayBuilder<T> builder, T e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 5501, 5613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 5587, 5602);

                f_91_5587_5601(builder, e);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 5501, 5613);

                int
                f_91_5587_5601(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 5587, 5601);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 5501, 5613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 5501, 5613);
            }
        }

        public static T Pop<T>(this ArrayBuilder<T> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 5625, 5809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 5702, 5725);

                var
                e = f_91_5710_5724(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 5739, 5775);

                f_91_5739_5774(builder, f_91_5756_5769(builder) - 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 5789, 5798);

                return e;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 5625, 5809);

                T
                f_91_5710_5724(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                builder)
                {
                    var return_v = builder.Peek<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 5710, 5724);
                    return return_v;
                }


                int
                f_91_5756_5769(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 5756, 5769);
                    return return_v;
                }


                int
                f_91_5739_5774(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 5739, 5774);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 5625, 5809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 5625, 5809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryPop<T>(this ArrayBuilder<T> builder, [MaybeNullWhen(false)] out T result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 5821, 6135);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 5941, 6064) || true) && (f_91_5945_5958(builder) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 5941, 6064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 5996, 6019);

                    result = f_91_6005_6018(builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 6037, 6049);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(91, 5941, 6064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 6080, 6097);

                result = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 6111, 6124);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 5821, 6135);

                int
                f_91_5945_5958(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 5945, 5958);
                    return return_v;
                }


                T
                f_91_6005_6018(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                builder)
                {
                    var return_v = builder.Pop<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 6005, 6018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 5821, 6135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 5821, 6135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T Peek<T>(this ArrayBuilder<T> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 6147, 6270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 6225, 6259);

                return f_91_6232_6258(builder, f_91_6240_6253(builder) - 1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 6147, 6270);

                int
                f_91_6240_6253(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 6240, 6253);
                    return return_v;
                }


                T?
                f_91_6232_6258(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(91, 6232, 6258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 6147, 6270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 6147, 6270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> ToImmutableOrEmptyAndFree<T>(this ArrayBuilder<T>? builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 6282, 6473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 6398, 6462);

                return f_91_6405_6434_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(builder, 91, 6405, 6434)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<T>?>(91, 6405, 6461) ?? ImmutableArray<T>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 6282, 6473);

                System.Collections.Immutable.ImmutableArray<T>?
                f_91_6405_6434_I(System.Collections.Immutable.ImmutableArray<T>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 6405, 6434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 6282, 6473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 6282, 6473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void AddIfNotNull<T>(this ArrayBuilder<T> builder, T? value)
                    where T : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 6485, 6716);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 6614, 6705) || true) && (value != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 6614, 6705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 6665, 6690);

                    f_91_6665_6689(builder, value.Value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(91, 6614, 6705);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 6485, 6716);

                int
                f_91_6665_6689(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 6665, 6689);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 6485, 6716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 6485, 6716);
            }
        }

        public static void AddIfNotNull<T>(this ArrayBuilder<T> builder, T? value)
                    where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 6728, 6952);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 6856, 6941) || true) && (value != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 6856, 6941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 6907, 6926);

                    f_91_6907_6925(builder, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(91, 6856, 6941);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 6728, 6952);

                int
                f_91_6907_6925(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 6907, 6925);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 6728, 6952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 6728, 6952);
            }
        }

        public static void FreeAll<T>(this ArrayBuilder<T> builder, Func<T, ArrayBuilder<T>> getNested)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(91, 6983, 7256);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 7103, 7216);
                    foreach (var item in f_91_7124_7131_I(builder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(91, 7103, 7216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 7165, 7201);

                        // LAFHIS TODO
                        //f_91_7181_7200(f_91_7165_7180(getNested, item), getNested);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(91, 7103, 7216);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(91, 1, 114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(91, 1, 114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(91, 7230, 7245);

                f_91_7230_7244(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(91, 6983, 7256);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>?
                f_91_7165_7180(System.Func<T, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>>
                this_param, T
                arg)
                {
                    var return_v = this_param?.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 7165, 7180);
                    return return_v;
                }


                // LAFHIS TODO
//                void? f_91_7181_7200(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder < T >
//builder, System.Func < T, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder < T >>
//getNested)
//{
//                    var return_v = builder?.FreeAll<T>(getNested);
//                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 7181, 7200);
//                    return return_v;
//                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_91_7124_7131_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 7124, 7131);
                    return return_v;
                }


                int
                f_91_7230_7244(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(91, 7230, 7244);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(91, 6983, 7256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 6983, 7256);
            }
        }

        static ArrayBuilderExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(91, 388, 7281);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(91, 388, 7281);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(91, 388, 7281);
        }

    }
}
