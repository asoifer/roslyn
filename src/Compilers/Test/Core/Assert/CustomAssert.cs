// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Roslyn.Test.Utilities
{
    public static class CustomAssert
    {
        public static bool True(bool condition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 495, 619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 559, 582);

                f_25008_559_581(condition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 596, 608);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 495, 619);

                int
                f_25008_559_581(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 559, 581);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 495, 619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 495, 619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool True(bool condition, string userMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 631, 788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 715, 751);

                f_25008_715_750(condition, userMessage);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 765, 777);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 631, 788);

                int
                f_25008_715_750(bool
                condition, string
                userMessage)
                {
                    Assert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 715, 750);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 631, 788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 631, 788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool False(bool condition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 800, 926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 865, 889);

                f_25008_865_888(condition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 903, 915);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 800, 926);

                int
                f_25008_865_888(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 865, 888);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 800, 926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 800, 926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool False(bool condition, string userMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 938, 1097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1023, 1060);

                f_25008_1023_1059(condition, userMessage);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1074, 1086);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 938, 1097);

                int
                f_25008_1023_1059(bool
                condition, string
                userMessage)
                {
                    Assert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 1023, 1059);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 938, 1097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 938, 1097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Null(object @object)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 1109, 1231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1173, 1194);

                f_25008_1173_1193(@object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1208, 1220);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 1109, 1231);

                int
                f_25008_1173_1193(object
                @object)
                {
                    Assert.Null(@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 1173, 1193);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 1109, 1231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 1109, 1231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool NotNull(object @object)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 1243, 1371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1310, 1334);

                f_25008_1310_1333(@object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1348, 1360);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 1243, 1371);

                int
                f_25008_1310_1333(object
                @object)
                {
                    Assert.NotNull(@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 1310, 1333);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 1243, 1371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 1243, 1371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Equal<T>(T expected, T actual, IEqualityComparer<T> equalityComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 1383, 1582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1496, 1545);

                f_25008_1496_1544<T>(expected, actual, equalityComparer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1559, 1571);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 1383, 1582);

                int
                f_25008_1496_1544<T>(T?
                expected, T?
                actual, System.Collections.Generic.IEqualityComparer<T>
                comparer)
                {
                    Assert.Equal(expected, actual, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 1496, 1544);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 1383, 1582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 1383, 1582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Equal<T>(T expected, T actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 1594, 1736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1668, 1699);

                f_25008_1668_1698<T>(expected, actual);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1713, 1725);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 1594, 1736);

                int
                f_25008_1668_1698<T>(T?
                expected, T?
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 1668, 1698);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 1594, 1736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 1594, 1736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool NotEqual<T>(T expected, T actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 1748, 1896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1825, 1859);

                f_25008_1825_1858<T>(expected, actual);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1873, 1885);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 1748, 1896);

                int
                f_25008_1825_1858<T>(T?
                expected, T?
                actual)
                {
                    Assert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 1825, 1858);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 1748, 1896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 1748, 1896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Empty(IEnumerable enumerable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 1908, 2043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 1981, 2006);

                f_25008_1981_2005(enumerable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2020, 2032);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 1908, 2043);

                int
                f_25008_1981_2005(System.Collections.IEnumerable
                collection)
                {
                    Assert.Empty(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 1981, 2005);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 1908, 2043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 1908, 2043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool NotEmpty(IEnumerable enumerable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 2055, 2196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2131, 2159);

                f_25008_2131_2158(enumerable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2173, 2185);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 2055, 2196);

                int
                f_25008_2131_2158(System.Collections.IEnumerable
                collection)
                {
                    Assert.NotEmpty(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 2131, 2158);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 2055, 2196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 2055, 2196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Contains(string expectedSubstring, string actualString, StringComparison comparisonType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 2208, 2442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2340, 2405);

                f_25008_2340_2404(expectedSubstring, actualString, comparisonType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2419, 2431);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 2208, 2442);

                int
                f_25008_2340_2404(string
                expectedSubstring, string
                actualString, System.StringComparison
                comparisonType)
                {
                    Assert.Contains(expectedSubstring, actualString, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 2340, 2404);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 2208, 2442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 2208, 2442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Contains(string expectedSubstring, string actualString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 2454, 2639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2553, 2602);

                f_25008_2553_2601(expectedSubstring, actualString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2616, 2628);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 2454, 2639);

                int
                f_25008_2553_2601(string
                expectedSubstring, string
                actualString)
                {
                    Assert.Contains(expectedSubstring, actualString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 2553, 2601);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 2454, 2639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 2454, 2639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Contains<T>(IEnumerable<T> collection, Predicate<T> filter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 2651, 2827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2754, 2790);

                f_25008_2754_2789<T>(collection, filter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2804, 2816);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 2651, 2827);

                int
                f_25008_2754_2789<T>(System.Collections.Generic.IEnumerable<T>
                collection, System.Predicate<T>
                filter)
                {
                    Assert.Contains(collection, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 2754, 2789);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 2651, 2827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 2651, 2827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Contains<T>(T expected, IEnumerable<T> collection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 2839, 3008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2933, 2971);

                f_25008_2933_2970<T>(expected, collection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 2985, 2997);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 2839, 3008);

                int
                f_25008_2933_2970<T>(T?
                expected, System.Collections.Generic.IEnumerable<T>
                collection)
                {
                    Assert.Contains(expected, collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 2933, 2970);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 2839, 3008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 2839, 3008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool DoesNotContain(string expectedSubstring, string[] actualString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 3020, 3219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 3127, 3182);

                f_25008_3127_3181(expectedSubstring, actualString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 3196, 3208);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 3020, 3219);

                int
                f_25008_3127_3181(string
                expected, string[]
                collection)
                {
                    Assert.DoesNotContain(expected, (System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 3127, 3181);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 3020, 3219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 3020, 3219);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool StartsWith(string expectedStartString, string actualString, StringComparison comparisonType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 3231, 3473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 3367, 3436);

                f_25008_3367_3435(expectedStartString, actualString, comparisonType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 3450, 3462);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 3231, 3473);

                int
                f_25008_3367_3435(string
                expectedStartString, string
                actualString, System.StringComparison
                comparisonType)
                {
                    Assert.StartsWith(expectedStartString, actualString, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 3367, 3435);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 3231, 3473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 3231, 3473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Same(object expected, object actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 3485, 3632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 3565, 3595);

                f_25008_3565_3594(expected, actual);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 3609, 3621);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 3485, 3632);

                int
                f_25008_3565_3594(object
                expected, object
                actual)
                {
                    Assert.Same(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 3565, 3594);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 3485, 3632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 3485, 3632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool NotSame(object expected, object actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 3644, 3797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 3727, 3760);

                f_25008_3727_3759(expected, actual);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 3774, 3786);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 3644, 3797);

                int
                f_25008_3727_3759(object
                expected, object
                actual)
                {
                    Assert.NotSame(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 3727, 3759);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 3644, 3797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 3644, 3797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T IsType<T>(object @object)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 3809, 3919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 3875, 3908);

                return f_25008_3882_3907<T>(@object);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 3809, 3919);

                T
                f_25008_3882_3907<T>(object
                @object)
                {
                    var return_v = Assert.IsType<T>(@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 3882, 3907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 3809, 3919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 3809, 3919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAssignableFrom(Type expectedType, object @object)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 3931, 4110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 4026, 4073);

                f_25008_4026_4072(expectedType, @object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 4087, 4099);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 3931, 4110);

                int
                f_25008_4026_4072(System.Type
                expectedType, object
                @object)
                {
                    Assert.IsAssignableFrom(expectedType, @object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 4026, 4072);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 3931, 4110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 3931, 4110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T Throws<T>(Func<object> testCode) where T : Exception
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 4122, 4260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 4215, 4249);

                return f_25008_4222_4248<T>(testCode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 4122, 4260);

                T
                f_25008_4222_4248<T>(System.Func<object>
                testCode) where T : Exception

                {
                    var return_v = Assert.Throws<T>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 4222, 4248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 4122, 4260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 4122, 4260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool InRange(int a, int b, int c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25008, 4272, 4405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 4344, 4368);

                f_25008_4344_4367(a, b, c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25008, 4382, 4394);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25008, 4272, 4405);

                int
                f_25008_4344_4367(int
                actual, int
                low, int
                high)
                {
                    Assert.InRange(actual, low, high);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25008, 4344, 4367);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25008, 4272, 4405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 4272, 4405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomAssert()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25008, 446, 4412);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25008, 446, 4412);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25008, 446, 4412);
        }

    }
}
