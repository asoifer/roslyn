// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Roslyn.Utilities
{
    internal static class ImmutableArrayExtensions
    {
        internal static ImmutableArray<T> ToImmutableArrayOrEmpty<T>(this IEnumerable<T>? items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(333, 497, 575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 500, 575);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(333, 500, 513) || ((items == null && DynAbs.Tracing.TraceSender.Conditional_F2(333, 516, 539)) || DynAbs.Tracing.TraceSender.Conditional_F3(333, 542, 575))) ? ImmutableArray<T>.Empty : f_333_542_575(items); DynAbs.Tracing.TraceSender.TraceExitMethod(333, 497, 575);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(333, 497, 575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(333, 497, 575);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<T>
            f_333_542_575(System.Collections.Generic.IEnumerable<T>
            items)
            {
                var return_v = ImmutableArray.CreateRange(items);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(333, 542, 575);
                return return_v;
            }

        }

        internal static ImmutableArray<T> ToImmutableArrayOrEmpty<T>(this ImmutableArray<T> items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(333, 692, 744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 695, 744);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(333, 695, 710) || ((items.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(333, 713, 736)) || DynAbs.Tracing.TraceSender.Conditional_F3(333, 739, 744))) ? ImmutableArray<T>.Empty : items; DynAbs.Tracing.TraceSender.TraceExitMethod(333, 692, 744);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(333, 692, 744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(333, 692, 744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int BinarySearch<TElement, TValue>(this ImmutableArray<TElement> array, TValue value, Func<TElement, TValue, int> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(333, 871, 1646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1035, 1047);

                int
                low = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1061, 1089);

                int
                high = array.Length - 1
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1105, 1607) || true) && (low <= high)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(333, 1105, 1607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1157, 1196);

                        int
                        middle = low + ((high - low) >> 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1214, 1262);

                        int
                        comparison = f_333_1231_1261(comparer, array[middle], value)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1282, 1376) || true) && (comparison == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(333, 1282, 1376);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1343, 1357);

                            return middle;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(333, 1282, 1376);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1396, 1592) || true) && (comparison > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(333, 1396, 1592);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1456, 1474);

                            high = middle - 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(333, 1396, 1592);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(333, 1396, 1592);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1556, 1573);

                            low = middle + 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(333, 1396, 1592);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(333, 1105, 1607);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(333, 1105, 1607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(333, 1105, 1607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1623, 1635);

                return ~low;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(333, 871, 1646);

                int
                f_333_1231_1261(System.Func<TElement, TValue, int>
                this_param, TElement?
                arg1, TValue?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(333, 1231, 1261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(333, 871, 1646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(333, 871, 1646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TDerived> CastDown<TOriginal, TDerived>(this ImmutableArray<TOriginal> array) where TDerived : class, TOriginal
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(333, 1658, 1871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(333, 1825, 1860);

                return array.CastArray<TDerived>();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(333, 1658, 1871);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(333, 1658, 1871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(333, 1658, 1871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ImmutableArrayExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(333, 332, 1878);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(333, 332, 1878);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(333, 332, 1878);
        }

    }
}
