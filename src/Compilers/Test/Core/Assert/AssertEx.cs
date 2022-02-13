// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using DiffPlex;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Roslyn.Test.Utilities
{
    public static class AssertEx
    {
        private class AssertEqualityComparer<T> : IEqualityComparer<T>
        {
            private static readonly IEqualityComparer<T> s_instance;

            private static bool CanBeNull()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 1123, 1396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 1187, 1208);

                    var
                    type = typeof(T)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 1226, 1381);

                    return f_25000_1233_1264_M(!f_25000_1234_1252(type).IsValueType) || (DynAbs.Tracing.TraceSender.Expression_False(25000, 1233, 1380) || (f_25000_1290_1322(f_25000_1290_1308(type)) && (DynAbs.Tracing.TraceSender.Expression_True(25000, 1290, 1379) && f_25000_1326_1357(type) == typeof(Nullable<>))));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 1123, 1396);

                    System.Reflection.TypeInfo
                    f_25000_1234_1252(System.Type
                    type)
                    {
                        var return_v = type.GetTypeInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 1234, 1252);
                        return return_v;
                    }


                    bool
                    f_25000_1233_1264_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 1233, 1264);
                        return return_v;
                    }


                    System.Reflection.TypeInfo
                    f_25000_1290_1308(System.Type
                    type)
                    {
                        var return_v = type.GetTypeInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 1290, 1308);
                        return return_v;
                    }


                    bool
                    f_25000_1290_1322(System.Reflection.TypeInfo
                    this_param)
                    {
                        var return_v = this_param.IsGenericType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 1290, 1322);
                        return return_v;
                    }


                    System.Type
                    f_25000_1326_1357(System.Type
                    this_param)
                    {
                        var return_v = this_param.GetGenericTypeDefinition();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 1326, 1357);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 1123, 1396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 1123, 1396);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static bool IsNull(T @object)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 1412, 1648);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 1481, 1571) || true) && (!f_25000_1486_1497())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 1481, 1571);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 1539, 1552);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 1481, 1571);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 1591, 1633);

                    return f_25000_1598_1632(@object, default(T));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 1412, 1648);

                    bool
                    f_25000_1486_1497()
                    {
                        var return_v = CanBeNull();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 1486, 1497);
                        return return_v;
                    }


                    bool
                    f_25000_1598_1632(T
                    objA, T?
                    objB)
                    {
                        var return_v = object.Equals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 1598, 1632);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 1412, 1648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 1412, 1648);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static bool Equals(T left, T right)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 1664, 1792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 1739, 1777);

                    return f_25000_1746_1776(s_instance, left, right);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 1664, 1792);

                    bool
                    f_25000_1746_1776(System.Collections.Generic.IEqualityComparer<T>
                    this_param, T
                    x, T
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 1746, 1776);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 1664, 1792);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 1664, 1792);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            bool IEqualityComparer<T>.Equals(T x, T y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25000, 1808, 3776);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 1883, 2242) || true) && (f_25000_1887_1898())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 1883, 2242);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 1940, 2081) || true) && (f_25000_1944_1972(x, default(T)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 1940, 2081);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2022, 2058);

                            return f_25000_2029_2057(y, default(T));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 1940, 2081);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2105, 2223) || true) && (f_25000_2109_2137(y, default(T)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 2105, 2223);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2187, 2200);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 2105, 2223);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 1883, 2242);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2262, 2366) || true) && (f_25000_2266_2277(x) != f_25000_2281_2292(y))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 2262, 2366);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2334, 2347);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 2262, 2366);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2386, 2506) || true) && (x is IEquatable<T> equatable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 2386, 2506);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2460, 2487);

                        return f_25000_2467_2486(equatable, y);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 2386, 2506);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2526, 2659) || true) && (x is IComparable<T> comparableT)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 2526, 2659);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2603, 2640);

                        return f_25000_2610_2634(comparableT, y) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 2526, 2659);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2679, 2807) || true) && (x is IComparable comparable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 2679, 2807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2752, 2788);

                        return f_25000_2759_2782(comparable, y) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 2679, 2807);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2827, 2862);

                    var
                    enumerableX = x as IEnumerable
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2880, 2915);

                    var
                    enumerableY = y as IEnumerable
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 2935, 3714) || true) && (enumerableX != null && (DynAbs.Tracing.TraceSender.Expression_True(25000, 2939, 2981) && enumerableY != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 2935, 3714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3023, 3069);

                        var
                        enumeratorX = f_25000_3041_3068(enumerableX)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3091, 3137);

                        var
                        enumeratorY = f_25000_3109_3136(enumerableY)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3161, 3695) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 3161, 3695);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3222, 3261);

                                bool
                                hasNextX = f_25000_3238_3260(enumeratorX)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3287, 3326);

                                bool
                                hasNextY = f_25000_3303_3325(enumeratorY)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3354, 3493) || true) && (!hasNextX || (DynAbs.Tracing.TraceSender.Expression_False(25000, 3358, 3380) || !hasNextY))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 3354, 3493);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3438, 3466);

                                    return hasNextX == hasNextY;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 3354, 3493);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3521, 3672) || true) && (!f_25000_3526_3574(f_25000_3533_3552(enumeratorX), f_25000_3554_3573(enumeratorY)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 3521, 3672);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3632, 3645);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 3521, 3672);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 3161, 3695);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 3161, 3695);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 3161, 3695);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 2935, 3714);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3734, 3761);

                    return f_25000_3741_3760(x, y);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25000, 1808, 3776);

                    bool
                    f_25000_1887_1898()
                    {
                        var return_v = CanBeNull();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 1887, 1898);
                        return return_v;
                    }


                    bool
                    f_25000_1944_1972(T
                    objA, T?
                    objB)
                    {
                        var return_v = object.Equals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 1944, 1972);
                        return return_v;
                    }


                    bool
                    f_25000_2029_2057(T
                    objA, T?
                    objB)
                    {
                        var return_v = object.Equals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 2029, 2057);
                        return return_v;
                    }


                    bool
                    f_25000_2109_2137(T
                    objA, T?
                    objB)
                    {
                        var return_v = object.Equals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 2109, 2137);
                        return return_v;
                    }


                    System.Type
                    f_25000_2266_2277(T
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 2266, 2277);
                        return return_v;
                    }


                    System.Type
                    f_25000_2281_2292(T
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 2281, 2292);
                        return return_v;
                    }


                    bool
                    f_25000_2467_2486(System.IEquatable<T>
                    this_param, T
                    other)
                    {
                        var return_v = this_param.Equals(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 2467, 2486);
                        return return_v;
                    }


                    int
                    f_25000_2610_2634(System.IComparable<T>
                    this_param, T
                    other)
                    {
                        var return_v = this_param.CompareTo(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 2610, 2634);
                        return return_v;
                    }


                    int
                    f_25000_2759_2782(System.IComparable
                    this_param, T
                    obj)
                    {
                        var return_v = this_param.CompareTo((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 2759, 2782);
                        return return_v;
                    }


                    System.Collections.IEnumerator
                    f_25000_3041_3068(System.Collections.IEnumerable
                    this_param)
                    {
                        var return_v = this_param.GetEnumerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 3041, 3068);
                        return return_v;
                    }


                    System.Collections.IEnumerator
                    f_25000_3109_3136(System.Collections.IEnumerable
                    this_param)
                    {
                        var return_v = this_param.GetEnumerator();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 3109, 3136);
                        return return_v;
                    }


                    bool
                    f_25000_3238_3260(System.Collections.IEnumerator
                    this_param)
                    {
                        var return_v = this_param.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 3238, 3260);
                        return return_v;
                    }


                    bool
                    f_25000_3303_3325(System.Collections.IEnumerator
                    this_param)
                    {
                        var return_v = this_param.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 3303, 3325);
                        return return_v;
                    }


                    object?
                    f_25000_3533_3552(System.Collections.IEnumerator
                    this_param)
                    {
                        var return_v = this_param.Current;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 3533, 3552);
                        return return_v;
                    }


                    object?
                    f_25000_3554_3573(System.Collections.IEnumerator
                    this_param)
                    {
                        var return_v = this_param.Current;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 3554, 3573);
                        return return_v;
                    }


                    bool
                    f_25000_3526_3574(object?
                    objA, object?
                    objB)
                    {
                        var return_v = Equals(objA, objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 3526, 3574);
                        return return_v;
                    }


                    bool
                    f_25000_3741_3760(T
                    objA, T
                    objB)
                    {
                        var return_v = object.Equals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 3741, 3760);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 1808, 3776);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 1808, 3776);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            int IEqualityComparer<T>.GetHashCode(T obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25000, 3792, 3919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 3868, 3904);

                    throw f_25000_3874_3903();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25000, 3792, 3919);

                    System.NotImplementedException
                    f_25000_3874_3903()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 3874, 3903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 3792, 3919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 3792, 3919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AssertEqualityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25000, 930, 3930);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25000, 930, 3930);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 930, 3930);
            }


            static AssertEqualityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25000, 930, 3930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 1062, 1106);
                s_instance = f_25000_1075_1106<T>(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25000, 930, 3930);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 930, 3930);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25000, 930, 3930);

            static Roslyn.Test.Utilities.AssertEx.AssertEqualityComparer<T>
            f_25000_1075_1106<T>()
            {
                var return_v = new Roslyn.Test.Utilities.AssertEx.AssertEqualityComparer<T>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 1075, 1106);
                return return_v;
            }

        }

        public static void AreEqual<T>(T expected, T actual, string message = null, IEqualityComparer<T> comparer = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 3964, 4984);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 4102, 4195) || true) && (f_25000_4106_4139<T>(expected, actual))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 4102, 4195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 4173, 4180);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 4102, 4195);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 4211, 4973) || true) && (expected == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 4211, 4973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 4265, 4324);

                    f_25000_4265_4323<T>("expected was null, but actual wasn't\r\n" + message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 4211, 4973);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 4211, 4973);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 4358, 4973) || true) && (actual == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 4358, 4973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 4410, 4469);

                        f_25000_4410_4468<T>("actual was null, but expected wasn't\r\n" + message);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 4358, 4973);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 4358, 4973);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 4535, 4958) || true) && (!((DynAbs.Tracing.TraceSender.Conditional_F1(25000, 4541, 4557) || ((comparer != null && DynAbs.Tracing.TraceSender.Conditional_F2(25000, 4581, 4614)) || DynAbs.Tracing.TraceSender.Conditional_F3(25000, 4638, 4688))) ? f_25000_4581_4614<T>(comparer, expected, actual) : f_25000_4638_4688<T>(expected, actual)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 4535, 4958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 4731, 4939);

                            f_25000_4731_4938<T>("Expected and actual were different.\r\n" +
                                                     "Expected:\r\n" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (expected).ToString(), 25000, 4824, 4832) + "\r\n" +
                                                     "Actual:\r\n" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (actual).ToString(), 25000, 4886, 4892) + "\r\n" +
                                                     message);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 4535, 4958);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 4358, 4973);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 4211, 4973);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 3964, 4984);

                bool
                f_25000_4106_4139<T>(T
                objA, T
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 4106, 4139);
                    return return_v;
                }


                int
                f_25000_4265_4323<T>(string
                message)
                {
                    Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 4265, 4323);
                    return 0;
                }


                int
                f_25000_4410_4468<T>(string
                message)
                {
                    Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 4410, 4468);
                    return 0;
                }


                bool
                f_25000_4581_4614<T>(System.Collections.Generic.IEqualityComparer<T>
                this_param, T
                x, T
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 4581, 4614);
                    return return_v;
                }


                bool
                f_25000_4638_4688<T>(T
                left, T
                right)
                {
                    var return_v = AssertEqualityComparer<T>.Equals(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 4638, 4688);
                    return return_v;
                }


                int
                f_25000_4731_4938<T>(string
                message)
                {
                    Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 4731, 4938);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 3964, 4984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 3964, 4984);
            }
        }

        public static void Equal<T>(ImmutableArray<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer = null, string message = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 4996, 5452);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 5160, 5441) || true) && (actual == null || (DynAbs.Tracing.TraceSender.Expression_False(25000, 5164, 5200) || expected.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 5160, 5441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 5234, 5301);

                    f_25000_5234_5300<T>((actual == null) == expected.IsDefault, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 5160, 5441);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 5160, 5441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 5367, 5426);

                    f_25000_5367_5425<T>(expected, actual, comparer, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 5160, 5441);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 4996, 5452);

                bool
                f_25000_5234_5300<T>(bool
                condition, string?
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 5234, 5300);
                    return return_v;
                }


                bool
                f_25000_5367_5425<T>(System.Collections.Immutable.ImmutableArray<T>
                expected, System.Collections.Generic.IEnumerable<T>
                actual, System.Collections.Generic.IEqualityComparer<T>?
                comparer, string?
                message)
                {
                    var return_v = Equal((System.Collections.Generic.IEnumerable<T>)expected, actual, comparer, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 5367, 5425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 4996, 5452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 4996, 5452);
            }
        }

        public static void Equal<T>(IEnumerable<T> expected, ImmutableArray<T> actual, IEqualityComparer<T> comparer = null, string message = null, string itemSeparator = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 5464, 5964);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 5657, 5953) || true) && (expected == null || (DynAbs.Tracing.TraceSender.Expression_False(25000, 5661, 5697) || actual.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 5657, 5953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 5731, 5798);

                    f_25000_5731_5797<T>((expected == null) == actual.IsDefault, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 5657, 5953);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 5657, 5953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 5864, 5938);

                    f_25000_5864_5937<T>(expected, actual, comparer, message, itemSeparator);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 5657, 5953);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 5464, 5964);

                bool
                f_25000_5731_5797<T>(bool
                condition, string?
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 5731, 5797);
                    return return_v;
                }


                bool
                f_25000_5864_5937<T>(System.Collections.Generic.IEnumerable<T>
                expected, System.Collections.Immutable.ImmutableArray<T>
                actual, System.Collections.Generic.IEqualityComparer<T>?
                comparer, string?
                message, string?
                itemSeparator)
                {
                    var return_v = Equal(expected, (System.Collections.Generic.IEnumerable<T>)actual, comparer, message, itemSeparator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 5864, 5937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 5464, 5964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 5464, 5964);
            }
        }

        public static void Equal<T>(ImmutableArray<T> expected, ImmutableArray<T> actual, IEqualityComparer<T> comparer = null, string message = null, string itemSeparator = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 5976, 6257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 6172, 6246);

                f_25000_6172_6245<T>(expected, actual, comparer, message, itemSeparator);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 5976, 6257);

                bool
                f_25000_6172_6245<T>(System.Collections.Immutable.ImmutableArray<T>
                expected, System.Collections.Immutable.ImmutableArray<T>
                actual, System.Collections.Generic.IEqualityComparer<T>?
                comparer, string?
                message, string?
                itemSeparator)
                {
                    var return_v = Equal((System.Collections.Generic.IEnumerable<T>)expected, (System.Collections.Generic.IEnumerable<T>)actual, comparer, message, itemSeparator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 6172, 6245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 5976, 6257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 5976, 6257);
            }
        }

        public static void Equal(string expected, string actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 6269, 6798);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 6350, 6467) || true) && (f_25000_6354_6411(expected, actual, StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 6350, 6467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 6445, 6452);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 6350, 6467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 6483, 6517);

                var
                message = f_25000_6497_6516()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 6531, 6552);

                f_25000_6531_6551(message);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 6566, 6598);

                f_25000_6566_6597(message, "Expected:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 6612, 6641);

                f_25000_6612_6640(message, expected);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 6655, 6685);

                f_25000_6655_6684(message, "Actual:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 6699, 6726);

                f_25000_6699_6725(message, actual);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 6742, 6787);

                f_25000_6742_6786(false, f_25000_6767_6785(message));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 6269, 6798);

                bool
                f_25000_6354_6411(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 6354, 6411);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_6497_6516()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 6497, 6516);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_6531_6551(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 6531, 6551);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_6566_6597(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 6566, 6597);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_6612_6640(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 6612, 6640);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_6655_6684(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 6655, 6684);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_6699_6725(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 6699, 6725);
                    return return_v;
                }


                string
                f_25000_6767_6785(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 6767, 6785);
                    return return_v;
                }


                bool
                f_25000_6742_6786(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 6742, 6786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 6269, 6798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 6269, 6798);
            }
        }

        public static bool Equal<T>(
                    IEnumerable<T> expected,
                    IEnumerable<T> actual,
                    IEqualityComparer<T> comparer = null,
                    string message = null,
                    string itemSeparator = null,
                    Func<T, string> itemInspector = null,
                    string expectedValueSourcePath = null,
                    int expectedValueSourceLine = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 6810, 7990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7215, 7235);

                var
                toReturn = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7249, 7439) || true) && (expected == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 7249, 7439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7303, 7329);

                    f_25000_7303_7328<T>(actual);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 7249, 7439);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 7249, 7439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7395, 7424);

                    f_25000_7395_7423<T>(actual);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 7249, 7439);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7455, 7561) || true) && (f_25000_7459_7500<T>(expected, actual, comparer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 7455, 7561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7534, 7546);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 7455, 7561);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7577, 7725);

                string
                assertMessage = f_25000_7600_7724<T>(expected, actual, comparer, itemInspector, itemSeparator, expectedValueSourcePath, expectedValueSourceLine)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7741, 7893) || true) && (message != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 7741, 7893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7794, 7843);

                    assertMessage = message + "\r\n" + assertMessage;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7861, 7878);

                    toReturn = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 7741, 7893);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7909, 7949);

                f_25000_7909_7948<T>(false, assertMessage);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 7963, 7979);

                return toReturn;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 6810, 7990);

                bool
                f_25000_7303_7328<T>(System.Collections.Generic.IEnumerable<T>
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 7303, 7328);
                    return return_v;
                }


                bool
                f_25000_7395_7423<T>(System.Collections.Generic.IEnumerable<T>
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 7395, 7423);
                    return return_v;
                }


                bool
                f_25000_7459_7500<T>(System.Collections.Generic.IEnumerable<T>?
                expected, System.Collections.Generic.IEnumerable<T>
                actual, System.Collections.Generic.IEqualityComparer<T>?
                comparer)
                {
                    var return_v = SequenceEqual(expected, actual, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 7459, 7500);
                    return return_v;
                }


                string
                f_25000_7600_7724<T>(System.Collections.Generic.IEnumerable<T>?
                expected, System.Collections.Generic.IEnumerable<T>
                actual, System.Collections.Generic.IEqualityComparer<T>?
                comparer, System.Func<T, string>?
                itemInspector, string?
                itemSeparator, string?
                expectedValueSourcePath, int
                expectedValueSourceLine)
                {
                    var return_v = GetAssertMessage(expected, actual, comparer, itemInspector, itemSeparator, expectedValueSourcePath, expectedValueSourceLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 7600, 7724);
                    return return_v;
                }


                bool
                f_25000_7909_7948<T>(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 7909, 7948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 6810, 7990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 6810, 7990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void EqualOrDiff(string expected, string actual, string message = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 8503, 9793);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 8613, 8691) || true) && (expected == actual)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 8613, 8691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 8669, 8676);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 8613, 8691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 8707, 8761);

                var
                diffBuilder = f_25000_8725_8760(f_25000_8747_8759())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 8775, 8856);

                var
                diff = f_25000_8786_8855(diffBuilder, expected, actual, ignoreWhitespace: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 8870, 8911);

                var
                messageBuilder = f_25000_8891_8910()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 8925, 9127);

                f_25000_8925_9126(messageBuilder, (DynAbs.Tracing.TraceSender.Conditional_F1(25000, 8969, 8998) || ((f_25000_8969_8998(message) && DynAbs.Tracing.TraceSender.Conditional_F2(25000, 9022, 9094)) || DynAbs.Tracing.TraceSender.Conditional_F3(25000, 9118, 9125))) ? "Actual and expected values differ. Expected shown in baseline of diff:"
                : message);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 9143, 9714);
                    foreach (var line in f_25000_9164_9174_I(f_25000_9164_9174(diff)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 9143, 9714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 9208, 9642);

                        switch (f_25000_9216_9225(line))
                        {

                            case ChangeType.Inserted:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 9208, 9642);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 9318, 9345);

                                f_25000_9318_9344(messageBuilder, "+");
                                DynAbs.Tracing.TraceSender.TraceBreak(25000, 9371, 9377);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 9208, 9642);

                            case ChangeType.Deleted:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 9208, 9642);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 9449, 9476);

                                f_25000_9449_9475(messageBuilder, "-");
                                DynAbs.Tracing.TraceSender.TraceBreak(25000, 9502, 9508);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 9208, 9642);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 9208, 9642);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 9564, 9591);

                                f_25000_9564_9590(messageBuilder, " ");
                                DynAbs.Tracing.TraceSender.TraceBreak(25000, 9617, 9623);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 9208, 9642);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 9662, 9699);

                        f_25000_9662_9698(
                                        messageBuilder, f_25000_9688_9697(line));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 9143, 9714);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 9730, 9782);

                f_25000_9730_9781(false, f_25000_9755_9780(messageBuilder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 8503, 9793);

                DiffPlex.Differ
                f_25000_8747_8759()
                {
                    var return_v = new DiffPlex.Differ();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 8747, 8759);
                    return return_v;
                }


                DiffPlex.DiffBuilder.InlineDiffBuilder
                f_25000_8725_8760(DiffPlex.Differ
                differ)
                {
                    var return_v = new DiffPlex.DiffBuilder.InlineDiffBuilder((DiffPlex.IDiffer)differ);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 8725, 8760);
                    return return_v;
                }


                DiffPlex.DiffBuilder.Model.DiffPaneModel
                f_25000_8786_8855(DiffPlex.DiffBuilder.InlineDiffBuilder
                this_param, string
                oldText, string
                newText, bool
                ignoreWhitespace)
                {
                    var return_v = this_param.BuildDiffModel(oldText, newText, ignoreWhitespace: ignoreWhitespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 8786, 8855);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_8891_8910()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 8891, 8910);
                    return return_v;
                }


                bool
                f_25000_8969_8998(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 8969, 8998);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_8925_9126(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 8925, 9126);
                    return return_v;
                }


                System.Collections.Generic.List<DiffPlex.DiffBuilder.Model.DiffPiece>
                f_25000_9164_9174(DiffPlex.DiffBuilder.Model.DiffPaneModel
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 9164, 9174);
                    return return_v;
                }


                DiffPlex.DiffBuilder.Model.ChangeType
                f_25000_9216_9225(DiffPlex.DiffBuilder.Model.DiffPiece
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 9216, 9225);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_9318_9344(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 9318, 9344);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_9449_9475(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 9449, 9475);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_9564_9590(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 9564, 9590);
                    return return_v;
                }


                string
                f_25000_9688_9697(DiffPlex.DiffBuilder.Model.DiffPiece
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 9688, 9697);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_9662_9698(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 9662, 9698);
                    return return_v;
                }


                System.Collections.Generic.List<DiffPlex.DiffBuilder.Model.DiffPiece>
                f_25000_9164_9174_I(System.Collections.Generic.List<DiffPlex.DiffBuilder.Model.DiffPiece>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 9164, 9174);
                    return return_v;
                }


                string
                f_25000_9755_9780(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 9755, 9780);
                    return return_v;
                }


                bool
                f_25000_9730_9781(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 9730, 9781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 8503, 9793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 8503, 9793);
            }
        }

        public static void NotEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer = null, string message = null,
                    string itemSeparator = null, Func<T, string> itemInspector = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 9805, 10494);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10049, 10202) || true) && (f_25000_10053_10086<T>(expected, actual))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 10049, 10202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10120, 10187);

                    f_25000_10120_10186<T>("expected and actual references are identical\r\n" + message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 10049, 10202);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10218, 10483) || true) && (expected == null || (DynAbs.Tracing.TraceSender.Expression_False(25000, 10222, 10256) || actual == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 10218, 10483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10290, 10297);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 10218, 10483);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 10218, 10483);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10331, 10483) || true) && (f_25000_10335_10376<T>(expected, actual, comparer))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 10331, 10483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10410, 10468);

                        f_25000_10410_10467<T>("expected and actual sequences match\r\n" + message);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 10331, 10483);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 10218, 10483);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 9805, 10494);

                bool
                f_25000_10053_10086<T>(System.Collections.Generic.IEnumerable<T>
                objA, System.Collections.Generic.IEnumerable<T>
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 10053, 10086);
                    return return_v;
                }


                int
                f_25000_10120_10186<T>(string
                message)
                {
                    Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 10120, 10186);
                    return 0;
                }


                bool
                f_25000_10335_10376<T>(System.Collections.Generic.IEnumerable<T>
                expected, System.Collections.Generic.IEnumerable<T>
                actual, System.Collections.Generic.IEqualityComparer<T>?
                comparer)
                {
                    var return_v = SequenceEqual(expected, actual, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 10335, 10376);
                    return return_v;
                }


                int
                f_25000_10410_10467<T>(string
                message)
                {
                    Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 10410, 10467);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 9805, 10494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 9805, 10494);
            }
        }

        private static bool SequenceEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 10506, 11598);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10653, 10751) || true) && (f_25000_10657_10690<T>(expected, actual))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 10653, 10751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10724, 10736);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 10653, 10751);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10767, 10810);

                var
                enumerator1 = f_25000_10785_10809<T>(expected)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10824, 10865);

                var
                enumerator2 = f_25000_10842_10864<T>(actual)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10881, 11559) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 10881, 11559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10926, 10964);

                        var
                        hasNext1 = f_25000_10941_10963<T>(enumerator1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 10982, 11020);

                        var
                        hasNext2 = f_25000_10997_11019<T>(enumerator2)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11040, 11138) || true) && (hasNext1 != hasNext2)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 11040, 11138);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11106, 11119);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 11040, 11138);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11158, 11238) || true) && (!hasNext1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 11158, 11238);
                            DynAbs.Tracing.TraceSender.TraceBreak(25000, 11213, 11219);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 11158, 11238);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11258, 11291);

                        var
                        value1 = f_25000_11271_11290<T>(enumerator1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11309, 11342);

                        var
                        value2 = f_25000_11322_11341<T>(enumerator2)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11362, 11544) || true) && (!((DynAbs.Tracing.TraceSender.Conditional_F1(25000, 11368, 11384) || ((comparer != null && DynAbs.Tracing.TraceSender.Conditional_F2(25000, 11387, 11418)) || DynAbs.Tracing.TraceSender.Conditional_F3(25000, 11421, 11469))) ? f_25000_11387_11418<T>(comparer, value1, value2) : f_25000_11421_11469<T>(value1, value2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 11362, 11544);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11512, 11525);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 11362, 11544);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 10881, 11559);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 10881, 11559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 10881, 11559);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11575, 11587);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 10506, 11598);

                bool
                f_25000_10657_10690<T>(System.Collections.Generic.IEnumerable<T>
                objA, System.Collections.Generic.IEnumerable<T>
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 10657, 10690);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_25000_10785_10809<T>(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 10785, 10809);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_25000_10842_10864<T>(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 10842, 10864);
                    return return_v;
                }


                bool
                f_25000_10941_10963<T>(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 10941, 10963);
                    return return_v;
                }


                bool
                f_25000_10997_11019<T>(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 10997, 11019);
                    return return_v;
                }


                T
                f_25000_11271_11290<T>(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 11271, 11290);
                    return return_v;
                }


                T
                f_25000_11322_11341<T>(System.Collections.Generic.IEnumerator<T>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 11322, 11341);
                    return return_v;
                }


                bool
                f_25000_11387_11418<T>(System.Collections.Generic.IEqualityComparer<T>
                this_param, T
                x, T
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 11387, 11418);
                    return return_v;
                }


                bool
                f_25000_11421_11469<T>(T
                left, T
                right)
                {
                    var return_v = AssertEqualityComparer<T>.Equals(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 11421, 11469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 10506, 11598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 10506, 11598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void SetEqual(IEnumerable<string> expected, IEnumerable<string> actual, IEqualityComparer<string> comparer = null, string message = null, string itemSeparator = "\r\n", Func<string, string> itemInspector = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 11610, 15503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11860, 11912);

                var
                indexes = f_25000_11874_11911(comparer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11926, 11942);

                int
                counter = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 11956, 12178);
                    foreach (var expectedItem in f_25000_11985_11993_I(expected))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 11956, 12178);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12027, 12163) || true) && (!f_25000_12032_12065(indexes, expectedItem))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 12027, 12163);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12107, 12144);

                            f_25000_12107_12143(indexes, expectedItem, counter++);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 12027, 12163);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 11956, 12178);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12194, 12304);

                f_25000_12194_12303(expected, f_25000_12221_12253(actual, e => getIndex(e)), comparer, message, itemSeparator, itemInspector);

                int getIndex(string item)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25000, 12320, 13301);
                        int index = default(int);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12428, 12546) || true) && (f_25000_12432_12472(indexes, item, out index))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 12428, 12546);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12514, 12527);

                            return index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 12428, 12546);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12618, 12653);

                        int
                        closestDistance = int.MaxValue
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12671, 12697);

                        string
                        closestItem = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12715, 13069);
                            foreach (var expectedItem in f_25000_12744_12756_I(f_25000_12744_12756(indexes)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 12715, 13069);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12798, 12845);

                                var
                                distance = f_25000_12813_12844(item, expectedItem)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12867, 13050) || true) && (distance < closestDistance)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 12867, 13050);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 12947, 12974);

                                    closestDistance = distance;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 13000, 13027);

                                    closestItem = expectedItem;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 12867, 13050);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 12715, 13069);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 355);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 355);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 13089, 13256) || true) && (closestItem != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 13089, 13256);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 13154, 13202);

                            _ = f_25000_13158_13201(indexes, closestItem, out index);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 13224, 13237);

                            return index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 13089, 13256);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 13276, 13286);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25000, 12320, 13301);

                        bool
                        f_25000_12432_12472(System.Collections.Generic.Dictionary<string, int>
                        this_param, string
                        key, out int
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 12432, 12472);
                            return return_v;
                        }


                        System.Collections.Generic.Dictionary<string, int>.KeyCollection
                        f_25000_12744_12756(System.Collections.Generic.Dictionary<string, int>
                        this_param)
                        {
                            var return_v = this_param.Keys;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 12744, 12756);
                            return return_v;
                        }


                        int
                        f_25000_12813_12844(string
                        first, string
                        second)
                        {
                            var return_v = levenshtein(first, second);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 12813, 12844);
                            return return_v;
                        }


                        System.Collections.Generic.Dictionary<string, int>.KeyCollection
                        f_25000_12744_12756_I(System.Collections.Generic.Dictionary<string, int>.KeyCollection
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 12744, 12756);
                            return return_v;
                        }


                        bool
                        f_25000_13158_13201(System.Collections.Generic.Dictionary<string, int>
                        this_param, string
                        key, out int
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 13158, 13201);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 12320, 13301);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 12320, 13301);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                int levenshtein(string first, string second)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25000, 13444, 15492);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 13705, 13745);

                        int
                        n = f_25000_13713_13725(first)
                        ,
                        m = f_25000_13731_13744(second)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 13763, 13805) || true) && (n == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 13763, 13805);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 13796, 13805);

                            return m;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 13763, 13805);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 13823, 13865) || true) && (m == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 13823, 13865);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 13856, 13865);

                            return n;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 13823, 13865);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14144, 14172);

                        int
                        curRow = 0
                        ,
                        nextRow = 1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14190, 14252);

                        int[][]
                        rows = new int[][] { new int[m + 1], new int[m + 1] }
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14279, 14284);
                            for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14270, 14340) || true) && (j <= m)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14294, 14297)
            , ++j, DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 14270, 14340))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 14270, 14340);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14320, 14340);

                                rows[curRow][j] = j;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 71);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 71);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14456, 14461);

                            // For each virtual row (since we only have physical storage for two)
                            for (int
            i = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14447, 15380) || true) && (i <= n)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14471, 14474)
            , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 14447, 15380))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 14447, 15380);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14570, 14591);

                                rows[nextRow][0] = i;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14622, 14627);
                                    for (int
                j = 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14613, 14998) || true) && (j <= m)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14637, 14640)
                , ++j, DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 14613, 14998))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 14613, 14998);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14690, 14722);

                                        int
                                        dist1 = rows[curRow][j] + 1
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14748, 14785);

                                        int
                                        dist2 = rows[nextRow][j - 1] + 1
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14811, 14890);

                                        int
                                        dist3 = rows[curRow][j - 1] + ((DynAbs.Tracing.TraceSender.Conditional_F1(25000, 14846, 14880) || ((f_25000_14846_14880(f_25000_14846_14858(first, i - 1), f_25000_14866_14879(second, j - 1)) && DynAbs.Tracing.TraceSender.Conditional_F2(25000, 14883, 14884)) || DynAbs.Tracing.TraceSender.Conditional_F3(25000, 14887, 14888))) ? 0 : 1)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 14916, 14975);

                                        rows[nextRow][j] = f_25000_14935_14974(dist1, f_25000_14951_14973(dist2, dist3));
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 386);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 386);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 15077, 15361) || true) && (curRow == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 15077, 15361);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 15142, 15153);

                                    curRow = 1;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 15179, 15191);

                                    nextRow = 0;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 15077, 15361);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 15077, 15361);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 15289, 15300);

                                    curRow = 0;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 15326, 15338);

                                    nextRow = 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 15077, 15361);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 934);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 934);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 15454, 15477);

                        return rows[curRow][m];
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25000, 13444, 15492);

                        int
                        f_25000_13713_13725(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 13713, 13725);
                            return return_v;
                        }


                        int
                        f_25000_13731_13744(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 13731, 13744);
                            return return_v;
                        }


                        char
                        f_25000_14846_14858(string
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 14846, 14858);
                            return return_v;
                        }


                        char
                        f_25000_14866_14879(string
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 14866, 14879);
                            return return_v;
                        }


                        bool
                        f_25000_14846_14880(char
                        this_param, char
                        obj)
                        {
                            var return_v = this_param.Equals(obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 14846, 14880);
                            return return_v;
                        }


                        int
                        f_25000_14951_14973(int
                        val1, int
                        val2)
                        {
                            var return_v = Math.Min(val1, val2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 14951, 14973);
                            return return_v;
                        }


                        int
                        f_25000_14935_14974(int
                        val1, int
                        val2)
                        {
                            var return_v = Math.Min(val1, val2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 14935, 14974);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 13444, 15492);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 13444, 15492);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 11610, 15503);

                System.Collections.Generic.Dictionary<string, int>
                f_25000_11874_11911(System.Collections.Generic.IEqualityComparer<string>?
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, int>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 11874, 11911);
                    return return_v;
                }


                bool
                f_25000_12032_12065(System.Collections.Generic.Dictionary<string, int>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 12032, 12065);
                    return return_v;
                }


                int
                f_25000_12107_12143(System.Collections.Generic.Dictionary<string, int>
                this_param, string
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 12107, 12143);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25000_11985_11993_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 11985, 11993);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<string>
                f_25000_12221_12253(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, int>
                keySelector)
                {
                    var return_v = source.OrderBy<string, int>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 12221, 12253);
                    return return_v;
                }


                int
                f_25000_12194_12303(System.Collections.Generic.IEnumerable<string>
                expected, System.Linq.IOrderedEnumerable<string>
                actual, System.Collections.Generic.IEqualityComparer<string>?
                comparer, string?
                message, string
                itemSeparator, System.Func<string, string>?
                itemInspector)
                {
                    SetEqual<string>(expected, (System.Collections.Generic.IEnumerable<string>)actual, comparer, message, itemSeparator, itemInspector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 12194, 12303);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 11610, 15503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 11610, 15503);
            }
        }

        public static void SetEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer = null, string message = null, string itemSeparator = "\r\n", Func<T, string> itemInspector = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 15515, 16306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 15748, 15801);

                var
                expectedSet = f_25000_15766_15800<T>(expected, comparer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 15815, 15896);

                var
                result = f_25000_15828_15844<T>(expected) == f_25000_15848_15862<T>(actual) && (DynAbs.Tracing.TraceSender.Expression_True(25000, 15828, 15895) && f_25000_15866_15895<T>(expectedSet, actual))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 15910, 16295) || true) && (!result)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 15910, 16295);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 15955, 16225) || true) && (f_25000_15959_15988<T>(message))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 15955, 16225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 16030, 16206);

                        message = f_25000_16040_16205<T>(f_25000_16083_16131<T>(expected, itemSeparator, itemInspector), f_25000_16158_16204<T>(actual, itemSeparator, itemInspector));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 15955, 16225);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 16245, 16280);

                    f_25000_16245_16279<T>(result, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 15910, 16295);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 15515, 16306);

                System.Collections.Generic.HashSet<T>
                f_25000_15766_15800<T>(System.Collections.Generic.IEnumerable<T>
                collection, System.Collections.Generic.IEqualityComparer<T>?
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<T>(collection, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 15766, 15800);
                    return return_v;
                }


                int
                f_25000_15828_15844<T>(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.Count<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 15828, 15844);
                    return return_v;
                }


                int
                f_25000_15848_15862<T>(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.Count<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 15848, 15862);
                    return return_v;
                }


                bool
                f_25000_15866_15895<T>(System.Collections.Generic.HashSet<T>
                this_param, System.Collections.Generic.IEnumerable<T>
                other)
                {
                    var return_v = this_param.SetEquals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 15866, 15895);
                    return return_v;
                }


                bool
                f_25000_15959_15988<T>(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 15959, 15988);
                    return return_v;
                }


                string
                f_25000_16083_16131<T>(System.Collections.Generic.IEnumerable<T>
                list, string
                separator, System.Func<T, string>?
                itemInspector)
                {
                    var return_v = ToString(list, separator, itemInspector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16083, 16131);
                    return return_v;
                }


                string
                f_25000_16158_16204<T>(System.Collections.Generic.IEnumerable<T>
                list, string
                separator, System.Func<T, string>?
                itemInspector)
                {
                    var return_v = ToString(list, separator, itemInspector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16158, 16204);
                    return return_v;
                }


                string
                f_25000_16040_16205<T>(string
                expected, string
                actual)
                {
                    var return_v = GetAssertMessage(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16040, 16205);
                    return return_v;
                }


                bool
                f_25000_16245_16279<T>(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16245, 16279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 15515, 16306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 15515, 16306);
            }
        }

        public static void SetEqual<T>(T[] expected, T[] actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25000, 16388, 16433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 16391, 16433);
                f_25000_16391_16433<T>(actual, expected); DynAbs.Tracing.TraceSender.TraceExitMethod(25000, 16388, 16433);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 16388, 16433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 16388, 16433);
            }
        }

        public static void SetEqual<T>(IEnumerable<T> actual, params T[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 16446, 16960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 16545, 16588);

                var
                expectedSet = f_25000_16563_16587<T>(expected)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 16602, 16878) || true) && (!f_25000_16607_16636<T>(expectedSet, actual))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 16602, 16878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 16670, 16811);

                    var
                    message = f_25000_16684_16810<T>(f_25000_16701_16755<T>(expected, ",\r\n", itemInspector: withQuotes), f_25000_16757_16809<T>(actual, ",\r\n", itemInspector: withQuotes))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 16829, 16863);

                    f_25000_16829_16862<T>(false, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 16602, 16878);
                }

                string withQuotes(T t)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25000, 16917, 16948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 16920, 16948);
                        return $"\"{f_25000_16925_16944<T>(t)}\""; DynAbs.Tracing.TraceSender.TraceExitMethod(25000, 16917, 16948);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 16917, 16948);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 16917, 16948);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 16446, 16960);

                System.Collections.Generic.HashSet<T>
                f_25000_16563_16587<T>(T[]
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<T>((System.Collections.Generic.IEnumerable<T>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16563, 16587);
                    return return_v;
                }


                bool
                f_25000_16607_16636<T>(System.Collections.Generic.HashSet<T>
                this_param, System.Collections.Generic.IEnumerable<T>
                other)
                {
                    var return_v = this_param.SetEquals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16607, 16636);
                    return return_v;
                }


                string
                f_25000_16701_16755<T>(T[]
                list, string
                separator, System.Func<T, string>
                itemInspector)
                {
                    var return_v = ToString((System.Collections.Generic.IEnumerable<T>)list, separator, itemInspector: itemInspector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16701, 16755);
                    return return_v;
                }


                string
                f_25000_16757_16809<T>(System.Collections.Generic.IEnumerable<T>
                list, string
                separator, System.Func<T, string>
                itemInspector)
                {
                    var return_v = ToString(list, separator, itemInspector: itemInspector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16757, 16809);
                    return return_v;
                }


                string
                f_25000_16684_16810<T>(string
                expected, string
                actual)
                {
                    var return_v = GetAssertMessage(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16684, 16810);
                    return return_v;
                }


                bool
                f_25000_16829_16862<T>(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16829, 16862);
                    return return_v;
                }


                string?
                f_25000_16925_16944<T>(T
                value)
                {
                    var return_v = Convert.ToString((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16925, 16944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 16446, 16960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 16446, 16960);
            }
        }

        public static void None<T>(IEnumerable<T> actual, Func<T, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 16972, 17416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 17071, 17105);

                var
                none = !f_25000_17083_17104<T>(actual, predicate)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 17119, 17405) || true) && (!none)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 17119, 17405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 17162, 17390);

                    f_25000_17162_17389<T>(none, f_25000_17186_17388<T>("Unexpected item found among existing items: {0}\nExisting items: {1}", f_25000_17315_17348<T>(f_25000_17324_17347<T>(actual, predicate)), f_25000_17371_17387<T>(actual)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 17119, 17405);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 16972, 17416);

                bool
                f_25000_17083_17104<T>(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, bool>
                predicate)
                {
                    var return_v = source.Any<T>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17083, 17104);
                    return return_v;
                }


                T
                f_25000_17324_17347<T>(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, bool>
                predicate)
                {
                    var return_v = source.First<T>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17324, 17347);
                    return return_v;
                }


                string
                f_25000_17315_17348<T>(T
                o)
                {
                    var return_v = ToString((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17315, 17348);
                    return return_v;
                }


                string
                f_25000_17371_17387<T>(System.Collections.Generic.IEnumerable<T>
                list)
                {
                    var return_v = ToString(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17371, 17387);
                    return return_v;
                }


                string
                f_25000_17186_17388<T>(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17186, 17388);
                    return return_v;
                }


                bool
                f_25000_17162_17389<T>(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17162, 17389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 16972, 17416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 16972, 17416);
            }
        }

        public static void Any<T>(IEnumerable<T> actual, Func<T, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 17428, 17691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 17526, 17558);

                var
                any = f_25000_17536_17557<T>(actual, predicate)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 17572, 17680);

                f_25000_17572_17679<T>(any, f_25000_17595_17678<T>("No expected item was found.\nExisting items: {0}", f_25000_17661_17677<T>(actual)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 17428, 17691);

                bool
                f_25000_17536_17557<T>(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, bool>
                predicate)
                {
                    var return_v = source.Any<T>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17536, 17557);
                    return return_v;
                }


                string
                f_25000_17661_17677<T>(System.Collections.Generic.IEnumerable<T>
                list)
                {
                    var return_v = ToString(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17661, 17677);
                    return return_v;
                }


                string
                f_25000_17595_17678<T>(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17595, 17678);
                    return return_v;
                }


                bool
                f_25000_17572_17679<T>(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17572, 17679);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 17428, 17691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 17428, 17691);
            }
        }

        public static void All<T>(IEnumerable<T> actual, Func<T, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 17703, 18081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 17801, 17833);

                var
                all = f_25000_17811_17832<T>(actual, predicate)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 17847, 18070) || true) && (!all)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 17847, 18070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 17889, 18055);

                    f_25000_17889_18054<T>(all, f_25000_17912_18053<T>("Not all items satisfy condition:\n{0}", f_25000_18010_18052<T>(f_25000_18019_18051<T>(actual, i => !predicate(i)))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 17847, 18070);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 17703, 18081);

                bool
                f_25000_17811_17832<T>(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, bool>
                predicate)
                {
                    var return_v = source.All<T>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17811, 17832);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_25000_18019_18051<T>(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, bool>
                predicate)
                {
                    var return_v = source.Where<T>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 18019, 18051);
                    return return_v;
                }


                string
                f_25000_18010_18052<T>(System.Collections.Generic.IEnumerable<T>
                list)
                {
                    var return_v = ToString(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 18010, 18052);
                    return return_v;
                }


                string
                f_25000_17912_18053<T>(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17912, 18053);
                    return return_v;
                }


                bool
                f_25000_17889_18054<T>(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 17889, 18054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 17703, 18081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 17703, 18081);
            }
        }

        public static string ToString(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 18093, 18195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 18157, 18184);

                return f_25000_18164_18183(o);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 18093, 18195);

                string?
                f_25000_18164_18183(object
                value)
                {
                    var return_v = Convert.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 18164, 18183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 18093, 18195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 18093, 18195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ToString<T>(IEnumerable<T> list, string separator = ", ", Func<T, string> itemInspector = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 18207, 18548);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 18348, 18463) || true) && (itemInspector == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 18348, 18463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 18407, 18448);

                    itemInspector = i => Convert.ToString(i);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 18348, 18463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 18479, 18537);

                return f_25000_18486_18536<T>(separator, f_25000_18509_18535<T>(list, itemInspector));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 18207, 18548);

                System.Collections.Generic.IEnumerable<string>
                f_25000_18509_18535<T>(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, string>
                selector)
                {
                    var return_v = source.Select<T, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 18509, 18535);
                    return return_v;
                }


                string
                f_25000_18486_18536<T>(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 18486, 18536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 18207, 18548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 18207, 18548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void Fail(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 18560, 18679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 18624, 18668);

                throw f_25000_18630_18667(message);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 18560, 18679);

                Xunit.Sdk.XunitException
                f_25000_18630_18667(string
                userMessage)
                {
                    var return_v = new Xunit.Sdk.XunitException(userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 18630, 18667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 18560, 18679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 18560, 18679);
            }
        }

        public static void Fail(string format, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 18691, 18851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 18776, 18840);

                throw f_25000_18782_18839(f_25000_18811_18838(format, args));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 18691, 18851);

                string
                f_25000_18811_18838(string
                format, params object[]
                args)
                {
                    var return_v = string.Format(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 18811, 18838);
                    return return_v;
                }


                Xunit.Sdk.XunitException
                f_25000_18782_18839(string
                userMessage)
                {
                    var return_v = new Xunit.Sdk.XunitException(userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 18782, 18839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 18691, 18851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 18691, 18851);
            }
        }

        public static void NotNull<T>(T @object, string message = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 18863, 19033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 18951, 19022);

                f_25000_18951_19021<T>(f_25000_18970_19011<T>(@object), message);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 18863, 19033);

                bool
                f_25000_18970_19011<T>(T
                @object)
                {
                    var return_v = AssertEqualityComparer<T>.IsNull(@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 18970, 19011);
                    return return_v;
                }


                bool
                f_25000_18951_19021<T>(bool
                condition, string?
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 18951, 19021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 18863, 19033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 18863, 19033);
            }
        }

        public static bool AssertEqualToleratingWhitespaceDifferences(
                    string expected,
                    string actual,
                    bool escapeQuotes = true,
                    [CallerFilePath] string expectedValueSourcePath = null,
                    [CallerLineNumber] int expectedValueSourceLine = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 19085, 19956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 19403, 19458);

                var
                normalizedExpected = f_25000_19428_19457(expected)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 19472, 19523);

                var
                normalizedActual = f_25000_19495_19522(actual)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 19539, 19755) || true) && (normalizedExpected != normalizedActual)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 19539, 19755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 19615, 19740);

                    f_25000_19615_19739(false, f_25000_19640_19738(expected, actual, escapeQuotes, expectedValueSourcePath, expectedValueSourceLine));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 19539, 19755);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 19861, 19915);

                var
                toReturn = normalizedExpected != normalizedActual
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 19929, 19945);

                return toReturn;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 19085, 19956);

                string
                f_25000_19428_19457(string
                input)
                {
                    var return_v = NormalizeWhitespace(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 19428, 19457);
                    return return_v;
                }


                string
                f_25000_19495_19522(string
                input)
                {
                    var return_v = NormalizeWhitespace(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 19495, 19522);
                    return return_v;
                }


                string
                f_25000_19640_19738(string
                expected, string
                actual, bool
                escapeQuotes, string
                expectedValueSourcePath, int
                expectedValueSourceLine)
                {
                    var return_v = GetAssertMessage(expected, actual, escapeQuotes, expectedValueSourcePath, expectedValueSourceLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 19640, 19738);
                    return return_v;
                }


                bool
                f_25000_19615_19739(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 19615, 19739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 19085, 19956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 19085, 19956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void AssertResultsEqual(string result1, string result2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 20015, 20766);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20109, 20755) || true) && (result1 != result2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 20109, 20755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20165, 20180);

                    string
                    message
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20200, 20686) || true) && (f_25000_20204_20221())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 20200, 20686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20263, 20301);

                        string
                        file1 = f_25000_20278_20300()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20323, 20357);

                        f_25000_20323_20356(file1, result1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20381, 20419);

                        string
                        file2 = f_25000_20396_20418()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20441, 20475);

                        f_25000_20441_20474(file2, result2);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20499, 20540);

                        message = f_25000_20509_20539(file1, file2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 20200, 20686);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 20200, 20686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20622, 20667);

                        message = f_25000_20632_20666(result1, result2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 20200, 20686);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20706, 20740);

                    f_25000_20706_20739(false, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 20109, 20755);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 20015, 20766);

                bool
                f_25000_20204_20221()
                {
                    var return_v = DiffToolAvailable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 20204, 20221);
                    return return_v;
                }


                string
                f_25000_20278_20300()
                {
                    var return_v = Path.GetTempFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 20278, 20300);
                    return return_v;
                }


                int
                f_25000_20323_20356(string
                path, string
                contents)
                {
                    File.WriteAllText(path, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 20323, 20356);
                    return 0;
                }


                string
                f_25000_20396_20418()
                {
                    var return_v = Path.GetTempFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 20396, 20418);
                    return return_v;
                }


                int
                f_25000_20441_20474(string
                path, string
                contents)
                {
                    File.WriteAllText(path, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 20441, 20474);
                    return 0;
                }


                string
                f_25000_20509_20539(string
                actualFilePath, string
                expectedFilePath)
                {
                    var return_v = MakeDiffToolLink(actualFilePath, expectedFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 20509, 20539);
                    return return_v;
                }


                string
                f_25000_20632_20666(string
                expected, string
                actual)
                {
                    var return_v = GetAssertMessage(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 20632, 20666);
                    return return_v;
                }


                bool
                f_25000_20706_20739(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 20706, 20739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 20015, 20766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 20015, 20766);
            }
        }

        public static void AssertContainsToleratingWhitespaceDifferences(string expectedSubString, string actualString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 20778, 21142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20914, 20973);

                expectedSubString = f_25000_20934_20972(expectedSubString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 20987, 21036);

                actualString = f_25000_21002_21035(actualString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 21050, 21131);

                f_25000_21050_21130(expectedSubString, actualString, StringComparison.Ordinal);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 20778, 21142);

                string
                f_25000_20934_20972(string
                input)
                {
                    var return_v = NormalizeWhitespace(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 20934, 20972);
                    return return_v;
                }


                string
                f_25000_21002_21035(string
                input)
                {
                    var return_v = NormalizeWhitespace(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 21002, 21035);
                    return return_v;
                }


                bool
                f_25000_21050_21130(string
                expectedSubstring, string
                actualString, System.StringComparison
                comparisonType)
                {
                    var return_v = CustomAssert.Contains(expectedSubstring, actualString, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 21050, 21130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 20778, 21142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 20778, 21142);
            }
        }

        public static void AssertStartsWithToleratingWhitespaceDifferences(string expectedSubString, string actualString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 21154, 21522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 21292, 21351);

                expectedSubString = f_25000_21312_21350(expectedSubString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 21365, 21414);

                actualString = f_25000_21380_21413(actualString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 21428, 21511);

                f_25000_21428_21510(expectedSubString, actualString, StringComparison.Ordinal);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 21154, 21522);

                string
                f_25000_21312_21350(string
                input)
                {
                    var return_v = NormalizeWhitespace(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 21312, 21350);
                    return return_v;
                }


                string
                f_25000_21380_21413(string
                input)
                {
                    var return_v = NormalizeWhitespace(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 21380, 21413);
                    return return_v;
                }


                bool
                f_25000_21428_21510(string
                expectedStartString, string
                actualString, System.StringComparison
                comparisonType)
                {
                    var return_v = CustomAssert.StartsWith(expectedStartString, actualString, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 21428, 21510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 21154, 21522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 21154, 21522);
            }
        }

        internal static string NormalizeWhitespace(string input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 21534, 22185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 21615, 21648);

                var
                output = f_25000_21628_21647()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 21662, 21703);

                var
                inputLines = f_25000_21679_21702(input, '\n', '\r')
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 21717, 22133);
                    foreach (var line in f_25000_21738_21748_I(inputLines))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 21717, 22133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 21782, 21812);

                        var
                        trimmedLine = f_25000_21800_21811(line)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 21830, 22118) || true) && (f_25000_21834_21852(trimmedLine) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 21830, 22118);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 21898, 22044) || true) && (!(f_25000_21904_21918(trimmedLine, 0) == '{' || (DynAbs.Tracing.TraceSender.Expression_False(25000, 21904, 21950) || f_25000_21929_21943(trimmedLine, 0) == '}')))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 21898, 22044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 22001, 22021);

                                f_25000_22001_22020(output, "  ");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 21898, 22044);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 22068, 22099);

                            f_25000_22068_22098(
                                                output, trimmedLine);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 21830, 22118);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 21717, 22133);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 22149, 22174);

                return f_25000_22156_22173(output);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 21534, 22185);

                System.Text.StringBuilder
                f_25000_21628_21647()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 21628, 21647);
                    return return_v;
                }


                string[]
                f_25000_21679_21702(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 21679, 21702);
                    return return_v;
                }


                string
                f_25000_21800_21811(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 21800, 21811);
                    return return_v;
                }


                int
                f_25000_21834_21852(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 21834, 21852);
                    return return_v;
                }


                char
                f_25000_21904_21918(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 21904, 21918);
                    return return_v;
                }


                char
                f_25000_21929_21943(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 21929, 21943);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_22001_22020(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 22001, 22020);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_22068_22098(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 22068, 22098);
                    return return_v;
                }


                string[]
                f_25000_21738_21748_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 21738, 21748);
                    return return_v;
                }


                string
                f_25000_22156_22173(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 22156, 22173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 21534, 22185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 21534, 22185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetAssertMessage(string expected, string actual, bool escapeQuotes = false, string expectedValueSourcePath = null, int expectedValueSourceLine = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 22197, 22539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 22390, 22528);

                return f_25000_22397_22527(f_25000_22414_22438(expected), f_25000_22440_22462(actual), escapeQuotes, expectedValueSourcePath, expectedValueSourceLine);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 22197, 22539);

                string[]
                f_25000_22414_22438(string
                s)
                {
                    var return_v = DiffUtil.Lines(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 22414, 22438);
                    return return_v;
                }


                string[]
                f_25000_22440_22462(string
                s)
                {
                    var return_v = DiffUtil.Lines(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 22440, 22462);
                    return return_v;
                }


                string
                f_25000_22397_22527(string[]
                expected, string[]
                actual, bool
                escapeQuotes, string?
                expectedValueSourcePath, int
                expectedValueSourceLine)
                {
                    var return_v = GetAssertMessage((System.Collections.Generic.IEnumerable<string>)expected, (System.Collections.Generic.IEnumerable<string>)actual, escapeQuotes, expectedValueSourcePath, expectedValueSourceLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 22397, 22527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 22197, 22539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 22197, 22539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetAssertMessage<T>(IEnumerable<T> expected, IEnumerable<T> actual, bool escapeQuotes, string expectedValueSourcePath = null, int expectedValueSourceLine = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 22551, 23090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 22755, 22870);

                Func<T, string>
                itemInspector = (DynAbs.Tracing.TraceSender.Conditional_F1(25000, 22787, 22799) || ((escapeQuotes && DynAbs.Tracing.TraceSender.Conditional_F2(25000, 22802, 22862)) || DynAbs.Tracing.TraceSender.Conditional_F3(25000, 22865, 22869))) ? new Func<T, string>(t => t.ToString().Replace("\"", "\"\"")) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 22884, 23079);

                return f_25000_22891_23078<T>(expected, actual, itemInspector: itemInspector, itemSeparator: "\r\n", expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 22551, 23090);

                string
                f_25000_22891_23078<T>(System.Collections.Generic.IEnumerable<T>
                expected, System.Collections.Generic.IEnumerable<T>
                actual, System.Func<T, string>?
                itemInspector, string
                itemSeparator, string?
                expectedValueSourcePath, int
                expectedValueSourceLine)
                {
                    var return_v = GetAssertMessage(expected, actual, itemInspector: itemInspector, itemSeparator: itemSeparator, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 22891, 23078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 22551, 23090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 22551, 23090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly string s_diffToolPath;

        public static string GetAssertMessage<T>(
                    IEnumerable<T> expected,
                    IEnumerable<T> actual,
                    IEqualityComparer<T> comparer = null,
                    Func<T, string> itemInspector = null,
                    string itemSeparator = null,
                    string expectedValueSourcePath = null,
                    int expectedValueSourceLine = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 23216, 25329);
                string link = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 23598, 23963) || true) && (itemInspector == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 23598, 23963);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 23657, 23948) || true) && (typeof(T) == typeof(byte))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 23657, 23948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 23728, 23761);

                        itemInspector = b => $"0x{b:X2}";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 23657, 23948);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 23657, 23948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 23843, 23929);

                        itemInspector = new Func<T, string>(obj => (obj != null) ? obj.ToString() : "<null>");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 23657, 23948);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 23598, 23963);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 23979, 24288) || true) && (itemSeparator == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 23979, 24288);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24038, 24273) || true) && (typeof(T) == typeof(byte))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 24038, 24273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24109, 24130);

                        itemSeparator = ", ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 24038, 24273);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 24038, 24273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24212, 24254);

                        itemSeparator = "," + f_25000_24234_24253<T>();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 24038, 24273);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 23979, 24288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24304, 24393);

                var
                expectedString = f_25000_24325_24392<T>(itemSeparator, f_25000_24352_24391<T>(f_25000_24352_24369<T>(expected, 10), itemInspector))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24407, 24483);

                var
                actualString = f_25000_24426_24482<T>(itemSeparator, f_25000_24453_24481<T>(actual, itemInspector))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24499, 24533);

                var
                message = f_25000_24513_24532<T>()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24547, 24568);

                f_25000_24547_24567<T>(message);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24582, 24614);

                f_25000_24582_24613<T>(message, "Expected:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24628, 24663);

                f_25000_24628_24662<T>(message, expectedString);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24677, 24791) || true) && (f_25000_24681_24697<T>(expected) > 10)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 24677, 24791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24736, 24776);

                    f_25000_24736_24775<T>(message, "... truncated ...");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 24677, 24791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24805, 24835);

                f_25000_24805_24834<T>(message, "Actual:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24849, 24882);

                f_25000_24849_24881<T>(message, actualString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24896, 24931);

                f_25000_24896_24930<T>(message, "Differences:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 24945, 25043);

                f_25000_24945_25042<T>(message, f_25000_24964_25041<T>(expected, actual, itemSeparator, comparer, itemInspector));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 25059, 25276) || true) && (f_25000_25063_25202<T>(actualString, f_25000_25121_25137<T>(expected), expectedValueSourcePath, expectedValueSourceLine, out link))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 25059, 25276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 25236, 25261);

                    f_25000_25236_25260<T>(message, link);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 25059, 25276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 25292, 25318);

                return f_25000_25299_25317<T>(message);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 23216, 25329);

                string
                f_25000_24234_24253<T>()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 24234, 24253);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_25000_24352_24369<T>(System.Collections.Generic.IEnumerable<T>
                source, int
                count)
                {
                    var return_v = source.Take<T>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24352, 24369);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25000_24352_24391<T>(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, string>
                selector)
                {
                    var return_v = source.Select<T, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24352, 24391);
                    return return_v;
                }


                string
                f_25000_24325_24392<T>(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24325, 24392);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25000_24453_24481<T>(System.Collections.Generic.IEnumerable<T>
                source, System.Func<T, string>
                selector)
                {
                    var return_v = source.Select<T, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24453, 24481);
                    return return_v;
                }


                string
                f_25000_24426_24482<T>(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24426, 24482);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_24513_24532<T>()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24513, 24532);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_24547_24567<T>(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24547, 24567);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_24582_24613<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24582, 24613);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_24628_24662<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24628, 24662);
                    return return_v;
                }


                int
                f_25000_24681_24697<T>(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.Count<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24681, 24697);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_24736_24775<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24736, 24775);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_24805_24834<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24805, 24834);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_24849_24881<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24849, 24881);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_24896_24930<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24896, 24930);
                    return return_v;
                }


                string
                f_25000_24964_25041<T>(System.Collections.Generic.IEnumerable<T>
                expected, System.Collections.Generic.IEnumerable<T>
                actual, string
                separator, System.Collections.Generic.IEqualityComparer<T>?
                comparer, System.Func<T, string>
                toString)
                {
                    var return_v = DiffUtil.DiffReport(expected, actual, separator, comparer, toString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24964, 25041);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_24945_25042<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 24945, 25042);
                    return return_v;
                }


                int
                f_25000_25121_25137<T>(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.Count<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 25121, 25137);
                    return return_v;
                }


                bool
                f_25000_25063_25202<T>(string
                actualString, int
                expectedLineCount, string?
                expectedValueSourcePath, int
                expectedValueSourceLine, out string
                link)
                {
                    var return_v = TryGenerateExpectedSourceFileAndGetDiffLink(actualString, expectedLineCount, expectedValueSourcePath, expectedValueSourceLine, out link);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 25063, 25202);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_25236_25260<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 25236, 25260);
                    return return_v;
                }


                string
                f_25000_25299_25317<T>(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 25299, 25317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 23216, 25329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 23216, 25329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryGenerateExpectedSourceFileAndGetDiffLink(string actualString, int expectedLineCount, string expectedValueSourcePath, int expectedValueSourceLine, out string link)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 25341, 26329);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 25618, 26263) || true) && (f_25000_25622_25639() && (DynAbs.Tracing.TraceSender.Expression_True(25000, 25622, 25674) && expectedValueSourcePath != null) && (DynAbs.Tracing.TraceSender.Expression_True(25000, 25622, 25706) && expectedValueSourceLine != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 25618, 26263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 25740, 25780);

                    var
                    actualFile = f_25000_25757_25779()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 25798, 25861);

                    var
                    testFileLines = f_25000_25818_25860(expectedValueSourcePath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 25881, 25957);

                    f_25000_25881_25956(actualFile, f_25000_25912_25955(testFileLines, expectedValueSourceLine));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 25975, 26020);

                    f_25000_25975_26019(actualFile, actualString);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 26038, 26135);

                    f_25000_26038_26134(actualFile, f_25000_26070_26133(testFileLines, expectedValueSourceLine + expectedLineCount));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 26155, 26216);

                    link = f_25000_26162_26215(actualFile, expectedValueSourcePath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 26236, 26248);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 25618, 26263);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 26279, 26291);

                link = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 26305, 26318);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 25341, 26329);

                bool
                f_25000_25622_25639()
                {
                    var return_v = DiffToolAvailable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 25622, 25639);
                    return return_v;
                }


                string
                f_25000_25757_25779()
                {
                    var return_v = Path.GetTempFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 25757, 25779);
                    return return_v;
                }


                string[]
                f_25000_25818_25860(string
                path)
                {
                    var return_v = File.ReadAllLines(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 25818, 25860);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25000_25912_25955(string[]
                source, int
                count)
                {
                    var return_v = source.Take<string>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 25912, 25955);
                    return return_v;
                }


                int
                f_25000_25881_25956(string
                path, System.Collections.Generic.IEnumerable<string>
                contents)
                {
                    File.WriteAllLines(path, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 25881, 25956);
                    return 0;
                }


                int
                f_25000_25975_26019(string
                path, string
                contents)
                {
                    File.AppendAllText(path, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 25975, 26019);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25000_26070_26133(string[]
                source, int
                count)
                {
                    var return_v = source.Skip<string>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 26070, 26133);
                    return return_v;
                }


                int
                f_25000_26038_26134(string
                path, System.Collections.Generic.IEnumerable<string>
                contents)
                {
                    File.AppendAllLines(path, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 26038, 26134);
                    return 0;
                }


                string
                f_25000_26162_26215(string
                actualFilePath, string
                expectedFilePath)
                {
                    var return_v = MakeDiffToolLink(actualFilePath, expectedFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 26162, 26215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 25341, 26329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 25341, 26329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool DiffToolAvailable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25000, 26380, 26420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 26383, 26420);
                    return !f_25000_26384_26420(s_diffToolPath); DynAbs.Tracing.TraceSender.TraceExitMethod(25000, 26380, 26420);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 26380, 26420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 26380, 26420);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static string MakeDiffToolLink(string actualFilePath, string expectedFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 26433, 26787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 26545, 26594);

                var
                compareCmd = f_25000_26562_26584() + ".cmd"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 26608, 26730);

                f_25000_26608_26729(compareCmd, f_25000_26638_26728("\"{0}\" \"{1}\" \"{2}\"", s_diffToolPath, actualFilePath, expectedFilePath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 26746, 26776);

                return "file://" + compareCmd;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 26433, 26787);

                string
                f_25000_26562_26584()
                {
                    var return_v = Path.GetTempFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 26562, 26584);
                    return return_v;
                }


                string
                f_25000_26638_26728(string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 26638, 26728);
                    return return_v;
                }


                int
                f_25000_26608_26729(string
                path, string
                contents)
                {
                    File.WriteAllText(path, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 26608, 26729);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 26433, 26787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 26433, 26787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void Empty<T>(IEnumerable<T> items, string message = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 26799, 27225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 26997, 27023);

                var
                list = f_25000_27008_27022<T>(items)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 27037, 27214) || true) && (f_25000_27041_27051<T>(list) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 27037, 27214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 27090, 27199);

                    f_25000_27090_27198<T>($"Expected 0 items but found {f_25000_27125_27135<T>(list)}: {message}\r\nItems:\r\n    {f_25000_27166_27195<T>("\r\n    ", list)}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 27037, 27214);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 26799, 27225);

                System.Collections.Generic.List<T>
                f_25000_27008_27022<T>(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.ToList<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27008, 27022);
                    return return_v;
                }


                int
                f_25000_27041_27051<T>(System.Collections.Generic.List<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 27041, 27051);
                    return return_v;
                }


                int
                f_25000_27125_27135<T>(System.Collections.Generic.List<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 27125, 27135);
                    return return_v;
                }


                string
                f_25000_27166_27195<T>(string
                separator, System.Collections.Generic.List<T>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<T>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27166, 27195);
                    return return_v;
                }


                int
                f_25000_27090_27198<T>(string
                message)
                {
                    Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27090, 27198);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 26799, 27225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 26799, 27225);
            }
        }
        private sealed class LineComparer : IEqualityComparer<string>
        {
            public static readonly LineComparer Instance;

            public bool Equals(string left, string right)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25000, 27451, 27481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 27454, 27481);
                    return f_25000_27454_27465(left) == f_25000_27469_27481(right); DynAbs.Tracing.TraceSender.TraceExitMethod(25000, 27451, 27481);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 27451, 27481);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 27451, 27481);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(string str)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25000, 27531, 27558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 27534, 27558);
                    return f_25000_27534_27558(f_25000_27534_27544(str)); DynAbs.Tracing.TraceSender.TraceExitMethod(25000, 27531, 27558);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 27531, 27558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 27531, 27558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LineComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25000, 27237, 27570);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25000, 27237, 27570);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 27237, 27570);
            }


            static LineComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25000, 27237, 27570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 27359, 27388);
                Instance = f_25000_27370_27388(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25000, 27237, 27570);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 27237, 27570);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25000, 27237, 27570);

            static Roslyn.Test.Utilities.AssertEx.LineComparer
            f_25000_27370_27388()
            {
                var return_v = new Roslyn.Test.Utilities.AssertEx.LineComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27370, 27388);
                return return_v;
            }


            string
            f_25000_27454_27465(string
            this_param)
            {
                var return_v = this_param.Trim();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27454, 27465);
                return return_v;
            }


            string
            f_25000_27469_27481(string
            this_param)
            {
                var return_v = this_param.Trim();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27469, 27481);
                return return_v;
            }


            string
            f_25000_27534_27544(string
            this_param)
            {
                var return_v = this_param.Trim();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27534, 27544);
                return return_v;
            }


            int
            f_25000_27534_27558(string
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27534, 27558);
                return return_v;
            }

        }

        public static bool AssertLinesEqual(string expected, string actual, string message, string expectedValueSourcePath, int expectedValueSourceLine, bool escapeQuotes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 27582, 28412);

                IEnumerable<string> GetLines(string str)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25000, 27811, 27901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 27831, 27901);
                        return f_25000_27831_27901(str, new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); DynAbs.Tracing.TraceSender.TraceExitMethod(25000, 27811, 27901);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 27811, 27901);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 27811, 27901);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 27918, 28401);

                return f_25000_27925_28400(f_25000_27958_27976(expected), f_25000_27995_28011(actual), comparer: LineComparer.Instance, message: message, itemInspector: (DynAbs.Tracing.TraceSender.Conditional_F1(25000, 28130, 28142) || ((escapeQuotes && DynAbs.Tracing.TraceSender.Conditional_F2(25000, 28145, 28205)) || DynAbs.Tracing.TraceSender.Conditional_F3(25000, 28208, 28212))) ? new Func<string, string>(line => line.Replace("\"", "\"\"")) : null, itemSeparator: f_25000_28246_28265(), expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 27582, 28412);

                string[]
                f_25000_27831_27901(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27831, 27901);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25000_27958_27976(string
                str)
                {
                    var return_v = GetLines(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27958, 27976);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25000_27995_28011(string
                str)
                {
                    var return_v = GetLines(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27995, 28011);
                    return return_v;
                }


                string
                f_25000_28246_28265()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 28246, 28265);
                    return return_v;
                }


                bool
                f_25000_27925_28400(System.Collections.Generic.IEnumerable<string>
                expected, System.Collections.Generic.IEnumerable<string>
                actual, Roslyn.Test.Utilities.AssertEx.LineComparer
                comparer, string
                message, System.Func<string, string>?
                itemInspector, string
                itemSeparator, string
                expectedValueSourcePath, int
                expectedValueSourceLine)
                {
                    var return_v = AssertEx.Equal(expected, actual, comparer: (System.Collections.Generic.IEqualityComparer<string>)comparer, message: message, itemInspector: itemInspector, itemSeparator: itemSeparator, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 27925, 28400);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 27582, 28412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 27582, 28412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void Throws<TException>(Action action, Action<TException> checker = null)
                    where TException : Exception
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 28424, 29004);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 28614, 28623);

                    f_25000_28614_28622<TException>(action);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(25000, 28652, 28993);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 28704, 28857) || true) && (e is AggregateException agg && (DynAbs.Tracing.TraceSender.Expression_True(25000, 28708, 28769) && f_25000_28739_28764<TException>(f_25000_28739_28758<TException>(agg)) == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 28704, 28857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 28811, 28838);

                        e = f_25000_28815_28837<TException>(f_25000_28815_28834<TException>(agg), 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 28704, 28857);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 28877, 28929);

                    f_25000_28877_28928<TException>(typeof(TException), f_25000_28916_28927<TException>(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 28947, 28978);

                    f_25000_28955_28977<TException>(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(checker, 25000, 28947, 28977), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(25000, 28652, 28993);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 28424, 29004);

                int
                f_25000_28614_28622<TException>(System.Action
                this_param) where TException : Exception

                {
                    this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 28614, 28622);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                f_25000_28739_28758<TException>(System.AggregateException
                this_param) where TException : Exception

                {
                    var return_v = this_param.InnerExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 28739, 28758);
                    return return_v;
                }


                int
                f_25000_28739_28764<TException>(System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                this_param) where TException : Exception

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 28739, 28764);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                f_25000_28815_28834<TException>(System.AggregateException
                this_param) where TException : Exception

                {
                    var return_v = this_param.InnerExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 28815, 28834);
                    return return_v;
                }


                System.Exception
                f_25000_28815_28837<TException>(System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
                this_param, int
                i0) where TException : Exception

                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25000, 28815, 28837);
                    return return_v;
                }


                System.Type
                f_25000_28916_28927<TException>(System.Exception
                this_param) where TException : Exception

                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 28916, 28927);
                    return return_v;
                }


                bool
                f_25000_28877_28928<TException>(System.Type
                expected, System.Type
                actual) where TException : Exception

                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 28877, 28928);
                    return return_v;
                }


                int
                f_25000_28955_28977<TException>(System.Action<TException>
                this_param, System.Exception
                obj) where TException : Exception

                {
                    this_param?.Invoke((TException)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 28955, 28977);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 28424, 29004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 28424, 29004);
            }
        }

        public static void Equal(bool[,] expected, Func<int, int, bool> getResult, int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 29016, 29236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29125, 29225);

                f_25000_29125_29224(expected, getResult, (b1, b2) => b1 == b2, b => b ? "true" : "false", "{0,-6:G}", size);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 29016, 29236);

                int
                f_25000_29125_29224(bool[,]
                expected, System.Func<int, int, bool>
                getResult, System.Func<bool, bool, bool>
                valuesEqual, System.Func<bool, string>
                printValue, string
                format, int
                size)
                {
                    Equal<bool>(expected, getResult, valuesEqual, printValue, format, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 29125, 29224);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 29016, 29236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 29016, 29236);
            }
        }

        public static void Equal<T>(T[,] expected, Func<int, int, T> getResult, Func<T, T, bool> valuesEqual, Func<T, string> printValue, string format, int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 29248, 30745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29427, 29449);

                bool
                mismatch = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29472, 29477);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29463, 29769) || true) && (i < size)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29489, 29492)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 29463, 29769))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 29463, 29769);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29535, 29540);
                            for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29526, 29754) || true) && (j < size)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29552, 29555)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 29526, 29754))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 29526, 29754);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29597, 29735) || true) && (!f_25000_29602_29646<T>(valuesEqual, expected[i, j], f_25000_29630_29645<T>(getResult, i, j)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 29597, 29735);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29696, 29712);

                                    mismatch = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 29597, 29735);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 229);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 229);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 307);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29785, 30734) || true) && (mismatch)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 29785, 30734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29831, 29865);

                    var
                    builder = f_25000_29845_29864<T>()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29883, 29921);

                    f_25000_29883_29920<T>(builder, "Actual result: ");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29948, 29953);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29939, 30654) || true) && (i < size)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 29965, 29968)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 29939, 30654))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 29939, 30654);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30010, 30031);

                            f_25000_30010_30030<T>(builder, "{ ");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30062, 30067);
                                for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30053, 30588) || true) && (j < size)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30079, 30082)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 30053, 30588))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 30053, 30588);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30132, 30185);

                                    string
                                    resultWithComma = f_25000_30157_30184<T>(printValue, f_25000_30168_30183<T>(getResult, i, j))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30211, 30335) || true) && (j < size - 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 30211, 30335);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30285, 30308);

                                        resultWithComma += ",";
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 30211, 30335);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30363, 30418);

                                    f_25000_30363_30417<T>(
                                                            builder, f_25000_30378_30416<T>(format, resultWithComma));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30444, 30565) || true) && (j < size - 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25000, 30444, 30565);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30518, 30538);

                                        f_25000_30518_30537<T>(builder, ' ');
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 30444, 30565);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 536);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 536);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30610, 30635);

                            f_25000_30610_30634<T>(builder, "},");
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25000, 1, 716);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25000, 1, 716);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30674, 30719);

                    f_25000_30674_30718<T>(false, f_25000_30699_30717<T>(builder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25000, 29785, 30734);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 29248, 30745);

                T
                f_25000_29630_29645<T>(System.Func<int, int, T>
                this_param, int
                arg1, int
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 29630, 29645);
                    return return_v;
                }


                bool
                f_25000_29602_29646<T>(System.Func<T, T, bool>
                this_param, T
                arg1, T
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 29602, 29646);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_29845_29864<T>()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 29845, 29864);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_29883_29920<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 29883, 29920);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_30010_30030<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30010, 30030);
                    return return_v;
                }


                T
                f_25000_30168_30183<T>(System.Func<int, int, T>
                this_param, int
                arg1, int
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30168, 30183);
                    return return_v;
                }


                string
                f_25000_30157_30184<T>(System.Func<T, string>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30157, 30184);
                    return return_v;
                }


                string
                f_25000_30378_30416<T>(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30378, 30416);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_30363_30417<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30363, 30417);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_30518_30537<T>(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30518, 30537);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25000_30610_30634<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30610, 30634);
                    return return_v;
                }


                string
                f_25000_30699_30717<T>(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30699, 30717);
                    return return_v;
                }


                bool
                f_25000_30674_30718<T>(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30674, 30718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 29248, 30745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 29248, 30745);
            }
        }

        public static void NotNull<T>([NotNull] T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25000, 30775, 30931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30848, 30876);

                f_25000_30848_30875<T>(value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 30890, 30920);

                f_25000_30890_30919<T>(value is object);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25000, 30775, 30931);

                bool
                f_25000_30848_30875<T>(T?
                @object)
                {
                    var return_v = CustomAssert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30848, 30875);
                    return return_v;
                }


                int
                f_25000_30890_30919<T>(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 30890, 30919);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25000, 30775, 30931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 30775, 30931);
            }
        }

        static AssertEx()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25000, 840, 30959);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25000, 23133, 23203);
            s_diffToolPath = f_25000_23150_23203("ROSLYN_DIFFTOOL"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25000, 840, 30959);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25000, 840, 30959);
        }


        static int
        f_25000_16391_16433<T>(T[]
        actual, params T[]
        expected)
        {
            SetEqual((System.Collections.Generic.IEnumerable<T>)actual, expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 16391, 16433);
            return 0;
        }


        static string?
        f_25000_23150_23203(string
        variable)
        {
            var return_v = Environment.GetEnvironmentVariable(variable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 23150, 23203);
            return return_v;
        }


        static bool
        f_25000_26384_26420(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25000, 26384, 26420);
            return return_v;
        }

    }
}
