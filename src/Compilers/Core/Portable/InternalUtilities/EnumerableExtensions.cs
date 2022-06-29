// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

using System.Diagnostics;

namespace Roslyn.Utilities
{
    internal static partial class EnumerableExtensions
    {
        public static IEnumerable<T> Do<T>(this IEnumerable<T> source, Action<T> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 634, 1487);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 739, 854) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 739, 854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 791, 839);

                    throw f_324_797_838(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 739, 854);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 870, 985) || true) && (action == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 870, 985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 922, 970);

                    throw f_324_928_969(nameof(action));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 870, 985);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1074, 1446) || true) && (source is IList<T> list)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 1074, 1446);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1144, 1149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1151, 1169);
                        for (int
        i = 0
        ,
        count = f_324_1159_1169(list)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1135, 1262) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1182, 1185)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(324, 1135, 1262))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 1135, 1262);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1227, 1243);

                            f_324_1227_1242(action, f_324_1234_1241(list, i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 128);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 128);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 1074, 1446);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 1074, 1446);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1328, 1431);
                        foreach (var value in f_324_1350_1356_I(source))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 1328, 1431);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1398, 1412);

                            f_324_1398_1411(action, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(324, 1328, 1431);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 104);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 104);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 1074, 1446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1462, 1476);

                return source;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 634, 1487);

                System.ArgumentNullException
                f_324_797_838(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 797, 838);
                    return return_v;
                }


                System.ArgumentNullException
                f_324_928_969(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 928, 969);
                    return return_v;
                }


                int
                f_324_1159_1169(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 1159, 1169);
                    return return_v;
                }


                T?
                f_324_1234_1241(System.Collections.Generic.IList<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 1234, 1241);
                    return return_v;
                }


                int
                f_324_1227_1242(System.Action<T>
                this_param, T?
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 1227, 1242);
                    return 0;
                }


                int
                f_324_1398_1411(System.Action<T>
                this_param, T?
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 1398, 1411);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<T>
                f_324_1350_1356_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 1350, 1356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 634, 1487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 634, 1487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IEnumerable<T> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 1499, 1803);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1611, 1726) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 1611, 1726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1663, 1711);

                    throw f_324_1669_1710(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 1611, 1726);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1742, 1792);

                return f_324_1749_1791(f_324_1775_1790(source));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 1499, 1803);

                System.ArgumentNullException
                f_324_1669_1710(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 1669, 1710);
                    return return_v;
                }


                System.Collections.Generic.List<T>
                f_324_1775_1790(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.ToList<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 1775, 1790);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<T>
                f_324_1749_1791(System.Collections.Generic.List<T>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<T>((System.Collections.Generic.IList<T>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 1749, 1791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 1499, 1803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 1499, 1803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<T> Concat<T>(this IEnumerable<T> source, T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 1815, 2091);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1915, 2030) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 1915, 2030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 1967, 2015);

                    throw f_324_1973_2014(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 1915, 2030);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2046, 2080);

                return f_324_2053_2079(source, value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 1815, 2091);

                System.ArgumentNullException
                f_324_1973_2014(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 1973, 2014);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_324_2053_2079(System.Collections.Generic.IEnumerable<T>
                source, T?
                value)
                {
                    var return_v = source.ConcatWorker<T>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 2053, 2079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 1815, 2091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 1815, 2091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<T> ConcatWorker<T>(this IEnumerable<T> source, T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 2103, 2344);

                var listYield = new List<T>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2210, 2298);
                    foreach (var v in f_324_2228_2234_I(source))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 2210, 2298);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2268, 2283);

                        listYield.Add(v);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 2210, 2298);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 89);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 89);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2314, 2333);

                listYield.Add(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 2103, 2344);

                return listYield;

                System.Collections.Generic.IEnumerable<T>
                f_324_2228_2234_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 2228, 2234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 2103, 2344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 2103, 2344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool SetEquals<T>(this IEnumerable<T> source1, IEnumerable<T> source2, IEqualityComparer<T>? comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 2356, 2824);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2497, 2614) || true) && (source1 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 2497, 2614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2550, 2599);

                    throw f_324_2556_2598(nameof(source1));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 2497, 2614);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2630, 2747) || true) && (source2 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 2630, 2747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2683, 2732);

                    throw f_324_2689_2731(nameof(source2));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 2630, 2747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2763, 2813);

                return f_324_2770_2812(f_324_2770_2793(source1, comparer), source2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 2356, 2824);

                System.ArgumentNullException
                f_324_2556_2598(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 2556, 2598);
                    return return_v;
                }


                System.ArgumentNullException
                f_324_2689_2731(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 2689, 2731);
                    return return_v;
                }


                System.Collections.Generic.ISet<T>
                f_324_2770_2793(System.Collections.Generic.IEnumerable<T>
                source, System.Collections.Generic.IEqualityComparer<T>?
                comparer)
                {
                    var return_v = source.ToSet<T>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 2770, 2793);
                    return return_v;
                }


                bool
                f_324_2770_2812(System.Collections.Generic.ISet<T>
                this_param, System.Collections.Generic.IEnumerable<T>
                other)
                {
                    var return_v = this_param.SetEquals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 2770, 2812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 2356, 2824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 2356, 2824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool SetEquals<T>(this IEnumerable<T> source1, IEnumerable<T> source2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 2836, 3264);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2945, 3062) || true) && (source1 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 2945, 3062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 2998, 3047);

                    throw f_324_3004_3046(nameof(source1));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 2945, 3062);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 3078, 3195) || true) && (source2 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 3078, 3195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 3131, 3180);

                    throw f_324_3137_3179(nameof(source2));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 3078, 3195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 3211, 3253);

                return f_324_3218_3252(f_324_3218_3233(source1), source2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 2836, 3264);

                System.ArgumentNullException
                f_324_3004_3046(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 3004, 3046);
                    return return_v;
                }


                System.ArgumentNullException
                f_324_3137_3179(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 3137, 3179);
                    return return_v;
                }


                System.Collections.Generic.ISet<T>
                f_324_3218_3233(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.ToSet<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 3218, 3233);
                    return return_v;
                }


                bool
                f_324_3218_3252(System.Collections.Generic.ISet<T>
                this_param, System.Collections.Generic.IEnumerable<T>
                other)
                {
                    var return_v = this_param.SetEquals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 3218, 3252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 2836, 3264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 2836, 3264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISet<T> ToSet<T>(this IEnumerable<T> source, IEqualityComparer<T>? comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 3276, 3573);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 3391, 3506) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 3391, 3506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 3443, 3491);

                    throw f_324_3449_3490(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 3391, 3506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 3522, 3562);

                return f_324_3529_3561(source, comparer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 3276, 3573);

                System.ArgumentNullException
                f_324_3449_3490(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 3449, 3490);
                    return return_v;
                }


                System.Collections.Generic.HashSet<T>
                f_324_3529_3561(System.Collections.Generic.IEnumerable<T>
                collection, System.Collections.Generic.IEqualityComparer<T>?
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<T>(collection, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 3529, 3561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 3276, 3573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 3276, 3573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISet<T> ToSet<T>(this IEnumerable<T> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 3585, 3861);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 3668, 3783) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 3668, 3783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 3720, 3768);

                    throw f_324_3726_3767(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 3668, 3783);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 3799, 3850);

                return source as ISet<T> ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.ISet<T>?>(324, 3806, 3849) ?? f_324_3827_3849(source));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 3585, 3861);

                System.ArgumentNullException
                f_324_3726_3767(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 3726, 3767);
                    return return_v;
                }


                System.Collections.Generic.HashSet<T>
                f_324_3827_3849(System.Collections.Generic.IEnumerable<T>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<T>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 3827, 3849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 3585, 3861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 3585, 3861);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IReadOnlyCollection<T> ToCollection<T>(this IEnumerable<T> sequence)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(324, 3969, 4052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 3972, 4052);

                // LAFHIS
                DynAbs.Tracing.TraceSender.Conditional_F1(324, 3972, 4019);
                return (((sequence is IReadOnlyCollection<T>) && 
                    DynAbs.Tracing.TraceSender.Conditional_F2(324, 4022, 4032)) || 
                    DynAbs.Tracing.TraceSender.Conditional_F3(324, 4035, 4052)) ? 
                    (IReadOnlyCollection<T>)sequence : f_324_4035_4052(sequence); 
                
                DynAbs.Tracing.TraceSender.TraceExitMethod(324, 3969, 4052);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 3969, 4052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 3969, 4052);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.List<T>
            f_324_4035_4052(System.Collections.Generic.IEnumerable<T>
            source)
            {
                var return_v = source.ToList<T>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 4035, 4052);
                return return_v;
            }

        }

        public static T? FirstOrNull<T>(this IEnumerable<T> source)
                    where T : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 4065, 4363);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 4179, 4294) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 4179, 4294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 4231, 4279);

                    throw f_324_4237_4278(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 4179, 4294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 4310, 4352);

                return f_324_4317_4351(f_324_4317_4334(source));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 4065, 4363);

                System.ArgumentNullException
                f_324_4237_4278(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 4237, 4278);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T?>
                f_324_4317_4334(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.Cast<T?>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 4317, 4334);
                    return return_v;
                }


                T?
                f_324_4317_4351(System.Collections.Generic.IEnumerable<T?>
                source)
                {
                    var return_v = source.FirstOrDefault<T?>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 4317, 4351);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 4065, 4363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 4065, 4363);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T? FirstOrNull<T>(this IEnumerable<T> source, Func<T, bool> predicate)
                    where T : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 4375, 4722);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 4514, 4629) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 4514, 4629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 4566, 4614);

                    throw f_324_4572_4613(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 4514, 4629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 4645, 4711);

                return f_324_4652_4710(f_324_4652_4669(source), v => predicate(v!.Value));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 4375, 4722);

                System.ArgumentNullException
                f_324_4572_4613(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 4572, 4613);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T?>
                f_324_4652_4669(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.Cast<T?>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 4652, 4669);
                    return return_v;
                }


                T?
                f_324_4652_4710(System.Collections.Generic.IEnumerable<T?>
                source, System.Func<T?, bool>
                predicate)
                {
                    var return_v = source.FirstOrDefault<T?>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 4652, 4710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 4375, 4722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 4375, 4722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T? LastOrNull<T>(this IEnumerable<T> source)
                    where T : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 4734, 5030);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 4847, 4962) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 4847, 4962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 4899, 4947);

                    throw f_324_4905_4946(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 4847, 4962);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 4978, 5019);

                return f_324_4985_5018(f_324_4985_5002(source));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 4734, 5030);

                System.ArgumentNullException
                f_324_4905_4946(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 4905, 4946);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T?>
                f_324_4985_5002(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.Cast<T?>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 4985, 5002);
                    return return_v;
                }


                T?
                f_324_4985_5018(System.Collections.Generic.IEnumerable<T?>
                source)
                {
                    var return_v = source.LastOrDefault<T?>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 4985, 5018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 4734, 5030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 4734, 5030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T? SingleOrNull<T>(this IEnumerable<T> source, Func<T, bool> predicate)
                    where T : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 5042, 5391);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 5182, 5297) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 5182, 5297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 5234, 5282);

                    throw f_324_5240_5281(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 5182, 5297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 5313, 5380);

                return f_324_5320_5379(f_324_5320_5337(source), v => predicate(v!.Value));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 5042, 5391);

                System.ArgumentNullException
                f_324_5240_5281(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 5240, 5281);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T?>
                f_324_5320_5337(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.Cast<T?>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 5320, 5337);
                    return return_v;
                }


                T?
                f_324_5320_5379(System.Collections.Generic.IEnumerable<T?>
                source, System.Func<T?, bool>
                predicate)
                {
                    var return_v = source.SingleOrDefault<T?>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 5320, 5379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 5042, 5391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 5042, 5391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsSingle<T>(this IEnumerable<T> list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 5403, 5608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 5484, 5528);

                using var
                enumerator = f_324_5507_5527(list)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 5542, 5597);

                return f_324_5549_5570(enumerator) && (DynAbs.Tracing.TraceSender.Expression_True(324, 5549, 5596) && !f_324_5575_5596(enumerator));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 5403, 5608);

                System.Collections.Generic.IEnumerator<T>
                f_324_5507_5527(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 5507, 5527);
                    return return_v;
                }


                bool
                f_324_5549_5570(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 5549, 5570);
                    return return_v;
                }


                bool
                f_324_5575_5596(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 5575, 5596);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 5403, 5608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 5403, 5608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 5620, 6373);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 5702, 5843) || true) && (source is IReadOnlyCollection<T> readOnlyCollection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 5702, 5843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 5791, 5828);

                    return f_324_5798_5822(readOnlyCollection) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 5702, 5843);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 5859, 5990) || true) && (source is ICollection<T> genericCollection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 5859, 5990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 5939, 5975);

                    return f_324_5946_5969(genericCollection) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 5859, 5990);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 6006, 6120) || true) && (source is ICollection collection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 6006, 6120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 6076, 6105);

                    return f_324_6083_6099(collection) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 6006, 6120);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 6136, 6232) || true) && (source is string str)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 6136, 6232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 6194, 6217);

                    return f_324_6201_6211(str) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 6136, 6232);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 6248, 6334);
                    foreach (var _ in f_324_6266_6272_I(source))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 6248, 6334);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 6306, 6319);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 6248, 6334);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 87);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 87);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 6350, 6362);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 5620, 6373);

                int
                f_324_5798_5822(System.Collections.Generic.IReadOnlyCollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 5798, 5822);
                    return return_v;
                }


                int
                f_324_5946_5969(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 5946, 5969);
                    return return_v;
                }


                int
                f_324_6083_6099(System.Collections.ICollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 6083, 6099);
                    return return_v;
                }


                int
                f_324_6201_6211(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 6201, 6211);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_324_6266_6272_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 6266, 6272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 5620, 6373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 5620, 6373);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsEmpty<T>(this IReadOnlyCollection<T> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 6385, 6511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 6475, 6500);

                return f_324_6482_6494(source) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 6385, 6511);

                int
                f_324_6482_6494(System.Collections.Generic.IReadOnlyCollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 6482, 6494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 6385, 6511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 6385, 6511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsEmpty<T>(this ICollection<T> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 6523, 6641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 6605, 6630);

                return f_324_6612_6624(source) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 6523, 6641);

                int
                f_324_6612_6624(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 6612, 6624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 6523, 6641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 6523, 6641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsEmpty(this string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 6653, 6761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 6724, 6750);

                return f_324_6731_6744(source) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 6653, 6761);

                int
                f_324_6731_6744(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 6731, 6744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 6653, 6761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 6653, 6761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsEmpty<T>(this T[] source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 6983, 7091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 7054, 7080);

                return f_324_7061_7074(source) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 6983, 7091);

                int
                f_324_7061_7074(T[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 7061, 7074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 6983, 7091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 6983, 7091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsEmpty<T>(this List<T> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 7313, 7424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 7388, 7413);

                return f_324_7395_7407(source) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 7313, 7424);

                int
                f_324_7395_7407(System.Collections.Generic.List<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 7395, 7407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 7313, 7424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 7313, 7424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Func<object, bool> s_notNullTest;

        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source)
                    where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 7522, 7846);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 7649, 7767) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 7649, 7767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 7701, 7752);

                    return f_324_7708_7751();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 7649, 7767);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 7783, 7835);

                return f_324_7790_7833(source, (Func<T, bool>)s_notNullTest)!;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 7522, 7846);

                System.Collections.Generic.IEnumerable<T>
                f_324_7708_7751()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 7708, 7751);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_324_7790_7833<T>(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, bool>
                predicate)
                {
                    var return_v = source.Where<T>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 7790, 7833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 7522, 7846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 7522, 7846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T[] AsArray<T>(this IEnumerable<T> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(324, 7928, 7964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 7931, 7964);
                return source as T[] ?? (DynAbs.Tracing.TraceSender.Expression_Null<T[]?>(324, 7931, 7964) ?? f_324_7948_7964(source)); DynAbs.Tracing.TraceSender.TraceExitMethod(324, 7928, 7964);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 7928, 7964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 7928, 7964);
            }
            throw new System.Exception("Slicer error: unreachable code");

            T[]
            f_324_7948_7964(System.Collections.Generic.IEnumerable<T>
            source)
            {
                var return_v = source.ToArray<T>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 7948, 7964);
                return return_v;
            }

        }

        public static ImmutableArray<TResult> SelectAsArray<TSource, TResult>(this IEnumerable<TSource>? source, Func<TSource, TResult> selector)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 7977, 8428);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8139, 8243) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 8139, 8243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8191, 8228);

                    return ImmutableArray<TResult>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 8139, 8243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8259, 8309);

                var
                builder = f_324_8273_8308()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8323, 8365);

                f_324_8323_8364(builder, f_324_8340_8363(source, selector));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8381, 8417);

                return f_324_8388_8416(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 7977, 8428);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                f_324_8273_8308()
                {
                    var return_v = ArrayBuilder<TResult>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 8273, 8308);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TResult>
                f_324_8340_8363(System.Collections.Generic.IEnumerable<TSource>
                source, System.Func<TSource, TResult>
                selector)
                {
                    var return_v = source.Select<TSource, TResult>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 8340, 8363);
                    return return_v;
                }


                int
                f_324_8323_8364(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param, System.Collections.Generic.IEnumerable<TResult>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 8323, 8364);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TResult>
                f_324_8388_8416(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TResult>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 8388, 8416);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 7977, 8428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 7977, 8428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool All(this IEnumerable<bool> source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 8440, 8841);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8518, 8633) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 8518, 8633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8570, 8618);

                    throw f_324_8576_8617(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 8518, 8633);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8649, 8802);
                    foreach (var b in f_324_8667_8673_I(source))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 8649, 8802);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8707, 8787) || true) && (!b)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 8707, 8787);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8755, 8768);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(324, 8707, 8787);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 8649, 8802);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8818, 8830);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 8440, 8841);

                System.ArgumentNullException
                f_324_8576_8617(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 8576, 8617);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<bool>
                f_324_8667_8673_I(System.Collections.Generic.IEnumerable<bool>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 8667, 8673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 8440, 8841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 8440, 8841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int IndexOf<T>(this IEnumerable<T> sequence, T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 8853, 9260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 8945, 9249);

                return sequence switch
                {
                    IList<T> list when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9000, 9036) && DynAbs.Tracing.TraceSender.Expression_True(324, 9000, 9036))
    => f_324_9017_9036(list, value),
                    IReadOnlyList<T> readOnlyList when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9055, 9145) && DynAbs.Tracing.TraceSender.Expression_True(324, 9055, 9145))
    => f_324_9088_9145(readOnlyList, value, f_324_9117_9144()),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9164, 9233) && DynAbs.Tracing.TraceSender.Expression_True(324, 9164, 9233))
    => f_324_9169_9233(sequence, value, f_324_9205_9232())
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 8853, 9260);

                int
                f_324_9017_9036(System.Collections.Generic.IList<T>
                this_param, T?
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 9017, 9036);
                    return return_v;
                }


                System.Collections.Generic.EqualityComparer<T>
                f_324_9117_9144()
                {
                    var return_v = EqualityComparer<T>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 9117, 9144);
                    return return_v;
                }


                int
                f_324_9088_9145(System.Collections.Generic.IReadOnlyList<T>
                list, T?
                value, System.Collections.Generic.EqualityComparer<T>
                comparer)
                {
                    var return_v = list.IndexOf<T>(value, (System.Collections.Generic.IEqualityComparer<T>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 9088, 9145);
                    return return_v;
                }


                System.Collections.Generic.EqualityComparer<T>
                f_324_9205_9232()
                {
                    var return_v = EqualityComparer<T>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 9205, 9232);
                    return return_v;
                }


                int
                f_324_9169_9233(System.Collections.Generic.IEnumerable<T>
                sequence, T?
                value, System.Collections.Generic.EqualityComparer<T>
                comparer)
                {
                    var return_v = sequence.EnumeratingIndexOf<T>(value, (System.Collections.Generic.IEqualityComparer<T>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 9169, 9233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 8853, 9260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 8853, 9260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int IndexOf<T>(this IEnumerable<T> sequence, T value, IEqualityComparer<T> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 9272, 9617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9395, 9606);

                return sequence switch
                {
                    IReadOnlyList<T> readOnlyList when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9450, 9521) && DynAbs.Tracing.TraceSender.Expression_True(324, 9450, 9521))
    => f_324_9483_9521(readOnlyList, value, comparer),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9540, 9590) && DynAbs.Tracing.TraceSender.Expression_True(324, 9540, 9590))
    => f_324_9545_9590(sequence, value, comparer)
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 9272, 9617);

                int
                f_324_9483_9521(System.Collections.Generic.IReadOnlyList<T>
                list, T?
                value, System.Collections.Generic.IEqualityComparer<T>
                comparer)
                {
                    var return_v = list.IndexOf<T>(value, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 9483, 9521);
                    return return_v;
                }


                int
                f_324_9545_9590(System.Collections.Generic.IEnumerable<T>
                sequence, T?
                value, System.Collections.Generic.IEqualityComparer<T>
                comparer)
                {
                    var return_v = sequence.EnumeratingIndexOf<T>(value, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 9545, 9590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 9272, 9617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 9272, 9617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int EnumeratingIndexOf<T>(this IEnumerable<T> sequence, T value, IEqualityComparer<T> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 9629, 10029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9764, 9774);

                int
                i = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9788, 9992);
                    foreach (var item in f_324_9809_9817_I(sequence))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 9788, 9992);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9851, 9953) || true) && (f_324_9855_9883(comparer, item, value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 9851, 9953);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9925, 9934);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(324, 9851, 9953);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 9973, 9977);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 9788, 9992);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10008, 10018);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 9629, 10029);

                bool
                f_324_9855_9883(System.Collections.Generic.IEqualityComparer<T>
                this_param, T?
                x, T?
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 9855, 9883);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_324_9809_9817_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 9809, 9817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 9629, 10029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 9629, 10029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int IndexOf<T>(this IReadOnlyList<T> list, T value, IEqualityComparer<T> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 10041, 10405);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10171, 10176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10178, 10197);
                    for (int
        i = 0
        ,
        length = f_324_10187_10197(list)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10162, 10368) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10211, 10214)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(324, 10162, 10368))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 10162, 10368);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10248, 10353) || true) && (f_324_10252_10283(comparer, f_324_10268_10275(list, i), value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 10248, 10353);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10325, 10334);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(324, 10248, 10353);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 207);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10384, 10394);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 10041, 10405);

                int
                f_324_10187_10197(System.Collections.Generic.IReadOnlyList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 10187, 10197);
                    return return_v;
                }


                T?
                f_324_10268_10275(System.Collections.Generic.IReadOnlyList<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 10268, 10275);
                    return return_v;
                }


                bool
                f_324_10252_10283(System.Collections.Generic.IEqualityComparer<T>
                this_param, T?
                x, T?
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 10252, 10283);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 10041, 10405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 10041, 10405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> sequence)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 10417, 10705);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10524, 10643) || true) && (sequence == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 10524, 10643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10578, 10628);

                    throw f_324_10584_10627(nameof(sequence));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 10524, 10643);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10659, 10694);

                return f_324_10666_10693(sequence, s => s);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 10417, 10705);

                System.ArgumentNullException
                f_324_10584_10627(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 10584, 10627);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_324_10666_10693(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>>
                source, System.Func<System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IEnumerable<T>>
                selector)
                {
                    var return_v = source.SelectMany<System.Collections.Generic.IEnumerable<T>, T>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 10666, 10693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 10417, 10705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 10417, 10705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IOrderedEnumerable<T> OrderBy<T>(this IEnumerable<T> source, IComparer<T>? comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 10717, 10906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 10840, 10895);

                return f_324_10847_10894(source, Functions<T>.Identity, comparer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 10717, 10906);

                System.Linq.IOrderedEnumerable<T>
                f_324_10847_10894(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, T>
                keySelector, System.Collections.Generic.IComparer<T>?
                comparer)
                {
                    var return_v = source.OrderBy<T, T>(keySelector, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 10847, 10894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 10717, 10906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 10717, 10906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IOrderedEnumerable<T> OrderByDescending<T>(this IEnumerable<T> source, IComparer<T>? comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 10918, 11127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 11051, 11116);

                return f_324_11058_11115(source, Functions<T>.Identity, comparer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 10918, 11127);

                System.Linq.IOrderedEnumerable<T>
                f_324_11058_11115(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, T>
                keySelector, System.Collections.Generic.IComparer<T>?
                comparer)
                {
                    var return_v = source.OrderByDescending<T, T>(keySelector, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 11058, 11115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 10918, 11127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 10918, 11127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IOrderedEnumerable<T> OrderBy<T>(this IEnumerable<T> source, Comparison<T> compare)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 11139, 11323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 11261, 11312);

                return f_324_11268_11311(source, f_324_11283_11310(compare));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 11139, 11323);

                System.Collections.Generic.Comparer<T>
                f_324_11283_11310(System.Comparison<T>
                comparison)
                {
                    var return_v = Comparer<T>.Create(comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 11283, 11310);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<T>
                f_324_11268_11311(System.Collections.Generic.IEnumerable<T>
                source, System.Collections.Generic.Comparer<T>
                comparer)
                {
                    var return_v = source.OrderBy<T>((System.Collections.Generic.IComparer<T>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 11268, 11311);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 11139, 11323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 11139, 11323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IOrderedEnumerable<T> OrderByDescending<T>(this IEnumerable<T> source, Comparison<T> compare)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 11335, 11539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 11467, 11528);

                return f_324_11474_11527(source, f_324_11499_11526(compare));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 11335, 11539);

                System.Collections.Generic.Comparer<T>
                f_324_11499_11526(System.Comparison<T>
                comparison)
                {
                    var return_v = Comparer<T>.Create(comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 11499, 11526);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<T>
                f_324_11474_11527(System.Collections.Generic.IEnumerable<T>
                source, System.Collections.Generic.Comparer<T>
                comparer)
                {
                    var return_v = source.OrderByDescending<T>((System.Collections.Generic.IComparer<T>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 11474, 11527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 11335, 11539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 11335, 11539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IOrderedEnumerable<T> Order<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 11551, 11731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 11673, 11720);

                return f_324_11680_11719(source, Comparisons<T>.Comparer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 11551, 11731);

                System.Linq.IOrderedEnumerable<T>
                f_324_11680_11719(System.Collections.Generic.IEnumerable<T>
                source, System.Collections.Generic.IComparer<T>
                comparer)
                {
                    var return_v = source.OrderBy<T>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 11680, 11719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 11551, 11731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 11551, 11731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IOrderedEnumerable<T> ThenBy<T>(this IOrderedEnumerable<T> source, IComparer<T>? comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 11743, 11937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 11872, 11926);

                return f_324_11879_11925(source, Functions<T>.Identity, comparer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 11743, 11937);

                System.Linq.IOrderedEnumerable<T>
                f_324_11879_11925(System.Linq.IOrderedEnumerable<T>
                source, System.Func<T, T>
                keySelector, System.Collections.Generic.IComparer<T>?
                comparer)
                {
                    var return_v = source.ThenBy<T, T>(keySelector, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 11879, 11925);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 11743, 11937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 11743, 11937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IOrderedEnumerable<T> ThenBy<T>(this IOrderedEnumerable<T> source, Comparison<T> compare)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 11949, 12138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 12077, 12127);

                return f_324_12084_12126(source, f_324_12098_12125(compare));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 11949, 12138);

                System.Collections.Generic.Comparer<T>
                f_324_12098_12125(System.Comparison<T>
                comparison)
                {
                    var return_v = Comparer<T>.Create(comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 12098, 12125);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<T>
                f_324_12084_12126(System.Linq.IOrderedEnumerable<T>
                source, System.Collections.Generic.Comparer<T>
                comparer)
                {
                    var return_v = source.ThenBy<T>((System.Collections.Generic.IComparer<T>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 12084, 12126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 11949, 12138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 11949, 12138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IOrderedEnumerable<T> ThenBy<T>(this IOrderedEnumerable<T> source) where T : IComparable<T>
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 12150, 12337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 12280, 12326);

                return f_324_12287_12325(source, Comparisons<T>.Comparer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 12150, 12337);

                System.Linq.IOrderedEnumerable<T>
                f_324_12287_12325(System.Linq.IOrderedEnumerable<T>
                source, System.Collections.Generic.IComparer<T>
                comparer)
                {
                    var return_v = source.ThenBy<T>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 12287, 12325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 12150, 12337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 12150, 12337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private static class Comparisons<T> where T : IComparable<T>
        {
            public static readonly Comparison<T> CompareTo;

            public static readonly IComparer<T> Comparer;

            static Comparisons()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(324, 12349, 12616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 12471, 12511);
                CompareTo = (t1, t2) => t1.CompareTo(t2); DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 12564, 12604);
                Comparer = f_324_12575_12604<T>(CompareTo); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(324, 12349, 12616);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 12349, 12616);
            }


            static System.Collections.Generic.Comparer<T>
            f_324_12575_12604<T>(System.Comparison<T>
            comparison)
            {
                var return_v = Comparer<T>.Create(comparison);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 12575, 12604);
                return return_v;
            }

        }

        public static bool IsSorted<T>(this IEnumerable<T> enumerable, IComparer<T> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 12628, 13193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 12738, 12779);

                using var
                e = f_324_12752_12778(enumerable)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 12793, 12871) || true) && (!f_324_12798_12810(e))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 12793, 12871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 12844, 12856);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 12793, 12871);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 12887, 12912);

                var
                previous = f_324_12902_12911(e)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 12926, 13154) || true) && (f_324_12933_12945(e))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 12926, 13154);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 12979, 13098) || true) && (f_324_12983_13020(comparer, previous, f_324_13010_13019(e)) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 12979, 13098);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 13066, 13079);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(324, 12979, 13098);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 13118, 13139);

                        previous = f_324_13129_13138(e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 12926, 13154);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 12926, 13154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(324, 12926, 13154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 13170, 13182);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 12628, 13193);

                System.Collections.Generic.IEnumerator<T>
                f_324_12752_12778(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 12752, 12778);
                    return return_v;
                }


                bool
                f_324_12798_12810(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 12798, 12810);
                    return return_v;
                }


                T?
                f_324_12902_12911(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 12902, 12911);
                    return return_v;
                }


                bool
                f_324_12933_12945(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 12933, 12945);
                    return return_v;
                }


                T?
                f_324_13010_13019(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 13010, 13019);
                    return return_v;
                }


                int
                f_324_12983_13020(System.Collections.Generic.IComparer<T>
                this_param, T?
                x, T?
                y)
                {
                    var return_v = this_param.Compare(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 12983, 13020);
                    return return_v;
                }


                T?
                f_324_13129_13138(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 13129, 13138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 12628, 13193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 12628, 13193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Contains<T>(this IEnumerable<T> sequence, Func<T, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 13205, 13357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 13315, 13346);

                return f_324_13322_13345(sequence, predicate);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 13205, 13357);

                bool
                f_324_13322_13345(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, bool>
                predicate)
                {
                    var return_v = source.Any<T>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 13322, 13345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 13205, 13357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 13205, 13357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Contains(this IEnumerable<string?> sequence, string? s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 13369, 13672);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 13468, 13632);
                    foreach (var item in f_324_13489_13497_I(sequence))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 13468, 13632);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 13531, 13617) || true) && (item == s)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 13531, 13617);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 13586, 13598);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(324, 13531, 13617);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 13468, 13632);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 13648, 13661);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 13369, 13672);

                System.Collections.Generic.IEnumerable<string?>
                f_324_13489_13497_I(System.Collections.Generic.IEnumerable<string?>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 13489, 13497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 13369, 13672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 13369, 13672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IComparer<T> ToComparer<T>(this Comparison<T> comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 13684, 13829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 13780, 13818);

                return f_324_13787_13817(comparison);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 13684, 13829);

                System.Collections.Generic.Comparer<T>
                f_324_13787_13817(System.Comparison<T>
                comparison)
                {
                    var return_v = Comparer<T>.Create(comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 13787, 13817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 13684, 13829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 13684, 13829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableDictionary<K, V> ToImmutableDictionaryOrEmpty<K, V>(this IEnumerable<KeyValuePair<K, V>>? items)
                    where K : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 13841, 14197);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 14016, 14124) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 14016, 14124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 14067, 14109);

                    return f_324_14074_14108();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 14016, 14124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 14140, 14186);

                return f_324_14147_14185(items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 13841, 14197);

                System.Collections.Immutable.ImmutableDictionary<K, V>
                f_324_14074_14108()
                {
                    var return_v = ImmutableDictionary.Create<K, V>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 14074, 14108);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<K, V>
                f_324_14147_14185(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K, V>>
                items)
                {
                    var return_v = ImmutableDictionary.CreateRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 14147, 14185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 13841, 14197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 13841, 14197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableDictionary<K, V> ToImmutableDictionaryOrEmpty<K, V>(this IEnumerable<KeyValuePair<K, V>>? items, IEqualityComparer<K>? keyComparer)
                    where K : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 14209, 14624);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 14419, 14538) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 14419, 14538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 14470, 14523);

                    return f_324_14477_14522(keyComparer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 14419, 14538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 14554, 14613);

                return f_324_14561_14612(keyComparer, items);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 14209, 14624);

                System.Collections.Immutable.ImmutableDictionary<K, V>
                f_324_14477_14522(System.Collections.Generic.IEqualityComparer<K>?
                keyComparer)
                {
                    var return_v = ImmutableDictionary.Create<K, V>(keyComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 14477, 14522);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<K, V>
                f_324_14561_14612(System.Collections.Generic.IEqualityComparer<K>?
                keyComparer, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K, V>>
                items)
                {
                    var return_v = ImmutableDictionary.CreateRange(keyComparer, items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 14561, 14612);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 14209, 14624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 14209, 14624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IList<IList<T>> Transpose<T>(this IEnumerable<IEnumerable<T>> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 14733, 15021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 14852, 14885);

                var
                count = f_324_14864_14884(f_324_14864_14876(data))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 14899, 14947);

                f_324_14899_14946(f_324_14912_14945(data, d => d.Count() == count));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 14969, 15010);

                return f_324_14976_15009(f_324_14976_14999(data));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 14733, 15021);

                System.Collections.Generic.IEnumerable<T>
                f_324_14864_14876(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>>
                source)
                {
                    var return_v = source.First<System.Collections.Generic.IEnumerable<T>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 14864, 14876);
                    return return_v;
                }


                int
                f_324_14864_14884(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.Count<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 14864, 14884);
                    return return_v;
                }


                bool
                f_324_14912_14945(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>>
                source, System.Func<System.Collections.Generic.IEnumerable<T>, bool>
                predicate)
                {
                    var return_v = source.All<System.Collections.Generic.IEnumerable<T>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 14912, 14945);
                    return return_v;
                }


                int
                f_324_14899_14946(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 14899, 14946);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.IList<T>>
                f_324_14976_14999(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>>
                data)
                {
                    var return_v = data.TransposeInternal<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 14976, 14999);
                    return return_v;
                }


                System.Collections.Generic.IList<T>[]
                f_324_14976_15009(System.Collections.Generic.IEnumerable<System.Collections.Generic.IList<T>>
                source)
                {
                    var return_v = source.ToArray<System.Collections.Generic.IList<T>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 14976, 15009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 14733, 15021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 14733, 15021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<IList<T>> TransposeInternal<T>(this IEnumerable<IEnumerable<T>> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 15033, 16277);

                var listYield = new List<IList<T>>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15154, 15216);

                List<IEnumerator<T>>
                enumerators = f_324_15189_15215()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15232, 15246);

                var
                width = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15260, 15395);
                    foreach (var e in f_324_15278_15282_I(data))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 15260, 15395);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15316, 15351);

                        f_324_15316_15350(enumerators, f_324_15332_15349(e));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15369, 15380);

                        width += 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 15260, 15395);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 136);
                }
                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15447, 16062) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 15447, 16062);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15500, 15516);

                            T[]
                            line = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15547, 15552);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15538, 16001) || true) && (i < width)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15565, 15568)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(324, 15538, 16001))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 15538, 16001);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15618, 15641);

                                    var
                                    e = f_324_15626_15640(enumerators, i)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15667, 15781) || true) && (!f_324_15672_15684(e))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 15667, 15781);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15742, 15754);

                                        return listYield;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 15667, 15781);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15809, 15930) || true) && (line == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 15809, 15930);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15883, 15903);

                                        line = new T[width];
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 15809, 15930);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 15958, 15978);

                                    line[i] = f_324_15968_15977(e);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 464);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 464);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 16025, 16043);

                            listYield.Add(line);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(324, 15447, 16062);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 15447, 16062);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(324, 15447, 16062);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(324, 16091, 16266);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 16131, 16251);
                        foreach (var enumerator in f_324_16158_16169_I(enumerators))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 16131, 16251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 16211, 16232);

                            f_324_16211_16231(enumerator);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(324, 16131, 16251);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 121);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 121);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(324, 16091, 16266);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 15033, 16277);

                return listYield;

                System.Collections.Generic.List<System.Collections.Generic.IEnumerator<T>>
                f_324_15189_15215()
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Generic.IEnumerator<T>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 15189, 15215);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_324_15332_15349(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 15332, 15349);
                    return return_v;
                }


                int
                f_324_15316_15350(System.Collections.Generic.List<System.Collections.Generic.IEnumerator<T>>
                this_param, System.Collections.Generic.IEnumerator<T>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 15316, 15350);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>>
                f_324_15278_15282_I(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 15278, 15282);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_324_15626_15640(System.Collections.Generic.List<System.Collections.Generic.IEnumerator<T>>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 15626, 15640);
                    return return_v;
                }


                bool
                f_324_15672_15684(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 15672, 15684);
                    return return_v;
                }


                T
                f_324_15968_15977(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 15968, 15977);
                    return return_v;
                }


                int
                f_324_16211_16231(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 16211, 16231);
                    return 0;
                }


                System.Collections.Generic.List<System.Collections.Generic.IEnumerator<T>>
                f_324_16158_16169_I(System.Collections.Generic.List<System.Collections.Generic.IEnumerator<T>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 16158, 16169);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 15033, 16277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 15033, 16277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Dictionary<K, ImmutableArray<T>> ToDictionary<K, T>(this IEnumerable<T> data, Func<T, K> keySelector, IEqualityComparer<K>? comparer = null)
                    where K : notnull
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 16307, 16874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 16519, 16583);

                var
                dictionary = f_324_16536_16582(comparer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 16597, 16646);

                var
                groups = f_324_16610_16645(data, keySelector, comparer)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 16660, 16829);
                    foreach (var grouping in f_324_16685_16691_I(groups))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 16660, 16829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 16725, 16760);

                        var
                        items = f_324_16737_16759(grouping)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 16778, 16814);

                        f_324_16778_16813(dictionary, f_324_16793_16805(grouping), items);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 16660, 16829);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(324, 1, 170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 16845, 16863);

                return dictionary;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 16307, 16874);

                System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>
                f_324_16536_16582(System.Collections.Generic.IEqualityComparer<K>?
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 16536, 16582);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<K, T>>
                f_324_16610_16645(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, K>
                keySelector, System.Collections.Generic.IEqualityComparer<K>?
                comparer)
                {
                    var return_v = source.GroupBy<T, K>(keySelector, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 16610, 16645);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_324_16737_16759(System.Linq.IGrouping<K, T>
                items)
                {
                    var return_v = items.AsImmutable<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 16737, 16759);
                    return return_v;
                }


                K
                f_324_16793_16805(System.Linq.IGrouping<K, T>
                this_param)
                {
                    var return_v = this_param.Key;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 16793, 16805);
                    return return_v;
                }


                int
                f_324_16778_16813(System.Collections.Generic.Dictionary<K, System.Collections.Immutable.ImmutableArray<T>>
                this_param, K
                key, System.Collections.Immutable.ImmutableArray<T>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 16778, 16813);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<K, T>>
                f_324_16685_16691_I(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<K, T>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 16685, 16691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 16307, 16874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 16307, 16874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TSource? AsSingleton<TSource>(this IEnumerable<TSource>? source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 17205, 17878);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17310, 17392) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 17310, 17392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17362, 17377);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 17310, 17392);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17408, 17535) || true) && (source is IList<TSource> list)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 17408, 17535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17475, 17520);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(324, 17482, 17499) || (((f_324_17483_17493(list) == 1) && DynAbs.Tracing.TraceSender.Conditional_F2(324, 17502, 17509)) || DynAbs.Tracing.TraceSender.Conditional_F3(324, 17512, 17519))) ? f_324_17502_17509(list, 0) : default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 17408, 17535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17551, 17605);

                using IEnumerator<TSource>
                e = f_324_17582_17604(source)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17619, 17700) || true) && (!f_324_17624_17636(e))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 17619, 17700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17670, 17685);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 17619, 17700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17716, 17743);

                TSource
                result = f_324_17733_17742(e)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17757, 17837) || true) && (f_324_17761_17773(e))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 17757, 17837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17807, 17822);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 17757, 17837);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 17853, 17867);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 17205, 17878);

                int
                f_324_17483_17493(System.Collections.Generic.IList<TSource>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 17483, 17493);
                    return return_v;
                }


                TSource?
                f_324_17502_17509(System.Collections.Generic.IList<TSource>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 17502, 17509);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<TSource>
                f_324_17582_17604(System.Collections.Generic.IEnumerable<TSource>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 17582, 17604);
                    return return_v;
                }


                bool
                f_324_17624_17636(System.Collections.Generic.IEnumerator<TSource>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 17624, 17636);
                    return return_v;
                }


                TSource?
                f_324_17733_17742(System.Collections.Generic.IEnumerator<TSource>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 17733, 17742);
                    return return_v;
                }


                bool
                f_324_17761_17773(System.Collections.Generic.IEnumerator<TSource>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 17761, 17773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 17205, 17878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 17205, 17878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnumerableExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(324, 567, 17885);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 7479, 7509);
            s_notNullTest = x => x != null; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(324, 567, 17885);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 567, 17885);
        }

    }
    internal static class Functions<T>
    {
        public static readonly Func<T, T> Identity;

        public static readonly Func<T, bool> True;

        static Functions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(324, 18027, 18201);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 18112, 18129);
            Identity = t => t; DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 18177, 18193);
            True = t => true; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(324, 18027, 18201);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 18027, 18201);
        }

    }
    internal static class Predicates<T>
    {
        public static readonly Predicate<T> True;

        static Predicates()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(324, 18343, 18455);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 18431, 18447);
            True = t => true; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(324, 18343, 18455);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 18343, 18455);
        }

    }
}

namespace System.Linq
{
    internal static class EnumerableExtensions
    {
        public static bool SequenceEqual<T>(this IEnumerable<T>? first, IEnumerable<T>? second, Func<T, T, bool> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 18936, 19908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19075, 19112);

                f_324_19075_19111(comparer != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19128, 19208) || true) && (first == second)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 19128, 19208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19181, 19193);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 19128, 19208);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19224, 19321) || true) && (first == null || (DynAbs.Tracing.TraceSender.Expression_False(324, 19228, 19259) || second == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 19224, 19321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19293, 19306);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 19224, 19321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19337, 19869);
                using (var
                enumerator = f_324_19361_19382(first)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19397, 19869);
                    using (var
                    enumerator2 = f_324_19422_19444(second)
                    )
                    {
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19478, 19734) || true) && (f_324_19485_19506(enumerator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 19478, 19734);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19548, 19715) || true) && (!f_324_19553_19575(enumerator2) || (DynAbs.Tracing.TraceSender.Expression_False(324, 19552, 19629) || !f_324_19580_19629(comparer, f_324_19589_19607(enumerator), f_324_19609_19628(enumerator2))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 19548, 19715);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19679, 19692);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(324, 19548, 19715);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(324, 19478, 19734);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 19478, 19734);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(324, 19478, 19734);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19754, 19854) || true) && (f_324_19758_19780(enumerator2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 19754, 19854);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19822, 19835);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(324, 19754, 19854);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(324, 19397, 19869);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(324, 19337, 19869);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 19885, 19897);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 18936, 19908);

                int
                f_324_19075_19111(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 19075, 19111);
                    return 0;
                }


                System.Collections.Generic.IEnumerator<T>
                f_324_19361_19382(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 19361, 19382);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_324_19422_19444(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 19422, 19444);
                    return return_v;
                }


                bool
                f_324_19485_19506(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 19485, 19506);
                    return return_v;
                }


                bool
                f_324_19553_19575(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 19553, 19575);
                    return return_v;
                }


                T?
                f_324_19589_19607(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 19589, 19607);
                    return return_v;
                }


                T?
                f_324_19609_19628(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 19609, 19628);
                    return return_v;
                }


                bool
                f_324_19580_19629(System.Func<T, T, bool>
                this_param, T?
                arg1, T?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 19580, 19629);
                    return return_v;
                }


                bool
                f_324_19758_19780(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 19758, 19780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 18936, 19908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 18936, 19908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T? AggregateOrDefault<T>(this IEnumerable<T> source, Func<T, T, T> func)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(324, 19920, 20429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 20031, 20418);
                using (var
                e = f_324_20046_20068(source)
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 20102, 20195) || true) && (!f_324_20107_20119(e))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 20102, 20195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 20161, 20176);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(324, 20102, 20195);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 20215, 20238);

                    var
                    result = f_324_20228_20237(e)
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 20256, 20369) || true) && (f_324_20263_20275(e))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(324, 20256, 20369);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 20317, 20350);

                            result = f_324_20326_20349(func, result, f_324_20339_20348(e));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(324, 20256, 20369);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(324, 20256, 20369);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(324, 20256, 20369);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(324, 20389, 20403);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(324, 20031, 20418);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(324, 19920, 20429);

                System.Collections.Generic.IEnumerator<T>
                f_324_20046_20068(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 20046, 20068);
                    return return_v;
                }


                bool
                f_324_20107_20119(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 20107, 20119);
                    return return_v;
                }


                T?
                f_324_20228_20237(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 20228, 20237);
                    return return_v;
                }


                bool
                f_324_20263_20275(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 20263, 20275);
                    return return_v;
                }


                T?
                f_324_20339_20348(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(324, 20339, 20348);
                    return return_v;
                }


                T
                f_324_20326_20349(System.Func<T, T, T>
                this_param, T?
                arg1, T?
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(324, 20326, 20349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(324, 19920, 20429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 19920, 20429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnumerableExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(324, 18877, 20436);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(324, 18877, 20436);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(324, 18877, 20436);
        }

    }
}
