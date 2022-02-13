// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    [Flags]
    internal enum AttributeLocation : short
    {
        None = 0,

        // the order of these determine the order in which they are displayed in error messages when multiple locations are possible:
        Assembly = 1 << 0,
        Module = 1 << 1,
        Type = 1 << 2,
        Method = 1 << 3,
        Field = 1 << 4,
        Property = 1 << 5,
        Event = 1 << 6,
        Parameter = 1 << 7,
        Return = 1 << 8,
        TypeParameter = 1 << 9,

        // must be the last:
        Unknown = 1 << 10,
    }
    internal static class AttributeLocationExtensions
    {
        internal static string ToDisplayString(this AttributeLocation locations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10009, 1100, 3329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 1197, 1240);

                StringBuilder
                result = f_10009_1220_1239()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 1263, 1268);
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 1254, 3277) || true) && (i < (int)AttributeLocation.Unknown)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 1306, 1313)
        , i <<= 1, DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1254, 3277))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1254, 3277);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 1347, 3262) || true) && ((locations & (AttributeLocation)i) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1347, 3262);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 1432, 1546) || true) && (f_10009_1436_1449(result) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1432, 1546);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 1503, 1523);

                                f_10009_1503_1522(result, ", ");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1432, 1546);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 1570, 3243);

                            switch ((AttributeLocation)i)
                            {

                                case AttributeLocation.Assembly:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 1710, 1736);

                                    f_10009_1710_1735(result, "assembly");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10009, 1766, 1772);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);

                                case AttributeLocation.Module:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 1860, 1884);

                                    f_10009_1860_1883(result, "module");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10009, 1914, 1920);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);

                                case AttributeLocation.Type:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 2006, 2028);

                                    f_10009_2006_2027(result, "type");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10009, 2058, 2064);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);

                                case AttributeLocation.Method:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 2152, 2176);

                                    f_10009_2152_2175(result, "method");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10009, 2206, 2212);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);

                                case AttributeLocation.Field:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 2299, 2322);

                                    f_10009_2299_2321(result, "field");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10009, 2352, 2358);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);

                                case AttributeLocation.Property:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 2448, 2474);

                                    f_10009_2448_2473(result, "property");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10009, 2504, 2510);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);

                                case AttributeLocation.Event:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 2597, 2620);

                                    f_10009_2597_2619(result, "event");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10009, 2650, 2656);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);

                                case AttributeLocation.Return:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 2744, 2768);

                                    f_10009_2744_2767(result, "return");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10009, 2798, 2804);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);

                                case AttributeLocation.Parameter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 2895, 2918);

                                    f_10009_2895_2917(result, "param");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10009, 2948, 2954);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);

                                case AttributeLocation.TypeParameter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 3049, 3074);

                                    f_10009_3049_3073(result, "typevar");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10009, 3104, 3110);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 1570, 3243);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 3176, 3220);

                                    throw f_10009_3182_3219(i);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1570, 3243);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 1347, 3262);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10009, 1, 2024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10009, 1, 2024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 3293, 3318);

                return f_10009_3300_3317(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10009, 1100, 3329);

                System.Text.StringBuilder
                f_10009_1220_1239()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 1220, 1239);
                    return return_v;
                }


                int
                f_10009_1436_1449(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10009, 1436, 1449);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_1503_1522(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 1503, 1522);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_1710_1735(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 1710, 1735);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_1860_1883(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 1860, 1883);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_2006_2027(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 2006, 2027);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_2152_2175(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 2152, 2175);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_2299_2321(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 2299, 2321);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_2448_2473(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 2448, 2473);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_2597_2619(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 2597, 2619);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_2744_2767(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 2744, 2767);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_2895_2917(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 2895, 2917);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10009_3049_3073(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 3049, 3073);
                    return return_v;
                }


                System.Exception
                f_10009_3182_3219(int
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 3182, 3219);
                    return return_v;
                }


                string
                f_10009_3300_3317(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 3300, 3317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10009, 1100, 3329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10009, 1100, 3329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AttributeLocation ToAttributeLocation(this SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10009, 3341, 3676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 3621, 3665);

                return f_10009_3628_3664(token.ValueText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10009, 3341, 3676);

                Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                f_10009_3628_3664(string
                text)
                {
                    var return_v = ToAttributeLocation(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 3628, 3664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10009, 3341, 3676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10009, 3341, 3676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AttributeLocation ToAttributeLocation(this Syntax.InternalSyntax.SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10009, 3688, 4045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 3990, 4034);

                return f_10009_3997_4033(f_10009_4017_4032(token));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10009, 3688, 4045);

                string
                f_10009_4017_4032(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10009, 4017, 4032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation
                f_10009_3997_4033(string
                text)
                {
                    var return_v = ToAttributeLocation(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10009, 3997, 4033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10009, 3688, 4045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10009, 3688, 4045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static AttributeLocation ToAttributeLocation(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10009, 4057, 5149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 4147, 5138);

                switch (text)
                {

                    case "assembly":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 4231, 4265);

                        return AttributeLocation.Assembly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);

                    case "module":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 4319, 4351);

                        return AttributeLocation.Module;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);

                    case "type":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 4403, 4433);

                        return AttributeLocation.Type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);

                    case "return":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 4487, 4519);

                        return AttributeLocation.Return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);

                    case "method":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 4573, 4605);

                        return AttributeLocation.Method;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);

                    case "field":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 4658, 4689);

                        return AttributeLocation.Field;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);

                    case "event":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 4742, 4773);

                        return AttributeLocation.Event;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);

                    case "param":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 4826, 4861);

                        return AttributeLocation.Parameter;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);

                    case "property":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 4917, 4951);

                        return AttributeLocation.Property;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);

                    case "typevar":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 5006, 5045);

                        return AttributeLocation.TypeParameter;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10009, 4147, 5138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10009, 5093, 5123);

                        return AttributeLocation.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10009, 4147, 5138);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10009, 4057, 5149);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10009, 4057, 5149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10009, 4057, 5149);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AttributeLocationExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10009, 1034, 5156);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10009, 1034, 5156);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10009, 1034, 5156);
        }

    }
}
