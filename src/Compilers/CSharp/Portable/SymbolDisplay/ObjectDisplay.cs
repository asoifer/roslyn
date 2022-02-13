// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using ExceptionUtilities = Roslyn.Utilities.ExceptionUtilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class ObjectDisplay
    {
        public static string FormatPrimitive(object obj, ObjectDisplayOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 1953, 4183);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2056, 2139) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 2056, 2139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2105, 2124);

                    return f_10954_2112_2123();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 2056, 2139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2155, 2181);

                Type
                type = f_10954_2167_2180(obj)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2195, 2309) || true) && (f_10954_2199_2224(f_10954_2199_2217(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 2195, 2309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2258, 2294);

                    type = f_10954_2265_2293(type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 2195, 2309);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2325, 2437) || true) && (type == typeof(int))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 2325, 2437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2382, 2422);

                    return f_10954_2389_2421(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 2325, 2437);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2453, 2571) || true) && (type == typeof(string))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 2453, 2571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2513, 2556);

                    return f_10954_2520_2555(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 2453, 2571);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2587, 2692) || true) && (type == typeof(bool))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 2587, 2692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2645, 2677);

                    return f_10954_2652_2676(obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 2587, 2692);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2708, 2822) || true) && (type == typeof(char))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 2708, 2822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2766, 2807);

                    return f_10954_2773_2806(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 2708, 2822);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2838, 2952) || true) && (type == typeof(byte))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 2838, 2952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2896, 2937);

                    return f_10954_2903_2936(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 2838, 2952);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 2968, 3084) || true) && (type == typeof(short))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 2968, 3084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3027, 3069);

                    return f_10954_3034_3068(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 2968, 3084);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3100, 3214) || true) && (type == typeof(long))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 3100, 3214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3158, 3199);

                    return f_10954_3165_3198(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 3100, 3214);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3230, 3348) || true) && (type == typeof(double))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 3230, 3348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3290, 3333);

                    return f_10954_3297_3332(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 3230, 3348);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3364, 3480) || true) && (type == typeof(ulong))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 3364, 3480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3423, 3465);

                    return f_10954_3430_3464(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 3364, 3480);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3496, 3610) || true) && (type == typeof(uint))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 3496, 3610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3554, 3595);

                    return f_10954_3561_3594(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 3496, 3610);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3626, 3744) || true) && (type == typeof(ushort))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 3626, 3744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3686, 3729);

                    return f_10954_3693_3728(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 3626, 3744);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3760, 3876) || true) && (type == typeof(sbyte))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 3760, 3876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3819, 3861);

                    return f_10954_3826_3860(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 3760, 3876);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3892, 4008) || true) && (type == typeof(float))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 3892, 4008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 3951, 3993);

                    return f_10954_3958_3992(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 3892, 4008);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 4024, 4144) || true) && (type == typeof(decimal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 4024, 4144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 4085, 4129);

                    return f_10954_4092_4128(obj, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 4024, 4144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 4160, 4172);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 1953, 4183);

                string
                f_10954_2112_2123()
                {
                    var return_v = NullLiteral;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10954, 2112, 2123);
                    return return_v;
                }


                System.Type
                f_10954_2167_2180(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 2167, 2180);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_10954_2199_2217(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 2199, 2217);
                    return return_v;
                }


                bool
                f_10954_2199_2224(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10954, 2199, 2224);
                    return return_v;
                }


                System.Type
                f_10954_2265_2293(System.Type
                enumType)
                {
                    var return_v = Enum.GetUnderlyingType(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 2265, 2293);
                    return return_v;
                }


                string
                f_10954_2389_2421(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((int)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 2389, 2421);
                    return return_v;
                }


                string
                f_10954_2520_2555(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((string)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 2520, 2555);
                    return return_v;
                }


                string
                f_10954_2652_2676(object
                value)
                {
                    var return_v = FormatLiteral((bool)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 2652, 2676);
                    return return_v;
                }


                string
                f_10954_2773_2806(object
                c, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((char)c, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 2773, 2806);
                    return return_v;
                }


                string
                f_10954_2903_2936(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((byte)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 2903, 2936);
                    return return_v;
                }


                string
                f_10954_3034_3068(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((short)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 3034, 3068);
                    return return_v;
                }


                string
                f_10954_3165_3198(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((long)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 3165, 3198);
                    return return_v;
                }


                string
                f_10954_3297_3332(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((double)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 3297, 3332);
                    return return_v;
                }


                string
                f_10954_3430_3464(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((ulong)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 3430, 3464);
                    return return_v;
                }


                string
                f_10954_3561_3594(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((uint)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 3561, 3594);
                    return return_v;
                }


                string
                f_10954_3693_3728(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((ushort)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 3693, 3728);
                    return return_v;
                }


                string
                f_10954_3826_3860(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((sbyte)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 3826, 3860);
                    return return_v;
                }


                string
                f_10954_3958_3992(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((float)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 3958, 3992);
                    return return_v;
                }


                string
                f_10954_4092_4128(object
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = FormatLiteral((decimal)value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 4092, 4128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 1953, 4183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 1953, 4183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string NullLiteral
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 4254, 4319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 4290, 4304);

                    return "null";
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 4254, 4319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 4195, 4330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 4195, 4330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static string FormatLiteral(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 4342, 4458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 4415, 4447);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10954, 4422, 4427) || ((value && DynAbs.Tracing.TraceSender.Conditional_F2(10954, 4430, 4436)) || DynAbs.Tracing.TraceSender.Conditional_F3(10954, 4439, 4446))) ? "true" : "false";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 4342, 4458);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 4342, 4458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 4342, 4458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryReplaceChar(char c, out string replaceWith)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 4657, 6041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 4748, 4767);

                replaceWith = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 4781, 5704);

                switch (c)
                {

                    case '\\':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 4781, 5704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 4856, 4877);

                        replaceWith = "\\\\";
                        DynAbs.Tracing.TraceSender.TraceBreak(10954, 4899, 4905);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 4781, 5704);

                    case '\0':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 4781, 5704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 4955, 4975);

                        replaceWith = "\\0";
                        DynAbs.Tracing.TraceSender.TraceBreak(10954, 4997, 5003);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 4781, 5704);

                    case '\a':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 4781, 5704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5053, 5073);

                        replaceWith = "\\a";
                        DynAbs.Tracing.TraceSender.TraceBreak(10954, 5095, 5101);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 4781, 5704);

                    case '\b':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 4781, 5704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5151, 5171);

                        replaceWith = "\\b";
                        DynAbs.Tracing.TraceSender.TraceBreak(10954, 5193, 5199);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 4781, 5704);

                    case '\f':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 4781, 5704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5249, 5269);

                        replaceWith = "\\f";
                        DynAbs.Tracing.TraceSender.TraceBreak(10954, 5291, 5297);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 4781, 5704);

                    case '\n':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 4781, 5704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5347, 5367);

                        replaceWith = "\\n";
                        DynAbs.Tracing.TraceSender.TraceBreak(10954, 5389, 5395);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 4781, 5704);

                    case '\r':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 4781, 5704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5445, 5465);

                        replaceWith = "\\r";
                        DynAbs.Tracing.TraceSender.TraceBreak(10954, 5487, 5493);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 4781, 5704);

                    case '\t':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 4781, 5704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5543, 5563);

                        replaceWith = "\\t";
                        DynAbs.Tracing.TraceSender.TraceBreak(10954, 5585, 5591);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 4781, 5704);

                    case '\v':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 4781, 5704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5641, 5661);

                        replaceWith = "\\v";
                        DynAbs.Tracing.TraceSender.TraceBreak(10954, 5683, 5689);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 4781, 5704);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5720, 5804) || true) && (replaceWith != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 5720, 5804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5777, 5789);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 5720, 5804);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5820, 6001) || true) && (f_10954_5824_5876(f_10954_5838_5875(c)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 5820, 6001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5910, 5956);

                    replaceWith = "\\u" + f_10954_5932_5955(((int)c), "x4");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 5974, 5986);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 5820, 6001);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 6017, 6030);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 4657, 6041);

                System.Globalization.UnicodeCategory
                f_10954_5838_5875(char
                ch)
                {
                    var return_v = CharUnicodeInfo.GetUnicodeCategory(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 5838, 5875);
                    return return_v;
                }


                bool
                f_10954_5824_5876(System.Globalization.UnicodeCategory
                category)
                {
                    var return_v = NeedsEscaping(category);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 5824, 5876);
                    return return_v;
                }


                string
                f_10954_5932_5955(int
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 5932, 5955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 4657, 6041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 4657, 6041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedsEscaping(UnicodeCategory category)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 6053, 6553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 6137, 6542);

                switch (category)
                {

                    case UnicodeCategory.Control:
                    case UnicodeCategory.OtherNotAssigned:
                    case UnicodeCategory.ParagraphSeparator:
                    case UnicodeCategory.LineSeparator:
                    case UnicodeCategory.Surrogate:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 6137, 6542);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 6454, 6466);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 6137, 6542);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 6137, 6542);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 6514, 6527);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 6137, 6542);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 6053, 6553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 6053, 6553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 6053, 6553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string FormatLiteral(string value, ObjectDisplayOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 7049, 10030);
                string replaceWith = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7152, 7265) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 7152, 7265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7203, 7250);

                    throw f_10954_7209_7249(nameof(value));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 7152, 7265);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7281, 7304);

                const char
                quote = '"'
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7320, 7374);

                var
                pooledBuilder = f_10954_7340_7373()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7388, 7424);

                var
                builder = pooledBuilder.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7440, 7511);

                var
                useQuotes = f_10954_7456_7510(options, ObjectDisplayOptions.UseQuotes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7525, 7624);

                var
                escapeNonPrintable = f_10954_7550_7623(options, ObjectDisplayOptions.EscapeNonPrintableCharacters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7640, 7716);

                var
                isVerbatim = useQuotes && (DynAbs.Tracing.TraceSender.Expression_True(10954, 7657, 7689) && !escapeNonPrintable) && (DynAbs.Tracing.TraceSender.Expression_True(10954, 7657, 7715) && f_10954_7693_7715(value))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7732, 7929) || true) && (useQuotes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 7732, 7929);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7779, 7874) || true) && (isVerbatim)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 7779, 7874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7835, 7855);

                        f_10954_7835_7854(builder, '@');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 7779, 7874);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7892, 7914);

                    f_10954_7892_7913(builder, quote);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 7732, 7929);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7954, 7959);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7945, 9864) || true) && (i < f_10954_7965_7977(value))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 7979, 7982)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 7945, 9864))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 7945, 9864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 8016, 8034);

                        char
                        c = f_10954_8025_8033(value, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 8052, 9849) || true) && (escapeNonPrintable && (DynAbs.Tracing.TraceSender.Expression_True(10954, 8056, 8144) && f_10954_8078_8115(c) == UnicodeCategory.Surrogate))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 8052, 9849);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 8186, 8246);

                            var
                            category = f_10954_8201_8245(value, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 8268, 9119) || true) && (category == UnicodeCategory.Surrogate)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 8268, 9119);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 8409, 8457);

                                f_10954_8409_8456(                        // an unpaired surrogate
                                                        builder, "\\u" + f_10954_8432_8455(((int)c), "x4"));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 8268, 9119);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 8268, 9119);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 8507, 9119) || true) && (f_10954_8511_8534(category))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 8507, 9119);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 8654, 8698);

                                    var
                                    unicode = f_10954_8668_8697(value, i)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 8724, 8771);

                                    f_10954_8724_8770(builder, "\\U" + f_10954_8747_8769(unicode, "x8"));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 8797, 8801);

                                    i++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 8507, 9119);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 8507, 9119);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9025, 9043);

                                    f_10954_9025_9042(                        // copy a printable surrogate pair directly
                                                            builder, c);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9069, 9096);

                                    f_10954_9069_9095(builder, f_10954_9084_9094(value, ++i));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 8507, 9119);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 8268, 9119);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 8052, 9849);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 8052, 9849);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9161, 9849) || true) && (escapeNonPrintable && (DynAbs.Tracing.TraceSender.Expression_True(10954, 9165, 9225) && f_10954_9187_9225(c, out replaceWith)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 9161, 9849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9267, 9295);

                                f_10954_9267_9294(builder, replaceWith);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 9161, 9849);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 9161, 9849);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9337, 9849) || true) && (useQuotes && (DynAbs.Tracing.TraceSender.Expression_True(10954, 9341, 9364) && c == quote))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 9337, 9849);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9406, 9730) || true) && (isVerbatim)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 9406, 9730);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9470, 9492);

                                        f_10954_9470_9491(builder, quote);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9518, 9540);

                                        f_10954_9518_9539(builder, quote);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 9406, 9730);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 9406, 9730);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9638, 9659);

                                        f_10954_9638_9658(builder, '\\');
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9685, 9707);

                                        f_10954_9685_9706(builder, quote);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 9406, 9730);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 9337, 9849);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 9337, 9849);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9812, 9830);

                                    f_10954_9812_9829(builder, c);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 9337, 9849);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 9161, 9849);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 8052, 9849);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10954, 1, 1920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10954, 1, 1920);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9880, 9964) || true) && (useQuotes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 9880, 9964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9927, 9949);

                    f_10954_9927_9948(builder, quote);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 9880, 9964);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 9980, 10019);

                return f_10954_9987_10018(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 7049, 10030);

                System.ArgumentNullException
                f_10954_7209_7249(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 7209, 7249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10954_7340_7373()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 7340, 7373);
                    return return_v;
                }


                bool
                f_10954_7456_7510(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 7456, 7510);
                    return return_v;
                }


                bool
                f_10954_7550_7623(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 7550, 7623);
                    return return_v;
                }


                bool
                f_10954_7693_7715(string
                s)
                {
                    var return_v = ContainsNewLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 7693, 7715);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_7835_7854(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 7835, 7854);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_7892_7913(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 7892, 7913);
                    return return_v;
                }


                int
                f_10954_7965_7977(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10954, 7965, 7977);
                    return return_v;
                }


                char
                f_10954_8025_8033(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10954, 8025, 8033);
                    return return_v;
                }


                System.Globalization.UnicodeCategory
                f_10954_8078_8115(char
                ch)
                {
                    var return_v = CharUnicodeInfo.GetUnicodeCategory(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 8078, 8115);
                    return return_v;
                }


                System.Globalization.UnicodeCategory
                f_10954_8201_8245(string
                s, int
                index)
                {
                    var return_v = CharUnicodeInfo.GetUnicodeCategory(s, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 8201, 8245);
                    return return_v;
                }


                string
                f_10954_8432_8455(int
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 8432, 8455);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_8409_8456(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 8409, 8456);
                    return return_v;
                }


                bool
                f_10954_8511_8534(System.Globalization.UnicodeCategory
                category)
                {
                    var return_v = NeedsEscaping(category);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 8511, 8534);
                    return return_v;
                }


                int
                f_10954_8668_8697(string
                s, int
                index)
                {
                    var return_v = char.ConvertToUtf32(s, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 8668, 8697);
                    return return_v;
                }


                string
                f_10954_8747_8769(int
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 8747, 8769);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_8724_8770(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 8724, 8770);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_9025_9042(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9025, 9042);
                    return return_v;
                }


                char
                f_10954_9084_9094(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10954, 9084, 9094);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_9069_9095(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9069, 9095);
                    return return_v;
                }


                bool
                f_10954_9187_9225(char
                c, out string
                replaceWith)
                {
                    var return_v = TryReplaceChar(c, out replaceWith);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9187, 9225);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_9267_9294(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9267, 9294);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_9470_9491(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9470, 9491);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_9518_9539(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9518, 9539);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_9638_9658(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9638, 9658);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_9685_9706(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9685, 9706);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_9812_9829(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9812, 9829);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_9927_9948(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9927, 9948);
                    return return_v;
                }


                string
                f_10954_9987_10018(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 9987, 10018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 7049, 10030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 7049, 10030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ContainsNewLine(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 10042, 10322);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 10112, 10282);
                    foreach (char c in f_10954_10131_10132_I(s))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 10112, 10282);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 10166, 10267) || true) && (f_10954_10170_10194(c))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 10166, 10267);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 10236, 10248);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 10166, 10267);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 10112, 10282);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10954, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10954, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 10298, 10311);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 10042, 10322);

                bool
                f_10954_10170_10194(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 10170, 10194);
                    return return_v;
                }


                string
                f_10954_10131_10132_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 10131, 10132);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 10042, 10322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 10042, 10322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(char c, ObjectDisplayOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 10718, 12160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 10817, 10841);

                const char
                quote = '\''
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 10857, 10911);

                var
                pooledBuilder = f_10954_10877_10910()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 10925, 10961);

                var
                builder = pooledBuilder.Builder
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 10977, 11268) || true) && (f_10954_10981_11043(options, ObjectDisplayOptions.IncludeCodePoints))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 10977, 11268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11077, 11215);

                    f_10954_11077_11214(builder, (DynAbs.Tracing.TraceSender.Conditional_F1(10954, 11092, 11158) || ((f_10954_11092_11158(options, ObjectDisplayOptions.UseHexadecimalNumbers) && DynAbs.Tracing.TraceSender.Conditional_F2(10954, 11161, 11191)) || DynAbs.Tracing.TraceSender.Conditional_F3(10954, 11194, 11213))) ? "0x" + f_10954_11168_11191(((int)c), "x4") : f_10954_11194_11213(((int)c)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11233, 11253);

                    f_10954_11233_11252(builder, " ");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 10977, 11268);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11284, 11355);

                var
                useQuotes = f_10954_11300_11354(options, ObjectDisplayOptions.UseQuotes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11369, 11468);

                var
                escapeNonPrintable = f_10954_11394_11467(options, ObjectDisplayOptions.EscapeNonPrintableCharacters)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11484, 11568) || true) && (useQuotes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 11484, 11568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11531, 11553);

                    f_10954_11531_11552(builder, quote);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 11484, 11568);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11584, 11603);

                string
                replaceWith
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11617, 11994) || true) && (escapeNonPrintable && (DynAbs.Tracing.TraceSender.Expression_True(10954, 11621, 11677) && f_10954_11643_11677(c, out replaceWith)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 11617, 11994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11711, 11739);

                    f_10954_11711_11738(builder, replaceWith);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 11617, 11994);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 11617, 11994);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11773, 11994) || true) && (useQuotes && (DynAbs.Tracing.TraceSender.Expression_True(10954, 11777, 11800) && c == quote))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 11773, 11994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11834, 11855);

                        f_10954_11834_11854(builder, '\\');
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11873, 11895);

                        f_10954_11873_11894(builder, quote);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 11773, 11994);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 11773, 11994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 11961, 11979);

                        f_10954_11961_11978(builder, c);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 11773, 11994);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 11617, 11994);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 12010, 12094) || true) && (useQuotes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 12010, 12094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 12057, 12079);

                    f_10954_12057_12078(builder, quote);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 12010, 12094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 12110, 12149);

                return f_10954_12117_12148(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 10718, 12160);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10954_10877_10910()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 10877, 10910);
                    return return_v;
                }


                bool
                f_10954_10981_11043(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 10981, 11043);
                    return return_v;
                }


                bool
                f_10954_11092_11158(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11092, 11158);
                    return return_v;
                }


                string
                f_10954_11168_11191(int
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11168, 11191);
                    return return_v;
                }


                string
                f_10954_11194_11213(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11194, 11213);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_11077_11214(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11077, 11214);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_11233_11252(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11233, 11252);
                    return return_v;
                }


                bool
                f_10954_11300_11354(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11300, 11354);
                    return return_v;
                }


                bool
                f_10954_11394_11467(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11394, 11467);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_11531_11552(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11531, 11552);
                    return return_v;
                }


                bool
                f_10954_11643_11677(char
                c, out string
                replaceWith)
                {
                    var return_v = TryReplaceChar(c, out replaceWith);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11643, 11677);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_11711_11738(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11711, 11738);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_11834_11854(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11834, 11854);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_11873_11894(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11873, 11894);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_11961_11978(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 11961, 11978);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_12057_12078(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 12057, 12078);
                    return return_v;
                }


                string
                f_10954_12117_12148(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 12117, 12148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 10718, 12160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 10718, 12160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(sbyte value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 12172, 12768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 12308, 12757) || true) && (f_10954_12312_12378(options, ObjectDisplayOptions.UseHexadecimalNumbers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 12308, 12757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 12543, 12623);

                    return "0x" + ((DynAbs.Tracing.TraceSender.Conditional_F1(10954, 12558, 12568) || ((value >= 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10954, 12571, 12591)) || DynAbs.Tracing.TraceSender.Conditional_F3(10954, 12594, 12621))) ? f_10954_12571_12591(value, "x2") : f_10954_12594_12621(((int)value), "x8"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 12308, 12757);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 12308, 12757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 12689, 12742);

                    return f_10954_12696_12741(value, f_10954_12711_12740(cultureInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 12308, 12757);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 12172, 12768);

                bool
                f_10954_12312_12378(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 12312, 12378);
                    return return_v;
                }


                string
                f_10954_12571_12591(sbyte
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 12571, 12591);
                    return return_v;
                }


                string
                f_10954_12594_12621(int
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 12594, 12621);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10954_12711_12740(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 12711, 12740);
                    return return_v;
                }


                string
                f_10954_12696_12741(sbyte
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 12696, 12741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 12172, 12768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 12172, 12768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(byte value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 12780, 13199);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 12915, 13188) || true) && (f_10954_12919_12985(options, ObjectDisplayOptions.UseHexadecimalNumbers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 12915, 13188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 13019, 13054);

                    return "0x" + f_10954_13033_13053(value, "x2");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 12915, 13188);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 12915, 13188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 13120, 13173);

                    return f_10954_13127_13172(value, f_10954_13142_13171(cultureInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 12915, 13188);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 12780, 13199);

                bool
                f_10954_12919_12985(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 12919, 12985);
                    return return_v;
                }


                string
                f_10954_13033_13053(byte
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 13033, 13053);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10954_13142_13171(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 13142, 13171);
                    return return_v;
                }


                string
                f_10954_13127_13172(byte
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 13127, 13172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 12780, 13199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 12780, 13199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(short value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 13211, 13807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 13347, 13796) || true) && (f_10954_13351_13417(options, ObjectDisplayOptions.UseHexadecimalNumbers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 13347, 13796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 13582, 13662);

                    return "0x" + ((DynAbs.Tracing.TraceSender.Conditional_F1(10954, 13597, 13607) || ((value >= 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10954, 13610, 13630)) || DynAbs.Tracing.TraceSender.Conditional_F3(10954, 13633, 13660))) ? f_10954_13610_13630(value, "x4") : f_10954_13633_13660(((int)value), "x8"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 13347, 13796);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 13347, 13796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 13728, 13781);

                    return f_10954_13735_13780(value, f_10954_13750_13779(cultureInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 13347, 13796);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 13211, 13807);

                bool
                f_10954_13351_13417(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 13351, 13417);
                    return return_v;
                }


                string
                f_10954_13610_13630(short
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 13610, 13630);
                    return return_v;
                }


                string
                f_10954_13633_13660(int
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 13633, 13660);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10954_13750_13779(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 13750, 13779);
                    return return_v;
                }


                string
                f_10954_13735_13780(short
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 13735, 13780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 13211, 13807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 13211, 13807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(ushort value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 13819, 14240);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 13956, 14229) || true) && (f_10954_13960_14026(options, ObjectDisplayOptions.UseHexadecimalNumbers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 13956, 14229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 14060, 14095);

                    return "0x" + f_10954_14074_14094(value, "x4");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 13956, 14229);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 13956, 14229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 14161, 14214);

                    return f_10954_14168_14213(value, f_10954_14183_14212(cultureInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 13956, 14229);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 13819, 14240);

                bool
                f_10954_13960_14026(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 13960, 14026);
                    return return_v;
                }


                string
                f_10954_14074_14094(ushort
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 14074, 14094);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10954_14183_14212(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 14183, 14212);
                    return return_v;
                }


                string
                f_10954_14168_14213(ushort
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 14168, 14213);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 13819, 14240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 13819, 14240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(int value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 14252, 14670);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 14386, 14659) || true) && (f_10954_14390_14456(options, ObjectDisplayOptions.UseHexadecimalNumbers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 14386, 14659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 14490, 14525);

                    return "0x" + f_10954_14504_14524(value, "x8");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 14386, 14659);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 14386, 14659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 14591, 14644);

                    return f_10954_14598_14643(value, f_10954_14613_14642(cultureInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 14386, 14659);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 14252, 14670);

                bool
                f_10954_14390_14456(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 14390, 14456);
                    return return_v;
                }


                string
                f_10954_14504_14524(int
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 14504, 14524);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10954_14613_14642(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 14613, 14642);
                    return return_v;
                }


                string
                f_10954_14598_14643(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 14598, 14643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 14252, 14670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 14252, 14670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(uint value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 14682, 15452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 14817, 14871);

                var
                pooledBuilder = f_10954_14837_14870()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 14885, 14916);

                var
                sb = pooledBuilder.Builder
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 14932, 15240) || true) && (f_10954_14936_15002(options, ObjectDisplayOptions.UseHexadecimalNumbers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 14932, 15240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15036, 15052);

                    f_10954_15036_15051(sb, "0x");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15070, 15102);

                    f_10954_15070_15101(sb, f_10954_15080_15100(value, "x8"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 14932, 15240);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 14932, 15240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15168, 15225);

                    f_10954_15168_15224(sb, f_10954_15178_15223(value, f_10954_15193_15222(cultureInfo)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 14932, 15240);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15256, 15386) || true) && (f_10954_15260_15322(options, ObjectDisplayOptions.IncludeTypeSuffix))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 15256, 15386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15356, 15371);

                    f_10954_15356_15370(sb, 'U');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 15256, 15386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15402, 15441);

                return f_10954_15409_15440(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 14682, 15452);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10954_14837_14870()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 14837, 14870);
                    return return_v;
                }


                bool
                f_10954_14936_15002(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 14936, 15002);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_15036_15051(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15036, 15051);
                    return return_v;
                }


                string
                f_10954_15080_15100(uint
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15080, 15100);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_15070_15101(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15070, 15101);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10954_15193_15222(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15193, 15222);
                    return return_v;
                }


                string
                f_10954_15178_15223(uint
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15178, 15223);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_15168_15224(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15168, 15224);
                    return return_v;
                }


                bool
                f_10954_15260_15322(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15260, 15322);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_15356_15370(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15356, 15370);
                    return return_v;
                }


                string
                f_10954_15409_15440(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15409, 15440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 14682, 15452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 14682, 15452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(long value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 15464, 16235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15599, 15653);

                var
                pooledBuilder = f_10954_15619_15652()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15667, 15698);

                var
                sb = pooledBuilder.Builder
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15714, 16023) || true) && (f_10954_15718_15784(options, ObjectDisplayOptions.UseHexadecimalNumbers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 15714, 16023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15818, 15834);

                    f_10954_15818_15833(sb, "0x");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15852, 15885);

                    f_10954_15852_15884(sb, f_10954_15862_15883(value, "x16"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 15714, 16023);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 15714, 16023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 15951, 16008);

                    f_10954_15951_16007(sb, f_10954_15961_16006(value, f_10954_15976_16005(cultureInfo)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 15714, 16023);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16039, 16169) || true) && (f_10954_16043_16105(options, ObjectDisplayOptions.IncludeTypeSuffix))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 16039, 16169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16139, 16154);

                    f_10954_16139_16153(sb, 'L');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 16039, 16169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16185, 16224);

                return f_10954_16192_16223(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 15464, 16235);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10954_15619_15652()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15619, 15652);
                    return return_v;
                }


                bool
                f_10954_15718_15784(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15718, 15784);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_15818_15833(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15818, 15833);
                    return return_v;
                }


                string
                f_10954_15862_15883(long
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15862, 15883);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_15852_15884(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15852, 15884);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10954_15976_16005(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15976, 16005);
                    return return_v;
                }


                string
                f_10954_15961_16006(long
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15961, 16006);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_15951_16007(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 15951, 16007);
                    return return_v;
                }


                bool
                f_10954_16043_16105(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16043, 16105);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_16139_16153(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16139, 16153);
                    return return_v;
                }


                string
                f_10954_16192_16223(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16192, 16223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 15464, 16235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 15464, 16235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(ulong value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 16247, 17020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16383, 16437);

                var
                pooledBuilder = f_10954_16403_16436()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16451, 16482);

                var
                sb = pooledBuilder.Builder
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16498, 16807) || true) && (f_10954_16502_16568(options, ObjectDisplayOptions.UseHexadecimalNumbers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 16498, 16807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16602, 16618);

                    f_10954_16602_16617(sb, "0x");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16636, 16669);

                    f_10954_16636_16668(sb, f_10954_16646_16667(value, "x16"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 16498, 16807);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 16498, 16807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16735, 16792);

                    f_10954_16735_16791(sb, f_10954_16745_16790(value, f_10954_16760_16789(cultureInfo)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 16498, 16807);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16823, 16954) || true) && (f_10954_16827_16889(options, ObjectDisplayOptions.IncludeTypeSuffix))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10954, 16823, 16954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16923, 16939);

                    f_10954_16923_16938(sb, "UL");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10954, 16823, 16954);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 16970, 17009);

                return f_10954_16977_17008(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 16247, 17020);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10954_16403_16436()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16403, 16436);
                    return return_v;
                }


                bool
                f_10954_16502_16568(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16502, 16568);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_16602_16617(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16602, 16617);
                    return return_v;
                }


                string
                f_10954_16646_16667(ulong
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16646, 16667);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_16636_16668(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16636, 16668);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10954_16760_16789(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16760, 16789);
                    return return_v;
                }


                string
                f_10954_16745_16790(ulong
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16745, 16790);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_16735_16791(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16735, 16791);
                    return return_v;
                }


                bool
                f_10954_16827_16889(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16827, 16889);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10954_16923_16938(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16923, 16938);
                    return return_v;
                }


                string
                f_10954_16977_17008(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 16977, 17008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 16247, 17020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 16247, 17020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(double value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 17032, 17354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 17169, 17233);

                var
                result = f_10954_17182_17232(value, "R", f_10954_17202_17231(cultureInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 17249, 17343);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10954, 17256, 17318) || ((f_10954_17256_17318(options, ObjectDisplayOptions.IncludeTypeSuffix) && DynAbs.Tracing.TraceSender.Conditional_F2(10954, 17321, 17333)) || DynAbs.Tracing.TraceSender.Conditional_F3(10954, 17336, 17342))) ? result + "D" : result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 17032, 17354);

                System.Globalization.CultureInfo
                f_10954_17202_17231(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 17202, 17231);
                    return return_v;
                }


                string
                f_10954_17182_17232(double
                this_param, string
                format, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString(format, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 17182, 17232);
                    return return_v;
                }


                bool
                f_10954_17256_17318(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 17256, 17318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 17032, 17354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 17032, 17354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(float value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 17366, 17687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 17502, 17566);

                var
                result = f_10954_17515_17565(value, "R", f_10954_17535_17564(cultureInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 17582, 17676);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10954, 17589, 17651) || ((f_10954_17589_17651(options, ObjectDisplayOptions.IncludeTypeSuffix) && DynAbs.Tracing.TraceSender.Conditional_F2(10954, 17654, 17666)) || DynAbs.Tracing.TraceSender.Conditional_F3(10954, 17669, 17675))) ? result + "F" : result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 17366, 17687);

                System.Globalization.CultureInfo
                f_10954_17535_17564(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 17535, 17564);
                    return return_v;
                }


                string
                f_10954_17515_17565(float
                this_param, string
                format, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString(format, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 17515, 17565);
                    return return_v;
                }


                bool
                f_10954_17589_17651(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 17589, 17651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 17366, 17687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 17366, 17687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatLiteral(decimal value, ObjectDisplayOptions options, CultureInfo cultureInfo = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 17699, 18017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 17837, 17896);

                var
                result = f_10954_17850_17895(value, f_10954_17865_17894(cultureInfo))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 17912, 18006);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10954, 17919, 17981) || ((f_10954_17919_17981(options, ObjectDisplayOptions.IncludeTypeSuffix) && DynAbs.Tracing.TraceSender.Conditional_F2(10954, 17984, 17996)) || DynAbs.Tracing.TraceSender.Conditional_F3(10954, 17999, 18005))) ? result + "M" : result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 17699, 18017);

                System.Globalization.CultureInfo
                f_10954_17865_17894(System.Globalization.CultureInfo?
                cultureInfo)
                {
                    var return_v = GetFormatCulture(cultureInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 17865, 17894);
                    return return_v;
                }


                string
                f_10954_17850_17895(decimal
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 17850, 17895);
                    return return_v;
                }


                bool
                f_10954_17919_17981(Microsoft.CodeAnalysis.ObjectDisplayOptions
                options, Microsoft.CodeAnalysis.ObjectDisplayOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10954, 17919, 17981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 17699, 18017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 17699, 18017);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CultureInfo GetFormatCulture(CultureInfo cultureInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10954, 18029, 18184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10954, 18122, 18173);

                return cultureInfo ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Globalization.CultureInfo>(10954, 18129, 18172) ?? f_10954_18144_18172());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10954, 18029, 18184);

                System.Globalization.CultureInfo
                f_10954_18144_18172()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10954, 18144, 18172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10954, 18029, 18184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 18029, 18184);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ObjectDisplay()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10954, 1064, 18191);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10954, 1064, 18191);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10954, 1064, 18191);
        }

    }
}
