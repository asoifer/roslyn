// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordEqualityContractProperty : SourcePropertySymbolBase
    {
        internal const string
        PropertyName = "EqualityContract"
        ;

        public SynthesizedRecordEqualityContractProperty(SourceMemberContainerTypeSymbol containingType, DiagnosticBag diagnostics)
        : base(
        f_10722_710_724_C(containingType), syntax: (CSharpSyntaxNode)f_10722_769_815(f_10722_769_800(containingType)[0]), hasGetAccessor: true, hasSetAccessor: false, isExplicitInterfaceImplementation: false, explicitInterfaceType: null, aliasQualifierOpt: null, modifiers: (f_10722_1072_1095(containingType), f_10722_1097_1155(f_10722_1097_1140(containingType))) switch
        {
            (true, true) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 1204, 1248) && DynAbs.Tracing.TraceSender.Expression_True(10722, 1204, 1248))
=> DeclarationModifiers.Private,
            (false, true) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 1271, 1349) && DynAbs.Tracing.TraceSender.Expression_True(10722, 1271, 1349))
=> DeclarationModifiers.Protected | DeclarationModifiers.Virtual,
            (_, false) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 1372, 1448) && DynAbs.Tracing.TraceSender.Expression_True(10722, 1372, 1448))
=> DeclarationModifiers.Protected | DeclarationModifiers.Override
        }, hasInitializer: false, isAutoProperty: false, isExpressionBodied: false, isInitOnly: false, RefKind.None, PropertyName, indexerNameAttributeLists: f_10722_1735_1772(), f_10722_1791_1815(containingType)[0], diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10722, 548, 1871);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10722, 548, 1871);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 548, 1871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 548, 1871);
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 1925, 1932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 1928, 1932);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 1925, 1932);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 1925, 1932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 1925, 1932);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 2019, 2059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 2022, 2059);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 2019, 2059);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 2019, 2059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 2019, 2059);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 2164, 2204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 2167, 2204);
                    return f_10722_2167_2204(); DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 2164, 2204);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 2164, 2204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 2164, 2204);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IAttributeTargetSymbol AttributesOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 2272, 2279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 2275, 2279);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 2272, 2279);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 2272, 2279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 2272, 2279);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 2346, 2376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 2349, 2376);
                    return f_10722_2349_2373(f_10722_2349_2363())[0]; DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 2346, 2376);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 2346, 2376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 2346, 2376);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override SourcePropertyAccessorSymbol CreateGetAccessorSymbol(bool isAutoPropertyAccessor, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 2389, 2889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 2541, 2878);

                return f_10722_2548_2877(f_10722_2616_2630(), this, _modifiers, f_10722_2701_2725(f_10722_2701_2715())[0], f_10722_2765_2846(f_10722_2765_2831(((SourceMemberContainerTypeSymbol)f_10722_2799_2813()))[0]), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 2389, 2889);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_2616_2630()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 2616, 2630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_2701_2715()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 2701, 2715);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10722_2701_2725(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 2701, 2725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_2799_2813()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 2799, 2813);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10722_2765_2831(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 2765, 2831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10722_2765_2846(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 2765, 2846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                f_10722_2548_2877(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityContractProperty
                property, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                propertyModifiers, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = SourcePropertyAccessorSymbol.CreateAccessorSymbol(containingType, property, propertyModifiers, location, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 2548, 2877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 2389, 2889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 2389, 2889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override SourcePropertyAccessorSymbol CreateSetAccessorSymbol(bool isAutoPropertyAccessor, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 2901, 3101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 3053, 3090);

                throw f_10722_3059_3089();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 2901, 3101);

                System.Exception
                f_10722_3059_3089()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 3059, 3089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 2901, 3101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 2901, 3101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override (TypeWithAnnotations Type, ImmutableArray<ParameterSymbol> Parameters) MakeParametersAndBindType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 3113, 3517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 3280, 3506);

                return (TypeWithAnnotations.Create(f_10722_3315_3410(f_10722_3339_3359(), WellKnownType.System_Type, diagnostics, f_10722_3401_3409()), NullableAnnotation.NotAnnotated),
                                    ImmutableArray<ParameterSymbol>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 3113, 3517);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10722_3339_3359()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 3339, 3359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10722_3401_3409()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 3401, 3409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_3315_3410(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.GetWellKnownType(compilation, type, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 3315, 3410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 3113, 3517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 3113, 3517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool HasPointerTypeSyntactically
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 3581, 3589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 3584, 3589);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 3581, 3589);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 3581, 3589);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 3581, 3589);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void ValidatePropertyType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 3602, 3821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 3698, 3737);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ValidatePropertyType(diagnostics), 10722, 3698, 3736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 3751, 3810);

                f_10722_3751_3809(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 3602, 3821);

                int
                f_10722_3751_3809(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityContractProperty
                overriding, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    VerifyOverridesEqualityContractFromBase((Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)overriding, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 3751, 3809);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 3602, 3821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 3602, 3821);
            }
        }

        internal static void VerifyOverridesEqualityContractFromBase(PropertySymbol overriding, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10722, 3833, 4896);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 3972, 4101) || true) && (f_10722_3976_4045(f_10722_3976_4030(f_10722_3976_4001(overriding))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10722, 3972, 4101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 4079, 4086);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10722, 3972, 4101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 4117, 4144);

                bool
                reportAnError = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 4160, 4643) || true) && (f_10722_4164_4186_M(!overriding.IsOverride))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10722, 4160, 4643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 4220, 4241);

                    reportAnError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10722, 4160, 4643);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10722, 4160, 4643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 4307, 4354);

                    var
                    overridden = f_10722_4324_4353(overriding)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 4374, 4628) || true) && (overridden is object && (DynAbs.Tracing.TraceSender.Expression_True(10722, 4378, 4546) && !f_10722_4424_4546(f_10722_4424_4449(overridden), f_10722_4457_4511(f_10722_4457_4482(overriding)), TypeCompareKind.AllIgnoreOptions)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10722, 4374, 4628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 4588, 4609);

                        reportAnError = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10722, 4374, 4628);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10722, 4160, 4643);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 4659, 4885) || true) && (reportAnError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10722, 4659, 4885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 4710, 4870);

                    f_10722_4710_4869(diagnostics, ErrorCode.ERR_DoesNotOverrideBaseEqualityContract, f_10722_4777_4797(overriding)[0], overriding, f_10722_4814_4868(f_10722_4814_4839(overriding)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10722, 4659, 4885);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10722, 3833, 4896);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_3976_4001(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 3976, 4001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_3976_4030(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 3976, 4030);
                    return return_v;
                }


                bool
                f_10722_3976_4045(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 3976, 4045);
                    return return_v;
                }


                bool
                f_10722_4164_4186_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 4164, 4186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10722_4324_4353(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OverriddenProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 4324, 4353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_4424_4449(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 4424, 4449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_4457_4482(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 4457, 4482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_4457_4511(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 4457, 4511);
                    return return_v;
                }


                bool
                f_10722_4424_4546(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 4424, 4546);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10722_4777_4797(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 4777, 4797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_4814_4839(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 4814, 4839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10722_4814_4868(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 4814, 4868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10722_4710_4869(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 4710, 4869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 3833, 4896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 3833, 4896);
            }
        }
        internal sealed class GetAccessorSymbol : SourcePropertyAccessorSymbol
        {
            internal GetAccessorSymbol(
                            NamedTypeSymbol containingType,
                            SourcePropertySymbolBase property,
                            DeclarationModifiers propertyModifiers,
                            Location location,
                            CSharpSyntaxNode syntax,
                            DiagnosticBag diagnostics)
            : base(
            f_10722_5360_5374_C(containingType), property, propertyModifiers, location, syntax, hasBody: false, hasExpressionBody: false, isIterator: false, modifiers: f_10722_5687_5708(), MethodKind.PropertyGet, usesInit: false, isAutoPropertyAccessor: true, isNullableAnalysisEnabled: false, diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10722, 5003, 5977);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10722, 5003, 5977);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 5003, 5977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 5003, 5977);
                }
            }

            public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 6067, 6107);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 6070, 6107);
                        return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 6067, 6107);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 6067, 6107);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 6067, 6107);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool SynthesizesLoweredBoundBody
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 6175, 6182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 6178, 6182);
                        return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 6175, 6182);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 6175, 6182);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 6175, 6182);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10722, 6199, 6867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 6339, 6443);

                    var
                    F = f_10722_6347_6442(this, f_10722_6383_6410(this), compilationState, diagnostics)
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 6507, 6532);

                        F.CurrentFunction = this;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 6554, 6613);

                        f_10722_6554_6612(F, f_10722_6568_6611(F, f_10722_6576_6610(F, f_10722_6585_6609(F, f_10722_6594_6608()))));
                    }
                    catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10722, 6650, 6852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 6751, 6782);

                        f_10722_6751_6781(diagnostics, f_10722_6767_6780(ex));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 6804, 6833);

                        f_10722_6804_6832(F, f_10722_6818_6831(F));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10722, 6650, 6852);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10722, 6199, 6867);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10722_6383_6410(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityContractProperty.GetAccessorSymbol
                    symbol)
                    {
                        var return_v = symbol.GetNonNullSyntaxNode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 6383, 6410);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    f_10722_6347_6442(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityContractProperty.GetAccessorSymbol
                    topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 6347, 6442);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10722_6594_6608()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 6594, 6608);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10722_6585_6609(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = this_param.Typeof((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 6585, 6609);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10722_6576_6610(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression)
                    {
                        var return_v = this_param.Return(expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 6576, 6610);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10722_6568_6611(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 6568, 6611);
                        return return_v;
                    }


                    int
                    f_10722_6554_6612(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 6554, 6612);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_10722_6767_6780(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                    this_param)
                    {
                        var return_v = this_param.Diagnostic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 6767, 6780);
                        return return_v;
                    }


                    int
                    f_10722_6751_6781(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diag)
                    {
                        this_param.Add(diag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 6751, 6781);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10722_6818_6831(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.ThrowNull();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 6818, 6831);
                        return return_v;
                    }


                    int
                    f_10722_6804_6832(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    body)
                    {
                        this_param.CloseMethod(body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 6804, 6832);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10722, 6199, 6867);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 6199, 6867);
                }
            }

            static GetAccessorSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10722, 4908, 6878);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10722, 4908, 6878);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 4908, 6878);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10722, 4908, 6878);

            static Microsoft.CodeAnalysis.SyntaxTokenList
            f_10722_5687_5708()
            {
                var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 5687, 5708);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10722_5360_5374_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10722, 5003, 5977);
                return return_v;
            }

        }

        static SynthesizedRecordEqualityContractProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10722, 373, 6885);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10722, 502, 535);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10722, 373, 6885);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10722, 373, 6885);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10722, 373, 6885);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        f_10722_769_800(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.SyntaxReferences;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 769, 800);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10722_769_815(Microsoft.CodeAnalysis.SyntaxReference
        this_param)
        {
            var return_v = this_param.GetSyntax();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 769, 815);
            return return_v;
        }


        static bool
        f_10722_1072_1095(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsSealed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 1072, 1095);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10722_1097_1140(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 1097, 1140);
            return return_v;
        }


        static bool
        f_10722_1097_1155(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        type)
        {
            var return_v = type.IsObjectType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 1097, 1155);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        f_10722_1735_1772()
        {
            var return_v = new Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 1735, 1772);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10722_1791_1815(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 1791, 1815);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10722_710_724_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10722, 548, 1871);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        f_10722_2167_2204()
        {
            var return_v = new Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10722, 2167, 2204);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10722_2349_2363()
        {
            var return_v = ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 2349, 2363);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10722_2349_2373(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.Locations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10722, 2349, 2373);
            return return_v;
        }

    }
}
