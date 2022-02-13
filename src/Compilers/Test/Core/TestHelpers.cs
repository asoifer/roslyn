// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.CodeAnalysis.Text;
using KeyValuePair = Roslyn.Utilities.KeyValuePairUtil;

namespace Roslyn.Test.Utilities
{
    public static class TestHelpers
    {
        public static ImmutableDictionary<K, V> CreateImmutableDictionary<K, V>(
                    IEqualityComparer<K> comparer,
                    params (K, V)[] entries)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25007, 890, 979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 893, 979);
                return f_25007_893_979<K, V>(comparer, f_25007_935_978<K, V>(entries, KeyValuePair.ToKeyValuePair)); DynAbs.Tracing.TraceSender.TraceExitMethod(25007, 890, 979);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25007, 890, 979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25007, 890, 979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableDictionary<K, V> CreateImmutableDictionary<K, V>(params (K, V)[] entries)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25007, 1102, 1181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 1105, 1181);
                return f_25007_1105_1181<K, V>(f_25007_1137_1180<K, V>(entries, KeyValuePair.ToKeyValuePair)); DynAbs.Tracing.TraceSender.TraceExitMethod(25007, 1102, 1181);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25007, 1102, 1181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25007, 1102, 1181);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<Type> GetAllTypesWithStaticFieldsImplementingType(Assembly assembly, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25007, 1194, 1538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 1324, 1527);

                return f_25007_1331_1526(f_25007_1331_1517(f_25007_1331_1350(assembly), t =>
                            {
                                return t.GetFields(BindingFlags.Public | BindingFlags.Static).Any(f => type.IsAssignableFrom(f.FieldType));
                            }));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25007, 1194, 1538);

                System.Type[]
                f_25007_1331_1350(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 1331, 1350);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Type>
                f_25007_1331_1517(System.Type[]
                source, System.Func<System.Type, bool>
                predicate)
                {
                    var return_v = source.Where<System.Type>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 1331, 1517);
                    return return_v;
                }


                System.Collections.Generic.List<System.Type>
                f_25007_1331_1526(System.Collections.Generic.IEnumerable<System.Type>
                source)
                {
                    var return_v = source.ToList<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 1331, 1526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25007, 1194, 1538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25007, 1194, 1538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetCultureInvariantString(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25007, 1550, 2558);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 1635, 1683) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25007, 1635, 1683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 1671, 1683);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25007, 1635, 1683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 1699, 1731);

                var
                valueType = f_25007_1715_1730(value)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 1745, 1848) || true) && (valueType == typeof(string))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25007, 1745, 1848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 1810, 1833);

                    return value as string;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25007, 1745, 1848);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 1864, 2033) || true) && (valueType == typeof(DateTime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25007, 1864, 2033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 1931, 2018);

                    return ((DateTime)value).ToString("M/d/yyyy h:mm:ss tt", f_25007_1988_2016());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25007, 1864, 2033);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2049, 2189) || true) && (valueType == typeof(float))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25007, 2049, 2189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2113, 2174);

                    return f_25007_2120_2173(((float)value), f_25007_2144_2172());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25007, 2049, 2189);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2205, 2347) || true) && (valueType == typeof(double))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25007, 2205, 2347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2270, 2332);

                    return f_25007_2277_2331(((double)value), f_25007_2302_2330());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25007, 2205, 2347);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2363, 2507) || true) && (valueType == typeof(decimal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25007, 2363, 2507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2429, 2492);

                    return f_25007_2436_2491(((decimal)value), f_25007_2462_2490());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25007, 2363, 2507);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2523, 2547);

                return f_25007_2530_2546(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25007, 1550, 2558);

                System.Type
                f_25007_1715_1730(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 1715, 1730);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_25007_1988_2016()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25007, 1988, 2016);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_25007_2144_2172()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25007, 2144, 2172);
                    return return_v;
                }


                string
                f_25007_2120_2173(float
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 2120, 2173);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_25007_2302_2330()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25007, 2302, 2330);
                    return return_v;
                }


                string
                f_25007_2277_2331(double
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 2277, 2331);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_25007_2462_2490()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25007, 2462, 2490);
                    return return_v;
                }


                string
                f_25007_2436_2491(decimal
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 2436, 2491);
                    return return_v;
                }


                string?
                f_25007_2530_2546(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 2530, 2546);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25007, 1550, 2558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25007, 1550, 2558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string AsXmlCommentText(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25007, 2717, 3261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2792, 2826);

                var
                builder = f_25007_2806_2825()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2849, 2854);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2840, 3125) || true) && (i < f_25007_2860_2871(text))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2873, 2876)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(25007, 2840, 3125))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25007, 2840, 3125);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2910, 2926);

                        var
                        c = f_25007_2918_2925(text, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 2944, 3074) || true) && ((c == '-') && (DynAbs.Tracing.TraceSender.Expression_True(25007, 2948, 2969) && (i > 0)) && (DynAbs.Tracing.TraceSender.Expression_True(25007, 2948, 2993) && (f_25007_2974_2985(text, i - 1) == '-')))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25007, 2944, 3074);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 3035, 3055);

                            f_25007_3035_3054(builder, ' ');
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25007, 2944, 3074);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 3092, 3110);

                        f_25007_3092_3109(builder, c);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25007, 1, 286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25007, 1, 286);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 3139, 3171);

                var
                result = f_25007_3152_3170(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 3185, 3222);

                f_25007_3185_3221(!f_25007_3199_3220(result, "--"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 3236, 3250);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25007, 2717, 3261);

                System.Text.StringBuilder
                f_25007_2806_2825()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 2806, 2825);
                    return return_v;
                }


                int
                f_25007_2860_2871(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25007, 2860, 2871);
                    return return_v;
                }


                char
                f_25007_2918_2925(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25007, 2918, 2925);
                    return return_v;
                }


                char
                f_25007_2974_2985(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25007, 2974, 2985);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25007_3035_3054(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 3035, 3054);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25007_3092_3109(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 3092, 3109);
                    return return_v;
                }


                string
                f_25007_3152_3170(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 3152, 3170);
                    return return_v;
                }


                bool
                f_25007_3199_3220(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 3199, 3220);
                    return return_v;
                }


                int
                f_25007_3185_3221(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 3185, 3221);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25007, 2717, 3261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25007, 2717, 3261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DiagnosticDescription Diagnostic(
                    object code,
                    string squiggledText = null,
                    object[] arguments = null,
                    LinePosition? startLocation = null,
                    Func<SyntaxNode, bool> syntaxNodePredicate = null,
                    bool argumentOrderDoesNotMatter = false,
                    bool isSuppressed = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25007, 3273, 4277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 3660, 3885);

                f_25007_3660_3884(code is Microsoft.CodeAnalysis.CSharp.ErrorCode || (DynAbs.Tracing.TraceSender.Expression_False(25007, 3673, 3798) || code is Microsoft.CodeAnalysis.VisualBasic.ERRID) || (DynAbs.Tracing.TraceSender.Expression_False(25007, 3673, 3839) || code is int) || (DynAbs.Tracing.TraceSender.Expression_False(25007, 3673, 3883) || code is string));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 3901, 4266);

                return f_25007_3908_4265(code as string ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(25007, 3952, 3987) ?? (object)(int)code), false, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, f_25007_4205_4219(code), isSuppressed: isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25007, 3273, 4277);

                int
                f_25007_3660_3884(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 3660, 3884);
                    return 0;
                }


                System.Type
                f_25007_4205_4219(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 4205, 4219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25007_3908_4265(object
                code, bool
                isWarningAsError, string?
                squiggledText, object[]?
                arguments, Microsoft.CodeAnalysis.Text.LinePosition?
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, System.Type
                errorCodeType, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription(code, isWarningAsError, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, errorCodeType, isSuppressed: isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 3908, 4265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25007, 3273, 4277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25007, 3273, 4277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DiagnosticDescription Diagnostic(
                   object code,
                   XCData squiggledText,
                   object[] arguments = null,
                   LinePosition? startLocation = null,
                   Func<SyntaxNode, bool> syntaxNodePredicate = null,
                   bool argumentOrderDoesNotMatter = false,
                   bool isSuppressed = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25007, 4289, 4956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 4664, 4945);

                return f_25007_4671_4944(code, f_25007_4723_4755(squiggledText), arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, isSuppressed: isSuppressed);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25007, 4289, 4956);

                string
                f_25007_4723_4755(System.Xml.Linq.XCData
                data)
                {
                    var return_v = NormalizeNewLines(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 4723, 4755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25007_4671_4944(object
                code, string
                squiggledText, object[]?
                arguments, Microsoft.CodeAnalysis.Text.LinePosition?
                startLocation, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                syntaxNodePredicate, bool
                argumentOrderDoesNotMatter, bool
                isSuppressed)
                {
                    var return_v = Diagnostic(code, squiggledText, arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter, isSuppressed: isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 4671, 4944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25007, 4289, 4956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25007, 4289, 4956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string NormalizeNewLines(XCData data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25007, 4968, 5214);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 5044, 5169) || true) && (f_25007_5048_5080())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25007, 5044, 5169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 5114, 5154);

                    return f_25007_5121_5153(f_25007_5121_5131(data), "\n", "\r\n");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25007, 5044, 5169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25007, 5185, 5203);

                return f_25007_5192_5202(data);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25007, 4968, 5214);

                bool
                f_25007_5048_5080()
                {
                    var return_v = ExecutionConditionUtil.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25007, 5048, 5080);
                    return return_v;
                }


                string
                f_25007_5121_5131(System.Xml.Linq.XCData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25007, 5121, 5131);
                    return return_v;
                }


                string
                f_25007_5121_5153(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 5121, 5153);
                    return return_v;
                }


                string
                f_25007_5192_5202(System.Xml.Linq.XCData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25007, 5192, 5202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25007, 4968, 5214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25007, 4968, 5214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TestHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25007, 674, 5221);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25007, 674, 5221);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25007, 674, 5221);
        }


        static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K, V>>
        f_25007_935_978<K, V>((K, V)[]
        source, System.Func<(K, V), System.Collections.Generic.KeyValuePair<K, V>>
        selector)
        {
            var return_v = source.Select<(K, V), System.Collections.Generic.KeyValuePair<K, V>>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 935, 978);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<K, V>
        f_25007_893_979<K, V>(System.Collections.Generic.IEqualityComparer<K>
        keyComparer, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K, V>>
        items)
        {
            var return_v = ImmutableDictionary.CreateRange(keyComparer, items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 893, 979);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K, V>>
        f_25007_1137_1180<K, V>((K, V)[]
        source, System.Func<(K, V), System.Collections.Generic.KeyValuePair<K, V>>
        selector)
        {
            var return_v = source.Select<(K, V), System.Collections.Generic.KeyValuePair<K, V>>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 1137, 1180);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<K, V>
        f_25007_1105_1181<K, V>(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K, V>>
        items)
        {
            var return_v = ImmutableDictionary.CreateRange(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25007, 1105, 1181);
            return return_v;
        }

    }
}
