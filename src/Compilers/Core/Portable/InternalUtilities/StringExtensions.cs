// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal static class StringExtensions
    {
        private static ImmutableArray<string> s_lazyNumerals;

        internal static string GetNumeral(int number)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 519, 1018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 589, 619);

                var
                numerals = s_lazyNumerals
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 633, 878) || true) && (numerals.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 633, 878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 689, 772);

                    numerals = f_385_700_771("0", "1", "2", "3", "4", "5", "6", "7", "8", "9");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 790, 863);

                    f_385_790_862(ref s_lazyNumerals, numerals);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(385, 633, 878);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 894, 920);

                f_385_894_919(number >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 934, 1007);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(385, 941, 967) || (((number < numerals.Length) && DynAbs.Tracing.TraceSender.Conditional_F2(385, 970, 986)) || DynAbs.Tracing.TraceSender.Conditional_F3(385, 989, 1006))) ? numerals[number] : f_385_989_1006(number);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 519, 1018);

                System.Collections.Immutable.ImmutableArray<string>
                f_385_700_771(params string[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 700, 771);
                    return return_v;
                }


                bool
                f_385_790_862(ref System.Collections.Immutable.ImmutableArray<string>
                location, System.Collections.Immutable.ImmutableArray<string>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 790, 862);
                    return return_v;
                }


                int
                f_385_894_919(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 894, 919);
                    return 0;
                }


                string
                f_385_989_1006(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 989, 1006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 519, 1018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 519, 1018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string Join(this IEnumerable<string?> source, string separator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 1030, 1449);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 1132, 1247) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 1132, 1247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 1184, 1232);

                    throw f_385_1190_1231(nameof(source));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(385, 1132, 1247);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 1263, 1384) || true) && (separator == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 1263, 1384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 1318, 1369);

                    throw f_385_1324_1368(nameof(separator));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(385, 1263, 1384);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 1400, 1438);

                return f_385_1407_1437(separator, source);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 1030, 1449);

                System.ArgumentNullException
                f_385_1190_1231(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 1190, 1231);
                    return return_v;
                }


                System.ArgumentNullException
                f_385_1324_1368(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 1324, 1368);
                    return return_v;
                }


                string
                f_385_1407_1437(string
                separator, System.Collections.Generic.IEnumerable<string?>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 1407, 1437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 1030, 1449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 1030, 1449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool LooksLikeInterfaceName(this string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 1461, 1648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 1545, 1637);

                return f_385_1552_1563(name) >= 3 && (DynAbs.Tracing.TraceSender.Expression_True(385, 1552, 1586) && f_385_1572_1579(name, 0) == 'I') && (DynAbs.Tracing.TraceSender.Expression_True(385, 1552, 1611) && f_385_1590_1611(f_385_1603_1610(name, 1))) && (DynAbs.Tracing.TraceSender.Expression_True(385, 1552, 1636) && f_385_1615_1636(f_385_1628_1635(name, 2)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 1461, 1648);

                int
                f_385_1552_1563(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 1552, 1563);
                    return return_v;
                }


                char
                f_385_1572_1579(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 1572, 1579);
                    return return_v;
                }


                char
                f_385_1603_1610(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 1603, 1610);
                    return return_v;
                }


                bool
                f_385_1590_1611(char
                c)
                {
                    var return_v = char.IsUpper(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 1590, 1611);
                    return return_v;
                }


                char
                f_385_1628_1635(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 1628, 1635);
                    return return_v;
                }


                bool
                f_385_1615_1636(char
                c)
                {
                    var return_v = char.IsLower(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 1615, 1636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 1461, 1648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 1461, 1648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool LooksLikeTypeParameterName(this string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 1660, 1851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 1748, 1840);

                return f_385_1755_1766(name) >= 3 && (DynAbs.Tracing.TraceSender.Expression_True(385, 1755, 1789) && f_385_1775_1782(name, 0) == 'T') && (DynAbs.Tracing.TraceSender.Expression_True(385, 1755, 1814) && f_385_1793_1814(f_385_1806_1813(name, 1))) && (DynAbs.Tracing.TraceSender.Expression_True(385, 1755, 1839) && f_385_1818_1839(f_385_1831_1838(name, 2)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 1660, 1851);

                int
                f_385_1755_1766(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 1755, 1766);
                    return return_v;
                }


                char
                f_385_1775_1782(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 1775, 1782);
                    return return_v;
                }


                char
                f_385_1806_1813(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 1806, 1813);
                    return return_v;
                }


                bool
                f_385_1793_1814(char
                c)
                {
                    var return_v = char.IsUpper(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 1793, 1814);
                    return return_v;
                }


                char
                f_385_1831_1838(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 1831, 1838);
                    return return_v;
                }


                bool
                f_385_1818_1839(char
                c)
                {
                    var return_v = char.IsLower(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 1818, 1839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 1660, 1851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 1660, 1851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Func<char, char> s_toLower;

        private static readonly Func<char, char> s_toUpper;

        [return: NotNullIfNotNull(parameterName: "shortName")]
        public static string? ToPascalCase(
                    this string? shortName,
                    bool trimLeadingTypePrefix = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 2017, 2301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 2226, 2290);

                return f_385_2233_2289(shortName, trimLeadingTypePrefix, s_toUpper);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 2017, 2301);

                string?
                f_385_2233_2289(string?
                shortName, bool
                trimLeadingTypePrefix, System.Func<char, char>
                convert)
                {
                    var return_v = shortName.ConvertCase(trimLeadingTypePrefix, convert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 2233, 2289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 2017, 2301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 2017, 2301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "shortName")]
        public static string? ToCamelCase(
                    this string? shortName,
                    bool trimLeadingTypePrefix = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 2313, 2596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 2521, 2585);

                return f_385_2528_2584(shortName, trimLeadingTypePrefix, s_toLower);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 2313, 2596);

                string?
                f_385_2528_2584(string?
                shortName, bool
                trimLeadingTypePrefix, System.Func<char, char>
                convert)
                {
                    var return_v = shortName.ConvertCase(trimLeadingTypePrefix, convert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 2528, 2584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 2313, 2596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 2313, 2596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "shortName")]
        private static string? ConvertCase(
                    this string? shortName,
                    bool trimLeadingTypePrefix,
                    Func<char, char> convert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 2608, 3542);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 3009, 3498) || true) && (!f_385_3014_3051(shortName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 3009, 3498);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 3085, 3307) || true) && (trimLeadingTypePrefix && (DynAbs.Tracing.TraceSender.Expression_True(385, 3089, 3192) && (f_385_3115_3149(shortName) || (DynAbs.Tracing.TraceSender.Expression_False(385, 3115, 3191) || f_385_3153_3191(shortName)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 3085, 3307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 3234, 3288);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_385_3241_3262(convert, f_385_3249_3261(shortName, 1))).ToString(), 385, 3241, 3262) + f_385_3265_3287(shortName, 2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(385, 3085, 3307);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 3327, 3483) || true) && (f_385_3331_3352(convert, f_385_3339_3351(shortName, 0)) != f_385_3356_3368(shortName, 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 3327, 3483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 3410, 3464);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_385_3417_3438(convert, f_385_3425_3437(shortName, 0))).ToString(), 385, 3417, 3438) + f_385_3441_3463(shortName, 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(385, 3327, 3483);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(385, 3009, 3498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 3514, 3531);

                return shortName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 2608, 3542);

                bool
                f_385_3014_3051(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 3014, 3051);
                    return return_v;
                }


                bool
                f_385_3115_3149(string
                name)
                {
                    var return_v = name.LooksLikeInterfaceName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 3115, 3149);
                    return return_v;
                }


                bool
                f_385_3153_3191(string
                name)
                {
                    var return_v = name.LooksLikeTypeParameterName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 3153, 3191);
                    return return_v;
                }


                char
                f_385_3249_3261(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 3249, 3261);
                    return return_v;
                }


                char
                f_385_3241_3262(System.Func<char, char>
                this_param, char
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 3241, 3262);
                    return return_v;
                }


                string
                f_385_3265_3287(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 3265, 3287);
                    return return_v;
                }


                char
                f_385_3339_3351(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 3339, 3351);
                    return return_v;
                }


                char
                f_385_3331_3352(System.Func<char, char>
                this_param, char
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 3331, 3352);
                    return return_v;
                }


                char
                f_385_3356_3368(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 3356, 3368);
                    return return_v;
                }


                char
                f_385_3425_3437(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 3425, 3437);
                    return return_v;
                }


                char
                f_385_3417_3438(System.Func<char, char>
                this_param, char
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 3417, 3438);
                    return return_v;
                }


                string
                f_385_3441_3463(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 3441, 3463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 2608, 3542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 2608, 3542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidClrTypeName([NotNullWhen(returnValue: true)] this string? name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 3554, 3750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 3670, 3739);

                return !f_385_3678_3710(name) && (DynAbs.Tracing.TraceSender.Expression_True(385, 3677, 3738) && f_385_3714_3732(name, '\0') == -1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 3554, 3750);

                bool
                f_385_3678_3710(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 3678, 3710);
                    return return_v;
                }


                int
                f_385_3714_3732(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 3714, 3732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 3554, 3750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 3554, 3750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidClrNamespaceName([NotNullWhen(returnValue: true)] this string? name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 3900, 4444);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4021, 4119) || true) && (f_385_4025_4057(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 4021, 4119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4091, 4104);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(385, 4021, 4119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4135, 4155);

                char
                lastChar = '.'
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4169, 4394);
                    foreach (char c in f_385_4188_4192_I(name))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 4169, 4394);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4226, 4346) || true) && (c == '\0' || (DynAbs.Tracing.TraceSender.Expression_False(385, 4230, 4272) || (c == '.' && (DynAbs.Tracing.TraceSender.Expression_True(385, 4244, 4271) && lastChar == '.'))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 4226, 4346);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4314, 4327);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(385, 4226, 4346);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4366, 4379);

                        lastChar = c;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(385, 4169, 4394);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(385, 1, 226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(385, 1, 226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4410, 4433);

                return lastChar != '.';
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 3900, 4444);

                bool
                f_385_4025_4057(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 4025, 4057);
                    return return_v;
                }


                string
                f_385_4188_4192_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 4188, 4192);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 3900, 4444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 3900, 4444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const string
        AttributeSuffix = "Attribute"
        ;

        internal static string GetWithSingleAttributeSuffix(
                    this string name,
                    bool isCaseSensitive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 4519, 4898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4662, 4685);

                string?
                cleaned = name
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4699, 4841) || true) && ((cleaned = f_385_4717_4768(cleaned, isCaseSensitive)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 4699, 4841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4811, 4826);

                        name = cleaned;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(385, 4699, 4841);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(385, 4699, 4841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(385, 4699, 4841);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4857, 4887);

                return name + AttributeSuffix;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 4519, 4898);

                string?
                f_385_4717_4768(string
                name, bool
                isCaseSensitive)
                {
                    var return_v = name.GetWithoutAttributeSuffix(isCaseSensitive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 4717, 4768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 4519, 4898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 4519, 4898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryGetWithoutAttributeSuffix(
                    this string name,
                    [NotNullWhen(returnValue: true)] out string? result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 4910, 5178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 5082, 5167);

                return f_385_5089_5166(name, isCaseSensitive: true, result: out result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 4910, 5178);

                bool
                f_385_5089_5166(string
                name, bool
                isCaseSensitive, out string?
                result)
                {
                    var return_v = name.TryGetWithoutAttributeSuffix(isCaseSensitive: isCaseSensitive, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 5089, 5166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 4910, 5178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 4910, 5178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string? GetWithoutAttributeSuffix(
                    this string name,
                    bool isCaseSensitive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 5190, 5433);
                string? result = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 5331, 5422);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(385, 5338, 5405) || ((f_385_5338_5405(name, isCaseSensitive, out result) && DynAbs.Tracing.TraceSender.Conditional_F2(385, 5408, 5414)) || DynAbs.Tracing.TraceSender.Conditional_F3(385, 5417, 5421))) ? result : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 5190, 5433);

                bool
                f_385_5338_5405(string
                name, bool
                isCaseSensitive, out string?
                result)
                {
                    var return_v = name.TryGetWithoutAttributeSuffix(isCaseSensitive, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 5338, 5405);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 5190, 5433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 5190, 5433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryGetWithoutAttributeSuffix(
                    this string name,
                    bool isCaseSensitive,
                    [NotNullWhen(returnValue: true)] out string? result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 5445, 5908);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 5652, 5840) || true) && (f_385_5656_5696(name, isCaseSensitive))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 5652, 5840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 5730, 5795);

                    result = f_385_5739_5794(name, 0, f_385_5757_5768(name) - f_385_5771_5793(AttributeSuffix));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 5813, 5825);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(385, 5652, 5840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 5856, 5870);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 5884, 5897);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 5445, 5908);

                bool
                f_385_5656_5696(string
                name, bool
                isCaseSensitive)
                {
                    var return_v = name.HasAttributeSuffix(isCaseSensitive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 5656, 5696);
                    return return_v;
                }


                int
                f_385_5757_5768(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 5757, 5768);
                    return return_v;
                }


                int
                f_385_5771_5793(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 5771, 5793);
                    return return_v;
                }


                string
                f_385_5739_5794(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 5739, 5794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 5445, 5908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 5445, 5908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasAttributeSuffix(this string name, bool isCaseSensitive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 5920, 6236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 6024, 6121);

                var
                comparison = (DynAbs.Tracing.TraceSender.Conditional_F1(385, 6041, 6056) || ((isCaseSensitive && DynAbs.Tracing.TraceSender.Conditional_F2(385, 6059, 6083)) || DynAbs.Tracing.TraceSender.Conditional_F3(385, 6086, 6120))) ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 6135, 6225);

                return f_385_6142_6153(name) > f_385_6156_6178(AttributeSuffix) && (DynAbs.Tracing.TraceSender.Expression_True(385, 6142, 6224) && f_385_6182_6224(name, AttributeSuffix, comparison));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 5920, 6236);

                int
                f_385_6142_6153(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 6142, 6153);
                    return return_v;
                }


                int
                f_385_6156_6178(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 6156, 6178);
                    return return_v;
                }


                bool
                f_385_6182_6224(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 6182, 6224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 5920, 6236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 5920, 6236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidUnicodeString(this string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 6248, 7188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 6331, 6341);

                int
                i = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 6355, 7149) || true) && (i < f_385_6366_6376(str))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 6355, 7149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 6410, 6428);

                        char
                        c = f_385_6419_6427(str, i++)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 6546, 7134) || true) && (f_385_6550_6573(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 6546, 7134);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 6615, 6925) || true) && (i < f_385_6623_6633(str) && (DynAbs.Tracing.TraceSender.Expression_True(385, 6619, 6664) && f_385_6637_6664(f_385_6657_6663(str, i))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 6615, 6925);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 6714, 6718);

                                i++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(385, 6615, 6925);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 6615, 6925);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 6889, 6902);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(385, 6615, 6925);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(385, 6546, 7134);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 6546, 7134);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 6967, 7134) || true) && (f_385_6971_6993(c))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 6967, 7134);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 7102, 7115);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(385, 6967, 7134);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(385, 6546, 7134);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(385, 6355, 7149);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(385, 6355, 7149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(385, 6355, 7149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 7165, 7177);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 6248, 7188);

                int
                f_385_6366_6376(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 6366, 6376);
                    return return_v;
                }


                char
                f_385_6419_6427(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 6419, 6427);
                    return return_v;
                }


                bool
                f_385_6550_6573(char
                c)
                {
                    var return_v = char.IsHighSurrogate(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 6550, 6573);
                    return return_v;
                }


                int
                f_385_6623_6633(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 6623, 6633);
                    return return_v;
                }


                char
                f_385_6657_6663(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 6657, 6663);
                    return return_v;
                }


                bool
                f_385_6637_6664(char
                c)
                {
                    var return_v = char.IsLowSurrogate(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 6637, 6664);
                    return return_v;
                }


                bool
                f_385_6971_6993(char
                c)
                {
                    var return_v = char.IsLowSurrogate(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 6971, 6993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 6248, 7188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 6248, 7188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string Unquote(this string arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 7345, 7455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 7417, 7444);

                return f_385_7424_7443(arg, out _);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 7345, 7455);

                string
                f_385_7424_7443(string
                arg, out bool
                quoted)
                {
                    var return_v = arg.Unquote(out quoted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 7424, 7443);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 7345, 7455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 7345, 7455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string Unquote(this string arg, out bool quoted)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 7467, 7863);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 7556, 7852) || true) && (f_385_7560_7570(arg) > 1 && (DynAbs.Tracing.TraceSender.Expression_True(385, 7560, 7591) && f_385_7578_7584(arg, 0) == '"') && (DynAbs.Tracing.TraceSender.Expression_True(385, 7560, 7621) && f_385_7595_7614(arg, f_385_7599_7609(arg) - 1) == '"'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 7556, 7852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 7655, 7669);

                    quoted = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 7687, 7727);

                    return f_385_7694_7726(arg, 1, f_385_7711_7721(arg) - 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(385, 7556, 7852);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 7556, 7852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 7793, 7808);

                    quoted = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 7826, 7837);

                    return arg;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(385, 7556, 7852);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 7467, 7863);

                int
                f_385_7560_7570(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 7560, 7570);
                    return return_v;
                }


                char
                f_385_7578_7584(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 7578, 7584);
                    return return_v;
                }


                int
                f_385_7599_7609(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 7599, 7609);
                    return return_v;
                }


                char
                f_385_7595_7614(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 7595, 7614);
                    return return_v;
                }


                int
                f_385_7711_7721(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 7711, 7721);
                    return return_v;
                }


                string
                f_385_7694_7726(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 7694, 7726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 7467, 7863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 7467, 7863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int IndexOfBalancedParenthesis(this string str, int openingOffset, char closing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 7875, 8555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 7996, 8030);

                char
                opening = f_385_8011_8029(str, openingOffset)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8046, 8060);

                int
                depth = 1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8083, 8104);
                    for (int
        i = openingOffset + 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8074, 8518) || true) && (i < f_385_8110_8120(str))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8122, 8125)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(385, 8074, 8518))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 8074, 8518);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8159, 8174);

                        var
                        c = f_385_8167_8173(str, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8192, 8503) || true) && (c == opening)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 8192, 8503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8250, 8258);

                            depth++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(385, 8192, 8503);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 8192, 8503);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8300, 8503) || true) && (c == closing)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 8300, 8503);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8358, 8366);

                                depth--;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8388, 8484) || true) && (depth == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 8388, 8484);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8452, 8461);

                                    return i;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(385, 8388, 8484);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(385, 8300, 8503);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(385, 8192, 8503);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(385, 1, 445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(385, 1, 445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8534, 8544);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 7875, 8555);

                char
                f_385_8011_8029(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 8011, 8029);
                    return return_v;
                }


                int
                f_385_8110_8120(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 8110, 8120);
                    return return_v;
                }


                char
                f_385_8167_8173(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 8167, 8173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 7875, 8555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 7875, 8555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static char First(this string arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 8644, 8737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8712, 8726);

                return f_385_8719_8725(arg, 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 8644, 8737);

                char
                f_385_8719_8725(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 8719, 8725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 8644, 8737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 8644, 8737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static char Last(this string arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 8826, 8931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 8893, 8920);

                return f_385_8900_8919(arg, f_385_8904_8914(arg) - 1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 8826, 8931);

                int
                f_385_8904_8914(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 8904, 8914);
                    return return_v;
                }


                char
                f_385_8900_8919(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 8900, 8919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 8826, 8931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 8826, 8931);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool All(this string arg, Predicate<char> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 9020, 9314);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9113, 9275);
                    foreach (char c in f_385_9132_9135_I(arg))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 9113, 9275);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9169, 9260) || true) && (!f_385_9174_9186(predicate, c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 9169, 9260);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9228, 9241);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(385, 9169, 9260);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(385, 9113, 9275);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(385, 1, 163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(385, 1, 163);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9291, 9303);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 9020, 9314);

                bool
                f_385_9174_9186(System.Predicate<char>
                this_param, char
                obj)
                {
                    var return_v = this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 9174, 9186);
                    return return_v;
                }


                string
                f_385_9132_9135_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 9132, 9135);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 9020, 9314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 9020, 9314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int GetCaseInsensitivePrefixLength(this string string1, string string2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 9326, 9672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9436, 9446);

                int
                x = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9460, 9636) || true) && (x < f_385_9471_9485(string1) && (DynAbs.Tracing.TraceSender.Expression_True(385, 9467, 9507) && x < f_385_9493_9507(string2)) && (DynAbs.Tracing.TraceSender.Expression_True(385, 9467, 9583) && f_385_9531_9555(f_385_9544_9554(string1, x)) == f_385_9559_9583(f_385_9572_9582(string2, x))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 9460, 9636);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9617, 9621);

                        x++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(385, 9460, 9636);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(385, 9460, 9636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(385, 9460, 9636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9652, 9661);

                return x;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 9326, 9672);

                int
                f_385_9471_9485(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 9471, 9485);
                    return return_v;
                }


                int
                f_385_9493_9507(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 9493, 9507);
                    return return_v;
                }


                char
                f_385_9544_9554(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 9544, 9554);
                    return return_v;
                }


                char
                f_385_9531_9555(char
                c)
                {
                    var return_v = char.ToUpper(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 9531, 9555);
                    return return_v;
                }


                char
                f_385_9572_9582(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 9572, 9582);
                    return return_v;
                }


                char
                f_385_9559_9583(char
                c)
                {
                    var return_v = char.ToUpper(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(385, 9559, 9583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 9326, 9672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 9326, 9672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int GetCaseSensitivePrefixLength(this string string1, string string2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(385, 9684, 10000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9792, 9802);

                int
                x = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9816, 9964) || true) && (x < f_385_9827_9841(string1) && (DynAbs.Tracing.TraceSender.Expression_True(385, 9823, 9863) && x < f_385_9849_9863(string2)) && (DynAbs.Tracing.TraceSender.Expression_True(385, 9823, 9911) && f_385_9887_9897(string1, x) == f_385_9901_9911(string2, x)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(385, 9816, 9964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9945, 9949);

                        x++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(385, 9816, 9964);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(385, 9816, 9964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(385, 9816, 9964);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 9980, 9989);

                return x;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(385, 9684, 10000);

                int
                f_385_9827_9841(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 9827, 9841);
                    return return_v;
                }


                int
                f_385_9849_9863(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 9849, 9863);
                    return return_v;
                }


                char
                f_385_9887_9897(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 9887, 9897);
                    return return_v;
                }


                char
                f_385_9901_9911(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(385, 9901, 9911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(385, 9684, 10000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 9684, 10000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StringExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(385, 399, 10007);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 1904, 1928);
            s_toLower = char.ToLower; DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 1980, 2004);
            s_toUpper = char.ToUpper; DynAbs.Tracing.TraceSender.TraceSimpleStatement(385, 4477, 4506);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(385, 399, 10007);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(385, 399, 10007);
        }

    }
}
