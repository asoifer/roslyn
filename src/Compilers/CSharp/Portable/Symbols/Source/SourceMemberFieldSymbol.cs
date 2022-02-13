// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceMemberFieldSymbol : SourceFieldSymbolWithSyntaxReference
    {
        private readonly DeclarationModifiers _modifiers;

        internal SourceMemberFieldSymbol(
                    SourceMemberContainerTypeSymbol containingType,
                    DeclarationModifiers modifiers,
                    string name,
                    SyntaxReference syntax,
                    Location location)
        : base(f_10258_1039_1053_C(containingType), name, syntax, location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10258, 784, 1137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 761, 771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 1103, 1126);

                _modifiers = modifiers;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10258, 784, 1137);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 784, 1137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 784, 1137);
            }
        }

        protected sealed override DeclarationModifiers Modifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 1230, 1299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 1266, 1284);

                    return _modifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 1230, 1299);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 1149, 1310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 1149, 1310);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract TypeSyntax TypeSyntax { get; }

        protected abstract SyntaxTokenList ModifiersTokenList { get; }

        protected void TypeChecks(TypeSymbol type, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 1457, 3750);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 1551, 3299) || true) && (f_10258_1555_1568(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 1551, 3299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 1669, 1747);

                    f_10258_1669_1746(                // Cannot declare a variable of static type '{0}'
                                    diagnostics, ErrorCode.ERR_VarDeclIsStaticClass, f_10258_1721_1739(this), type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 1551, 3299);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 1551, 3299);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 1781, 3299) || true) && (f_10258_1785_1802(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 1781, 3299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 1836, 1932);

                        f_10258_1836_1931(diagnostics, ErrorCode.ERR_FieldCantHaveVoidType, f_10258_1889_1909_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10258_1889_1899(), 10258, 1889, 1909)?.Location) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10258, 1889, 1930) ?? f_10258_1913_1927(this)[0]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 1781, 3299);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 1781, 3299);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 1966, 3299) || true) && (f_10258_1970_2018(type, ignoreSpanLikeTypes: true))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 1966, 3299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 2052, 2150);

                            f_10258_2052_2149(diagnostics, ErrorCode.ERR_FieldCantBeRefAny, f_10258_2101_2121_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10258_2101_2111(), 10258, 2101, 2121)?.Location) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10258, 2101, 2142) ?? f_10258_2125_2139(this)[0]), type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 1966, 3299);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 1966, 3299);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 2184, 3299) || true) && (f_10258_2188_2206(type) && (DynAbs.Tracing.TraceSender.Expression_True(10258, 2188, 2258) && (f_10258_2211_2224(this) || (DynAbs.Tracing.TraceSender.Expression_False(10258, 2211, 2257) || f_10258_2228_2257_M(!containingType.IsRefLikeType)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 2184, 3299);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 2292, 2401);

                                f_10258_2292_2400(diagnostics, ErrorCode.ERR_FieldAutoPropCantBeByRefLike, f_10258_2352_2372_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10258_2352_2362(), 10258, 2352, 2372)?.Location) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10258, 2352, 2393) ?? f_10258_2376_2390(this)[0]), type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 2184, 3299);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 2184, 3299);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 2435, 3299) || true) && (f_10258_2439_2446() && (DynAbs.Tracing.TraceSender.Expression_True(10258, 2439, 2468) && !f_10258_2451_2468(type)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 2435, 3299);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 2502, 2548);

                                    SyntaxToken
                                    constToken = default(SyntaxToken)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 2566, 2843);
                                        foreach (var modifier in f_10258_2591_2609_I(f_10258_2591_2609()))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 2566, 2843);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 2651, 2824) || true) && (modifier.Kind() == SyntaxKind.ConstKeyword)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 2651, 2824);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 2747, 2769);

                                                constToken = modifier;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10258, 2795, 2801);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 2651, 2824);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 2566, 2843);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10258, 1, 278);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10258, 1, 278);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 2861, 2920);

                                    f_10258_2861_2919(constToken.Kind() == SyntaxKind.ConstKeyword);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 2940, 3016);

                                    f_10258_2940_3015(
                                                    diagnostics, ErrorCode.ERR_BadConstType, constToken.GetLocation(), type);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 2435, 3299);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 2435, 3299);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 3050, 3299) || true) && (f_10258_3054_3064() && (DynAbs.Tracing.TraceSender.Expression_True(10258, 3054, 3100) && !f_10258_3069_3100(type)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 3050, 3299);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 3206, 3284);

                                        f_10258_3206_3283(                // '{0}': a volatile field cannot be of the type '{1}'
                                                        diagnostics, ErrorCode.ERR_VolatileStruct, f_10258_3252_3270(this), this, type);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 3050, 3299);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 2435, 3299);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 2184, 3299);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 1966, 3299);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 1781, 3299);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 1551, 3299);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 3315, 3365);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 3379, 3667) || true) && (!f_10258_3384_3438(this, type, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 3379, 3667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 3573, 3652);

                    f_10258_3573_3651(                // Inconsistent accessibility: field type '{1}' is less accessible than field '{0}'
                                    diagnostics, ErrorCode.ERR_BadVisFieldType, f_10258_3620_3638(this), this, type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 3379, 3667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 3683, 3739);

                f_10258_3683_3738(
                            diagnostics, f_10258_3699_3717(this), useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 1457, 3750);

                bool
                f_10258_1555_1568(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 1555, 1568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_1721_1739(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 1721, 1739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_1669_1746(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 1669, 1746);
                    return return_v;
                }


                bool
                f_10258_1785_1802(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 1785, 1802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10258_1889_1899()
                {
                    var return_v = TypeSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 1889, 1899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location?
                f_10258_1889_1909_M(Microsoft.CodeAnalysis.Location?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 1889, 1909);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10258_1913_1927(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 1913, 1927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_1836_1931(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 1836, 1931);
                    return return_v;
                }


                bool
                f_10258_1970_2018(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                ignoreSpanLikeTypes)
                {
                    var return_v = type.IsRestrictedType(ignoreSpanLikeTypes: ignoreSpanLikeTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 1970, 2018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10258_2101_2111()
                {
                    var return_v = TypeSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2101, 2111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location?
                f_10258_2101_2121_M(Microsoft.CodeAnalysis.Location?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2101, 2121);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10258_2125_2139(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2125, 2139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_2052_2149(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 2052, 2149);
                    return return_v;
                }


                bool
                f_10258_2188_2206(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2188, 2206);
                    return return_v;
                }


                bool
                f_10258_2211_2224(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2211, 2224);
                    return return_v;
                }


                bool
                f_10258_2228_2257_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2228, 2257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10258_2352_2362()
                {
                    var return_v = TypeSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2352, 2362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location?
                f_10258_2352_2372_M(Microsoft.CodeAnalysis.Location?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2352, 2372);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10258_2376_2390(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2376, 2390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_2292_2400(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 2292, 2400);
                    return return_v;
                }


                bool
                f_10258_2439_2446()
                {
                    var return_v = IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2439, 2446);
                    return return_v;
                }


                bool
                f_10258_2451_2468(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.CanBeConst();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 2451, 2468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10258_2591_2609()
                {
                    var return_v = ModifiersTokenList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 2591, 2609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10258_2591_2609_I(Microsoft.CodeAnalysis.SyntaxTokenList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 2591, 2609);
                    return return_v;
                }


                int
                f_10258_2861_2919(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 2861, 2919);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_2940_3015(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 2940, 3015);
                    return return_v;
                }


                bool
                f_10258_3054_3064()
                {
                    var return_v = IsVolatile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 3054, 3064);
                    return return_v;
                }


                bool
                f_10258_3069_3100(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsValidVolatileFieldType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 3069, 3100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_3252_3270(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 3252, 3270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_3206_3283(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 3206, 3283);
                    return return_v;
                }


                bool
                f_10258_3384_3438(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = symbol.IsNoMoreVisibleThan(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 3384, 3438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_3620_3638(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 3620, 3638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_3573_3651(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 3573, 3651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_3699_3717(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 3699, 3717);
                    return return_v;
                }


                bool
                f_10258_3683_3738(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(location, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 3683, 3738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 1457, 3750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 1457, 3750);
            }
        }

        public abstract bool HasInitializer { get; }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 3818, 4799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 3976, 4037);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10258, 3976, 4036);

                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 3976, 4036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 4053, 4097);

                var
                compilation = f_10258_4071_4096(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 4111, 4218);

                var
                value = f_10258_4123_4217(this, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 4328, 4788) || true) && (f_10258_4332_4344(this) && (DynAbs.Tracing.TraceSender.Expression_True(10258, 4332, 4361) && value != null
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10258, 4332, 4433) && f_10258_4382_4403(f_10258_4382_4391(this)) == SpecialType.System_Decimal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 4328, 4788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 4467, 4513);

                    var
                    data = f_10258_4478_4512(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 4533, 4773) || true) && (data == null || (DynAbs.Tracing.TraceSender.Expression_False(10258, 4537, 4604) || f_10258_4553_4568(data) == f_10258_4572_4604()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 4533, 4773);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 4646, 4754);

                        f_10258_4646_4753(ref attributes, f_10258_4686_4752(compilation, f_10258_4733_4751(value)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 4533, 4773);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 4328, 4788);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 3818, 4799);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10258_4071_4096(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 4071, 4096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10258_4123_4217(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 4123, 4217);
                    return return_v;
                }


                bool
                f_10258_4332_4344(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 4332, 4344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10258_4382_4391(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 4382, 4391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10258_4382_4403(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 4382, 4403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                f_10258_4478_4512(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.GetDecodedWellKnownAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 4478, 4512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10258_4553_4568(Microsoft.CodeAnalysis.CSharp.Symbols.FieldWellKnownAttributeData
                this_param)
                {
                    var return_v = this_param.ConstValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 4553, 4568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10258_4572_4604()
                {
                    var return_v = CodeAnalysis.ConstantValue.Unset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 4572, 4604);
                    return return_v;
                }


                decimal
                f_10258_4733_4751(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DecimalValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 4733, 4751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10258_4686_4752(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, decimal
                value)
                {
                    var return_v = this_param.SynthesizeDecimalConstantAttribute(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 4686, 4752);
                    return return_v;
                }


                int
                f_10258_4646_4753(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 4646, 4753);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 3818, 4799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 3818, 4799);
            }
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 4875, 4938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 4911, 4923);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 4875, 4938);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 4811, 4949);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 4811, 4949);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int FixedSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 5015, 5252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 5051, 5143);

                    f_10258_5051_5142(f_10258_5064_5087_M(!this.IsFixedSizeBuffer), "Subclasses representing fixed fields must override");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 5161, 5210);

                    state.NotePartComplete(CompletionPart.FixedSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 5228, 5237);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 5015, 5252);

                    bool
                    f_10258_5064_5087_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 5064, 5087);
                        return return_v;
                    }


                    int
                    f_10258_5051_5142(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 5051, 5142);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 4961, 5263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 4961, 5263);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static DeclarationModifiers MakeModifiers(NamedTypeSymbol containingType, SyntaxToken firstIdentifier, SyntaxTokenList modifiers, DiagnosticBag diagnostics, out bool modifierErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10258, 5275, 10355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 5490, 5634);

                DeclarationModifiers
                defaultAccess =
                (DynAbs.Tracing.TraceSender.Conditional_F1(10258, 5544, 5572) || (((f_10258_5545_5571(containingType)) && DynAbs.Tracing.TraceSender.Conditional_F2(10258, 5575, 5602)) || DynAbs.Tracing.TraceSender.Conditional_F3(10258, 5605, 5633))) ? DeclarationModifiers.Public : DeclarationModifiers.Private
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 5650, 6123);

                DeclarationModifiers
                allowedModifiers =
                                DeclarationModifiers.AccessibilityMask |
                                DeclarationModifiers.Const |
                                DeclarationModifiers.New |
                                DeclarationModifiers.ReadOnly |
                                DeclarationModifiers.Static |
                                DeclarationModifiers.Volatile |
                                DeclarationModifiers.Fixed |
                                DeclarationModifiers.Unsafe |
                                DeclarationModifiers.Abstract
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 6161, 6217);

                var
                errorLocation = f_10258_6181_6216(firstIdentifier)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 6231, 6420);

                DeclarationModifiers
                result = f_10258_6261_6419(modifiers, defaultAccess, allowedModifiers, errorLocation, diagnostics, out modifierErrors)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 6436, 6653) || true) && ((result & DeclarationModifiers.Abstract) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 6436, 6653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 6519, 6579);

                    f_10258_6519_6578(diagnostics, ErrorCode.ERR_AbstractField, errorLocation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 6597, 6638);

                    result &= ~DeclarationModifiers.Abstract;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 6436, 6653);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 6669, 8315) || true) && ((result & DeclarationModifiers.Fixed) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 6669, 8315);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 6749, 7037) || true) && ((result & DeclarationModifiers.Static) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 6749, 7037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 6911, 7018);

                        f_10258_6911_7017(                    // The modifier 'static' is not valid for this item
                                            diagnostics, ErrorCode.ERR_BadMemberFlag, errorLocation, f_10258_6971_7016(SyntaxKind.StaticKeyword));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 6749, 7037);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 7057, 7351) || true) && ((result & DeclarationModifiers.ReadOnly) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 7057, 7351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 7223, 7332);

                        f_10258_7223_7331(                    // The modifier 'readonly' is not valid for this item
                                            diagnostics, ErrorCode.ERR_BadMemberFlag, errorLocation, f_10258_7283_7330(SyntaxKind.ReadOnlyKeyword));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 7057, 7351);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 7371, 7656) || true) && ((result & DeclarationModifiers.Const) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 7371, 7656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 7531, 7637);

                        f_10258_7531_7636(                    // The modifier 'const' is not valid for this item
                                            diagnostics, ErrorCode.ERR_BadMemberFlag, errorLocation, f_10258_7591_7635(SyntaxKind.ConstKeyword));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 7371, 7656);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 7676, 7970) || true) && ((result & DeclarationModifiers.Volatile) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 7676, 7970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 7842, 7951);

                        f_10258_7842_7950(                    // The modifier 'volatile' is not valid for this item
                                            diagnostics, ErrorCode.ERR_BadMemberFlag, errorLocation, f_10258_7902_7949(SyntaxKind.VolatileKeyword));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 7676, 7970);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 7990, 8124);

                    result &= ~(DeclarationModifiers.Static | DeclarationModifiers.ReadOnly | DeclarationModifiers.Const | DeclarationModifiers.Volatile);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 8142, 8300);

                    f_10258_8142_8299((result & ~(DeclarationModifiers.AccessibilityMask | DeclarationModifiers.Fixed | DeclarationModifiers.Unsafe | DeclarationModifiers.New)) == 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 6669, 8315);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 8331, 10314) || true) && ((result & DeclarationModifiers.Const) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 8331, 10314);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 8411, 8674) || true) && ((result & DeclarationModifiers.Static) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 8411, 8674);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 8567, 8655);

                        f_10258_8567_8654(                    // The constant '{0}' cannot be marked static
                                            diagnostics, ErrorCode.ERR_StaticConstant, errorLocation, firstIdentifier.ValueText);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 8411, 8674);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 8694, 8988) || true) && ((result & DeclarationModifiers.ReadOnly) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 8694, 8988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 8860, 8969);

                        f_10258_8860_8968(                    // The modifier 'readonly' is not valid for this item
                                            diagnostics, ErrorCode.ERR_BadMemberFlag, errorLocation, f_10258_8920_8967(SyntaxKind.ReadOnlyKeyword));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 8694, 8988);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 9008, 9302) || true) && ((result & DeclarationModifiers.Volatile) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 9008, 9302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 9174, 9283);

                        f_10258_9174_9282(                    // The modifier 'volatile' is not valid for this item
                                            diagnostics, ErrorCode.ERR_BadMemberFlag, errorLocation, f_10258_9234_9281(SyntaxKind.VolatileKeyword));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 9008, 9302);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 9322, 9610) || true) && ((result & DeclarationModifiers.Unsafe) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 9322, 9610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 9484, 9591);

                        f_10258_9484_9590(                    // The modifier 'unsafe' is not valid for this item
                                            diagnostics, ErrorCode.ERR_BadMemberFlag, errorLocation, f_10258_9544_9589(SyntaxKind.UnsafeKeyword));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 9322, 9610);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 9630, 9668);

                    result |= DeclarationModifiers.Static;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 8331, 10314);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 8331, 10314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 10228, 10299);

                    f_10258_10228_10298(                // NOTE: always cascading on a const, so suppress.
                                                        // NOTE: we're being a bit sneaky here - we're using the containingType rather than this symbol
                                                        // to determine whether or not unsafe is allowed.  Since this symbol and the containing type are
                                                        // in the same compilation, it won't make a difference.  We do, however, have to pass the error
                                                        // location explicitly.
                                    containingType, result, errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 8331, 10314);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 10330, 10344);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10258, 5275, 10355);

                bool
                f_10258_5545_5571(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 5545, 5571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10258_6181_6216(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 6181, 6216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10258_6261_6419(Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultAccess, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                allowedModifiers, Microsoft.CodeAnalysis.SourceLocation
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                modifierErrors)
                {
                    var return_v = ModifierUtils.MakeAndCheckNontypeMemberModifiers(modifiers, defaultAccess, allowedModifiers, (Microsoft.CodeAnalysis.Location)errorLocation, diagnostics, out modifierErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 6261, 6419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_6519_6578(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 6519, 6578);
                    return return_v;
                }


                string
                f_10258_6971_7016(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 6971, 7016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_6911_7017(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 6911, 7017);
                    return return_v;
                }


                string
                f_10258_7283_7330(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 7283, 7330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_7223_7331(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 7223, 7331);
                    return return_v;
                }


                string
                f_10258_7591_7635(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 7591, 7635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_7531_7636(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 7531, 7636);
                    return return_v;
                }


                string
                f_10258_7902_7949(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 7902, 7949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_7842_7950(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 7842, 7950);
                    return return_v;
                }


                int
                f_10258_8142_8299(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 8142, 8299);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_8567_8654(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 8567, 8654);
                    return return_v;
                }


                string
                f_10258_8920_8967(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 8920, 8967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_8860_8968(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 8860, 8968);
                    return return_v;
                }


                string
                f_10258_9234_9281(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 9234, 9281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_9174_9282(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 9174, 9282);
                    return return_v;
                }


                string
                f_10258_9544_9589(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 9544, 9589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_9484_9590(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 9484, 9590);
                    return return_v;
                }


                int
                f_10258_10228_10298(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.SourceLocation
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    symbol.CheckUnsafeModifier(modifiers, (Microsoft.CodeAnalysis.Location)errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 10228, 10298);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 5275, 10355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 5275, 10355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 10367, 11816);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 10500, 11805) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 10500, 11805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 10545, 10594);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 10612, 10658);

                        var
                        incompletePart = state.NextIncompletePart
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 10676, 11712);

                        switch (incompletePart)
                        {

                            case CompletionPart.Attributes:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 10676, 11712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 10797, 10813);

                                f_10258_10797_10812(this);
                                DynAbs.Tracing.TraceSender.TraceBreak(10258, 10839, 10845);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 10676, 11712);

                            case CompletionPart.Type:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 10676, 11712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 10920, 10962);

                                f_10258_10920_10961(this, ConsList<FieldSymbol>.Empty);
                                DynAbs.Tracing.TraceSender.TraceBreak(10258, 10988, 10994);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 10676, 11712);

                            case CompletionPart.FixedSize:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 10676, 11712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 11074, 11105);

                                int
                                discarded = f_10258_11090_11104(this)
                                ;
                                DynAbs.Tracing.TraceSender.TraceBreak(10258, 11131, 11137);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 10676, 11712);

                            case CompletionPart.ConstantValue:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 10676, 11712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 11221, 11311);

                                f_10258_11221_11310(this, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false);
                                DynAbs.Tracing.TraceSender.TraceBreak(10258, 11337, 11343);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 10676, 11712);

                            case CompletionPart.None:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 10676, 11712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 11418, 11425);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 10676, 11712);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 10676, 11712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 11585, 11661);

                                state.NotePartComplete(CompletionPart.All & ~CompletionPart.FieldSymbolAll);
                                DynAbs.Tracing.TraceSender.TraceBreak(10258, 11687, 11693);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 10676, 11712);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 11732, 11790);

                        state.SpinWaitComplete(incompletePart, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 10500, 11805);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10258, 10500, 11805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10258, 10500, 11805);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 10367, 11816);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10258_10797_10812(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 10797, 10812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10258_10920_10961(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fieldsBeingBound)
                {
                    var return_v = this_param.GetFieldType(fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 10920, 10961);
                    return return_v;
                }


                int
                f_10258_11090_11104(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param)
                {
                    var return_v = this_param.FixedSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 11090, 11104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10258_11221_11310(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                inProgress, bool
                earlyDecodingWellKnownAttributes)
                {
                    var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 11221, 11310);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 10367, 11816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 10367, 11816);
            }
        }

        internal override NamedTypeSymbol FixedImplementationType(PEModuleBuilder emitModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 11828, 12067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 11938, 12030);

                f_10258_11938_12029(f_10258_11951_11974_M(!this.IsFixedSizeBuffer), "Subclasses representing fixed fields must override");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 12044, 12056);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 11828, 12067);

                bool
                f_10258_11951_11974_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 11951, 11974);
                    return return_v;
                }


                int
                f_10258_11938_12029(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 11938, 12029);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 11828, 12067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 11828, 12067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceMemberFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10258, 620, 12074);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10258, 620, 12074);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 620, 12074);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10258, 620, 12074);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10258_1039_1053_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10258, 784, 1137);
            return return_v;
        }

    }
    internal class SourceMemberFieldSymbolFromDeclarator : SourceMemberFieldSymbol
    {
        private readonly bool _hasInitializer;

        private TypeWithAnnotations.Boxed _lazyType;

        private int _lazyFieldTypeInferred;

        internal SourceMemberFieldSymbolFromDeclarator(
                    SourceMemberContainerTypeSymbol containingType,
                    VariableDeclaratorSyntax declarator,
                    DeclarationModifiers modifiers,
                    bool modifierErrors,
                    DiagnosticBag diagnostics)
        : base(f_10258_12850_12864_C(containingType), modifiers, declarator.Identifier.ValueText, f_10258_12910_12935(declarator), declarator.Identifier.GetLocation())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10258, 12552, 13951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 12199, 12214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 12261, 12270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 12517, 12539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 12998, 13047);

                _hasInitializer = f_10258_13016_13038(declarator) != null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 13063, 13100);

                f_10258_13063_13099(
                            this, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 13116, 13229) || true) && (!modifierErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 13116, 13229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 13169, 13214);

                    f_10258_13169_13213(this, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 13116, 13229);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 13245, 13940) || true) && (f_10258_13249_13275(containingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 13245, 13940);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 13309, 13925) || true) && (f_10258_13313_13326(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 13309, 13925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 13368, 13486);

                        f_10258_13368_13485(declarator, MessageID.IDS_DefaultInterfaceImplementation, diagnostics, f_10258_13471_13484());

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 13510, 13750) || true) && (f_10258_13514_13579_M(!f_10258_13515_13533().RuntimeSupportsDefaultInterfaceImplementation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 13510, 13750);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 13629, 13727);

                            f_10258_13629_13726(diagnostics, ErrorCode.ERR_RuntimeDoesNotSupportDefaultInterfaceImplementation, f_10258_13712_13725());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 13510, 13750);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 13309, 13925);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 13309, 13925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 13832, 13906);

                        f_10258_13832_13905(diagnostics, ErrorCode.ERR_InterfacesCantContainFields, f_10258_13891_13904());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 13309, 13925);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 13245, 13940);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10258, 12552, 13951);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 12552, 13951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 12552, 13951);
            }
        }

        protected sealed override TypeSyntax TypeSyntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 14035, 14154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 14071, 14139);

                    return f_10258_14078_14138(f_10258_14078_14133(f_10258_14078_14121(f_10258_14098_14120())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 14035, 14154);

                    Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                    f_10258_14098_14120()
                    {
                        var return_v = VariableDeclaratorNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 14098, 14120);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                    f_10258_14078_14121(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                    declarator)
                    {
                        var return_v = GetFieldDeclaration((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarator);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 14078, 14121);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                    f_10258_14078_14133(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Declaration;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 14078, 14133);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                    f_10258_14078_14138(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 14078, 14138);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 13963, 14165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 13963, 14165);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override SyntaxTokenList ModifiersTokenList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 14262, 14374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 14298, 14359);

                    return f_10258_14305_14358(f_10258_14305_14348(f_10258_14325_14347()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 14262, 14374);

                    Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                    f_10258_14325_14347()
                    {
                        var return_v = VariableDeclaratorNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 14325, 14347);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                    f_10258_14305_14348(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                    declarator)
                    {
                        var return_v = GetFieldDeclaration((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarator);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 14305, 14348);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList
                    f_10258_14305_14358(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.Modifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 14305, 14358);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 14177, 14385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 14177, 14385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool HasInitializer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 14464, 14495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 14470, 14493);

                    return _hasInitializer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 14464, 14495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 14397, 14506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 14397, 14506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected VariableDeclaratorSyntax VariableDeclaratorNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 14600, 14700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 14636, 14685);

                    return (VariableDeclaratorSyntax)f_10258_14669_14684(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 14600, 14700);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10258_14669_14684(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                    this_param)
                    {
                        var return_v = this_param.SyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 14669, 14684);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 14518, 14711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 14518, 14711);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static BaseFieldDeclarationSyntax GetFieldDeclaration(CSharpSyntaxNode declarator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10258, 14723, 14909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 14838, 14898);

                return (BaseFieldDeclarationSyntax)f_10258_14873_14897(f_10258_14873_14890(declarator));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10258, 14723, 14909);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10258_14873_14890(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 14873, 14890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10258_14873_14897(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 14873, 14897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 14723, 14909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 14723, 14909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SyntaxList<AttributeListSyntax> AttributeDeclarationSyntaxList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 15027, 15312);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15063, 15229) || true) && (f_10258_15067_15109(this.containingType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 15063, 15229);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15151, 15210);

                        return f_10258_15158_15209(f_10258_15158_15194(f_10258_15178_15193(this)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 15063, 15229);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15249, 15297);

                    return default(SyntaxList<AttributeListSyntax>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 15027, 15312);

                    bool
                    f_10258_15067_15109(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.AnyMemberHasAttributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 15067, 15109);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10258_15178_15193(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                    this_param)
                    {
                        var return_v = this_param.SyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 15178, 15193);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                    f_10258_15158_15194(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    declarator)
                    {
                        var return_v = GetFieldDeclaration(declarator);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 15158, 15194);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    f_10258_15158_15209(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.AttributeLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 15158, 15209);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 14921, 15323);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 14921, 15323);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPointerType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 15397, 15978);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15433, 15906) || true) && (_lazyType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 15433, 15906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15496, 15761);

                        bool
                        isPointerType = f_10258_15517_15549(_lazyType.Value.DefaultType) switch
                        {
                            SymbolKind.PointerType when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15605, 15635) && DynAbs.Tracing.TraceSender.Expression_True(10258, 15605, 15635))
=> true,
                            SymbolKind.FunctionPointerType when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15662, 15700) && DynAbs.Tracing.TraceSender.Expression_True(10258, 15662, 15700))
=> true,
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15727, 15737) && DynAbs.Tracing.TraceSender.Expression_True(10258, 15727, 15737))
=> false
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15783, 15844);

                        f_10258_15783_15843(isPointerType == f_10258_15813_15842(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15866, 15887);

                        return isPointerType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 15433, 15906);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 15926, 15963);

                    return f_10258_15933_15962(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 15397, 15978);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10258_15517_15549(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 15517, 15549);
                        return return_v;
                    }


                    bool
                    f_10258_15813_15842(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                    this_param)
                    {
                        var return_v = this_param.IsPointerFieldSyntactically();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 15813, 15842);
                        return return_v;
                    }


                    int
                    f_10258_15783_15843(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 15783, 15843);
                        return 0;
                    }


                    bool
                    f_10258_15933_15962(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                    this_param)
                    {
                        var return_v = this_param.IsPointerFieldSyntactically();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 15933, 15962);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 15335, 15989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 15335, 15989);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsPointerFieldSyntactically()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 16001, 16796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16068, 16142);

                var
                declaration = f_10258_16086_16141(f_10258_16086_16129(f_10258_16106_16128()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16156, 16390) || true) && (f_10258_16160_16183(f_10258_16160_16176(declaration)) switch
                {
                    SyntaxKind.PointerType when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16193, 16223) && DynAbs.Tracing.TraceSender.Expression_True(10258, 16193, 16223))
=> true,
                    SyntaxKind.FunctionPointerType when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16225, 16263) && DynAbs.Tracing.TraceSender.Expression_True(10258, 16225, 16263))
           => true,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16265, 16275) && DynAbs.Tracing.TraceSender.Expression_True(10258, 16265, 16275))
           => false
                })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 16156, 16390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16363, 16375);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 16156, 16390);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16406, 16756);
                    foreach (var singleVariable in f_10258_16437_16458_I(f_10258_16437_16458(declaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 16406, 16756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16492, 16534);

                        var
                        argList = f_10258_16506_16533(singleVariable)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16552, 16741) || true) && (argList != null && (DynAbs.Tracing.TraceSender.Expression_True(10258, 16556, 16603) && argList.Arguments.Count != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 16552, 16741);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16710, 16722);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 16552, 16741);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 16406, 16756);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10258, 1, 351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10258, 1, 351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16772, 16785);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 16001, 16796);

                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                f_10258_16106_16128()
                {
                    var return_v = VariableDeclaratorNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 16106, 16128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                f_10258_16086_16129(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarator)
                {
                    var return_v = GetFieldDeclaration((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 16086, 16129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10258_16086_16141(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 16086, 16141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10258_16160_16176(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 16160, 16176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10258_16160_16183(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 16160, 16183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10258_16437_16458(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 16437, 16458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax?
                f_10258_16506_16533(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 16506, 16533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10258_16437_16458_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 16437, 16458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 16001, 16796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 16001, 16796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 16808, 23806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16930, 16969);

                f_10258_16930_16968(fieldsBeingBound != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 16985, 17078) || true) && (_lazyType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 16985, 17078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17040, 17063);

                    return _lazyType.Value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 16985, 17078);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17094, 17134);

                var
                declarator = f_10258_17111_17133()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17148, 17198);

                var
                fieldSyntax = f_10258_17166_17197(declarator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17212, 17258);

                var
                typeSyntax = f_10258_17229_17257(f_10258_17229_17252(fieldSyntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17274, 17318);

                var
                compilation = f_10258_17292_17317(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17334, 17380);

                var
                diagnostics = f_10258_17352_17379()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17394, 17419);

                TypeWithAnnotations
                type
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17536, 17610);

                DiagnosticBag
                diagnosticsForFirstDeclarator = f_10258_17582_17609()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17626, 17683);

                Symbol
                associatedPropertyOrEvent = f_10258_17661_17682(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17697, 22829) || true) && ((object)associatedPropertyOrEvent != null && (DynAbs.Tracing.TraceSender.Expression_True(10258, 17701, 17796) && f_10258_17746_17776(associatedPropertyOrEvent) == SymbolKind.Event))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 17697, 22829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17830, 17890);

                    EventSymbol
                    @event = (EventSymbol)associatedPropertyOrEvent
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17908, 18754) || true) && (f_10258_17912_17940(@event))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 17908, 18754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 17982, 18149);

                        NamedTypeSymbol
                        tokenTableType = f_10258_18015_18148(f_10258_18015_18040(this), WellKnownType.System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 18171, 18270);

                        f_10258_18171_18269(tokenTableType, diagnosticsForFirstDeclarator, f_10258_18250_18268(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 18508, 18619);

                        type = TypeWithAnnotations.Create(f_10258_18542_18617(tokenTableType, f_10258_18567_18616(f_10258_18589_18615(@event))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 17908, 18754);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 17908, 18754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 18701, 18735);

                        type = f_10258_18708_18734(@event);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 17908, 18754);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 17697, 22829);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 17697, 22829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 18820, 18881);

                    var
                    binderFactory = f_10258_18840_18880(compilation, f_10258_18869_18879())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 18899, 18948);

                    var
                    binder = f_10258_18912_18947(binderFactory, typeSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 18968, 19075);

                    binder = f_10258_18977_19074(binder, BinderFlags.SuppressConstraintChecks, this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 19093, 21842) || true) && (f_10258_19097_19126_M(!f_10258_19098_19112().IsScriptClass))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 19093, 21842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 19168, 19234);

                        type = f_10258_19175_19233(binder, typeSyntax, diagnosticsForFirstDeclarator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 19093, 21842);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 19093, 21842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 19316, 19327);

                        bool
                        isVar
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 19349, 19420);

                        type = f_10258_19356_19419(binder, typeSyntax, diagnostics, out isVar);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 19444, 19480);

                        f_10258_19444_19479(type.HasType || (DynAbs.Tracing.TraceSender.Expression_False(10258, 19457, 19478) || isVar));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 19504, 21823) || true) && (isVar)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 19504, 21823);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 19563, 19771) || true) && (f_10258_19567_19579(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 19563, 19771);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 19637, 19744);

                                f_10258_19637_19743(diagnosticsForFirstDeclarator, ErrorCode.ERR_ImplicitlyTypedVariableCannotBeConst, f_10258_19723_19742(typeSyntax));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 19563, 19771);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 19799, 21605) || true) && (f_10258_19803_19843(fieldsBeingBound, this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 19799, 21605);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 19901, 19983);

                                f_10258_19901_19982(diagnostics, ErrorCode.ERR_RecursivelyTypedVariable, f_10258_19957_19975(this), this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 20013, 20028);

                                type = default;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 19799, 21605);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 19799, 21605);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 20086, 21605) || true) && (f_10258_20090_20113(fieldSyntax).Variables.Count > 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 20086, 21605);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 20191, 20303);

                                    f_10258_20191_20302(diagnosticsForFirstDeclarator, ErrorCode.ERR_ImplicitlyTypedVariableMultipleDeclarator, f_10258_20282_20301(typeSyntax));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 20086, 21605);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 20086, 21605);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 20361, 21605) || true) && (f_10258_20365_20377(this) && (DynAbs.Tracing.TraceSender.Expression_True(10258, 20365, 20414) && f_10258_20381_20414(f_10258_20381_20400(this))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 20361, 21605);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 20619, 20634);

                                        type = default;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 20361, 21605);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 20361, 21605);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 20748, 20817);

                                        fieldsBeingBound = f_10258_20767_20816(this, fieldsBeingBound);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 20849, 20930);

                                        var
                                        initializerBinder = f_10258_20873_20929(binder, fieldsBeingBound)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 20960, 21119);

                                        var
                                        initializerOpt = f_10258_20981_21118(initializerBinder, diagnostics, RefKind.None, f_10258_21083_21105(declarator), declarator)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 21151, 21578) || true) && (initializerOpt != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 21151, 21578);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 21243, 21484) || true) && ((object)f_10258_21255_21274(initializerOpt) != null && (DynAbs.Tracing.TraceSender.Expression_True(10258, 21247, 21320) && !f_10258_21287_21320(f_10258_21287_21306(initializerOpt))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 21243, 21484);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 21394, 21449);

                                                type = TypeWithAnnotations.Create(f_10258_21428_21447(initializerOpt));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 21243, 21484);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 21520, 21547);

                                            _lazyFieldTypeInferred = 1;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 21151, 21578);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 20361, 21605);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 20086, 21605);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 19799, 21605);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 21633, 21800) || true) && (f_10258_21637_21650_M(!type.HasType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 21633, 21800);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 21708, 21773);

                                type = TypeWithAnnotations.Create(f_10258_21742_21771(binder, "var"));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 21633, 21800);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 19504, 21823);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 19093, 21842);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 21862, 22814) || true) && (f_10258_21866_21883())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 21862, 22814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 21925, 21988);

                        type = TypeWithAnnotations.Create(f_10258_21959_21986(type));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 22012, 22194) || true) && (f_10258_22016_22039(f_10258_22016_22030()) != TypeKind.Struct)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 22012, 22194);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 22108, 22171);

                            f_10258_22108_22170(diagnostics, ErrorCode.ERR_FixedNotInStruct, f_10258_22156_22169());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 22012, 22194);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 22218, 22281);

                        var
                        elementType = f_10258_22236_22280(((PointerTypeSymbol)type.Type))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 22303, 22365);

                        int
                        elementSize = f_10258_22321_22364(elementType)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 22387, 22589) || true) && (elementSize == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 22387, 22589);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 22457, 22487);

                            var
                            loc = f_10258_22467_22486(typeSyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 22513, 22566);

                            f_10258_22513_22565(diagnostics, ErrorCode.ERR_IllegalFixedType, loc);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 22387, 22589);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 22613, 22795) || true) && (f_10258_22617_22639_M(!binder.InUnsafeRegion))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 22613, 22795);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 22689, 22772);

                            f_10258_22689_22771(diagnosticsForFirstDeclarator, ErrorCode.ERR_UnsafeNeeded, f_10258_22751_22770(declarator));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 22613, 22795);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 21862, 22814);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 17697, 22829);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 22940, 23672) || true) && (f_10258_22944_23073(ref _lazyType, f_10258_22987_23066(type.WithModifiers(f_10258_23036_23064(this))), null) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 22940, 23672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23115, 23150);

                    f_10258_23115_23149(this, type.Type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23265, 23322);

                    f_10258_23265_23321(f_10258_23265_23299(compilation), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23342, 23418);

                    bool
                    isFirstDeclarator = f_10258_23367_23400(f_10258_23367_23390(fieldSyntax))[0] == declarator
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23436, 23593) || true) && (isFirstDeclarator)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 23436, 23593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23499, 23574);

                        f_10258_23499_23573(f_10258_23499_23533(compilation), diagnosticsForFirstDeclarator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 23436, 23593);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23613, 23657);

                    state.NotePartComplete(CompletionPart.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 22940, 23672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23688, 23707);

                f_10258_23688_23706(
                            diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23721, 23758);

                f_10258_23721_23757(diagnosticsForFirstDeclarator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23772, 23795);

                return _lazyType.Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 16808, 23806);

                int
                f_10258_16930_16968(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 16930, 16968);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                f_10258_17111_17133()
                {
                    var return_v = VariableDeclaratorNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 17111, 17133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                f_10258_17166_17197(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarator)
                {
                    var return_v = GetFieldDeclaration((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 17166, 17197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10258_17229_17252(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 17229, 17252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10258_17229_17257(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 17229, 17257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10258_17292_17317(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 17292, 17317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10258_17352_17379()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 17352, 17379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10258_17582_17609()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 17582, 17609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10258_17661_17682(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 17661, 17682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10258_17746_17776(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 17746, 17776);
                    return return_v;
                }


                bool
                f_10258_17912_17940(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsWindowsRuntimeEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 17912, 17940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10258_18015_18040(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 18015, 18040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10258_18015_18148(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 18015, 18148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_18250_18268(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 18250, 18268);
                    return return_v;
                }


                bool
                f_10258_18171_18269(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 18171, 18269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10258_18589_18615(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 18589, 18615);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10258_18567_18616(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 18567, 18616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10258_18542_18617(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 18542, 18617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10258_18708_18734(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 18708, 18734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10258_18869_18879()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 18869, 18879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10258_18840_18880(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 18840, 18880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10258_18912_18947(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 18912, 18947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10258_18977_19074(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 18977, 19074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10258_19098_19112()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 19098, 19112);
                    return return_v;
                }


                bool
                f_10258_19097_19126_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 19097, 19126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10258_19175_19233(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 19175, 19233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10258_19356_19419(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isVar)
                {
                    var return_v = this_param.BindTypeOrVarKeyword(syntax, diagnostics, out isVar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 19356, 19419);
                    return return_v;
                }


                int
                f_10258_19444_19479(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 19444, 19479);
                    return 0;
                }


                bool
                f_10258_19567_19579(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 19567, 19579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_19723_19742(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 19723, 19742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_19637_19743(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 19637, 19743);
                    return return_v;
                }


                bool
                f_10258_19803_19843(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 19803, 19843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_19957_19975(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 19957, 19975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_19901_19982(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 19901, 19982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10258_20090_20113(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 20090, 20113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_20282_20301(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 20282, 20301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_20191_20302(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 20191, 20302);
                    return return_v;
                }


                bool
                f_10258_20365_20377(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 20365, 20377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10258_20381_20400(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 20381, 20400);
                    return return_v;
                }


                bool
                f_10258_20381_20414(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 20381, 20414);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10258_20767_20816(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                head, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                tail)
                {
                    var return_v = new Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)head, tail);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 20767, 20816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ImplicitlyTypedFieldBinder
                f_10258_20873_20929(Microsoft.CodeAnalysis.CSharp.Binder
                next, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fieldsBeingBound)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ImplicitlyTypedFieldBinder(next, fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 20873, 20929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10258_21083_21105(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 21083, 21105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10258_20981_21118(Microsoft.CodeAnalysis.CSharp.ImplicitlyTypedFieldBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                initializer, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                errorSyntax)
                {
                    var return_v = this_param.BindInferredVariableInitializer(diagnostics, refKind, initializer, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)errorSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 20981, 21118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10258_21255_21274(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 21255, 21274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10258_21287_21306(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 21287, 21306);
                    return return_v;
                }


                bool
                f_10258_21287_21320(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 21287, 21320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10258_21428_21447(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 21428, 21447);
                    return return_v;
                }


                bool
                f_10258_21637_21650_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 21637, 21650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10258_21742_21771(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 21742, 21771);
                    return return_v;
                }


                bool
                f_10258_21866_21883()
                {
                    var return_v = IsFixedSizeBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 21866, 21883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10258_21959_21986(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 21959, 21986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10258_22016_22030()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 22016, 22030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10258_22016_22039(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 22016, 22039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_22156_22169()
                {
                    var return_v = ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 22156, 22169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_22108_22170(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 22108, 22170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10258_22236_22280(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 22236, 22280);
                    return return_v;
                }


                int
                f_10258_22321_22364(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.FixedBufferElementSizeInBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 22321, 22364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_22467_22486(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 22467, 22486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_22513_22565(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 22513, 22565);
                    return return_v;
                }


                bool
                f_10258_22617_22639_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 22617, 22639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_22751_22770(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 22751, 22770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10258_22689_22771(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 22689, 22771);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10258_23036_23064(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.RequiredCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 23036, 23064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                f_10258_22987_23066(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 22987, 23066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                f_10258_22944_23073(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 22944, 23073);
                    return return_v;
                }


                int
                f_10258_23115_23149(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.TypeChecks(type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 23115, 23149);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10258_23265_23299(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DeclarationDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 23265, 23299);
                    return return_v;
                }


                int
                f_10258_23265_23321(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 23265, 23321);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10258_23367_23390(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 23367, 23390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10258_23367_23400(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 23367, 23400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10258_23499_23533(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DeclarationDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 23499, 23533);
                    return return_v;
                }


                int
                f_10258_23499_23573(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 23499, 23573);
                    return 0;
                }


                int
                f_10258_23688_23706(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 23688, 23706);
                    return 0;
                }


                int
                f_10258_23721_23757(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 23721, 23757);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 16808, 23806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 16808, 23806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool FieldTypeInferred(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 23818, 24250);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23914, 24009) || true) && (f_10258_23918_23947_M(!f_10258_23919_23933().IsScriptClass))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 23914, 24009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 23981, 23994);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 23914, 24009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 24025, 24056);

                f_10258_24025_24055(this, fieldsBeingBound);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 24154, 24239);

                return _lazyFieldTypeInferred != 0 || (DynAbs.Tracing.TraceSender.Expression_False(10258, 24161, 24238) || f_10258_24192_24233(ref _lazyFieldTypeInferred) != 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 23818, 24250);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10258_23919_23933()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 23919, 23933);
                    return return_v;
                }


                bool
                f_10258_23918_23947_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 23918, 23947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10258_24025_24055(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fieldsBeingBound)
                {
                    var return_v = this_param.GetFieldType(fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 24025, 24055);
                    return return_v;
                }


                int
                f_10258_24192_24233(ref int
                location)
                {
                    var return_v = Volatile.Read(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 24192, 24233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 23818, 24250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 23818, 24250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override ConstantValue MakeConstantValue(HashSet<SourceFieldSymbolWithSyntaxReference> dependencies, bool earlyDecodingWellKnownAttributes, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 24262, 24797);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 24470, 24594) || true) && (f_10258_24474_24487_M(!this.IsConst) || (DynAbs.Tracing.TraceSender.Expression_False(10258, 24474, 24533) || f_10258_24491_24525(f_10258_24491_24513()) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 24470, 24594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 24567, 24579);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 24470, 24594);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 24610, 24786);

                return f_10258_24617_24785(this, f_10258_24689_24723(f_10258_24689_24711()), dependencies, earlyDecodingWellKnownAttributes, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 24262, 24797);

                bool
                f_10258_24474_24487_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 24474, 24487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                f_10258_24491_24513()
                {
                    var return_v = VariableDeclaratorNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 24491, 24513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10258_24491_24525(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 24491, 24525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                f_10258_24689_24711()
                {
                    var return_v = VariableDeclaratorNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 24689, 24711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                f_10258_24689_24723(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 24689, 24723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10258_24617_24785(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                symbol, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                equalsValueNode, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                dependencies, bool
                earlyDecodingWellKnownAttributes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ConstantValueUtils.EvaluateFieldConstant((Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol)symbol, equalsValueNode, dependencies, earlyDecodingWellKnownAttributes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 24617, 24785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 24262, 24797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 24262, 24797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 24809, 25431);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 24990, 25391) || true) && (f_10258_24994_25009(this) == tree)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 24990, 25391);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 25051, 25155) || true) && (f_10258_25055_25082_M(!definedWithinSpan.HasValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 25051, 25155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 25124, 25136);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 25051, 25155);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 25175, 25235);

                    var
                    fieldDeclaration = f_10258_25198_25234(f_10258_25218_25233(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 25253, 25376);

                    return f_10258_25260_25310(f_10258_25260_25287(fieldDeclaration)) && (DynAbs.Tracing.TraceSender.Expression_True(10258, 25260, 25375) && fieldDeclaration.Span.IntersectsWith(definedWithinSpan.Value));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 24990, 25391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 25407, 25420);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 24809, 25431);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10258_24994_25009(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 24994, 25009);
                    return return_v;
                }


                bool
                f_10258_25055_25082_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 25055, 25082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10258_25218_25233(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 25218, 25233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                f_10258_25198_25234(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                declarator)
                {
                    var return_v = GetFieldDeclaration(declarator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 25198, 25234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10258_25260_25287(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 25260, 25287);
                    return return_v;
                }


                bool
                f_10258_25260_25310(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.HasCompilationUnitRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 25260, 25310);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 24809, 25431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 24809, 25431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10258, 25443, 25946);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 25700, 25859) || true) && (f_10258_25704_25722_M(!IsFixedSizeBuffer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10258, 25700, 25859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 25756, 25844);

                    f_10258_25756_25843(f_10258_25756_25760(), f_10258_25781_25801(), conversions, f_10258_25816_25829(), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10258, 25700, 25859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10258, 25875, 25935);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AfterAddingTypeMembersChecks(conversions, diagnostics), 10258, 25875, 25934);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10258, 25443, 25946);

                bool
                f_10258_25704_25722_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 25704, 25722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10258_25756_25760()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 25756, 25760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10258_25781_25801()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 25781, 25801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10258_25816_25829()
                {
                    var return_v = ErrorLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 25816, 25829);
                    return return_v;
                }


                int
                f_10258_25756_25843(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 25756, 25843);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10258, 25443, 25946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 25443, 25946);
            }
        }

        static SourceMemberFieldSymbolFromDeclarator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10258, 12082, 25953);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10258, 12082, 25953);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10258, 12082, 25953);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10258, 12082, 25953);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10258_12910_12935(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 12910, 12935);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
        f_10258_13016_13038(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        this_param)
        {
            var return_v = this_param.Initializer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 13016, 13038);
            return return_v;
        }


        int
        f_10258_13063_13099(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
        this_param, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckAccessibility(diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 13063, 13099);
            return 0;
        }


        int
        f_10258_13169_13213(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
        this_param, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.ReportModifiersDiagnostics(diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 13169, 13213);
            return 0;
        }


        bool
        f_10258_13249_13275(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 13249, 13275);
            return return_v;
        }


        bool
        f_10258_13313_13326(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 13313, 13326);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_10258_13471_13484()
        {
            var return_v = ErrorLocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 13471, 13484);
            return return_v;
        }


        bool
        f_10258_13368_13485(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        syntax, Microsoft.CodeAnalysis.CSharp.MessageID
        feature, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = Binder.CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 13368, 13485);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10258_13515_13533()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 13515, 13533);
            return return_v;
        }


        bool
        f_10258_13514_13579_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 13514, 13579);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_10258_13712_13725()
        {
            var return_v = ErrorLocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 13712, 13725);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10258_13629_13726(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 13629, 13726);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_10258_13891_13904()
        {
            var return_v = ErrorLocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10258, 13891, 13904);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10258_13832_13905(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, Microsoft.CodeAnalysis.Location
        location)
        {
            var return_v = diagnostics.Add(code, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10258, 13832, 13905);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10258_12850_12864_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10258, 12552, 13951);
            return return_v;
        }

    }
}
