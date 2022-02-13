// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordPropertySymbol : SourcePropertySymbolBase
    {
        public SourceParameterSymbol BackingParameter { get; }

        public SynthesizedRecordPropertySymbol(
                    SourceMemberContainerTypeSymbol containingType,
                    CSharpSyntaxNode syntax,
                    ParameterSymbol backingParameter,
                    bool isOverride,
                    DiagnosticBag diagnostics)
        : base(
        f_10732_832_846_C(containingType), syntax: syntax, hasGetAccessor: true, hasSetAccessor: true, isExplicitInterfaceImplementation: false, explicitInterfaceType: null, aliasQualifierOpt: null, modifiers: DeclarationModifiers.Public | ((DynAbs.Tracing.TraceSender.Conditional_F1(10732, 1165, 1175) || ((isOverride && DynAbs.Tracing.TraceSender.Conditional_F2(10732, 1178, 1207)) || DynAbs.Tracing.TraceSender.Conditional_F3(10732, 1210, 1235))) ? DeclarationModifiers.Override : DeclarationModifiers.None), hasInitializer: true, isAutoProperty: true, isExpressionBodied: false, isInitOnly: true, RefKind.None, f_10732_1514_1535(backingParameter), indexerNameAttributeLists: f_10732_1581_1618(), f_10732_1637_1663(backingParameter)[0], diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10732, 538, 1792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 472, 526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 1722, 1781);

                BackingParameter = (SourceParameterSymbol)backingParameter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10732, 538, 1792);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10732, 538, 1792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 538, 1792);
            }
        }

        public override IAttributeTargetSymbol AttributesOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10732, 1859, 1912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 1862, 1912);
                    return f_10732_1862_1878() as IAttributeTargetSymbol ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol?>(10732, 1862, 1912) ?? this); DynAbs.Tracing.TraceSender.TraceExitMethod(10732, 1859, 1912);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10732, 1859, 1912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 1859, 1912);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Location TypeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10732, 1979, 2032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 1982, 2032);
                    return f_10732_1982_2032(((ParameterSyntax)f_10732_2000_2016()).Type!); DynAbs.Tracing.TraceSender.TraceExitMethod(10732, 1979, 2032);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10732, 1979, 2032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 1979, 2032);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SyntaxList<AttributeListSyntax> AttributeDeclarationSyntaxList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10732, 2137, 2181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 2140, 2181);
                    return f_10732_2140_2181(f_10732_2140_2156()); DynAbs.Tracing.TraceSender.TraceExitMethod(10732, 2137, 2181);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10732, 2137, 2181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 2137, 2181);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override SourcePropertyAccessorSymbol CreateGetAccessorSymbol(bool isAutoPropertyAccessor, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10732, 2194, 2480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 2346, 2383);

                f_10732_2346_2382(isAutoPropertyAccessor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 2397, 2469);

                return f_10732_2404_2468(this, isGet: true, f_10732_2438_2454(), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10732, 2194, 2480);

                int
                f_10732_2346_2382(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10732, 2346, 2382);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10732_2438_2454()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 2438, 2454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10732_2404_2468(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordPropertySymbol
                this_param, bool
                isGet, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateAccessorSymbol(isGet: isGet, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10732, 2404, 2468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10732, 2194, 2480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 2194, 2480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SourcePropertyAccessorSymbol CreateSetAccessorSymbol(bool isAutoPropertyAccessor, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10732, 2492, 2779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 2644, 2681);

                f_10732_2644_2680(isAutoPropertyAccessor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 2695, 2768);

                return f_10732_2702_2767(this, isGet: false, f_10732_2737_2753(), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10732, 2492, 2779);

                int
                f_10732_2644_2680(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10732, 2644, 2680);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10732_2737_2753()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 2737, 2753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10732_2702_2767(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordPropertySymbol
                this_param, bool
                isGet, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateAccessorSymbol(isGet: isGet, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10732, 2702, 2767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10732, 2492, 2779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 2492, 2779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SourcePropertyAccessorSymbol CreateAccessorSymbol(
                    bool isGet,
                    CSharpSyntaxNode syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10732, 2791, 3348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 2977, 3337);

                return f_10732_2984_3336(isGet, usesInit: !isGet, f_10732_3145_3159(), this, _modifiers, ((ParameterSyntax)syntax).Identifier.GetLocation(), syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10732, 2791, 3348);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10732_3145_3159()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 3145, 3159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10732_2984_3336(bool
                isGetMethod, bool
                usesInit, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordPropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                propertyModifiers, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = SourcePropertyAccessorSymbol.CreateAccessorSymbol(isGetMethod, usesInit: usesInit, containingType, property, propertyModifiers, location, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10732, 2984, 3336);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10732, 2791, 3348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 2791, 3348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations Type, ImmutableArray<ParameterSymbol> Parameters) MakeParametersAndBindType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10732, 3360, 3644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 3527, 3633);

                return (f_10732_3535_3571(f_10732_3535_3551()),
                                    ImmutableArray<ParameterSymbol>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10732, 3360, 3644);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                f_10732_3535_3551()
                {
                    var return_v = BackingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 3535, 3551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10732_3535_3571(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 3535, 3571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10732, 3360, 3644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 3360, 3644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool HasPointerTypeSyntactically
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10732, 3801, 3864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 3804, 3864);
                    return f_10732_3804_3864(f_10732_3804_3823().DefaultType); DynAbs.Tracing.TraceSender.TraceExitMethod(10732, 3801, 3864);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10732, 3801, 3864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 3801, 3864);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool HaveCorrespondingSynthesizedRecordPropertySymbol(SourceParameterSymbol parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10732, 3877, 4261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 4002, 4250);

                return f_10732_4009_4035(parameter) is SynthesizedRecordConstructor && (DynAbs.Tracing.TraceSender.Expression_True(10732, 4009, 4249) && f_10732_4091_4137(f_10732_4091_4115(parameter)).Any((s, parameter) => (s as SynthesizedRecordPropertySymbol)?.BackingParameter == (object)parameter, parameter));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10732, 3877, 4261);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10732_4009_4035(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 4009, 4035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10732_4091_4115(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 4091, 4115);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10732_4091_4137(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10732, 4091, 4137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10732, 3877, 4261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 3877, 4261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedRecordPropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10732, 375, 4268);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10732, 375, 4268);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10732, 375, 4268);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10732, 375, 4268);

        static string
        f_10732_1514_1535(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 1514, 1535);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        f_10732_1581_1618()
        {
            var return_v = new Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10732, 1581, 1618);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10732_1637_1663(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 1637, 1663);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10732_832_846_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10732, 538, 1792);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
        f_10732_1862_1878()
        {
            var return_v = BackingParameter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 1862, 1878);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        f_10732_2000_2016()
        {
            var return_v = CSharpSyntaxNode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 2000, 2016);
            return return_v;
        }


        Microsoft.CodeAnalysis.Location
        f_10732_1982_2032(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 1982, 2032);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
        f_10732_2140_2156()
        {
            var return_v = BackingParameter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 2140, 2156);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        f_10732_2140_2181(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
        this_param)
        {
            var return_v = this_param.AttributeDeclarationList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 2140, 2181);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10732_3804_3823()
        {
            var return_v = TypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10732, 3804, 3823);
            return return_v;
        }


        bool
        f_10732_3804_3864(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type.IsPointerOrFunctionPointer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10732, 3804, 3864);
            return return_v;
        }

    }
}
