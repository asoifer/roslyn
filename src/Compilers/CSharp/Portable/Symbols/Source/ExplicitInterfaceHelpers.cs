// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class ExplicitInterfaceHelpers
    {
        public static string GetMemberName(
                    Binder binder,
                    ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierOpt,
                    string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 709, 1339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 900, 965);

                DiagnosticBag
                discardedDiagnostics = f_10226_937_964()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 979, 1021);

                TypeSymbol
                discardedExplicitInterfaceType
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 1035, 1060);

                string
                discardedAliasOpt
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 1074, 1252);

                string
                methodName = f_10226_1094_1251(binder, explicitInterfaceSpecifierOpt, name, discardedDiagnostics, out discardedExplicitInterfaceType, out discardedAliasOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 1266, 1294);

                f_10226_1266_1293(discardedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 1310, 1328);

                return methodName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 709, 1339);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10226_937_964()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 937, 964);
                    return return_v;
                }


                string
                f_10226_1094_1251(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifierOpt, string
                name, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                explicitInterfaceTypeOpt, out string
                aliasQualifierOpt)
                {
                    var return_v = GetMemberNameAndInterfaceSymbol(binder, explicitInterfaceSpecifierOpt, name, diagnostics, out explicitInterfaceTypeOpt, out aliasQualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 1094, 1251);
                    return return_v;
                }


                int
                f_10226_1266_1293(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 1266, 1293);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 709, 1339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 709, 1339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetMemberNameAndInterfaceSymbol(
                    Binder binder,
                    ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierOpt,
                    string name,
                    DiagnosticBag diagnostics,
                    out TypeSymbol explicitInterfaceTypeOpt,
                    out string aliasQualifierOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 1351, 2560);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 1697, 1892) || true) && (explicitInterfaceSpecifierOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 1697, 1892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 1772, 1804);

                    explicitInterfaceTypeOpt = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 1822, 1847);

                    aliasQualifierOpt = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 1865, 1877);

                    return name;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 1697, 1892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 2089, 2200);

                binder = f_10226_2098_2199(binder, BinderFlags.SuppressConstraintChecks | BinderFlags.SuppressObsoleteChecks);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 2216, 2286);

                NameSyntax
                explicitInterfaceName = f_10226_2251_2285(explicitInterfaceSpecifierOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 2300, 2384);

                explicitInterfaceTypeOpt = f_10226_2327_2378(binder, explicitInterfaceName, diagnostics).Type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 2398, 2463);

                aliasQualifierOpt = f_10226_2418_2462(explicitInterfaceName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 2477, 2549);

                return f_10226_2484_2548(name, explicitInterfaceTypeOpt, aliasQualifierOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 1351, 2560);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10226_2098_2199(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 2098, 2199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10226_2251_2285(Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 2251, 2285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10226_2327_2378(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 2327, 2378);
                    return return_v;
                }


                string?
                f_10226_2418_2462(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.GetAliasQualifierOpt();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 2418, 2462);
                    return return_v;
                }


                string
                f_10226_2484_2548(string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                explicitInterfaceTypeOpt, string?
                aliasQualifierOpt)
                {
                    var return_v = GetMemberName(name, explicitInterfaceTypeOpt, aliasQualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 2484, 2548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 1351, 2560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 1351, 2560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetMemberName(string name, TypeSymbol explicitInterfaceTypeOpt, string aliasQualifierOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 2572, 3865);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 2707, 2812) || true) && ((object)explicitInterfaceTypeOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 2707, 2812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 2785, 2797);

                    return name;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 2707, 2812);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3010, 3133);

                string
                interfaceName = f_10226_3033_3132(explicitInterfaceTypeOpt, SymbolDisplayFormat.ExplicitInterfaceImplementationFormat)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3149, 3212);

                PooledStringBuilder
                pooled = f_10226_3178_3211()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3226, 3265);

                StringBuilder
                builder = pooled.Builder
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3281, 3447) || true) && (!f_10226_3286_3325(aliasQualifierOpt))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 3281, 3447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3359, 3393);

                    f_10226_3359_3392(builder, aliasQualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3411, 3432);

                    f_10226_3411_3431(builder, "::");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 3281, 3447);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3463, 3735);
                    foreach (char ch in f_10226_3483_3496_I(interfaceName))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 3463, 3735);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3627, 3720) || true) && (ch != ' ')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 3627, 3720);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3682, 3701);

                            f_10226_3682_3700(builder, ch);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 3627, 3720);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 3463, 3735);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10226, 1, 273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10226, 1, 273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3751, 3771);

                f_10226_3751_3770(
                            builder, ".");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3785, 3806);

                f_10226_3785_3805(builder, name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3822, 3854);

                return f_10226_3829_3853(pooled);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 2572, 3865);

                string
                f_10226_3033_3132(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 3033, 3132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10226_3178_3211()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 3178, 3211);
                    return return_v;
                }


                bool
                f_10226_3286_3325(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 3286, 3325);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10226_3359_3392(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 3359, 3392);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10226_3411_3431(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 3411, 3431);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10226_3682_3700(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 3682, 3700);
                    return return_v;
                }


                string
                f_10226_3483_3496_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 3483, 3496);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10226_3751_3770(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 3751, 3770);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10226_3785_3805(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 3785, 3805);
                    return return_v;
                }


                string
                f_10226_3829_3853(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 3829, 3853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 2572, 3865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 2572, 3865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetMethodNameWithoutInterfaceName(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 3877, 4198);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 3982, 4117) || true) && (f_10226_3986_4003(method) != MethodKind.ExplicitInterfaceImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 3982, 4117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 4083, 4102);

                    return f_10226_4090_4101(method);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 3982, 4117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 4133, 4187);

                return f_10226_4140_4186(f_10226_4174_4185(method));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 3877, 4198);

                Microsoft.CodeAnalysis.MethodKind
                f_10226_3986_4003(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 3986, 4003);
                    return return_v;
                }


                string
                f_10226_4090_4101(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 4090, 4101);
                    return return_v;
                }


                string
                f_10226_4174_4185(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 4174, 4185);
                    return return_v;
                }


                string
                f_10226_4140_4186(string
                fullName)
                {
                    var return_v = GetMemberNameWithoutInterfaceName(fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 4140, 4186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 3877, 4198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 3877, 4198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetMemberNameWithoutInterfaceName(string fullName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 4210, 4505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 4306, 4342);

                var
                idx = f_10226_4316_4341(fullName, '.')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 4356, 4392);

                f_10226_4356_4391(idx < f_10226_4375_4390(fullName));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 4406, 4464);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10226, 4413, 4422) || (((idx > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10226, 4425, 4452)) || DynAbs.Tracing.TraceSender.Conditional_F3(10226, 4455, 4463))) ? f_10226_4425_4452(fullName, idx + 1) : fullName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 4210, 4505);

                int
                f_10226_4316_4341(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 4316, 4341);
                    return return_v;
                }


                int
                f_10226_4375_4390(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 4375, 4390);
                    return return_v;
                }


                int
                f_10226_4356_4391(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 4356, 4391);
                    return 0;
                }


                string
                f_10226_4425_4452(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 4425, 4452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 4210, 4505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 4210, 4505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> SubstituteExplicitInterfaceImplementations<T>(ImmutableArray<T> unsubstitutedExplicitInterfaceImplementations, TypeMap map) where T : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 4517, 6082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 4714, 4758);

                var
                builder = f_10226_4728_4757<T>()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 4772, 6019);
                    foreach (var unsubstitutedPropertyImplemented in f_10226_4821_4866_I<T>(unsubstitutedExplicitInterfaceImplementations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 4772, 6019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 4900, 4981);

                        var
                        unsubstitutedInterfaceType = f_10226_4933_4980<T>(unsubstitutedPropertyImplemented)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 4999, 5056);

                        f_10226_4999_5055<T>((object)unsubstitutedInterfaceType != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 5074, 5154);

                        var
                        explicitInterfaceType = f_10226_5102_5153<T>(map, unsubstitutedInterfaceType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 5172, 5224);

                        f_10226_5172_5223<T>((object)explicitInterfaceType != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 5242, 5291);

                        var
                        name = f_10226_5253_5290<T>(unsubstitutedPropertyImplemented)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 5343, 5381);

                        T
                        substitutedMemberImplemented = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 5399, 5778);
                            foreach (var candidateMember in f_10226_5431_5469_I(f_10226_5431_5469<T>(explicitInterfaceType, name)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 5399, 5778);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 5511, 5759) || true) && (f_10226_5515_5549<T>(candidateMember) == f_10226_5553_5604<T>(unsubstitutedPropertyImplemented))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 5511, 5759);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 5654, 5704);

                                    substitutedMemberImplemented = (T)candidateMember;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10226, 5730, 5736);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 5511, 5759);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 5399, 5778);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10226, 1, 380);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10226, 1, 380);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 5796, 5855);

                        f_10226_5796_5854<T>((object)substitutedMemberImplemented != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 5962, 6004);

                        f_10226_5962_6003<T>(builder, substitutedMemberImplemented);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 4772, 6019);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10226, 1, 1248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10226, 1, 1248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 6035, 6071);

                return f_10226_6042_6070<T>(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 4517, 6082);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_10226_4728_4757<T>() where T : Symbol

                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 4728, 4757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10226_4933_4980<T>(T
                this_param) where T : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 4933, 4980);
                    return return_v;
                }


                int
                f_10226_4999_5055<T>(bool
                condition) where T : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 4999, 5055);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10226_5102_5153<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous) where T : Symbol

                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 5102, 5153);
                    return return_v;
                }


                int
                f_10226_5172_5223<T>(bool
                condition) where T : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 5172, 5223);
                    return 0;
                }


                string
                f_10226_5253_5290<T>(T
                this_param) where T : Symbol

                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 5253, 5290);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10226_5431_5469<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name) where T : Symbol

                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 5431, 5469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10226_5515_5549<T>(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 5515, 5549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10226_5553_5604<T>(T
                this_param) where T : Symbol

                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 5553, 5604);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10226_5431_5469_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 5431, 5469);
                    return return_v;
                }


                int
                f_10226_5796_5854<T>(bool
                condition) where T : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 5796, 5854);
                    return 0;
                }


                int
                f_10226_5962_6003<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item) where T : Symbol

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 5962, 6003);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_10226_4821_4866_I<T>(System.Collections.Immutable.ImmutableArray<T>
                i) where T : Symbol

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 4821, 4866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_10226_6042_6070<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param) where T : Symbol

                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 6042, 6070);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 4517, 6082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 4517, 6082);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MethodSymbol FindExplicitlyImplementedMethod(
                    this MethodSymbol implementingMethod,
                    TypeSymbol explicitInterfaceType,
                    string interfaceMethodName,
                    ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierSyntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 6094, 6614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 6439, 6603);

                return (MethodSymbol)f_10226_6460_6602(implementingMethod, explicitInterfaceType, interfaceMethodName, explicitInterfaceSpecifierSyntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 6094, 6614);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10226_6460_6602(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                implementingMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                explicitInterfaceType, string
                interfaceMemberName, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifierSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = FindExplicitlyImplementedMember((Microsoft.CodeAnalysis.CSharp.Symbol)implementingMember, explicitInterfaceType, interfaceMemberName, explicitInterfaceSpecifierSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 6460, 6602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 6094, 6614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 6094, 6614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PropertySymbol FindExplicitlyImplementedProperty(
                    this PropertySymbol implementingProperty,
                    TypeSymbol explicitInterfaceType,
                    string interfacePropertyName,
                    ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierSyntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 6626, 7162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 6981, 7151);

                return (PropertySymbol)f_10226_7004_7150(implementingProperty, explicitInterfaceType, interfacePropertyName, explicitInterfaceSpecifierSyntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 6626, 7162);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10226_7004_7150(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                implementingMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                explicitInterfaceType, string
                interfaceMemberName, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifierSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = FindExplicitlyImplementedMember((Microsoft.CodeAnalysis.CSharp.Symbol)implementingMember, explicitInterfaceType, interfaceMemberName, explicitInterfaceSpecifierSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 7004, 7150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 6626, 7162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 6626, 7162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static EventSymbol FindExplicitlyImplementedEvent(
                    this EventSymbol implementingEvent,
                    TypeSymbol explicitInterfaceType,
                    string interfaceEventName,
                    ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierSyntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 7174, 7686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 7514, 7675);

                return (EventSymbol)f_10226_7534_7674(implementingEvent, explicitInterfaceType, interfaceEventName, explicitInterfaceSpecifierSyntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 7174, 7686);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10226_7534_7674(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                implementingMember, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                explicitInterfaceType, string
                interfaceMemberName, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifierSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = FindExplicitlyImplementedMember((Microsoft.CodeAnalysis.CSharp.Symbol)implementingMember, explicitInterfaceType, interfaceMemberName, explicitInterfaceSpecifierSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 7534, 7674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 7174, 7686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 7174, 7686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Symbol FindExplicitlyImplementedMember(
                    Symbol implementingMember,
                    TypeSymbol explicitInterfaceType,
                    string interfaceMemberName,
                    ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierSyntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 7698, 15768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 8025, 8127) || true) && ((object)explicitInterfaceType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 8025, 8127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 8100, 8112);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 8025, 8127);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 8143, 8196);

                var
                memberLocation = f_10226_8164_8192(implementingMember)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 8210, 8265);

                var
                containingType = f_10226_8231_8264(implementingMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 8281, 8691);

                switch (f_10226_8289_8312(containingType))
                {

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 8281, 8691);
                        DynAbs.Tracing.TraceSender.TraceBreak(10226, 8469, 8475);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 8281, 8691);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 8281, 8691);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 8525, 8642);

                        f_10226_8525_8641(diagnostics, ErrorCode.ERR_ExplicitInterfaceImplementationInNonClassOrStruct, memberLocation, implementingMember);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 8664, 8676);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 8281, 8691);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 8707, 9176) || true) && (!f_10226_8712_8751(explicitInterfaceType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 8707, 9176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 8858, 8926);

                    var
                    explicitInterfaceSyntax = f_10226_8888_8925(explicitInterfaceSpecifierSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 8944, 9003);

                    var
                    location = f_10226_8959_9002(explicitInterfaceSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 9023, 9131);

                    f_10226_9023_9130(
                                    diagnostics, ErrorCode.ERR_ExplicitInterfaceImplementationNotInterface, location, explicitInterfaceType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 9149, 9161);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 8707, 9176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 9192, 9264);

                var
                explicitInterfaceNamedType = (NamedTypeSymbol)explicitInterfaceType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 9476, 9637);

                MultiDictionary<NamedTypeSymbol, NamedTypeSymbol>.ValueSet
                set = f_10226_9541_9636(f_10226_9541_9608(containingType), explicitInterfaceNamedType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 9651, 9676);

                int
                setCount = set.Count
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 9690, 10611) || true) && (setCount == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10226, 9694, 9820) || !set.Contains(explicitInterfaceNamedType, Symbols.SymbolEqualityComparer.ObliviousNullableModifierMatchesAny)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 9690, 10611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 9927, 9995);

                    var
                    explicitInterfaceSyntax = f_10226_9957_9994(explicitInterfaceSpecifierSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 10013, 10072);

                    var
                    location = f_10226_10028_10071(explicitInterfaceSyntax)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 10092, 10556) || true) && (setCount > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10226, 10096, 10201) && set.Contains(explicitInterfaceNamedType, Symbols.SymbolEqualityComparer.IgnoringNullable)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 10092, 10556);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 10243, 10336);

                        f_10226_10243_10335(diagnostics, ErrorCode.WRN_NullabilityMismatchInExplicitlyImplementedInterface, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 10092, 10556);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 10092, 10556);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 10418, 10537);

                        f_10226_10418_10536(diagnostics, ErrorCode.ERR_ClassDoesntImplementInterface, location, implementingMember, explicitInterfaceNamedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 10092, 10556);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 9690, 10611);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 10665, 10968) || true) && (containingType == (object)f_10226_10695_10740(explicitInterfaceNamedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 10665, 10968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 10941, 10953);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 10665, 10968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 10984, 11045);

                var
                hasParamsParam = f_10226_11005_11044(implementingMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 11294, 11326);

                var
                foundMatchingMember = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 11342, 11374);

                Symbol
                implementedMember = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 11390, 13423);
                    foreach (Symbol interfaceMember in f_10226_11425_11483_I(f_10226_11425_11483(explicitInterfaceNamedType, interfaceMemberName)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 11390, 13423);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 11712, 11886) || true) && (f_10226_11716_11736(interfaceMember) != f_10226_11740_11763(implementingMember) || (DynAbs.Tracing.TraceSender.Expression_False(10226, 11716, 11816) || !f_10226_11768_11816(interfaceMember)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 11712, 11886);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 11858, 11867);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 11712, 11886);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 11906, 13408) || true) && (f_10226_11910_12008(MemberSignatureComparer.ExplicitImplementationComparer, implementingMember, interfaceMember))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 11906, 13408);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 12050, 12077);

                            foundMatchingMember = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 12231, 13389) || true) && (f_10226_12235_12263(interfaceMember) && (DynAbs.Tracing.TraceSender.Expression_True(10226, 12235, 12327) && !f_10226_12268_12327(((MethodSymbol)interfaceMember))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 12231, 13389);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 12377, 12488);

                                f_10226_12377_12487(diagnostics, ErrorCode.ERR_ExplicitMethodImplAccessor, memberLocation, implementingMember, interfaceMember);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 12231, 13389);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 12231, 13389);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 12586, 13270) || true) && (f_10226_12590_12631(interfaceMember))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 12586, 13270);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 12689, 12791);

                                    f_10226_12689_12790(diagnostics, ErrorCode.ERR_BogusExplicitImpl, memberLocation, implementingMember, interfaceMember);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 12586, 13270);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 12586, 13270);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 12849, 13270) || true) && (hasParamsParam && (DynAbs.Tracing.TraceSender.Expression_True(10226, 12853, 12908) && !f_10226_12872_12908(interfaceMember)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 12849, 13270);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 13140, 13243);

                                        f_10226_13140_13242(                            // Note: no error for !hasParamsParam && interfaceMethod.HasParamsParameter()
                                                                                        // Still counts as an implementation.
                                                                    diagnostics, ErrorCode.ERR_ExplicitImplParams, memberLocation, implementingMember, interfaceMember);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 12849, 13270);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 12586, 13270);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 13298, 13334);

                                implementedMember = interfaceMember;
                                DynAbs.Tracing.TraceSender.TraceBreak(10226, 13360, 13366);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 12231, 13389);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 11906, 13408);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 11390, 13423);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10226, 1, 2034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10226, 1, 2034);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 13439, 13759) || true) && (!foundMatchingMember)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 13439, 13759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 13653, 13744);

                    f_10226_13653_13743(                // CONSIDER: we may wish to suppress this error in the event that another error
                                                        // has been reported about the signature.
                                    diagnostics, ErrorCode.ERR_InterfaceMemberNotFound, memberLocation, implementingMember);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 13439, 13759);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 13834, 15716) || true) && ((object)implementedMember != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 13834, 15716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 13905, 13955);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 13975, 15629) || true) && (!f_10226_13980_14110(implementedMember, f_10226_14030_14063(implementingMember), ref useSiteDiagnostics, throughTypeOpt: null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 13975, 15629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 14152, 14228);

                        f_10226_14152_14227(diagnostics, ErrorCode.ERR_BadAccess, memberLocation, implementedMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 13975, 15629);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 13975, 15629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 14310, 15109);

                        switch (f_10226_14318_14340(implementedMember))
                        {

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 14310, 15109);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 14445, 14500);

                                var
                                propertySymbol = (PropertySymbol)implementedMember
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 14530, 14597);

                                f_10226_14530_14596(f_10226_14571_14595(propertySymbol));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 14627, 14694);

                                f_10226_14627_14693(f_10226_14668_14692(propertySymbol));
                                DynAbs.Tracing.TraceSender.TraceBreak(10226, 14724, 14730);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 14310, 15109);

                            case SymbolKind.Event:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 14310, 15109);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 14810, 14859);

                                var
                                eventSymbol = (EventSymbol)implementedMember
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 14889, 14953);

                                f_10226_14889_14952(f_10226_14930_14951(eventSymbol));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 14983, 15050);

                                f_10226_14983_15049(f_10226_15024_15048(eventSymbol));
                                DynAbs.Tracing.TraceSender.TraceBreak(10226, 15080, 15086);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 14310, 15109);
                        }

                        int f_10226_14530_14596(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol accessor)
                        {
                            checkAccessorIsAccessibleIfImplementable(accessor);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 14530, 14596);
                            return 0;
                        }

                        int
                        f_10226_14627_14693(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        accessor)
                        {
                            checkAccessorIsAccessibleIfImplementable(accessor);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 14627, 14693);
                            return 0;
                        }

                        int
                        f_10226_14889_14952(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        accessor)
                        {
                            checkAccessorIsAccessibleIfImplementable(accessor);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 14889, 14952);
                            return 0;
                        }

                        int
                        f_10226_14983_15049(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        accessor)
                        {
                            checkAccessorIsAccessibleIfImplementable(accessor);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 14983, 15049);
                            return 0;
                        }

                        void checkAccessorIsAccessibleIfImplementable(MethodSymbol accessor)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10226, 15133, 15610);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 15250, 15587) || true) && (f_10226_15254_15280(accessor) && (DynAbs.Tracing.TraceSender.Expression_True(10226, 15254, 15435) && !f_10226_15314_15435(accessor, f_10226_15355_15388(implementingMember), ref useSiteDiagnostics, throughTypeOpt: null)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 15250, 15587);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 15493, 15560);

                                    f_10226_15493_15559(diagnostics, ErrorCode.ERR_BadAccess, memberLocation, accessor);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 15250, 15587);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10226, 15133, 15610);

                                bool
                                f_10226_15254_15280(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                methodOpt)
                                {
                                    var return_v = methodOpt.IsImplementable();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 15254, 15280);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                f_10226_15355_15388(Microsoft.CodeAnalysis.CSharp.Symbol
                                this_param)
                                {
                                    var return_v = this_param.ContainingType;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 15355, 15388);
                                    return return_v;
                                }


                                bool
                                f_10226_15314_15435(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                                throughTypeOpt)
                                {
                                    var return_v = AccessCheck.IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, ref useSiteDiagnostics, throughTypeOpt: throughTypeOpt);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 15314, 15435);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                f_10226_15493_15559(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                                code, Microsoft.CodeAnalysis.Location
                                location, params object[]
                                args)
                                {
                                    var return_v = diagnostics.Add(code, location, args);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 15493, 15559);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 15133, 15610);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 15133, 15610);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 13975, 15629);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 15649, 15701);

                    f_10226_15649_15700(
                                    diagnostics, memberLocation, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 13834, 15716);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 15732, 15757);

                return implementedMember;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 7698, 15768);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10226_8164_8192(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 8164, 8192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10226_8231_8264(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 8231, 8264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10226_8289_8312(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 8289, 8312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_8525_8641(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 8525, 8641);
                    return return_v;
                }


                bool
                f_10226_8712_8751(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 8712, 8751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10226_8888_8925(Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 8888, 8925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10226_8959_9002(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 8959, 9002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_9023_9130(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 9023, 9130);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10226_9541_9608(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 9541, 9608);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>.ValueSet
                f_10226_9541_9636(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 9541, 9636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10226_9957_9994(Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 9957, 9994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10226_10028_10071(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 10028, 10071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_10243_10335(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 10243, 10335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_10418_10536(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 10418, 10536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10226_10695_10740(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 10695, 10740);
                    return return_v;
                }


                bool
                f_10226_11005_11044(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.HasParamsParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 11005, 11044);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10226_11425_11483(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 11425, 11483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10226_11716_11736(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 11716, 11736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10226_11740_11763(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 11740, 11763);
                    return return_v;
                }


                bool
                f_10226_11768_11816(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsImplementableInterfaceMember();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 11768, 11816);
                    return return_v;
                }


                bool
                f_10226_11910_12008(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 11910, 12008);
                    return return_v;
                }


                bool
                f_10226_12235_12263(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 12235, 12263);
                    return return_v;
                }


                bool
                f_10226_12268_12327(Microsoft.CodeAnalysis.CSharp.Symbol
                methodSymbol)
                {
                    var return_v = ((MethodSymbol)methodSymbol).IsIndexedPropertyAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 12268, 12327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_12377_12487(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 12377, 12487);
                    return return_v;
                }


                bool
                f_10226_12590_12631(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.MustCallMethodsDirectly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 12590, 12631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_12689_12790(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 12689, 12790);
                    return return_v;
                }


                bool
                f_10226_12872_12908(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.HasParamsParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 12872, 12908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_13140_13242(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 13140, 13242);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10226_11425_11483_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 11425, 11483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_13653_13743(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 13653, 13743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10226_14030_14063(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 14030, 14063);
                    return return_v;
                }


                bool
                f_10226_13980_14110(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt)
                {
                    var return_v = AccessCheck.IsSymbolAccessible(symbol, within, ref useSiteDiagnostics, throughTypeOpt: throughTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 13980, 14110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_14152_14227(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 14152, 14227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10226_14318_14340(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 14318, 14340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10226_14571_14595(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 14571, 14595);
                    return return_v;
                }

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10226_14668_14692(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 14668, 14692);
                    return return_v;
                }

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10226_14930_14951(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 14930, 14951);
                    return return_v;
                }

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10226_15024_15048(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 15024, 15048);
                    return return_v;
                }

                bool
                f_10226_15649_15700(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 15649, 15700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 7698, 15768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 7698, 15768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void FindExplicitlyImplementedMemberVerification(
                    this Symbol implementingMember,
                    Symbol implementedMember,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 15780, 17136);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 15994, 16087) || true) && ((object)implementedMember == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 15994, 16087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 16065, 16072);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 15994, 16087);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 16103, 16611) || true) && (f_10226_16107_16146(implementingMember) && (DynAbs.Tracing.TraceSender.Expression_True(10226, 16107, 16251) && f_10226_16150_16251(implementingMember, implementedMember)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 16103, 16611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 16421, 16474);

                    var
                    memberLocation = f_10226_16442_16470(implementingMember)[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 16492, 16596);

                    f_10226_16492_16595(diagnostics, ErrorCode.ERR_ImplBadTupleNames, memberLocation, implementingMember, implementedMember);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 16103, 16611);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 17036, 17125);

                f_10226_17036_17124(implementingMember, implementedMember, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 15780, 17136);

                bool
                f_10226_16107_16146(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 16107, 16146);
                    return return_v;
                }


                bool
                f_10226_16150_16251(Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = MemberSignatureComparer.ConsideringTupleNamesCreatesDifference(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 16150, 16251);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10226_16442_16470(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 16442, 16470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_16492_16595(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 16492, 16595);
                    return return_v;
                }


                int
                f_10226_17036_17124(Microsoft.CodeAnalysis.CSharp.Symbol
                implementingMember, Microsoft.CodeAnalysis.CSharp.Symbol
                implementedMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    FindExplicitImplementationCollisions(implementingMember, implementedMember, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 17036, 17124);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 15780, 17136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 15780, 17136);
            }
        }

        private static void FindExplicitImplementationCollisions(Symbol implementingMember, Symbol implementedMember, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10226, 17352, 20859);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 17513, 17606) || true) && ((object)implementedMember == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 17513, 17606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 17584, 17591);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 17513, 17606);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 17622, 17695);

                NamedTypeSymbol
                explicitInterfaceType = f_10226_17662_17694(implementedMember)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 17709, 17785);

                bool
                explicitInterfaceTypeIsDefinition = f_10226_17750_17784(explicitInterfaceType)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 17850, 20848);
                    foreach (Symbol collisionCandidateMember in f_10226_17894_17950_I(f_10226_17894_17950(explicitInterfaceType, f_10226_17927_17949(implementedMember))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 17850, 20848);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 17984, 20833) || true) && (f_10226_17988_18017(collisionCandidateMember) == f_10226_18021_18044(implementingMember) && (DynAbs.Tracing.TraceSender.Expression_True(10226, 17988, 18093) && implementedMember != collisionCandidateMember))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 17984, 20833);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 18343, 20814) || true) && (!explicitInterfaceTypeIsDefinition && (DynAbs.Tracing.TraceSender.Expression_True(10226, 18347, 18485) && f_10226_18385_18485(MemberSignatureComparer.RuntimeSignatureComparer, implementedMember, collisionCandidateMember)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 18343, 20814);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 18535, 18571);

                                bool
                                foundMismatchedRefKind = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 18597, 18693);

                                ImmutableArray<ParameterSymbol>
                                implementedMemberParameters = f_10226_18659_18692(implementedMember)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 18719, 18823);

                                ImmutableArray<ParameterSymbol>
                                collisionCandidateParameters = f_10226_18782_18822(collisionCandidateMember)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 18849, 18900);

                                int
                                numParams = implementedMemberParameters.Length
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 18935, 18940);
                                    for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 18926, 19297) || true) && (i < numParams)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 18957, 18960)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 18926, 19297))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 18926, 19297);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 19018, 19270) || true) && (f_10226_19022_19060(implementedMemberParameters[i]) != f_10226_19064_19103(collisionCandidateParameters[i]))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 19018, 19270);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 19169, 19199);

                                            foundMismatchedRefKind = true;
                                            DynAbs.Tracing.TraceSender.TraceBreak(10226, 19233, 19239);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 19018, 19270);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10226, 1, 372);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10226, 1, 372);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 19325, 19909) || true) && (foundMismatchedRefKind)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 19325, 19909);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 19409, 19548);

                                    f_10226_19409_19547(diagnostics, ErrorCode.ERR_ExplicitImplCollisionOnRefOut, f_10226_19470_19501(explicitInterfaceType)[0], explicitInterfaceType, implementedMember);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 19325, 19909);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 19325, 19909);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 19776, 19882);

                                    f_10226_19776_19881(                            //UNDONE: related locations for conflicting members - keep iterating to find others?
                                                                diagnostics, ErrorCode.WRN_ExplicitImplCollision, f_10226_19829_19857(implementingMember)[0], implementingMember);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 19325, 19909);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10226, 19935, 19941);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 18343, 20814);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 18343, 20814);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 20039, 20791) || true) && (f_10226_20043_20149(MemberSignatureComparer.ExplicitImplementationComparer, implementedMember, collisionCandidateMember))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10226, 20039, 20791);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10226, 20658, 20764);

                                    f_10226_20658_20763(                            // NOTE: this is different from the same error code above.  Above, the diagnostic means that
                                                                                    // the runtime behavior is ambiguous because the runtime cannot distinguish between two or
                                                                                    // more interface members.  This diagnostic means that *C#* cannot distinguish between two
                                                                                    // or more interface members (because of custom modifiers).
                                                                diagnostics, ErrorCode.WRN_ExplicitImplCollision, f_10226_20711_20739(implementingMember)[0], implementingMember);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 20039, 20791);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 18343, 20814);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 17984, 20833);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10226, 17850, 20848);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10226, 1, 2999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10226, 1, 2999);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10226, 17352, 20859);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10226_17662_17694(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 17662, 17694);
                    return return_v;
                }


                bool
                f_10226_17750_17784(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 17750, 17784);
                    return return_v;
                }


                string
                f_10226_17927_17949(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 17927, 17949);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10226_17894_17950(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 17894, 17950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10226_17988_18017(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 17988, 18017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10226_18021_18044(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 18021, 18044);
                    return return_v;
                }


                bool
                f_10226_18385_18485(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 18385, 18485);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10226_18659_18692(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 18659, 18692);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10226_18782_18822(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 18782, 18822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10226_19022_19060(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 19022, 19060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10226_19064_19103(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 19064, 19103);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10226_19470_19501(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 19470, 19501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_19409_19547(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 19409, 19547);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10226_19829_19857(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 19829, 19857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_19776_19881(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 19776, 19881);
                    return return_v;
                }


                bool
                f_10226_20043_20149(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 20043, 20149);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10226_20711_20739(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10226, 20711, 20739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10226_20658_20763(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 20658, 20763);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10226_17894_17950_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10226, 17894, 17950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10226, 17352, 20859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 17352, 20859);
            }
        }

        static ExplicitInterfaceHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10226, 646, 20866);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10226, 646, 20866);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10226, 646, 20866);
        }

    }
}
