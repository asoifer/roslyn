// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class MemberRefMetadataDecoder : MetadataDecoder
    {
        private readonly TypeSymbol _containingType;

        public MemberRefMetadataDecoder(
                    PEModuleSymbol moduleSymbol,
                    TypeSymbol containingType) : base(f_10699_1481_1493_C(moduleSymbol), containingType as PENamedTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10699, 1346, 1659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 1318, 1333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 1556, 1601);

                f_10699_1556_1600((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 1615, 1648);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10699, 1346, 1659);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 1346, 1659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 1346, 1659);
            }
        }

        protected override TypeSymbol GetGenericMethodTypeParamSymbol(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10699, 2006, 2273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 2201, 2262);

                return f_10699_2208_2261(position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10699, 2006, 2273);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10699_2208_2261(int
                index)
                {
                    var return_v = IndexedTypeParameterSymbol.GetTypeParameter(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 2208, 2261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 2006, 2273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 2006, 2273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeSymbol GetGenericTypeParamSymbol(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10699, 2490, 4240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 2584, 2648);

                PENamedTypeSymbol
                peType = _containingType as PENamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 2662, 3421) || true) && ((object)peType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 2662, 3421);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 2722, 2918) || true) && ((object)peType != null && (DynAbs.Tracing.TraceSender.Expression_True(10699, 2729, 2803) && (f_10699_2756_2776(peType) - f_10699_2779_2791(peType)) > position))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 2722, 2918);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 2845, 2899);

                            peType = f_10699_2854_2877(peType) as PENamedTypeSymbol;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 2722, 2918);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10699, 2722, 2918);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10699, 2722, 2918);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 2938, 3144) || true) && ((object)peType == null || (DynAbs.Tracing.TraceSender.Expression_False(10699, 2942, 3000) || f_10699_2968_2988(peType) <= position))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 2938, 3144);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3042, 3085);

                        return f_10699_3049_3084();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 2938, 3144);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3164, 3212);

                    position -= f_10699_3176_3196(peType) - f_10699_3199_3211(peType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3230, 3285);

                    f_10699_3230_3284(position >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10699, 3243, 3283) && position < f_10699_3271_3283(peType)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3305, 3383);

                    return f_10699_3312_3367(peType)[position].Type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 2662, 3421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3437, 3500);

                NamedTypeSymbol
                namedType = _containingType as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3514, 4121) || true) && ((object)namedType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 3514, 4121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3577, 3597);

                    int
                    cumulativeArity
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3615, 3639);

                    TypeSymbol
                    typeArgument
                    = default(TypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3657, 3746);

                    f_10699_3657_3745(position, namedType, out cumulativeArity, out typeArgument);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3764, 4106) || true) && ((object)typeArgument != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 3764, 4106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3838, 3858);

                        return typeArgument;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 3764, 4106);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 3764, 4106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 3940, 3982);

                        f_10699_3940_3981(cumulativeArity <= position);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4004, 4047);

                        return f_10699_4011_4046();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 3764, 4106);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 3514, 4121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4137, 4180);

                return f_10699_4144_4179();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10699, 2490, 4240);

                int
                f_10699_2756_2776(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataArity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 2756, 2776);
                    return return_v;
                }


                int
                f_10699_2779_2791(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 2779, 2791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10699_2854_2877(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 2854, 2877);
                    return return_v;
                }


                int
                f_10699_2968_2988(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataArity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 2968, 2988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10699_3049_3084()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 3049, 3084);
                    return return_v;
                }


                int
                f_10699_3176_3196(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataArity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 3176, 3196);
                    return return_v;
                }


                int
                f_10699_3199_3211(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 3199, 3211);
                    return return_v;
                }


                int
                f_10699_3271_3283(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 3271, 3283);
                    return return_v;
                }


                int
                f_10699_3230_3284(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 3230, 3284);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10699_3312_3367(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 3312, 3367);
                    return return_v;
                }


                int
                f_10699_3657_3745(int
                position, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, out int
                cumulativeArity, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    GetGenericTypeArgumentSymbol(position, namedType, out cumulativeArity, out typeArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 3657, 3745);
                    return 0;
                }


                int
                f_10699_3940_3981(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 3940, 3981);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10699_4011_4046()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 4011, 4046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10699_4144_4179()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 4144, 4179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 2490, 4240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 2490, 4240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetGenericTypeArgumentSymbol(int position, NamedTypeSymbol namedType, out int cumulativeArity, out TypeSymbol typeArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10699, 4252, 5271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4420, 4454);

                cumulativeArity = f_10699_4438_4453(namedType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4468, 4488);

                typeArgument = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4504, 4524);

                int
                arityOffset = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4540, 4586);

                var
                containingType = f_10699_4561_4585(namedType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4600, 4972) || true) && ((object)containingType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 4600, 4972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4668, 4702);

                    int
                    containingTypeCumulativeArity
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4720, 4828);

                    f_10699_4720_4827(position, containingType, out containingTypeCumulativeArity, out typeArgument);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4846, 4895);

                    cumulativeArity += containingTypeCumulativeArity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4913, 4957);

                    arityOffset = containingTypeCumulativeArity;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 4600, 4972);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 4988, 5260) || true) && (arityOffset <= position && (DynAbs.Tracing.TraceSender.Expression_True(10699, 4992, 5045) && position < cumulativeArity))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 4988, 5260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 5079, 5122);

                    f_10699_5079_5121((object)typeArgument == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 5142, 5245);

                    typeArgument = f_10699_5157_5215(namedType)[position - arityOffset].Type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 4988, 5260);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10699, 4252, 5271);

                int
                f_10699_4438_4453(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 4438, 4453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10699_4561_4585(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 4561, 4585);
                    return return_v;
                }


                int
                f_10699_4720_4827(int
                position, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, out int
                cumulativeArity, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    GetGenericTypeArgumentSymbol(position, namedType, out cumulativeArity, out typeArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 4720, 4827);
                    return 0;
                }


                int
                f_10699_5079_5121(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 5079, 5121);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10699_5157_5215(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 5157, 5215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 4252, 5271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 4252, 5271);
            }
        }

        internal Symbol FindMember(TypeSymbol targetTypeSymbol, MemberReferenceHandle memberRef, bool methodsOnly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10699, 5881, 7900);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 6012, 6109) || true) && ((object)targetTypeSymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 6012, 6109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 6082, 6094);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 6012, 6109);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 6161, 6223);

                    string
                    memberName = f_10699_6181_6222(Module, memberRef)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 6241, 6308);

                    BlobHandle
                    signatureHandle = f_10699_6270_6307(Module, memberRef)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 6328, 6360);

                    SignatureHeader
                    signatureHeader
                    = default(SignatureHeader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 6378, 6480);

                    BlobReader
                    signaturePointer = f_10699_6408_6479(this, signatureHandle, out signatureHeader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 6500, 7769);

                    switch (signatureHeader.RawValue & SignatureHeader.CallingConventionOrKindMask)
                    {

                        case (byte)SignatureCallingConvention.Default:
                        case (byte)SignatureCallingConvention.VarArgs:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 6500, 7769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 6760, 6779);

                            int
                            typeParamCount
                            = default(int);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 6805, 6944);

                            ParamInfo<TypeSymbol>[]
                            targetParamInfo = f_10699_6847_6943(this, ref signaturePointer, signatureHeader, out typeParamCount)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 6970, 7079);

                            return f_10699_6977_7078(targetTypeSymbol, memberName, signatureHeader, typeParamCount, targetParamInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 6500, 7769);

                        case (byte)SignatureKind.Field:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 6500, 7769);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 7160, 7310) || true) && (methodsOnly)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 7160, 7310);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 7271, 7283);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 7160, 7310);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 7338, 7395);

                            ImmutableArray<ModifierInfo<TypeSymbol>>
                            customModifiers
                            = default(ImmutableArray<ModifierInfo<TypeSymbol>>);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 7421, 7508);

                            TypeSymbol
                            type = f_10699_7439_7507(this, ref signaturePointer, out customModifiers)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 7534, 7615);

                            return f_10699_7541_7614(targetTypeSymbol, memberName, customModifiers, type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 6500, 7769);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 6500, 7769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 7738, 7750);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 6500, 7769);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10699, 7798, 7889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 7862, 7874);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10699, 7798, 7889);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10699, 5881, 7900);

                string
                f_10699_6181_6222(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MemberReferenceHandle
                memberRef)
                {
                    var return_v = this_param.GetMemberRefNameOrThrow(memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 6181, 6222);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_10699_6270_6307(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MemberReferenceHandle
                memberRef)
                {
                    var return_v = this_param.GetSignatureOrThrow(memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 6270, 6307);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_10699_6408_6479(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MemberRefMetadataDecoder
                this_param, System.Reflection.Metadata.BlobHandle
                signature, out System.Reflection.Metadata.SignatureHeader
                signatureHeader)
                {
                    var return_v = this_param.DecodeSignatureHeaderOrThrow(signature, out signatureHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 6408, 6479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                f_10699_6847_6943(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MemberRefMetadataDecoder
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, System.Reflection.Metadata.SignatureHeader
                signatureHeader, out int
                typeParameterCount)
                {
                    var return_v = this_param.DecodeSignatureParametersOrThrow(ref signatureReader, signatureHeader, out typeParameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 6847, 6943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10699_6977_7078(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetTypeSymbol, string
                targetMemberName, System.Reflection.Metadata.SignatureHeader
                targetMemberSignatureHeader, int
                targetMemberTypeParamCount, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                targetParamInfo)
                {
                    var return_v = FindMethodBySignature(targetTypeSymbol, targetMemberName, targetMemberSignatureHeader, targetMemberTypeParamCount, targetParamInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 6977, 7078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10699_7439_7507(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MemberRefMetadataDecoder
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.DecodeFieldSignature(ref signatureReader, out customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 7439, 7507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10699_7541_7614(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetTypeSymbol, string
                targetMemberName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = FindFieldBySignature(targetTypeSymbol, targetMemberName, customModifiers, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 7541, 7614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 5881, 7900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 5881, 7900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static FieldSymbol FindFieldBySignature(TypeSymbol targetTypeSymbol, string targetMemberName, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10699, 7912, 8860);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 8113, 8821);
                    foreach (Symbol member in f_10699_8139_8184_I(f_10699_8139_8184(targetTypeSymbol, targetMemberName)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 8113, 8821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 8218, 8252);

                        var
                        field = member as FieldSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 8270, 8300);

                        TypeWithAnnotations
                        fieldType
                        = default(TypeWithAnnotations);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 8320, 8806) || true) && ((object)field != null && (DynAbs.Tracing.TraceSender.Expression_True(10699, 8324, 8483) && f_10699_8370_8483((fieldType = f_10699_8401_8426(field)).Type, type, TypeCompareKind.CLRSignatureCompareOptions)) && (DynAbs.Tracing.TraceSender.Expression_True(10699, 8324, 8572) && f_10699_8508_8572(fieldType.CustomModifiers, customModifiers)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 8320, 8806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 8774, 8787);

                            return field;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 8320, 8806);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 8113, 8821);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10699, 1, 709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10699, 1, 709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 8837, 8849);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10699, 7912, 8860);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10699_8139_8184(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 8139, 8184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10699_8401_8426(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 8401, 8426);
                    return return_v;
                }


                bool
                f_10699_8370_8483(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 8370, 8483);
                    return return_v;
                }


                bool
                f_10699_8508_8572(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                candidateCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                targetCustomModifiers)
                {
                    var return_v = CustomModifiersMatch(candidateCustomModifiers, targetCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 8508, 8572);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10699_8139_8184_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 8139, 8184);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 7912, 8860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 7912, 8860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodSymbol FindMethodBySignature(TypeSymbol targetTypeSymbol, string targetMemberName, SignatureHeader targetMemberSignatureHeader, int targetMemberTypeParamCount, ParamInfo<TypeSymbol>[] targetParamInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10699, 8872, 9836);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 9118, 9797);
                    foreach (Symbol member in f_10699_9144_9189_I(f_10699_9144_9189(targetTypeSymbol, targetMemberName)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 9118, 9797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 9223, 9259);

                        var
                        method = member as MethodSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 9277, 9782) || true) && ((object)method != null && (DynAbs.Tracing.TraceSender.Expression_True(10699, 9281, 9400) && ((byte)f_10699_9335_9359(method) == targetMemberSignatureHeader.RawValue)) && (DynAbs.Tracing.TraceSender.Expression_True(10699, 9281, 9469) && (targetMemberTypeParamCount == f_10699_9456_9468(method))) && (DynAbs.Tracing.TraceSender.Expression_True(10699, 9281, 9547) && f_10699_9494_9547(method, targetParamInfo)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 9277, 9782);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 9749, 9763);

                            return method;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 9277, 9782);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 9118, 9797);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10699, 1, 680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10699, 1, 680);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 9813, 9825);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10699, 8872, 9836);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10699_9144_9189(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 9144, 9189);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10699_9335_9359(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 9335, 9359);
                    return return_v;
                }


                int
                f_10699_9456_9468(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 9456, 9468);
                    return return_v;
                }


                bool
                f_10699_9494_9547(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                candidateMethod, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                targetParamInfo)
                {
                    var return_v = MethodSymbolMatchesParamInfo(candidateMethod, targetParamInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 9494, 9547);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10699_9144_9189_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 9144, 9189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 8872, 9836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 8872, 9836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool MethodSymbolMatchesParamInfo(MethodSymbol candidateMethod, ParamInfo<TypeSymbol>[] targetParamInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10699, 9848, 11027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 9992, 10035);

                int
                numParams = f_10699_10008_10030(targetParamInfo) - 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 10077, 10186) || true) && (f_10699_10081_10111(candidateMethod) != numParams)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 10077, 10186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 10158, 10171);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 10077, 10186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 10354, 10528);

                TypeMap
                candidateMethodTypeMap = f_10699_10387_10527(f_10699_10417_10447(candidateMethod), f_10699_10466_10520(f_10699_10498_10519(candidateMethod)), true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 10544, 10692) || true) && (!f_10699_10549_10630(candidateMethod, candidateMethodTypeMap, ref targetParamInfo[0]))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 10544, 10692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 10664, 10677);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 10544, 10692);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 10717, 10722);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 10708, 10988) || true) && (i < numParams)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 10739, 10742)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 10708, 10988))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 10708, 10988);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 10776, 10973) || true) && (!f_10699_10781_10899(f_10699_10797_10823(candidateMethod)[i], candidateMethodTypeMap, ref targetParamInfo[i + 1 /*for return type*/]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 10776, 10973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 10941, 10954);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 10776, 10973);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10699, 1, 281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10699, 1, 281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 11004, 11016);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10699, 9848, 11027);

                int
                f_10699_10008_10030(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 10008, 10030);
                    return return_v;
                }


                int
                f_10699_10081_10111(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 10081, 10111);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10699_10417_10447(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 10417, 10447);
                    return return_v;
                }


                int
                f_10699_10498_10519(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 10498, 10519);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10699_10466_10520(int
                count)
                {
                    var return_v = IndexedTypeParameterSymbol.Take(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 10466, 10520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10699_10387_10527(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to, bool
                allowAlpha)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 10387, 10527);
                    return return_v;
                }


                bool
                f_10699_10549_10630(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                candidateMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                candidateMethodTypeMap, ref Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                targetReturnParam)
                {
                    var return_v = ReturnTypesMatch(candidateMethod, candidateMethodTypeMap, ref targetReturnParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 10549, 10630);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10699_10797_10823(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 10797, 10823);
                    return return_v;
                }


                bool
                f_10699_10781_10899(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                candidateParam, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                candidateMethodTypeMap, ref Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                targetParam)
                {
                    var return_v = ParametersMatch(candidateParam, candidateMethodTypeMap, ref targetParam);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 10781, 10899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 9848, 11027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 9848, 11027);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ParametersMatch(ParameterSymbol candidateParam, TypeMap candidateMethodTypeMap, ref ParamInfo<TypeSymbol> targetParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10699, 11039, 12324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 11202, 11247);

                f_10699_11202_11246(candidateMethodTypeMap != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 11422, 11551) || true) && ((f_10699_11427_11449(candidateParam) != RefKind.None) != targetParam.IsByRef)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 11422, 11551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 11523, 11536);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 11422, 11551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 11695, 11787);

                var
                substituted = candidateParam.TypeWithAnnotations.SubstituteType(candidateMethodTypeMap)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 11801, 11965) || true) && (!f_10699_11806_11903(substituted.Type, targetParam.Type, TypeCompareKind.CLRSignatureCompareOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 11801, 11965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 11937, 11950);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 11801, 11965);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 11981, 12285) || true) && (!f_10699_11986_12064(substituted.CustomModifiers, targetParam.CustomModifiers) || (DynAbs.Tracing.TraceSender.Expression_False(10699, 11985, 12223) || !f_10699_12086_12223(f_10699_12107_12190(candidateMethodTypeMap, f_10699_12156_12189(candidateParam)), targetParam.RefCustomModifiers)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 11981, 12285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 12257, 12270);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 11981, 12285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 12301, 12313);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10699, 11039, 12324);

                int
                f_10699_11202_11246(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 11202, 11246);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10699_11427_11449(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 11427, 11449);
                    return return_v;
                }


                bool
                f_10699_11806_11903(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 11806, 11903);
                    return return_v;
                }


                bool
                f_10699_11986_12064(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                candidateCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                targetCustomModifiers)
                {
                    var return_v = CustomModifiersMatch(candidateCustomModifiers, targetCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 11986, 12064);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10699_12156_12189(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 12156, 12189);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10699_12107_12190(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 12107, 12190);
                    return return_v;
                }


                bool
                f_10699_12086_12223(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                candidateCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                targetCustomModifiers)
                {
                    var return_v = CustomModifiersMatch(candidateCustomModifiers, targetCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 12086, 12223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 11039, 12324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 11039, 12324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ReturnTypesMatch(MethodSymbol candidateMethod, TypeMap candidateMethodTypeMap, ref ParamInfo<TypeSymbol> targetReturnParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10699, 12336, 13626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 12504, 12549);

                f_10699_12504_12548(candidateMethodTypeMap != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 12565, 12688) || true) && (f_10699_12569_12597(candidateMethod) != targetReturnParam.IsByRef)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 12565, 12688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 12660, 12673);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 12565, 12688);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 12704, 12788);

                TypeWithAnnotations
                candidateMethodType = f_10699_12746_12787(candidateMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 12802, 12855);

                TypeSymbol
                targetReturnType = targetReturnParam.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 12999, 13076);

                var
                substituted = candidateMethodType.SubstituteType(candidateMethodTypeMap)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 13090, 13254) || true) && (!f_10699_13095_13192(substituted.Type, targetReturnType, TypeCompareKind.CLRSignatureCompareOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 13090, 13254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 13226, 13239);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 13090, 13254);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 13270, 13587) || true) && (!f_10699_13275_13359(substituted.CustomModifiers, targetReturnParam.CustomModifiers) || (DynAbs.Tracing.TraceSender.Expression_False(10699, 13274, 13525) || !f_10699_13381_13525(f_10699_13402_13486(candidateMethodTypeMap, f_10699_13451_13485(candidateMethod)), targetReturnParam.RefCustomModifiers)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 13270, 13587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 13559, 13572);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 13270, 13587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 13603, 13615);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10699, 12336, 13626);

                int
                f_10699_12504_12548(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 12504, 12548);
                    return 0;
                }


                bool
                f_10699_12569_12597(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsByRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 12569, 12597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10699_12746_12787(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 12746, 12787);
                    return return_v;
                }


                bool
                f_10699_13095_13192(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 13095, 13192);
                    return return_v;
                }


                bool
                f_10699_13275_13359(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                candidateCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                targetCustomModifiers)
                {
                    var return_v = CustomModifiersMatch(candidateCustomModifiers, targetCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 13275, 13359);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10699_13451_13485(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 13451, 13485);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10699_13402_13486(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers)
                {
                    var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 13402, 13486);
                    return return_v;
                }


                bool
                f_10699_13381_13525(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                candidateCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                targetCustomModifiers)
                {
                    var return_v = CustomModifiersMatch(candidateCustomModifiers, targetCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 13381, 13525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 12336, 13626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 12336, 13626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CustomModifiersMatch(ImmutableArray<CustomModifier> candidateCustomModifiers, ImmutableArray<ModifierInfo<TypeSymbol>> targetCustomModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10699, 13638, 14877);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 13824, 14138) || true) && (targetCustomModifiers.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10699, 13828, 13892) || targetCustomModifiers.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 13824, 14138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 13926, 14004);

                    return candidateCustomModifiers.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10699, 13933, 14003) || candidateCustomModifiers.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 13824, 14138);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 13824, 14138);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14038, 14138) || true) && (candidateCustomModifiers.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 14038, 14138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14110, 14123);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 14038, 14138);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 13824, 14138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14154, 14194);

                var
                n = candidateCustomModifiers.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14208, 14307) || true) && (targetCustomModifiers.Length != n)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 14208, 14307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14279, 14292);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 14208, 14307);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14332, 14337);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14323, 14838) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14346, 14349)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 14323, 14838))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 14323, 14838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14383, 14435);

                        var
                        targetCustomModifier = targetCustomModifiers[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14453, 14522);

                        CustomModifier
                        candidateCustomModifier = candidateCustomModifiers[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14542, 14823) || true) && (targetCustomModifier.IsOptional != f_10699_14581_14615(candidateCustomModifier) || (DynAbs.Tracing.TraceSender.Expression_False(10699, 14546, 14749) || !f_10699_14641_14749(targetCustomModifier.Modifier, f_10699_14686_14748(((CSharpCustomModifier)candidateCustomModifier)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10699, 14542, 14823);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14791, 14804);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10699, 14542, 14823);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10699, 1, 516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10699, 1, 516);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10699, 14854, 14866);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10699, 13638, 14877);

                bool
                f_10699_14581_14615(Microsoft.CodeAnalysis.CustomModifier
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 14581, 14615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10699_14686_14748(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                this_param)
                {
                    var return_v = this_param.ModifierSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10699, 14686, 14748);
                    return return_v;
                }


                bool
                f_10699_14641_14749(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 14641, 14749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10699, 13638, 14877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 13638, 14877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MemberRefMetadataDecoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10699, 1098, 14884);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10699, 1098, 14884);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10699, 1098, 14884);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10699, 1098, 14884);

        int
        f_10699_1556_1600(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10699, 1556, 1600);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10699_1481_1493_C(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10699, 1346, 1659);
            return return_v;
        }

    }
}
