// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.DocumentationComments;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal class PEPropertySymbol
            : PropertySymbol
    {
        private readonly string _name;

        private readonly PENamedTypeSymbol _containingType;

        private readonly PropertyDefinitionHandle _handle;

        private readonly ImmutableArray<ParameterSymbol> _parameters;

        private readonly RefKind _refKind;

        private readonly TypeWithAnnotations _propertyTypeWithAnnotations;

        private readonly PEMethodSymbol _getMethod;

        private readonly PEMethodSymbol _setMethod;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        private Tuple<CultureInfo, string> _lazyDocComment;

        private DiagnosticInfo _lazyUseSiteDiagnostic;

        private ObsoleteAttributeData _lazyObsoleteAttributeData;

        private const int
        UnsetAccessibility = -1
        ;

        private int _declaredAccessibility;

        private readonly Flags _flags;

        [Flags]
        private enum Flags : byte
        {
            IsSpecialName = 1,
            IsRuntimeSpecialName = 2,
            CallMethodsDirectly = 4
        }

        internal static PEPropertySymbol Create(
                    PEModuleSymbol moduleSymbol,
                    PENamedTypeSymbol containingType,
                    PropertyDefinitionHandle handle,
                    PEMethodSymbol getMethod,
                    PEMethodSymbol setMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10713, 2352, 4008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 2630, 2673);

                f_10713_2630_2672((object)moduleSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 2687, 2732);

                f_10713_2687_2731((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 2746, 2774);

                f_10713_2746_2773(f_10713_2759_2772_M(!handle.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 2790, 2862);

                var
                metadataDecoder = f_10713_2812_2861(moduleSymbol, containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 2876, 2910);

                SignatureHeader
                callingConvention
                = default(SignatureHeader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 2924, 2955);

                BadImageFormatException
                propEx
                = default(BadImageFormatException);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 2969, 3073);

                var
                propertyParams = f_10713_2990_3072(metadataDecoder, handle, out callingConvention, out propEx)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 3087, 3127);

                f_10713_3087_3126(f_10713_3100_3121(propertyParams) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 3143, 3178);

                var
                returnInfo = propertyParams[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 3194, 3599);

                PEPropertySymbol
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10713, 3220, 3313) || ((returnInfo.CustomModifiers.IsDefaultOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10713, 3220, 3313) && returnInfo.RefCustomModifiers.IsDefaultOrEmpty
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(10713, 3333, 3446)) || DynAbs.Tracing.TraceSender.Conditional_F3(10713, 3466, 3598))) ? f_10713_3333_3446(moduleSymbol, containingType, handle, getMethod, setMethod, propertyParams, metadataDecoder) : f_10713_3466_3598(moduleSymbol, containingType, handle, getMethod, setMethod, propertyParams, metadataDecoder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 3690, 3787);

                var
                isBad = (f_10713_3703_3717(result) == RefKind.In) != result.RefCustomModifiers.HasInAttributeModifier()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 3803, 3967) || true) && (propEx != null || (DynAbs.Tracing.TraceSender.Expression_False(10713, 3807, 3830) || isBad))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 3803, 3967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 3864, 3952);

                    result._lazyUseSiteDiagnostic = f_10713_3896_3951(ErrorCode.ERR_BindToBogus, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 3803, 3967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 3983, 3997);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10713, 2352, 4008);

                int
                f_10713_2630_2672(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 2630, 2672);
                    return 0;
                }


                int
                f_10713_2687_2731(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 2687, 2731);
                    return 0;
                }


                bool
                f_10713_2759_2772_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 2759, 2772);
                    return return_v;
                }


                int
                f_10713_2746_2773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 2746, 2773);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10713_2812_2861(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 2812, 2861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                f_10713_2990_3072(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                handle, out System.Reflection.Metadata.SignatureHeader
                signatureHeader, out System.BadImageFormatException
                BadImageFormatException)
                {
                    var return_v = this_param.GetSignatureForProperty(handle, out signatureHeader, out BadImageFormatException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 2990, 3072);
                    return return_v;
                }


                int
                f_10713_3100_3121(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 3100, 3121);
                    return return_v;
                }


                int
                f_10713_3087_3126(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 3087, 3126);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                f_10713_3333_3446(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType, System.Reflection.Metadata.PropertyDefinitionHandle
                handle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                getMethod, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                setMethod, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                propertyParams, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                metadataDecoder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol(moduleSymbol, containingType, handle, getMethod, setMethod, propertyParams, metadataDecoder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 3333, 3446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol.PEPropertySymbolWithCustomModifiers
                f_10713_3466_3598(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                containingType, System.Reflection.Metadata.PropertyDefinitionHandle
                handle, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                getMethod, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                setMethod, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                propertyParams, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                metadataDecoder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol.PEPropertySymbolWithCustomModifiers(moduleSymbol, containingType, handle, getMethod, setMethod, propertyParams, metadataDecoder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 3466, 3598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10713_3703_3717(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 3703, 3717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10713_3896_3951(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 3896, 3951);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 2352, 4008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 2352, 4008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PEPropertySymbol(
                    PEModuleSymbol moduleSymbol,
                    PENamedTypeSymbol containingType,
                    PropertyDefinitionHandle handle,
                    PEMethodSymbol getMethod,
                    PEMethodSymbol setMethod,
                    ParamInfo<TypeSymbol>[] propertyParams,
                    MetadataDecoder metadataDecoder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10713, 4020, 10144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 907, 912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 958, 973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 1140, 1148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 1267, 1277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 1320, 1330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 1452, 1467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 1501, 1557);
                this._lazyUseSiteDiagnostic = CSDiagnosticInfo.EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 1629, 1693);
                this._lazyObsoleteAttributeData = ObsoleteAttributeData.Uninitialized; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 2070, 2113);
                this._declaredAccessibility = UnsetAccessibility; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 2149, 2155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 4382, 4415);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 4429, 4462);

                var
                module = f_10713_4442_4461(moduleSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 4476, 4507);

                PropertyAttributes
                mdFlags = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 4521, 4557);

                BadImageFormatException
                mrEx = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 4609, 4675);

                    f_10713_4609_4674(module, handle, out _name, out mdFlags);
                }
                catch (BadImageFormatException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10713, 4704, 4921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 4770, 4779);

                    mrEx = e;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 4799, 4906) || true) && ((object)_name == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 4799, 4906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 4866, 4887);

                        _name = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 4799, 4906);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10713, 4704, 4921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 4937, 4960);

                _getMethod = getMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 4974, 4997);

                _setMethod = setMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 5011, 5028);

                _handle = handle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 5044, 5084);

                SignatureHeader
                unusedCallingConvention
                = default(SignatureHeader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 5098, 5135);

                BadImageFormatException
                getEx = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 5149, 5302);

                var
                getMethodParams = (DynAbs.Tracing.TraceSender.Conditional_F1(10713, 5171, 5196) || (((object)getMethod == null && DynAbs.Tracing.TraceSender.Conditional_F2(10713, 5199, 5203)) || DynAbs.Tracing.TraceSender.Conditional_F3(10713, 5206, 5301))) ? null : f_10713_5206_5301(metadataDecoder, f_10713_5244_5260(getMethod), out unusedCallingConvention, out getEx)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 5316, 5353);

                BadImageFormatException
                setEx = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 5367, 5520);

                var
                setMethodParams = (DynAbs.Tracing.TraceSender.Conditional_F1(10713, 5389, 5414) || (((object)setMethod == null && DynAbs.Tracing.TraceSender.Conditional_F2(10713, 5417, 5421)) || DynAbs.Tracing.TraceSender.Conditional_F3(10713, 5424, 5519))) ? null : f_10713_5424_5519(metadataDecoder, f_10713_5462_5478(setMethod), out unusedCallingConvention, out setEx)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 5769, 5780);

                bool
                isBad
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 5796, 6050);

                _parameters = (DynAbs.Tracing.TraceSender.Conditional_F1(10713, 5810, 5833) || ((setMethodParams is null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10713, 5853, 5941)) || DynAbs.Tracing.TraceSender.Conditional_F3(10713, 5961, 6049))) ? f_10713_5853_5941(moduleSymbol, this, getMethod, propertyParams, getMethodParams, out isBad) : f_10713_5961_6049(moduleSymbol, this, setMethod, propertyParams, setMethodParams, out isBad);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6066, 6253) || true) && (getEx != null || (DynAbs.Tracing.TraceSender.Expression_False(10713, 6070, 6100) || setEx != null) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 6070, 6116) || mrEx != null) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 6070, 6125) || isBad))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 6066, 6253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6159, 6238);

                    _lazyUseSiteDiagnostic = f_10713_6184_6237(ErrorCode.ERR_BindToBogus, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 6066, 6253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6269, 6304);

                var
                returnInfo = propertyParams[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6318, 6401);

                var
                typeCustomModifiers = f_10713_6344_6400(returnInfo.CustomModifiers)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6417, 6829) || true) && (returnInfo.IsByRef)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 6417, 6829);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6473, 6724) || true) && (f_10713_6477_6527(f_10713_6477_6496(moduleSymbol), handle))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 6473, 6724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6569, 6600);

                        _refKind = RefKind.RefReadOnly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 6473, 6724);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 6473, 6724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6682, 6705);

                        _refKind = RefKind.Ref;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 6473, 6724);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 6417, 6829);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 6417, 6829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6790, 6814);

                    _refKind = RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 6417, 6829);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6916, 6966);

                TypeSymbol
                originalPropertyType = returnInfo.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 6982, 7120);

                originalPropertyType = DynamicTypeDecoder.TransformType(originalPropertyType, typeCustomModifiers.Length, handle, moduleSymbol, _refKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 7134, 7240);

                originalPropertyType = NativeIntegerTypeDecoder.TransformType(originalPropertyType, handle, moduleSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 7306, 7384);

                originalPropertyType = f_10713_7329_7383(originalPropertyType, _containingType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 7473, 7594);

                var
                propertyTypeWithAnnotations = TypeWithAnnotations.Create(originalPropertyType, customModifiers: typeCustomModifiers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 7948, 8128);

                propertyTypeWithAnnotations = f_10713_7978_8127(propertyTypeWithAnnotations, handle, moduleSymbol, accessSymbol: _containingType, nullableContext: _containingType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 8142, 8269);

                propertyTypeWithAnnotations = TupleTypeDecoder.DecodeTupleTypesIfApplicable(propertyTypeWithAnnotations, handle, moduleSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 8285, 8344);

                _propertyTypeWithAnnotations = propertyTypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 8635, 8897);

                bool
                callMethodsDirectly = !f_10713_8663_8779(module, metadataDecoder, propertyParams, _getMethod, getMethodParams, _setMethod, setMethodParams) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 8662, 8829) || f_10713_8800_8829(this)) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 8662, 8896) || f_10713_8850_8896(propertyParams))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 8913, 9314) || true) && (!callMethodsDirectly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 8913, 9314);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 8971, 9125) || true) && ((object)_getMethod != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 8971, 9125);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 9043, 9106);

                        f_10713_9043_9105(_getMethod, this, MethodKind.PropertyGet);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 8971, 9125);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 9145, 9299) || true) && ((object)_setMethod != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 9145, 9299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 9217, 9280);

                        f_10713_9217_9279(_setMethod, this, MethodKind.PropertySet);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 9145, 9299);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 8913, 9314);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 9330, 9438) || true) && (callMethodsDirectly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 9330, 9438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 9387, 9423);

                    _flags |= Flags.CallMethodsDirectly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 9330, 9438);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 9454, 9584) || true) && ((mdFlags & PropertyAttributes.SpecialName) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 9454, 9584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 9539, 9569);

                    _flags |= Flags.IsSpecialName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 9454, 9584);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 9600, 9739) || true) && ((mdFlags & PropertyAttributes.RTSpecialName) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 9600, 9739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 9687, 9724);

                    _flags |= Flags.IsRuntimeSpecialName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 9600, 9739);
                }


                bool
                f_10713_8850_8896(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                propertyParams)
                {
                    var return_v = anyUnexpectedRequiredModifiers(propertyParams);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 8850, 8896);
                    return return_v;
                }


                static bool anyUnexpectedRequiredModifiers(ParamInfo<TypeSymbol>[] propertyParams)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10713, 9755, 10133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 9870, 10118);

                        return f_10713_9877_10117(propertyParams, p => (!p.RefCustomModifiers.IsDefaultOrEmpty && p.RefCustomModifiers.Any(m => !m.IsOptional && !m.Modifier.IsWellKnownTypeInAttribute())) ||
                                                                       p.CustomModifiers.AnyRequired());
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10713, 9755, 10133);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 9755, 10133);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 9755, 10133);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10713, 4020, 10144);

                static bool
                f_10713_9877_10117(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                source, System.Func<Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 9877, 10117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 4020, 10144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 4020, 10144);
            }
        }

        private bool MustCallMethodsDirectlyCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 10156, 10772);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 10223, 10761) || true) && (f_10713_10227_10239(this) != RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10713, 10227, 10277) && _setMethod != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 10223, 10761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 10311, 10323);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 10223, 10761);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 10223, 10761);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 10357, 10761) || true) && (f_10713_10361_10380(this) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 10357, 10761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 10419, 10432);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 10357, 10761);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 10357, 10761);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 10466, 10761) || true) && (f_10713_10470_10492(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 10466, 10761);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 10526, 10547);

                            return f_10713_10533_10546(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 10466, 10761);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 10466, 10761);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 10581, 10761) || true) && (f_10713_10585_10599(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 10581, 10761);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 10633, 10668);

                                return f_10713_10640_10667(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 10581, 10761);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 10581, 10761);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 10734, 10746);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 10581, 10761);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 10466, 10761);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 10357, 10761);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 10223, 10761);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 10156, 10772);

                Microsoft.CodeAnalysis.RefKind
                f_10713_10227_10239(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 10227, 10239);
                    return return_v;
                }


                int
                f_10713_10361_10380(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 10361, 10380);
                    return return_v;
                }


                bool
                f_10713_10470_10492(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param)
                {
                    var return_v = this_param.IsIndexedProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 10470, 10492);
                    return return_v;
                }


                bool
                f_10713_10533_10546(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 10533, 10546);
                    return return_v;
                }


                bool
                f_10713_10585_10599(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param)
                {
                    var return_v = this_param.IsIndexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 10585, 10599);
                    return return_v;
                }


                bool
                f_10713_10640_10667(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                property)
                {
                    var return_v = property.HasRefOrOutParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 10640, 10667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 10156, 10772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 10156, 10772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 10848, 10922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 10884, 10907);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 10848, 10922);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 10784, 10933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 10784, 10933);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 11016, 11090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 11052, 11075);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 11016, 11090);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 10945, 11101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 10945, 11101);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 11362, 11431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 11368, 11429);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10713, 11375, 11389) || ((f_10713_11375_11389(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10713, 11392, 11420)) || DynAbs.Tracing.TraceSender.Conditional_F3(10713, 11423, 11428))) ? WellKnownMemberNames.Indexer : _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 11362, 11431);

                    bool
                    f_10713_11375_11389(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsIndexer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 11375, 11389);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 11310, 11442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 11310, 11442);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 11516, 11567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 11522, 11565);

                    return (_flags & Flags.IsSpecialName) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 11516, 11567);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 11454, 11578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 11454, 11578);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 11650, 11714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 11686, 11699);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 11650, 11714);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 11590, 11725);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 11590, 11725);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PropertyDefinitionHandle Handle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 11800, 11866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 11836, 11851);

                    return _handle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 11800, 11866);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 11735, 11877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 11735, 11877);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 11965, 17525);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 12001, 17445) || true) && (_declaredAccessibility == UnsetAccessibility)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 12001, 17445);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 12091, 12119);

                        Accessibility
                        accessibility
                        = default(Accessibility);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 12141, 17306) || true) && (f_10713_12145_12160(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 12141, 17306);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 14187, 14249);

                            bool
                            crossedAssemblyBoundaryWithoutInternalsVisibleTo = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 14275, 14336);

                            Accessibility
                            getAccessibility = Accessibility.NotApplicable
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 14362, 14423);

                            Accessibility
                            setAccessibility = Accessibility.NotApplicable
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 14449, 14476);

                            PropertySymbol
                            curr = this
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 14502, 16931) || true) && (true)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 14502, 16931);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 14571, 15307) || true) && (getAccessibility == Accessibility.NotApplicable)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 14571, 15307);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 14688, 14728);

                                        MethodSymbol
                                        getMethod = f_10713_14713_14727(curr)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 14762, 15276) || true) && ((object)getMethod != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 14762, 15276);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 14865, 14937);

                                            Accessibility
                                            overriddenAccessibility = f_10713_14905_14936(getMethod)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 14975, 15241);

                                            getAccessibility = (DynAbs.Tracing.TraceSender.Conditional_F1(10713, 14994, 15106) || ((overriddenAccessibility == Accessibility.ProtectedOrInternal && (DynAbs.Tracing.TraceSender.Expression_True(10713, 14994, 15106) && crossedAssemblyBoundaryWithoutInternalsVisibleTo
                                            ) && DynAbs.Tracing.TraceSender.Conditional_F2(10713, 15150, 15173)) || DynAbs.Tracing.TraceSender.Conditional_F3(10713, 15217, 15240))) ? Accessibility.Protected
                                            : overriddenAccessibility;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 14762, 15276);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 14571, 15307);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 15339, 16075) || true) && (setAccessibility == Accessibility.NotApplicable)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 15339, 16075);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 15456, 15496);

                                        MethodSymbol
                                        setMethod = f_10713_15481_15495(curr)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 15530, 16044) || true) && ((object)setMethod != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 15530, 16044);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 15633, 15705);

                                            Accessibility
                                            overriddenAccessibility = f_10713_15673_15704(setMethod)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 15743, 16009);

                                            setAccessibility = (DynAbs.Tracing.TraceSender.Conditional_F1(10713, 15762, 15874) || ((overriddenAccessibility == Accessibility.ProtectedOrInternal && (DynAbs.Tracing.TraceSender.Expression_True(10713, 15762, 15874) && crossedAssemblyBoundaryWithoutInternalsVisibleTo
                                            ) && DynAbs.Tracing.TraceSender.Conditional_F2(10713, 15918, 15941)) || DynAbs.Tracing.TraceSender.Conditional_F3(10713, 15985, 16008))) ? Accessibility.Protected
                                            : overriddenAccessibility;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 15530, 16044);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 15339, 16075);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 16107, 16312) || true) && (getAccessibility != Accessibility.NotApplicable && (DynAbs.Tracing.TraceSender.Expression_True(10713, 16111, 16209) && setAccessibility != Accessibility.NotApplicable))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 16107, 16312);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10713, 16275, 16281);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 16107, 16312);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 16344, 16390);

                                    PropertySymbol
                                    next = f_10713_16366_16389(curr)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 16422, 16549) || true) && ((object)next == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 16422, 16549);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10713, 16512, 16518);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 16422, 16549);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 16581, 16860) || true) && (!crossedAssemblyBoundaryWithoutInternalsVisibleTo && (DynAbs.Tracing.TraceSender.Expression_True(10713, 16585, 16707) && !f_10713_16639_16707(f_10713_16639_16662(curr), f_10713_16683_16706(next))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 16581, 16860);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 16773, 16829);

                                        crossedAssemblyBoundaryWithoutInternalsVisibleTo = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 16581, 16860);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 16892, 16904);

                                    curr = next;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 14502, 16931);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10713, 14502, 16931);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10713, 14502, 16931);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 16959, 17074);

                            accessibility = f_10713_16975_17073(getAccessibility, setAccessibility);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 12141, 17306);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 12141, 17306);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 17172, 17283);

                            accessibility = f_10713_17188_17282(f_10713_17251_17265(this), f_10713_17267_17281(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 12141, 17306);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 17330, 17426);

                        f_10713_17330_17425(ref _declaredAccessibility, accessibility, UnsetAccessibility);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 12001, 17445);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 17465, 17510);

                    return (Accessibility)_declaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 11965, 17525);

                    bool
                    f_10713_12145_12160(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 12145, 12160);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10713_14713_14727(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 14713, 14727);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10713_14905_14936(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 14905, 14936);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10713_15481_15495(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 15481, 15495);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10713_15673_15704(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 15673, 15704);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10713_16366_16389(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenProperty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 16366, 16389);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10713_16639_16662(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 16639, 16662);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10713_16683_16706(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 16683, 16706);
                        return return_v;
                    }


                    bool
                    f_10713_16639_16707(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    fromAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    toAssembly)
                    {
                        var return_v = fromAssembly.HasInternalAccessTo(toAssembly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 16639, 16707);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10713_16975_17073(Microsoft.CodeAnalysis.Accessibility
                    accessibility1, Microsoft.CodeAnalysis.Accessibility
                    accessibility2)
                    {
                        var return_v = PEPropertyOrEventHelpers.GetDeclaredAccessibilityFromAccessors(accessibility1, accessibility2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 16975, 17073);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10713_17251_17265(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 17251, 17265);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10713_17267_17281(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 17267, 17281);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Accessibility
                    f_10713_17188_17282(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    accessor1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    accessor2)
                    {
                        var return_v = PEPropertyOrEventHelpers.GetDeclaredAccessibilityFromAccessors(accessor1, accessor2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 17188, 17282);
                        return return_v;
                    }


                    int
                    f_10713_17330_17425(ref int
                    location1, Microsoft.CodeAnalysis.Accessibility
                    value, int
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, (int)value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 17330, 17425);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 11889, 17536);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 11889, 17536);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 17602, 17851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 17680, 17836);

                    return
                                        ((object)_getMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10713, 17709, 17758) && f_10713_17739_17758(_getMethod))) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 17708, 17835) || ((object)_setMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10713, 17785, 17834) && f_10713_17815_17834(_setMethod))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 17602, 17851);

                    bool
                    f_10713_17739_17758(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 17739, 17758);
                        return return_v;
                    }


                    bool
                    f_10713_17815_17834(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 17815, 17834);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 17548, 17862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 17548, 17862);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 17930, 18185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 18010, 18170);

                    return
                                        ((object)_getMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10713, 18039, 18090) && f_10713_18069_18090(_getMethod))) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 18038, 18169) || ((object)_setMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10713, 18117, 18168) && f_10713_18147_18168(_setMethod))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 17930, 18185);

                    bool
                    f_10713_18069_18090(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 18069, 18090);
                        return return_v;
                    }


                    bool
                    f_10713_18147_18168(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 18147, 18168);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 17874, 18196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 17874, 18196);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 18262, 18511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 18340, 18496);

                    return
                                        ((object)_getMethod == null || (DynAbs.Tracing.TraceSender.Expression_False(10713, 18369, 18418) || f_10713_18399_18418(_getMethod))) && (DynAbs.Tracing.TraceSender.Expression_True(10713, 18368, 18495) && ((object)_setMethod == null || (DynAbs.Tracing.TraceSender.Expression_False(10713, 18445, 18494) || f_10713_18475_18494(_setMethod))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 18262, 18511);

                    bool
                    f_10713_18399_18418(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 18399, 18418);
                        return return_v;
                    }


                    bool
                    f_10713_18475_18494(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 18475, 18494);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 18208, 18522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 18208, 18522);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 18589, 18922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 18716, 18907);

                    return f_10713_18723_18734_M(!IsOverride) && (DynAbs.Tracing.TraceSender.Expression_True(10713, 18723, 18749) && f_10713_18738_18749_M(!IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10713, 18723, 18906) && (((object)_getMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10713, 18776, 18826) && f_10713_18806_18826(_getMethod))) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 18775, 18905) || ((object)_setMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10713, 18854, 18904) && f_10713_18884_18904(_setMethod))))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 18589, 18922);

                    bool
                    f_10713_18723_18734_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 18723, 18734);
                        return return_v;
                    }


                    bool
                    f_10713_18738_18749_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 18738, 18749);
                        return return_v;
                    }


                    bool
                    f_10713_18806_18826(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 18806, 18826);
                        return return_v;
                    }


                    bool
                    f_10713_18884_18904(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 18884, 18904);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 18534, 18933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 18534, 18933);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 19001, 19256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 19081, 19241);

                    return
                                        ((object)_getMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10713, 19110, 19161) && f_10713_19140_19161(_getMethod))) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 19109, 19240) || ((object)_setMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10713, 19188, 19239) && f_10713_19218_19239(_setMethod))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 19001, 19256);

                    bool
                    f_10713_19140_19161(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 19140, 19161);
                        return return_v;
                    }


                    bool
                    f_10713_19218_19239(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 19218, 19239);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 18945, 19267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 18945, 19267);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 19333, 19582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 19411, 19567);

                    return
                                        ((object)_getMethod == null || (DynAbs.Tracing.TraceSender.Expression_False(10713, 19440, 19489) || f_10713_19470_19489(_getMethod))) && (DynAbs.Tracing.TraceSender.Expression_True(10713, 19439, 19566) && ((object)_setMethod == null || (DynAbs.Tracing.TraceSender.Expression_False(10713, 19516, 19565) || f_10713_19546_19565(_setMethod))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 19333, 19582);

                    bool
                    f_10713_19470_19489(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 19470, 19489);
                        return return_v;
                    }


                    bool
                    f_10713_19546_19565(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 19546, 19565);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 19279, 19593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 19279, 19593);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 19688, 19715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 19694, 19713);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 19688, 19715);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 19605, 19726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 19605, 19726);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 20110, 20875);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 20365, 20829) || true) && (f_10713_20369_20388(this) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 20365, 20829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 20434, 20495);

                        string
                        defaultMemberName = f_10713_20461_20494(_containingType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 20517, 20810);

                        return _name == defaultMemberName || (DynAbs.Tracing.TraceSender.Expression_False(10713, 20524, 20704) || ((object)f_10713_20637_20651(this) != null && (DynAbs.Tracing.TraceSender.Expression_True(10713, 20629, 20703) && f_10713_20663_20682(f_10713_20663_20677(this)) == defaultMemberName))) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 20524, 20809) || ((object)f_10713_20742_20756(this) != null && (DynAbs.Tracing.TraceSender.Expression_True(10713, 20734, 20808) && f_10713_20768_20787(f_10713_20768_20782(this)) == defaultMemberName)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 20365, 20829);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 20847, 20860);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 20110, 20875);

                    int
                    f_10713_20369_20388(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 20369, 20388);
                        return return_v;
                    }


                    string
                    f_10713_20461_20494(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.DefaultMemberName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 20461, 20494);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10713_20637_20651(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 20637, 20651);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10713_20663_20677(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 20663, 20677);
                        return return_v;
                    }


                    string
                    f_10713_20663_20682(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 20663, 20682);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10713_20742_20756(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 20742, 20756);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10713_20768_20782(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 20768, 20782);
                        return return_v;
                    }


                    string
                    f_10713_20768_20787(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 20768, 20787);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 20055, 20886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 20055, 20886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsIndexedProperty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 20961, 21296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 21217, 21281);

                    return (f_10713_21225_21244(this) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(10713, 21224, 21280) && f_10713_21253_21280(_containingType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 20961, 21296);

                    int
                    f_10713_21225_21244(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 21225, 21244);
                        return return_v;
                    }


                    bool
                    f_10713_21253_21280(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsComImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 21253, 21280);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 20898, 21307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 20898, 21307);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 21375, 21399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 21381, 21397);

                    return _refKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 21375, 21399);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 21319, 21410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 21319, 21410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 21502, 21546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 21508, 21544);

                    return _propertyTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 21502, 21546);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 21422, 21557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 21422, 21557);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 21659, 21711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 21665, 21709);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 21659, 21711);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 21569, 21722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 21569, 21722);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol GetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 21797, 21823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 21803, 21821);

                    return _getMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 21797, 21823);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 21734, 21834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 21734, 21834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol SetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 21909, 21935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 21915, 21933);

                    return _setMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 21909, 21935);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 21846, 21946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 21846, 21946);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 22050, 22320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 22086, 22181);

                    var
                    metadataDecoder = f_10713_22108_22180(f_10713_22128_22162(_containingType), _containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 22199, 22305);

                    return (Microsoft.Cci.CallingConvention)(f_10713_22240_22294(metadataDecoder, _handle).RawValue);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 22050, 22320);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10713_22128_22162(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 22128, 22162);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                    f_10713_22108_22180(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    context)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 22108, 22180);
                        return return_v;
                    }


                    System.Reflection.Metadata.SignatureHeader
                    f_10713_22240_22294(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                    this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                    handle)
                    {
                        var return_v = this_param.GetSignatureHeaderForProperty(handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 22240, 22294);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 21958, 22331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 21958, 22331);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 22418, 22563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 22454, 22548);

                    return f_10713_22461_22495(_containingType).MetadataLocation.Cast<MetadataLocation, Location>();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 22418, 22563);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10713_22461_22495(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 22461, 22495);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 22343, 22574);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 22343, 22574);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 22684, 22780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 22720, 22765);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 22684, 22780);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 22586, 22791);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 22586, 22791);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 22803, 23502);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 22895, 23448) || true) && (_lazyCustomAttributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 22895, 23448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 22964, 23033);

                    var
                    containingPEModuleSymbol = (PEModuleSymbol)f_10713_23011_23032(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 23053, 23331);

                    ImmutableArray<CSharpAttributeData>
                    attributes = f_10713_23102_23330(containingPEModuleSymbol, _handle, out _, (DynAbs.Tracing.TraceSender.Conditional_F1(10713, 23241, 23276) || ((f_10713_23241_23253(this) == RefKind.RefReadOnly && DynAbs.Tracing.TraceSender.Conditional_F2(10713, 23279, 23319)) || DynAbs.Tracing.TraceSender.Conditional_F3(10713, 23322, 23329))) ? AttributeDescription.IsReadOnlyAttribute : default)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 23351, 23433);

                    f_10713_23351_23432(ref _lazyCustomAttributes, attributes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 22895, 23448);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 23462, 23491);

                return _lazyCustomAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 22803, 23502);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10713_23011_23032(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 23011, 23032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10713_23241_23253(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 23241, 23253);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10713_23102_23330(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                token, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute1, Microsoft.CodeAnalysis.AttributeDescription
                filterOut1)
                {
                    var return_v = this_param.GetCustomAttributesForToken((System.Reflection.Metadata.EntityHandle)token, out filteredOutAttribute1, filterOut1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 23102, 23330);
                    return return_v;
                }


                bool
                f_10713_23351_23432(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 23351, 23432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 22803, 23502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 22803, 23502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 23514, 23680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 23646, 23669);

                return f_10713_23653_23668(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 23514, 23680);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10713_23653_23668(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 23653, 23668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 23514, 23680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 23514, 23680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<PropertySymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 24394, 25898);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 24430, 24738) || true) && (((object)_getMethod == null || (DynAbs.Tracing.TraceSender.Expression_False(10713, 24435, 24520) || _getMethod.ExplicitInterfaceImplementations.Length == 0)) && (DynAbs.Tracing.TraceSender.Expression_True(10713, 24434, 24633) && ((object)_setMethod == null || (DynAbs.Tracing.TraceSender.Expression_False(10713, 24547, 24632) || _setMethod.ExplicitInterfaceImplementations.Length == 0))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 24430, 24738);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 24675, 24719);

                        return ImmutableArray<PropertySymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 24430, 24738);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 24758, 24880);

                    var
                    propertiesWithImplementedGetters = f_10713_24797_24879(_getMethod)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 24898, 25020);

                    var
                    propertiesWithImplementedSetters = f_10713_24937_25019(_setMethod)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 25040, 25097);

                    var
                    builder = f_10713_25054_25096()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 25117, 25410);
                        foreach (var prop in f_10713_25138_25170_I(propertiesWithImplementedGetters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 25117, 25410);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 25212, 25391) || true) && (!f_10713_25217_25249(f_10713_25217_25231(prop)) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 25216, 25300) || f_10713_25253_25300(propertiesWithImplementedSetters, prop)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 25212, 25391);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 25350, 25368);

                                f_10713_25350_25367(builder, prop);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 25212, 25391);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 25117, 25410);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10713, 1, 294);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10713, 1, 294);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 25430, 25827);
                        foreach (var prop in f_10713_25451_25483_I(propertiesWithImplementedSetters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 25430, 25827);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 25680, 25808) || true) && (!f_10713_25685_25717(f_10713_25685_25699(prop)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 25680, 25808);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 25767, 25785);

                                f_10713_25767_25784(builder, prop);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 25680, 25808);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 25430, 25827);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10713, 1, 398);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10713, 1, 398);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 25847, 25883);

                    return f_10713_25854_25882(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 24394, 25898);

                    System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10713_24797_24879(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol?
                    accessor)
                    {
                        var return_v = PEPropertyOrEventHelpers.GetPropertiesForExplicitlyImplementedAccessor((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?)accessor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 24797, 24879);
                        return return_v;
                    }


                    System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10713_24937_25019(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    accessor)
                    {
                        var return_v = PEPropertyOrEventHelpers.GetPropertiesForExplicitlyImplementedAccessor((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)accessor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 24937, 25019);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10713_25054_25096()
                    {
                        var return_v = ArrayBuilder<PropertySymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 25054, 25096);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10713_25217_25231(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 25217, 25231);
                        return return_v;
                    }


                    bool
                    f_10713_25217_25249(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodOpt)
                    {
                        var return_v = methodOpt.IsImplementable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 25217, 25249);
                        return return_v;
                    }


                    bool
                    f_10713_25253_25300(System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 25253, 25300);
                        return return_v;
                    }


                    int
                    f_10713_25350_25367(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 25350, 25367);
                        return 0;
                    }


                    System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10713_25138_25170_I(System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 25138, 25170);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10713_25685_25699(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 25685, 25699);
                        return return_v;
                    }


                    bool
                    f_10713_25685_25717(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodOpt)
                    {
                        var return_v = methodOpt.IsImplementable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 25685, 25717);
                        return return_v;
                    }


                    int
                    f_10713_25767_25784(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 25767, 25784);
                        return 0;
                    }


                    System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10713_25451_25483_I(System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 25451, 25483);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10713_25854_25882(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 25854, 25882);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 24290, 25909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 24290, 25909);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MustCallMethodsDirectly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 25992, 26049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 25998, 26047);

                    return (_flags & Flags.CallMethodsDirectly) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 25992, 26049);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 25921, 26060);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 25921, 26060);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static bool DoSignaturesMatch(
                    PEModule module,
                    MetadataDecoder metadataDecoder,
                    ParamInfo<TypeSymbol>[] propertyParams,
                    PEMethodSymbol getMethod,
                    ParamInfo<TypeSymbol>[] getMethodParams,
                    PEMethodSymbol setMethod,
                    ParamInfo<TypeSymbol>[] setMethodParams)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10713, 26072, 28378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 26450, 26521);

                f_10713_26450_26520((getMethodParams == null) == ((object)getMethod == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 26535, 26606);

                f_10713_26535_26605((setMethodParams == null) == ((object)setMethod == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 26622, 26666);

                bool
                hasGetMethod = getMethodParams != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 26680, 26724);

                bool
                hasSetMethod = setMethodParams != null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 26740, 26973) || true) && (hasGetMethod && (DynAbs.Tracing.TraceSender.Expression_True(10713, 26744, 26911) && !f_10713_26761_26911(metadataDecoder, propertyParams, getMethodParams, comparingToSetter: false, compareParamByRef: true, compareReturnType: true)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 26740, 26973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 26945, 26958);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 26740, 26973);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 26989, 27221) || true) && (hasSetMethod && (DynAbs.Tracing.TraceSender.Expression_True(10713, 26993, 27159) && !f_10713_27010_27159(metadataDecoder, propertyParams, setMethodParams, comparingToSetter: true, compareParamByRef: true, compareReturnType: true)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 26989, 27221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 27193, 27206);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 26989, 27221);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 27237, 28339) || true) && (hasGetMethod && (DynAbs.Tracing.TraceSender.Expression_True(10713, 27241, 27269) && hasSetMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 27237, 28339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 27303, 27358);

                    var
                    lastPropertyParamIndex = f_10713_27332_27353(propertyParams) - 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 27376, 27439);

                    var
                    getHandle = getMethodParams[lastPropertyParamIndex].Handle
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 27457, 27520);

                    var
                    setHandle = setMethodParams[lastPropertyParamIndex].Handle
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 27538, 27621);

                    var
                    getterHasParamArray = f_10713_27564_27580_M(!getHandle.IsNil) && (DynAbs.Tracing.TraceSender.Expression_True(10713, 27564, 27620) && f_10713_27584_27620(module, getHandle))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 27639, 27722);

                    var
                    setterHasParamArray = f_10713_27665_27681_M(!setHandle.IsNil) && (DynAbs.Tracing.TraceSender.Expression_True(10713, 27665, 27721) && f_10713_27685_27721(module, setHandle))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 27740, 27860) || true) && (getterHasParamArray != setterHasParamArray)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 27740, 27860);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 27828, 27841);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 27740, 27860);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 27880, 28324) || true) && ((f_10713_27885_27903(getMethod) != f_10713_27907_27925(setMethod)) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 27884, 28112) ||                    // (getMethod.IsAbstract != setMethod.IsAbstract) || // NOTE: Dev10 accepts one abstract accessor
                                        (f_10713_28071_28089(getMethod) != f_10713_28093_28111(setMethod))) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 27884, 28183) || (f_10713_28138_28158(getMethod) != f_10713_28162_28182(setMethod))) || (DynAbs.Tracing.TraceSender.Expression_False(10713, 27884, 28250) || (f_10713_28209_28227(getMethod) != f_10713_28231_28249(setMethod))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 27880, 28324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 28292, 28305);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 27880, 28324);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 27237, 28339);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 28355, 28367);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10713, 26072, 28378);

                int
                f_10713_26450_26520(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 26450, 26520);
                    return 0;
                }


                int
                f_10713_26535_26605(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 26535, 26605);
                    return 0;
                }


                bool
                f_10713_26761_26911(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                signature1, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]?
                signature2, bool
                comparingToSetter, bool
                compareParamByRef, bool
                compareReturnType)
                {
                    var return_v = this_param.DoPropertySignaturesMatch(signature1, signature2, comparingToSetter: comparingToSetter, compareParamByRef: compareParamByRef, compareReturnType: compareReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 26761, 26911);
                    return return_v;
                }


                bool
                f_10713_27010_27159(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                signature1, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]?
                signature2, bool
                comparingToSetter, bool
                compareParamByRef, bool
                compareReturnType)
                {
                    var return_v = this_param.DoPropertySignaturesMatch(signature1, signature2, comparingToSetter: comparingToSetter, compareParamByRef: compareParamByRef, compareReturnType: compareReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 27010, 27159);
                    return return_v;
                }


                int
                f_10713_27332_27353(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 27332, 27353);
                    return return_v;
                }


                bool
                f_10713_27564_27580_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 27564, 27580);
                    return return_v;
                }


                bool
                f_10713_27584_27620(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token)
                {
                    var return_v = this_param.HasParamsAttribute((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 27584, 27620);
                    return return_v;
                }


                bool
                f_10713_27665_27681_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 27665, 27681);
                    return return_v;
                }


                bool
                f_10713_27685_27721(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token)
                {
                    var return_v = this_param.HasParamsAttribute((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 27685, 27721);
                    return return_v;
                }


                bool
                f_10713_27885_27903(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol?
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 27885, 27903);
                    return return_v;
                }


                bool
                f_10713_27907_27925(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol?
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 27907, 27925);
                    return return_v;
                }


                bool
                f_10713_28071_28089(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 28071, 28089);
                    return return_v;
                }


                bool
                f_10713_28093_28111(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 28093, 28111);
                    return return_v;
                }


                bool
                f_10713_28138_28158(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 28138, 28158);
                    return return_v;
                }


                bool
                f_10713_28162_28182(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 28162, 28182);
                    return return_v;
                }


                bool
                f_10713_28209_28227(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 28209, 28227);
                    return return_v;
                }


                bool
                f_10713_28231_28249(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 28231, 28249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 26072, 28378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 26072, 28378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<ParameterSymbol> GetParameters(
                    PEModuleSymbol moduleSymbol,
                    PEPropertySymbol property,
                    PEMethodSymbol accessor,
                    ParamInfo<TypeSymbol>[] propertyParams,
                    ParamInfo<TypeSymbol>[] accessorParams,
                    out bool anyParameterIsBad)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10713, 28390, 30349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 28743, 28769);

                anyParameterIsBad = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 28839, 28962) || true) && (f_10713_28843_28864(propertyParams) < 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 28839, 28962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 28902, 28947);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 28839, 28962);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 28978, 29024);

                var
                numAccessorParams = f_10713_29002_29023(accessorParams)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29040, 29104);

                var
                parameters = new ParameterSymbol[f_10713_29077_29098(propertyParams) - 1]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29127, 29132);
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29118, 30284) || true) && (i < f_10713_29138_29159(propertyParams))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29161, 29164)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 29118, 30284)) // from 1 to skip property/return type

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 29118, 30284);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29418, 29456);

                        var
                        propertyParam = propertyParams[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29474, 29502);

                        ParameterHandle
                        paramHandle
                        = default(ParameterHandle);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29520, 29543);

                        Symbol
                        nullableContext
                        = default(Symbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29561, 29901) || true) && (i < numAccessorParams)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 29561, 29901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29628, 29667);

                            paramHandle = accessorParams[i].Handle;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29689, 29716);

                            nullableContext = accessor;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 29561, 29901);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 29561, 29901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29798, 29833);

                            paramHandle = propertyParam.Handle;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29855, 29882);

                            nullableContext = property;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 29561, 29901);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29919, 29939);

                        var
                        ordinal = i - 1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29957, 29968);

                        bool
                        isBad
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 29988, 30154);

                        parameters[ordinal] = f_10713_30010_30153(moduleSymbol, property, f_10713_30059_30087(accessor), ordinal, paramHandle, propertyParam, nullableContext, out isBad);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 30174, 30269) || true) && (isBad)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 30174, 30269);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 30225, 30250);

                            anyParameterIsBad = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 30174, 30269);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10713, 1, 1167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10713, 1, 1167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 30300, 30338);

                return f_10713_30307_30337(parameters);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10713, 28390, 30349);

                int
                f_10713_28843_28864(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 28843, 28864);
                    return return_v;
                }


                int
                f_10713_29002_29023(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 29002, 29023);
                    return return_v;
                }


                int
                f_10713_29077_29098(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 29077, 29098);
                    return return_v;
                }


                int
                f_10713_29138_29159(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 29138, 29159);
                    return return_v;
                }


                bool
                f_10713_30059_30087(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 30059, 30087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                f_10713_30010_30153(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                containingSymbol, bool
                isContainingSymbolVirtual, int
                ordinal, System.Reflection.Metadata.ParameterHandle
                handle, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                parameterInfo, Microsoft.CodeAnalysis.CSharp.Symbol
                nullableContext, out bool
                isBad)
                {
                    var return_v = PEParameterSymbol.Create(moduleSymbol, containingSymbol, isContainingSymbolVirtual, ordinal, handle, parameterInfo, nullableContext, out isBad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 30010, 30153);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10713_30307_30337(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 30307, 30337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 28390, 30349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 28390, 30349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 30361, 30737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 30567, 30726);

                return f_10713_30574_30725(this, f_10713_30632_30666(_containingType), preferredCulture, cancellationToken, ref _lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 30361, 30737);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10713_30632_30666(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 30632, 30666);
                    return return_v;
                }


                string
                f_10713_30574_30725(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                containingPEModule, System.Globalization.CultureInfo?
                preferredCulture, System.Threading.CancellationToken
                cancellationToken, ref System.Tuple<System.Globalization.CultureInfo, string>
                lazyDocComment)
                {
                    var return_v = PEDocumentationCommentUtils.GetDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingPEModule, preferredCulture, cancellationToken, ref lazyDocComment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 30574, 30725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 30361, 30737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 30361, 30737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 30749, 31147);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 30829, 31090) || true) && (f_10713_30833_30905(_lazyUseSiteDiagnostic, CSDiagnosticInfo.EmptyErrorInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10713, 30829, 31090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 30939, 30968);

                    DiagnosticInfo
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 30986, 31025);

                    f_10713_30986_31024(this, ref result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 31043, 31075);

                    _lazyUseSiteDiagnostic = result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10713, 30829, 31090);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 31106, 31136);

                return _lazyUseSiteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 30749, 31147);

                bool
                f_10713_30833_30905(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 30833, 30905);
                    return return_v;
                }


                bool
                f_10713_30986_31024(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic(ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 30986, 31024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 30749, 31147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 30749, 31147);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 31245, 31520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 31281, 31453);

                    f_10713_31281_31452(ref _lazyObsoleteAttributeData, _handle, (f_10713_31399_31420(this)), ignoreByRefLikeMarker: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 31471, 31505);

                    return _lazyObsoleteAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 31245, 31520);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10713_31399_31420(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 31399, 31420);
                        return return_v;
                    }


                    int
                    f_10713_31281_31452(ref Microsoft.CodeAnalysis.ObsoleteAttributeData
                    data, System.Reflection.Metadata.PropertyDefinitionHandle
                    token, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    containingModule, bool
                    ignoreByRefLikeMarker)
                    {
                        ObsoleteAttributeHelpers.InitializeObsoleteDataFromMetadata(ref data, (System.Reflection.Metadata.EntityHandle)token, (Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol)containingModule, ignoreByRefLikeMarker: ignoreByRefLikeMarker);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 31281, 31452);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 31159, 31531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 31159, 31531);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 31612, 31713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 31648, 31698);

                    return (_flags & Flags.IsRuntimeSpecialName) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 31612, 31713);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 31543, 31724);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 31543, 31724);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 31849, 31869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 31855, 31867);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 31849, 31869);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 31736, 31880);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 31736, 31880);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        private sealed class PEPropertySymbolWithCustomModifiers : PEPropertySymbol
        {
            private readonly ImmutableArray<CustomModifier> _refCustomModifiers;

            public PEPropertySymbolWithCustomModifiers(
                            PEModuleSymbol moduleSymbol,
                            PENamedTypeSymbol containingType,
                            PropertyDefinitionHandle handle,
                            PEMethodSymbol getMethod,
                            PEMethodSymbol setMethod,
                            ParamInfo<TypeSymbol>[] propertyParams,
                            MetadataDecoder metadataDecoder)
            : base(f_10713_32484_32496_C(moduleSymbol), containingType, handle, getMethod, setMethod, propertyParams, metadataDecoder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10713, 32076, 32801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 32651, 32686);

                    var
                    returnInfo = propertyParams[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 32704, 32786);

                    _refCustomModifiers = f_10713_32726_32785(returnInfo.RefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10713, 32076, 32801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 32076, 32801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 32076, 32801);
                }
            }

            public override ImmutableArray<CustomModifier> RefCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10713, 32915, 32950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 32921, 32948);

                        return _refCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10713, 32915, 32950);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10713, 32817, 32965);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 32817, 32965);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static PEPropertySymbolWithCustomModifiers()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10713, 31892, 32976);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10713, 31892, 32976);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 31892, 32976);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10713, 31892, 32976);

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            f_10713_32726_32785(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
            customModifiers)
            {
                var return_v = CSharpCustomModifier.Convert(customModifiers);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 32726, 32785);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
            f_10713_32484_32496_C(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10713, 32076, 32801);
                return return_v;
            }

        }

        static PEPropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10713, 809, 32983);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10713, 2024, 2047);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10713, 809, 32983);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10713, 809, 32983);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10713, 809, 32983);

        Microsoft.CodeAnalysis.PEModule
        f_10713_4442_4461(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 4442, 4461);
            return return_v;
        }


        int
        f_10713_4609_4674(Microsoft.CodeAnalysis.PEModule
        this_param, System.Reflection.Metadata.PropertyDefinitionHandle
        propertyDef, out string
        name, out System.Reflection.PropertyAttributes
        flags)
        {
            this_param.GetPropertyDefPropsOrThrow(propertyDef, out name, out flags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 4609, 4674);
            return 0;
        }


        System.Reflection.Metadata.MethodDefinitionHandle
        f_10713_5244_5260(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.Handle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 5244, 5260);
            return return_v;
        }


        Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
        f_10713_5206_5301(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
        this_param, System.Reflection.Metadata.MethodDefinitionHandle
        methodDef, out System.Reflection.Metadata.SignatureHeader
        signatureHeader, out System.BadImageFormatException
        metadataException)
        {
            var return_v = this_param.GetSignatureForMethod(methodDef, out signatureHeader, out metadataException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 5206, 5301);
            return return_v;
        }


        System.Reflection.Metadata.MethodDefinitionHandle
        f_10713_5462_5478(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.Handle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 5462, 5478);
            return return_v;
        }


        Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
        f_10713_5424_5519(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
        this_param, System.Reflection.Metadata.MethodDefinitionHandle
        methodDef, out System.Reflection.Metadata.SignatureHeader
        signatureHeader, out System.BadImageFormatException
        metadataException)
        {
            var return_v = this_param.GetSignatureForMethod(methodDef, out signatureHeader, out metadataException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 5424, 5519);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10713_5853_5941(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
        property, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol?
        accessor, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
        propertyParams, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]?
        accessorParams, out bool
        anyParameterIsBad)
        {
            var return_v = GetParameters(moduleSymbol, property, accessor, propertyParams, accessorParams, out anyParameterIsBad);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 5853, 5941);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10713_5961_6049(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
        property, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol?
        accessor, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
        propertyParams, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
        accessorParams, out bool
        anyParameterIsBad)
        {
            var return_v = GetParameters(moduleSymbol, property, accessor, propertyParams, accessorParams, out anyParameterIsBad);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 5961, 6049);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10713_6184_6237(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, params object[]
        args)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 6184, 6237);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10713_6344_6400(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
        customModifiers)
        {
            var return_v = CSharpCustomModifier.Convert(customModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 6344, 6400);
            return return_v;
        }


        Microsoft.CodeAnalysis.PEModule
        f_10713_6477_6496(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10713, 6477, 6496);
            return return_v;
        }


        bool
        f_10713_6477_6527(Microsoft.CodeAnalysis.PEModule
        this_param, System.Reflection.Metadata.PropertyDefinitionHandle
        token)
        {
            var return_v = this_param.HasIsReadOnlyAttribute((System.Reflection.Metadata.EntityHandle)token);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 6477, 6527);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10713_7329_7383(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        containingType)
        {
            var return_v = type.AsDynamicIfNoPia((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 7329, 7383);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10713_7978_8127(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        metadataType, System.Reflection.Metadata.PropertyDefinitionHandle
        targetSymbolToken, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        containingModule, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        accessSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        nullableContext)
        {
            var return_v = NullableTypeDecoder.TransformType(metadataType, (System.Reflection.Metadata.EntityHandle)targetSymbolToken, containingModule, accessSymbol: (Microsoft.CodeAnalysis.CSharp.Symbol)accessSymbol, nullableContext: (Microsoft.CodeAnalysis.CSharp.Symbol)nullableContext);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 7978, 8127);
            return return_v;
        }


        bool
        f_10713_8663_8779(Microsoft.CodeAnalysis.PEModule
        module, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
        metadataDecoder, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
        propertyParams, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        getMethod, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]?
        getMethodParams, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        setMethod, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]?
        setMethodParams)
        {
            var return_v = DoSignaturesMatch(module, metadataDecoder, propertyParams, getMethod, getMethodParams, setMethod, setMethodParams);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 8663, 8779);
            return return_v;
        }


        bool
        f_10713_8800_8829(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
        this_param)
        {
            var return_v = this_param.MustCallMethodsDirectlyCore();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 8800, 8829);
            return return_v;
        }



        bool
        f_10713_9043_9105(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
        propertySymbol, Microsoft.CodeAnalysis.MethodKind
        methodKind)
        {
            var return_v = this_param.SetAssociatedProperty(propertySymbol, methodKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 9043, 9105);
            return return_v;
        }


        bool
        f_10713_9217_9279(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
        propertySymbol, Microsoft.CodeAnalysis.MethodKind
        methodKind)
        {
            var return_v = this_param.SetAssociatedProperty(propertySymbol, methodKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10713, 9217, 9279);
            return return_v;
        }

    }
}
