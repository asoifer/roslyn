// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.PooledObjects;

using System.Linq;

namespace Microsoft.CodeAnalysis
{
    internal static class ImmutableArrayExtensions
    {
        public static ImmutableArray<T> AsImmutable<T>(this IEnumerable<T> items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 1341, 1494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 1439, 1483);

                return f_105_1446_1482(items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 1341, 1494);

                System.Collections.Immutable.ImmutableArray<T>
                f_105_1446_1482(System.Collections.Generic.IEnumerable<T>
                items)
                {
                    var return_v = ImmutableArray.CreateRange<T>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 1446, 1482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 1341, 1494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 1341, 1494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> AsImmutableOrEmpty<T>(this IEnumerable<T>? items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 1925, 2199);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 2031, 2128) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 2031, 2128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 2082, 2113);

                    return ImmutableArray<T>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 2031, 2128);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 2144, 2188);

                return f_105_2151_2187(items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 1925, 2199);

                System.Collections.Immutable.ImmutableArray<T>
                f_105_2151_2187(System.Collections.Generic.IEnumerable<T>
                items)
                {
                    var return_v = ImmutableArray.CreateRange<T>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 2151, 2187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 1925, 2199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 1925, 2199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> AsImmutableOrNull<T>(this IEnumerable<T>? items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 2640, 2897);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 2745, 2826) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 2745, 2826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 2796, 2811);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 2745, 2826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 2842, 2886);

                return f_105_2849_2885(items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 2640, 2897);

                System.Collections.Immutable.ImmutableArray<T>
                f_105_2849_2885(System.Collections.Generic.IEnumerable<T>
                items)
                {
                    var return_v = ImmutableArray.CreateRange<T>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 2849, 2885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 2640, 2897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 2640, 2897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> AsImmutable<T>(this T[] items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 3182, 3361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 3269, 3297);

                f_105_3269_3296(items != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 3311, 3350);

                return f_105_3318_3349(items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 3182, 3361);

                int
                f_105_3269_3296(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 3269, 3296);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_3318_3349(params T[]
                items)
                {
                    var return_v = ImmutableArray.Create<T>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 3318, 3349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 3182, 3361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 3182, 3361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> AsImmutableOrNull<T>(this T[]? items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 3717, 3958);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 3811, 3892) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 3811, 3892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 3862, 3877);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 3811, 3892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 3908, 3947);

                return f_105_3915_3946(items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 3717, 3958);

                System.Collections.Immutable.ImmutableArray<T>
                f_105_3915_3946(params T[]
                items)
                {
                    var return_v = ImmutableArray.Create<T>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 3915, 3946);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 3717, 3958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 3717, 3958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> AsImmutableOrEmpty<T>(this T[]? items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 4279, 4537);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 4374, 4471) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 4374, 4471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 4425, 4456);

                    return ImmutableArray<T>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 4374, 4471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 4487, 4526);

                return f_105_4494_4525(items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 4279, 4537);

                System.Collections.Immutable.ImmutableArray<T>
                f_105_4494_4525(params T[]
                items)
                {
                    var return_v = ImmutableArray.Create<T>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 4494, 4525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 4279, 4537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 4279, 4537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<byte> ToImmutable(this MemoryStream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 4783, 4944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 4880, 4933);

                return f_105_4887_4932(f_105_4915_4931(stream));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 4783, 4944);

                byte[]
                f_105_4915_4931(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 4915, 4931);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_105_4887_4932(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create<byte>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 4887, 4932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 4783, 4944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 4783, 4944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<TResult> SelectAsArray<TItem, TResult>(this ImmutableArray<TItem> items, Func<TItem, TResult> map)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 5390, 5599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 5542, 5588);

                return f_105_5549_5587(items, map);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 5390, 5599);

                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_5549_5587(System.Collections.Immutable.ImmutableArray<TItem>
                items, System.Func<TItem, TResult>
                selector)
                {
                    var return_v = ImmutableArray.CreateRange(items, selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 5549, 5587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 5390, 5599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 5390, 5599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<TResult> SelectAsArray<TItem, TArg, TResult>(this ImmutableArray<TItem> items, Func<TItem, TArg, TResult> map, TArg arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 6178, 6414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 6352, 6403);

                return f_105_6359_6402(items, map, arg);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 6178, 6414);

                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_6359_6402(System.Collections.Immutable.ImmutableArray<TItem>
                items, System.Func<TItem, TArg, TResult>
                selector, TArg?
                arg)
                {
                    var return_v = ImmutableArray.CreateRange(items, selector, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 6359, 6402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 6178, 6414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 6178, 6414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<TResult> SelectAsArray<TItem, TArg, TResult>(this ImmutableArray<TItem> items, Func<TItem, int, TArg, TResult> map, TArg arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 6994, 8200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 7173, 8189);

                switch (items.Length)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 7173, 8189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 7256, 7293);

                        return ImmutableArray<TResult>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 7173, 8189);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 7173, 8189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 7342, 7394);

                        return f_105_7349_7393(f_105_7371_7392(map, items[0], 0, arg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 7173, 8189);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 7173, 8189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 7443, 7518);

                        return f_105_7450_7517(f_105_7472_7493(map, items[0], 0, arg), f_105_7495_7516(map, items[1], 1, arg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 7173, 8189);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 7173, 8189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 7567, 7665);

                        return f_105_7574_7664(f_105_7596_7617(map, items[0], 0, arg), f_105_7619_7640(map, items[1], 1, arg), f_105_7642_7663(map, items[2], 2, arg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 7173, 8189);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 7173, 8189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 7714, 7835);

                        return f_105_7721_7834(f_105_7743_7764(map, items[0], 0, arg), f_105_7766_7787(map, items[1], 1, arg), f_105_7789_7810(map, items[2], 2, arg), f_105_7812_7833(map, items[3], 3, arg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 7173, 8189);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 7173, 8189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 7885, 7947);

                        var
                        builder = f_105_7899_7946(items.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 7978, 7983);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 7969, 8114) || true) && (i < items.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 8003, 8006)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 7969, 8114))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 7969, 8114);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 8056, 8091);

                                f_105_8056_8090(builder, f_105_8068_8089(map, items[i], i, arg));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 146);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 146);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 8138, 8174);

                        return f_105_8145_8173(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 7173, 8189);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 6994, 8200);

                TResult
                f_105_7371_7392(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7371, 7392);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_7349_7393(TResult?
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7349, 7393);
                    return return_v;
                }


                TResult
                f_105_7472_7493(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7472, 7493);
                    return return_v;
                }


                TResult
                f_105_7495_7516(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7495, 7516);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_7450_7517(TResult?
                item1, TResult?
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7450, 7517);
                    return return_v;
                }


                TResult
                f_105_7596_7617(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7596, 7617);
                    return return_v;
                }


                TResult
                f_105_7619_7640(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7619, 7640);
                    return return_v;
                }


                TResult
                f_105_7642_7663(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7642, 7663);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_7574_7664(TResult?
                item1, TResult?
                item2, TResult?
                item3)
                {
                    var return_v = ImmutableArray.Create(item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7574, 7664);
                    return return_v;
                }


                TResult
                f_105_7743_7764(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7743, 7764);
                    return return_v;
                }


                TResult
                f_105_7766_7787(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7766, 7787);
                    return return_v;
                }


                TResult
                f_105_7789_7810(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7789, 7810);
                    return return_v;
                }


                TResult
                f_105_7812_7833(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7812, 7833);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_7721_7834(TResult?
                item1, TResult?
                item2, TResult?
                item3, TResult?
                item4)
                {
                    var return_v = ImmutableArray.Create(item1, item2, item3, item4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7721, 7834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                f_105_7899_7946(int
                capacity)
                {
                    var return_v = ArrayBuilder<TResult>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 7899, 7946);
                    return return_v;
                }


                TResult
                f_105_8068_8089(System.Func<TItem, int, TArg, TResult>
                this_param, TItem?
                arg1, int
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 8068, 8089);
                    return return_v;
                }


                int
                f_105_8056_8090(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param, TResult?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 8056, 8090);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_8145_8173(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 8145, 8173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 6994, 8200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 6994, 8200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<TResult> SelectAsArray<TItem, TResult>(this ImmutableArray<TItem> array, Func<TItem, bool> predicate, Func<TItem, TResult> selector)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 8914, 9533);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 9100, 9207) || true) && (array.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 9100, 9207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 9155, 9192);

                    return ImmutableArray<TResult>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 9100, 9207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 9223, 9273);

                var
                builder = f_105_9237_9272()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 9287, 9470);
                    foreach (var item in f_105_9308_9313_I(array))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 9287, 9470);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 9347, 9455) || true) && (f_105_9351_9366(predicate, item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 9347, 9455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 9408, 9436);

                            f_105_9408_9435(builder, f_105_9420_9434(selector, item));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 9347, 9455);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 9287, 9470);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 9486, 9522);

                return f_105_9493_9521(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 8914, 9533);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                f_105_9237_9272()
                {
                    var return_v = ArrayBuilder<TResult>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 9237, 9272);
                    return return_v;
                }


                bool
                f_105_9351_9366(System.Func<TItem, bool>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 9351, 9366);
                    return return_v;
                }


                TResult
                f_105_9420_9434(System.Func<TItem, TResult>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 9420, 9434);
                    return return_v;
                }


                int
                f_105_9408_9435(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param, TResult?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 9408, 9435);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TItem>
                f_105_9308_9313_I(System.Collections.Immutable.ImmutableArray<TItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 9308, 9313);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_9493_9521(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 9493, 9521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 8914, 9533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 8914, 9533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static async ValueTask<ImmutableArray<TResult>> SelectAsArrayAsync<TItem, TResult>(this ImmutableArray<TItem> array, Func<TItem, ValueTask<TResult>> selector)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 9709, 10171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 9899, 9961);

                var
                builder = f_105_9913_9960(array.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 9977, 10108);
                    foreach (var item in f_105_9998_10003_I(array))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 9977, 10108);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 10037, 10093);

                        f_105_10037_10092(builder, await f_105_10055_10069(selector, item).ConfigureAwait(false));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 9977, 10108);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 10124, 10160);

                return f_105_10131_10159(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 9709, 10171);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                f_105_9913_9960(int
                capacity)
                {
                    var return_v = ArrayBuilder<TResult>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 9913, 9960);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<TResult>
                f_105_10055_10069(System.Func<TItem, System.Threading.Tasks.ValueTask<TResult>>
                this_param, TItem?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 10055, 10069);
                    return return_v;
                }


                int
                f_105_10037_10092(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param, TResult?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 10037, 10092);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TItem>
                f_105_9998_10003_I(System.Collections.Immutable.ImmutableArray<TItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 9998, 10003);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_10131_10159(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 10131, 10159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 9709, 10171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 9709, 10171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<TResult> ZipAsArray<T1, T2, TResult>(this ImmutableArray<T1> self, ImmutableArray<T2> other, Func<T1, T2, TResult> map)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 10444, 11708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 10617, 10659);

                f_105_10617_10658(self.Length == other.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 10673, 11697);

                switch (self.Length)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 10673, 11697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 10755, 10792);

                        return ImmutableArray<TResult>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 10673, 11697);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 10673, 11697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 10841, 10894);

                        return f_105_10848_10893(f_105_10870_10892(map, self[0], other[0]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 10673, 11697);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 10673, 11697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 10943, 11020);

                        return f_105_10950_11019(f_105_10972_10994(map, self[0], other[0]), f_105_10996_11018(map, self[1], other[1]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 10673, 11697);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 10673, 11697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 11069, 11170);

                        return f_105_11076_11169(f_105_11098_11120(map, self[0], other[0]), f_105_11122_11144(map, self[1], other[1]), f_105_11146_11168(map, self[2], other[2]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 10673, 11697);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 10673, 11697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 11219, 11344);

                        return f_105_11226_11343(f_105_11248_11270(map, self[0], other[0]), f_105_11272_11294(map, self[1], other[1]), f_105_11296_11318(map, self[2], other[2]), f_105_11320_11342(map, self[3], other[3]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 10673, 11697);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 10673, 11697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 11394, 11455);

                        var
                        builder = f_105_11408_11454(self.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 11486, 11491);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 11477, 11622) || true) && (i < self.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 11510, 11513)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 11477, 11622))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 11477, 11622);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 11563, 11599);

                                f_105_11563_11598(builder, f_105_11575_11597(map, self[i], other[i]));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 146);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 146);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 11646, 11682);

                        return f_105_11653_11681(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 10673, 11697);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 10444, 11708);

                int
                f_105_10617_10658(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 10617, 10658);
                    return 0;
                }


                TResult
                f_105_10870_10892(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 10870, 10892);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_10848_10893(TResult?
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 10848, 10893);
                    return return_v;
                }


                TResult
                f_105_10972_10994(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 10972, 10994);
                    return return_v;
                }


                TResult
                f_105_10996_11018(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 10996, 11018);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_10950_11019(TResult?
                item1, TResult?
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 10950, 11019);
                    return return_v;
                }


                TResult
                f_105_11098_11120(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11098, 11120);
                    return return_v;
                }


                TResult
                f_105_11122_11144(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11122, 11144);
                    return return_v;
                }


                TResult
                f_105_11146_11168(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11146, 11168);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_11076_11169(TResult?
                item1, TResult?
                item2, TResult?
                item3)
                {
                    var return_v = ImmutableArray.Create(item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11076, 11169);
                    return return_v;
                }


                TResult
                f_105_11248_11270(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11248, 11270);
                    return return_v;
                }


                TResult
                f_105_11272_11294(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11272, 11294);
                    return return_v;
                }


                TResult
                f_105_11296_11318(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11296, 11318);
                    return return_v;
                }


                TResult
                f_105_11320_11342(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11320, 11342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_11226_11343(TResult?
                item1, TResult?
                item2, TResult?
                item3, TResult?
                item4)
                {
                    var return_v = ImmutableArray.Create(item1, item2, item3, item4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11226, 11343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                f_105_11408_11454(int
                capacity)
                {
                    var return_v = ArrayBuilder<TResult>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11408, 11454);
                    return return_v;
                }


                TResult
                f_105_11575_11597(System.Func<T1, T2, TResult>
                this_param, T1?
                arg1, T2?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11575, 11597);
                    return return_v;
                }


                int
                f_105_11563_11598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param, TResult?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11563, 11598);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_11653_11681(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11653, 11681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 10444, 11708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 10444, 11708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<TResult> ZipAsArray<T1, T2, TArg, TResult>(this ImmutableArray<T1> self, ImmutableArray<T2> other, TArg arg, Func<T1, T2, int, TArg, TResult> map)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 11720, 12359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 11920, 11962);

                f_105_11920_11961(self.Length == other.Length);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 11976, 12078) || true) && (self.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 11976, 12078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 12026, 12063);

                    return ImmutableArray<TResult>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 11976, 12078);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 12094, 12155);

                var
                builder = f_105_12108_12154(self.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 12178, 12183);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 12169, 12298) || true) && (i < self.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 12202, 12205)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 12169, 12298))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 12169, 12298);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 12239, 12283);

                        f_105_12239_12282(builder, f_105_12251_12281(map, self[i], other[i], i, arg));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 12312, 12348);

                return f_105_12319_12347(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 11720, 12359);

                int
                f_105_11920_11961(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 11920, 11961);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                f_105_12108_12154(int
                capacity)
                {
                    var return_v = ArrayBuilder<TResult>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 12108, 12154);
                    return return_v;
                }


                TResult
                f_105_12251_12281(System.Func<T1, T2, int, TArg, TResult>
                this_param, T1?
                arg1, T2?
                arg2, int
                arg3, TArg?
                arg4)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3, arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 12251, 12281);
                    return return_v;
                }


                int
                f_105_12239_12282(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param, TResult?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 12239, 12282);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_105_12319_12347(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 12319, 12347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 11720, 12359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 11720, 12359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> WhereAsArray<T>(this ImmutableArray<T> array, Func<T, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(105, 12828, 12912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 12831, 12912);
                return f_105_12831_12912(array, predicate, predicateWithArg: null, arg: null); DynAbs.Tracing.TraceSender.TraceExitMethod(105, 12828, 12912);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 12828, 12912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 12828, 12912);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<T>
            f_105_12831_12912(System.Collections.Immutable.ImmutableArray<T>
            array, System.Func<T, bool>
            predicateWithoutArg, System.Func<T, object?, bool>?
            predicateWithArg, object?
            arg)
            {
                var return_v = WhereAsArrayImpl<T, object?>(array, predicateWithoutArg, predicateWithArg: predicateWithArg, arg: arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 12831, 12912);
                return return_v;
            }

        }

        public static ImmutableArray<T> WhereAsArray<T, TArg>(this ImmutableArray<T> array, Func<T, TArg, bool> predicate, TArg arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(105, 13404, 13473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 13407, 13473);
                return f_105_13407_13473(array, predicateWithoutArg: null, predicate, arg); DynAbs.Tracing.TraceSender.TraceExitMethod(105, 13404, 13473);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 13404, 13473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 13404, 13473);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<T>
            f_105_13407_13473(System.Collections.Immutable.ImmutableArray<T>
            array, System.Func<T, bool>?
            predicateWithoutArg, System.Func<T, TArg, bool>
            predicateWithArg, TArg?
            arg)
            {
                var return_v = WhereAsArrayImpl(array, predicateWithoutArg: predicateWithoutArg, predicateWithArg, arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 13407, 13473);
                return return_v;
            }

        }

        private static ImmutableArray<T> WhereAsArrayImpl<T, TArg>(ImmutableArray<T> array, Func<T, bool>? predicateWithoutArg, Func<T, TArg, bool>? predicateWithArg, TArg arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 13486, 15650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 13679, 13710);

                f_105_13679_13709(f_105_13692_13708_M(!array.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 13724, 13793);

                f_105_13724_13792(predicateWithArg != null ^ predicateWithoutArg != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 13809, 13841);

                ArrayBuilder<T>?
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 13855, 13872);

                bool
                none = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 13886, 13902);

                bool
                all = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 13918, 13939);

                int
                n = array.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 13962, 13967);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 13953, 15222) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 13976, 13979)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 13953, 15222))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 13953, 15222);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14013, 14030);

                        var
                        a = array[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14050, 15207) || true) && ((DynAbs.Tracing.TraceSender.Conditional_F1(105, 14054, 14083) || (((predicateWithoutArg != null) && DynAbs.Tracing.TraceSender.Conditional_F2(105, 14086, 14108)) || DynAbs.Tracing.TraceSender.Conditional_F3(105, 14111, 14136))) ? f_105_14086_14108(predicateWithoutArg, a) : f_105_14111_14136(predicateWithArg, a, arg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 14050, 15207);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14178, 14191);

                            none = false;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14213, 14302) || true) && (all)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 14213, 14302);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14270, 14279);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(105, 14213, 14302);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14326, 14346);

                            f_105_14326_14345(i > 0);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14368, 14500) || true) && (builder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 14368, 14500);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14437, 14477);

                                builder = f_105_14447_14476();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(105, 14368, 14500);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14524, 14539);

                            f_105_14524_14538(
                                                builder, a);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 14050, 15207);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 14050, 15207);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14621, 14749) || true) && (none)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 14621, 14749);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14679, 14691);

                                all = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14717, 14726);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(105, 14621, 14749);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14773, 14793);

                            f_105_14773_14792(i > 0);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14815, 15188) || true) && (all)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 14815, 15188);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14872, 14902);

                                f_105_14872_14901(builder == null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14928, 14940);

                                all = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 14966, 15006);

                                builder = f_105_14976_15005();
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15041, 15046);
                                    for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15032, 15165) || true) && (j < i)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15055, 15058)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 15032, 15165))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 15032, 15165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15116, 15138);

                                        f_105_15116_15137(builder, array[j]);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 134);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 134);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(105, 14815, 15188);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 14050, 15207);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 1270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 1270);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15238, 15639) || true) && (builder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 15238, 15639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15291, 15310);

                    f_105_15291_15309(!all);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15328, 15348);

                    f_105_15328_15347(!none);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15366, 15402);

                    return f_105_15373_15401(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 15238, 15639);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 15238, 15639);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15436, 15639) || true) && (all)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 15436, 15639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15477, 15490);

                        return array;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 15436, 15639);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 15436, 15639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15556, 15575);

                        f_105_15556_15574(none);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15593, 15624);

                        return ImmutableArray<T>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 15436, 15639);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 15238, 15639);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 13486, 15650);

                bool
                f_105_13692_13708_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(105, 13692, 13708);
                    return return_v;
                }


                int
                f_105_13679_13709(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 13679, 13709);
                    return 0;
                }


                int
                f_105_13724_13792(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 13724, 13792);
                    return 0;
                }


                bool
                f_105_14086_14108(System.Func<T, bool>
                this_param, T?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 14086, 14108);
                    return return_v;
                }


                bool
                f_105_14111_14136(System.Func<T, TArg, bool>
                this_param, T?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 14111, 14136);
                    return return_v;
                }


                int
                f_105_14326_14345(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 14326, 14345);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_105_14447_14476()
                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 14447, 14476);
                    return return_v;
                }


                int
                f_105_14524_14538(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 14524, 14538);
                    return 0;
                }


                int
                f_105_14773_14792(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 14773, 14792);
                    return 0;
                }


                int
                f_105_14872_14901(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 14872, 14901);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_105_14976_15005()
                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 14976, 15005);
                    return return_v;
                }


                int
                f_105_15116_15137(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 15116, 15137);
                    return 0;
                }


                int
                f_105_15291_15309(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 15291, 15309);
                    return 0;
                }


                int
                f_105_15328_15347(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 15328, 15347);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_15373_15401(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 15373, 15401);
                    return return_v;
                }


                int
                f_105_15556_15574(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 15556, 15574);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 13486, 15650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 13486, 15650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Any<T, TArg>(this ImmutableArray<T> array, Func<T, TArg, bool> predicate, TArg arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 15662, 16070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15789, 15810);

                int
                n = array.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15833, 15838);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15824, 16030) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15847, 15850)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 15824, 16030))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 15824, 16030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15884, 15901);

                        var
                        a = array[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15921, 16015) || true) && (f_105_15925_15942(predicate, a, arg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 15921, 16015);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 15984, 15996);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 15921, 16015);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16046, 16059);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 15662, 16070);

                bool
                f_105_15925_15942(System.Func<T, TArg, bool>
                this_param, T?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 15925, 15942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 15662, 16070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 15662, 16070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool All<T, TArg>(this ImmutableArray<T> array, Func<T, TArg, bool> predicate, TArg arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 16082, 16491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16209, 16230);

                int
                n = array.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16253, 16258);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16244, 16452) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16267, 16270)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 16244, 16452))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 16244, 16452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16304, 16321);

                        var
                        a = array[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16341, 16437) || true) && (!f_105_16346_16363(predicate, a, arg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 16341, 16437);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16405, 16418);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 16341, 16437);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16468, 16480);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 16082, 16491);

                bool
                f_105_16346_16363(System.Func<T, TArg, bool>
                this_param, T?
                arg1, TArg?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 16346, 16363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 16082, 16491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 16082, 16491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static async Task<bool> AnyAsync<T>(this ImmutableArray<T> array, Func<T, Task<bool>> predicateAsync)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 16503, 16945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16636, 16657);

                int
                n = array.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16680, 16685);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16671, 16905) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16694, 16697)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 16671, 16905))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 16671, 16905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16731, 16748);

                        var
                        a = array[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16768, 16890) || true) && (await f_105_16778_16817(f_105_16778_16795(predicateAsync, a), false))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 16768, 16890);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16859, 16871);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 16768, 16890);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 16921, 16934);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 16503, 16945);

                System.Threading.Tasks.Task<bool>
                f_105_16778_16795(System.Func<T, System.Threading.Tasks.Task<bool>>
                this_param, T?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 16778, 16795);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<bool>
                f_105_16778_16817(System.Threading.Tasks.Task<bool>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 16778, 16817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 16503, 16945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 16503, 16945);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static async ValueTask<T?> FirstOrDefaultAsync<T>(this ImmutableArray<T> array, Func<T, Task<bool>> predicateAsync)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 16957, 17412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 17104, 17125);

                int
                n = array.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 17148, 17153);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 17139, 17370) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 17162, 17165)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 17139, 17370))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 17139, 17370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 17199, 17216);

                        var
                        a = array[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 17236, 17355) || true) && (await f_105_17246_17285(f_105_17246_17263(predicateAsync, a), false))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 17236, 17355);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 17327, 17336);

                            return a;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 17236, 17355);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 17386, 17401);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 16957, 17412);

                System.Threading.Tasks.Task<bool>
                f_105_17246_17263(System.Func<T, System.Threading.Tasks.Task<bool>>
                this_param, T?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 17246, 17263);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<bool>
                f_105_17246_17285(System.Threading.Tasks.Task<bool>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 17246, 17285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 16957, 17412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 16957, 17412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ImmutableArray<TBase> Cast<TDerived, TBase>(this ImmutableArray<TDerived> items)
                    where TDerived : class, TBase
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 17560, 17836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 17782, 17825);

                return ImmutableArray<TBase>.CastUp(items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 17560, 17836);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 17560, 17836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 17560, 17836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool SetEquals<T>(this ImmutableArray<T> array1, ImmutableArray<T> array2, IEqualityComparer<T> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 18276, 19489);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18420, 18614) || true) && (array1.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 18420, 18614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18474, 18498);

                    return array2.IsDefault;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 18420, 18614);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 18420, 18614);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18532, 18614) || true) && (array2.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 18532, 18614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18586, 18599);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 18532, 18614);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 18420, 18614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18630, 18657);

                var
                count1 = array1.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18671, 18698);

                var
                count2 = array2.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18780, 19176) || true) && (count1 == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 18780, 19176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18829, 18848);

                    return count2 == 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 18780, 19176);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 18780, 19176);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18882, 19176) || true) && (count2 == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 18882, 19176);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18931, 18944);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 18882, 19176);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 18882, 19176);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 18978, 19176) || true) && (count1 == 1 && (DynAbs.Tracing.TraceSender.Expression_True(105, 18982, 19008) && count2 == 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 18978, 19176);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 19042, 19064);

                            var
                            item1 = array1[0]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 19082, 19104);

                            var
                            item2 = array2[0]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 19124, 19161);

                            return f_105_19131_19160(comparer, item1, item2);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 18978, 19176);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 18882, 19176);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 18780, 19176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 19192, 19236);

                var
                set1 = f_105_19203_19235(array1, comparer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 19250, 19294);

                var
                set2 = f_105_19261_19293(array2, comparer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 19450, 19478);

                return f_105_19457_19477(set1, set2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 18276, 19489);

                bool
                f_105_19131_19160(System.Collections.Generic.IEqualityComparer<T>
                this_param, T?
                x, T?
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 19131, 19160);
                    return return_v;
                }


                System.Collections.Generic.HashSet<T>
                f_105_19203_19235(System.Collections.Immutable.ImmutableArray<T>
                collection, System.Collections.Generic.IEqualityComparer<T>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<T>((System.Collections.Generic.IEnumerable<T>)collection, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 19203, 19235);
                    return return_v;
                }


                System.Collections.Generic.HashSet<T>
                f_105_19261_19293(System.Collections.Immutable.ImmutableArray<T>
                collection, System.Collections.Generic.IEqualityComparer<T>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<T>((System.Collections.Generic.IEnumerable<T>)collection, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 19261, 19293);
                    return return_v;
                }


                bool
                f_105_19457_19477(System.Collections.Generic.HashSet<T>
                this_param, System.Collections.Generic.HashSet<T>
                other)
                {
                    var return_v = this_param.SetEquals((System.Collections.Generic.IEnumerable<T>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 19457, 19477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 18276, 19489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 18276, 19489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> NullToEmpty<T>(this ImmutableArray<T> array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 19621, 19790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 19722, 19779);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(105, 19729, 19744) || ((array.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(105, 19747, 19770)) || DynAbs.Tracing.TraceSender.Conditional_F3(105, 19773, 19778))) ? ImmutableArray<T>.Empty : array;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 19621, 19790);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 19621, 19790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 19621, 19790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> Distinct<T>(this ImmutableArray<T> array, IEqualityComparer<T>? comparer = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 20059, 20771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20196, 20227);

                f_105_20196_20226(f_105_20209_20225_M(!array.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20243, 20325) || true) && (array.Length < 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 20243, 20325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20297, 20310);

                    return array;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 20243, 20325);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20341, 20376);

                var
                set = f_105_20351_20375(comparer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20390, 20434);

                var
                builder = f_105_20404_20433()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20448, 20610);
                    foreach (var a in f_105_20466_20471_I(array))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 20448, 20610);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20505, 20595) || true) && (f_105_20509_20519(set, a))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 20505, 20595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20561, 20576);

                            f_105_20561_20575(builder, a);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 20505, 20595);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 20448, 20610);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 163);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20626, 20703);

                var
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(105, 20639, 20670) || (((f_105_20640_20653(builder) == array.Length) && DynAbs.Tracing.TraceSender.Conditional_F2(105, 20673, 20678)) || DynAbs.Tracing.TraceSender.Conditional_F3(105, 20681, 20702))) ? array : f_105_20681_20702(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20717, 20732);

                f_105_20717_20731(builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20746, 20760);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 20059, 20771);

                bool
                f_105_20209_20225_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(105, 20209, 20225);
                    return return_v;
                }


                int
                f_105_20196_20226(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 20196, 20226);
                    return 0;
                }


                System.Collections.Generic.HashSet<T>
                f_105_20351_20375(System.Collections.Generic.IEqualityComparer<T>?
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<T>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 20351, 20375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_105_20404_20433()
                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 20404, 20433);
                    return return_v;
                }


                bool
                f_105_20509_20519(System.Collections.Generic.HashSet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 20509, 20519);
                    return return_v;
                }


                int
                f_105_20561_20575(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 20561, 20575);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_20466_20471_I(System.Collections.Immutable.ImmutableArray<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 20466, 20471);
                    return return_v;
                }


                int
                f_105_20640_20653(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(105, 20640, 20653);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_20681_20702(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 20681, 20702);
                    return return_v;
                }


                int
                f_105_20717_20731(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 20717, 20731);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 20059, 20771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 20059, 20771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasAnyErrors<T>(this ImmutableArray<T> diagnostics) where T : Diagnostic
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 20783, 21152);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20901, 21112);
                    foreach (var diagnostic in f_105_20928_20939_I(diagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 20901, 21112);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 20973, 21097) || true) && (f_105_20977_20996(diagnostic) == DiagnosticSeverity.Error)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 20973, 21097);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 21066, 21078);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 20973, 21097);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 20901, 21112);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 21128, 21141);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 20783, 21152);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_105_20977_20996(T
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(105, 20977, 20996);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_20928_20939_I(System.Collections.Immutable.ImmutableArray<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 20928, 20939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 20783, 21152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 20783, 21152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<T> ConditionallyDeOrder<T>(this ImmutableArray<T> array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 21346, 21833);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 21469, 21787) || true) && (f_105_21473_21489_M(!array.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(105, 21473, 21510) && array.Length >= 2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 21469, 21787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 21544, 21571);

                    T[]
                    copy = array.ToArray()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 21589, 21616);

                    int
                    last = f_105_21600_21611(copy) - 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 21634, 21653);

                    var
                    temp = copy[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 21671, 21692);

                    copy[0] = copy[last];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 21710, 21728);

                    copy[last] = temp;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 21746, 21772);

                    return f_105_21753_21771(copy);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 21469, 21787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 21809, 21822);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 21346, 21833);

                bool
                f_105_21473_21489_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(105, 21473, 21489);
                    return return_v;
                }


                int
                f_105_21600_21611(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(105, 21600, 21611);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_21753_21771(T[]
                items)
                {
                    var return_v = items.AsImmutable<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 21753, 21771);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 21346, 21833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 21346, 21833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TValue> Flatten<TKey, TValue>(
                    this Dictionary<TKey, ImmutableArray<TValue>> dictionary,
                    IComparer<TValue>? comparer = null)
                    where TKey : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 21845, 22675);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 22085, 22195) || true) && (f_105_22089_22105(dictionary) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 22085, 22195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 22144, 22180);

                    return ImmutableArray<TValue>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 22085, 22195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 22211, 22260);

                var
                builder = f_105_22225_22259()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 22276, 22383);
                    foreach (var kvp in f_105_22296_22306_I(dictionary))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 22276, 22383);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 22340, 22368);

                        f_105_22340_22367(builder, kvp.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 22276, 22383);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 108);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 22399, 22612) || true) && (comparer != null && (DynAbs.Tracing.TraceSender.Expression_True(105, 22403, 22440) && f_105_22423_22436(builder) > 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 22399, 22612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 22574, 22597);

                    f_105_22574_22596(                // PERF: Beware ImmutableArray<T>.Builder.Sort allocates a Comparer wrapper object
                                    builder, comparer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 22399, 22612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 22628, 22664);

                return f_105_22635_22663(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 21845, 22675);

                int
                f_105_22089_22105(System.Collections.Generic.Dictionary<TKey, System.Collections.Immutable.ImmutableArray<TValue>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(105, 22089, 22105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TValue>
                f_105_22225_22259()
                {
                    var return_v = ArrayBuilder<TValue>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 22225, 22259);
                    return return_v;
                }


                int
                f_105_22340_22367(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TValue>
                this_param, System.Collections.Immutable.ImmutableArray<TValue>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 22340, 22367);
                    return 0;
                }


                System.Collections.Generic.Dictionary<TKey, System.Collections.Immutable.ImmutableArray<TValue>>
                f_105_22296_22306_I(System.Collections.Generic.Dictionary<TKey, System.Collections.Immutable.ImmutableArray<TValue>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 22296, 22306);
                    return return_v;
                }


                int
                f_105_22423_22436(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TValue>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(105, 22423, 22436);
                    return return_v;
                }


                int
                f_105_22574_22596(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TValue>
                this_param, System.Collections.Generic.IComparer<TValue>
                comparer)
                {
                    this_param.Sort(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 22574, 22596);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TValue>
                f_105_22635_22663(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TValue>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 22635, 22663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 21845, 22675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 21845, 22675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<T> Concat<T>(this ImmutableArray<T> first, ImmutableArray<T> second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 22687, 22852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 22811, 22841);

                return first.AddRange(second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 22687, 22852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 22687, 22852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 22687, 22852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<T> Concat<T>(this ImmutableArray<T> first, ImmutableArray<T> second, ImmutableArray<T> third)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 22864, 23276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23013, 23100);

                var
                builder = f_105_23027_23099(first.Length + second.Length + third.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23114, 23138);

                f_105_23114_23137(builder, first);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23152, 23177);

                f_105_23152_23176(builder, second);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23191, 23215);

                f_105_23191_23214(builder, third);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23229, 23265);

                return f_105_23236_23264(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 22864, 23276);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_105_23027_23099(int
                capacity)
                {
                    var return_v = ArrayBuilder<T>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23027, 23099);
                    return return_v;
                }


                int
                f_105_23114_23137(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23114, 23137);
                    return 0;
                }


                int
                f_105_23152_23176(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23152, 23176);
                    return 0;
                }


                int
                f_105_23191_23214(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23191, 23214);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_23236_23264(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23236, 23264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 22864, 23276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 22864, 23276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<T> Concat<T>(this ImmutableArray<T> first, ImmutableArray<T> second, ImmutableArray<T> third, ImmutableArray<T> fourth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 23288, 23781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23463, 23566);

                var
                builder = f_105_23477_23565(first.Length + second.Length + third.Length + fourth.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23580, 23604);

                f_105_23580_23603(builder, first);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23618, 23643);

                f_105_23618_23642(builder, second);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23657, 23681);

                f_105_23657_23680(builder, third);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23695, 23720);

                f_105_23695_23719(builder, fourth);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23734, 23770);

                return f_105_23741_23769(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 23288, 23781);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_105_23477_23565(int
                capacity)
                {
                    var return_v = ArrayBuilder<T>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23477, 23565);
                    return return_v;
                }


                int
                f_105_23580_23603(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23580, 23603);
                    return 0;
                }


                int
                f_105_23618_23642(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23618, 23642);
                    return 0;
                }


                int
                f_105_23657_23680(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23657, 23680);
                    return 0;
                }


                int
                f_105_23695_23719(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23695, 23719);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_23741_23769(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 23741, 23769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 23288, 23781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 23288, 23781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<T> Concat<T>(this ImmutableArray<T> first, T second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 23793, 23937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 23901, 23926);

                return first.Add(second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 23793, 23937);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 23793, 23937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 23793, 23937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasDuplicates<T>(this ImmutableArray<T> array, IEqualityComparer<T> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 23949, 24663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24072, 24652);

                switch (array.Length)
                {

                    case 0:
                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 24072, 24652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24180, 24193);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 24072, 24652);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 24072, 24652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24242, 24285);

                        return f_105_24249_24284(comparer, array[0], array[1]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 24072, 24652);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 24072, 24652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24335, 24370);

                        var
                        set = f_105_24345_24369(comparer)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24392, 24600);
                            foreach (var i in f_105_24410_24415_I(array))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 24392, 24600);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24465, 24577) || true) && (!f_105_24470_24480(set, i))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 24465, 24577);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24538, 24550);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 24465, 24577);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(105, 24392, 24600);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 209);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 209);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24624, 24637);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 24072, 24652);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 23949, 24663);

                bool
                f_105_24249_24284(System.Collections.Generic.IEqualityComparer<T>
                this_param, T?
                x, T?
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 24249, 24284);
                    return return_v;
                }


                System.Collections.Generic.HashSet<T>
                f_105_24345_24369(System.Collections.Generic.IEqualityComparer<T>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<T>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 24345, 24369);
                    return return_v;
                }


                bool
                f_105_24470_24480(System.Collections.Generic.HashSet<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 24470, 24480);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_24410_24415_I(System.Collections.Immutable.ImmutableArray<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 24410, 24415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 23949, 24663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 23949, 24663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int Count<T>(this ImmutableArray<T> items, Func<T, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 24675, 25118);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24781, 24856) || true) && (items.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 24781, 24856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24832, 24841);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 24781, 24856);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24872, 24886);

                int
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24909, 24914);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24900, 25078) || true) && (i < items.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24934, 24937)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 24900, 25078))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 24900, 25078);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 24971, 25063) || true) && (f_105_24975_24994(predicate, items[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 24971, 25063);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 25036, 25044);

                            ++count;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 24971, 25063);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 25094, 25107);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 24675, 25118);

                bool
                f_105_24975_24994(System.Func<T, bool>
                this_param, T?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 24975, 24994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 24675, 25118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 24675, 25118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct ImmutableArrayProxy<T>
        {

            internal T[] MutableArray;
            static ImmutableArrayProxy()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(105, 25130, 25276);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(105, 25130, 25276);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 25130, 25276);
            }
        }

        internal static T[] DangerousGetUnderlyingArray<T>(this ImmutableArray<T> array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(105, 25520, 25599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 25523, 25599);
                return f_105_25523_25586(ref array).MutableArray; DynAbs.Tracing.TraceSender.TraceExitMethod(105, 25520, 25599);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 25520, 25599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 25520, 25599);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.ImmutableArrayExtensions.ImmutableArrayProxy<T>
            f_105_25523_25586(ref System.Collections.Immutable.ImmutableArray<T>
            source)
            {
                var return_v = Unsafe.As<ImmutableArray<T>, ImmutableArrayProxy<T>>(ref source);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 25523, 25586);
                return return_v;
            }

        }

        internal static ReadOnlySpan<T> AsSpan<T>(this ImmutableArray<T> array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(105, 25697, 25735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 25700, 25735);
                return array.DangerousGetUnderlyingArray(); DynAbs.Tracing.TraceSender.TraceExitMethod(105, 25697, 25735);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 25697, 25735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 25697, 25735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<T> DangerousCreateFromUnderlyingArray<T>([MaybeNull] ref T[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 25748, 26059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 25871, 25935);

                // LAFHIS
                //var proxy = new ImmutableArrayProxy<T> { MutableArray = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => array, 105, 25883, 25934) };
                var proxy = new ImmutableArrayProxy<T> { MutableArray = array };
                DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 25949, 25963);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 25949, 25963);

                array = null!;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 25977, 26048);

                return f_105_25984_26047(ref proxy);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 25748, 26059);

                System.Collections.Immutable.ImmutableArray<T>
                f_105_25984_26047(ref Microsoft.CodeAnalysis.ImmutableArrayExtensions.ImmutableArrayProxy<T>
                source)
                {
                    var return_v = Unsafe.As<ImmutableArrayProxy<T>, ImmutableArray<T>>(ref source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 25984, 26047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 25748, 26059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 25748, 26059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Dictionary<K, ImmutableArray<T>> ToDictionary<K, T>(this ImmutableArray<T> items, Func<T, K> keySelector, IEqualityComparer<K>? comparer = null)
                    where K : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 26071, 27681);
                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T> bucket = default(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26287, 26583) || true) && (items.Length == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 26287, 26583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26342, 26410);

                    var
                    dictionary1 = f_105_26360_26409(1, comparer)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26428, 26447);

                    T
                    value = items[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26465, 26531);

                    f_105_26465_26530(dictionary1, f_105_26481_26499(keySelector, value), f_105_26501_26529(value));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26549, 26568);

                    return dictionary1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 26287, 26583);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26599, 26723) || true) && (items.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 26599, 26723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26654, 26708);

                    return f_105_26661_26707(comparer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 26599, 26723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26861, 26938);

                var
                accumulator = f_105_26879_26937(items.Length, comparer)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26961, 26966);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26952, 27359) || true) && (i < items.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 26986, 26989)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 26952, 27359))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 26952, 27359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27023, 27043);

                        var
                        item = items[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27061, 27089);

                        var
                        key = f_105_27071_27088(keySelector, item)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27107, 27307) || true) && (!f_105_27112_27156(accumulator, key, out bucket))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 27107, 27307);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27198, 27237);

                            bucket = f_105_27207_27236();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27259, 27288);

                            f_105_27259_27287(accumulator, key, bucket);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 27107, 27307);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27327, 27344);

                        f_105_27327_27343(
                                        bucket, item);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 408);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27375, 27458);

                var
                dictionary = f_105_27392_27457(f_105_27429_27446(accumulator), comparer)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27497, 27636);
                    foreach (var pair in f_105_27518_27529_I(accumulator))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 27497, 27636);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27563, 27621);

                        f_105_27563_27620(dictionary, pair.Key, f_105_27588_27619(pair.Value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(105, 27497, 27636);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27652, 27670);

                return dictionary;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 26071, 27681);

                System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>
                f_105_26360_26409(int
                capacity, System.Collections.Generic.IEqualityComparer<K>?
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>(capacity, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 26360, 26409);
                    return return_v;
                }


                K
                f_105_26481_26499(System.Func<T, K>
                this_param, T?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 26481, 26499);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_26501_26529(T?
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 26501, 26529);
                    return return_v;
                }


                int
                f_105_26465_26530(System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>
                this_param, K
                key, System.Collections.Immutable.ImmutableArray<T>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 26465, 26530);
                    return 0;
                }


                System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>
                f_105_26661_26707(System.Collections.Generic.IEqualityComparer<K>?
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 26661, 26707);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>>
                f_105_26879_26937(int
                capacity, System.Collections.Generic.IEqualityComparer<K>?
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>>(capacity, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 26879, 26937);
                    return return_v;
                }


                K
                f_105_27071_27088(System.Func<T, K>
                this_param, T?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 27071, 27088);
                    return return_v;
                }


                bool
                f_105_27112_27156(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>>
                this_param, K
                key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 27112, 27156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_105_27207_27236()
                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 27207, 27236);
                    return return_v;
                }


                int
                f_105_27259_27287(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>>
                this_param, K
                key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 27259, 27287);
                    return 0;
                }


                int
                f_105_27327_27343(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 27327, 27343);
                    return 0;
                }


                int
                f_105_27429_27446(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(105, 27429, 27446);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>
                f_105_27392_27457(int
                capacity, System.Collections.Generic.IEqualityComparer<K>?
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>(capacity, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 27392, 27457);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_105_27588_27619(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 27588, 27619);
                    return return_v;
                }


                int
                f_105_27563_27620(System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>
                this_param, K
                key, System.Collections.Immutable.ImmutableArray<T>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 27563, 27620);
                    return 0;
                }


                System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>>
                f_105_27518_27529_I(System.Collections.Generic.Dictionary<K, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 27518, 27529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 26071, 27681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 26071, 27681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Location FirstOrNone(this ImmutableArray<Location> items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 27693, 27850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 27791, 27839);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(105, 27798, 27811) || ((items.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(105, 27814, 27827)) || DynAbs.Tracing.TraceSender.Conditional_F3(105, 27830, 27838))) ? f_105_27814_27827() : items[0];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 27693, 27850);

                Microsoft.CodeAnalysis.Location
                f_105_27814_27827()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(105, 27814, 27827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 27693, 27850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 27693, 27850);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool SequenceEqual<TElement, TArg>(this ImmutableArray<TElement> array1, ImmutableArray<TElement> array2, TArg arg, Func<TElement, TElement, TArg, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(105, 27862, 28831);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28238, 28342) || true) && (array1.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 28238, 28342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28292, 28327);

                    throw f_105_28298_28326();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 28238, 28342);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28358, 28462) || true) && (array2.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 28358, 28462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28412, 28447);

                    throw f_105_28418_28446();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 28358, 28462);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28478, 28574) || true) && (array1.Length != array2.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 28478, 28574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28546, 28559);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(105, 28478, 28574);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28599, 28604);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28590, 28792) || true) && (i < array1.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28625, 28628)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(105, 28590, 28792))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 28590, 28792);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28662, 28777) || true) && (!f_105_28667_28703(predicate, array1[i], array2[i], arg))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(105, 28662, 28777);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28745, 28758);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(105, 28662, 28777);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(105, 1, 203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(105, 1, 203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28808, 28820);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(105, 27862, 28831);

                System.NullReferenceException
                f_105_28298_28326()
                {
                    var return_v = new System.NullReferenceException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 28298, 28326);
                    return return_v;
                }


                System.NullReferenceException
                f_105_28418_28446()
                {
                    var return_v = new System.NullReferenceException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 28418, 28446);
                    return return_v;
                }


                bool
                f_105_28667_28703(System.Func<TElement, TElement, TArg, bool>
                this_param, TElement?
                arg1, TElement?
                arg2, TArg?
                arg3)
                {
                    var return_v = this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(105, 28667, 28703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 27862, 28831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 27862, 28831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int IndexOf<T>(this ImmutableArray<T> array, T item, IEqualityComparer<T> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(105, 28956, 29003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(105, 28959, 29003);
                return array.IndexOf(item, startIndex: 0, comparer); DynAbs.Tracing.TraceSender.TraceExitMethod(105, 28956, 29003);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(105, 28956, 29003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 28956, 29003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ImmutableArrayExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(105, 748, 29011);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(105, 748, 29011);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(105, 748, 29011);
        }

    }
}
