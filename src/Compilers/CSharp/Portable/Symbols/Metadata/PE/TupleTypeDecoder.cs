// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{

    internal struct TupleTypeDecoder
    {

        private readonly ImmutableArray<string?> _elementNames;

        private int _namesIndex;

        private bool _foundUsableErrorType;

        private bool _decodingFailed;

        private TupleTypeDecoder(ImmutableArray<string?> elementNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10716, 2778, 3064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 2865, 2894);

                _elementNames = elementNames;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 2908, 2971);

                _namesIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(10716, 2922, 2944) || ((elementNames.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10716, 2947, 2948)) || DynAbs.Tracing.TraceSender.Conditional_F3(10716, 2951, 2970))) ? 0 : elementNames.Length;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 2985, 3009);

                _decodingFailed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 3023, 3053);

                _foundUsableErrorType = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10716, 2778, 3064);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 2778, 3064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 2778, 3064);
            }
        }

        public static TypeSymbol DecodeTupleTypesIfApplicable(
                    TypeSymbol metadataType,
                    EntityHandle targetHandle,
                    PEModuleSymbol containingModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10716, 3076, 3889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 3279, 3316);

                ImmutableArray<string?>
                elementNames
                = default(ImmutableArray<string?>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 3330, 3488);

                var
                hasTupleElementNamesAttribute = f_10716_3366_3487(f_10716_3366_3407(containingModule), targetHandle, out elementNames)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 3613, 3771) || true) && (hasTupleElementNamesAttribute && (DynAbs.Tracing.TraceSender.Expression_True(10716, 3617, 3679) && elementNames.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 3613, 3771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 3713, 3756);

                    return f_10716_3720_3755();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 3613, 3771);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 3787, 3878);

                return DecodeTupleTypesInternal(metadataType, elementNames, hasTupleElementNamesAttribute);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10716, 3076, 3889);

                Microsoft.CodeAnalysis.PEModule
                f_10716_3366_3407(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 3366, 3407);
                    return return_v;
                }


                bool
                f_10716_3366_3487(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, out System.Collections.Immutable.ImmutableArray<string?>
                tupleElementNames)
                {
                    var return_v = this_param.HasTupleElementNamesAttribute(token, out tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 3366, 3487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10716_3720_3755()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 3720, 3755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 3076, 3889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 3076, 3889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeWithAnnotations DecodeTupleTypesIfApplicable(
                    TypeWithAnnotations metadataType,
                    EntityHandle targetHandle,
                    PEModuleSymbol containingModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10716, 3901, 5019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 4122, 4159);

                ImmutableArray<string?>
                elementNames
                = default(ImmutableArray<string?>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 4173, 4331);

                var
                hasTupleElementNamesAttribute = f_10716_4209_4330(f_10716_4209_4250(containingModule), targetHandle, out elementNames)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 4456, 4642) || true) && (hasTupleElementNamesAttribute && (DynAbs.Tracing.TraceSender.Expression_True(10716, 4460, 4522) && elementNames.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 4456, 4642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 4556, 4627);

                    return TypeWithAnnotations.Create(f_10716_4590_4625());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 4456, 4642);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 4658, 4694);

                TypeSymbol
                type = metadataType.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 4708, 4805);

                TypeSymbol
                decoded = DecodeTupleTypesInternal(type, elementNames, hasTupleElementNamesAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 4819, 5008);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10716, 4826, 4857) || (((object)decoded == (object)type && DynAbs.Tracing.TraceSender.Conditional_F2(10716, 4877, 4889)) || DynAbs.Tracing.TraceSender.Conditional_F3(10716, 4909, 5007))) ? metadataType : TypeWithAnnotations.Create(decoded, metadataType.NullableAnnotation, metadataType.CustomModifiers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10716, 3901, 5019);

                Microsoft.CodeAnalysis.PEModule
                f_10716_4209_4250(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 4209, 4250);
                    return return_v;
                }


                bool
                f_10716_4209_4330(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, out System.Collections.Immutable.ImmutableArray<string?>
                tupleElementNames)
                {
                    var return_v = this_param.HasTupleElementNamesAttribute(token, out tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 4209, 4330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10716_4590_4625()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 4590, 4625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 3901, 5019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 3901, 5019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeSymbol DecodeTupleTypesIfApplicable(
                    TypeSymbol metadataType,
                    ImmutableArray<string?> elementNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10716, 5031, 5333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 5199, 5322);

                return DecodeTupleTypesInternal(metadataType, elementNames, hasTupleElementNamesAttribute: f_10716_5290_5320_M(!elementNames.IsDefaultOrEmpty));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10716, 5031, 5333);

                bool
                f_10716_5290_5320_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 5290, 5320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 5031, 5333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 5031, 5333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeSymbol DecodeTupleTypesInternal(TypeSymbol metadataType, ImmutableArray<string?> elementNames, bool hasTupleElementNamesAttribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10716, 5345, 6207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 5519, 5559);

                f_10716_5519_5558(metadataType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 5575, 5624);

                var
                decoder = f_10716_5589_5623(elementNames)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 5638, 5685);

                var
                decoded = decoder.DecodeType(metadataType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 5699, 5914) || true) && (!decoder._decodingFailed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 5699, 5914);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 5761, 5899) || true) && (!hasTupleElementNamesAttribute || (DynAbs.Tracing.TraceSender.Expression_False(10716, 5765, 5823) || decoder._namesIndex == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 5761, 5899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 5865, 5880);

                        return decoded;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 5761, 5899);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 5699, 5914);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 6006, 6108) || true) && (decoder._foundUsableErrorType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 6006, 6108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 6073, 6093);

                    return metadataType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 6006, 6108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 6153, 6196);

                return f_10716_6160_6195();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10716, 5345, 6207);

                int
                f_10716_5519_5558(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                value)
                {
                    RoslynDebug.AssertNotNull(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 5519, 5558);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.TupleTypeDecoder
                f_10716_5589_5623(System.Collections.Immutable.ImmutableArray<string?>
                elementNames)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.TupleTypeDecoder(elementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 5589, 5623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10716_6160_6195()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 6160, 6195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 5345, 6207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 5345, 6207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol DecodeType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10716, 6219, 8557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 6290, 8546);

                switch (f_10716_6298_6307(type))
                {

                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 6290, 8546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 6389, 6418);

                        _foundUsableErrorType = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 6440, 6452);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 6290, 8546);

                    case SymbolKind.DynamicType:
                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 6290, 8546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 6570, 6582);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 6290, 8546);

                    case SymbolKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 6290, 8546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 6660, 6726);

                        return DecodeFunctionPointerType((FunctionPointerTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 6290, 8546);

                    case SymbolKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 6290, 8546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 6796, 6846);

                        return DecodePointerType((PointerTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 6290, 8546);

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 6290, 8546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 8265, 8311);

                        return DecodeNamedType((NamedTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 6290, 8546);

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 6290, 8546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 8379, 8425);

                        return DecodeArrayType((ArrayTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 6290, 8546);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 6290, 8546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 8475, 8531);

                        throw f_10716_8481_8530(f_10716_8516_8529(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 6290, 8546);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10716, 6219, 8557);

                Microsoft.CodeAnalysis.SymbolKind
                f_10716_6298_6307(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 6298, 6307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10716_8516_8529(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 8516, 8529);
                    return return_v;
                }


                System.Exception
                f_10716_8481_8530(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 8481, 8530);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 6219, 8557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 6219, 8557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PointerTypeSymbol DecodePointerType(PointerTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10716, 8569, 8757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 8661, 8746);

                return f_10716_8668_8745(type, DecodeTypeInternal(f_10716_8710_8743(type)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10716, 8569, 8757);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10716_8710_8743(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 8710, 8743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10716_8668_8745(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newPointedAtType)
                {
                    var return_v = this_param.WithPointedAtType(newPointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 8668, 8745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 8569, 8757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 8569, 8757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FunctionPointerTypeSymbol DecodeFunctionPointerType(FunctionPointerTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10716, 8769, 10486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 8885, 8948);

                var
                parameterTypes = ImmutableArray<TypeWithAnnotations>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 8962, 8989);

                var
                paramsModified = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9005, 10009) || true) && (f_10716_9009_9038(f_10716_9009_9023(type)) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 9005, 10009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9076, 9173);

                    var
                    paramsBuilder = f_10716_9096_9172(f_10716_9142_9171(f_10716_9142_9156(type)))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9202, 9239);

                        for (int
        i = f_10716_9206_9235(f_10716_9206_9220(type)) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9193, 9602) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9249, 9252)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 9193, 9602))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 9193, 9602);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9294, 9335);

                            var
                            param = f_10716_9306_9331(f_10716_9306_9320(type))[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9357, 9422);

                            var
                            decodedParam = DecodeTypeInternal(f_10716_9395_9420(param))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9444, 9529);

                            paramsModified = paramsModified || (DynAbs.Tracing.TraceSender.Expression_False(10716, 9461, 9528) || !decodedParam.IsSameAs(f_10716_9502_9527(param)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9551, 9583);

                            f_10716_9551_9582(paramsBuilder, decodedParam);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10716, 1, 410);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10716, 1, 410);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9622, 9994) || true) && (paramsModified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 9622, 9994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9682, 9714);

                        f_10716_9682_9713(paramsBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9736, 9788);

                        parameterTypes = f_10716_9753_9787(paramsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 9622, 9994);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 9622, 9994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9870, 9932);

                        parameterTypes = f_10716_9887_9931(f_10716_9887_9901(type));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 9954, 9975);

                        f_10716_9954_9974(paramsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 9622, 9994);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 9005, 10009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 10025, 10110);

                var
                decodedReturnType = DecodeTypeInternal(f_10716_10068_10108(f_10716_10068_10082(type)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 10126, 10475) || true) && (paramsModified || (DynAbs.Tracing.TraceSender.Expression_False(10716, 10130, 10217) || !decodedReturnType.IsSameAs(f_10716_10176_10216(f_10716_10176_10190(type)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 10126, 10475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 10251, 10382);

                    return f_10716_10258_10381(type, decodedReturnType, parameterTypes, refCustomModifiers: default, paramRefCustomModifiers: default);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 10126, 10475);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 10126, 10475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 10448, 10460);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 10126, 10475);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10716, 8769, 10486);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10716_9009_9023(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9009, 9023);
                    return return_v;
                }


                int
                f_10716_9009_9038(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9009, 9038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10716_9142_9156(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9142, 9156);
                    return return_v;
                }


                int
                f_10716_9142_9171(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9142, 9171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10716_9096_9172(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 9096, 9172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10716_9206_9220(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9206, 9220);
                    return return_v;
                }


                int
                f_10716_9206_9235(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9206, 9235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10716_9306_9320(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9306, 9320);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10716_9306_9331(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9306, 9331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10716_9395_9420(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9395, 9420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10716_9502_9527(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9502, 9527);
                    return return_v;
                }


                int
                f_10716_9551_9582(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 9551, 9582);
                    return 0;
                }


                int
                f_10716_9682_9713(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.ReverseContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 9682, 9713);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10716_9753_9787(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 9753, 9787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10716_9887_9901(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9887, 9901);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10716_9887_9931(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 9887, 9931);
                    return return_v;
                }


                int
                f_10716_9954_9974(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 9954, 9974);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10716_10068_10082(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 10068, 10082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10716_10068_10108(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 10068, 10108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10716_10176_10190(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 10176, 10190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10716_10176_10216(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 10176, 10216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10716_10258_10381(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                substitutedParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                paramRefCustomModifiers)
                {
                    var return_v = this_param.SubstituteTypeSymbol(substitutedReturnType, substitutedParameterTypes, refCustomModifiers: refCustomModifiers, paramRefCustomModifiers: paramRefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 10258, 10381);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 8769, 10486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 8769, 10486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol DecodeNamedType(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10716, 10498, 12916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 10632, 10701);

                var
                typeArgs = f_10716_10647_10700(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 10715, 10763);

                var
                decodedArgs = DecodeTypeArguments(typeArgs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 10779, 10814);

                NamedTypeSymbol
                decodedType = type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 10870, 10923);

                NamedTypeSymbol
                containingType = f_10716_10903_10922(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 10937, 10976);

                NamedTypeSymbol?
                decodedContainingType
                = default(NamedTypeSymbol?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 10990, 11328) || true) && (containingType is object && (DynAbs.Tracing.TraceSender.Expression_True(10716, 10994, 11050) && f_10716_11022_11050(containingType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 10990, 11328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 11084, 11140);

                    decodedContainingType = DecodeNamedType(containingType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 11158, 11208);

                    f_10716_11158_11207(f_10716_11171_11206(decodedContainingType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 10990, 11328);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 10990, 11328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 11274, 11313);

                    decodedContainingType = containingType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 10990, 11328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 11390, 11469);

                var
                containerChanged = !f_10716_11414_11468(decodedContainingType, containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 11483, 11529);

                var
                typeArgsChanged = typeArgs != decodedArgs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 11543, 12285) || true) && (typeArgsChanged || (DynAbs.Tracing.TraceSender.Expression_False(10716, 11547, 11582) || containerChanged))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 11543, 12285);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 11616, 12176) || true) && (containerChanged)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 11616, 12176);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 11678, 11755);

                        decodedType = f_10716_11692_11754(f_10716_11692_11722(decodedType), decodedContainingType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 12106, 12157);

                        return decodedType.ConstructIfGeneric(decodedArgs);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 11616, 12176);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 12196, 12270);

                    decodedType = f_10716_12210_12269(f_10716_12210_12230(type), decodedArgs, unbound: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 11543, 12285);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 12355, 12870) || true) && (f_10716_12359_12382(decodedType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 12355, 12870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 12416, 12491);

                    int
                    tupleCardinality = decodedType.TupleElementTypesWithAnnotations.Length
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 12509, 12855) || true) && (tupleCardinality > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 12509, 12855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 12575, 12639);

                        var
                        elementNames = EatElementNamesIfAvailable(tupleCardinality)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 12663, 12743);

                        f_10716_12663_12742(elementNames.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10716, 12676, 12741) || elementNames.Length == tupleCardinality));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 12767, 12836);

                        decodedType = f_10716_12781_12835(decodedType, elementNames);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 12509, 12855);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 12355, 12870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 12886, 12905);

                return decodedType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10716, 10498, 12916);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10716_10647_10700(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 10647, 10700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10716_10903_10922(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 10903, 10922);
                    return return_v;
                }


                bool
                f_10716_11022_11050(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 11022, 11050);
                    return return_v;
                }


                bool
                f_10716_11171_11206(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 11171, 11206);
                    return return_v;
                }


                int
                f_10716_11158_11207(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 11158, 11207);
                    return 0;
                }


                bool
                f_10716_11414_11468(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 11414, 11468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10716_11692_11722(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 11692, 11722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10716_11692_11754(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 11692, 11754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10716_12210_12230(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 12210, 12230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10716_12210_12269(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 12210, 12269);
                    return return_v;
                }


                bool
                f_10716_12359_12382(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 12359, 12382);
                    return return_v;
                }


                int
                f_10716_12663_12742(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 12663, 12742);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10716_12781_12835(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                tupleCompatibleType, System.Collections.Immutable.ImmutableArray<string?>
                elementNames)
                {
                    var return_v = NamedTypeSymbol.CreateTuple(tupleCompatibleType, elementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 12781, 12835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 10498, 12916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 10498, 12916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<TypeWithAnnotations> DecodeTypeArguments(ImmutableArray<TypeWithAnnotations> typeArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10716, 12928, 13905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13062, 13147) || true) && (typeArgs.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 13062, 13147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13116, 13132);

                    return typeArgs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 13062, 13147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13163, 13244);

                var
                decodedArgs = f_10716_13181_13243(typeArgs.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13258, 13281);

                var
                anyDecoded = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13356, 13379);
                    // Visit the type arguments in reverse
                    for (int
        i = typeArgs.Length - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13347, 13661) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13389, 13392)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 13347, 13661))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 13347, 13661);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13426, 13468);

                        TypeWithAnnotations
                        typeArg = typeArgs[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13486, 13544);

                        TypeWithAnnotations
                        decoded = DecodeTypeInternal(typeArg)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13562, 13603);

                        anyDecoded |= !decoded.IsSameAs(typeArg);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13621, 13646);

                        f_10716_13621_13645(decodedArgs, decoded);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10716, 1, 315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10716, 1, 315);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13677, 13794) || true) && (!anyDecoded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 13677, 13794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13726, 13745);

                    f_10716_13726_13744(decodedArgs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13763, 13779);

                    return typeArgs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 13677, 13794);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13810, 13840);

                f_10716_13810_13839(
                            decodedArgs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 13854, 13894);

                return f_10716_13861_13893(decodedArgs);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10716, 12928, 13905);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10716_13181_13243(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 13181, 13243);
                    return return_v;
                }


                int
                f_10716_13621_13645(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 13621, 13645);
                    return 0;
                }


                int
                f_10716_13726_13744(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 13726, 13744);
                    return 0;
                }


                int
                f_10716_13810_13839(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.ReverseContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 13810, 13839);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10716_13861_13893(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 13861, 13893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 12928, 13905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 12928, 13905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ArrayTypeSymbol DecodeArrayType(ArrayTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10716, 13917, 14169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 14003, 14096);

                TypeWithAnnotations
                decodedElementType = DecodeTypeInternal(f_10716_14063_14094(type))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 14110, 14158);

                return f_10716_14117_14157(type, decodedElementType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10716, 13917, 14169);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10716_14063_14094(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10716, 14063, 14094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10716_14117_14157(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations)
                {
                    var return_v = this_param.WithElementType(elementTypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 14117, 14157);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 13917, 14169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 13917, 14169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations DecodeTypeInternal(TypeWithAnnotations typeWithAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10716, 14181, 14622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 14293, 14336);

                TypeSymbol
                type = typeWithAnnotations.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 14350, 14388);

                TypeSymbol
                decoded = DecodeType(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 14402, 14611);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10716, 14409, 14439) || ((f_10716_14409_14439(decoded, type) && DynAbs.Tracing.TraceSender.Conditional_F2(10716, 14459, 14478)) || DynAbs.Tracing.TraceSender.Conditional_F3(10716, 14498, 14610))) ? typeWithAnnotations : TypeWithAnnotations.Create(decoded, typeWithAnnotations.NullableAnnotation, typeWithAnnotations.CustomModifiers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10716, 14181, 14622);

                bool
                f_10716_14409_14439(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 14409, 14439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 14181, 14622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 14181, 14622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<string?> EatElementNamesIfAvailable(int numberOfElements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10716, 14634, 15955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 14739, 14774);

                f_10716_14739_14773(numberOfElements > 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 14864, 14961) || true) && (_elementNames.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 14864, 14961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 14925, 14946);

                    return _elementNames;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 14864, 14961);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15046, 15336) || true) && (numberOfElements > _namesIndex)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 15046, 15336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15231, 15247);

                    _namesIndex = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15265, 15288);

                    _decodingFailed = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15306, 15321);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 15046, 15336);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15410, 15453);

                var
                start = _namesIndex - numberOfElements
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15467, 15487);

                _namesIndex = start;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15501, 15521);

                bool
                allNull = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15546, 15551);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15537, 15768) || true) && (i < numberOfElements)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15575, 15578)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 15537, 15768))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 15537, 15768);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15612, 15753) || true) && (_elementNames[start + i] != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 15612, 15753);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15690, 15706);

                            allNull = false;
                            DynAbs.Tracing.TraceSender.TraceBreak(10716, 15728, 15734);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 15612, 15753);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10716, 1, 232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10716, 1, 232);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15784, 15859) || true) && (allNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10716, 15784, 15859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15829, 15844);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10716, 15784, 15859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10716, 15875, 15944);

                return f_10716_15882_15943(_elementNames, start, numberOfElements);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10716, 14634, 15955);

                int
                f_10716_14739_14773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 14739, 14773);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10716_15882_15943(System.Collections.Immutable.ImmutableArray<string?>
                items, int
                start, int
                length)
                {
                    var return_v = ImmutableArray.Create(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10716, 15882, 15943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10716, 14634, 15955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 14634, 15955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static TupleTypeDecoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10716, 2410, 15962);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10716, 2410, 15962);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10716, 2410, 15962);
        }
    }
}
