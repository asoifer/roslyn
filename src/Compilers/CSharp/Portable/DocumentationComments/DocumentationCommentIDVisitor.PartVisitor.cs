// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class DocumentationCommentIDVisitor
    {
        private sealed class PartVisitor : CSharpSymbolVisitor<StringBuilder, object>
        {
            internal static readonly PartVisitor Instance;

            private static readonly PartVisitor s_parameterOrReturnTypeInstance;

            private readonly bool _inParameterOrReturnType;

            private PartVisitor(bool inParameterOrReturnType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10934, 1414, 1562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 1373, 1397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 1496, 1547);

                    _inParameterOrReturnType = inParameterOrReturnType;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10934, 1414, 1562);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 1414, 1562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 1414, 1562);
                }
            }

            public override object VisitArrayType(ArrayTypeSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 1578, 2290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 1695, 1730);

                    f_10934_1695_1729(this, f_10934_1701_1719(symbol), builder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 1834, 2243) || true) && (f_10934_1838_1854(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 1834, 2243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 1896, 1917);

                        f_10934_1896_1916(builder, "[]");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 1834, 2243);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 1834, 2243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 1999, 2021);

                        f_10934_1999_2020(builder, "[0:");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2054, 2059);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2045, 2180) || true) && (i < f_10934_2065_2076(symbol) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2082, 2085)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 2045, 2180))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 2045, 2180);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2135, 2157);

                                f_10934_2135_2156(builder, ",0:");
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10934, 1, 136);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10934, 1, 136);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2204, 2224);

                        f_10934_2204_2223(
                                            builder, ']');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 1834, 2243);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2263, 2275);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 1578, 2290);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10934_1701_1719(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 1701, 1719);
                        return return_v;
                    }


                    object
                    f_10934_1695_1729(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 1695, 1729);
                        return return_v;
                    }


                    bool
                    f_10934_1838_1854(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSZArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 1838, 1854);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_1896_1916(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 1896, 1916);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_1999_2020(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 1999, 2020);
                        return return_v;
                    }


                    int
                    f_10934_2065_2076(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Rank;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 2065, 2076);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_2135_2156(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 2135, 2156);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_2204_2223(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 2204, 2223);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 1578, 2290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 1578, 2290);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object VisitField(FieldSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 2306, 2584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2415, 2453);

                    f_10934_2415_2452(this, f_10934_2421_2442(symbol), builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2471, 2491);

                    f_10934_2471_2490(builder, '.');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2509, 2537);

                    f_10934_2509_2536(builder, f_10934_2524_2535(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2557, 2569);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 2306, 2584);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10934_2421_2442(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 2421, 2442);
                        return return_v;
                    }


                    object
                    f_10934_2415_2452(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 2415, 2452);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_2471_2490(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 2471, 2490);
                        return return_v;
                    }


                    string
                    f_10934_2524_2535(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 2524, 2535);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_2509_2536(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 2509, 2536);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 2306, 2584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 2306, 2584);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void VisitParameters(ImmutableArray<ParameterSymbol> parameters, bool isVararg, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 2600, 3301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2743, 2763);

                    f_10934_2743_2762(builder, '(');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2781, 2805);

                    bool
                    needsComma = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2825, 3119);
                        foreach (var parameter in f_10934_2851_2861_I(parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 2825, 3119);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2903, 3010) || true) && (needsComma)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 2903, 3010);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 2967, 2987);

                                f_10934_2967_2986(builder, ',');
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 2903, 3010);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3034, 3060);

                            f_10934_3034_3059(this, parameter, builder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3082, 3100);

                            needsComma = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 2825, 3119);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10934, 1, 295);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10934, 1, 295);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3139, 3246) || true) && (isVararg && (DynAbs.Tracing.TraceSender.Expression_True(10934, 3143, 3165) && needsComma))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 3139, 3246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3207, 3227);

                        f_10934_3207_3226(builder, ',');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 3139, 3246);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3266, 3286);

                    f_10934_3266_3285(
                                    builder, ')');
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 2600, 3301);

                    System.Text.StringBuilder
                    f_10934_2743_2762(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 2743, 2762);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_2967_2986(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 2967, 2986);
                        return return_v;
                    }


                    object
                    f_10934_3034_3059(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 3034, 3059);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10934_2851_2861_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 2851, 2861);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_3207_3226(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 3207, 3226);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_3266_3285(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 3266, 3285);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 2600, 3301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 2600, 3301);
                }
            }

            public override object VisitMethod(MethodSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 3317, 4245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3428, 3466);

                    f_10934_3428_3465(this, f_10934_3434_3455(symbol), builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3484, 3504);

                    f_10934_3484_3503(builder, '.');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3522, 3569);

                    f_10934_3522_3568(builder, f_10934_3537_3567(symbol));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3589, 3743) || true) && (f_10934_3593_3605(symbol) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 3589, 3743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3652, 3673);

                        f_10934_3652_3672(builder, "``");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3695, 3724);

                        f_10934_3695_3723(builder, f_10934_3710_3722(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 3589, 3743);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3763, 3963) || true) && (symbol.Parameters.Any() || (DynAbs.Tracing.TraceSender.Expression_False(10934, 3767, 3809) || f_10934_3794_3809(symbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 3763, 3963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3851, 3944);

                        f_10934_3851_3943(s_parameterOrReturnTypeInstance, f_10934_3899_3916(symbol), f_10934_3918_3933(symbol), builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 3763, 3963);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 3983, 4198) || true) && (f_10934_3987_4004(symbol) == MethodKind.Conversion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 3983, 4198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4071, 4091);

                        f_10934_4071_4090(builder, '~');
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4113, 4179);

                        f_10934_4113_4178(s_parameterOrReturnTypeInstance, f_10934_4151_4168(symbol), builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 3983, 4198);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4218, 4230);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 3317, 4245);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10934_3434_3455(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 3434, 3455);
                        return return_v;
                    }


                    object
                    f_10934_3428_3465(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 3428, 3465);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_3484_3503(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 3484, 3503);
                        return return_v;
                    }


                    string
                    f_10934_3537_3567(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = GetEscapedMetadataName((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 3537, 3567);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_3522_3568(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 3522, 3568);
                        return return_v;
                    }


                    int
                    f_10934_3593_3605(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 3593, 3605);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_3652_3672(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 3652, 3672);
                        return return_v;
                    }


                    int
                    f_10934_3710_3722(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 3710, 3722);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_3695_3723(System.Text.StringBuilder
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 3695, 3723);
                        return return_v;
                    }


                    bool
                    f_10934_3794_3809(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 3794, 3809);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10934_3899_3916(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 3899, 3916);
                        return return_v;
                    }


                    bool
                    f_10934_3918_3933(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 3918, 3933);
                        return return_v;
                    }


                    int
                    f_10934_3851_3943(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, bool
                    isVararg, System.Text.StringBuilder
                    builder)
                    {
                        this_param.VisitParameters(parameters, isVararg, builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 3851, 3943);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10934_3987_4004(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 3987, 4004);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_4071_4090(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4071, 4090);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10934_4151_4168(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 4151, 4168);
                        return return_v;
                    }


                    object
                    f_10934_4113_4178(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4113, 4178);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 3317, 4245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 3317, 4245);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object VisitProperty(PropertySymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 4261, 4755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4376, 4414);

                    f_10934_4376_4413(this, f_10934_4382_4403(symbol), builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4432, 4452);

                    f_10934_4432_4451(builder, '.');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4470, 4517);

                    f_10934_4470_4516(builder, f_10934_4485_4515(symbol));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4537, 4708) || true) && (symbol.Parameters.Any())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 4537, 4708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4606, 4689);

                        f_10934_4606_4688(s_parameterOrReturnTypeInstance, f_10934_4654_4671(symbol), false, builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 4537, 4708);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4728, 4740);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 4261, 4755);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10934_4382_4403(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 4382, 4403);
                        return return_v;
                    }


                    object
                    f_10934_4376_4413(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4376, 4413);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_4432_4451(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4432, 4451);
                        return return_v;
                    }


                    string
                    f_10934_4485_4515(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    symbol)
                    {
                        var return_v = GetEscapedMetadataName((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4485, 4515);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_4470_4516(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4470, 4516);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10934_4654_4671(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 4654, 4671);
                        return return_v;
                    }


                    int
                    f_10934_4606_4688(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, bool
                    isVararg, System.Text.StringBuilder
                    builder)
                    {
                        this_param.VisitParameters(parameters, isVararg, builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4606, 4688);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 4261, 4755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 4261, 4755);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object VisitEvent(EventSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 4771, 5068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4880, 4918);

                    f_10934_4880_4917(this, f_10934_4886_4907(symbol), builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4936, 4956);

                    f_10934_4936_4955(builder, '.');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 4974, 5021);

                    f_10934_4974_5020(builder, f_10934_4989_5019(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 5041, 5053);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 4771, 5068);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10934_4886_4907(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 4886, 4907);
                        return return_v;
                    }


                    object
                    f_10934_4880_4917(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4880, 4917);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_4936_4955(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4936, 4955);
                        return return_v;
                    }


                    string
                    f_10934_4989_5019(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    symbol)
                    {
                        var return_v = GetEscapedMetadataName((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4989, 5019);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_4974_5020(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 4974, 5020);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 4771, 5068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 4771, 5068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object VisitTypeParameter(TypeParameterSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 5084, 6222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 5209, 5231);

                    int
                    ordinalOffset = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 5307, 5357);

                    Symbol
                    containingSymbol = f_10934_5333_5356(symbol)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 5375, 6108) || true) && (f_10934_5379_5400(containingSymbol) == SymbolKind.Method)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 5375, 6108);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 5463, 5484);

                        f_10934_5463_5483(builder, "``");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 5375, 6108);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 5375, 6108);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 5566, 5616);

                        f_10934_5566_5615(containingSymbol is NamedTypeSymbol);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 5858, 5896);

                            // If the containing type is nested within other types, then we need to add their arities.
                            // e.g. A<T>.B<U>.M<V>(T t, U u, V v) should be M(`0, `1, ``0).
                            for (NamedTypeSymbol
        curr = f_10934_5865_5896(containingSymbol)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 5837, 6047) || true) && ((object)curr != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 5920, 5946)
        , curr = f_10934_5927_5946(curr), DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 5837, 6047))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 5837, 6047);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 5996, 6024);

                                ordinalOffset += f_10934_6013_6023(curr);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10934, 1, 211);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10934, 1, 211);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 6069, 6089);

                        f_10934_6069_6088(builder, '`');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 5375, 6108);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 6128, 6175);

                    f_10934_6128_6174(
                                    builder, f_10934_6143_6157(symbol) + ordinalOffset);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 6195, 6207);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 5084, 6222);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10934_5333_5356(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 5333, 5356);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10934_5379_5400(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 5379, 5400);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_5463_5483(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 5463, 5483);
                        return return_v;
                    }


                    int
                    f_10934_5566_5615(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 5566, 5615);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10934_5865_5896(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 5865, 5896);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10934_5927_5946(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 5927, 5946);
                        return return_v;
                    }


                    int
                    f_10934_6013_6023(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 6013, 6023);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_6069_6088(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 6069, 6088);
                        return return_v;
                    }


                    int
                    f_10934_6143_6157(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 6143, 6157);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_6128_6174(System.Text.StringBuilder
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 6128, 6174);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 5084, 6222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 5084, 6222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object VisitNamedType(NamedTypeSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 6238, 7926);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 6355, 6585) || true) && ((object)f_10934_6367_6390(symbol) != null && (DynAbs.Tracing.TraceSender.Expression_True(10934, 6359, 6442) && f_10934_6402_6437(f_10934_6402_6430(f_10934_6402_6425(symbol))) != 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 6355, 6585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 6484, 6524);

                        f_10934_6484_6523(this, f_10934_6490_6513(symbol), builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 6546, 6566);

                        f_10934_6546_6565(builder, '.');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 6355, 6585);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 6605, 6633);

                    f_10934_6605_6632(
                                    builder, f_10934_6620_6631(symbol));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 6653, 7879) || true) && (f_10934_6657_6669(symbol) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 6653, 7879);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 6931, 7860) || true) && (!_inParameterOrReturnType && (DynAbs.Tracing.TraceSender.Expression_True(10934, 6935, 7050) && f_10934_6964_7050(symbol, f_10934_6990_7012(symbol), TypeCompareKind.ConsiderEverything2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 6931, 7860);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7100, 7120);

                            f_10934_7100_7119(builder, '`');
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7146, 7175);

                            f_10934_7146_7174(builder, f_10934_7161_7173(symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 6931, 7860);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 6931, 7860);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7273, 7293);

                            f_10934_7273_7292(builder, '{');
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7321, 7345);

                            bool
                            needsComma = false
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7373, 7789);
                                foreach (var typeArgument in f_10934_7402_7457_I(f_10934_7402_7457(symbol)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 7373, 7789);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7515, 7646) || true) && (needsComma)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 7515, 7646);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7595, 7615);

                                        f_10934_7595_7614(builder, ',');
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 7515, 7646);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7678, 7712);

                                    f_10934_7678_7711(this, typeArgument.Type, builder);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7744, 7762);

                                    needsComma = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 7373, 7789);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10934, 1, 417);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10934, 1, 417);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7817, 7837);

                            f_10934_7817_7836(
                                                    builder, '}');
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 6931, 7860);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 6653, 7879);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 7899, 7911);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 6238, 7926);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10934_6367_6390(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 6367, 6390);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10934_6402_6425(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 6402, 6425);
                        return return_v;
                    }


                    string
                    f_10934_6402_6430(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 6402, 6430);
                        return return_v;
                    }


                    int
                    f_10934_6402_6437(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 6402, 6437);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10934_6490_6513(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 6490, 6513);
                        return return_v;
                    }


                    object
                    f_10934_6484_6523(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit(symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 6484, 6523);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_6546_6565(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 6546, 6565);
                        return return_v;
                    }


                    string
                    f_10934_6620_6631(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 6620, 6631);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_6605_6632(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 6605, 6632);
                        return return_v;
                    }


                    int
                    f_10934_6657_6669(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 6657, 6669);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10934_6990_7012(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstructedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 6990, 7012);
                        return return_v;
                    }


                    bool
                    f_10934_6964_7050(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 6964, 7050);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_7100_7119(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 7100, 7119);
                        return return_v;
                    }


                    int
                    f_10934_7161_7173(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 7161, 7173);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_7146_7174(System.Text.StringBuilder
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 7146, 7174);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_7273_7292(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 7273, 7292);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10934_7402_7457(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 7402, 7457);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_7595_7614(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 7595, 7614);
                        return return_v;
                    }


                    object
                    f_10934_7678_7711(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 7678, 7711);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10934_7402_7457_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 7402, 7457);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_7817_7836(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 7817, 7836);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 6238, 7926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 6238, 7926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object VisitPointerType(PointerTypeSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 7942, 8185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8063, 8100);

                    f_10934_8063_8099(this, f_10934_8069_8089(symbol), builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8118, 8138);

                    f_10934_8118_8137(builder, '*');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8158, 8170);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 7942, 8185);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10934_8069_8089(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 8069, 8089);
                        return return_v;
                    }


                    object
                    f_10934_8063_8099(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 8063, 8099);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_8118_8137(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 8118, 8137);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 7942, 8185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 7942, 8185);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object VisitNamespace(NamespaceSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 8201, 8652);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8318, 8557) || true) && ((object)f_10934_8330_8356(symbol) != null && (DynAbs.Tracing.TraceSender.Expression_True(10934, 8322, 8411) && f_10934_8368_8406(f_10934_8368_8399(f_10934_8368_8394(symbol))) != 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 8318, 8557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8453, 8496);

                        f_10934_8453_8495(this, f_10934_8459_8485(symbol), builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8518, 8538);

                        f_10934_8518_8537(builder, '.');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 8318, 8557);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8577, 8605);

                    f_10934_8577_8604(
                                    builder, f_10934_8592_8603(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8625, 8637);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 8201, 8652);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10934_8330_8356(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 8330, 8356);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10934_8368_8394(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 8368, 8394);
                        return return_v;
                    }


                    string
                    f_10934_8368_8399(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 8368, 8399);
                        return return_v;
                    }


                    int
                    f_10934_8368_8406(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 8368, 8406);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10934_8459_8485(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 8459, 8485);
                        return return_v;
                    }


                    object
                    f_10934_8453_8495(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 8453, 8495);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_8518_8537(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 8518, 8537);
                        return return_v;
                    }


                    string
                    f_10934_8592_8603(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 8592, 8603);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_8577_8604(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 8577, 8604);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 8201, 8652);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 8201, 8652);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object VisitParameter(ParameterSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 8668, 9113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8785, 8824);

                    f_10934_8785_8823(_inParameterOrReturnType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8844, 8872);

                    f_10934_8844_8871(this, f_10934_8850_8861(symbol), builder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 8951, 9066) || true) && (f_10934_8955_8969(symbol) != RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10934, 8951, 9066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 9027, 9047);

                        f_10934_9027_9046(builder, '@');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10934, 8951, 9066);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 9086, 9098);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 8668, 9113);

                    int
                    f_10934_8785_8823(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 8785, 8823);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10934_8850_8861(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 8850, 8861);
                        return return_v;
                    }


                    object
                    f_10934_8844_8871(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol, System.Text.StringBuilder
                    argument)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 8844, 8871);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10934_8955_8969(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 8955, 8969);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_9027_9046(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 9027, 9046);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 8668, 9113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 8668, 9113);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object VisitErrorType(ErrorTypeSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 9129, 9300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 9246, 9285);

                    return f_10934_9253_9284(this, symbol, builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 9129, 9300);

                    object
                    f_10934_9253_9284(Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    symbol, System.Text.StringBuilder
                    builder)
                    {
                        var return_v = this_param.VisitNamedType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)symbol, builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 9253, 9284);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 9129, 9300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 9129, 9300);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object VisitDynamicType(DynamicTypeSymbol symbol, StringBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10934, 9316, 9887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 9808, 9840);

                    f_10934_9808_9839(                // NOTE: this is a change from dev11, which did not allow dynamic in parameter types.
                                                      // If we wanted to be really conservative, we would actually visit the symbol for
                                                      // System.Object.  However, the System.Object type must always have exactly this
                                                      // doc comment ID, so the hassle seems unjustifiable.
                                    builder, "System.Object");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 9860, 9872);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10934, 9316, 9887);

                    System.Text.StringBuilder
                    f_10934_9808_9839(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 9808, 9839);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 9316, 9887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 9316, 9887);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static string GetEscapedMetadataName(Symbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10934, 9903, 10548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 9995, 10037);

                    string
                    metadataName = f_10934_10017_10036(symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 10057, 10132);

                    int
                    colonColonIndex = f_10934_10079_10131(metadataName, "::", StringComparison.Ordinal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 10150, 10213);

                    int
                    startIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(10934, 10167, 10186) || ((colonColonIndex < 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10934, 10189, 10190)) || DynAbs.Tracing.TraceSender.Conditional_F3(10934, 10193, 10212))) ? 0 : colonColonIndex + 2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 10233, 10296);

                    PooledStringBuilder
                    pooled = f_10934_10262_10295()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 10314, 10396);

                    f_10934_10314_10395(pooled.Builder, metadataName, startIndex, f_10934_10362_10381(metadataName) - startIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 10414, 10483);

                    f_10934_10414_10482(f_10934_10414_10464(f_10934_10414_10446(pooled.Builder, '.', '#'), '<', '{'), '>', '}');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 10501, 10533);

                    return f_10934_10508_10532(pooled);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10934, 9903, 10548);

                    string
                    f_10934_10017_10036(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 10017, 10036);
                        return return_v;
                    }


                    int
                    f_10934_10079_10131(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.IndexOf(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 10079, 10131);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    f_10934_10262_10295()
                    {
                        var return_v = PooledStringBuilder.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 10262, 10295);
                        return return_v;
                    }


                    int
                    f_10934_10362_10381(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10934, 10362, 10381);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_10314_10395(System.Text.StringBuilder
                    this_param, string
                    value, int
                    startIndex, int
                    count)
                    {
                        var return_v = this_param.Append(value, startIndex, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 10314, 10395);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_10414_10446(System.Text.StringBuilder
                    this_param, char
                    oldChar, char
                    newChar)
                    {
                        var return_v = this_param.Replace(oldChar, newChar);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 10414, 10446);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_10414_10464(System.Text.StringBuilder
                    this_param, char
                    oldChar, char
                    newChar)
                    {
                        var return_v = this_param.Replace(oldChar, newChar);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 10414, 10464);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10934_10414_10482(System.Text.StringBuilder
                    this_param, char
                    oldChar, char
                    newChar)
                    {
                        var return_v = this_param.Replace(oldChar, newChar);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 10414, 10482);
                        return return_v;
                    }


                    string
                    f_10934_10508_10532(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToStringAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 10508, 10532);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10934, 9903, 10548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 9903, 10548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static PartVisitor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10934, 884, 10559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 1081, 1139);
                Instance = f_10934_1092_1139(inParameterOrReturnType: false); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10934, 1254, 1334);
                s_parameterOrReturnTypeInstance = f_10934_1288_1334(inParameterOrReturnType: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10934, 884, 10559);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10934, 884, 10559);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10934, 884, 10559);

            static Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
            f_10934_1092_1139(bool
            inParameterOrReturnType)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor(inParameterOrReturnType: inParameterOrReturnType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 1092, 1139);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor
            f_10934_1288_1334(bool
            inParameterOrReturnType)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.DocumentationCommentIDVisitor.PartVisitor(inParameterOrReturnType: inParameterOrReturnType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10934, 1288, 1334);
                return return_v;
            }

        }
    }
}
