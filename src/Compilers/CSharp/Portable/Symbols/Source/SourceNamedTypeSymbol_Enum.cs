// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class SourceNamedTypeSymbol
    {
        private SynthesizedEnumValueFieldSymbol _lazyEnumValueField;

        private NamedTypeSymbol _lazyEnumUnderlyingType;

        public override NamedTypeSymbol EnumUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10080, 925, 1701);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 961, 1635) || true) && (f_10080_965_1040(_lazyEnumUnderlyingType, ErrorTypeSymbol.UnknownResultType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10080, 961, 1635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 1082, 1138);

                        DiagnosticBag
                        diagnostics = f_10080_1110_1137()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 1160, 1575) || true) && ((object)f_10080_1172_1304(ref _lazyEnumUnderlyingType, f_10080_1229_1268(this, diagnostics), ErrorTypeSymbol.UnknownResultType) ==
                                                (object)ErrorTypeSymbol.UnknownResultType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10080, 1160, 1575);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 1424, 1463);

                            f_10080_1424_1462(this, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 1489, 1552);

                            this.state.NotePartComplete(CompletionPart.EnumUnderlyingType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10080, 1160, 1575);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 1597, 1616);

                        f_10080_1597_1615(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10080, 961, 1635);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 1655, 1686);

                    return _lazyEnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10080, 925, 1701);

                    bool
                    f_10080_965_1040(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 965, 1040);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10080_1110_1137()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 1110, 1137);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10080_1229_1268(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GetEnumUnderlyingType(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 1229, 1268);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10080_1172_1304(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 1172, 1304);
                        return return_v;
                    }


                    int
                    f_10080_1424_1462(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        this_param.AddDeclarationDiagnostics(diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 1424, 1462);
                        return 0;
                    }


                    int
                    f_10080_1597_1615(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 1597, 1615);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10080, 850, 1712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10080, 850, 1712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private NamedTypeSymbol GetEnumUnderlyingType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10080, 1724, 3235);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 1821, 1916) || true) && (f_10080_1825_1838(this) != TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10080, 1821, 1916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 1889, 1901);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10080, 1821, 1916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 1932, 1976);

                var
                compilation = f_10080_1950_1975(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 1990, 2034);

                var
                decl = f_10080_2001_2030(this.declaration)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2048, 2081);

                var
                bases = f_10080_2060_2080(decl)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2095, 2971) || true) && (bases != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10080, 2095, 2971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2146, 2170);

                    var
                    types = f_10080_2158_2169(bases)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2188, 2956) || true) && (types.Count > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10080, 2188, 2956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2249, 2280);

                        var
                        typeSyntax = f_10080_2266_2279(types[0])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2304, 2350);

                        var
                        baseBinder = f_10080_2321_2349(compilation, bases)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2372, 2433);

                        var
                        type = f_10080_2383_2427(baseBinder, typeSyntax, diagnostics).Type
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2603, 2884) || true) && (!f_10080_2608_2652(f_10080_2608_2624(type)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10080, 2603, 2884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2702, 2775);

                            f_10080_2702_2774(diagnostics, ErrorCode.ERR_IntegralTypeExpected, f_10080_2754_2773(typeSyntax));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2801, 2861);

                            type = f_10080_2808_2860(compilation, SpecialType.System_Int32);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10080, 2603, 2884);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2908, 2937);

                        return (NamedTypeSymbol)type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10080, 2188, 2956);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10080, 2095, 2971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 2987, 3080);

                NamedTypeSymbol
                defaultUnderlyingType = f_10080_3027_3079(compilation, SpecialType.System_Int32)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 3094, 3181);

                f_10080_3094_3180(defaultUnderlyingType, diagnostics, f_10080_3162_3176(this)[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 3195, 3224);

                return defaultUnderlyingType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10080, 1724, 3235);

                Microsoft.CodeAnalysis.TypeKind
                f_10080_1825_1838(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10080, 1825, 1838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10080_1950_1975(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10080, 1950, 1975);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10080_2001_2030(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10080, 2001, 2030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                f_10080_2060_2080(Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                decl)
                {
                    var return_v = GetBaseListOpt(decl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 2060, 2080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax>
                f_10080_2158_2169(Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                this_param)
                {
                    var return_v = this_param.Types;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10080, 2158, 2169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10080_2266_2279(Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10080, 2266, 2279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10080_2321_2349(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax
                syntax)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 2321, 2349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10080_2383_2427(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 2383, 2427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10080_2608_2624(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10080, 2608, 2624);
                    return return_v;
                }


                bool
                f_10080_2608_2652(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsValidEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 2608, 2652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10080_2754_2773(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10080, 2754, 2773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10080_2702_2774(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 2702, 2774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10080_2808_2860(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 2808, 2860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10080_3027_3079(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 3027, 3079);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10080_3162_3176(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10080, 3162, 3176);
                    return return_v;
                }


                bool
                f_10080_3094_3180(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 3094, 3180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10080, 1724, 3235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10080, 1724, 3235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FieldSymbol EnumValueField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10080, 3498, 4001);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 3534, 3641) || true) && (f_10080_3538_3551(this) != TypeKind.Enum)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10080, 3534, 3641);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 3610, 3622);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10080, 3534, 3641);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 3661, 3939) || true) && ((object)_lazyEnumValueField == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10080, 3661, 3939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 3742, 3796);

                        f_10080_3742_3795((object)f_10080_3763_3786(this) != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 3818, 3920);

                        f_10080_3818_3919(ref _lazyEnumValueField, f_10080_3871_3912(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10080, 3661, 3939);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10080, 3959, 3986);

                    return _lazyEnumValueField;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10080, 3498, 4001);

                    Microsoft.CodeAnalysis.TypeKind
                    f_10080_3538_3551(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10080, 3538, 3551);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10080_3763_3786(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.EnumUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10080, 3763, 3786);
                        return return_v;
                    }


                    int
                    f_10080_3742_3795(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 3742, 3795);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEnumValueFieldSymbol
                    f_10080_3871_3912(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                    containingEnum)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEnumValueFieldSymbol(containingEnum);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 3871, 3912);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEnumValueFieldSymbol?
                    f_10080_3818_3919(ref Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEnumValueFieldSymbol?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEnumValueFieldSymbol
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEnumValueFieldSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10080, 3818, 3919);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10080, 3438, 4012);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10080, 3438, 4012);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
}
