// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceOrdinaryMethodSymbolBase : SourceMemberMethodSymbol
    {
        private readonly ImmutableArray<TypeParameterSymbol> _typeParameters;

        private readonly string _name;

        private ImmutableArray<MethodSymbol> _lazyExplicitInterfaceImplementations;

        private ImmutableArray<CustomModifier> _lazyRefCustomModifiers;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        private TypeWithAnnotations _lazyReturnType;

        protected SourceOrdinaryMethodSymbolBase(
                    NamedTypeSymbol containingType,
                    string name,
                    Location location,
                    CSharpSyntaxNode syntax,
                    MethodKind methodKind,
                    bool isIterator,
                    bool isExtensionMethod,
                    bool isPartial,
                    bool hasBody,
                    bool isNullableAnalysisEnabled,
                    DiagnosticBag diagnostics) : base(f_10269_1764_1778_C(containingType), f_10269_1798_1819(syntax), location, isIterator: isIterator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10269, 1317, 3446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 1019, 1024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 17876, 17924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 1915, 1928);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 2211, 2242);

                const bool
                returnsVoid = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 2258, 2300);

                DeclarationModifiers
                declarationModifiers
                = default(DeclarationModifiers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 2314, 2440);

                // LAFHIS
                //(declarationModifiers, f_10269_2337_2362()) = f_10269_2366_2439(this, methodKind, isPartial, hasBody, location, diagnostics);

                (declarationModifiers, HasExplicitAccessModifier) = f_10269_2366_2439(this, methodKind, isPartial, hasBody, location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 2337, 2362);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 2456, 2554);

                var
                isMetadataVirtualIgnoringModifiers = methodKind == MethodKind.ExplicitInterfaceImplementation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 2619, 2845);

                f_10269_2619_2844(
                            this, methodKind, declarationModifiers, returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: isMetadataVirtualIgnoringModifiers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 2861, 2919);

                _typeParameters = f_10269_2879_2918(this, syntax, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 2935, 3017);

                f_10269_2935_3016(this, syntax, location, hasBody, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 3033, 3138) || true) && (hasBody)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 3033, 3138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 3078, 3123);

                    f_10269_3078_3122(this, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 3033, 3138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 3154, 3324);

                var
                info = f_10269_3165_3323(this.DeclarationModifiers, this, isExplicitInterfaceImplementation: methodKind == MethodKind.ExplicitInterfaceImplementation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 3338, 3435) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 3338, 3435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 3388, 3420);

                    f_10269_3388_3419(diagnostics, info, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 3338, 3435);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10269, 1317, 3446);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 1317, 3446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 1317, 3446);
            }
        }

        protected abstract ImmutableArray<TypeParameterSymbol> MakeTypeParameters(CSharpSyntaxNode node, DiagnosticBag diagnostics);

        public override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 3651, 3763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 3687, 3706);

                    f_10269_3687_3705(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 3724, 3748);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ReturnsVoid, 10269, 3731, 3747);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 3651, 3763);

                    int
                    f_10269_3687_3705(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 3687, 3705);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 3594, 3774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 3594, 3774);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void MethodChecks(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 3786, 13101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 3874, 3992);

                f_10269_3874_3991(f_10269_3887_3902(this) != MethodKind.UserDefinedOperator, "SourceUserDefinedOperatorSymbolBase overrides this");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4008, 4074);

                ImmutableArray<TypeParameterConstraintClause>
                declaredConstraints
                = default(ImmutableArray<TypeParameterConstraintClause>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4088, 4102);

                bool
                isVararg
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4116, 4229);

                (_lazyReturnType, _lazyParameters, isVararg, declaredConstraints) = f_10269_4184_4228(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4282, 4332);

                f_10269_4282_4331(
                            // set ReturnsVoid flag
                            this, _lazyReturnType.IsVoidType());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4348, 4428);

                f_10269_4348_4427(
                            this, _lazyReturnType, _lazyParameters, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4444, 4472);

                var
                location = locations[0]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4548, 4772) || true) && (f_10269_4552_4561(this) == WellKnownMemberNames.DestructorName && (DynAbs.Tracing.TraceSender.Expression_True(10269, 4552, 4628) && f_10269_4604_4623(this) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 4552, 4647) && f_10269_4632_4642(this) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 4552, 4667) && f_10269_4651_4667(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 4548, 4772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4701, 4757);

                    f_10269_4701_4756(diagnostics, ErrorCode.WRN_FinalizeMethod, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 4548, 4772);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4788, 4823);

                f_10269_4788_4822(this, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4839, 5273) || true) && (f_10269_4843_4852())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 4839, 5273);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4886, 5073) || true) && (f_10269_4890_4900() == MethodKind.ExplicitInterfaceImplementation)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 4886, 5073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 4988, 5054);

                        f_10269_4988_5053(diagnostics, ErrorCode.ERR_PartialMethodNotExplicit, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 4886, 5073);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 5093, 5258) || true) && (!f_10269_5098_5124(f_10269_5098_5112()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 5093, 5258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 5166, 5239);

                        f_10269_5166_5238(diagnostics, ErrorCode.ERR_PartialMethodOnlyInPartialClass, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 5093, 5258);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 4839, 5273);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 5289, 5488) || true) && (f_10269_5293_5303_M(!IsPartial))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 5289, 5488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 5337, 5383);

                    f_10269_5337_5382(this, CancellationToken.None);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 5401, 5473);

                    f_10269_5401_5472(state.HasComplete(CompletionPart.FinishAsyncMethodChecks));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 5289, 5488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 6521, 6575);

                f_10269_6521_6574(_lazyReturnType.CustomModifiers.IsEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 6589, 6652);

                _lazyRefCustomModifiers = ImmutableArray<CustomModifier>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 6668, 6728);

                MethodSymbol
                overriddenOrExplicitlyImplementedMethod = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 7018, 10929) || true) && (f_10269_7022_7032() != MethodKind.ExplicitInterfaceImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 7018, 10929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 7112, 7174);

                    f_10269_7112_7173(_lazyExplicitInterfaceImplementations.IsDefault);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 7192, 7267);

                    _lazyExplicitInterfaceImplementations = ImmutableArray<MethodSymbol>.Empty;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 7651, 9261) || true) && (f_10269_7655_7670(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 7651, 9261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 8289, 8353);

                        overriddenOrExplicitlyImplementedMethod = f_10269_8331_8352(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 8377, 8845) || true) && ((object)overriddenOrExplicitlyImplementedMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 8377, 8845);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 8486, 8822);

                            f_10269_8486_8821(overriddenOrExplicitlyImplementedMethod, this, out _lazyReturnType, out _lazyRefCustomModifiers, out _lazyParameters, alsoCopyParamsModifier: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 8377, 8845);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 7651, 9261);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 7651, 9261);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 8887, 9261) || true) && (f_10269_8891_8898() == RefKind.RefReadOnly)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 8887, 9261);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 8963, 9119);

                            var
                            modifierType = f_10269_8982_9118(f_10269_9006_9026(), WellKnownType.System_Runtime_InteropServices_InAttribute, diagnostics, f_10269_9099_9117())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 9143, 9242);

                            _lazyRefCustomModifiers = f_10269_9169_9241(f_10269_9191_9240(modifierType));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 8887, 9261);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 7651, 9261);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 7018, 10929);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 7018, 10929);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 9295, 10929) || true) && ((object)f_10269_9307_9328() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 9295, 10929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 9502, 9589);

                        overriddenOrExplicitlyImplementedMethod = f_10269_9544_9588(this, diagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 9609, 10914) || true) && ((object)overriddenOrExplicitlyImplementedMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 9609, 10914);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 9710, 9772);

                            f_10269_9710_9771(_lazyExplicitInterfaceImplementations.IsDefault);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 9794, 9911);

                            _lazyExplicitInterfaceImplementations = f_10269_9834_9910(overriddenOrExplicitlyImplementedMethod);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 9935, 10264);

                            f_10269_9935_10263(overriddenOrExplicitlyImplementedMethod, this, out _lazyReturnType, out _lazyRefCustomModifiers, out _lazyParameters, alsoCopyParamsModifier: false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 10286, 10389);

                            f_10269_10286_10388(this, overriddenOrExplicitlyImplementedMethod, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 10411, 10576);

                            f_10269_10411_10575(f_10269_10477_10496(this), this, overriddenOrExplicitlyImplementedMethod, isExplicit: true, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 9609, 10914);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 9609, 10914);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 10658, 10720);

                            f_10269_10658_10719(_lazyExplicitInterfaceImplementations.IsDefault);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 10742, 10817);

                            _lazyExplicitInterfaceImplementations = ImmutableArray<MethodSymbol>.Empty;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 10841, 10895);

                            f_10269_10841_10894(_lazyReturnType.CustomModifiers.IsEmpty);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 9609, 10914);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 9295, 10929);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 7018, 10929);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 10945, 12956) || true) && (f_10269_10949_10979_M(!declaredConstraints.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 10949, 11032) && overriddenOrExplicitlyImplementedMethod is object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 10945, 12956);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 11075, 11080);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 11066, 12941) || true) && (i < declaredConstraints.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 11114, 11117)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 11066, 12941))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 11066, 12941);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 11159, 11198);

                            var
                            typeParameter = _typeParameters[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 11220, 11237);

                            ErrorCode
                            report
                            = default(ErrorCode);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 11261, 12688);

                            switch (declaredConstraints[i].Constraints & (TypeParameterConstraintKind.ReferenceType | TypeParameterConstraintKind.ValueType | TypeParameterConstraintKind.Default))
                            {

                                case TypeParameterConstraintKind.ReferenceType:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 11261, 12688);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 11554, 11782) || true) && (f_10269_11558_11588_M(!typeParameter.IsReferenceType))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 11554, 11782);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 11654, 11711);

                                        report = ErrorCode.ERR_OverrideRefConstraintNotSatisfied;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10269, 11745, 11751);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 11554, 11782);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 11812, 11821);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 11261, 12688);

                                case TypeParameterConstraintKind.ValueType:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 11261, 12688);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 11920, 12157) || true) && (!f_10269_11925_11963(typeParameter))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 11920, 12157);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 12029, 12086);

                                        report = ErrorCode.ERR_OverrideValConstraintNotSatisfied;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10269, 12120, 12126);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 11920, 12157);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 12187, 12196);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 11261, 12688);

                                case TypeParameterConstraintKind.Default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 11261, 12688);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 12293, 12553) || true) && (f_10269_12297_12326(typeParameter) || (DynAbs.Tracing.TraceSender.Expression_False(10269, 12297, 12355) || f_10269_12330_12355(typeParameter)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 12293, 12553);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 12421, 12482);

                                        report = ErrorCode.ERR_OverrideDefaultConstraintNotSatisfied;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10269, 12516, 12522);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 12293, 12553);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 12583, 12592);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 11261, 12688);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 11261, 12688);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 12656, 12665);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 11261, 12688);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 12712, 12922);

                            f_10269_12712_12921(
                                                diagnostics, report, f_10269_12736_12759(typeParameter)[0], this, typeParameter, f_10269_12822_12876(overriddenOrExplicitlyImplementedMethod)[i], overriddenOrExplicitlyImplementedMethod);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10269, 1, 1876);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10269, 1, 1876);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 10945, 12956);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 12972, 13090);

                f_10269_12972_13089(this, f_10269_12987_12997() == MethodKind.ExplicitInterfaceImplementation, isVararg, f_10269_13055_13065(), location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 3786, 13101);

                Microsoft.CodeAnalysis.MethodKind
                f_10269_3887_3902(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 3887, 3902);
                    return return_v;
                }


                int
                f_10269_3874_3991(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 3874, 3991);
                    return 0;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations ReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol> Parameters, bool IsVararg, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation)
                f_10269_4184_4228(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeParametersAndBindReturnType(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 4184, 4228);
                    return return_v;
                }


                int
                f_10269_4282_4331(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, bool
                returnsVoid)
                {
                    this_param.SetReturnsVoid(returnsVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 4282, 4331);
                    return 0;
                }


                int
                f_10269_4348_4427(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckEffectiveAccessibility(returnType, parameters, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 4348, 4427);
                    return 0;
                }


                string
                f_10269_4552_4561(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 4552, 4561);
                    return return_v;
                }


                int
                f_10269_4604_4623(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 4604, 4623);
                    return return_v;
                }


                int
                f_10269_4632_4642(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 4632, 4642);
                    return return_v;
                }


                bool
                f_10269_4651_4667(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 4651, 4667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_4701_4756(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 4701, 4756);
                    return return_v;
                }


                int
                f_10269_4788_4822(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ExtensionMethodChecks(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 4788, 4822);
                    return 0;
                }


                bool
                f_10269_4843_4852()
                {
                    var return_v = IsPartial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 4843, 4852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10269_4890_4900()
                {
                    var return_v = MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 4890, 4900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_4988_5053(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 4988, 5053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_5098_5112()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 5098, 5112);
                    return return_v;
                }


                bool
                f_10269_5098_5124(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsPartial();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 5098, 5124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_5166_5238(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 5166, 5238);
                    return return_v;
                }


                bool
                f_10269_5293_5303_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 5293, 5303);
                    return return_v;
                }


                int
                f_10269_5337_5382(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.LazyAsyncMethodChecks(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 5337, 5382);
                    return 0;
                }


                int
                f_10269_5401_5472(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 5401, 5472);
                    return 0;
                }


                int
                f_10269_6521_6574(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 6521, 6574);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10269_7022_7032()
                {
                    var return_v = MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 7022, 7032);
                    return return_v;
                }


                int
                f_10269_7112_7173(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 7112, 7173);
                    return 0;
                }


                bool
                f_10269_7655_7670(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 7655, 7670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10269_8331_8352(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 8331, 8352);
                    return return_v;
                }


                int
                f_10269_8486_8821(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                sourceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                destinationMethod, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, bool
                alsoCopyParamsModifier)
                {
                    CustomModifierUtils.CopyMethodCustomModifiers(sourceMethod, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)destinationMethod, out returnType, out customModifiers, out parameters, alsoCopyParamsModifier: alsoCopyParamsModifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 8486, 8821);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10269_8891_8898()
                {
                    var return_v = RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 8891, 8898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10269_9006_9026()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 9006, 9026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10269_9099_9117()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 9099, 9117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_8982_9118(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.GetWellKnownType(compilation, type, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 8982, 9118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomModifier
                f_10269_9191_9240(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CSharpCustomModifier.CreateRequired(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 9191, 9240);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10269_9169_9241(Microsoft.CodeAnalysis.CustomModifier
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 9169, 9241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10269_9307_9328()
                {
                    var return_v = ExplicitInterfaceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 9307, 9328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10269_9544_9588(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.FindExplicitlyImplementedMethod(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 9544, 9588);
                    return return_v;
                }


                int
                f_10269_9710_9771(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 9710, 9771);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10269_9834_9910(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<MethodSymbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 9834, 9910);
                    return return_v;
                }


                int
                f_10269_9935_10263(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                sourceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                destinationMethod, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, bool
                alsoCopyParamsModifier)
                {
                    CustomModifierUtils.CopyMethodCustomModifiers(sourceMethod, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)destinationMethod, out returnType, out customModifiers, out parameters, alsoCopyParamsModifier: alsoCopyParamsModifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 9935, 10263);
                    return 0;
                }


                int
                f_10269_10286_10388(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                implementingMember, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                implementedMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    implementingMember.FindExplicitlyImplementedMemberVerification((Microsoft.CodeAnalysis.CSharp.Symbol)implementedMember, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 10286, 10388);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_10477_10496(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 10477, 10496);
                    return return_v;
                }


                int
                f_10269_10411_10575(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                implementingMember, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                interfaceMember, bool
                isExplicit, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    TypeSymbol.CheckNullableReferenceTypeMismatchOnImplementingMember((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)implementingType, (Microsoft.CodeAnalysis.CSharp.Symbol)implementingMember, (Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember, isExplicit: isExplicit, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 10411, 10575);
                    return 0;
                }


                int
                f_10269_10658_10719(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 10658, 10719);
                    return 0;
                }


                int
                f_10269_10841_10894(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 10841, 10894);
                    return 0;
                }


                bool
                f_10269_10949_10979_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 10949, 10979);
                    return return_v;
                }


                bool
                f_10269_11558_11588_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 11558, 11588);
                    return return_v;
                }


                bool
                f_10269_11925_11963(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 11925, 11963);
                    return return_v;
                }


                bool
                f_10269_12297_12326(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 12297, 12326);
                    return return_v;
                }


                bool
                f_10269_12330_12355(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 12330, 12355);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10269_12736_12759(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 12736, 12759);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10269_12822_12876(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 12822, 12876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_12712_12921(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 12712, 12921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10269_12987_12997()
                {
                    var return_v = MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 12987, 12997);
                    return return_v;
                }


                bool
                f_10269_13055_13065()
                {
                    var return_v = HasAnyBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 13055, 13065);
                    return return_v;
                }


                int
                f_10269_12972_13089(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, bool
                isExplicitInterfaceImplementation, bool
                isVararg, bool
                hasBody, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckModifiers(isExplicitInterfaceImplementation, isVararg, hasBody, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 12972, 13089);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 3786, 13101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 3786, 13101);
            }
        }

        protected abstract (TypeWithAnnotations ReturnType, ImmutableArray<ParameterSymbol> Parameters, bool IsVararg, ImmutableArray<TypeParameterConstraintClause> DeclaredConstraintsForOverrideOrImplementation) MakeParametersAndBindReturnType(DiagnosticBag diagnostics);

        protected abstract void ExtensionMethodChecks(DiagnosticBag diagnostics);

        protected abstract MethodSymbol FindExplicitlyImplementedMethod(DiagnosticBag diagnostics);

        protected abstract Location ReturnTypeLocation { get; }

        protected abstract TypeSymbol ExplicitInterfaceType { get; }

        protected abstract bool HasAnyBody { get; }

        protected sealed override void LazyAsyncMethodChecks(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 13771, 14574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 13885, 14146);

                f_10269_13885_14145(f_10269_13898_13912(this) == state.HasComplete(CompletionPart.FinishMethodChecks), "Partial methods complete method checks during construction.  " +
                                "Other methods can't complete method checks before executing this method.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14162, 14339) || true) && (f_10269_14166_14179_M(!this.IsAsync))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 14162, 14339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14213, 14299);

                    f_10269_14213_14298(this, diagnosticsOpt: null, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14317, 14324);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 14162, 14339);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14355, 14411);

                DiagnosticBag
                diagnostics = f_10269_14383_14410()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14425, 14456);

                f_10269_14425_14455(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14472, 14530);

                f_10269_14472_14529(this, diagnostics, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14544, 14563);

                f_10269_14544_14562(diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 13771, 14574);

                bool
                f_10269_13898_13912(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.IsPartial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 13898, 13912);
                    return return_v;
                }


                int
                f_10269_13885_14145(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 13885, 14145);
                    return 0;
                }


                bool
                f_10269_14166_14179_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 14166, 14179);
                    return return_v;
                }


                int
                f_10269_14213_14298(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.CompleteAsyncMethodChecks(diagnosticsOpt: diagnosticsOpt, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 14213, 14298);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10269_14383_14410()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 14383, 14410);
                    return return_v;
                }


                int
                f_10269_14425_14455(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AsyncMethodChecks(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 14425, 14455);
                    return 0;
                }


                int
                f_10269_14472_14529(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.CompleteAsyncMethodChecks(diagnosticsOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 14472, 14529);
                    return 0;
                }


                int
                f_10269_14544_14562(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 14544, 14562);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 13771, 14574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 13771, 14574);
            }
        }

        private void CompleteAsyncMethodChecks(DiagnosticBag diagnosticsOpt, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 14586, 15268);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14716, 15257) || true) && (state.NotePartComplete(CompletionPart.StartAsyncMethodChecks))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 14716, 15257);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14815, 14944) || true) && (diagnosticsOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 14815, 14944);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14883, 14925);

                        f_10269_14883_14924(this, diagnosticsOpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 14815, 14944);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 14964, 15013);

                    f_10269_14964_15012(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 15031, 15094);

                    state.NotePartComplete(CompletionPart.FinishAsyncMethodChecks);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 14716, 15257);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 14716, 15257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 15160, 15242);

                    state.SpinWaitComplete(CompletionPart.FinishAsyncMethodChecks, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 14716, 15257);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 14586, 15268);

                int
                f_10269_14883_14924(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 14883, 14924);
                    return 0;
                }


                int
                f_10269_14964_15012(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    this_param.CompleteAsyncMethodChecksBetweenStartAndFinish();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 14964, 15012);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 14586, 15268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 14586, 15268);
            }
        }

        protected abstract void CompleteAsyncMethodChecksBetweenStartAndFinish();

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 15456, 15487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 15462, 15485);

                    return _typeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 15456, 15487);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 15365, 15498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 15365, 15498);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 15585, 15658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 15621, 15643);

                    return this.locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 15585, 15658);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 15510, 15669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 15510, 15669);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 15749, 16096);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 15785, 16024) || true) && (f_10269_15789_15815_M(!_lazyParameters.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 15785, 16024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 15857, 15893);

                        int
                        result = _lazyParameters.Length
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 15915, 15969);

                        f_10269_15915_15968(result == f_10269_15938_15967(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 15991, 16005);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 15785, 16024);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 16044, 16081);

                    return f_10269_16051_16080(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 15749, 16096);

                    bool
                    f_10269_15789_15815_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 15789, 15815);
                        return return_v;
                    }


                    int
                    f_10269_15938_15967(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetParameterCountFromSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 15938, 15967);
                        return return_v;
                    }


                    int
                    f_10269_15915_15968(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 15915, 15968);
                        return 0;
                    }


                    int
                    f_10269_16051_16080(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetParameterCountFromSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 16051, 16080);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 15681, 16107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 15681, 16107);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract int GetParameterCountFromSyntax();

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 16267, 16378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 16303, 16322);

                    f_10269_16303_16321(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 16340, 16363);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 16267, 16378);

                    int
                    f_10269_16303_16321(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 16303, 16321);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 16184, 16389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 16184, 16389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 16487, 16598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 16523, 16542);

                    f_10269_16523_16541(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 16560, 16583);

                    return _lazyReturnType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 16487, 16598);

                    int
                    f_10269_16523_16541(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 16523, 16541);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 16401, 16609);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 16401, 16609);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken));

        internal override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 16905, 17020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 16941, 17005);

                    return f_10269_16948_16958() == MethodKind.ExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 16905, 17020);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10269_16948_16958()
                    {
                        var return_v = MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 16948, 16958);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 16824, 17031);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 16824, 17031);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 17145, 17278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 17181, 17200);

                    f_10269_17181_17199(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 17218, 17263);

                    return _lazyExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 17145, 17278);

                    int
                    f_10269_17181_17199(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 17181, 17199);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 17043, 17289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 17043, 17289);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 17391, 17510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 17427, 17446);

                    f_10269_17427_17445(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 17464, 17495);

                    return _lazyRefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 17391, 17510);

                    int
                    f_10269_17427_17445(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                    this_param)
                    {
                        this_param.LazyMethodChecks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 17427, 17445);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 17301, 17521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 17301, 17521);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 17585, 17649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 17621, 17634);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 17585, 17649);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 17533, 17660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 17533, 17660);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract override SourceMemberMethodSymbol BoundAttributesSource { get; }

        internal abstract override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations();

        internal bool HasExplicitAccessModifier { get; }

        private (DeclarationModifiers mods, bool hasExplicitAccessMod) MakeModifiers(MethodKind methodKind, bool isPartial, bool hasBody, Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 17936, 21986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 18136, 18187);

                bool
                isInterface = f_10269_18155_18186(f_10269_18155_18174(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 18201, 18299);

                bool
                isExplicitInterfaceImplementation = methodKind == MethodKind.ExplicitInterfaceImplementation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 18313, 18457);

                var
                defaultAccess = (DynAbs.Tracing.TraceSender.Conditional_F1(10269, 18333, 18395) || ((isInterface && (DynAbs.Tracing.TraceSender.Expression_True(10269, 18333, 18357) && isPartial) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 18333, 18395) && !isExplicitInterfaceImplementation) && DynAbs.Tracing.TraceSender.Conditional_F2(10269, 18398, 18425)) || DynAbs.Tracing.TraceSender.Conditional_F3(10269, 18428, 18456))) ? DeclarationModifiers.Public : DeclarationModifiers.Private
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 18532, 18614);

                var
                allowedModifiers = DeclarationModifiers.Partial | DeclarationModifiers.Unsafe
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 18628, 18700);

                var
                defaultInterfaceImplementationModifiers = DeclarationModifiers.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 18716, 20608) || true) && (!isExplicitInterfaceImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 18716, 20608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 18788, 19182);

                    allowedModifiers |= DeclarationModifiers.New |
                                                        DeclarationModifiers.Sealed |
                                                        DeclarationModifiers.Abstract |
                                                        DeclarationModifiers.Static |
                                                        DeclarationModifiers.Virtual |
                                                        DeclarationModifiers.AccessibilityMask;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 19202, 20394) || true) && (!isInterface)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 19202, 20394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 19260, 19310);

                        allowedModifiers |= DeclarationModifiers.Override;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 19202, 20394);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 19202, 20394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 19566, 19608);

                        defaultAccess = DeclarationModifiers.None;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 19632, 20375);

                        defaultInterfaceImplementationModifiers |= DeclarationModifiers.Sealed |
                                                                                       DeclarationModifiers.Abstract |
                                                                                       DeclarationModifiers.Static |
                                                                                       DeclarationModifiers.Virtual |
                                                                                       DeclarationModifiers.Extern |
                                                                                       DeclarationModifiers.Async |
                                                                                       DeclarationModifiers.Partial |
                                                                                       DeclarationModifiers.AccessibilityMask;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 19202, 20394);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 18716, 20608);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 18716, 20608);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 20428, 20608) || true) && (isInterface)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 20428, 20608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 20477, 20525);

                        f_10269_20477_20524(isExplicitInterfaceImplementation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 20543, 20593);

                        allowedModifiers |= DeclarationModifiers.Abstract;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 20428, 20608);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 18716, 20608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 20624, 20701);

                allowedModifiers |= DeclarationModifiers.Extern | DeclarationModifiers.Async;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 20717, 20849) || true) && (f_10269_20721_20750(f_10269_20721_20735()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 20717, 20849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 20784, 20834);

                    allowedModifiers |= DeclarationModifiers.ReadOnly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 20717, 20849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 21075, 21101);

                bool
                hasExplicitAccessMod
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 21115, 21199);

                DeclarationModifiers
                mods = f_10269_21143_21198(this, allowedModifiers, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 21213, 21481) || true) && ((mods & DeclarationModifiers.AccessibilityMask) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 21213, 21481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 21303, 21332);

                    hasExplicitAccessMod = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 21350, 21372);

                    mods |= defaultAccess;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 21213, 21481);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 21213, 21481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 21438, 21466);

                    hasExplicitAccessMod = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 21213, 21481);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 21497, 21541);

                f_10269_21497_21540(
                            this, mods, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 21557, 21842);

                f_10269_21557_21841(hasBody, mods, defaultInterfaceImplementationModifiers, location, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 21858, 21925);

                mods = f_10269_21865_21924(mods, isInterface, methodKind, hasBody);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 21939, 21975);

                return (mods, hasExplicitAccessMod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 17936, 21986);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_18155_18174(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 18155, 18174);
                    return return_v;
                }


                bool
                f_10269_18155_18186(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 18155, 18186);
                    return return_v;
                }


                int
                f_10269_20477_20524(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 20477, 20524);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_20721_20735()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 20721, 20735);
                    return return_v;
                }


                bool
                f_10269_20721_20750(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 20721, 20750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10269_21143_21198(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                allowedModifiers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeDeclarationModifiers(allowedModifiers, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 21143, 21198);
                    return return_v;
                }


                int
                f_10269_21497_21540(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                symbol, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    symbol.CheckUnsafeModifier(modifiers, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 21497, 21540);
                    return 0;
                }


                int
                f_10269_21557_21841(bool
                hasBody, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                defaultInterfaceImplementationModifiers, Microsoft.CodeAnalysis.Location
                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ModifierUtils.ReportDefaultInterfaceImplementationModifiers(hasBody, modifiers, defaultInterfaceImplementationModifiers, errorLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 21557, 21841);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10269_21865_21924(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                mods, bool
                containingTypeIsInterface, Microsoft.CodeAnalysis.MethodKind
                methodKind, bool
                hasBody)
                {
                    var return_v = AddImpliedModifiers(mods, containingTypeIsInterface, methodKind, hasBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 21865, 21924);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 17936, 21986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 17936, 21986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract DeclarationModifiers MakeDeclarationModifiers(DeclarationModifiers allowedModifiers, DiagnosticBag diagnostics);

        private static DeclarationModifiers AddImpliedModifiers(DeclarationModifiers mods, bool containingTypeIsInterface, MethodKind methodKind, bool hasBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10269, 22141, 23051);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 22517, 23014) || true) && (containingTypeIsInterface)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 22517, 23014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 22580, 22784);

                    mods = f_10269_22587_22783(mods, hasBody, methodKind == MethodKind.ExplicitInterfaceImplementation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 22517, 23014);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 22517, 23014);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 22818, 23014) || true) && (methodKind == MethodKind.ExplicitInterfaceImplementation)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 22818, 23014);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 22912, 22999);

                        mods = (mods & ~DeclarationModifiers.AccessibilityMask) | DeclarationModifiers.Private;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 22818, 23014);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 22517, 23014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 23028, 23040);

                return mods;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10269, 22141, 23051);

                Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                f_10269_22587_22783(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                mods, bool
                hasBody, bool
                isExplicitInterfaceImplementation)
                {
                    var return_v = ModifierUtils.AdjustModifiersForAnInterfaceMember(mods, hasBody, isExplicitInterfaceImplementation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 22587, 22783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 22141, 23051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 22141, 23051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const DeclarationModifiers
        PartialMethodExtendedModifierMask =
                    DeclarationModifiers.Virtual |
                    DeclarationModifiers.Override |
                    DeclarationModifiers.New |
                    DeclarationModifiers.Sealed |
                    DeclarationModifiers.Extern
        ;

        internal bool HasExtendedPartialModifier
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 23400, 23466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 23403, 23466);
                    return (DeclarationModifiers & PartialMethodExtendedModifierMask) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 23400, 23466);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 23400, 23466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 23400, 23466);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void CheckModifiers(bool isExplicitInterfaceImplementation, bool isVararg, bool hasBody, Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 23479, 29806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 23646, 23762);

                bool
                isExplicitInterfaceImplementationInInterface = isExplicitInterfaceImplementation && (DynAbs.Tracing.TraceSender.Expression_True(10269, 23698, 23761) && f_10269_23735_23761(f_10269_23735_23749()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 23778, 23981) || true) && (f_10269_23782_23791() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 23782, 23820) && f_10269_23795_23820()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 23778, 23981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 23854, 23966);

                    f_10269_23854_23965(f_10269_23886_23896(), MessageID.IDS_FeatureExtendedPartialMethods, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 23778, 23981);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 23997, 29795) || true) && (f_10269_24001_24010() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 24001, 24024) && f_10269_24014_24024()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 23997, 29795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 24058, 24128);

                    f_10269_24058_24127(diagnostics, ErrorCode.ERR_PartialMethodInvalidModifier, location);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 23997, 29795);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 23997, 29795);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 24162, 29795) || true) && (f_10269_24166_24175() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 24166, 24205) && f_10269_24179_24205_M(!HasExplicitAccessModifier)) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 24166, 24221) && f_10269_24209_24221_M(!ReturnsVoid)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 24162, 29795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 24255, 24351);

                        f_10269_24255_24350(diagnostics, ErrorCode.ERR_PartialMethodWithNonVoidReturnMustHaveAccessMods, location, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 24162, 29795);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 24162, 29795);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 24385, 29795) || true) && (f_10269_24389_24398() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 24389, 24428) && f_10269_24402_24428_M(!HasExplicitAccessModifier)) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 24389, 24458) && f_10269_24432_24458()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 24385, 29795);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 24492, 24586);

                            f_10269_24492_24585(diagnostics, ErrorCode.ERR_PartialMethodWithExtendedModMustHaveAccessMods, location, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 24385, 29795);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 24385, 29795);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 24620, 29795) || true) && (f_10269_24624_24633() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 24624, 24663) && f_10269_24637_24663_M(!HasExplicitAccessModifier)) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 24624, 24712) && f_10269_24667_24677().Any(p => p.RefKind == RefKind.Out)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 24620, 29795);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 24746, 24837);

                                f_10269_24746_24836(diagnostics, ErrorCode.ERR_PartialMethodWithOutParamMustHaveAccessMods, location, this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 24620, 29795);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 24620, 29795);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 24871, 29795) || true) && (f_10269_24875_24901(this) == Accessibility.Private && (DynAbs.Tracing.TraceSender.Expression_True(10269, 24875, 25020) && (f_10269_24931_24940() || (DynAbs.Tracing.TraceSender.Expression_False(10269, 24931, 25005) || (f_10269_24945_24955() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 24945, 25004) && !isExplicitInterfaceImplementationInInterface))) || (DynAbs.Tracing.TraceSender.Expression_False(10269, 24931, 25019) || f_10269_25009_25019()))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 24871, 29795);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 25054, 25116);

                                    f_10269_25054_25115(diagnostics, ErrorCode.ERR_VirtualPrivate, location, this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 24871, 29795);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 24871, 29795);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 25150, 29795) || true) && (f_10269_25154_25162() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 25154, 25205) && (f_10269_25167_25177() || (DynAbs.Tracing.TraceSender.Expression_False(10269, 25167, 25190) || f_10269_25181_25190()) || (DynAbs.Tracing.TraceSender.Expression_False(10269, 25167, 25204) || f_10269_25194_25204()))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 25150, 29795);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 25332, 25396);

                                        f_10269_25332_25395(                // A static member '{0}' cannot be marked as override, virtual, or abstract
                                                        diagnostics, ErrorCode.ERR_StaticNotVirtual, location, this);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 25150, 29795);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 25150, 29795);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 25430, 29795) || true) && (f_10269_25434_25444() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 25434, 25468) && (f_10269_25449_25454() || (DynAbs.Tracing.TraceSender.Expression_False(10269, 25449, 25467) || f_10269_25458_25467()))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 25430, 29795);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 25591, 25653);

                                            f_10269_25591_25652(                // A member '{0}' marked as override cannot be marked as new or virtual
                                                            diagnostics, ErrorCode.ERR_OverrideNotNew, location, this);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 25430, 29795);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 25430, 29795);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 25687, 29795) || true) && (f_10269_25691_25699() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 25691, 25714) && f_10269_25703_25714_M(!IsOverride)) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 25691, 25779) && !(isExplicitInterfaceImplementationInInterface && (DynAbs.Tracing.TraceSender.Expression_True(10269, 25720, 25778) && f_10269_25768_25778()))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 25687, 29795);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 25886, 25951);

                                                f_10269_25886_25950(                // '{0}' cannot be sealed because it is not an override
                                                                diagnostics, ErrorCode.ERR_SealedNonOverride, location, this);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 25687, 29795);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 25687, 29795);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 25985, 29795) || true) && (f_10269_25989_25997() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 25989, 26043) && f_10269_26001_26024(f_10269_26001_26015()) == TypeKind.Struct))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 25985, 29795);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 26143, 26245);

                                                    f_10269_26143_26244(                // The modifier '{0}' is not valid for this item
                                                                    diagnostics, ErrorCode.ERR_BadMemberFlag, location, f_10269_26198_26243(SyntaxKind.SealedKeyword));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 25985, 29795);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 25985, 29795);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 26279, 29795) || true) && (_lazyReturnType.IsStatic)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 26279, 29795);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 26412, 26531);

                                                        f_10269_26412_26530(                // '{0}': static types cannot be used as return types
                                                                        diagnostics, f_10269_26428_26497(f_10269_26464_26496(f_10269_26464_26478())), location, _lazyReturnType.Type);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 26279, 29795);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 26279, 29795);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 26565, 29795) || true) && (f_10269_26569_26579() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 26569, 26591) && f_10269_26583_26591()))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 26565, 29795);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 26625, 26690);

                                                            f_10269_26625_26689(diagnostics, ErrorCode.ERR_AbstractAndExtern, location, this);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 26565, 29795);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 26565, 29795);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 26724, 29795) || true) && (f_10269_26728_26738() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 26728, 26750) && f_10269_26742_26750()) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 26728, 26799) && !isExplicitInterfaceImplementationInInterface))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 26724, 29795);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 26833, 26898);

                                                                f_10269_26833_26897(diagnostics, ErrorCode.ERR_AbstractAndSealed, location, this);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 26724, 29795);
                                                            }

                                                            else
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 26724, 29795);

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 26932, 29795) || true) && (f_10269_26936_26946() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 26936, 26959) && f_10269_26950_26959()))
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 26932, 29795);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 26993, 27081);

                                                                    f_10269_26993_27080(diagnostics, ErrorCode.ERR_AbstractNotVirtual, location, f_10269_27053_27073(f_10269_27053_27062(this)), this);
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 26932, 29795);
                                                                }

                                                                else
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 26932, 29795);

                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 27115, 29795) || true) && (f_10269_27119_27129() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 27119, 27175) && f_10269_27133_27156(f_10269_27133_27147()) == TypeKind.Struct))
                                                                    )

                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 27115, 29795);
                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 27275, 27379);

                                                                        f_10269_27275_27378(                // The modifier '{0}' is not valid for this item
                                                                                        diagnostics, ErrorCode.ERR_BadMemberFlag, location, f_10269_27330_27377(SyntaxKind.AbstractKeyword));
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 27115, 29795);
                                                                    }

                                                                    else
                                                                    {
                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 27115, 29795);

                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 27413, 29795) || true) && (f_10269_27417_27426() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 27417, 27472) && f_10269_27430_27453(f_10269_27430_27444()) == TypeKind.Struct))
                                                                        )

                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 27413, 29795);
                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 27572, 27675);

                                                                            f_10269_27572_27674(                // The modifier '{0}' is not valid for this item
                                                                                            diagnostics, ErrorCode.ERR_BadMemberFlag, location, f_10269_27627_27673(SyntaxKind.VirtualKeyword));
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 27413, 29795);
                                                                        }

                                                                        else
                                                                        {
                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 27413, 29795);

                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 27709, 29795) || true) && (f_10269_27713_27721() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 27713, 27743) && f_10269_27725_27743()))
                                                                            )

                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 27709, 29795);
                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 27846, 27920);

                                                                                f_10269_27846_27919(                // Static member '{0}' cannot be marked 'readonly'.
                                                                                                diagnostics, ErrorCode.ERR_StaticMemberCantBeReadOnly, location, this);
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 27709, 29795);
                                                                            }

                                                                            else
                                                                            {
                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 27709, 29795);

                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 27954, 29795) || true) && (f_10269_27958_27968() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 27958, 27998) && f_10269_27972_27998_M(!f_10269_27973_27987().IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 27958, 28095) && (f_10269_28003_28026(f_10269_28003_28017()) == TypeKind.Class || (DynAbs.Tracing.TraceSender.Expression_False(10269, 28003, 28094) || f_10269_28048_28071(f_10269_28048_28062()) == TypeKind.Submission))))
                                                                                )

                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 27954, 29795);
                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 28214, 28301);

                                                                                    f_10269_28214_28300(                // '{0}' is abstract but it is contained in non-abstract type '{1}'
                                                                                                    diagnostics, ErrorCode.ERR_AbstractInConcreteClass, location, this, f_10269_28285_28299());
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 27954, 29795);
                                                                                }

                                                                                else
                                                                                {
                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 27954, 29795);

                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 28335, 29795) || true) && (f_10269_28339_28348() && (DynAbs.Tracing.TraceSender.Expression_True(10269, 28339, 28375) && f_10269_28352_28375(f_10269_28352_28366())))
                                                                                    )

                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 28335, 29795);
                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 28480, 28562);

                                                                                        f_10269_28480_28561(                // '{0}' is a new virtual member in sealed type '{1}'
                                                                                                        diagnostics, ErrorCode.ERR_NewVirtualInSealed, location, this, f_10269_28546_28560());
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 28335, 29795);
                                                                                    }

                                                                                    else
                                                                                    {
                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 28335, 29795);

                                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 28596, 29795) || true) && (!hasBody && (DynAbs.Tracing.TraceSender.Expression_True(10269, 28600, 28619) && f_10269_28612_28619()))
                                                                                        )

                                                                                        {
                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 28596, 29795);
                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 28653, 28712);

                                                                                            f_10269_28653_28711(diagnostics, ErrorCode.ERR_BadAsyncLacksBody, location);
                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 28596, 29795);
                                                                                        }

                                                                                        else
                                                                                        {
                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 28596, 29795);

                                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 28746, 29795) || true) && (!hasBody && (DynAbs.Tracing.TraceSender.Expression_True(10269, 28750, 28771) && f_10269_28762_28771_M(!IsExtern)) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 28750, 28786) && f_10269_28775_28786_M(!IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 28750, 28800) && f_10269_28790_28800_M(!IsPartial)) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 28750, 28823) && f_10269_28804_28823_M(!IsExpressionBodied)))
                                                                                            )

                                                                                            {
                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 28746, 29795);
                                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 28857, 28924);

                                                                                                f_10269_28857_28923(diagnostics, ErrorCode.ERR_ConcreteMissingBody, location, this);
                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 28746, 29795);
                                                                                            }

                                                                                            else
                                                                                            {
                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 28746, 29795);

                                                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 28958, 29795) || true) && (f_10269_28962_28985(f_10269_28962_28976()) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 28962, 29030) && f_10269_28989_29030(f_10269_28989_29015(this))) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 28962, 29050) && f_10269_29034_29050_M(!this.IsOverride)))
                                                                                                )

                                                                                                {
                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 28958, 29795);
                                                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 29084, 29181);

                                                                                                    f_10269_29084_29180(diagnostics, f_10269_29100_29163(f_10269_29148_29162()), location, this);
                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 28958, 29795);
                                                                                                }

                                                                                                else
                                                                                                {
                                                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 28958, 29795);

                                                                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 29215, 29795) || true) && (f_10269_29219_29242(f_10269_29219_29233()) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 29219, 29255) && f_10269_29246_29255_M(!IsStatic)))
                                                                                                    )

                                                                                                    {
                                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 29215, 29795);
                                                                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 29289, 29364);

                                                                                                        f_10269_29289_29363(diagnostics, ErrorCode.ERR_InstanceMemberInStaticClass, location, f_10269_29358_29362());
                                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 29215, 29795);
                                                                                                    }

                                                                                                    else
                                                                                                    {
                                                                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 29215, 29795);

                                                                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 29398, 29795) || true) && (isVararg && (DynAbs.Tracing.TraceSender.Expression_True(10269, 29402, 29549) && (f_10269_29415_29430() || (DynAbs.Tracing.TraceSender.Expression_False(10269, 29415, 29462) || f_10269_29434_29462(f_10269_29434_29448())) || (DynAbs.Tracing.TraceSender.Expression_False(10269, 29415, 29548) || _lazyParameters.Length > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10269, 29466, 29548) && f_10269_29496_29548(_lazyParameters[_lazyParameters.Length - 1]))))))
                                                                                                        )

                                                                                                        {
                                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 29398, 29795);
                                                                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 29583, 29635);

                                                                                                            f_10269_29583_29634(diagnostics, ErrorCode.ERR_BadVarargs, location);
                                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 29398, 29795);
                                                                                                        }

                                                                                                        else
                                                                                                        {
                                                                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 29398, 29795);

                                                                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 29669, 29795) || true) && (isVararg && (DynAbs.Tracing.TraceSender.Expression_True(10269, 29673, 29692) && f_10269_29685_29692()))
                                                                                                            )

                                                                                                            {
                                                                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 29669, 29795);
                                                                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 29726, 29780);

                                                                                                                f_10269_29726_29779(diagnostics, ErrorCode.ERR_VarargsAsync, location);
                                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 29669, 29795);
                                                                                                            }
                                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 29398, 29795);
                                                                                                        }
                                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 29215, 29795);
                                                                                                    }
                                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 28958, 29795);
                                                                                                }
                                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 28746, 29795);
                                                                                            }
                                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 28596, 29795);
                                                                                        }
                                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 28335, 29795);
                                                                                    }
                                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 27954, 29795);
                                                                                }
                                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 27709, 29795);
                                                                            }
                                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 27413, 29795);
                                                                        }
                                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 27115, 29795);
                                                                    }
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 26932, 29795);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 26724, 29795);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 26565, 29795);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 26279, 29795);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 25985, 29795);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 25687, 29795);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 25430, 29795);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 25150, 29795);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 24871, 29795);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 24620, 29795);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 24385, 29795);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 24162, 29795);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 23997, 29795);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 23479, 29806);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_23735_23749()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 23735, 23749);
                    return return_v;
                }


                bool
                f_10269_23735_23761(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 23735, 23761);
                    return return_v;
                }


                bool
                f_10269_23782_23791()
                {
                    var return_v = IsPartial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 23782, 23791);
                    return return_v;
                }


                bool
                f_10269_23795_23820()
                {
                    var return_v = HasExplicitAccessModifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 23795, 23820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10269_23886_23896()
                {
                    var return_v = SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 23886, 23896);
                    return return_v;
                }


                bool
                f_10269_23854_23965(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 23854, 23965);
                    return return_v;
                }


                bool
                f_10269_24001_24010()
                {
                    var return_v = IsPartial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24001, 24010);
                    return return_v;
                }


                bool
                f_10269_24014_24024()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24014, 24024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_24058_24127(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 24058, 24127);
                    return return_v;
                }


                bool
                f_10269_24166_24175()
                {
                    var return_v = IsPartial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24166, 24175);
                    return return_v;
                }


                bool
                f_10269_24179_24205_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24179, 24205);
                    return return_v;
                }


                bool
                f_10269_24209_24221_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24209, 24221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_24255_24350(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 24255, 24350);
                    return return_v;
                }


                bool
                f_10269_24389_24398()
                {
                    var return_v = IsPartial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24389, 24398);
                    return return_v;
                }


                bool
                f_10269_24402_24428_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24402, 24428);
                    return return_v;
                }


                bool
                f_10269_24432_24458()
                {
                    var return_v = HasExtendedPartialModifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24432, 24458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_24492_24585(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 24492, 24585);
                    return return_v;
                }


                bool
                f_10269_24624_24633()
                {
                    var return_v = IsPartial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24624, 24633);
                    return return_v;
                }


                bool
                f_10269_24637_24663_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24637, 24663);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10269_24667_24677()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24667, 24677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_24746_24836(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 24746, 24836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10269_24875_24901(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24875, 24901);
                    return return_v;
                }


                bool
                f_10269_24931_24940()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24931, 24940);
                    return return_v;
                }


                bool
                f_10269_24945_24955()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 24945, 24955);
                    return return_v;
                }


                bool
                f_10269_25009_25019()
                {
                    var return_v = IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25009, 25019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_25054_25115(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 25054, 25115);
                    return return_v;
                }


                bool
                f_10269_25154_25162()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25154, 25162);
                    return return_v;
                }


                bool
                f_10269_25167_25177()
                {
                    var return_v = IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25167, 25177);
                    return return_v;
                }


                bool
                f_10269_25181_25190()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25181, 25190);
                    return return_v;
                }


                bool
                f_10269_25194_25204()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25194, 25204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_25332_25395(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 25332, 25395);
                    return return_v;
                }


                bool
                f_10269_25434_25444()
                {
                    var return_v = IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25434, 25444);
                    return return_v;
                }


                bool
                f_10269_25449_25454()
                {
                    var return_v = IsNew;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25449, 25454);
                    return return_v;
                }


                bool
                f_10269_25458_25467()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25458, 25467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_25591_25652(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 25591, 25652);
                    return return_v;
                }


                bool
                f_10269_25691_25699()
                {
                    var return_v = IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25691, 25699);
                    return return_v;
                }


                bool
                f_10269_25703_25714_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25703, 25714);
                    return return_v;
                }


                bool
                f_10269_25768_25778()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25768, 25778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_25886_25950(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 25886, 25950);
                    return return_v;
                }


                bool
                f_10269_25989_25997()
                {
                    var return_v = IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 25989, 25997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_26001_26015()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 26001, 26015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10269_26001_26024(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 26001, 26024);
                    return return_v;
                }


                string
                f_10269_26198_26243(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 26198, 26243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_26143_26244(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 26143, 26244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_26464_26478()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 26464, 26478);
                    return return_v;
                }


                bool
                f_10269_26464_26496(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 26464, 26496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10269_26428_26497(bool
                useWarning)
                {
                    var return_v = ErrorFacts.GetStaticClassReturnCode(useWarning);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 26428, 26497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_26412_26530(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 26412, 26530);
                    return return_v;
                }


                bool
                f_10269_26569_26579()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 26569, 26579);
                    return return_v;
                }


                bool
                f_10269_26583_26591()
                {
                    var return_v = IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 26583, 26591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_26625_26689(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 26625, 26689);
                    return return_v;
                }


                bool
                f_10269_26728_26738()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 26728, 26738);
                    return return_v;
                }


                bool
                f_10269_26742_26750()
                {
                    var return_v = IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 26742, 26750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_26833_26897(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 26833, 26897);
                    return return_v;
                }


                bool
                f_10269_26936_26946()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 26936, 26946);
                    return return_v;
                }


                bool
                f_10269_26950_26959()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 26950, 26959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10269_27053_27062(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27053, 27062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10269_27053_27073(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 27053, 27073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_26993_27080(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 26993, 27080);
                    return return_v;
                }


                bool
                f_10269_27119_27129()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27119, 27129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_27133_27147()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27133, 27147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10269_27133_27156(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27133, 27156);
                    return return_v;
                }


                string
                f_10269_27330_27377(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 27330, 27377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_27275_27378(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 27275, 27378);
                    return return_v;
                }


                bool
                f_10269_27417_27426()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27417, 27426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_27430_27444()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27430, 27444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10269_27430_27453(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27430, 27453);
                    return return_v;
                }


                string
                f_10269_27627_27673(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 27627, 27673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_27572_27674(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 27572, 27674);
                    return return_v;
                }


                bool
                f_10269_27713_27721()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27713, 27721);
                    return return_v;
                }


                bool
                f_10269_27725_27743()
                {
                    var return_v = IsDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27725, 27743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_27846_27919(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 27846, 27919);
                    return return_v;
                }


                bool
                f_10269_27958_27968()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27958, 27968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_27973_27987()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27973, 27987);
                    return return_v;
                }


                bool
                f_10269_27972_27998_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 27972, 27998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_28003_28017()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28003, 28017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10269_28003_28026(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28003, 28026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_28048_28062()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28048, 28062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10269_28048_28071(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28048, 28071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_28285_28299()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28285, 28299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_28214_28300(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 28214, 28300);
                    return return_v;
                }


                bool
                f_10269_28339_28348()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28339, 28348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_28352_28366()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28352, 28366);
                    return return_v;
                }


                bool
                f_10269_28352_28375(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28352, 28375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_28546_28560()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28546, 28560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_28480_28561(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 28480, 28561);
                    return return_v;
                }


                bool
                f_10269_28612_28619()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28612, 28619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_28653_28711(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 28653, 28711);
                    return return_v;
                }


                bool
                f_10269_28762_28771_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28762, 28771);
                    return return_v;
                }


                bool
                f_10269_28775_28786_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28775, 28786);
                    return return_v;
                }


                bool
                f_10269_28790_28800_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28790, 28800);
                    return return_v;
                }


                bool
                f_10269_28804_28823_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28804, 28823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_28857_28923(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 28857, 28923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_28962_28976()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28962, 28976);
                    return return_v;
                }


                bool
                f_10269_28962_28985(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28962, 28985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10269_28989_29015(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 28989, 29015);
                    return return_v;
                }


                bool
                f_10269_28989_29030(Microsoft.CodeAnalysis.Accessibility
                accessibility)
                {
                    var return_v = accessibility.HasProtected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 28989, 29030);
                    return return_v;
                }


                bool
                f_10269_29034_29050_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29034, 29050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_29148_29162()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29148, 29162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10269_29100_29163(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType)
                {
                    var return_v = AccessCheck.GetProtectedMemberInSealedTypeError(containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 29100, 29163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_29084_29180(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 29084, 29180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_29219_29233()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29219, 29233);
                    return return_v;
                }


                bool
                f_10269_29219_29242(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29219, 29242);
                    return return_v;
                }


                bool
                f_10269_29246_29255_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29246, 29255);
                    return return_v;
                }


                string
                f_10269_29358_29362()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29358, 29362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_29289_29363(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 29289, 29363);
                    return return_v;
                }


                bool
                f_10269_29415_29430()
                {
                    var return_v = IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29415, 29430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10269_29434_29448()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29434, 29448);
                    return return_v;
                }


                bool
                f_10269_29434_29462(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29434, 29462);
                    return return_v;
                }


                bool
                f_10269_29496_29548(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29496, 29548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_29583_29634(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 29583, 29634);
                    return return_v;
                }


                bool
                f_10269_29685_29692()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 29685, 29692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10269_29726_29779(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 29726, 29779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 23479, 29806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 23479, 29806);
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 29818, 30545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 29976, 30037);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10269, 29976, 30036);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 29976, 30036);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 30053, 30534) || true) && (f_10269_30057_30079(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 30053, 30534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 30283, 30327);

                    var
                    compilation = f_10269_30301_30326(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 30347, 30519);

                    f_10269_30347_30518(ref attributes, f_10269_30387_30517(compilation, WellKnownMember.System_Runtime_CompilerServices_ExtensionAttribute__ctor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 30053, 30534);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 29818, 30545);

                bool
                f_10269_30057_30079(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 30057, 30079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10269_30301_30326(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 30301, 30326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10269_30387_30517(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 30387, 30517);
                    return return_v;
                }


                int
                f_10269_30347_30518(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 30347, 30518);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 29818, 30545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 29818, 30545);
            }
        }

        internal override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10269, 30557, 32656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 30689, 30749);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AfterAddingTypeMembersChecks(conversions, diagnostics), 10269, 30689, 30748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 30765, 30799);

                var
                location = f_10269_30780_30798()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 30813, 30852);

                var
                compilation = f_10269_30831_30851()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 30868, 30899);

                f_10269_30868_30898(location != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 31176, 31243);

                f_10269_31176_31242(this, conversions, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 31259, 31353);

                f_10269_31259_31352(f_10269_31259_31274(this), compilation, conversions, f_10269_31321_31335(this)[0], diagnostics);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 31369, 31557);
                    foreach (var parameter in f_10269_31395_31410_I(f_10269_31395_31410(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 31369, 31557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 31444, 31542);

                        f_10269_31444_31541(f_10269_31444_31458(parameter), compilation, conversions, f_10269_31505_31524(parameter)[0], diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 31369, 31557);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10269, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10269, 1, 189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 31573, 31606);

                f_10269_31573_31605(this, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 31622, 31797) || true) && (f_10269_31626_31633() == RefKind.RefReadOnly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 31622, 31797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 31690, 31782);

                    f_10269_31690_31781(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 31622, 31797);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 31813, 31925);

                f_10269_31813_31924(compilation, f_10269_31875_31885(), diagnostics, modifyCompilation: true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 31941, 32123) || true) && (f_10269_31945_31979(f_10269_31945_31955()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 31941, 32123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 32013, 32108);

                    f_10269_32013_32107(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 31941, 32123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 32139, 32254);

                f_10269_32139_32253(compilation, f_10269_32204_32214(), diagnostics, modifyCompilation: true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 32270, 32513) || true) && (f_10269_32274_32320(compilation, this) && (DynAbs.Tracing.TraceSender.Expression_True(10269, 32274, 32374) && f_10269_32324_32349().NeedsNullableAttribute()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10269, 32270, 32513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 32408, 32498);

                    f_10269_32408_32497(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10269, 32270, 32513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 32529, 32645);

                f_10269_32529_32644(compilation, this, f_10269_32595_32605(), diagnostics, modifyCompilation: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10269, 30557, 32656);

                Microsoft.CodeAnalysis.Location
                f_10269_30780_30798()
                {
                    var return_v = ReturnTypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 30780, 30798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10269_30831_30851()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 30831, 30851);
                    return return_v;
                }


                int
                f_10269_30868_30898(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 30868, 30898);
                    return 0;
                }


                int
                f_10269_31176_31242(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckConstraintsForExplicitInterfaceType(conversions, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 31176, 31242);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10269_31259_31274(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 31259, 31274);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10269_31321_31335(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 31321, 31335);
                    return return_v;
                }


                int
                f_10269_31259_31352(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 31259, 31352);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10269_31395_31410(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 31395, 31410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10269_31444_31458(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 31444, 31458);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10269_31505_31524(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 31505, 31524);
                    return return_v;
                }


                int
                f_10269_31444_31541(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, conversions, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 31444, 31541);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10269_31395_31410_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 31395, 31410);
                    return return_v;
                }


                int
                f_10269_31573_31605(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.PartialMethodChecks(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 31573, 31605);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10269_31626_31633()
                {
                    var return_v = RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 31626, 31633);
                    return return_v;
                }


                int
                f_10269_31690_31781(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureIsReadOnlyAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 31690, 31781);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10269_31875_31885()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 31875, 31885);
                    return return_v;
                }


                int
                f_10269_31813_31924(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureIsReadOnlyAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 31813, 31924);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10269_31945_31955()
                {
                    var return_v = ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 31945, 31955);
                    return return_v;
                }


                bool
                f_10269_31945_31979(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 31945, 31979);
                    return return_v;
                }


                int
                f_10269_32013_32107(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNativeIntegerAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 32013, 32107);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10269_32204_32214()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 32204, 32214);
                    return return_v;
                }


                int
                f_10269_32139_32253(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNativeIntegerAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 32139, 32253);
                    return 0;
                }


                bool
                f_10269_32274_32320(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 32274, 32320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10269_32324_32349()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 32324, 32349);
                    return return_v;
                }


                int
                f_10269_32408_32497(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNullableAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 32408, 32497);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10269_32595_32605()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 32595, 32605);
                    return return_v;
                }


                int
                f_10269_32529_32644(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
                container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNullableAttributeExists(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)container, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 32529, 32644);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10269, 30557, 32656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 30557, 32656);
            }
        }

        protected abstract void CheckConstraintsForExplicitInterfaceType(ConversionsBase conversions, DiagnosticBag diagnostics);

        protected abstract void PartialMethodChecks(DiagnosticBag diagnostics);

        static SourceOrdinaryMethodSymbolBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10269, 818, 32879);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10269, 23098, 23346);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10269, 818, 32879);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10269, 818, 32879);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10269, 818, 32879);

        static Microsoft.CodeAnalysis.SyntaxReference
        f_10269_1798_1819(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 1798, 1819);
            return return_v;
        }


        bool
        f_10269_2337_2362()
        {
            var return_v = HasExplicitAccessModifier;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10269, 2337, 2362);
            return return_v;
        }


        (Microsoft.CodeAnalysis.CSharp.DeclarationModifiers mods, bool hasExplicitAccessMod)
        f_10269_2366_2439(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, bool
        isPartial, bool
        hasBody, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = this_param.MakeModifiers(methodKind, isPartial, hasBody, location, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 2366, 2439);
            return return_v;
        }


        int
        f_10269_2619_2844(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        declarationModifiers, bool
        returnsVoid, bool
        isExtensionMethod, bool
        isNullableAnalysisEnabled, bool
        isMetadataVirtualIgnoringModifiers)
        {
            this_param.MakeFlags(methodKind, declarationModifiers, returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled, isMetadataVirtualIgnoringModifiers: isMetadataVirtualIgnoringModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 2619, 2844);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10269_2879_2918(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        node, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = this_param.MakeTypeParameters(node, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 2879, 2918);
            return return_v;
        }


        int
        f_10269_2935_3016(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        declarationSyntax, Microsoft.CodeAnalysis.Location
        location, bool
        hasBody, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckFeatureAvailabilityAndRuntimeSupport((Microsoft.CodeAnalysis.SyntaxNode)declarationSyntax, location, hasBody, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 2935, 3016);
            return 0;
        }


        int
        f_10269_3078_3122(Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
        this_param, Microsoft.CodeAnalysis.Location
        location, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            this_param.CheckModifiersForBody(location, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 3078, 3122);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10269_3165_3323(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        modifiers, Microsoft.CodeAnalysis.CSharp.Symbols.SourceOrdinaryMethodSymbolBase
        symbol, bool
        isExplicitInterfaceImplementation)
        {
            var return_v = ModifierUtils.CheckAccessibility(modifiers, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, isExplicitInterfaceImplementation: isExplicitInterfaceImplementation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 3165, 3323);
            return return_v;
        }


        int
        f_10269_3388_3419(Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        info, Microsoft.CodeAnalysis.Location
        location)
        {
            diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10269, 3388, 3419);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10269_1764_1778_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10269, 1317, 3446);
            return return_v;
        }

    }
}
