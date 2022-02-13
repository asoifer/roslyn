// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourcePropertySymbolBase : PropertySymbol, IAttributeTargetSymbol
    {
        protected const string
        DefaultIndexerName = "Item"
        ;

        /// <summary>
        /// Condensed flags storing useful information about the <see cref="SourcePropertySymbolBase"/>
        /// so that we do not have to go back to source to compute this data.
        /// </summary>
        [Flags]
        private enum Flags : byte
        {
            IsExpressionBodied = 1 << 0,
            IsAutoProperty = 1 << 1,
            IsExplicitInterfaceImplementation = 1 << 2,
            HasInitializer = 1 << 3,
        }

        private readonly SourceMemberContainerTypeSymbol _containingType;

        private readonly string _name;

        private readonly SyntaxReference _syntaxRef;

        protected readonly DeclarationModifiers _modifiers;

        private ImmutableArray<CustomModifier> _lazyRefCustomModifiers;

        private readonly SourcePropertyAccessorSymbol? _getMethod;

        private readonly SourcePropertyAccessorSymbol? _setMethod;

        private readonly TypeSymbol _explicitInterfaceType;

        private ImmutableArray<PropertySymbol> _lazyExplicitInterfaceImplementations;

        private readonly Flags _propertyFlags;

        private readonly RefKind _refKind;

        private SymbolCompletionState _state;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        private TypeWithAnnotations.Boxed _lazyType;

        private string _lazySourceName;

        private string _lazyDocComment;

        private string _lazyExpandedDocComment;

        private OverriddenOrHiddenMembersResult _lazyOverriddenOrHiddenMembers;

        private SynthesizedSealedPropertyAccessor _lazySynthesizedSealedAccessor;

        private CustomAttributesBag<CSharpAttributeData> _lazyCustomAttributesBag;

        public Location Location { get; }

        protected SourcePropertySymbolBase(
                    SourceMemberContainerTypeSymbol containingType,
                    CSharpSyntaxNode syntax,
                    bool hasGetAccessor,
                    bool hasSetAccessor,
                    bool isExplicitInterfaceImplementation,
                    TypeSymbol? explicitInterfaceType,
                    string? aliasQualifierOpt,
                    DeclarationModifiers modifiers,
                    bool hasInitializer,
                    bool isAutoProperty,
                    bool isExpressionBodied,
                    bool isInitOnly,
                    RefKind refKind,
                    string memberName,
                    SyntaxList<AttributeListSyntax> indexerNameAttributeLists,
                    Location location,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10274, 2865, 6519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 1421, 1436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 1471, 1476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 1520, 1530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 1581, 1591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 1740, 1750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 1808, 1818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 1876, 1898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 2019, 2033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 2069, 2077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 2237, 2246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 2274, 2289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 2317, 2332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 2358, 2381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 2432, 2462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 2515, 2545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 2605, 2629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 2802, 2835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 26173, 26233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 3620, 3673);

                f_10274_3620_3672(!isExpressionBodied || (DynAbs.Tracing.TraceSender.Expression_False(10274, 3633, 3671) || !isAutoProperty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 3687, 3740);

                f_10274_3687_3739(!isExpressionBodied || (DynAbs.Tracing.TraceSender.Expression_False(10274, 3700, 3738) || !hasInitializer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 3756, 3791);

                _syntaxRef = f_10274_3769_3790(syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 3805, 3825);

                Location = location;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 3839, 3872);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 3886, 3905);

                _refKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 3919, 3942);

                _modifiers = modifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 3956, 4003);

                _explicitInterfaceType = explicitInterfaceType;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4019, 4306) || true) && (isExplicitInterfaceImplementation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 4019, 4306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4090, 4148);

                    _propertyFlags |= Flags.IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 4019, 4306);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 4019, 4306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4214, 4291);

                    _lazyExplicitInterfaceImplementations = ImmutableArray<PropertySymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 4019, 4306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4322, 4349);

                bool
                isIndexer = f_10274_4339_4348()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4363, 4483);

                isAutoProperty = isAutoProperty && (DynAbs.Tracing.TraceSender.Expression_True(10274, 4380, 4440) && !(f_10274_4400_4426(containingType) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 4400, 4439) && f_10274_4430_4439_M(!IsStatic)))) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 4380, 4455) && f_10274_4444_4455_M(!IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 4380, 4468) && f_10274_4459_4468_M(!IsExtern)) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 4380, 4482) && !isIndexer);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4499, 4605) || true) && (isAutoProperty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 4499, 4605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4551, 4590);

                    _propertyFlags |= Flags.IsAutoProperty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 4499, 4605);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4621, 4727) || true) && (hasInitializer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 4621, 4727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4673, 4712);

                    _propertyFlags |= Flags.HasInitializer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 4621, 4727);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4743, 4857) || true) && (isExpressionBodied)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 4743, 4857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4799, 4842);

                    _propertyFlags |= Flags.IsExpressionBodied;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 4743, 4857);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4873, 5474) || true) && (isIndexer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 4873, 5474);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 4920, 5216) || true) && (indexerNameAttributeLists.Count == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10274, 4924, 4997) || isExplicitInterfaceImplementation))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 4920, 5216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 5039, 5068);

                        _lazySourceName = memberName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 4920, 5216);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 4920, 5216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 5150, 5197);

                        f_10274_5150_5196(memberName == DefaultIndexerName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 4920, 5216);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 5236, 5356);

                    _name = f_10274_5244_5355(WellKnownMemberNames.Indexer, _explicitInterfaceType, aliasQualifierOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 4873, 5474);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 4873, 5474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 5422, 5459);

                    _name = _lazySourceName = memberName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 4873, 5474);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 5490, 6162) || true) && ((isAutoProperty && (DynAbs.Tracing.TraceSender.Expression_True(10274, 5495, 5527) && hasGetAccessor)) || (DynAbs.Tracing.TraceSender.Expression_False(10274, 5494, 5546) || hasInitializer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 5490, 6162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 5580, 5605);

                    f_10274_5580_5604(f_10274_5593_5603_M(!IsIndexer));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 5623, 5685);

                    string
                    fieldName = f_10274_5642_5684(_name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 5703, 6147);

                    BackingField = f_10274_5718_6146(this, fieldName, isReadOnly: (hasGetAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10274, 5924, 5957) && !hasSetAccessor)) || (DynAbs.Tracing.TraceSender.Expression_False(10274, 5923, 5972) || isInitOnly), f_10274_6045_6058(this), hasInitializer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 5490, 6162);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 6178, 6335) || true) && (hasGetAccessor)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 6178, 6335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 6230, 6320);

                    _getMethod = f_10274_6243_6319(this, isAutoPropertyAccessor: isAutoProperty, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 6178, 6335);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 6351, 6508) || true) && (hasSetAccessor)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 6351, 6508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 6403, 6493);

                    _setMethod = f_10274_6416_6492(this, isAutoPropertyAccessor: isAutoProperty, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 6351, 6508);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10274, 2865, 6519);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 2865, 6519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 2865, 6519);
            }
        }

        private void EnsureSignatureGuarded(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 6531, 11993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 6618, 6671);

                PropertySymbol?
                explicitlyImplementedProperty = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 6685, 6748);

                _lazyRefCustomModifiers = ImmutableArray<CustomModifier>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 6764, 6789);

                TypeWithAnnotations
                type
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 6803, 6868);

                (type, _lazyParameters) = f_10274_6829_6867(this, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 6882, 6930);

                _lazyType = f_10274_6894_6929(type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 8160, 8235);

                bool
                isExplicitInterfaceImplementation = f_10274_8201_8234()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 8249, 11624) || true) && (isExplicitInterfaceImplementation || (DynAbs.Tracing.TraceSender.Expression_False(10274, 8253, 8305) || f_10274_8290_8305(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 8249, 11624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 8339, 8363);

                    bool
                    isOverride = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 8381, 8429);

                    PropertySymbol?
                    overriddenOrImplementedProperty
                    = default(PropertySymbol?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 8449, 9695) || true) && (!isExplicitInterfaceImplementation)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 8449, 9695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 8913, 8931);

                        isOverride = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 8953, 9011);

                        overriddenOrImplementedProperty = f_10274_8987_9010(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 8449, 9695);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 8449, 9695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 9093, 9136);

                        CSharpSyntaxNode
                        syntax = f_10274_9119_9135()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 9158, 9289);

                        string
                        interfacePropertyName = (DynAbs.Tracing.TraceSender.Conditional_F1(10274, 9189, 9198) || ((f_10274_9189_9198() && DynAbs.Tracing.TraceSender.Conditional_F2(10274, 9201, 9229)) || DynAbs.Tracing.TraceSender.Conditional_F3(10274, 9232, 9288))) ? WellKnownMemberNames.Indexer : ((PropertyDeclarationSyntax)syntax).Identifier.ValueText
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 9311, 9475);

                        explicitlyImplementedProperty = f_10274_9343_9474(this, _explicitInterfaceType, interfacePropertyName, f_10274_9429_9460(this), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 9497, 9590);

                        f_10274_9497_9589(this, explicitlyImplementedProperty, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 9612, 9676);

                        overriddenOrImplementedProperty = explicitlyImplementedProperty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 8449, 9695);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 9715, 11237) || true) && ((object)overriddenOrImplementedProperty != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 9715, 11237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 9808, 9951);

                        _lazyRefCustomModifiers = (DynAbs.Tracing.TraceSender.Conditional_F1(10274, 9834, 9858) || ((_refKind != RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10274, 9861, 9911)) || DynAbs.Tracing.TraceSender.Conditional_F3(10274, 9914, 9950))) ? f_10274_9861_9911(overriddenOrImplementedProperty) : ImmutableArray<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 9975, 10072);

                        TypeWithAnnotations
                        overriddenPropertyType = f_10274_10020_10071(overriddenOrImplementedProperty)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 10433, 11030) || true) && (f_10274_10437_10639(type.Type, overriddenPropertyType.Type, TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes | TypeCompareKind.IgnoreDynamic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 10433, 11030);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 10689, 10931);

                            type = type.WithTypeAndModifiers(f_10274_10752_10860(overriddenPropertyType.Type, type.Type, f_10274_10836_10859(this)), overriddenPropertyType.CustomModifiers);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 10959, 11007);

                            _lazyType = f_10274_10971_11006(type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 10433, 11030);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 11054, 11218);

                        _lazyParameters = f_10274_11072_11217(f_10274_11121_11163(overriddenOrImplementedProperty), _lazyParameters, alsoCopyParamsModifier: isOverride);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 9715, 11237);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 8249, 11624);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 8249, 11624);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 11271, 11624) || true) && (_refKind == RefKind.RefReadOnly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 11271, 11624);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 11340, 11490);

                        var
                        modifierType = f_10274_11359_11489(f_10274_11383_11403(), WellKnownType.System_Runtime_InteropServices_InAttribute, diagnostics, f_10274_11476_11488())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 11510, 11609);

                        _lazyRefCustomModifiers = f_10274_11536_11608(f_10274_11558_11607(modifierType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 11271, 11624);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 8249, 11624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 11640, 11737);

                f_10274_11640_11736(isExplicitInterfaceImplementation || (DynAbs.Tracing.TraceSender.Expression_False(10274, 11653, 11735) || _lazyExplicitInterfaceImplementations.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 11751, 11982);

                _lazyExplicitInterfaceImplementations =
                (DynAbs.Tracing.TraceSender.Conditional_F1(10274, 11808, 11845) || ((explicitlyImplementedProperty is null && DynAbs.Tracing.TraceSender.Conditional_F2(10274, 11869, 11905)) || DynAbs.Tracing.TraceSender.Conditional_F3(10274, 11929, 11981))) ? ImmutableArray<PropertySymbol>.Empty : f_10274_11929_11981(explicitlyImplementedProperty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 6531, 11993);

                (Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations Type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol> Parameters)
                f_10274_6829_6867(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeParametersAndBindType(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 6829, 6867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                f_10274_6894_6929(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 6894, 6929);
                    return return_v;
                }


                bool
                f_10274_8201_8234()
                {
                    var return_v = IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 8201, 8234);
                    return return_v;
                }


                bool
                f_10274_8290_8305(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 8290, 8305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10274_8987_9010(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.OverriddenProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 8987, 9010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10274_9119_9135()
                {
                    var return_v = CSharpSyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 9119, 9135);
                    return return_v;
                }


                bool
                f_10274_9189_9198()
                {
                    var return_v = IsIndexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 9189, 9198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10274_9429_9460(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.GetExplicitInterfaceSpecifier();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 9429, 9460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10274_9343_9474(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                implementingProperty, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                explicitInterfaceType, string
                interfacePropertyName, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                explicitInterfaceSpecifierSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = implementingProperty.FindExplicitlyImplementedProperty(explicitInterfaceType, interfacePropertyName, explicitInterfaceSpecifierSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 9343, 9474);
                    return return_v;
                }


                int
                f_10274_9497_9589(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                implementingMember, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                implementedMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    implementingMember.FindExplicitlyImplementedMemberVerification((Microsoft.CodeAnalysis.CSharp.Symbol)implementedMember, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 9497, 9589);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10274_9861_9911(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 9861, 9911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10274_10020_10071(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 10020, 10071);
                    return return_v;
                }


                bool
                f_10274_10437_10639(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 10437, 10639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10274_10836_10859(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 10836, 10859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10274_10752_10860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destinationType, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                containingAssembly)
                {
                    var return_v = CustomModifierUtils.CopyTypeCustomModifiers(sourceType, destinationType, containingAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 10752, 10860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                f_10274_10971_11006(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 10971, 11006);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10274_11121_11163(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 11121, 11163);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10274_11072_11217(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                sourceParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                destinationParameters, bool
                alsoCopyParamsModifier)
                {
                    var return_v = CustomModifierUtils.CopyParameterCustomModifiers(sourceParameters, destinationParameters, alsoCopyParamsModifier: alsoCopyParamsModifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 11072, 11217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10274_11383_11403()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 11383, 11403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_11476_11488()
                {
                    var return_v = TypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 11476, 11488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_11359_11489(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Binder.GetWellKnownType(compilation, type, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 11359, 11489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomModifier
                f_10274_11558_11607(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CSharpCustomModifier.CreateRequired(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 11558, 11607);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10274_11536_11608(Microsoft.CodeAnalysis.CustomModifier
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 11536, 11608);
                    return return_v;
                }


                int
                f_10274_11640_11736(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 11640, 11736);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10274_11929_11981(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 11929, 11981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 6531, 11993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 6531, 11993);
            }
        }

        protected abstract Location TypeLocation { get; }

        internal sealed override ImmutableArray<string> NotNullMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 12150, 12248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 12166, 12248);
                    return f_10274_12166_12216_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10274_12166_12200(this), 10274, 12166, 12216)?.NotNullMembers) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<string>?>(10274, 12166, 12248) ?? ImmutableArray<string>.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 12150, 12248);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 12150, 12248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 12150, 12248);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<string> NotNullWhenTrueMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 12332, 12438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 12348, 12438);
                    return f_10274_12348_12406_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10274_12348_12382(this), 10274, 12348, 12406)?.NotNullWhenTrueMembers) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<string>?>(10274, 12348, 12438) ?? ImmutableArray<string>.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 12332, 12438);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 12332, 12438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 12332, 12438);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<string> NotNullWhenFalseMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 12523, 12630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 12539, 12630);
                    return f_10274_12539_12598_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10274_12539_12573(this), 10274, 12539, 12598)?.NotNullWhenFalseMembers) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<string>?>(10274, 12539, 12630) ?? ImmutableArray<string>.Empty); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 12523, 12630);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 12523, 12630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 12523, 12630);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 12689, 12740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 12692, 12740);
                    return (_propertyFlags & Flags.IsExpressionBodied) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 12689, 12740);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 12689, 12740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 12689, 12740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void CheckInitializer(
                    bool isAutoProperty,
                    bool isInterface,
                    bool isStatic,
                    Location location,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 12753, 13310);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 12973, 13299) || true) && (isInterface && (DynAbs.Tracing.TraceSender.Expression_True(10274, 12977, 13001) && !isStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 12973, 13299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 13035, 13121);

                    f_10274_13035_13120(diagnostics, ErrorCode.ERR_InstancePropertyInitializerInInterface, location, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 12973, 13299);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 12973, 13299);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 13155, 13299) || true) && (!isAutoProperty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 13155, 13299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 13208, 13284);

                        f_10274_13208_13283(diagnostics, ErrorCode.ERR_InitializerOnNonAutoProperty, location, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 13155, 13299);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 12973, 13299);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 12753, 13310);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_13035_13120(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 13035, 13120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_13208_13283(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 13208, 13283);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 12753, 13310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 12753, 13310);
            }
        }

        public sealed override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 13385, 13452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 13421, 13437);

                    return _refKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 13385, 13452);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 13322, 13463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 13322, 13463);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 13562, 13672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 13598, 13616);

                    f_10274_13598_13615(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 13634, 13657);

                    return _lazyType.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 13562, 13672);

                    int
                    f_10274_13598_13615(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        this_param.EnsureSignature();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 13598, 13615);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 13475, 13683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 13475, 13683);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void EnsureSignature()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 13716, 16861);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 13771, 16850) || true) && (!_state.HasComplete(CompletionPart.FinishPropertyEnsureSignature))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 13771, 16850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 14132, 14142);
                    // If this lock ever encloses a potential call to Debugger.NotifyOfCrossThreadDependency,
                    // then we should call DebuggerUtilities.CallBeforeAcquiringLock() (see method comment for more
                    // details).

                    lock (_syntaxRef)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 14184, 16816) || true) && (_state.NotePartComplete(CompletionPart.StartPropertyEnsureSignature))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 14184, 16816);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 14546, 14592);

                            var
                            diagnostics = f_10274_14564_14591()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 14678, 14714);

                                f_10274_14678_14713(this, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 14744, 14788);

                                f_10274_14744_14787(this, diagnostics);
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(10274, 14841, 15051);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 14905, 14975);

                                _state.NotePartComplete(CompletionPart.FinishPropertyEnsureSignature);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 15005, 15024);

                                f_10274_15005_15023(diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitFinally(10274, 14841, 15051);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 14184, 16816);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 14184, 16816);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 14184, 16816);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 13771, 16850);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 13716, 16861);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10274_14564_14591()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 14564, 14591);
                    return return_v;
                }


                int
                f_10274_14678_14713(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EnsureSignatureGuarded(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 14678, 14713);
                    return 0;
                }


                int
                f_10274_14744_14787(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddDeclarationDiagnostics(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 14744, 14787);
                    return 0;
                }


                int
                f_10274_15005_15023(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 15005, 15023);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 13716, 16861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 13716, 16861);
            }
        }

        internal bool HasPointerType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 16947, 17341);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 16983, 17271) || true) && (_lazyType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 16983, 17271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 17048, 17126);

                        var
                        hasPointerType = f_10274_17069_17125(_lazyType.Value.DefaultType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 17148, 17208);

                        f_10274_17148_17207(hasPointerType == f_10274_17179_17206());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 17230, 17252);

                        return hasPointerType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 16983, 17271);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 17291, 17326);

                    return f_10274_17298_17325();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 16947, 17341);

                    bool
                    f_10274_17069_17125(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsPointerOrFunctionPointer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 17069, 17125);
                        return return_v;
                    }


                    bool
                    f_10274_17179_17206()
                    {
                        var return_v = HasPointerTypeSyntactically;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 17179, 17206);
                        return return_v;
                    }


                    int
                    f_10274_17148_17207(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 17148, 17207);
                        return 0;
                    }


                    bool
                    f_10274_17298_17325()
                    {
                        var return_v = HasPointerTypeSyntactically;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 17298, 17325);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 16894, 17352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 16894, 17352);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract bool HasPointerTypeSyntactically { get; }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 17762, 17826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 17798, 17811);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 17762, 17826);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 17710, 17837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 17710, 17837);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string SourceName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 17918, 19775);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 17954, 19717) || true) && (_lazySourceName is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 17954, 19717);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 18023, 18047);

                        f_10274_18023_18046(f_10274_18036_18045());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 18071, 18163);

                        var
                        indexerNameAttributeLists = f_10274_18103_18162(((IndexerDeclarationSyntax)f_10274_18130_18146()))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 18185, 18236);

                        f_10274_18185_18235(indexerNameAttributeLists.Count != 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 18258, 18307);

                        f_10274_18258_18306(f_10274_18271_18305_M(!IsExplicitInterfaceImplementation));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 18331, 18357);

                        string?
                        sourceName = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 18886, 18940);

                        CustomAttributesBag<CSharpAttributeData>?
                        temp = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 18962, 19068);

                        f_10274_18962_19067(this, f_10274_18988_19031(indexerNameAttributeLists), ref temp, earlyDecodingOnly: true);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 19090, 19538) || true) && (temp != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 19090, 19538);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 19156, 19220);

                            f_10274_19156_19219(f_10274_19169_19218(temp));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 19246, 19342);

                            var
                            propertyData = (PropertyEarlyWellKnownAttributeData)f_10274_19302_19341(temp)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 19368, 19515) || true) && (propertyData != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 19368, 19515);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 19450, 19488);

                                sourceName = f_10274_19463_19487(propertyData);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 19368, 19515);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 19090, 19538);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 19562, 19608);

                        sourceName = sourceName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10274, 19575, 19607) ?? DefaultIndexerName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 19632, 19698);

                        f_10274_19632_19697(ref _lazySourceName, sourceName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 17954, 19717);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 19737, 19760);

                    return _lazySourceName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 17918, 19775);

                    bool
                    f_10274_18036_18045()
                    {
                        var return_v = IsIndexer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 18036, 18045);
                        return return_v;
                    }


                    int
                    f_10274_18023_18046(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 18023, 18046);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10274_18130_18146()
                    {
                        var return_v = CSharpSyntaxNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 18130, 18146);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    f_10274_18103_18162(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.AttributeLists;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 18103, 18162);
                        return return_v;
                    }


                    int
                    f_10274_18185_18235(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 18185, 18235);
                        return 0;
                    }


                    bool
                    f_10274_18271_18305_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 18271, 18305);
                        return return_v;
                    }


                    int
                    f_10274_18258_18306(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 18258, 18306);
                        return 0;
                    }


                    Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    f_10274_18988_19031(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                    one)
                    {
                        var return_v = OneOrMany.Create(one);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 18988, 19031);
                        return return_v;
                    }


                    bool
                    f_10274_18962_19067(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                    attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                    lazyCustomAttributesBag, bool
                    earlyDecodingOnly)
                    {
                        var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag, earlyDecodingOnly: earlyDecodingOnly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 18962, 19067);
                        return return_v;
                    }


                    bool
                    f_10274_19169_19218(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.IsEarlyDecodedWellKnownAttributeDataComputed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 19169, 19218);
                        return return_v;
                    }


                    int
                    f_10274_19156_19219(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 19156, 19219);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                    f_10274_19302_19341(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 19302, 19341);
                        return return_v;
                    }


                    string
                    f_10274_19463_19487(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyEarlyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.IndexerName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 19463, 19487);
                        return return_v;
                    }


                    string
                    f_10274_19632_19697(ref string?
                    target, string
                    value)
                    {
                        var return_v = InterlockedOperations.Initialize(ref target, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 19632, 19697);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 17867, 19786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 17867, 19786);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 19877, 20107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 20057, 20092);

                    return f_10274_20064_20091(f_10274_20064_20074(), " ", "");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 19877, 20107);

                    string
                    f_10274_20064_20074()
                    {
                        var return_v = SourceName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 20064, 20074);
                        return return_v;
                    }


                    string
                    f_10274_20064_20091(string
                    this_param, string
                    oldValue, string
                    newValue)
                    {
                        var return_v = this_param.Replace(oldValue, newValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 20064, 20091);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 19817, 20118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 19817, 20118);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 20194, 20268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 20230, 20253);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 20194, 20268);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 20130, 20279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 20130, 20279);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 20362, 20436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 20398, 20421);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 20362, 20436);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 20291, 20447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 20291, 20447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LexicalSortKey GetLexicalSortKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 20459, 20610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 20536, 20599);

                return f_10274_20543_20598(f_10274_20562_20570(), f_10274_20572_20597(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 20459, 20610);

                Microsoft.CodeAnalysis.Location
                f_10274_20562_20570()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 20562, 20570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10274_20572_20597(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 20572, 20597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10274_20543_20598(Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey(location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 20543, 20598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 20459, 20610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 20459, 20610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 20697, 20787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 20733, 20772);

                    return f_10274_20740_20771(f_10274_20762_20770());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 20697, 20787);

                    Microsoft.CodeAnalysis.Location
                    f_10274_20762_20770()
                    {
                        var return_v = Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 20762, 20770);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10274_20740_20771(Microsoft.CodeAnalysis.Location
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 20740, 20771);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 20622, 20798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 20622, 20798);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 20908, 21000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 20944, 20985);

                    return f_10274_20951_20984(_syntaxRef);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 20908, 21000);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10274_20951_20984(Microsoft.CodeAnalysis.SyntaxReference
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 20951, 20984);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 20810, 21011);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 20810, 21011);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 21079, 21144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 21085, 21142);

                    return (_modifiers & DeclarationModifiers.Abstract) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 21079, 21144);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 21023, 21155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 21023, 21155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 21221, 21284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 21227, 21282);

                    return (_modifiers & DeclarationModifiers.Extern) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 21221, 21284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 21167, 21295);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 21167, 21295);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 21361, 21424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 21367, 21422);

                    return (_modifiers & DeclarationModifiers.Static) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 21361, 21424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 21307, 21435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 21307, 21435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsFixed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 21493, 21514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 21499, 21512);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 21493, 21514);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 21447, 21525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 21447, 21525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsIndexer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 22042, 22106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 22048, 22104);

                    return (_modifiers & DeclarationModifiers.Indexer) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 22042, 22106);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 21987, 22117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 21987, 22117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 22185, 22250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 22191, 22248);

                    return (_modifiers & DeclarationModifiers.Override) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 22185, 22250);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 22129, 22261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 22129, 22261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 22327, 22390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 22333, 22388);

                    return (_modifiers & DeclarationModifiers.Sealed) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 22327, 22390);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 22273, 22401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 22273, 22401);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 22468, 22532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 22474, 22530);

                    return (_modifiers & DeclarationModifiers.Virtual) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 22468, 22532);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 22413, 22543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 22413, 22543);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsNew
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 22599, 22659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 22605, 22657);

                    return (_modifiers & DeclarationModifiers.New) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 22599, 22659);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 22555, 22670);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 22555, 22670);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasReadOnlyModifier
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 22716, 22768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 22719, 22768);
                    return (_modifiers & DeclarationModifiers.ReadOnly) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 22716, 22768);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 22716, 22768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 22716, 22768);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract SourcePropertyAccessorSymbol CreateGetAccessorSymbol(
                    bool isAutoPropertyAccessor,
                    DiagnosticBag diagnostics);

        protected abstract SourcePropertyAccessorSymbol CreateSetAccessorSymbol(
                    bool isAutoPropertyAccessor,
                    DiagnosticBag diagnostics);

        public sealed override MethodSymbol? GetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 23752, 23821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 23788, 23806);

                    return _getMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 23752, 23821);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 23681, 23832);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 23681, 23832);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override MethodSymbol? SetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 23915, 23984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 23951, 23969);

                    return _setMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 23915, 23984);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 23844, 23995);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 23844, 23995);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Microsoft.Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 24120, 24192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 24126, 24190);

                    return ((DynAbs.Tracing.TraceSender.Conditional_F1(10274, 24134, 24142) || ((f_10274_24134_24142() && DynAbs.Tracing.TraceSender.Conditional_F2(10274, 24145, 24146)) || DynAbs.Tracing.TraceSender.Conditional_F3(10274, 24149, 24188))) ? 0 : Microsoft.Cci.CallingConvention.HasThis);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 24120, 24192);

                    bool
                    f_10274_24134_24142()
                    {
                        var return_v = IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 24134, 24142);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 24028, 24203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 24028, 24203);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 24305, 24415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 24341, 24359);

                    f_10274_24341_24358(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 24377, 24400);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 24305, 24415);

                    int
                    f_10274_24341_24358(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        this_param.EnsureSignature();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 24341, 24358);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 24215, 24426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 24215, 24426);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 24508, 24574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 24511, 24574);
                    return (_propertyFlags & Flags.IsExplicitInterfaceImplementation) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 24508, 24574);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 24508, 24574);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 24508, 24574);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<PropertySymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 24698, 25072);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 24734, 24992) || true) && (f_10274_24738_24771())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 24734, 24992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 24813, 24831);

                        f_10274_24813_24830(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 24734, 24992);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 24734, 24992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 24913, 24973);

                        f_10274_24913_24972(_lazyExplicitInterfaceImplementations.IsEmpty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 24734, 24992);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 25012, 25057);

                    return _lazyExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 24698, 25072);

                    bool
                    f_10274_24738_24771()
                    {
                        var return_v = IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 24738, 24771);
                        return return_v;
                    }


                    int
                    f_10274_24813_24830(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        this_param.EnsureSignature();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 24813, 24830);
                        return 0;
                    }


                    int
                    f_10274_24913_24972(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 24913, 24972);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 24587, 25083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 24587, 25083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 25192, 25310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 25228, 25246);

                    f_10274_25228_25245(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 25264, 25295);

                    return _lazyRefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 25192, 25310);

                    int
                    f_10274_25228_25245(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        this_param.EnsureSignature();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 25228, 25245);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 25095, 25321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 25095, 25321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 25409, 25516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 25445, 25501);

                    return f_10274_25452_25500(_modifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 25409, 25516);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10274_25452_25500(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                    modifiers)
                    {
                        var return_v = ModifierUtils.EffectiveAccessibility(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 25452, 25500);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 25333, 25527);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 25333, 25527);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasSkipLocalsInitAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 25602, 25770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 25638, 25689);

                    var
                    data = f_10274_25649_25688(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 25707, 25755);

                    return f_10274_25714_25746_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(data, 10274, 25714, 25746)?.HasSkipLocalsInitAttribute) == true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 25602, 25770);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    f_10274_25649_25688(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 25649, 25688);
                        return return_v;
                    }


                    bool?
                    f_10274_25714_25746_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 25714, 25746);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 25539, 25781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 25539, 25781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsAutoPropertyWithGetAccessor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 25850, 25891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 25853, 25891);
                    return f_10274_25853_25867() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 25853, 25891) && _getMethod is object); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 25850, 25891);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 25850, 25891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 25850, 25891);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool IsAutoProperty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 25947, 25994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 25950, 25994);
                    return (_propertyFlags & Flags.IsAutoProperty) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 25947, 25994);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 25947, 25994);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 25947, 25994);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SynthesizedBackingFieldSymbol BackingField { get; }

        internal override bool MustCallMethodsDirectly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 26316, 26337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 26322, 26335);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 26316, 26337);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 26245, 26348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 26245, 26348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxReference SyntaxReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 26425, 26494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 26461, 26479);

                    return _syntaxRef;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 26425, 26494);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 26360, 26505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 26360, 26505);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CSharpSyntaxNode CSharpSyntaxNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 26584, 26683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 26620, 26668);

                    return (CSharpSyntaxNode)f_10274_26645_26667(_syntaxRef);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 26584, 26683);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10274_26645_26667(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.GetSyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 26645, 26667);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 26517, 26694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 26517, 26694);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 26761, 26841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 26797, 26826);

                    return f_10274_26804_26825(_syntaxRef);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 26761, 26841);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10274_26804_26825(Microsoft.CodeAnalysis.SyntaxReference
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 26804, 26825);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 26706, 26852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 26706, 26852);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void AfterAddingTypeMembersChecks(ConversionsBase conversions, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 26864, 35375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27014, 27089);

                bool
                isExplicitInterfaceImplementation = f_10274_27055_27088()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27103, 27185);

                f_10274_27103_27184(this, f_10274_27127_27135(), diagnostics, isExplicitInterfaceImplementation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27199, 27288);

                f_10274_27199_27287(this, isExplicitInterfaceImplementation, f_10274_27254_27262(), f_10274_27264_27273(), diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27304, 27371);

                bool
                hasInitializer = (_propertyFlags & Flags.HasInitializer) != 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27385, 27546) || true) && (hasInitializer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 27385, 27546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27437, 27531);

                    f_10274_27437_27530(this, f_10274_27454_27468(), f_10274_27470_27496(f_10274_27470_27484()), f_10274_27498_27506(), f_10274_27508_27516(), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 27385, 27546);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27562, 28978) || true) && (f_10274_27566_27595())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 27562, 28978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27629, 27663);

                    f_10274_27629_27662(f_10274_27642_27651() is object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27683, 28165) || true) && (f_10274_27687_27696_M(!IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 27687, 27734) && f_10274_27700_27709() is { IsInitOnly: false }))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 27683, 28165);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27776, 28146) || true) && (f_10274_27780_27805(f_10274_27780_27794()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 27776, 28146);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27855, 27916);

                            f_10274_27855_27915(diagnostics, ErrorCode.ERR_AutoPropsInRoStruct, f_10274_27906_27914());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 27776, 28146);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 27776, 28146);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 27966, 28146) || true) && (f_10274_27970_27989())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 27966, 28146);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 28039, 28123);

                                f_10274_28039_28122(diagnostics, ErrorCode.ERR_AutoPropertyWithSetterCantBeReadOnly, f_10274_28107_28115(), this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 27966, 28146);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 27776, 28146);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 27683, 28165);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 28278, 28490);

                    f_10274_28278_28489(f_10274_28332_28352(), WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor, diagnostics, location: f_10274_28480_28488());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 28510, 28683) || true) && (f_10274_28514_28526(this) != RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 28510, 28683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 28584, 28664);

                        f_10274_28584_28663(diagnostics, ErrorCode.ERR_AutoPropertyCannotBeRefReturning, f_10274_28648_28656(), this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 28510, 28683);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 28786, 28963) || true) && (f_10274_28790_28799() is null && (DynAbs.Tracing.TraceSender.Expression_True(10274, 28790, 28827) && f_10274_28811_28827_M(!this.IsReadOnly)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 28786, 28963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 28869, 28944);

                        f_10274_28869_28943(diagnostics, ErrorCode.ERR_AutoPropertyMustOverrideSet, f_10274_28928_28936(), this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 28786, 28963);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 27562, 28978);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 28994, 32611) || true) && (f_10274_28998_29017_M(!IsExpressionBodied))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 28994, 32611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 29051, 29093);

                    bool
                    hasGetAccessor = f_10274_29073_29082() is object
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 29111, 29153);

                    bool
                    hasSetAccessor = f_10274_29133_29142() is object
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 29173, 32342) || true) && (hasGetAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10274, 29177, 29209) && hasSetAccessor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 29173, 32342);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 29251, 29286);

                        f_10274_29251_29285(_getMethod is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 29308, 29343);

                        f_10274_29308_29342(_setMethod is object);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 29367, 30584) || true) && (_refKind != RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 29367, 30584);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 29445, 29546);

                            f_10274_29445_29545(diagnostics, ErrorCode.ERR_RefPropertyCannotHaveSetAccessor, f_10274_29509_29529(_setMethod)[0], _setMethod);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 29367, 30584);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 29367, 30584);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 29596, 30584) || true) && ((f_10274_29601_29630(_getMethod) != Accessibility.NotApplicable) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 29600, 29753) && (f_10274_29692_29721(_setMethod) != Accessibility.NotApplicable)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 29596, 30584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 29883, 29958);

                                f_10274_29883_29957(                        // Check accessibility is set on at most one accessor.
                                                        diagnostics, ErrorCode.ERR_DuplicatePropertyAccessMods, f_10274_29942_29950(), this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 29596, 30584);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 29596, 30584);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 30008, 30584) || true) && (f_10274_30012_30044(_getMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 30012, 30080) && f_10274_30048_30080(_setMethod)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 30008, 30584);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 30130, 30207);

                                    f_10274_30130_30206(diagnostics, ErrorCode.ERR_DuplicatePropertyReadOnlyMods, f_10274_30191_30199(), this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 30008, 30584);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 30008, 30584);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 30257, 30584) || true) && (f_10274_30261_30276(this))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 30257, 30584);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 30405, 30470);

                                        f_10274_30405_30469(_getMethod, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 30496, 30561);

                                        f_10274_30496_30560(_setMethod, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 30257, 30584);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 30008, 30584);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 29596, 30584);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 29367, 30584);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 29173, 32342);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 29173, 32342);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 30666, 31395) || true) && (!hasGetAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10274, 30670, 30704) && !hasSetAccessor))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 30666, 31395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 30754, 30825);

                            f_10274_30754_30824(diagnostics, ErrorCode.ERR_PropertyWithNoAccessors, f_10274_30809_30817(), this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 30666, 31395);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 30666, 31395);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 30875, 31395) || true) && (f_10274_30879_30886() != RefKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 30875, 31395);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 30952, 31134) || true) && (!hasGetAccessor)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 30952, 31134);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 31029, 31107);

                                    f_10274_31029_31106(diagnostics, ErrorCode.ERR_RefPropertyMustHaveGetAccessor, f_10274_31091_31099(), this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 30952, 31134);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 30875, 31395);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 30875, 31395);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 31184, 31395) || true) && (!hasGetAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10274, 31188, 31221) && f_10274_31207_31221()))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 31184, 31395);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 31271, 31372);

                                    f_10274_31271_31371(diagnostics, ErrorCode.ERR_AutoPropertyMustHaveGetAccessor, f_10274_31334_31355(_setMethod!)[0], _setMethod);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 31184, 31395);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 30875, 31395);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 30666, 31395);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 31419, 32323) || true) && (f_10274_31423_31439_M(!this.IsOverride))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 31419, 32323);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 31489, 31529);

                            var
                            accessor = _getMethod ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol?>(10274, 31504, 31528) ?? _setMethod)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 31555, 32300) || true) && (accessor is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 31555, 32300);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 31719, 31950) || true) && (f_10274_31723_31750(accessor) != Accessibility.NotApplicable)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 31719, 31950);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 31847, 31919);

                                    f_10274_31847_31918(diagnostics, ErrorCode.ERR_AccessModMissingAccessor, f_10274_31903_31911(), this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 31719, 31950);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 32068, 32273) || true) && (f_10274_32072_32102(accessor))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 32068, 32273);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 32168, 32242);

                                    f_10274_32168_32241(diagnostics, ErrorCode.ERR_ReadOnlyModMissingAccessor, f_10274_32226_32234(), this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 32068, 32273);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 31555, 32300);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 31419, 32323);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 29173, 32342);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 32460, 32519);

                    f_10274_32460_32518(this, _getMethod, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 32537, 32596);

                    f_10274_32537_32595(this, _setMethod, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 28994, 32611);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 32627, 32725);

                PropertySymbol?
                explicitlyImplementedProperty = f_10274_32675_32707().FirstOrDefault()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 32741, 33115) || true) && (explicitlyImplementedProperty is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 32741, 33115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 32818, 32950);

                    f_10274_32818_32949(this, f_10274_32854_32863(), f_10274_32865_32904(explicitlyImplementedProperty), explicitlyImplementedProperty, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 32968, 33100);

                    f_10274_32968_33099(this, f_10274_33004_33013(), f_10274_33015_33054(explicitlyImplementedProperty), explicitlyImplementedProperty, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 32741, 33115);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 33152, 33185);

                Location
                location = f_10274_33172_33184()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 33199, 33238);

                var
                compilation = f_10274_33217_33237()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 33254, 33285);

                f_10274_33254_33284(location != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 33566, 34314) || true) && ((object)_explicitInterfaceType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 33566, 34314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 33642, 33707);

                    var
                    explicitInterfaceSpecifier = f_10274_33675_33706(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 33725, 33774);

                    f_10274_33725_33773(explicitInterfaceSpecifier != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 33792, 33927);

                    f_10274_33792_33926(_explicitInterfaceType, compilation, conversions, f_10274_33861_33912(f_10274_33880_33911(explicitInterfaceSpecifier)), diagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 34040, 34299) || true) && (explicitlyImplementedProperty is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 34040, 34299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 34125, 34280);

                        f_10274_34125_34279(f_10274_34191_34210(this), this, explicitlyImplementedProperty, isExplicit: true, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 34040, 34299);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 33566, 34314);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 34330, 34506) || true) && (_refKind == RefKind.RefReadOnly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 34330, 34506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 34399, 34491);

                    f_10274_34399_34490(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 34330, 34506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 34522, 34634);

                f_10274_34522_34633(compilation, f_10274_34584_34594(), diagnostics, modifyCompilation: true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 34650, 34826) || true) && (f_10274_34654_34682(f_10274_34654_34658()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 34650, 34826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 34716, 34811);

                    f_10274_34716_34810(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 34650, 34826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 34842, 34957);

                f_10274_34842_34956(compilation, f_10274_34907_34917(), diagnostics, modifyCompilation: true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 34973, 35232) || true) && (f_10274_34977_35023(compilation, this) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 34977, 35093) && this.TypeWithAnnotations.NeedsNullableAttribute()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 34973, 35232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 35127, 35217);

                    f_10274_35127_35216(compilation, diagnostics, location, modifyCompilation: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 34973, 35232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 35248, 35364);

                f_10274_35248_35363(compilation, this, f_10274_35314_35324(), diagnostics, modifyCompilation: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 26864, 35375);

                bool
                f_10274_27055_27088()
                {
                    var return_v = IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27055, 27088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_27127_27135()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27127, 27135);
                    return return_v;
                }


                int
                f_10274_27103_27184(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isExplicitInterfaceImplementation)
                {
                    this_param.CheckAccessibility(location, diagnostics, isExplicitInterfaceImplementation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 27103, 27184);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_27254_27262()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27254, 27262);
                    return return_v;
                }


                bool
                f_10274_27264_27273()
                {
                    var return_v = IsIndexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27264, 27273);
                    return return_v;
                }


                int
                f_10274_27199_27287(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, bool
                isExplicitInterfaceImplementation, Microsoft.CodeAnalysis.Location
                location, bool
                isIndexer, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckModifiers(isExplicitInterfaceImplementation, location, isIndexer, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 27199, 27287);
                    return 0;
                }


                bool
                f_10274_27454_27468()
                {
                    var return_v = IsAutoProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27454, 27468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_27470_27484()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27470, 27484);
                    return return_v;
                }


                bool
                f_10274_27470_27496(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27470, 27496);
                    return return_v;
                }


                bool
                f_10274_27498_27506()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27498, 27506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_27508_27516()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27508, 27516);
                    return return_v;
                }


                int
                f_10274_27437_27530(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, bool
                isAutoProperty, bool
                isInterface, bool
                isStatic, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckInitializer(isAutoProperty, isInterface, isStatic, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 27437, 27530);
                    return 0;
                }


                bool
                f_10274_27566_27595()
                {
                    var return_v = IsAutoPropertyWithGetAccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27566, 27595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_27642_27651()
                {
                    var return_v = GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27642, 27651);
                    return return_v;
                }


                int
                f_10274_27629_27662(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 27629, 27662);
                    return 0;
                }


                bool
                f_10274_27687_27696_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27687, 27696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_27700_27709()
                {
                    var return_v = SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27700, 27709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_27780_27794()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27780, 27794);
                    return return_v;
                }


                bool
                f_10274_27780_27805(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27780, 27805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_27906_27914()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27906, 27914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_27855_27915(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 27855, 27915);
                    return return_v;
                }


                bool
                f_10274_27970_27989()
                {
                    var return_v = HasReadOnlyModifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 27970, 27989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_28107_28115()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 28107, 28115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_28039_28122(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 28039, 28122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10274_28332_28352()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 28332, 28352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_28480_28488()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 28480, 28488);
                    return return_v;
                }


                int
                f_10274_28278_28489(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                attributeMember, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    Binder.ReportUseSiteDiagnosticForSynthesizedAttribute(compilation, attributeMember, diagnostics, location: location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 28278, 28489);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10274_28514_28526(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 28514, 28526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_28648_28656()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 28648, 28656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_28584_28663(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 28584, 28663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_28790_28799()
                {
                    var return_v = SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 28790, 28799);
                    return return_v;
                }


                bool
                f_10274_28811_28827_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 28811, 28827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_28928_28936()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 28928, 28936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_28869_28943(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 28869, 28943);
                    return return_v;
                }


                bool
                f_10274_28998_29017_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 28998, 29017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_29073_29082()
                {
                    var return_v = GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 29073, 29082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_29133_29142()
                {
                    var return_v = SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 29133, 29142);
                    return return_v;
                }


                int
                f_10274_29251_29285(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 29251, 29285);
                    return 0;
                }


                int
                f_10274_29308_29342(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 29308, 29342);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10274_29509_29529(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 29509, 29529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_29445_29545(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 29445, 29545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10274_29601_29630(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.LocalAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 29601, 29630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10274_29692_29721(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.LocalAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 29692, 29721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_29942_29950()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 29942, 29950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_29883_29957(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 29883, 29957);
                    return return_v;
                }


                bool
                f_10274_30012_30044(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.LocalDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 30012, 30044);
                    return return_v;
                }


                bool
                f_10274_30048_30080(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.LocalDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 30048, 30080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_30191_30199()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 30191, 30199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_30130_30206(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 30130, 30206);
                    return return_v;
                }


                bool
                f_10274_30261_30276(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 30261, 30276);
                    return return_v;
                }


                int
                f_10274_30405_30469(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                accessor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckAbstractPropertyAccessorNotPrivate(accessor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 30405, 30469);
                    return 0;
                }


                int
                f_10274_30496_30560(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                accessor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckAbstractPropertyAccessorNotPrivate(accessor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 30496, 30560);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_30809_30817()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 30809, 30817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_30754_30824(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 30754, 30824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10274_30879_30886()
                {
                    var return_v = RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 30879, 30886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_31091_31099()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 31091, 31099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_31029_31106(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 31029, 31106);
                    return return_v;
                }


                bool
                f_10274_31207_31221()
                {
                    var return_v = IsAutoProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 31207, 31221);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10274_31334_31355(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 31334, 31355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_31271_31371(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 31271, 31371);
                    return return_v;
                }


                bool
                f_10274_31423_31439_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 31423, 31439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10274_31723_31750(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.LocalAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 31723, 31750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_31903_31911()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 31903, 31911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_31847_31918(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 31847, 31918);
                    return return_v;
                }


                bool
                f_10274_32072_32102(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.LocalDeclaredReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 32072, 32102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_32226_32234()
                {
                    var return_v = Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 32226, 32234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_32168_32241(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 32168, 32241);
                    return return_v;
                }


                int
                f_10274_32460_32518(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol?
                accessor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckAccessibilityMoreRestrictive(accessor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 32460, 32518);
                    return 0;
                }


                int
                f_10274_32537_32595(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol?
                accessor, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckAccessibilityMoreRestrictive(accessor, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 32537, 32595);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10274_32675_32707()
                {
                    var return_v = ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 32675, 32707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_32854_32863()
                {
                    var return_v = GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 32854, 32863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10274_32865_32904(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 32865, 32904);
                    return return_v;
                }


                int
                f_10274_32818_32949(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                thisAccessor, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                otherAccessor, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                explicitlyImplementedProperty, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckExplicitImplementationAccessor(thisAccessor, otherAccessor, explicitlyImplementedProperty, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 32818, 32949);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_33004_33013()
                {
                    var return_v = SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 33004, 33013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10274_33015_33054(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 33015, 33054);
                    return return_v;
                }


                int
                f_10274_32968_33099(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                thisAccessor, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                otherAccessor, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                explicitlyImplementedProperty, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckExplicitImplementationAccessor(thisAccessor, otherAccessor, explicitlyImplementedProperty, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 32968, 33099);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_33172_33184()
                {
                    var return_v = TypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 33172, 33184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10274_33217_33237()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 33217, 33237);
                    return return_v;
                }


                int
                f_10274_33254_33284(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 33254, 33284);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10274_33675_33706(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.GetExplicitInterfaceSpecifier();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 33675, 33706);
                    return return_v;
                }


                int
                f_10274_33725_33773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 33725, 33773);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10274_33880_33911(Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 33880, 33911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10274_33861_33912(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 33861, 33912);
                    return return_v;
                }


                int
                f_10274_33792_33926(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.SourceLocation
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    type.CheckAllConstraints(compilation, conversions, (Microsoft.CodeAnalysis.Location)location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 33792, 33926);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_34191_34210(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 34191, 34210);
                    return return_v;
                }


                int
                f_10274_34125_34279(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                implementingType, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                implementingMember, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                interfaceMember, bool
                isExplicit, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    TypeSymbol.CheckNullableReferenceTypeMismatchOnImplementingMember((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)implementingType, (Microsoft.CodeAnalysis.CSharp.Symbol)implementingMember, (Microsoft.CodeAnalysis.CSharp.Symbol)interfaceMember, isExplicit: isExplicit, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 34125, 34279);
                    return 0;
                }


                int
                f_10274_34399_34490(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureIsReadOnlyAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 34399, 34490);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10274_34584_34594()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 34584, 34594);
                    return return_v;
                }


                int
                f_10274_34522_34633(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureIsReadOnlyAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 34522, 34633);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10274_34654_34658()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 34654, 34658);
                    return return_v;
                }


                bool
                f_10274_34654_34682(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 34654, 34682);
                    return return_v;
                }


                int
                f_10274_34716_34810(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNativeIntegerAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 34716, 34810);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10274_34907_34917()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 34907, 34917);
                    return return_v;
                }


                int
                f_10274_34842_34956(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNativeIntegerAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 34842, 34956);
                    return 0;
                }


                bool
                f_10274_34977_35023(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 34977, 35023);
                    return return_v;
                }


                int
                f_10274_35127_35216(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNullableAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 35127, 35216);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10274_35314_35324()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 35314, 35324);
                    return return_v;
                }


                int
                f_10274_35248_35363(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNullableAttributeExists(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)container, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 35248, 35363);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 26864, 35375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 26864, 35375);
            }
        }

        private void CheckAccessibility(Location location, DiagnosticBag diagnostics, bool isExplicitInterfaceImplementation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 35387, 35766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 35529, 35626);

                var
                info = f_10274_35540_35625(_modifiers, this, isExplicitInterfaceImplementation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 35640, 35755) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 35640, 35755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 35690, 35740);

                    f_10274_35690_35739(diagnostics, f_10274_35706_35738(info, location));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 35640, 35755);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 35387, 35766);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_35540_35625(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                symbol, bool
                isExplicitInterfaceImplementation)
                {
                    var return_v = ModifierUtils.CheckAccessibility(modifiers, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, isExplicitInterfaceImplementation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 35540, 35625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10274_35706_35738(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 35706, 35738);
                    return return_v;
                }


                int
                f_10274_35690_35739(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 35690, 35739);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 35387, 35766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 35387, 35766);
            }
        }

        private void CheckModifiers(bool isExplicitInterfaceImplementation, Location location, bool isIndexer, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 35778, 39099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 35932, 36048);

                bool
                isExplicitInterfaceImplementationInInterface = isExplicitInterfaceImplementation && (DynAbs.Tracing.TraceSender.Expression_True(10274, 35984, 36047) && f_10274_36021_36047(f_10274_36021_36035()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 36064, 39088) || true) && (f_10274_36068_36094(this) == Accessibility.Private && (DynAbs.Tracing.TraceSender.Expression_True(10274, 36068, 36213) && (f_10274_36124_36133() || (DynAbs.Tracing.TraceSender.Expression_False(10274, 36124, 36198) || (f_10274_36138_36148() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 36138, 36197) && !isExplicitInterfaceImplementationInInterface))) || (DynAbs.Tracing.TraceSender.Expression_False(10274, 36124, 36212) || f_10274_36202_36212()))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 36064, 39088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 36247, 36309);

                    f_10274_36247_36308(diagnostics, ErrorCode.ERR_VirtualPrivate, location, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 36064, 39088);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 36064, 39088);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 36343, 39088) || true) && (f_10274_36347_36355() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 36347, 36398) && (f_10274_36360_36370() || (DynAbs.Tracing.TraceSender.Expression_False(10274, 36360, 36383) || f_10274_36374_36383()) || (DynAbs.Tracing.TraceSender.Expression_False(10274, 36360, 36397) || f_10274_36387_36397()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 36343, 39088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 36525, 36589);

                        f_10274_36525_36588(                // A static member '{0}' cannot be marked as override, virtual, or abstract
                                        diagnostics, ErrorCode.ERR_StaticNotVirtual, location, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 36343, 39088);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 36343, 39088);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 36623, 39088) || true) && (f_10274_36627_36635() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 36627, 36658) && f_10274_36639_36658()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 36623, 39088);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 36761, 36835);

                            f_10274_36761_36834(                // Static member '{0}' cannot be marked 'readonly'.
                                            diagnostics, ErrorCode.ERR_StaticMemberCantBeReadOnly, location, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 36623, 39088);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 36623, 39088);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 36869, 39088) || true) && (f_10274_36873_36883() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 36873, 36907) && (f_10274_36888_36893() || (DynAbs.Tracing.TraceSender.Expression_False(10274, 36888, 36906) || f_10274_36897_36906()))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 36869, 39088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 37030, 37092);

                                f_10274_37030_37091(                // A member '{0}' marked as override cannot be marked as new or virtual
                                                diagnostics, ErrorCode.ERR_OverrideNotNew, location, this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 36869, 39088);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 36869, 39088);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 37126, 39088) || true) && (f_10274_37130_37138() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 37130, 37153) && f_10274_37142_37153_M(!IsOverride)) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 37130, 37218) && !(f_10274_37159_37169() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 37159, 37217) && isExplicitInterfaceImplementationInInterface))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 37126, 39088);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 37325, 37390);

                                    f_10274_37325_37389(                // '{0}' cannot be sealed because it is not an override
                                                    diagnostics, ErrorCode.ERR_SealedNonOverride, location, this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 37126, 39088);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 37126, 39088);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 37424, 39088) || true) && (f_10274_37428_37438() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 37428, 37484) && f_10274_37442_37465(f_10274_37442_37456()) == TypeKind.Struct))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 37424, 39088);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 37584, 37688);

                                        f_10274_37584_37687(                // The modifier '{0}' is not valid for this item
                                                        diagnostics, ErrorCode.ERR_BadMemberFlag, location, f_10274_37639_37686(SyntaxKind.AbstractKeyword));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 37424, 39088);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 37424, 39088);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 37722, 39088) || true) && (f_10274_37726_37735() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 37726, 37781) && f_10274_37739_37762(f_10274_37739_37753()) == TypeKind.Struct))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 37722, 39088);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 37881, 37984);

                                            f_10274_37881_37983(                // The modifier '{0}' is not valid for this item
                                                            diagnostics, ErrorCode.ERR_BadMemberFlag, location, f_10274_37936_37982(SyntaxKind.VirtualKeyword));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 37722, 39088);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 37722, 39088);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 38018, 39088) || true) && (f_10274_38022_38032() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 38022, 38044) && f_10274_38036_38044()))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 38018, 39088);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 38078, 38143);

                                                f_10274_38078_38142(diagnostics, ErrorCode.ERR_AbstractAndExtern, location, this);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 38018, 39088);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 38018, 39088);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 38177, 39088) || true) && (f_10274_38181_38191() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 38181, 38203) && f_10274_38195_38203()) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 38181, 38252) && !isExplicitInterfaceImplementationInInterface))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 38177, 39088);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 38286, 38351);

                                                    f_10274_38286_38350(diagnostics, ErrorCode.ERR_AbstractAndSealed, location, this);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 38177, 39088);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 38177, 39088);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 38385, 39088) || true) && (f_10274_38389_38399() && (DynAbs.Tracing.TraceSender.Expression_True(10274, 38389, 38412) && f_10274_38403_38412()))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 38385, 39088);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 38446, 38534);

                                                        f_10274_38446_38533(diagnostics, ErrorCode.ERR_AbstractNotVirtual, location, f_10274_38506_38526(f_10274_38506_38515(this)), this);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 38385, 39088);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 38385, 39088);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 38568, 39088) || true) && (f_10274_38572_38595(f_10274_38572_38586()) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 38572, 38640) && f_10274_38599_38640(f_10274_38599_38625(this))) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 38572, 38660) && f_10274_38644_38660_M(!this.IsOverride)))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 38568, 39088);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 38694, 38791);

                                                            f_10274_38694_38790(diagnostics, f_10274_38710_38773(f_10274_38758_38772()), location, this);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 38568, 39088);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 38568, 39088);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 38825, 39088) || true) && (f_10274_38829_38852(f_10274_38829_38843()) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 38829, 38865) && f_10274_38856_38865_M(!IsStatic)))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 38825, 39088);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 38899, 39012);

                                                                ErrorCode
                                                                errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10274, 38921, 38930) || ((isIndexer && DynAbs.Tracing.TraceSender.Conditional_F2(10274, 38933, 38967)) || DynAbs.Tracing.TraceSender.Conditional_F3(10274, 38970, 39011))) ? ErrorCode.ERR_IndexerInStaticClass : ErrorCode.ERR_InstanceMemberInStaticClass
                                                                ;
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 39030, 39073);

                                                                f_10274_39030_39072(diagnostics, errorCode, location, this);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 38825, 39088);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 38568, 39088);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 38385, 39088);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 38177, 39088);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 38018, 39088);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 37722, 39088);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 37424, 39088);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 37126, 39088);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 36869, 39088);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 36623, 39088);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 36343, 39088);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 36064, 39088);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 35778, 39099);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_36021_36035()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36021, 36035);
                    return return_v;
                }


                bool
                f_10274_36021_36047(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36021, 36047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10274_36068_36094(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36068, 36094);
                    return return_v;
                }


                bool
                f_10274_36124_36133()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36124, 36133);
                    return return_v;
                }


                bool
                f_10274_36138_36148()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36138, 36148);
                    return return_v;
                }


                bool
                f_10274_36202_36212()
                {
                    var return_v = IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36202, 36212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_36247_36308(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 36247, 36308);
                    return return_v;
                }


                bool
                f_10274_36347_36355()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36347, 36355);
                    return return_v;
                }


                bool
                f_10274_36360_36370()
                {
                    var return_v = IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36360, 36370);
                    return return_v;
                }


                bool
                f_10274_36374_36383()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36374, 36383);
                    return return_v;
                }


                bool
                f_10274_36387_36397()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36387, 36397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_36525_36588(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 36525, 36588);
                    return return_v;
                }


                bool
                f_10274_36627_36635()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36627, 36635);
                    return return_v;
                }


                bool
                f_10274_36639_36658()
                {
                    var return_v = HasReadOnlyModifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36639, 36658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_36761_36834(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 36761, 36834);
                    return return_v;
                }


                bool
                f_10274_36873_36883()
                {
                    var return_v = IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36873, 36883);
                    return return_v;
                }


                bool
                f_10274_36888_36893()
                {
                    var return_v = IsNew;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36888, 36893);
                    return return_v;
                }


                bool
                f_10274_36897_36906()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 36897, 36906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_37030_37091(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 37030, 37091);
                    return return_v;
                }


                bool
                f_10274_37130_37138()
                {
                    var return_v = IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 37130, 37138);
                    return return_v;
                }


                bool
                f_10274_37142_37153_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 37142, 37153);
                    return return_v;
                }


                bool
                f_10274_37159_37169()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 37159, 37169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_37325_37389(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 37325, 37389);
                    return return_v;
                }


                bool
                f_10274_37428_37438()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 37428, 37438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_37442_37456()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 37442, 37456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10274_37442_37465(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 37442, 37465);
                    return return_v;
                }


                string
                f_10274_37639_37686(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 37639, 37686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_37584_37687(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 37584, 37687);
                    return return_v;
                }


                bool
                f_10274_37726_37735()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 37726, 37735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_37739_37753()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 37739, 37753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10274_37739_37762(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 37739, 37762);
                    return return_v;
                }


                string
                f_10274_37936_37982(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 37936, 37982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_37881_37983(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 37881, 37983);
                    return return_v;
                }


                bool
                f_10274_38022_38032()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38022, 38032);
                    return return_v;
                }


                bool
                f_10274_38036_38044()
                {
                    var return_v = IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38036, 38044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_38078_38142(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 38078, 38142);
                    return return_v;
                }


                bool
                f_10274_38181_38191()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38181, 38191);
                    return return_v;
                }


                bool
                f_10274_38195_38203()
                {
                    var return_v = IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38195, 38203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_38286_38350(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 38286, 38350);
                    return return_v;
                }


                bool
                f_10274_38389_38399()
                {
                    var return_v = IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38389, 38399);
                    return return_v;
                }


                bool
                f_10274_38403_38412()
                {
                    var return_v = IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38403, 38412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10274_38506_38515(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38506, 38515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10274_38506_38526(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 38506, 38526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_38446_38533(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 38446, 38533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_38572_38586()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38572, 38586);
                    return return_v;
                }


                bool
                f_10274_38572_38595(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38572, 38595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10274_38599_38625(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38599, 38625);
                    return return_v;
                }


                bool
                f_10274_38599_38640(Microsoft.CodeAnalysis.Accessibility
                accessibility)
                {
                    var return_v = accessibility.HasProtected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 38599, 38640);
                    return return_v;
                }


                bool
                f_10274_38644_38660_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38644, 38660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_38758_38772()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38758, 38772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10274_38710_38773(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType)
                {
                    var return_v = AccessCheck.GetProtectedMemberInSealedTypeError(containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 38710, 38773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_38694_38790(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 38694, 38790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_38829_38843()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38829, 38843);
                    return return_v;
                }


                bool
                f_10274_38829_38852(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38829, 38852);
                    return return_v;
                }


                bool
                f_10274_38856_38865_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 38856, 38865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_39030_39072(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 39030, 39072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 35778, 39099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 35778, 39099);
            }
        }

        private void CheckAccessibilityMoreRestrictive(SourcePropertyAccessorSymbol accessor, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 39111, 39542);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 39248, 39531) || true) && (((object)accessor != null) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 39252, 39387) && !f_10274_39300_39387(f_10274_39331_39357(this), f_10274_39359_39386(accessor))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 39248, 39531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 39421, 39516);

                    f_10274_39421_39515(diagnostics, ErrorCode.ERR_InvalidPropertyAccessMod, f_10274_39477_39495(accessor)[0], accessor, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 39248, 39531);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 39111, 39542);

                Microsoft.CodeAnalysis.Accessibility
                f_10274_39331_39357(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 39331, 39357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10274_39359_39386(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.LocalAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 39359, 39386);
                    return return_v;
                }


                bool
                f_10274_39300_39387(Microsoft.CodeAnalysis.Accessibility
                property, Microsoft.CodeAnalysis.Accessibility
                accessor)
                {
                    var return_v = IsAccessibilityMoreRestrictive(property, accessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 39300, 39387);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10274_39477_39495(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 39477, 39495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_39421_39515(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 39421, 39515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 39111, 39542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 39111, 39542);
            }
        }

        private static bool IsAccessibilityMoreRestrictive(Accessibility property, Accessibility accessor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10274, 39739, 40120);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 39862, 39966) || true) && (accessor == Accessibility.NotApplicable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 39862, 39966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 39939, 39951);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 39862, 39966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 39980, 40109);

                return (accessor < property) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 39987, 40108) && ((accessor != Accessibility.Protected) || (DynAbs.Tracing.TraceSender.Expression_False(10274, 40030, 40107) || (property != Accessibility.Internal))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10274, 39739, 40120);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 39739, 40120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 39739, 40120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CheckAbstractPropertyAccessorNotPrivate(SourcePropertyAccessorSymbol accessor, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10274, 40132, 40486);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 40282, 40475) || true) && (f_10274_40286_40313(accessor) == Accessibility.Private)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 40282, 40475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 40372, 40460);

                    f_10274_40372_40459(diagnostics, ErrorCode.ERR_PrivateAbstractAccessor, f_10274_40427_40445(accessor)[0], accessor);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 40282, 40475);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10274, 40132, 40486);

                Microsoft.CodeAnalysis.Accessibility
                f_10274_40286_40313(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.LocalAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 40286, 40313);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10274_40427_40445(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 40427, 40445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_40372_40459(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 40372, 40459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 40132, 40486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 40132, 40486);
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 40498, 40938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 40704, 40800);

                ref var
                lazyDocComment = ref (DynAbs.Tracing.TraceSender.Conditional_F1(10274, 40733, 40747) || ((expandIncludes && DynAbs.Tracing.TraceSender.Conditional_F2(10274, 40750, 40777)) || DynAbs.Tracing.TraceSender.Conditional_F3(10274, 40780, 40799))) ? ref _lazyExpandedDocComment : ref _lazyDocComment
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 40814, 40927);

                return f_10274_40821_40926(this, expandIncludes, ref lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 40498, 40938);

                string
                f_10274_40821_40926(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                symbol, bool
                expandIncludes, ref string
                lazyXmlText)
                {
                    var return_v = SourceDocumentationCommentUtils.GetAndCacheDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, expandIncludes, ref lazyXmlText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 40821, 40926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 40498, 40938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 40498, 40938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckExplicitImplementationAccessor(MethodSymbol thisAccessor, MethodSymbol otherAccessor, PropertySymbol explicitlyImplementedProperty, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 41134, 42246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 41335, 41386);

                var
                thisHasAccessor = (object)thisAccessor != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 41400, 41455);

                var
                otherHasAccessor = f_10274_41423_41454(otherAccessor)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 41471, 42235) || true) && (otherHasAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10274, 41475, 41511) && !thisHasAccessor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 41471, 42235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 41545, 41644);

                    f_10274_41545_41643(diagnostics, ErrorCode.ERR_ExplicitPropertyMissingAccessor, f_10274_41608_41621(this), this, otherAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 41471, 42235);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 41471, 42235);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 41678, 42235) || true) && (!otherHasAccessor && (DynAbs.Tracing.TraceSender.Expression_True(10274, 41682, 41718) && thisHasAccessor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 41678, 42235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 41752, 41886);

                        f_10274_41752_41885(diagnostics, ErrorCode.ERR_ExplicitPropertyAddingAccessor, f_10274_41814_41836(thisAccessor)[0], thisAccessor, explicitlyImplementedProperty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 41678, 42235);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 41678, 42235);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 41920, 42235) || true) && (f_10274_41924_41984(thisAccessor, otherAccessor))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 41920, 42235);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 42018, 42082);

                            f_10274_42018_42081(f_10274_42031_42054(thisAccessor) == MethodKind.PropertySet);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 42100, 42220);

                            f_10274_42100_42219(diagnostics, ErrorCode.ERR_ExplicitPropertyMismatchInitOnly, f_10274_42164_42186(thisAccessor)[0], thisAccessor, otherAccessor);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 41920, 42235);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 41678, 42235);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 41471, 42235);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 41134, 42246);

                bool
                f_10274_41423_41454(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOpt)
                {
                    var return_v = methodOpt.IsImplementable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 41423, 41454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_41608_41621(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 41608, 41621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_41545_41643(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 41545, 41643);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10274_41814_41836(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 41814, 41836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_41752_41885(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 41752, 41885);
                    return return_v;
                }


                bool
                f_10274_41924_41984(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                one, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                other)
                {
                    var return_v = TypeSymbol.HaveInitOnlyMismatch((Microsoft.CodeAnalysis.CSharp.Symbol?)one, (Microsoft.CodeAnalysis.CSharp.Symbol)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 41924, 41984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10274_42031_42054(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 42031, 42054);
                    return return_v;
                }


                int
                f_10274_42018_42081(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 42018, 42081);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10274_42164_42186(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 42164, 42186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_42100_42219(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 42100, 42219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 41134, 42246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 41134, 42246);
            }
        }

        internal override OverriddenOrHiddenMembersResult OverriddenOrHiddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 42358, 42676);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 42394, 42605) || true) && (_lazyOverriddenOrHiddenMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 42394, 42605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 42478, 42586);

                        f_10274_42478_42585(ref _lazyOverriddenOrHiddenMembers, f_10274_42542_42578(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 42394, 42605);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 42623, 42661);

                    return _lazyOverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 42358, 42676);

                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10274_42542_42578(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    member)
                    {
                        var return_v = member.MakeOverriddenOrHiddenMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 42542, 42578);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    f_10274_42478_42585(ref Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 42478, 42585);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 42258, 42687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 42258, 42687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SynthesizedSealedPropertyAccessor SynthesizedSealedAccessorOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 43038, 43868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 43074, 43111);

                    bool
                    hasGetter = f_10274_43091_43100() is object
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 43129, 43166);

                    bool
                    hasSetter = f_10274_43146_43155() is object
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 43184, 43303) || true) && (f_10274_43188_43202_M(!this.IsSealed) || (DynAbs.Tracing.TraceSender.Expression_False(10274, 43188, 43230) || (hasGetter && (DynAbs.Tracing.TraceSender.Expression_True(10274, 43207, 43229) && hasSetter))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 43184, 43303);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 43272, 43284);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 43184, 43303);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 43583, 43797) || true) && ((object)_lazySynthesizedSealedAccessor == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 43583, 43797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 43675, 43778);

                        f_10274_43675_43777(ref _lazySynthesizedSealedAccessor, f_10274_43739_43770(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 43583, 43797);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 43815, 43853);

                    return _lazySynthesizedSealedAccessor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 43038, 43868);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10274_43091_43100()
                    {
                        var return_v = GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 43091, 43100);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10274_43146_43155()
                    {
                        var return_v = SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 43146, 43155);
                        return return_v;
                    }


                    bool
                    f_10274_43188_43202_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 43188, 43202);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                    f_10274_43739_43770(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.MakeSynthesizedSealedAccessor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 43739, 43770);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor?
                    f_10274_43675_43777(ref Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 43675, 43777);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 42942, 43879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 42942, 43879);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SynthesizedSealedPropertyAccessor MakeSynthesizedSealedAccessor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 44011, 45204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 44109, 44181);

                f_10274_44109_44180(f_10274_44122_44135(this) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 44122, 44179) && (f_10274_44140_44149() is null || (DynAbs.Tracing.TraceSender.Expression_False(10274, 44140, 44178) || f_10274_44161_44170() is null))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 44197, 45193) || true) && (f_10274_44201_44210() is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 44197, 45193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 44300, 44368);

                    MethodSymbol
                    overriddenAccessor = f_10274_44334_44367(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 44386, 44501);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10274, 44393, 44427) || (((object)overriddenAccessor == null && DynAbs.Tracing.TraceSender.Conditional_F2(10274, 44430, 44434)) || DynAbs.Tracing.TraceSender.Conditional_F3(10274, 44437, 44500))) ? null : f_10274_44437_44500(this, overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 44197, 45193);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 44197, 45193);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 44535, 45193) || true) && (f_10274_44539_44548() is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 44535, 45193);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 44638, 44706);

                        MethodSymbol
                        overriddenAccessor = f_10274_44672_44705(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 44724, 44839);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10274, 44731, 44765) || (((object)overriddenAccessor == null && DynAbs.Tracing.TraceSender.Conditional_F2(10274, 44768, 44772)) || DynAbs.Tracing.TraceSender.Conditional_F3(10274, 44775, 44838))) ? null : f_10274_44775_44838(this, overriddenAccessor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 44535, 45193);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 44535, 45193);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 45166, 45178);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 44535, 45193);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 44197, 45193);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 44011, 45204);

                bool
                f_10274_44122_44135(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 44122, 44135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_44140_44149()
                {
                    var return_v = GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 44140, 44149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_44161_44170()
                {
                    var return_v = SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 44161, 44170);
                    return return_v;
                }


                int
                f_10274_44109_44180(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 44109, 44180);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_44201_44210()
                {
                    var return_v = GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 44201, 44210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_44334_44367(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                property)
                {
                    var return_v = property.GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 44334, 44367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                f_10274_44437_44500(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                property, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overriddenAccessor)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor((Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)property, overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 44437, 44500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_44539_44548()
                {
                    var return_v = SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 44539, 44548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10274_44672_44705(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                property)
                {
                    var return_v = property.GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 44672, 44705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                f_10274_44775_44838(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                property, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overriddenAccessor)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor((Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)property, overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 44775, 44838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 44011, 45204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 44011, 45204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract SyntaxList<AttributeListSyntax> AttributeDeclarationSyntaxList { get; }

        public abstract IAttributeTargetSymbol AttributesOwner { get; }

        IAttributeTargetSymbol IAttributeTargetSymbol.AttributesOwner
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 45482, 45500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 45485, 45500);
                    return f_10274_45485_45500(); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 45482, 45500);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 45482, 45500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 45482, 45500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.DefaultAttributeLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 45579, 45608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 45582, 45608);
                    return AttributeLocation.Property; DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 45579, 45608);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 45579, 45608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 45579, 45608);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        AttributeLocation IAttributeTargetSymbol.AllowedAttributeLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 45701, 45851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 45704, 45851);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10274, 45704, 45733) || ((f_10274_45704_45733() && DynAbs.Tracing.TraceSender.Conditional_F2(10274, 45753, 45805)) || DynAbs.Tracing.TraceSender.Conditional_F3(10274, 45825, 45851))) ? AttributeLocation.Property | AttributeLocation.Field
                    : AttributeLocation.Property; DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 45701, 45851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 45701, 45851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 45701, 45851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CustomAttributesBag<CSharpAttributeData> GetAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 46172, 46938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 46264, 46299);

                var
                bag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 46313, 46404) || true) && (bag != null && (DynAbs.Tracing.TraceSender.Expression_True(10274, 46317, 46344) && f_10274_46332_46344(bag)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 46313, 46404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 46378, 46389);

                    return bag;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 46313, 46404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 46500, 46534);

                _ = f_10274_46504_46533_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10274_46504_46516(), 10274, 46504, 46533)?.GetAttributes());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 46550, 46817) || true) && (f_10274_46554_46659(this, f_10274_46580_46628(f_10274_46597_46627()), ref _lazyCustomAttributesBag))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 46550, 46817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 46693, 46760);

                    var
                    completed = _state.NotePartComplete(CompletionPart.Attributes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 46778, 46802);

                    f_10274_46778_46801(completed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 46550, 46817);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 46833, 46881);

                f_10274_46833_46880(f_10274_46846_46879(_lazyCustomAttributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 46895, 46927);

                return _lazyCustomAttributesBag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 46172, 46938);

                bool
                f_10274_46332_46344(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 46332, 46344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                f_10274_46504_46516()
                {
                    var return_v = BackingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 46504, 46516);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                f_10274_46504_46533_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 46504, 46533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10274_46597_46627()
                {
                    var return_v = AttributeDeclarationSyntaxList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 46597, 46627);
                    return return_v;
                }


                Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                f_10274_46580_46628(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                one)
                {
                    var return_v = OneOrMany.Create(one);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 46580, 46628);
                    return return_v;
                }


                bool
                f_10274_46554_46659(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
                attributesSyntaxLists, ref Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributesBag)
                {
                    var return_v = this_param.LoadAndValidateAttributes(attributesSyntaxLists, ref lazyCustomAttributesBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 46554, 46659);
                    return return_v;
                }


                int
                f_10274_46778_46801(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 46778, 46801);
                    return 0;
                }


                bool
                f_10274_46846_46879(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 46846, 46879);
                    return return_v;
                }


                int
                f_10274_46833_46880(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 46833, 46880);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 46172, 46938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 46172, 46938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 47371, 47523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 47470, 47512);

                return f_10274_47477_47511(f_10274_47477_47500(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 47371, 47523);

                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10274_47477_47500(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 47477, 47500);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10274_47477_47511(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 47477, 47511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 47371, 47523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 47371, 47523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PropertyWellKnownAttributeData GetDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 47812, 48251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 47910, 47955);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 47969, 48141) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10274, 47973, 48052) || f_10274_47998_48052_M(!attributesBag.IsDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 47969, 48141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 48086, 48126);

                    attributesBag = f_10274_48102_48125(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 47969, 48141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 48157, 48240);

                return (PropertyWellKnownAttributeData)f_10274_48196_48239(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 47812, 48251);

                bool
                f_10274_47998_48052_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 47998, 48052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10274_48102_48125(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 48102, 48125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownAttributeData
                f_10274_48196_48239(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.DecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 48196, 48239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 47812, 48251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 47812, 48251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PropertyEarlyWellKnownAttributeData GetEarlyDecodedWellKnownAttributeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 48560, 49025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 48669, 48714);

                var
                attributesBag = _lazyCustomAttributesBag
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 48728, 48905) || true) && (attributesBag == null || (DynAbs.Tracing.TraceSender.Expression_False(10274, 48732, 48816) || f_10274_48757_48816_M(!attributesBag.IsEarlyDecodedWellKnownAttributeDataComputed)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 48728, 48905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 48850, 48890);

                    attributesBag = f_10274_48866_48889(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 48728, 48905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 48921, 49014);

                return (PropertyEarlyWellKnownAttributeData)f_10274_48965_49013(attributesBag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 48560, 49025);

                bool
                f_10274_48757_48816_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 48757, 48816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10274_48866_48889(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.GetAttributesBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 48866, 48889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                f_10274_48965_49013(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 48965, 49013);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 48560, 49025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 48560, 49025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 49037, 50521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 49195, 49256);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10274, 49195, 49255);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 49195, 49255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 49272, 49316);

                var
                compilation = f_10274_49290_49315(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 49330, 49366);

                var
                type = f_10274_49341_49365(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 49382, 49641) || true) && (f_10274_49386_49413(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 49382, 49641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 49447, 49626);

                    f_10274_49447_49625(ref attributes, f_10274_49508_49624(compilation, type.Type, type.CustomModifiers.Length + f_10274_49588_49606().Length, _refKind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 49382, 49641);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 49657, 49848) || true) && (f_10274_49661_49694(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 49657, 49848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 49728, 49833);

                    f_10274_49728_49832(ref attributes, f_10274_49768_49831(moduleBuilder, this, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 49657, 49848);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 49864, 50062) || true) && (f_10274_49868_49898(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 49864, 50062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 49932, 50047);

                    f_10274_49932_50046(ref attributes, f_10274_49993_50045(compilation, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 49864, 50062);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 50078, 50325) || true) && (f_10274_50082_50128(compilation, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 50078, 50325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 50162, 50310);

                    f_10274_50162_50309(ref attributes, f_10274_50202_50308(moduleBuilder, this, f_10274_50261_50301(f_10274_50261_50275()), type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 50078, 50325);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 50341, 50510) || true) && (f_10274_50345_50370(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 50341, 50510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 50404, 50495);

                    f_10274_50404_50494(ref attributes, f_10274_50444_50493(moduleBuilder, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 50341, 50510);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 49037, 50521);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10274_49290_49315(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 49290, 49315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10274_49341_49365(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 49341, 49365);
                    return return_v;
                }


                bool
                f_10274_49386_49413(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 49386, 49413);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10274_49588_49606()
                {
                    var return_v = RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 49588, 49606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10274_49508_49624(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, int
                customModifiersCount, Microsoft.CodeAnalysis.RefKind
                refKindOpt)
                {
                    var return_v = this_param.SynthesizeDynamicAttribute(type, customModifiersCount, refKindOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 49508, 49624);
                    return return_v;
                }


                int
                f_10274_49447_49625(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 49447, 49625);
                    return 0;
                }


                bool
                f_10274_49661_49694(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 49661, 49694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10274_49768_49831(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeNativeIntegerAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 49768, 49831);
                    return return_v;
                }


                int
                f_10274_49728_49832(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 49728, 49832);
                    return 0;
                }


                bool
                f_10274_49868_49898(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 49868, 49898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10274_49993_50045(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeTupleNamesAttribute(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 49993, 50045);
                    return return_v;
                }


                int
                f_10274_49932_50046(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 49932, 50046);
                    return 0;
                }


                bool
                f_10274_50082_50128(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 50082, 50128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_50261_50275()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 50261, 50275);
                    return return_v;
                }


                byte?
                f_10274_50261_50301(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 50261, 50301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10274_50202_50308(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                symbol, byte?
                nullableContextValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SynthesizeNullableAttributeIfNecessary((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, nullableContextValue, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 50202, 50308);
                    return return_v;
                }


                int
                f_10274_50162_50309(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 50162, 50309);
                    return 0;
                }


                bool
                f_10274_50345_50370(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.ReturnsByRefReadonly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 50345, 50370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10274_50444_50493(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                symbol)
                {
                    var return_v = this_param.SynthesizeIsReadOnlyAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 50444, 50493);
                    return return_v;
                }


                int
                f_10274_50404_50494(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 50404, 50494);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 49037, 50521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 49037, 50521);
            }
        }

        internal sealed override bool IsDirectlyExcludedFromCodeCoverage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 50598, 50693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 50614, 50693);
                    return f_10274_50614_50685_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10274_50614_50648(this), 10274, 50614, 50685)?.HasExcludeFromCodeCoverageAttribute) == true; DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 50598, 50693);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 50598, 50693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 50598, 50693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 50768, 50935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 50804, 50850);

                    var
                    data = f_10274_50815_50849(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 50868, 50920);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10274, 50875, 50919) && f_10274_50891_50919(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 50768, 50935);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    f_10274_50815_50849(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 50815, 50849);
                        return return_v;
                    }


                    bool
                    f_10274_50891_50919(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasSpecialNameAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 50891, 50919);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 50706, 50946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 50706, 50946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CSharpAttributeData EarlyDecodeWellKnownAttribute(ref EarlyDecodeWellKnownAttributeArguments<EarlyWellKnownAttributeBinder, NamedTypeSymbol, AttributeSyntax, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 50958, 52733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 51188, 51223);

                CSharpAttributeData
                boundAttribute
                = default(CSharpAttributeData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 51237, 51272);

                ObsoleteAttributeData
                obsoleteData
                = default(ObsoleteAttributeData);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 51288, 51677) || true) && (f_10274_51292_51399(ref arguments, out boundAttribute, out obsoleteData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 51288, 51677);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 51433, 51620) || true) && (obsoleteData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 51433, 51620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 51499, 51601);

                        arguments.GetOrCreateData<PropertyEarlyWellKnownAttributeData>().ObsoleteAttributeData = obsoleteData;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 51433, 51620);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 51640, 51662);

                    return boundAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 51288, 51677);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 51693, 52649) || true) && (f_10274_51697_51834(arguments.AttributeType, arguments.AttributeSyntax, AttributeDescription.IndexerNameAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 51693, 52649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 51868, 51891);

                    bool
                    hasAnyDiagnostics
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 51909, 52031);

                    boundAttribute = f_10274_51926_52030(arguments.Binder, arguments.AttributeSyntax, arguments.AttributeType, out hasAnyDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 52049, 52602) || true) && (f_10274_52053_52078_M(!boundAttribute.HasErrors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 52049, 52602);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 52120, 52233);

                        string
                        indexerName = f_10274_52141_52182(boundAttribute)[0].DecodeValue<string>(SpecialType.System_String)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 52255, 52442) || true) && (indexerName != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 52255, 52442);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 52328, 52419);

                            arguments.GetOrCreateData<PropertyEarlyWellKnownAttributeData>().IndexerName = indexerName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 52255, 52442);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 52466, 52583) || true) && (!hasAnyDiagnostics)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 52466, 52583);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 52538, 52560);

                            return boundAttribute;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 52466, 52583);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 52049, 52602);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 52622, 52634);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 51693, 52649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 52665, 52722);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EarlyDecodeWellKnownAttribute(ref arguments), 10274, 52672, 52721);

                var temp = base.EarlyDecodeWellKnownAttribute(ref arguments);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 52672, 52721);
                return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 50958, 52733);

                bool
                f_10274_51292_51399(ref Microsoft.CodeAnalysis.EarlyDecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, out Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attributeData, out Microsoft.CodeAnalysis.ObsoleteAttributeData
                obsoleteData)
                {
                    var return_v = EarlyDecodeDeprecatedOrExperimentalOrObsoleteAttribute(ref arguments, out attributeData, out obsoleteData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 51292, 51399);
                    return return_v;
                }


                bool
                f_10274_51697_51834(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = CSharpAttributeData.IsTargetEarlyAttribute(attributeType, attributeSyntax, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 51697, 51834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                f_10274_51926_52030(Microsoft.CodeAnalysis.CSharp.EarlyWellKnownAttributeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                boundAttributeType, out bool
                generatedDiagnostics)
                {
                    var return_v = this_param.GetAttribute(node, boundAttributeType, out generatedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 51926, 52030);
                    return return_v;
                }


                bool
                f_10274_52053_52078_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 52053, 52078);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10274_52141_52182(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 52141, 52182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 50958, 52733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 50958, 52733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 53099, 53718);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 53135, 53251) || true) && (f_10274_53139_53178_M(!_containingType.AnyMemberHasAttributes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 53135, 53251);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 53220, 53232);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 53135, 53251);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 53271, 53326);

                    var
                    lazyCustomAttributesBag = _lazyCustomAttributesBag
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 53344, 53640) || true) && (lazyCustomAttributesBag != null && (DynAbs.Tracing.TraceSender.Expression_True(10274, 53348, 53451) && f_10274_53383_53451(lazyCustomAttributesBag)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 53344, 53640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 53493, 53621);

                        return f_10274_53500_53620_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(((PropertyEarlyWellKnownAttributeData)f_10274_53538_53596(lazyCustomAttributesBag)), 10274, 53500, 53620)?.ObsoleteAttributeData);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 53344, 53640);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 53660, 53703);

                    return ObsoleteAttributeData.Uninitialized;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 53099, 53718);

                    bool
                    f_10274_53139_53178_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 53139, 53178);
                        return return_v;
                    }


                    bool
                    f_10274_53383_53451(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.IsEarlyDecodedWellKnownAttributeDataComputed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 53383, 53451);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
                    f_10274_53538_53596(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    this_param)
                    {
                        var return_v = this_param.EarlyDecodedWellKnownAttributeData;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 53538, 53596);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ObsoleteAttributeData?
                    f_10274_53500_53620_M(Microsoft.CodeAnalysis.ObsoleteAttributeData?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 53500, 53620);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 53013, 53729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 53013, 53729);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void DecodeWellKnownAttribute(ref DecodeWellKnownAttributeArguments<AttributeSyntax, CSharpAttributeData, AttributeLocation> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 53741, 57706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 53919, 53970);

                f_10274_53919_53969(arguments.AttributeSyntaxOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 53986, 54022);

                var
                attribute = arguments.Attribute
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 54036, 54071);

                f_10274_54036_54070(f_10274_54049_54069_M(!attribute.HasErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 54085, 54146);

                f_10274_54085_54145(arguments.SymbolPart == AttributeLocation.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 54162, 57695) || true) && (f_10274_54166_54242(attribute, this, AttributeDescription.IndexerNameAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 54162, 57695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 54353, 54446);

                    f_10274_54353_54445(this, attribute, arguments.AttributeSyntaxOpt, arguments.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 54162, 57695);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 54162, 57695);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 54480, 57695) || true) && (f_10274_54484_54560(attribute, this, AttributeDescription.SpecialNameAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 54480, 57695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 54594, 54685);

                        arguments.GetOrCreateData<PropertyWellKnownAttributeData>().HasSpecialNameAttribute = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 54480, 57695);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 54480, 57695);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 54719, 57695) || true) && (f_10274_54723_54811(attribute, this, AttributeDescription.ExcludeFromCodeCoverageAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 54719, 57695);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 54845, 54948);

                            arguments.GetOrCreateData<PropertyWellKnownAttributeData>().HasExcludeFromCodeCoverageAttribute = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 54719, 57695);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 54719, 57695);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 54982, 57695) || true) && (f_10274_54986_55065(attribute, this, AttributeDescription.SkipLocalsInitAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 54982, 57695);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 55099, 55218);

                                f_10274_55099_55217(f_10274_55181_55201(), ref arguments);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 54982, 57695);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 54982, 57695);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 55252, 57695) || true) && (f_10274_55256_55328(attribute, this, AttributeDescription.DynamicAttribute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 55252, 57695);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 55429, 55529);

                                    f_10274_55429_55528(                // DynamicAttribute should not be set explicitly.
                                                    arguments.Diagnostics, ErrorCode.ERR_ExplicitDynamicAttr, f_10274_55490_55527(arguments.AttributeSyntaxOpt));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 55252, 57695);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 55252, 57695);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 55563, 57695) || true) && (f_10274_55567_55928(this, arguments, ReservedAttributes.DynamicAttribute | ReservedAttributes.IsReadOnlyAttribute | ReservedAttributes.IsUnmanagedAttribute | ReservedAttributes.IsByRefLikeAttribute | ReservedAttributes.TupleElementNamesAttribute | ReservedAttributes.NullableAttribute | ReservedAttributes.NativeIntegerAttribute))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 55563, 57695);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 55563, 57695);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 55563, 57695);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 55978, 57695) || true) && (f_10274_55982_56059(attribute, this, AttributeDescription.DisallowNullAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 55978, 57695);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 56093, 56185);

                                            arguments.GetOrCreateData<PropertyWellKnownAttributeData>().HasDisallowNullAttribute = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 55978, 57695);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 55978, 57695);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 56219, 57695) || true) && (f_10274_56223_56297(attribute, this, AttributeDescription.AllowNullAttribute))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 56219, 57695);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 56331, 56420);

                                                arguments.GetOrCreateData<PropertyWellKnownAttributeData>().HasAllowNullAttribute = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 56219, 57695);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 56219, 57695);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 56454, 57695) || true) && (f_10274_56458_56532(attribute, this, AttributeDescription.MaybeNullAttribute))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 56454, 57695);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 56566, 56655);

                                                    arguments.GetOrCreateData<PropertyWellKnownAttributeData>().HasMaybeNullAttribute = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 56454, 57695);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 56454, 57695);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 56689, 57695) || true) && (f_10274_56693_56765(attribute, this, AttributeDescription.NotNullAttribute))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 56689, 57695);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 56799, 56886);

                                                        arguments.GetOrCreateData<PropertyWellKnownAttributeData>().HasNotNullAttribute = true;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 56689, 57695);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 56689, 57695);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 56920, 57695) || true) && (f_10274_56924_57002(attribute, this, AttributeDescription.MemberNotNullAttribute))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 56920, 57695);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 57036, 57149);

                                                            f_10274_57036_57148(MessageID.IDS_FeatureMemberNotNull, arguments.Diagnostics, arguments.AttributeSyntaxOpt);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 57167, 57279);

                                                            f_10274_57167_57278(f_10274_57248_57262(), ref arguments);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 56920, 57695);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 56920, 57695);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 57313, 57695) || true) && (f_10274_57317_57399(attribute, this, AttributeDescription.MemberNotNullWhenAttribute))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 57313, 57695);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 57433, 57546);

                                                                f_10274_57433_57545(MessageID.IDS_FeatureMemberNotNull, arguments.Diagnostics, arguments.AttributeSyntaxOpt);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 57564, 57680);

                                                                f_10274_57564_57679(f_10274_57649_57663(), ref arguments);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 57313, 57695);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 56920, 57695);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 56689, 57695);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 56454, 57695);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 56219, 57695);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 55978, 57695);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 55563, 57695);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 55252, 57695);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 54982, 57695);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 54719, 57695);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 54480, 57695);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 54162, 57695);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 53741, 57706);

                int
                f_10274_53919_53969(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 53919, 53969);
                    return 0;
                }


                bool
                f_10274_54049_54069_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 54049, 54069);
                    return return_v;
                }


                int
                f_10274_54036_54070(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 54036, 54070);
                    return 0;
                }


                int
                f_10274_54085_54145(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 54085, 54145);
                    return 0;
                }


                bool
                f_10274_54166_54242(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 54166, 54242);
                    return return_v;
                }


                int
                f_10274_54353_54445(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                attribute, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateIndexerNameAttribute(attribute, node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 54353, 54445);
                    return 0;
                }


                bool
                f_10274_54484_54560(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 54484, 54560);
                    return return_v;
                }


                bool
                f_10274_54723_54811(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 54723, 54811);
                    return return_v;
                }


                bool
                f_10274_54986_55065(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 54986, 55065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10274_55181_55201()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 55181, 55201);
                    return return_v;
                }


                int
                f_10274_55099_55217(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    CSharpAttributeData.DecodeSkipLocalsInitAttribute<PropertyWellKnownAttributeData>(compilation, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 55099, 55217);
                    return 0;
                }


                bool
                f_10274_55256_55328(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 55256, 55328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_55490_55527(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 55490, 55527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_55429_55528(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 55429, 55528);
                    return return_v;
                }


                bool
                f_10274_55567_55928(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param, Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments, Microsoft.CodeAnalysis.CSharp.Symbol.ReservedAttributes
                reserved)
                {
                    var return_v = this_param.ReportExplicitUseOfReservedAttributes(arguments, reserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 55567, 55928);
                    return return_v;
                }


                bool
                f_10274_55982_56059(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 55982, 56059);
                    return return_v;
                }


                bool
                f_10274_56223_56297(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 56223, 56297);
                    return return_v;
                }


                bool
                f_10274_56458_56532(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 56458, 56532);
                    return return_v;
                }


                bool
                f_10274_56693_56765(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 56693, 56765);
                    return return_v;
                }


                bool
                f_10274_56924_57002(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 56924, 57002);
                    return return_v;
                }


                bool
                f_10274_57036_57148(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                syntax)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 57036, 57148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_57248_57262()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 57248, 57262);
                    return return_v;
                }


                int
                f_10274_57167_57278(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    CSharpAttributeData.DecodeMemberNotNullAttribute<PropertyWellKnownAttributeData>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 57167, 57278);
                    return 0;
                }


                bool
                f_10274_57317_57399(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 57317, 57399);
                    return return_v;
                }


                bool
                f_10274_57433_57545(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                syntax)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 57433, 57545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_57649_57663()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 57649, 57663);
                    return return_v;
                }


                int
                f_10274_57564_57679(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref Microsoft.CodeAnalysis.DecodeWellKnownAttributeArguments<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.Symbols.AttributeLocation>
                arguments)
                {
                    CSharpAttributeData.DecodeMemberNotNullWhenAttribute<PropertyWellKnownAttributeData>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, ref arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 57564, 57679);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 53741, 57706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 53741, 57706);
            }
        }

        internal bool HasDisallowNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 57772, 57940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 57808, 57854);

                    var
                    data = f_10274_57819_57853(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 57872, 57925);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10274, 57879, 57924) && f_10274_57895_57924(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 57772, 57940);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    f_10274_57819_57853(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 57819, 57853);
                        return return_v;
                    }


                    bool
                    f_10274_57895_57924(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasDisallowNullAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 57895, 57924);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 57718, 57951);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 57718, 57951);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasAllowNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 58014, 58179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 58050, 58096);

                    var
                    data = f_10274_58061_58095(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 58114, 58164);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10274, 58121, 58163) && f_10274_58137_58163(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 58014, 58179);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    f_10274_58061_58095(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 58061, 58095);
                        return return_v;
                    }


                    bool
                    f_10274_58137_58163(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasAllowNullAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 58137, 58163);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 57963, 58190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 57963, 58190);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasMaybeNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 58253, 58418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 58289, 58335);

                    var
                    data = f_10274_58300_58334(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 58353, 58403);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10274, 58360, 58402) && f_10274_58376_58402(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 58253, 58418);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    f_10274_58300_58334(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 58300, 58334);
                        return return_v;
                    }


                    bool
                    f_10274_58376_58402(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasMaybeNullAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 58376, 58402);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 58202, 58429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 58202, 58429);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 58490, 58653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 58526, 58572);

                    var
                    data = f_10274_58537_58571(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 58590, 58638);

                    return data != null && (DynAbs.Tracing.TraceSender.Expression_True(10274, 58597, 58637) && f_10274_58613_58637(data));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 58490, 58653);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    f_10274_58537_58571(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                    this_param)
                    {
                        var return_v = this_param.GetDecodedWellKnownAttributeData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 58537, 58571);
                        return return_v;
                    }


                    bool
                    f_10274_58613_58637(Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasNotNullAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 58613, 58637);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 58441, 58664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 58441, 58664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SourceAttributeData DisallowNullAttributeIfExists
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 58748, 58808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 58751, 58808);
                    return f_10274_58751_58808(this, AttributeDescription.DisallowNullAttribute); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 58748, 58808);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 58748, 58808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 58748, 58808);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SourceAttributeData AllowNullAttributeIfExists
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 58890, 58947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 58893, 58947);
                    return f_10274_58893_58947(this, AttributeDescription.AllowNullAttribute); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 58890, 58947);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 58890, 58947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 58890, 58947);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SourceAttributeData MaybeNullAttributeIfExists
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 59029, 59086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 59032, 59086);
                    return f_10274_59032_59086(this, AttributeDescription.MaybeNullAttribute); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 59029, 59086);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 59029, 59086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 59029, 59086);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SourceAttributeData NotNullAttributeIfExists
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 59166, 59221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 59169, 59221);
                    return f_10274_59169_59221(this, AttributeDescription.NotNullAttribute); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 59166, 59221);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 59166, 59221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 59166, 59221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<SourceAttributeData> MemberNotNullAttributeIfExists
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 59323, 59385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 59326, 59385);
                    return f_10274_59326_59385(this, AttributeDescription.MemberNotNullAttribute); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 59323, 59385);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 59323, 59385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 59323, 59385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<SourceAttributeData> MemberNotNullWhenAttributeIfExists
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 59491, 59557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 59494, 59557);
                    return f_10274_59494_59557(this, AttributeDescription.MemberNotNullWhenAttribute); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 59491, 59557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 59491, 59557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 59491, 59557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SourceAttributeData FindAttribute(AttributeDescription attributeDescription)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 59668, 59767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 59671, 59767);
                return (SourceAttributeData)f_10274_59692_59707(this).First(a => a.IsTargetAttribute(this, attributeDescription)); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 59668, 59767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 59668, 59767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 59668, 59767);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
            f_10274_59692_59707(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
            this_param)
            {
                var return_v = this_param.GetAttributes();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 59692, 59707);
                return return_v;
            }

        }

        private ImmutableArray<SourceAttributeData> FindAttributes(AttributeDescription attributeDescription)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 59895, 60020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 59898, 60020);
                return f_10274_59898_60020(f_10274_59898_60001(f_10274_59898_59913(this).Where(a => a.IsTargetAttribute(this, attributeDescription)))); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 59895, 60020);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 59895, 60020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 59895, 60020);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
            f_10274_59898_59913(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
            this_param)
            {
                var return_v = this_param.GetAttributes();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 59898, 59913);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
            f_10274_59898_60001(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
            source)
            {
                var return_v = source.Cast<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 59898, 60001);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
            f_10274_59898_60020(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
            items)
            {
                var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 59898, 60020);
                return return_v;
            }

        }

        internal override void PostDecodeWellKnownAttributes(ImmutableArray<CSharpAttributeData> boundAttributes, ImmutableArray<AttributeSyntax> allAttributeSyntaxNodes, DiagnosticBag diagnostics, AttributeLocation symbolPart, WellKnownAttributeData decodedData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 60033, 60863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 60313, 60354);

                f_10274_60313_60353(f_10274_60326_60352_M(!boundAttributes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 60368, 60417);

                f_10274_60368_60416(f_10274_60381_60415_M(!allAttributeSyntaxNodes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 60431, 60502);

                f_10274_60431_60501(boundAttributes.Length == allAttributeSyntaxNodes.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 60516, 60563);

                f_10274_60516_60562(_lazyCustomAttributesBag != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 60577, 60656);

                f_10274_60577_60655(f_10274_60590_60654(_lazyCustomAttributesBag));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 60670, 60721);

                f_10274_60670_60720(symbolPart == AttributeLocation.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 60737, 60852);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.PostDecodeWellKnownAttributes(boundAttributes, allAttributeSyntaxNodes, diagnostics, symbolPart, decodedData), 10274, 60737, 60851);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 60033, 60863);

                bool
                f_10274_60326_60352_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 60326, 60352);
                    return return_v;
                }


                int
                f_10274_60313_60353(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 60313, 60353);
                    return 0;
                }


                bool
                f_10274_60381_60415_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 60381, 60415);
                    return return_v;
                }


                int
                f_10274_60368_60416(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 60368, 60416);
                    return 0;
                }


                int
                f_10274_60431_60501(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 60431, 60501);
                    return 0;
                }


                int
                f_10274_60516_60562(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 60516, 60562);
                    return 0;
                }


                bool
                f_10274_60590_60654(Microsoft.CodeAnalysis.CustomAttributesBag<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.IsDecodedWellKnownAttributeDataComputed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 60590, 60654);
                    return return_v;
                }


                int
                f_10274_60577_60655(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 60577, 60655);
                    return 0;
                }


                int
                f_10274_60670_60720(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 60670, 60720);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 60033, 60863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 60033, 60863);
            }
        }

        private void ValidateIndexerNameAttribute(CSharpAttributeData attribute, AttributeSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 60875, 61686);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 61021, 61675) || true) && (f_10274_61025_61040_M(!this.IsIndexer) || (DynAbs.Tracing.TraceSender.Expression_False(10274, 61025, 61082) || f_10274_61044_61082(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 61021, 61675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 61116, 61214);

                    f_10274_61116_61213(diagnostics, ErrorCode.ERR_BadIndexerNameAttr, f_10274_61166_61184(f_10274_61166_61175(node)), f_10274_61186_61212(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 61021, 61675);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 61021, 61675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 61280, 61388);

                    string
                    indexerName = f_10274_61301_61337(attribute)[0].DecodeValue<string>(SpecialType.System_String)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 61406, 61660) || true) && (indexerName == null || (DynAbs.Tracing.TraceSender.Expression_False(10274, 61410, 61476) || !f_10274_61434_61476(indexerName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 61406, 61660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 61518, 61641);

                        f_10274_61518_61640(diagnostics, ErrorCode.ERR_BadArgumentToAttribute, f_10274_61572_61611(f_10274_61572_61599(f_10274_61572_61589(node))[0]), f_10274_61613_61639(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 61406, 61660);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 61021, 61675);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 60875, 61686);

                bool
                f_10274_61025_61040_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 61025, 61040);
                    return return_v;
                }


                bool
                f_10274_61044_61082(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 61044, 61082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10274_61166_61175(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 61166, 61175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_61166_61184(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 61166, 61184);
                    return return_v;
                }


                string
                f_10274_61186_61212(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 61186, 61212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_61116_61213(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 61116, 61213);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10274_61301_61337(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 61301, 61337);
                    return return_v;
                }


                bool
                f_10274_61434_61476(string
                name)
                {
                    var return_v = SyntaxFacts.IsValidIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 61434, 61476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                f_10274_61572_61589(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 61572, 61589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10274_61572_61599(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 61572, 61599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_61572_61611(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 61572, 61611);
                    return return_v;
                }


                string
                f_10274_61613_61639(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 61613, 61639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_61518_61640(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 61518, 61640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 60875, 61686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 60875, 61686);
            }
        }

        internal sealed override bool RequiresCompletion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 61823, 61843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 61829, 61841);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 61823, 61843);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 61750, 61854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 61750, 61854);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 61866, 61996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 61953, 61985);

                return _state.HasComplete(part);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 61866, 61996);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 61866, 61996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 61866, 61996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var incompletePart = _state.NextIncompletePart;
                switch (incompletePart)
                {
                    case CompletionPart.Attributes:
                        GetAttributes();
                        break;

                    case CompletionPart.StartPropertyEnsureSignature:
                    case CompletionPart.FinishPropertyEnsureSignature:
                        EnsureSignature();
                        Debug.Assert(_state.HasComplete(CompletionPart.FinishPropertyEnsureSignature));
                        break;

                    case CompletionPart.StartPropertyParameters:
                    case CompletionPart.FinishPropertyParameters:
                        {
                            if (_state.NotePartComplete(CompletionPart.StartPropertyParameters))
                            {
                                var parameters = this.Parameters;
                                if (parameters.Length > 0)
                                {
                                    var diagnostics = DiagnosticBag.GetInstance();
                                    var conversions = new TypeConversions(this.ContainingAssembly.CorLibrary);
                                    foreach (var parameter in this.Parameters)
                                    {
                                        parameter.ForceComplete(locationOpt, cancellationToken);
                                        parameter.Type.CheckAllConstraints(DeclaringCompilation, conversions, parameter.Locations[0], diagnostics);
                                    }

                                    this.AddDeclarationDiagnostics(diagnostics);
                                    diagnostics.Free();
                                }

                                DeclaringCompilation.SymbolDeclaredEvent(this);
                                var completedOnThisThread = _state.NotePartComplete(CompletionPart.FinishPropertyParameters);
                                Debug.Assert(completedOnThisThread);
                            }
                            else
                            {
                                // StartPropertyParameters was completed by another thread. Wait for it to finish the parameters.
                                _state.SpinWaitComplete(CompletionPart.FinishPropertyParameters, cancellationToken);
                            }
                        }
                        break;

                    case CompletionPart.StartPropertyType:
                    case CompletionPart.FinishPropertyType:
                        {
                            if (_state.NotePartComplete(CompletionPart.StartPropertyType))
                            {
                                var diagnostics = DiagnosticBag.GetInstance();
                                var conversions = new TypeConversions(this.ContainingAssembly.CorLibrary);
                                this.Type.CheckAllConstraints(DeclaringCompilation, conversions, Location, diagnostics);

                                ValidatePropertyType(diagnostics);

                                this.AddDeclarationDiagnostics(diagnostics);
                                var completedOnThisThread = _state.NotePartComplete(CompletionPart.FinishPropertyType);
                                Debug.Assert(completedOnThisThread);
                                diagnostics.Free();
                            }
                            else
                            {
                                // StartPropertyType was completed by another thread. Wait for it to finish the type.
                                _state.SpinWaitComplete(CompletionPart.FinishPropertyType, cancellationToken);
                            }
                        }
                        break;

                    case CompletionPart.None:
                        return;

                    default:
                        // any other values are completion parts intended for other kinds of symbols
                        _state.NotePartComplete(CompletionPart.All & ~CompletionPart.PropertySymbolAll);
                        break;
                }

                _state.SpinWaitComplete(incompletePart, cancellationToken);
            }
        }

        protected virtual void ValidatePropertyType(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 66635, 67211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 66730, 66751);

                var
                type = f_10274_66741_66750(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 66765, 67200) || true) && (f_10274_66769_66817(type, ignoreSpanLikeTypes: true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 66765, 67200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 66851, 66920);

                    f_10274_66851_66919(diagnostics, ErrorCode.ERR_FieldCantBeRefAny, f_10274_66900_66912(), type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 66765, 67200);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 66765, 67200);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 66954, 67200) || true) && (f_10274_66958_66992(this) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 66958, 67014) && f_10274_66996_67014(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10274, 66958, 67071) && (f_10274_67019_67032(this) || (DynAbs.Tracing.TraceSender.Expression_False(10274, 67019, 67070) || f_10274_67036_67070_M(!f_10274_67037_67056(this).IsRefLikeType)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10274, 66954, 67200);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 67105, 67185);

                        f_10274_67105_67184(diagnostics, ErrorCode.ERR_FieldAutoPropCantBeByRefLike, f_10274_67165_67177(), type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 66954, 67200);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10274, 66765, 67200);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 66635, 67211);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10274_66741_66750(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 66741, 66750);
                    return return_v;
                }


                bool
                f_10274_66769_66817(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                ignoreSpanLikeTypes)
                {
                    var return_v = type.IsRestrictedType(ignoreSpanLikeTypes: ignoreSpanLikeTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 66769, 66817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_66900_66912()
                {
                    var return_v = TypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 66900, 66912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_66851_66919(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 66851, 66919);
                    return return_v;
                }


                bool
                f_10274_66958_66992(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsAutoPropertyWithGetAccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 66958, 66992);
                    return return_v;
                }


                bool
                f_10274_66996_67014(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 66996, 67014);
                    return return_v;
                }


                bool
                f_10274_67019_67032(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 67019, 67032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10274_67037_67056(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 67037, 67056);
                    return return_v;
                }


                bool
                f_10274_67036_67070_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 67036, 67070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10274_67165_67177()
                {
                    var return_v = TypeLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 67165, 67177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10274_67105_67184(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 67105, 67184);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 66635, 67211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 66635, 67211);
            }
        }

        protected abstract (TypeWithAnnotations Type, ImmutableArray<ParameterSymbol> Parameters) MakeParametersAndBindType(DiagnosticBag diagnostics);

        protected static ExplicitInterfaceSpecifierSyntax? GetExplicitInterfaceSpecifier(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 67533, 67774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 67657, 67774);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10274, 67657, 67698) || ((            // LAFHIS
                                                                                                        //(syntax as BasePropertyDeclarationSyntax)?.ExplicitInterfaceSpecifier
                            (syntax is BasePropertyDeclarationSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10274, 67701, 67767)) || DynAbs.Tracing.TraceSender.Conditional_F3(10274, 67770, 67774))) ? f_10274_67701_67767(((BasePropertyDeclarationSyntax)syntax)) : null; DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 67533, 67774);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 67533, 67774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 67533, 67774);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
            f_10274_67701_67767(Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
            this_param)
            {
                var return_v = this_param.ExplicitInterfaceSpecifier;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 67701, 67767);
                return return_v;
            }

        }

        internal ExplicitInterfaceSpecifierSyntax? GetExplicitInterfaceSpecifier()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10274, 67875, 67925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 67878, 67925);
                return f_10274_67878_67925(f_10274_67908_67924()); DynAbs.Tracing.TraceSender.TraceExitMethod(10274, 67875, 67925);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10274, 67875, 67925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 67875, 67925);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            f_10274_67908_67924()
            {
                var return_v = CSharpSyntaxNode;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 67908, 67924);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
            f_10274_67878_67925(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            syntax)
            {
                var return_v = GetExplicitInterfaceSpecifier((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 67878, 67925);
                return return_v;
            }

        }

        static SourcePropertySymbolBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10274, 638, 67952);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10274, 767, 794);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10274, 638, 67952);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10274, 638, 67952);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10274, 638, 67952);

        int
        f_10274_3620_3672(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 3620, 3672);
            return 0;
        }


        int
        f_10274_3687_3739(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 3687, 3739);
            return 0;
        }


        Microsoft.CodeAnalysis.SyntaxReference
        f_10274_3769_3790(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        this_param)
        {
            var return_v = this_param.GetReference();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 3769, 3790);
            return return_v;
        }


        bool
        f_10274_4339_4348()
        {
            var return_v = IsIndexer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 4339, 4348);
            return return_v;
        }


        bool
        f_10274_4400_4426(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 4400, 4426);
            return return_v;
        }


        bool
        f_10274_4430_4439_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 4430, 4439);
            return return_v;
        }


        bool
        f_10274_4444_4455_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 4444, 4455);
            return return_v;
        }


        bool
        f_10274_4459_4468_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 4459, 4468);
            return return_v;
        }


        int
        f_10274_5150_5196(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 5150, 5196);
            return 0;
        }


        string
        f_10274_5244_5355(string
        name, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        explicitInterfaceTypeOpt, string?
        aliasQualifierOpt)
        {
            var return_v = ExplicitInterfaceHelpers.GetMemberName(name, explicitInterfaceTypeOpt, aliasQualifierOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 5244, 5355);
            return return_v;
        }


        bool
        f_10274_5593_5603_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 5593, 5603);
            return return_v;
        }


        int
        f_10274_5580_5604(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 5580, 5604);
            return 0;
        }


        string
        f_10274_5642_5684(string
        propertyName)
        {
            var return_v = GeneratedNames.MakeBackingFieldName(propertyName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 5642, 5684);
            return return_v;
        }


        bool
        f_10274_6045_6058(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 6045, 6058);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
        f_10274_5718_6146(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        property, string
        name, bool
        isReadOnly, bool
        isStatic, bool
        hasInitializer)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol(property, name, isReadOnly: isReadOnly, isStatic, hasInitializer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 5718, 6146);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        f_10274_6243_6319(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param, bool
        isAutoPropertyAccessor, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = this_param.CreateGetAccessorSymbol(isAutoPropertyAccessor: isAutoPropertyAccessor, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 6243, 6319);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertyAccessorSymbol
        f_10274_6416_6492(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param, bool
        isAutoPropertyAccessor, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = this_param.CreateSetAccessorSymbol(isAutoPropertyAccessor: isAutoPropertyAccessor, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 6416, 6492);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData?
        f_10274_12166_12200(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 12166, 12200);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>?
        f_10274_12166_12216_M(System.Collections.Immutable.ImmutableArray<string>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 12166, 12216);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData?
        f_10274_12348_12382(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 12348, 12382);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>?
        f_10274_12348_12406_M(System.Collections.Immutable.ImmutableArray<string>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 12348, 12406);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData?
        f_10274_12539_12573(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 12539, 12573);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<string>?
        f_10274_12539_12598_M(System.Collections.Immutable.ImmutableArray<string>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 12539, 12598);
            return return_v;
        }


        bool
        f_10274_25853_25867()
        {
            var return_v = IsAutoProperty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 25853, 25867);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.IAttributeTargetSymbol
        f_10274_45485_45500()
        {
            var return_v = AttributesOwner;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 45485, 45500);
            return return_v;
        }


        bool
        f_10274_45704_45733()
        {
            var return_v = IsAutoPropertyWithGetAccessor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 45704, 45733);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.PropertyWellKnownAttributeData?
        f_10274_50614_50648(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param)
        {
            var return_v = this_param?.GetDecodedWellKnownAttributeData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 50614, 50648);
            return return_v;
        }


        bool?
        f_10274_50614_50685_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10274, 50614, 50685);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        f_10274_58751_58808(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param, Microsoft.CodeAnalysis.AttributeDescription
        attributeDescription)
        {
            var return_v = this_param.FindAttribute(attributeDescription);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 58751, 58808);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        f_10274_58893_58947(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param, Microsoft.CodeAnalysis.AttributeDescription
        attributeDescription)
        {
            var return_v = this_param.FindAttribute(attributeDescription);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 58893, 58947);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        f_10274_59032_59086(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param, Microsoft.CodeAnalysis.AttributeDescription
        attributeDescription)
        {
            var return_v = this_param.FindAttribute(attributeDescription);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 59032, 59086);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
        f_10274_59169_59221(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param, Microsoft.CodeAnalysis.AttributeDescription
        attributeDescription)
        {
            var return_v = this_param.FindAttribute(attributeDescription);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 59169, 59221);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
        f_10274_59326_59385(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param, Microsoft.CodeAnalysis.AttributeDescription
        attributeDescription)
        {
            var return_v = this_param.FindAttributes(attributeDescription);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 59326, 59385);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData>
        f_10274_59494_59557(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
        this_param, Microsoft.CodeAnalysis.AttributeDescription
        attributeDescription)
        {
            var return_v = this_param.FindAttributes(attributeDescription);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10274, 59494, 59557);
            return return_v;
        }

    }
}
