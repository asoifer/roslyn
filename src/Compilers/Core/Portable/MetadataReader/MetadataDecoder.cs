// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    [StructLayout(LayoutKind.Auto)]
    internal struct ModifierInfo<TypeSymbol>
            where TypeSymbol : class
    {

        internal readonly bool IsOptional;

        internal readonly TypeSymbol Modifier;

        public ModifierInfo(bool isOptional, TypeSymbol modifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(406, 889, 1040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 971, 995);

                IsOptional = isOptional;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 1009, 1029);

                Modifier = modifier;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(406, 889, 1040);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 889, 1040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 889, 1040);
            }
        }
        static ModifierInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(406, 667, 1047);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(406, 667, 1047);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 667, 1047);
        }
    }
    internal static class ModifierInfoExtensions
    {
        internal static bool AnyRequired<TypeSymbol>(this ImmutableArray<ModifierInfo<TypeSymbol>> modifiers) where TypeSymbol : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(406, 1116, 1350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 1267, 1339);

                return f_406_1274_1301_M(!modifiers.IsDefaultOrEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(406, 1274, 1338) && modifiers.Any(m => !m.IsOptional));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(406, 1116, 1350);

                bool
                f_406_1274_1301_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 1274, 1301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 1116, 1350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 1116, 1350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModifierInfoExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(406, 1055, 1357);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(406, 1055, 1357);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 1055, 1357);
        }

    }

    [StructLayout(LayoutKind.Auto)]
    internal struct ParamInfo<TypeSymbol>
            where TypeSymbol : class
    {

        internal bool IsByRef;

        internal TypeSymbol Type;

        internal ParameterHandle Handle;

        internal ImmutableArray<ModifierInfo<TypeSymbol>> RefCustomModifiers;

        internal ImmutableArray<ModifierInfo<TypeSymbol>> CustomModifiers;
        static ParamInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(406, 1365, 1765);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(406, 1365, 1765);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 1365, 1765);
        }
    }

    [StructLayout(LayoutKind.Auto)]
    internal struct LocalInfo<TypeSymbol>
            where TypeSymbol : class
    {

        internal readonly byte[] SignatureOpt;

        internal readonly TypeSymbol Type;

        internal readonly ImmutableArray<ModifierInfo<TypeSymbol>> CustomModifiers;

        internal readonly LocalSlotConstraints Constraints;

        internal LocalInfo(TypeSymbol type, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers, LocalSlotConstraints constraints, byte[] signatureOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(406, 2138, 2527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 2311, 2338);

                f_406_2311_2337(type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 2354, 2371);

                this.Type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 2385, 2424);

                this.CustomModifiers = customModifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 2438, 2469);

                this.Constraints = constraints;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 2483, 2516);

                this.SignatureOpt = signatureOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(406, 2138, 2527);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 2138, 2527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 2138, 2527);
            }
        }

        internal LocalInfo<TypeSymbol> WithSignature(byte[] signature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 2539, 2732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 2626, 2721);

                return f_406_2633_2720(this.Type, this.CustomModifiers, this.Constraints, signature);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 2539, 2732);

                Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>
                f_406_2633_2720(TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints, byte[]
                signatureOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>(type, customModifiers, constraints, signatureOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 2633, 2720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 2539, 2732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 2539, 2732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 2764, 2814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 2767, 2814);
                    return (Constraints & LocalSlotConstraints.ByRef) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(406, 2764, 2814);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 2764, 2814);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 2764, 2814);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPinned
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 2848, 2899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 2851, 2899);
                    return (Constraints & LocalSlotConstraints.Pinned) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(406, 2848, 2899);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 2848, 2899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 2848, 2899);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        static LocalInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(406, 1773, 2907);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(406, 1773, 2907);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 1773, 2907);
        }

        static int
        f_406_2311_2337(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 2311, 2337);
            return 0;
        }

    }

#nullable enable
    internal interface IAttributeNamedArgumentDecoder
    {

        (KeyValuePair<string, TypedConstant> nameValuePair, bool isProperty, SerializationTypeCode typeCode, SerializationTypeCode elementTypeCode) DecodeCustomAttributeNamedArgumentOrThrow(ref BlobReader argReader);
    }
    internal abstract class MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol> :
            TypeNameDecoder<ModuleSymbol, TypeSymbol>,
            IAttributeNamedArgumentDecoder
            where ModuleSymbol : class, IModuleSymbolInternal
            where TypeSymbol : class, Symbol, ITypeSymbolInternal
            where MethodSymbol : class, Symbol, IMethodSymbolInternal
            where FieldSymbol : class, Symbol, IFieldSymbolInternal
            where Symbol : class, ISymbolInternal
    {
        public readonly PEModule Module;

        private readonly AssemblyIdentity _containingAssemblyIdentity;

        internal MetadataDecoder(PEModule module, AssemblyIdentity containingAssemblyIdentity, SymbolFactory<ModuleSymbol, TypeSymbol> factory, ModuleSymbol moduleSymbol) : base(f_406_4158_4165_C<ModuleSymbol, TypeSymbol>(factory), moduleSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(406, 3975, 4351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 3778, 3784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 3935, 3962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 4205, 4234);

                f_406_4205_4233(module != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 4248, 4269);

                this.Module = module;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 4283, 4340);

                _containingAssemblyIdentity = containingAssemblyIdentity;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(406, 3975, 4351);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 3975, 4351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 3975, 4351);
            }
        }

        internal TypeSymbol GetTypeOfToken(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 4363, 4540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 4442, 4464);

                bool
                isNoPiaLocalType
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 4478, 4529);

                return f_406_4485_4528(this, token, out isNoPiaLocalType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 4363, 4540);

                TypeSymbol
                f_406_4485_4528(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                token, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.GetTypeOfToken(token, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 4485, 4528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 4363, 4540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 4363, 4540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeSymbol GetTypeOfToken(EntityHandle token, out bool isNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 4552, 5657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 4658, 4685);

                f_406_4658_4684(f_406_4671_4683_M(!token.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 4701, 4717);

                TypeSymbol
                type
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 4731, 4765);

                HandleKind
                tokenType = token.Kind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 4781, 5577);

                switch (tokenType)
                {

                    case HandleKind.TypeDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 4781, 5577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 4885, 4985);

                        type = f_406_4892_4984(this, token, out isNoPiaLocalType, isContainingType: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 5007, 5013);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 4781, 5577);

                    case HandleKind.TypeSpecification:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 4781, 5577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5089, 5114);

                        isNoPiaLocalType = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5136, 5193);

                        type = f_406_5143_5192(this, token);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 5215, 5221);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 4781, 5577);

                    case HandleKind.TypeReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 4781, 5577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5293, 5367);

                        type = f_406_5300_5366(this, token, out isNoPiaLocalType);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 5389, 5395);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 4781, 5577);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 4781, 5577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5445, 5470);

                        isNoPiaLocalType = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5492, 5534);

                        type = f_406_5499_5533(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 5556, 5562);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 4781, 5577);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5593, 5620);

                f_406_5593_5619(type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5634, 5646);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 4552, 5657);

                bool
                f_406_4671_4683_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 4671, 4683);
                    return return_v;
                }


                int
                f_406_4658_4684(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 4658, 4684);
                    return 0;
                }


                TypeSymbol
                f_406_4892_4984(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                typeDef, out bool
                isNoPiaLocalType, bool
                isContainingType)
                {
                    var return_v = this_param.GetTypeOfTypeDef((System.Reflection.Metadata.TypeDefinitionHandle)typeDef, out isNoPiaLocalType, isContainingType: isContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 4892, 4984);
                    return return_v;
                }


                TypeSymbol
                f_406_5143_5192(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                typeSpec)
                {
                    var return_v = this_param.GetTypeOfTypeSpec((System.Reflection.Metadata.TypeSpecificationHandle)typeSpec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 5143, 5192);
                    return return_v;
                }


                TypeSymbol
                f_406_5300_5366(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                typeRef, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.GetTypeOfTypeRef((System.Reflection.Metadata.TypeReferenceHandle)typeRef, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 5300, 5366);
                    return return_v;
                }


                TypeSymbol
                f_406_5499_5533(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 5499, 5533);
                    return return_v;
                }


                int
                f_406_5593_5619(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 5593, 5619);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 4552, 5657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 4552, 5657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol GetTypeOfTypeSpec(TypeSpecificationHandle typeSpec)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 5669, 6473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5764, 5781);

                TypeSymbol
                ptype
                = default(TypeSymbol);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5833, 5924);

                    BlobReader
                    memoryReader = f_406_5859_5923(this.Module, typeSpec)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5944, 5972);

                    bool
                    refersToNoPiaLocalType
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 5990, 6062);

                    ptype = f_406_5998_6061(this, ref memoryReader, out refersToNoPiaLocalType);
                }
                catch (BadImageFormatException mrEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 6091, 6260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 6160, 6207);

                    ptype = f_406_6168_6206(this, mrEx);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 6091, 6260);
                }
                catch (UnsupportedSignatureContent)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 6274, 6433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 6342, 6385);

                    ptype = f_406_6350_6384(this);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 6274, 6433);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 6449, 6462);

                return ptype;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 5669, 6473);

                System.Reflection.Metadata.BlobReader
                f_406_5859_5923(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeSpecificationHandle
                typeSpec)
                {
                    var return_v = this_param.GetTypeSpecificationSignatureReaderOrThrow(typeSpec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 5859, 5923);
                    return return_v;
                }


                TypeSymbol
                f_406_5998_6061(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 5998, 6061);
                    return return_v;
                }


                TypeSymbol
                f_406_6168_6206(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.BadImageFormatException
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 6168, 6206);
                    return return_v;
                }


                TypeSymbol
                f_406_6350_6384(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 6350, 6384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 5669, 6473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 5669, 6473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded type is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private TypeSymbol DecodeTypeOrThrow(ref BlobReader ppSig, out bool refersToNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 6690, 6964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 6806, 6865);

                SignatureTypeCode
                typeCode = ppSig.ReadSignatureTypeCode()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 6879, 6953);

                return f_406_6886_6952(this, ref ppSig, typeCode, out refersToNoPiaLocalType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 6690, 6964);

                TypeSymbol
                f_406_6886_6952(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, System.Reflection.Metadata.SignatureTypeCode
                typeCode, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, typeCode, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 6886, 6952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 6690, 6964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 6690, 6964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded type is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private TypeSymbol DecodeTypeOrThrow(ref BlobReader ppSig, SignatureTypeCode typeCode, out bool refersToNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 7181, 15316);
                int typeParamCount = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 7325, 7347);

                TypeSymbol
                typeSymbol
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 7361, 7379);

                int
                paramPosition
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 7393, 7444);

                ImmutableArray<ModifierInfo<TypeSymbol>>
                modifiers
                = default(ImmutableArray<ModifierInfo<TypeSymbol>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 7460, 7491);

                refersToNoPiaLocalType = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 7543, 15271);

                switch (typeCode)
                {

                    case SignatureTypeCode.Void:
                    case SignatureTypeCode.Boolean:
                    case SignatureTypeCode.SByte:
                    case SignatureTypeCode.Byte:
                    case SignatureTypeCode.Int16:
                    case SignatureTypeCode.UInt16:
                    case SignatureTypeCode.Int32:
                    case SignatureTypeCode.UInt32:
                    case SignatureTypeCode.Int64:
                    case SignatureTypeCode.UInt64:
                    case SignatureTypeCode.Single:
                    case SignatureTypeCode.Double:
                    case SignatureTypeCode.Char:
                    case SignatureTypeCode.String:
                    case SignatureTypeCode.IntPtr:
                    case SignatureTypeCode.UIntPtr:
                    case SignatureTypeCode.Object:
                    case SignatureTypeCode.TypedReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 7543, 15271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 8461, 8515);

                        typeSymbol = f_406_8474_8514(this, f_406_8489_8513(typeCode));
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 8537, 8543);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 7543, 15271);

                    case SignatureTypeCode.TypeHandle:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 7543, 15271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 8934, 9075);

                        typeSymbol = f_406_8947_9074(this, ppSig.ReadTypeHandle(), out refersToNoPiaLocalType, allowTypeSpec: false, requireShortForm: true);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 9097, 9103);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 7543, 15271);

                    case SignatureTypeCode.Array:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 7543, 15271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 9174, 9196);

                        int
                        countOfDimensions
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 9218, 9235);

                        int
                        countOfSizes
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 9257, 9280);

                        int
                        countOfLowerBounds
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 9304, 9364);

                        modifiers = f_406_9316_9363(this, ref ppSig, out typeCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 9386, 9466);

                        typeSymbol = f_406_9399_9465(this, ref ppSig, typeCode, out refersToNoPiaLocalType);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 9488, 9737) || true) && (!ppSig.TryReadCompressedInteger(out countOfDimensions) || (DynAbs.Tracing.TraceSender.Expression_False(406, 9492, 9624) || !ppSig.TryReadCompressedInteger(out countOfSizes)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 9488, 9737);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 9674, 9714);

                            throw f_406_9680_9713();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 9488, 9737);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 9833, 9859);

                        ImmutableArray<int>
                        sizes
                        = default(ImmutableArray<int>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 9883, 10750) || true) && (countOfSizes == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 9883, 10750);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 9954, 9988);

                            sizes = ImmutableArray<int>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 9883, 10750);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 9883, 10750);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10086, 10144);

                            var
                            builder = f_406_10100_10143(countOfSizes)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10181, 10186);

                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10172, 10662) || true) && (i < countOfSizes)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10206, 10209)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 10172, 10662))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 10172, 10662);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10267, 10276);

                                    int
                                    size
                                    = default(int);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10306, 10635) || true) && (ppSig.TryReadCompressedInteger(out size))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 10306, 10635);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10416, 10434);

                                        f_406_10416_10433(builder, size);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 10306, 10635);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 10306, 10635);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10564, 10604);

                                        throw f_406_10570_10603();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 10306, 10635);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 491);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 491);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10690, 10727);

                            sizes = f_406_10698_10726(builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 9883, 10750);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10774, 10946) || true) && (!ppSig.TryReadCompressedInteger(out countOfLowerBounds))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 10774, 10946);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 10883, 10923);

                            throw f_406_10889_10922();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 10774, 10946);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11144, 11207);

                        ImmutableArray<int>
                        lowerBounds = default(ImmutableArray<int>)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11231, 12693) || true) && (countOfLowerBounds == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 11231, 12693);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11308, 11348);

                            lowerBounds = ImmutableArray<int>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 11231, 12693);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 11231, 12693);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11446, 11576);

                            ArrayBuilder<int>
                            builder = (DynAbs.Tracing.TraceSender.Conditional_F1(406, 11474, 11513) || ((countOfLowerBounds != countOfDimensions && DynAbs.Tracing.TraceSender.Conditional_F2(406, 11516, 11568)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 11571, 11575))) ? f_406_11516_11568(countOfLowerBounds, 0) : null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11613, 11618);

                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11604, 12495) || true) && (i < countOfLowerBounds)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11644, 11647)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 11604, 12495))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 11604, 12495);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11705, 11720);

                                    int
                                    lowerBound
                                    = default(int);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11750, 12468) || true) && (ppSig.TryReadCompressedSignedInteger(out lowerBound))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 11750, 12468);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11872, 12267) || true) && (lowerBound != 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 11872, 12267);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 11965, 12168) || true) && (builder == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 11965, 12168);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 12066, 12129);

                                                builder = f_406_12076_12128(countOfLowerBounds, 0);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 11965, 12168);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 12208, 12232);

                                            builder[i] = lowerBound;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 11872, 12267);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 11750, 12468);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 11750, 12468);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 12397, 12437);

                                        throw f_406_12403_12436();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 11750, 12468);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 892);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 892);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 12523, 12670) || true) && (builder != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 12523, 12670);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 12600, 12643);

                                lowerBounds = f_406_12614_12642(builder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 12523, 12670);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 11231, 12693);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 12717, 12813);

                        typeSymbol = f_406_12730_12812(this, countOfDimensions, typeSymbol, modifiers, sizes, lowerBounds);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 12835, 12841);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 7543, 15271);

                    case SignatureTypeCode.SZArray:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 7543, 15271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 12914, 12974);

                        modifiers = f_406_12926_12973(this, ref ppSig, out typeCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 12996, 13076);

                        typeSymbol = f_406_13009_13075(this, ref ppSig, typeCode, out refersToNoPiaLocalType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 13098, 13155);

                        typeSymbol = f_406_13111_13154(this, typeSymbol, modifiers);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 13177, 13183);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 7543, 15271);

                    case SignatureTypeCode.Pointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 7543, 15271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 13256, 13316);

                        modifiers = f_406_13268_13315(this, ref ppSig, out typeCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 13338, 13418);

                        typeSymbol = f_406_13351_13417(this, ref ppSig, typeCode, out refersToNoPiaLocalType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 13440, 13498);

                        typeSymbol = f_406_13453_13497(this, typeSymbol, modifiers);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 13520, 13526);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 7543, 15271);

                    case SignatureTypeCode.GenericTypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 7543, 15271);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 13612, 13779) || true) && (!ppSig.TryReadCompressedInteger(out paramPosition))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 13612, 13779);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 13716, 13756);

                            throw f_406_13722_13755();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 13612, 13779);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 13803, 13857);

                        typeSymbol = f_406_13816_13856(this, paramPosition);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 13879, 13885);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 7543, 15271);

                    case SignatureTypeCode.GenericMethodParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 7543, 15271);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 13973, 14140) || true) && (!ppSig.TryReadCompressedInteger(out paramPosition))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 13973, 14140);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 14077, 14117);

                            throw f_406_14083_14116();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 13973, 14140);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 14164, 14224);

                        typeSymbol = f_406_14177_14223(this, paramPosition);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 14246, 14252);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 7543, 15271);

                    case SignatureTypeCode.GenericTypeInstance:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 7543, 15271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 14337, 14422);

                        typeSymbol = f_406_14350_14421(this, ref ppSig, out refersToNoPiaLocalType);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 14444, 14450);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 7543, 15271);

                    case SignatureTypeCode.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 7543, 15271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 14531, 14581);

                        var
                        signatureHeader = ppSig.ReadSignatureHeader()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 14603, 14789);

                        var
                        parameters = f_406_14620_14788(this, ref ppSig, signatureHeader, typeParameterCount: out typeParamCount, shouldProcessAllBytes: false, isFunctionPointerSignature: true)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 14813, 14949) || true) && (typeParamCount != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 14813, 14949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 14886, 14926);

                            throw f_406_14892_14925();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 14813, 14949);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 14973, 15138);

                        typeSymbol = f_406_14986_15137(this, f_406_15016_15101(signatureHeader.CallingConvention), f_406_15103_15136(parameters));
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 15160, 15166);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 7543, 15271);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 7543, 15271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 15216, 15256);

                        throw f_406_15222_15255();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 7543, 15271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 15287, 15305);

                return typeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 7181, 15316);

                Microsoft.CodeAnalysis.SpecialType
                f_406_8489_8513(System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = typeCode.ToSpecialType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 8489, 8513);
                    return return_v;
                }


                TypeSymbol
                f_406_8474_8514(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 8474, 8514);
                    return return_v;
                }


                TypeSymbol
                f_406_8947_9074(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                handle, out bool
                isNoPiaLocalType, bool
                allowTypeSpec, bool
                requireShortForm)
                {
                    var return_v = this_param.GetSymbolForTypeHandleOrThrow(handle, out isNoPiaLocalType, allowTypeSpec: allowTypeSpec, requireShortForm: requireShortForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 8947, 9074);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_9316_9363(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = this_param.DecodeModifiersOrThrow(ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 9316, 9363);
                    return return_v;
                }


                TypeSymbol
                f_406_9399_9465(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, System.Reflection.Metadata.SignatureTypeCode
                typeCode, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, typeCode, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 9399, 9465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_9680_9713()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 9680, 9713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_406_10100_10143(int
                capacity)
                {
                    var return_v = ArrayBuilder<int>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 10100, 10143);
                    return return_v;
                }


                int
                f_406_10416_10433(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 10416, 10433);
                    return 0;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_10570_10603()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 10570, 10603);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_406_10698_10726(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 10698, 10726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_10889_10922()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 10889, 10922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_406_11516_11568(int
                capacity, int
                fillWithValue)
                {
                    var return_v = ArrayBuilder<int>.GetInstance(capacity, fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 11516, 11568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_406_12076_12128(int
                capacity, int
                fillWithValue)
                {
                    var return_v = ArrayBuilder<int>.GetInstance(capacity, fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 12076, 12128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_12403_12436()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 12403, 12436);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_406_12614_12642(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 12614, 12642);
                    return return_v;
                }


                TypeSymbol
                f_406_12730_12812(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, int
                rank, TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers, System.Collections.Immutable.ImmutableArray<int>
                sizes, System.Collections.Immutable.ImmutableArray<int>
                lowerBounds)
                {
                    var return_v = this_param.GetMDArrayTypeSymbol(rank, elementType, customModifiers, sizes, lowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 12730, 12812);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_12926_12973(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = this_param.DecodeModifiersOrThrow(ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 12926, 12973);
                    return return_v;
                }


                TypeSymbol
                f_406_13009_13075(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, System.Reflection.Metadata.SignatureTypeCode
                typeCode, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, typeCode, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 13009, 13075);
                    return return_v;
                }


                TypeSymbol
                f_406_13111_13154(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.GetSZArrayTypeSymbol(elementType, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 13111, 13154);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_13268_13315(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = this_param.DecodeModifiersOrThrow(ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 13268, 13315);
                    return return_v;
                }


                TypeSymbol
                f_406_13351_13417(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, System.Reflection.Metadata.SignatureTypeCode
                typeCode, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, typeCode, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 13351, 13417);
                    return return_v;
                }


                TypeSymbol
                f_406_13453_13497(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.MakePointerTypeSymbol(type, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 13453, 13497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_13722_13755()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 13722, 13755);
                    return return_v;
                }


                TypeSymbol
                f_406_13816_13856(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, int
                position)
                {
                    var return_v = this_param.GetGenericTypeParamSymbol(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 13816, 13856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_14083_14116()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 14083, 14116);
                    return return_v;
                }


                TypeSymbol
                f_406_14177_14223(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, int
                position)
                {
                    var return_v = this_param.GetGenericMethodTypeParamSymbol(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 14177, 14223);
                    return return_v;
                }


                TypeSymbol
                f_406_14350_14421(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeGenericTypeInstanceOrThrow(ref ppSig, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 14350, 14421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>[]
                f_406_14620_14788(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, System.Reflection.Metadata.SignatureHeader
                signatureHeader, out int
                typeParameterCount, bool
                shouldProcessAllBytes, bool
                isFunctionPointerSignature)
                {
                    var return_v = this_param.DecodeSignatureParametersOrThrow(ref signatureReader, signatureHeader, out typeParameterCount, shouldProcessAllBytes: shouldProcessAllBytes, isFunctionPointerSignature: isFunctionPointerSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 14620, 14788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_14892_14925()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 14892, 14925);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_406_15016_15101(System.Reflection.Metadata.SignatureCallingConvention
                convention)
                {
                    var return_v = Cci.CallingConventionUtils.FromSignatureConvention(convention);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 15016, 15101);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>>
                f_406_15103_15136(params Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 15103, 15136);
                    return return_v;
                }


                TypeSymbol
                f_406_14986_15137(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, Microsoft.Cci.CallingConvention
                callingConvention, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>>
                retAndParamInfos)
                {
                    var return_v = this_param.MakeFunctionPointerTypeSymbol(callingConvention, retAndParamInfos);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 14986, 15137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_15222_15255()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 15222, 15255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 7181, 15316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 7181, 15316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol DecodeGenericTypeInstanceOrThrow(ref BlobReader ppSig, out bool refersToNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 15328, 17676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 15459, 15525);

                SignatureTypeCode
                elementTypeCode = ppSig.ReadSignatureTypeCode()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 15539, 15679) || true) && (elementTypeCode != SignatureTypeCode.TypeHandle)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 15539, 15679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 15624, 15664);

                    throw f_406_15630_15663();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 15539, 15679);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 15695, 15746);

                EntityHandle
                tokenGeneric = ppSig.ReadTypeHandle()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 15760, 15778);

                int
                argumentCount
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 15792, 15935) || true) && (!ppSig.TryReadCompressedInteger(out argumentCount))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 15792, 15935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 15880, 15920);

                    throw f_406_15886_15919();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 15792, 15935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 15951, 16029);

                TypeSymbol
                generic = f_406_15972_16028(this, tokenGeneric, out refersToNoPiaLocalType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16043, 16119);

                f_406_16043_16118(!refersToNoPiaLocalType || (DynAbs.Tracing.TraceSender.Expression_False(406, 16056, 16117) || f_406_16083_16099(generic) == TypeKind.Error));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16135, 16266);

                var
                argumentsBuilder = f_406_16158_16265(argumentCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16280, 16370);

                var
                argumentRefersToNoPiaLocalTypeBuilder = f_406_16324_16369(argumentCount)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16395, 16412);

                    for (int
        argumentIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16386, 16925) || true) && (argumentIndex < argumentCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16445, 16460)
        , argumentIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 16386, 16925))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 16386, 16925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16494, 16521);

                        bool
                        argumentRefersToNoPia
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16539, 16566);

                        SignatureTypeCode
                        typeCode
                        = default(SignatureTypeCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16584, 16685);

                        ImmutableArray<ModifierInfo<TypeSymbol>>
                        modifiers = f_406_16637_16684(this, ref ppSig, out typeCode)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16703, 16827);

                        f_406_16703_16826(argumentsBuilder, f_406_16724_16825(f_406_16748_16813(this, ref ppSig, typeCode, out argumentRefersToNoPia), modifiers));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 16845, 16910);

                        f_406_16845_16909(argumentRefersToNoPiaLocalTypeBuilder, argumentRefersToNoPia);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 540);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 17108, 17162);

                var
                arguments = f_406_17124_17161(argumentsBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 17176, 17272);

                var
                argumentRefersToNoPiaLocalType = f_406_17213_17271(argumentRefersToNoPiaLocalTypeBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 17286, 17387);

                TypeSymbol
                typeSymbol = f_406_17310_17386(this, generic, arguments, argumentRefersToNoPiaLocalType)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 17403, 17631);
                    foreach (bool flag in f_406_17425_17455_I(argumentRefersToNoPiaLocalType))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 17403, 17631);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 17489, 17616) || true) && (flag)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 17489, 17616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 17539, 17569);

                            refersToNoPiaLocalType = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(406, 17591, 17597);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 17489, 17616);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 17403, 17631);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 17647, 17665);

                return typeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 15328, 17676);

                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_15630_15663()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 15630, 15663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_15886_15919()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 15886, 15919);
                    return return_v;
                }


                TypeSymbol
                f_406_15972_16028(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                token, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.GetTypeOfToken(token, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 15972, 16028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_406_16083_16099(TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 16083, 16099);
                    return return_v;
                }


                int
                f_406_16043_16118(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 16043, 16118);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                f_406_16158_16265(int
                capacity)
                {
                    var return_v = ArrayBuilder<KeyValuePair<TypeSymbol, ImmutableArray<ModifierInfo<TypeSymbol>>>>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 16158, 16265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                f_406_16324_16369(int
                capacity)
                {
                    var return_v = ArrayBuilder<bool>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 16324, 16369);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_16637_16684(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = this_param.DecodeModifiersOrThrow(ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 16637, 16684);
                    return return_v;
                }


                TypeSymbol
                f_406_16748_16813(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, System.Reflection.Metadata.SignatureTypeCode
                typeCode, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, typeCode, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 16748, 16813);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>
                f_406_16724_16825(TypeSymbol
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                value)
                {
                    var return_v = KeyValuePairUtil.Create(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 16724, 16825);
                    return return_v;
                }


                int
                f_406_16703_16826(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                this_param, System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 16703, 16826);
                    return 0;
                }


                int
                f_406_16845_16909(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param, bool
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 16845, 16909);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                f_406_17124_17161(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 17124, 17161);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_406_17213_17271(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 17213, 17271);
                    return return_v;
                }


                TypeSymbol
                f_406_17310_17386(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                genericType, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                arguments, System.Collections.Immutable.ImmutableArray<bool>
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.SubstituteTypeParameters(genericType, arguments, refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 17310, 17386);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_406_17425_17455_I(System.Collections.Immutable.ImmutableArray<bool>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 17425, 17455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 15328, 17676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 15328, 17676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded type is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        internal TypeSymbol GetSymbolForTypeHandleOrThrow(EntityHandle handle, out bool isNoPiaLocalType, bool allowTypeSpec, bool requireShortForm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 17893, 20797);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 18058, 18163) || true) && (handle.IsNil)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 18058, 18163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 18108, 18148);

                    throw f_406_18114_18147();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 18058, 18163);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 18179, 18201);

                TypeSymbol
                typeSymbol
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 18215, 19126);

                switch (handle.Kind)
                {

                    case HandleKind.TypeDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 18215, 19126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 18321, 18428);

                        typeSymbol = f_406_18334_18427(this, handle, out isNoPiaLocalType, isContainingType: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 18450, 18456);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 18215, 19126);

                    case HandleKind.TypeReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 18215, 19126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 18528, 18609);

                        typeSymbol = f_406_18541_18608(this, handle, out isNoPiaLocalType);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 18631, 18637);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 18215, 19126);

                    case HandleKind.TypeSpecification:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 18215, 19126);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 18713, 18844) || true) && (!allowTypeSpec)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 18713, 18844);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 18781, 18821);

                            throw f_406_18787_18820();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 18713, 18844);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 18868, 18893);

                        isNoPiaLocalType = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 18915, 18979);

                        typeSymbol = f_406_18928_18978(this, handle);
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 19001, 19007);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 18215, 19126);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 18215, 19126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 19057, 19111);

                        throw f_406_19063_19110(handle.Kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 18215, 19126);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 20585, 20752) || true) && (requireShortForm && (DynAbs.Tracing.TraceSender.Expression_True(406, 20589, 20663) && f_406_20609_20663(f_406_20609_20631(typeSymbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 20585, 20752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 20697, 20737);

                    throw f_406_20703_20736();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 20585, 20752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 20768, 20786);

                return typeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 17893, 20797);

                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_18114_18147()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 18114, 18147);
                    return return_v;
                }


                TypeSymbol
                f_406_18334_18427(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                typeDef, out bool
                isNoPiaLocalType, bool
                isContainingType)
                {
                    var return_v = this_param.GetTypeOfTypeDef((System.Reflection.Metadata.TypeDefinitionHandle)typeDef, out isNoPiaLocalType, isContainingType: isContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 18334, 18427);
                    return return_v;
                }


                TypeSymbol
                f_406_18541_18608(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                typeRef, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.GetTypeOfTypeRef((System.Reflection.Metadata.TypeReferenceHandle)typeRef, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 18541, 18608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_18787_18820()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 18787, 18820);
                    return return_v;
                }


                TypeSymbol
                f_406_18928_18978(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                typeSpec)
                {
                    var return_v = this_param.GetTypeOfTypeSpec((System.Reflection.Metadata.TypeSpecificationHandle)typeSpec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 18928, 18978);
                    return return_v;
                }


                System.Exception
                f_406_19063_19110(System.Reflection.Metadata.HandleKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 19063, 19110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_406_20609_20631(TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 20609, 20631);
                    return return_v;
                }


                bool
                f_406_20609_20663(Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = type.HasShortFormSignatureEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 20609, 20663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_20703_20736()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 20703, 20736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 17893, 20797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 17893, 20797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        
        // MetaImport::GetTypeOfTypeRef
        private TypeSymbol GetTypeOfTypeRef(TypeReferenceHandle typeRef, out bool isNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 20850, 22779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 21133, 21223);

                ConcurrentDictionary<TypeReferenceHandle, TypeSymbol>
                cache = f_406_21195_21222(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 21237, 21255);

                TypeSymbol
                result
                = default(TypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 21271, 21466) || true) && (cache != null && (DynAbs.Tracing.TraceSender.Expression_True(406, 21275, 21330) && f_406_21292_21330(cache, typeRef, out result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 21271, 21466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 21364, 21389);

                    isNoPiaLocalType = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 21437, 21451);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 21271, 21466);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 21518, 21542);

                    string
                    name
                    = default(string),
                    @namespace
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 21560, 21589);

                    EntityHandle
                    resolutionScope
                    = default(EntityHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 21607, 21693);

                    f_406_21607_21692(Module, typeRef, out name, out @namespace, out resolutionScope);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 21711, 21773);

                    f_406_21711_21772(f_406_21724_21771(name));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 21793, 21983);

                    MetadataTypeName
                    mdName = (DynAbs.Tracing.TraceSender.Conditional_F1(406, 21819, 21840) || ((f_406_21819_21836(@namespace) > 0
                    && DynAbs.Tracing.TraceSender.Conditional_F2(406, 21864, 21923)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 21947, 21982))) ? MetadataTypeName.FromNamespaceAndTypeName(@namespace, name) : MetadataTypeName.FromTypeName(name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 22003, 22084);

                    result = f_406_22012_22083(this, ref mdName, resolutionScope, out isNoPiaLocalType);
                }
                catch (BadImageFormatException mrEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 22113, 22326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 22182, 22230);

                    result = f_406_22191_22229(this, mrEx);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 22286, 22311);

                    isNoPiaLocalType = false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 22113, 22326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 22342, 22371);

                f_406_22342_22370(result != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 22507, 22738) || true) && (cache != null && (DynAbs.Tracing.TraceSender.Expression_True(406, 22511, 22545) && !isNoPiaLocalType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 22507, 22738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 22579, 22632);

                    TypeSymbol
                    result1 = f_406_22600_22631(cache, typeRef, result)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 22650, 22723);

                    f_406_22650_22722(f_406_22663_22721(result1, result, TypeCompareKind.ConsiderEverything));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 22507, 22738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 22754, 22768);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 20850, 22779);

                System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeReferenceHandle, TypeSymbol>
                f_406_21195_21222(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetTypeRefHandleToTypeMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 21195, 21222);
                    return return_v;
                }


                bool
                f_406_21292_21330(System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeReferenceHandle, TypeSymbol>
                this_param, System.Reflection.Metadata.TypeReferenceHandle
                key, out TypeSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 21292, 21330);
                    return return_v;
                }


                int
                f_406_21607_21692(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeReferenceHandle
                handle, out string
                name, out string
                @namespace, out System.Reflection.Metadata.EntityHandle
                resolutionScope)
                {
                    this_param.GetTypeRefPropsOrThrow(handle, out name, out @namespace, out resolutionScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 21607, 21692);
                    return 0;
                }


                bool
                f_406_21724_21771(string
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 21724, 21771);
                    return return_v;
                }


                int
                f_406_21711_21772(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 21711, 21772);
                    return 0;
                }


                int
                f_406_21819_21836(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 21819, 21836);
                    return return_v;
                }


                TypeSymbol
                f_406_22012_22083(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName, System.Reflection.Metadata.EntityHandle
                tokenResolutionScope, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.GetTypeByNameOrThrow(ref fullName, tokenResolutionScope, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 22012, 22083);
                    return return_v;
                }


                TypeSymbol
                f_406_22191_22229(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.BadImageFormatException
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 22191, 22229);
                    return return_v;
                }


                int
                f_406_22342_22370(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 22342, 22370);
                    return 0;
                }


                TypeSymbol
                f_406_22600_22631(System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeReferenceHandle, TypeSymbol>
                this_param, System.Reflection.Metadata.TypeReferenceHandle
                key, TypeSymbol
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 22600, 22631);
                    return return_v;
                }


                bool
                f_406_22663_22721(TypeSymbol
                this_param, TypeSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 22663, 22721);
                    return return_v;
                }


                int
                f_406_22650_22722(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 22650, 22722);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 20850, 22779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 20850, 22779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        // MetaImport::GetTypeByName
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private TypeSymbol GetTypeByNameOrThrow(
                    ref MetadataTypeName fullName,
                    EntityHandle tokenResolutionScope,
                    out bool isNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 22931, 25432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 23128, 23177);

                HandleKind
                tokenType = tokenResolutionScope.Kind
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 23436, 23925) || true) && (tokenType == HandleKind.TypeReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 23436, 23925);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 23511, 23638) || true) && (tokenResolutionScope.IsNil)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 23511, 23638);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 23583, 23619);

                        throw f_406_23589_23618();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 23511, 23638);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 23656, 23720);

                    TypeSymbol
                    psymContainer = f_406_23683_23719(this, tokenResolutionScope)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 23738, 23787);

                    f_406_23738_23786(f_406_23751_23780(fullName.NamespaceName) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 23805, 23830);

                    isNoPiaLocalType = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 23848, 23910);

                    return f_406_23855_23909(this, psymContainer, ref fullName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 23436, 23925);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 23941, 24399) || true) && (tokenType == HandleKind.AssemblyReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 23941, 24399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24020, 24045);

                    isNoPiaLocalType = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24063, 24127);

                    var
                    assemblyRef = (AssemblyReferenceHandle)tokenResolutionScope
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24145, 24263) || true) && (assemblyRef.IsNil)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 24145, 24263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24208, 24244);

                        throw f_406_24214_24243();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 24145, 24263);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24281, 24384);

                    return f_406_24288_24383(this, f_406_24316_24368(Module, assemblyRef), ref fullName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 23941, 24399);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24415, 24897) || true) && (tokenType == HandleKind.ModuleReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 24415, 24897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24492, 24552);

                    var
                    moduleRef = (ModuleReferenceHandle)tokenResolutionScope
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24570, 24686) || true) && (moduleRef.IsNil)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 24570, 24686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24631, 24667);

                        throw f_406_24637_24666();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 24570, 24686);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24704, 24882);

                    return f_406_24711_24881(this, f_406_24761_24802(Module, moduleRef), ref fullName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 24415, 24897);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 24913, 25324) || true) && (tokenResolutionScope == EntityHandle.ModuleDefinition)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 24913, 25324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 25238, 25309);

                    return f_406_25245_25308(this, ref fullName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 24913, 25324);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 25340, 25365);

                isNoPiaLocalType = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 25379, 25421);

                return f_406_25386_25420(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 22931, 25432);

                System.BadImageFormatException
                f_406_23589_23618()
                {
                    var return_v = new System.BadImageFormatException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 23589, 23618);
                    return return_v;
                }


                TypeSymbol
                f_406_23683_23719(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 23683, 23719);
                    return return_v;
                }


                int
                f_406_23751_23780(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 23751, 23780);
                    return return_v;
                }


                int
                f_406_23738_23786(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 23738, 23786);
                    return 0;
                }


                TypeSymbol
                f_406_23855_23909(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                container, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupNestedTypeDefSymbol(container, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 23855, 23909);
                    return return_v;
                }


                System.BadImageFormatException
                f_406_24214_24243()
                {
                    var return_v = new System.BadImageFormatException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 24214, 24243);
                    return return_v;
                }


                int
                f_406_24316_24368(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.AssemblyReferenceHandle
                assemblyRef)
                {
                    var return_v = this_param.GetAssemblyReferenceIndexOrThrow(assemblyRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 24316, 24368);
                    return return_v;
                }


                TypeSymbol
                f_406_24288_24383(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, int
                referencedAssemblyIndex, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelTypeDefSymbol(referencedAssemblyIndex, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 24288, 24383);
                    return return_v;
                }


                System.BadImageFormatException
                f_406_24637_24666()
                {
                    var return_v = new System.BadImageFormatException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 24637, 24666);
                    return return_v;
                }


                string
                f_406_24761_24802(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ModuleReferenceHandle
                moduleRef)
                {
                    var return_v = this_param.GetModuleRefNameOrThrow(moduleRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 24761, 24802);
                    return return_v;
                }


                TypeSymbol
                f_406_24711_24881(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, string
                moduleName, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.LookupTopLevelTypeDefSymbol(moduleName, ref emittedName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 24711, 24881);
                    return return_v;
                }


                TypeSymbol
                f_406_25245_25308(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.LookupTopLevelTypeDefSymbol(ref emittedName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 25245, 25308);
                    return return_v;
                }


                TypeSymbol
                f_406_25386_25420(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 25386, 25420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 22931, 25432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 22931, 25432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        
        private TypeSymbol GetTypeOfTypeDef(TypeDefinitionHandle typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 25444, 25661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 25534, 25556);

                bool
                isNoPiaLocalType
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 25570, 25650);

                return f_406_25577_25649(this, typeDef, out isNoPiaLocalType, isContainingType: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 25444, 25661);

                TypeSymbol
                f_406_25577_25649(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef, out bool
                isNoPiaLocalType, bool
                isContainingType)
                {
                    var return_v = this_param.GetTypeOfTypeDef(typeDef, out isNoPiaLocalType, isContainingType: isContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 25577, 25649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 25444, 25661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 25444, 25661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol GetTypeOfTypeDef(TypeDefinitionHandle typeDef, out bool isNoPiaLocalType, bool isContainingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 25673, 31108);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 26343, 26431);

                    ConcurrentDictionary<TypeDefinitionHandle, TypeSymbol>
                    cache = f_406_26406_26430(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 26451, 26469);

                    TypeSymbol
                    result
                    = default(TypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 26489, 26946) || true) && (cache != null && (DynAbs.Tracing.TraceSender.Expression_True(406, 26493, 26548) && f_406_26510_26548(cache, typeDef, out result)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 26489, 26946);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 26590, 26889) || true) && (!f_406_26595_26633(Module, typeDef) && (DynAbs.Tracing.TraceSender.Expression_True(406, 26594, 26669) && f_406_26637_26669(Module, typeDef)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 26590, 26889);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 26719, 26743);

                            isNoPiaLocalType = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 26590, 26889);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 26590, 26889);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 26841, 26866);

                            isNoPiaLocalType = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 26590, 26889);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 26913, 26927);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 26489, 26946);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 26966, 26990);

                    MetadataTypeName
                    mdName
                    = default(MetadataTypeName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 27008, 27060);

                    string
                    name = f_406_27022_27059(Module, typeDef)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 27078, 27140);

                    f_406_27078_27139(f_406_27091_27138(name));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 27160, 28324) || true) && (f_406_27164_27202(Module, typeDef))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 27160, 28324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 27296, 27377);

                        TypeDefinitionHandle
                        containerTypeDef = f_406_27336_27376(Module, typeDef)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 27443, 27635) || true) && (containerTypeDef.IsNil)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 27443, 27635);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 27519, 27544);

                            isNoPiaLocalType = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 27570, 27612);

                            return f_406_27577_27611(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 27443, 27635);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 27659, 27763);

                        TypeSymbol
                        container = f_406_27682_27762(this, containerTypeDef, out isNoPiaLocalType, isContainingType: true)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 27787, 28158) || true) && (isNoPiaLocalType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 27787, 28158);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 27934, 28065) || true) && (!isContainingType)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 27934, 28065);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 28013, 28038);

                                isNoPiaLocalType = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 27934, 28065);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 28093, 28135);

                            return f_406_28100_28134(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 27787, 28158);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 28182, 28227);

                        mdName = MetadataTypeName.FromTypeName(name);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 28249, 28305);

                        return f_406_28256_28304(this, container, ref mdName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 27160, 28324);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 28344, 28410);

                    string
                    namespaceName = f_406_28367_28409(Module, typeDef)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 28430, 28609);

                    mdName = (DynAbs.Tracing.TraceSender.Conditional_F1(406, 28439, 28463) || ((f_406_28439_28459(namespaceName) > 0
                    && DynAbs.Tracing.TraceSender.Conditional_F2(406, 28487, 28549)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 28573, 28608))) ? MetadataTypeName.FromNamespaceAndTypeName(namespaceName, name) : MetadataTypeName.FromTypeName(name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 29329, 29350);

                    string
                    interfaceGuid
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 29368, 29381);

                    string
                    scope
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 29399, 29417);

                    string
                    identifier
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 29435, 30641) || true) && (f_406_29439_29602(Module, typeDef, out interfaceGuid, out scope, out identifier))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 29435, 30641);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 29644, 29668);

                        isNoPiaLocalType = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 29692, 30284) || true) && (!f_406_29697_29740(Module, typeDef))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 29692, 30284);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 29790, 29920);

                            MetadataTypeName
                            localTypeName = MetadataTypeName.FromNamespaceAndTypeName(mdName.NamespaceName, mdName.TypeName, forcedArity: 0)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 29946, 30158);

                            result = f_406_29955_30157(this, typeDef, ref localTypeName, interfaceGuid, scope, identifier);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30184, 30221);

                            f_406_30184_30220((object)result != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30247, 30261);

                            return result;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 29692, 30284);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30385, 30429);

                        result = f_406_30394_30428(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30453, 30584) || true) && (cache != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 30453, 30584);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30520, 30561);

                            result = f_406_30529_30560(cache, typeDef, result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 30453, 30584);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30608, 30622);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 29435, 30641);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30661, 30686);

                    isNoPiaLocalType = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30704, 30775);

                    result = f_406_30713_30774(this, ref mdName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30793, 30825);

                    f_406_30793_30824(!isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30843, 30857);

                    return result;
                }
                catch (BadImageFormatException mrEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 30886, 31097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30955, 30980);

                    isNoPiaLocalType = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 30998, 31044);

                    return f_406_31005_31043(this, mrEx);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 30886, 31097);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 25673, 31108);

                System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, TypeSymbol>
                f_406_26406_26430(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetTypeHandleToTypeMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 26406, 26430);
                    return return_v;
                }


                bool
                f_406_26510_26548(System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, TypeSymbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                key, out TypeSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 26510, 26548);
                    return return_v;
                }


                bool
                f_406_26595_26633(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.IsNestedTypeDefOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 26595, 26633);
                    return return_v;
                }


                bool
                f_406_26637_26669(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.IsNoPiaLocalType(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 26637, 26669);
                    return return_v;
                }


                string
                f_406_27022_27059(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetTypeDefNameOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 27022, 27059);
                    return return_v;
                }


                bool
                f_406_27091_27138(string
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 27091, 27138);
                    return return_v;
                }


                int
                f_406_27078_27139(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 27078, 27139);
                    return 0;
                }


                bool
                f_406_27164_27202(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.IsNestedTypeDefOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 27164, 27202);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandle
                f_406_27336_27376(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetContainingTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 27336, 27376);
                    return return_v;
                }


                TypeSymbol
                f_406_27577_27611(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 27577, 27611);
                    return return_v;
                }


                TypeSymbol
                f_406_27682_27762(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef, out bool
                isNoPiaLocalType, bool
                isContainingType)
                {
                    var return_v = this_param.GetTypeOfTypeDef(typeDef, out isNoPiaLocalType, isContainingType: isContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 27682, 27762);
                    return return_v;
                }


                TypeSymbol
                f_406_28100_28134(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 28100, 28134);
                    return return_v;
                }


                TypeSymbol
                f_406_28256_28304(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                container, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupNestedTypeDefSymbol(container, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 28256, 28304);
                    return return_v;
                }


                string
                f_406_28367_28409(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetTypeDefNamespaceOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 28367, 28409);
                    return return_v;
                }


                int
                f_406_28439_28459(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 28439, 28459);
                    return return_v;
                }


                bool
                f_406_29439_29602(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef, out string
                interfaceGuid, out string
                scope, out string
                identifier)
                {
                    var return_v = this_param.IsNoPiaLocalType(typeDef, out interfaceGuid, out scope, out identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 29439, 29602);
                    return return_v;
                }


                bool
                f_406_29697_29740(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.HasGenericParametersOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 29697, 29740);
                    return return_v;
                }


                TypeSymbol
                f_406_29955_30157(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef, ref Microsoft.CodeAnalysis.MetadataTypeName
                name, string
                interfaceGuid, string
                scope, string
                identifier)
                {
                    var return_v = this_param.SubstituteNoPiaLocalType(typeDef, ref name, interfaceGuid, scope, identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 29955, 30157);
                    return return_v;
                }


                int
                f_406_30184_30220(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 30184, 30220);
                    return 0;
                }


                TypeSymbol
                f_406_30394_30428(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 30394, 30428);
                    return return_v;
                }


                TypeSymbol
                f_406_30529_30560(System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, TypeSymbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                key, TypeSymbol
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 30529, 30560);
                    return return_v;
                }


                TypeSymbol
                f_406_30713_30774(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.LookupTopLevelTypeDefSymbol(ref emittedName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 30713, 30774);
                    return return_v;
                }


                int
                f_406_30793_30824(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 30793, 30824);
                    return 0;
                }


                TypeSymbol
                f_406_31005_31043(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.BadImageFormatException
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 31005, 31043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 25673, 31108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 25673, 31108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded type is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private ImmutableArray<ModifierInfo<TypeSymbol>> DecodeModifiersOrThrow(
                    ref BlobReader signatureReader,
                    out SignatureTypeCode typeCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 31325, 32591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 31512, 31568);

                ArrayBuilder<ModifierInfo<TypeSymbol>>
                modifiers = null
                ;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 31584, 32514) || true) && (true)
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(406, 31584, 32514))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 31584, 32514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 31627, 31678);

                        typeCode = signatureReader.ReadSignatureTypeCode();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 31696, 31712);

                        bool
                        isOptional
                        = default(bool);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 31732, 32102) || true) && (typeCode == SignatureTypeCode.RequiredModifier)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 31732, 32102);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 31824, 31843);

                            isOptional = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 31732, 32102);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 31732, 32102);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 31885, 32102) || true) && (typeCode == SignatureTypeCode.OptionalModifier)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 31885, 32102);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 31977, 31995);

                                isOptional = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 31885, 32102);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 31885, 32102);
                                DynAbs.Tracing.TraceSender.TraceBreak(406, 32077, 32083);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 31885, 32102);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 31732, 32102);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 32122, 32187);

                        TypeSymbol
                        type = f_406_32140_32186(this, ref signatureReader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 32205, 32288);

                        ModifierInfo<TypeSymbol>
                        modifier = f_406_32241_32287(isOptional, type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 32308, 32455) || true) && (modifiers == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 32308, 32455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 32371, 32436);

                            modifiers = f_406_32383_32435();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 32308, 32455);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 32475, 32499);

                        f_406_32475_32498(
                                        modifiers, modifier);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 32530, 32580);

                return f_406_32537_32568_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(modifiers, 406, 32537, 32568)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>?>(406, 32537, 32579) ?? default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 31325, 32591);

                TypeSymbol
                f_406_32140_32186(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader)
                {
                    var return_v = this_param.DecodeModifierTypeOrThrow(ref signatureReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 32140, 32186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>
                f_406_32241_32287(bool
                isOptional, TypeSymbol
                modifier)
                {
                    var return_v = new Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>(isOptional, modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 32241, 32287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_32383_32435()
                {
                    var return_v = ArrayBuilder<ModifierInfo<TypeSymbol>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 32383, 32435);
                    return return_v;
                }


                int
                f_406_32475_32498(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                this_param, Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 32475, 32498);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>?
                f_406_32537_32568_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 32537, 32568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 31325, 32591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 31325, 32591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol DecodeModifierTypeOrThrow(ref BlobReader signatureReader)
        {
            EntityHandle token = signatureReader.ReadTypeHandle();
            TypeSymbol type;
            bool isNoPiaLocalType;

// According to ECMA spec:
//  The CMOD_OPT or CMOD_REQD is followed by a metadata token that
//  indexes a row in the TypeDef table or the TypeRef table.
tryAgain:
            switch (token.Kind)
            {
                case HandleKind.TypeDefinition:
                    type = GetTypeOfTypeDef((TypeDefinitionHandle)token, out isNoPiaLocalType, isContainingType: false);
                    // it is valid for a modifier to refer to an unconstructed type, we need to preserve this fact
                    type = SubstituteWithUnboundIfGeneric(type);
                    break;

                case HandleKind.TypeReference:
                    type = GetTypeOfTypeRef((TypeReferenceHandle)token, out isNoPiaLocalType);
                    // it is valid for a modifier to refer to an unconstructed type, we need to preserve this fact
                    type = SubstituteWithUnboundIfGeneric(type);
                    break;

                case HandleKind.TypeSpecification:
                    // Section 23.2.7 of the CLI spec specifically says that this is not allowed (see comment on method),
                    // but, apparently, ilasm turns modopt(int32) into a TypeSpec.
                    // In addition, managed C++ compiler can use constructed generic types as modifiers, for example Nullable<bool>, etc.
                    // We will support only cases like these even though it looks like CLR allows any types that can be encoded through a TypeSpec.

                    BlobReader memoryReader = this.Module.GetTypeSpecificationSignatureReaderOrThrow((TypeSpecificationHandle)token);

                    SignatureTypeCode typeCode = memoryReader.ReadSignatureTypeCode();
                    bool refersToNoPiaLocalType;

                    switch (typeCode)
                    {
                        case SignatureTypeCode.Void:
                        case SignatureTypeCode.Boolean:
                        case SignatureTypeCode.SByte:
                        case SignatureTypeCode.Byte:
                        case SignatureTypeCode.Int16:
                        case SignatureTypeCode.UInt16:
                        case SignatureTypeCode.Int32:
                        case SignatureTypeCode.UInt32:
                        case SignatureTypeCode.Int64:
                        case SignatureTypeCode.UInt64:
                        case SignatureTypeCode.Single:
                        case SignatureTypeCode.Double:
                        case SignatureTypeCode.Char:
                        case SignatureTypeCode.String:
                        case SignatureTypeCode.IntPtr:
                        case SignatureTypeCode.UIntPtr:
                        case SignatureTypeCode.Object:
                        case SignatureTypeCode.TypedReference:
                            type = GetSpecialType(typeCode.ToSpecialType());
                            break;

                        case SignatureTypeCode.TypeHandle:

                            token = memoryReader.ReadTypeHandle();
                            goto tryAgain;

                        case SignatureTypeCode.GenericTypeInstance:
                            type = DecodeGenericTypeInstanceOrThrow(ref memoryReader, out refersToNoPiaLocalType);
                            break;

                        default:
                            throw new UnsupportedSignatureContent();
                    }
                    break;

                default:
                    throw new UnsupportedSignatureContent();
            }

            return type;
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded local variable type is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        internal ImmutableArray<LocalInfo<TypeSymbol>> DecodeLocalSignatureOrThrow(ref BlobReader signatureReader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 36724, 38813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 36855, 36927);

                SignatureHeader
                signatureHeader = signatureReader.ReadSignatureHeader()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 36943, 37088) || true) && (signatureHeader.Kind != SignatureKind.LocalVariables)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 36943, 37088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37033, 37073);

                    throw f_406_37039_37072();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 36943, 37088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37104, 37119);

                int
                localCount
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37133, 37156);

                int
                typeParameterCount
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37170, 37274);

                f_406_37170_37273(ref signatureReader, signatureHeader, out localCount, out typeParameterCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37288, 37326);

                f_406_37288_37325(typeParameterCount == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37342, 37415);

                var
                locals = f_406_37355_37414(localCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37429, 37485);

                var
                offsets = f_406_37443_37484(localCount)
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37544, 37549);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37535, 37749) || true) && (i < localCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37567, 37570)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 37535, 37749))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 37535, 37749);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37612, 37648);

                            f_406_37612_37647(offsets, signatureReader.Offset);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37670, 37730);

                            f_406_37670_37729(locals, f_406_37681_37728(this, ref signatureReader));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 215);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 215);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37769, 37908) || true) && (signatureReader.RemainingBytes > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 37769, 37908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37849, 37889);

                        throw f_406_37855_37888();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 37769, 37908);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 37984, 38008);

                    signatureReader.Reset();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38035, 38040);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38026, 38623) || true) && (i < localCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38058, 38061)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 38026, 38623))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 38026, 38623);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38103, 38126);

                            int
                            start = f_406_38115_38125(offsets, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38148, 38194);

                            f_406_38148_38193(signatureReader.Offset <= start);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38216, 38353) || true) && (signatureReader.Offset < start)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 38216, 38353);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38303, 38330);

                                    signatureReader.ReadByte();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 38216, 38353);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 38216, 38353);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(406, 38216, 38353);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38377, 38466);

                            int
                            n = (DynAbs.Tracing.TraceSender.Conditional_F1(406, 38385, 38405) || (((i < localCount - 1) && DynAbs.Tracing.TraceSender.Conditional_F2(406, 38408, 38432)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 38435, 38465))) ? (f_406_38409_38423(offsets, i + 1) - start) : signatureReader.RemainingBytes
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38488, 38533);

                            var
                            signature = signatureReader.ReadBytes(n)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38557, 38604);

                            locals[i] = locals[i].WithSignature(signature);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 598);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 598);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38643, 38671);

                    return f_406_38650_38670(locals);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(406, 38700, 38802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38740, 38755);

                    f_406_38740_38754(offsets);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38773, 38787);

                    f_406_38773_38786(locals);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(406, 38700, 38802);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 36724, 38813);

                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_37039_37072()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 37039, 37072);
                    return return_v;
                }


                int
                f_406_37170_37273(ref System.Reflection.Metadata.BlobReader
                signatureReader, System.Reflection.Metadata.SignatureHeader
                signatureHeader, out int
                parameterCount, out int
                typeParameterCount)
                {
                    GetSignatureCountsOrThrow(ref signatureReader, signatureHeader, out parameterCount, out typeParameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 37170, 37273);
                    return 0;
                }


                int
                f_406_37288_37325(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 37288, 37325);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>>
                f_406_37355_37414(int
                capacity)
                {
                    var return_v = ArrayBuilder<LocalInfo<TypeSymbol>>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 37355, 37414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_406_37443_37484(int
                capacity)
                {
                    var return_v = ArrayBuilder<int>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 37443, 37484);
                    return return_v;
                }


                int
                f_406_37612_37647(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 37612, 37647);
                    return 0;
                }


                Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>
                f_406_37681_37728(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader)
                {
                    var return_v = this_param.DecodeLocalVariableOrThrow(ref signatureReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 37681, 37728);
                    return return_v;
                }


                int
                f_406_37670_37729(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>>
                this_param, Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 37670, 37729);
                    return 0;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_37855_37888()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 37855, 37888);
                    return return_v;
                }


                int
                f_406_38115_38125(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 38115, 38125);
                    return return_v;
                }


                int
                f_406_38148_38193(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 38148, 38193);
                    return 0;
                }


                int
                f_406_38409_38423(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 38409, 38423);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>>
                f_406_38650_38670(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 38650, 38670);
                    return return_v;
                }


                int
                f_406_38740_38754(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 38740, 38754);
                    return 0;
                }


                int
                f_406_38773_38786(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 38773, 38786);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 36724, 38813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 36724, 38813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeSymbol DecodeGenericParameterConstraint(EntityHandle token, out ImmutableArray<ModifierInfo<TypeSymbol>> modifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 38825, 40389);
                System.Reflection.Metadata.SignatureTypeCode typeCode = default(System.Reflection.Metadata.SignatureTypeCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 38978, 39037);

                modifiers = ImmutableArray<ModifierInfo<TypeSymbol>>.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 39053, 40378);

                switch (token.Kind)
                {

                    case HandleKind.TypeSpecification:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 39053, 40378);
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 39248, 39354);

                                var
                                memoryReader = f_406_39267_39353(this.Module, token)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 39384, 39455);

                                modifiers = f_406_39396_39454(this, ref memoryReader, out typeCode);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 39485, 39549);

                                var
                                type = f_406_39496_39548(this, ref memoryReader, typeCode, out _)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 39579, 39591);

                                return type;
                            }
                            catch (BadImageFormatException mrEx)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 39644, 39810);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 39737, 39783);

                                return f_406_39744_39782(this, mrEx);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(406, 39644, 39810);
                            }
                            catch (UnsupportedSignatureContent)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 39836, 39997);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 39928, 39970);

                                return f_406_39935_39969(this);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(406, 39836, 39997);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 39053, 40378);

                    case HandleKind.TypeReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 39053, 40378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 40090, 40149);

                        return f_406_40097_40148(this, token, out _);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 39053, 40378);

                    case HandleKind.TypeDefinition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 39053, 40378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 40220, 40273);

                        return f_406_40227_40272(this, token);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 39053, 40378);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 39053, 40378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 40321, 40363);

                        return f_406_40328_40362(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 39053, 40378);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 38825, 40389);

                System.Reflection.Metadata.BlobReader
                f_406_39267_39353(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                typeSpec)
                {
                    var return_v = this_param.GetTypeSpecificationSignatureReaderOrThrow((System.Reflection.Metadata.TypeSpecificationHandle)typeSpec);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 39267, 39353);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_39396_39454(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = this_param.DecodeModifiersOrThrow(ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 39396, 39454);
                    return return_v;
                }


                TypeSymbol
                f_406_39496_39548(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, System.Reflection.Metadata.SignatureTypeCode
                typeCode, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, typeCode, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 39496, 39548);
                    return return_v;
                }


                TypeSymbol
                f_406_39744_39782(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.BadImageFormatException
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 39744, 39782);
                    return return_v;
                }


                TypeSymbol
                f_406_39935_39969(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 39935, 39969);
                    return return_v;
                }


                TypeSymbol
                f_406_40097_40148(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                typeRef, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.GetTypeOfTypeRef((System.Reflection.Metadata.TypeReferenceHandle)typeRef, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 40097, 40148);
                    return return_v;
                }


                TypeSymbol
                f_406_40227_40272(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                typeDef)
                {
                    var return_v = this_param.GetTypeOfTypeDef((System.Reflection.Metadata.TypeDefinitionHandle)typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 40227, 40272);
                    return return_v;
                }


                TypeSymbol
                f_406_40328_40362(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 40328, 40362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 38825, 40389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 38825, 40389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded local variable type is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        internal LocalInfo<TypeSymbol> DecodeLocalVariableOrThrow(ref BlobReader signatureReader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 40621, 42345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 40735, 40762);

                SignatureTypeCode
                typeCode
                = default(SignatureTypeCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 40778, 40858);

                var
                customModifiers = f_406_40800_40857(this, ref signatureReader, out typeCode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 40874, 40996) || true) && (customModifiers.AnyRequired())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 40874, 40996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 40941, 40981);

                    throw f_406_40947_40980();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 40874, 40996);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41012, 41056);

                var
                constraints = LocalSlotConstraints.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41070, 41092);

                TypeSymbol
                typeSymbol
                = default(TypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41108, 41309) || true) && (typeCode == SignatureTypeCode.Pinned)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 41108, 41309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41182, 41225);

                    constraints |= LocalSlotConstraints.Pinned;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41243, 41294);

                    typeCode = signatureReader.ReadSignatureTypeCode();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 41108, 41309);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41325, 41530) || true) && (typeCode == SignatureTypeCode.ByReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 41325, 41530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41404, 41446);

                    constraints |= LocalSlotConstraints.ByRef;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41464, 41515);

                    typeCode = signatureReader.ReadSignatureTypeCode();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 41325, 41530);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41604, 42223) || true) && (typeCode == SignatureTypeCode.TypedReference && (DynAbs.Tracing.TraceSender.Expression_True(406, 41608, 41696) && constraints != LocalSlotConstraints.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 41604, 42223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41730, 41778);

                    typeSymbol = f_406_41743_41777(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 41604, 42223);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 41604, 42223);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41888, 41916);

                        bool
                        refersToNoPiaLocalType
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 41938, 42028);

                        typeSymbol = f_406_41951_42027(this, ref signatureReader, typeCode, out refersToNoPiaLocalType);
                    }
                    catch (UnsupportedSignatureContent)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 42065, 42208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 42141, 42189);

                        typeSymbol = f_406_42154_42188(this);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(406, 42065, 42208);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 41604, 42223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 42239, 42334);

                return f_406_42246_42333(typeSymbol, customModifiers, constraints, signatureOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 40621, 42345);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_40800_40857(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = this_param.DecodeModifiersOrThrow(ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 40800, 40857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_40947_40980()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 40947, 40980);
                    return return_v;
                }


                TypeSymbol
                f_406_41743_41777(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 41743, 41777);
                    return return_v;
                }


                TypeSymbol
                f_406_41951_42027(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, System.Reflection.Metadata.SignatureTypeCode
                typeCode, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, typeCode, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 41951, 42027);
                    return return_v;
                }


                TypeSymbol
                f_406_42154_42188(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 42154, 42188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>
                f_406_42246_42333(TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints, byte[]
                signatureOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>(type, customModifiers, constraints, signatureOpt: signatureOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 42246, 42333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 40621, 42345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 40621, 42345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

       
        internal void DecodeLocalConstantBlobOrThrow(ref BlobReader sigReader, out TypeSymbol type, out ConstantValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 42357, 45881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 42498, 42525);

                SignatureTypeCode
                typeCode
                = default(SignatureTypeCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 42541, 42615);

                var
                customModifiers = f_406_42563_42614(this, ref sigReader, out typeCode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 42631, 42753) || true) && (customModifiers.AnyRequired())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 42631, 42753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 42698, 42738);

                    throw f_406_42704_42737();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 42631, 42753);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 42769, 45870) || true) && (typeCode == SignatureTypeCode.TypeHandle)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 42769, 45870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 43646, 43674);

                    bool
                    refersToNoPiaLocalType
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 43692, 43830);

                    type = f_406_43699_43829(this, sigReader.ReadTypeHandle(), out refersToNoPiaLocalType, allowTypeSpec: true, requireShortForm: true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 43850, 44823) || true) && (f_406_43854_43870(type) == SpecialType.System_Decimal)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 43850, 44823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 43942, 43996);

                        value = f_406_43950_43995(sigReader.ReadDecimal());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 43850, 44823);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 43850, 44823);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 44038, 44823) || true) && (f_406_44042_44058(type) == SpecialType.System_DateTime)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 44038, 44823);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 44131, 44186);

                            value = f_406_44139_44185(sigReader.ReadDateTime());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 44038, 44823);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 44038, 44823);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 44228, 44823) || true) && (sigReader.RemainingBytes == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 44228, 44823);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 44542, 44696);

                                value = (DynAbs.Tracing.TraceSender.Conditional_F1(406, 44550, 44654) || (((f_406_44551_44571(type) || (DynAbs.Tracing.TraceSender.Expression_False(406, 44551, 44608) || f_406_44575_44588(type) == TypeKind.Pointer) || (DynAbs.Tracing.TraceSender.Expression_False(406, 44551, 44653) || f_406_44612_44625(type) == TypeKind.FunctionPointer)) && DynAbs.Tracing.TraceSender.Conditional_F2(406, 44657, 44675)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 44678, 44695))) ? f_406_44657_44675() : f_406_44678_44695();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 44228, 44823);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 44228, 44823);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 44778, 44804);

                                value = f_406_44786_44803();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 44228, 44823);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 44038, 44823);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 43850, 44823);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 42769, 45870);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 42769, 45870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 44889, 44909);

                    bool
                    isEnumTypeCode
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 44927, 45009);

                    value = f_406_44935_45008(ref sigReader, typeCode, out isEnumTypeCode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 45027, 45070);

                    var
                    specialType = f_406_45045_45069(typeCode)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 45090, 45702) || true) && (isEnumTypeCode && (DynAbs.Tracing.TraceSender.Expression_True(406, 45094, 45140) && sigReader.RemainingBytes > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 45090, 45702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 45182, 45210);

                        bool
                        refersToNoPiaLocalType
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 45232, 45370);

                        type = f_406_45239_45369(this, sigReader.ReadTypeHandle(), out refersToNoPiaLocalType, allowTypeSpec: true, requireShortForm: true);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 45394, 45566) || true) && (f_406_45398_45438_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_406_45398_45425(this, type), 406, 45398, 45438)?.SpecialType) != specialType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 45394, 45566);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 45503, 45543);

                            throw f_406_45509_45542();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 45394, 45566);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 45090, 45702);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 45090, 45702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 45648, 45683);

                        type = f_406_45655_45682(this, specialType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 45090, 45702);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 45722, 45855) || true) && (sigReader.RemainingBytes > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 45722, 45855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 45796, 45836);

                        throw f_406_45802_45835();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 45722, 45855);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 42769, 45870);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 42357, 45881);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_42563_42614(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = this_param.DecodeModifiersOrThrow(ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 42563, 42614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_42704_42737()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 42704, 42737);
                    return return_v;
                }


                TypeSymbol
                f_406_43699_43829(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                handle, out bool
                isNoPiaLocalType, bool
                allowTypeSpec, bool
                requireShortForm)
                {
                    var return_v = this_param.GetSymbolForTypeHandleOrThrow(handle, out isNoPiaLocalType, allowTypeSpec: allowTypeSpec, requireShortForm: requireShortForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 43699, 43829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_406_43854_43870(TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 43854, 43870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_43950_43995(decimal
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 43950, 43995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_406_44042_44058(TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 44042, 44058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_44139_44185(System.DateTime
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 44139, 44185);
                    return return_v;
                }


                bool
                f_406_44551_44571(TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 44551, 44571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_406_44575_44588(TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 44575, 44588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_406_44612_44625(TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 44612, 44625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_44657_44675()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 44657, 44675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_44678_44695()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 44678, 44695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_44786_44803()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 44786, 44803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_44935_45008(ref System.Reflection.Metadata.BlobReader
                sigReader, System.Reflection.Metadata.SignatureTypeCode
                typeCode, out bool
                isEnumTypeCode)
                {
                    var return_v = DecodePrimitiveConstantValue(ref sigReader, typeCode, out isEnumTypeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 44935, 45008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_406_45045_45069(System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = typeCode.ToSpecialType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 45045, 45069);
                    return return_v;
                }


                TypeSymbol
                f_406_45239_45369(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                handle, out bool
                isNoPiaLocalType, bool
                allowTypeSpec, bool
                requireShortForm)
                {
                    var return_v = this_param.GetSymbolForTypeHandleOrThrow(handle, out isNoPiaLocalType, allowTypeSpec: allowTypeSpec, requireShortForm: requireShortForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 45239, 45369);
                    return return_v;
                }


                TypeSymbol?
                f_406_45398_45425(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                type)
                {
                    var return_v = this_param?.GetEnumUnderlyingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 45398, 45425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType?
                f_406_45398_45438_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 45398, 45438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_45509_45542()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 45509, 45542);
                    return return_v;
                }


                TypeSymbol
                f_406_45655_45682(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 45655, 45682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_45802_45835()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 45802, 45835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 42357, 45881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 42357, 45881);
            }
        }

        private static ConstantValue DecodePrimitiveConstantValue(ref BlobReader sigReader, SignatureTypeCode typeCode, out bool isEnumTypeCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(406, 45893, 49065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46054, 49054);

                switch (typeCode)
                {

                    case SignatureTypeCode.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46157, 46179);

                        isEnumTypeCode = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46201, 46254);

                        return f_406_46208_46253(sigReader.ReadBoolean());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46324, 46346);

                        isEnumTypeCode = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46368, 46418);

                        return f_406_46375_46417(sigReader.ReadChar());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46489, 46511);

                        isEnumTypeCode = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46533, 46584);

                        return f_406_46540_46583(sigReader.ReadSByte());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46654, 46676);

                        isEnumTypeCode = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46698, 46748);

                        return f_406_46705_46747(sigReader.ReadByte());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46819, 46841);

                        isEnumTypeCode = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46863, 46914);

                        return f_406_46870_46913(sigReader.ReadInt16());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 46986, 47008);

                        isEnumTypeCode = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47030, 47082);

                        return f_406_47037_47081(sigReader.ReadUInt16());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47153, 47175);

                        isEnumTypeCode = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47197, 47248);

                        return f_406_47204_47247(sigReader.ReadInt32());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47320, 47342);

                        isEnumTypeCode = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47364, 47416);

                        return f_406_47371_47415(sigReader.ReadUInt32());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47487, 47509);

                        isEnumTypeCode = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47531, 47582);

                        return f_406_47538_47581(sigReader.ReadInt64());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47654, 47676);

                        isEnumTypeCode = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47698, 47750);

                        return f_406_47705_47749(sigReader.ReadUInt64());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47822, 47845);

                        isEnumTypeCode = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47867, 47919);

                        return f_406_47874_47918(sigReader.ReadSingle());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 47991, 48014);

                        isEnumTypeCode = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48036, 48088);

                        return f_406_48043_48087(sigReader.ReadDouble());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48160, 48183);

                        isEnumTypeCode = false;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48207, 48509) || true) && (sigReader.RemainingBytes == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 48207, 48509);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48290, 48432) || true) && (sigReader.ReadByte() != 0xff)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 48290, 48432);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48380, 48405);

                                return f_406_48387_48404();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 48290, 48432);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48460, 48486);

                            return f_406_48467_48485();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 48207, 48509);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48533, 48668) || true) && (sigReader.RemainingBytes % 2 != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 48533, 48668);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48620, 48645);

                            return f_406_48627_48644();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 48533, 48668);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48692, 48767);

                        return f_406_48699_48766(sigReader.ReadUTF16(sigReader.RemainingBytes));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    case SignatureTypeCode.Object:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48878, 48901);

                        isEnumTypeCode = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48923, 48949);

                        return f_406_48930_48948();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 46054, 49054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 48999, 49039);

                        throw f_406_49005_49038();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 46054, 49054);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(406, 45893, 49065);

                Microsoft.CodeAnalysis.ConstantValue
                f_406_46208_46253(bool
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 46208, 46253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_46375_46417(char
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 46375, 46417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_46540_46583(sbyte
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 46540, 46583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_46705_46747(byte
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 46705, 46747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_46870_46913(short
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 46870, 46913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_47037_47081(ushort
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 47037, 47081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_47204_47247(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 47204, 47247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_47371_47415(uint
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 47371, 47415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_47538_47581(long
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 47538, 47581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_47705_47749(ulong
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 47705, 47749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_47874_47918(float
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 47874, 47918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_48043_48087(double
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 48043, 48087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_48387_48404()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 48387, 48404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_48467_48485()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 48467, 48485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_48627_48644()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 48627, 48644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_48699_48766(string
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 48699, 48766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_406_48930_48948()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 48930, 48948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_49005_49038()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 49005, 49038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 45893, 49065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 45893, 49065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<LocalInfo<TypeSymbol>> GetLocalsOrThrow(StandaloneSignatureHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 49077, 49454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 49199, 49284);

                var
                signatureHandle = f_406_49221_49273(f_406_49221_49242(Module), handle).Signature
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 49298, 49373);

                var
                signatureReader = f_406_49320_49372(f_406_49320_49341(Module), signatureHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 49387, 49443);

                return f_406_49394_49442(this, ref signatureReader);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 49077, 49454);

                System.Reflection.Metadata.MetadataReader
                f_406_49221_49242(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 49221, 49242);
                    return return_v;
                }


                System.Reflection.Metadata.StandaloneSignature
                f_406_49221_49273(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StandaloneSignatureHandle
                handle)
                {
                    var return_v = this_param.GetStandaloneSignature(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 49221, 49273);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_406_49320_49341(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 49320, 49341);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_406_49320_49372(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 49320, 49372);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>>
                f_406_49394_49442(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader)
                {
                    var return_v = this_param.DecodeLocalSignatureOrThrow(ref signatureReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 49394, 49442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 49077, 49454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 49077, 49454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Used to decode signatures of local constants returned by SymReader.
        /// </summary>
        internal unsafe TypeSymbol DecodeLocalVariableTypeOrThrow(ImmutableArray<byte> signature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 49594, 50258);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 49708, 49827) || true) && (signature.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 49708, 49827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 49772, 49812);

                    throw f_406_49778_49811();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 49708, 49827);
                }

                fixed (byte*
    ptr = signature.AsSpan()
    )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 49914, 49969);

                    var
                    blobReader = f_406_49931_49968(ptr, signature.Length)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 49987, 50041);

                    var
                    info = f_406_49998_50040(this, ref blobReader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 50061, 50195) || true) && (info.IsByRef || (DynAbs.Tracing.TraceSender.Expression_False(406, 50065, 50094) || info.IsPinned))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 50061, 50195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 50136, 50176);

                        throw f_406_50142_50175();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 50061, 50195);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 50215, 50232);

                    return info.Type;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 49594, 50258);

                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_49778_49811()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 49778, 49811);
                    return return_v;
                }


                unsafe System.Reflection.Metadata.BlobReader
                f_406_49931_49968(byte*
                buffer, int
                length)
                {
                    var return_v = new System.Reflection.Metadata.BlobReader(buffer, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 49931, 49968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>
                f_406_49998_50040(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader)
                {
                    var return_v = this_param.DecodeLocalVariableOrThrow(ref signatureReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 49998, 50040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_50142_50175()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 50142, 50175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 49594, 50258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 49594, 50258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Returns the local info for all locals indexed by slot.
        /// </summary>
        internal ImmutableArray<LocalInfo<TypeSymbol>> GetLocalInfo(StandaloneSignatureHandle localSignatureHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 50385, 50929);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 50517, 50647) || true) && (localSignatureHandle.IsNil)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 50517, 50647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 50581, 50632);

                    return ImmutableArray<LocalInfo<TypeSymbol>>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 50517, 50647);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 50663, 50698);

                var
                reader = f_406_50676_50697(Module)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 50712, 50790);

                var
                signature = f_406_50728_50779(reader, localSignatureHandle).Signature
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 50804, 50853);

                var
                blobReader = f_406_50821_50852(reader, signature)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 50867, 50918);

                return f_406_50874_50917(this, ref blobReader);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 50385, 50929);

                System.Reflection.Metadata.MetadataReader
                f_406_50676_50697(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 50676, 50697);
                    return return_v;
                }


                System.Reflection.Metadata.StandaloneSignature
                f_406_50728_50779(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StandaloneSignatureHandle
                handle)
                {
                    var return_v = this_param.GetStandaloneSignature(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 50728, 50779);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_406_50821_50852(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobReader(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 50821, 50852);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.LocalInfo<TypeSymbol>>
                f_406_50874_50917(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader)
                {
                    var return_v = this_param.DecodeLocalSignatureOrThrow(ref signatureReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 50874, 50917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 50385, 50929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 50385, 50929);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded parameter type is invalid.</exception>
        private void DecodeParameterOrThrow(ref BlobReader signatureReader, /*out*/ ref ParamInfo<TypeSymbol> info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 51054, 51711);
                System.Reflection.Metadata.SignatureTypeCode typeCode = default(System.Reflection.Metadata.SignatureTypeCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 51186, 51320);

                info.CustomModifiers = f_406_51209_51319(this, ref signatureReader, out typeCode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 51336, 51616) || true) && (typeCode == SignatureTypeCode.ByReference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 51336, 51616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 51415, 51435);

                    info.IsByRef = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 51455, 51502);

                    info.RefCustomModifiers = info.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 51520, 51601);

                    info.CustomModifiers = f_406_51543_51600(this, ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 51336, 51616);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 51632, 51700);

                info.Type = f_406_51644_51699(this, ref signatureReader, typeCode, out _);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 51054, 51711);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_51209_51319(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = this_param.DecodeModifiersOrThrow(ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 51209, 51319);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_51543_51600(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = this_param.DecodeModifiersOrThrow(ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 51543, 51600);
                    return return_v;
                }


                TypeSymbol
                f_406_51644_51699(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, System.Reflection.Metadata.SignatureTypeCode
                typeCode, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, typeCode, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 51644, 51699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 51054, 51711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 51054, 51711);
            }
        }

        // MetaImport::DecodeMethodSignature
        internal ParamInfo<TypeSymbol>[] GetSignatureForMethod(MethodDefinitionHandle methodDef, out SignatureHeader signatureHeader, out BadImageFormatException metadataException, bool setParamHandles = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 51769, 53917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 51995, 52036);

                ParamInfo<TypeSymbol>[]
                paramInfo = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 52050, 52093);

                signatureHeader = default(SignatureHeader);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 52145, 52212);

                    BlobHandle
                    signature = f_406_52168_52211(Module, methodDef)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 52230, 52320);

                    BlobReader
                    signatureReader = f_406_52259_52319(this, signature, out signatureHeader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 52340, 52363);

                    int
                    typeParameterCount
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 52411, 52518);

                    paramInfo = f_406_52423_52517(this, ref signatureReader, signatureHeader, out typeParameterCount);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 52538, 53305) || true) && (setParamHandles)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 52538, 53305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 52599, 52638);

                        int
                        paramInfoLength = f_406_52621_52637(paramInfo)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 52750, 53286);
                            foreach (var param in f_406_52772_52818_I(f_406_52772_52818(Module, methodDef)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 52750, 53286);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 52868, 52937);

                                int
                                sequenceNumber = f_406_52889_52936(Module, param)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 53036, 53263) || true) && (sequenceNumber >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(406, 53040, 53095) && sequenceNumber < paramInfoLength) && (DynAbs.Tracing.TraceSender.Expression_True(406, 53040, 53137) && paramInfo[sequenceNumber].Handle.IsNil))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 53036, 53263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 53195, 53236);

                                    paramInfo[sequenceNumber].Handle = param;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 53036, 53263);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 52750, 53286);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 537);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 537);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 52538, 53305);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 53325, 53350);

                    metadataException = null;
                }
                catch (BadImageFormatException mrEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 53379, 53873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 53448, 53473);

                    metadataException = mrEx;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 53548, 53858) || true) && (paramInfo == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 53548, 53858);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 53717, 53758);

                        paramInfo = new ParamInfo<TypeSymbol>[1];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 53780, 53839);

                        paramInfo[0].Type = f_406_53800_53838(this, mrEx);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 53548, 53858);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 53379, 53873);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 53889, 53906);

                return paramInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 51769, 53917);

                System.Reflection.Metadata.BlobHandle
                f_406_52168_52211(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetMethodSignatureOrThrow(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 52168, 52211);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_406_52259_52319(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.BlobHandle
                signature, out System.Reflection.Metadata.SignatureHeader
                signatureHeader)
                {
                    var return_v = this_param.DecodeSignatureHeaderOrThrow(signature, out signatureHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 52259, 52319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>[]
                f_406_52423_52517(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, System.Reflection.Metadata.SignatureHeader
                signatureHeader, out int
                typeParameterCount)
                {
                    var return_v = this_param.DecodeSignatureParametersOrThrow(ref signatureReader, signatureHeader, out typeParameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 52423, 52517);
                    return return_v;
                }


                int
                f_406_52621_52637(Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 52621, 52637);
                    return return_v;
                }


                System.Reflection.Metadata.ParameterHandleCollection
                f_406_52772_52818(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetParametersOfMethodOrThrow(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 52772, 52818);
                    return return_v;
                }


                int
                f_406_52889_52936(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                param)
                {
                    var return_v = this_param.GetParameterSequenceNumberOrThrow(param);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 52889, 52936);
                    return return_v;
                }


                System.Reflection.Metadata.ParameterHandleCollection
                f_406_52772_52818_I(System.Reflection.Metadata.ParameterHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 52772, 52818);
                    return return_v;
                }


                TypeSymbol
                f_406_53800_53838(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.BadImageFormatException
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 53800, 53838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 51769, 53917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 51769, 53917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void GetSignatureCountsOrThrow(PEModule module, MethodDefinitionHandle methodDef, out int parameterCount, out int typeParameterCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(406, 54031, 54565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 54205, 54272);

                BlobHandle
                signature = f_406_54228_54271(module, methodDef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 54286, 54318);

                SignatureHeader
                signatureHeader
                = default(SignatureHeader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 54332, 54430);

                BlobReader
                signatureReader = f_406_54361_54429(module, signature, out signatureHeader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 54446, 54554);

                f_406_54446_54553(ref signatureReader, signatureHeader, out parameterCount, out typeParameterCount);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(406, 54031, 54565);

                System.Reflection.Metadata.BlobHandle
                f_406_54228_54271(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.GetMethodSignatureOrThrow(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 54228, 54271);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_406_54361_54429(Microsoft.CodeAnalysis.PEModule
                module, System.Reflection.Metadata.BlobHandle
                signature, out System.Reflection.Metadata.SignatureHeader
                signatureHeader)
                {
                    var return_v = DecodeSignatureHeaderOrThrow(module, signature, out signatureHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 54361, 54429);
                    return return_v;
                }


                int
                f_406_54446_54553(ref System.Reflection.Metadata.BlobReader
                signatureReader, System.Reflection.Metadata.SignatureHeader
                signatureHeader, out int
                parameterCount, out int
                typeParameterCount)
                {
                    GetSignatureCountsOrThrow(ref signatureReader, signatureHeader, out parameterCount, out typeParameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 54446, 54553);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 54031, 54565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 54031, 54565);
            }
        }

        internal ParamInfo<TypeSymbol>[] GetSignatureForProperty(PropertyDefinitionHandle handle, out SignatureHeader signatureHeader, out BadImageFormatException BadImageFormatException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 54577, 55926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 54781, 54822);

                ParamInfo<TypeSymbol>[]
                paramInfo = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 54836, 54879);

                signatureHeader = default(SignatureHeader);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 54931, 54990);

                    var
                    signature = f_406_54947_54989(Module, handle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 55008, 55098);

                    BlobReader
                    signatureReader = f_406_55037_55097(this, signature, out signatureHeader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 55118, 55141);

                    int
                    typeParameterCount
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 55189, 55296);

                    paramInfo = f_406_55201_55295(this, ref signatureReader, signatureHeader, out typeParameterCount);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 55314, 55345);

                    BadImageFormatException = null;
                }
                catch (BadImageFormatException mrEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 55374, 55882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 55443, 55474);

                    BadImageFormatException = mrEx;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 55549, 55867) || true) && (paramInfo == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 55549, 55867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 55726, 55767);

                        paramInfo = new ParamInfo<TypeSymbol>[1];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 55789, 55848);

                        paramInfo[0].Type = f_406_55809_55847(this, mrEx);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 55549, 55867);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 55374, 55882);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 55898, 55915);

                return paramInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 54577, 55926);

                System.Reflection.Metadata.BlobHandle
                f_406_54947_54989(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                propertyDef)
                {
                    var return_v = this_param.GetPropertySignatureOrThrow(propertyDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 54947, 54989);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_406_55037_55097(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.BlobHandle
                signature, out System.Reflection.Metadata.SignatureHeader
                signatureHeader)
                {
                    var return_v = this_param.DecodeSignatureHeaderOrThrow(signature, out signatureHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 55037, 55097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>[]
                f_406_55201_55295(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, System.Reflection.Metadata.SignatureHeader
                signatureHeader, out int
                typeParameterCount)
                {
                    var return_v = this_param.DecodeSignatureParametersOrThrow(ref signatureReader, signatureHeader, out typeParameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 55201, 55295);
                    return return_v;
                }


                TypeSymbol
                f_406_55809_55847(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.BadImageFormatException
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 55809, 55847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 54577, 55926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 54577, 55926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }


        internal SignatureHeader GetSignatureHeaderForProperty(PropertyDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 55938, 56466);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 56086, 56145);

                    var
                    signature = f_406_56102_56144(Module, handle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 56163, 56195);

                    SignatureHeader
                    signatureHeader
                    = default(SignatureHeader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 56213, 56274);

                    f_406_56213_56273(this, signature, out signatureHeader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 56292, 56315);

                    return signatureHeader;
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 56344, 56455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 56408, 56440);

                    return default(SignatureHeader);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 56344, 56455);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 55938, 56466);

                System.Reflection.Metadata.BlobHandle
                f_406_56102_56144(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.PropertyDefinitionHandle
                propertyDef)
                {
                    var return_v = this_param.GetPropertySignatureOrThrow(propertyDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 56102, 56144);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_406_56213_56273(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.BlobHandle
                signature, out System.Reflection.Metadata.SignatureHeader
                signatureHeader)
                {
                    var return_v = this_param.DecodeSignatureHeaderOrThrow(signature, out signatureHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 56213, 56273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 55938, 56466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 55938, 56466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        #region Custom Attributes

        /// <summary>
        /// Decodes attribute parameter type from method signature.
        /// </summary>
        /// <exception cref="UnsupportedSignatureContent">If the encoded parameter type is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private void DecodeCustomAttributeParameterTypeOrThrow(ref BlobReader sigReader, out SerializationTypeCode typeCode, out TypeSymbol type, out SerializationTypeCode elementTypeCode, out TypeSymbol elementType, bool isElementType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 56846, 60421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57099, 57167);

                SignatureTypeCode
                paramTypeCode = sigReader.ReadSignatureTypeCode()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57183, 57952) || true) && (paramTypeCode == SignatureTypeCode.SZArray)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 57183, 57952);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57263, 57431) || true) && (isElementType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 57263, 57431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57372, 57412);

                        throw f_406_57378_57411();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 57263, 57431);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57451, 57495);

                    SerializationTypeCode
                    unusedElementTypeCode
                    = default(SerializationTypeCode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57513, 57542);

                    TypeSymbol
                    unusedElementType
                    = default(TypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57560, 57726);

                    f_406_57560_57725(this, ref sigReader, out elementTypeCode, out elementType, out unusedElementTypeCode, out unusedElementType, isElementType: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57744, 57853);

                    type = f_406_57751_57852(this, elementType, customModifiers: default(ImmutableArray<ModifierInfo<TypeSymbol>>));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57871, 57912);

                    typeCode = SerializationTypeCode.SZArray;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57930, 57937);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 57183, 57952);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 57968, 58016);

                elementTypeCode = SerializationTypeCode.Invalid;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 58030, 58049);

                elementType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 58065, 60354);

                switch (paramTypeCode)
                {

                    case SignatureTypeCode.Object:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 58065, 60354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 58172, 58221);

                        type = f_406_58179_58220(this, SpecialType.System_Object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 58243, 58289);

                        typeCode = SerializationTypeCode.TaggedObject;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 58311, 58318);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 58065, 60354);

                    case SignatureTypeCode.String:
                    case SignatureTypeCode.Boolean:
                    case SignatureTypeCode.Char:
                    case SignatureTypeCode.SByte:
                    case SignatureTypeCode.Byte:
                    case SignatureTypeCode.Int16:
                    case SignatureTypeCode.UInt16:
                    case SignatureTypeCode.Int32:
                    case SignatureTypeCode.UInt32:
                    case SignatureTypeCode.Int64:
                    case SignatureTypeCode.UInt64:
                    case SignatureTypeCode.Single:
                    case SignatureTypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 58065, 60354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 58959, 59012);

                        type = f_406_58966_59011(this, f_406_58981_59010(paramTypeCode));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 59034, 59082);

                        typeCode = (SerializationTypeCode)paramTypeCode;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 59104, 59111);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 58065, 60354);

                    case SignatureTypeCode.TypeHandle:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 58065, 60354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 59280, 59302);

                        bool
                        isNoPiaLocalType
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 59324, 59456);

                        type = f_406_59331_59455(this, sigReader.ReadTypeHandle(), out isNoPiaLocalType, allowTypeSpec: true, requireShortForm: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 59480, 59533);

                        var
                        underlyingEnumType = f_406_59505_59532(this, type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 59685, 60047) || true) && ((object)underlyingEnumType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 59685, 60047);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 59773, 59805);

                            f_406_59773_59804(!isNoPiaLocalType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 59927, 59991);

                            typeCode = f_406_59938_59990(f_406_59938_59968(underlyingEnumType));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 60017, 60024);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 59685, 60047);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 60071, 60309) || true) && ((object)type == f_406_60091_60107())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 60071, 60309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 60157, 60189);

                            f_406_60157_60188(!isNoPiaLocalType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 60215, 60253);

                            typeCode = SerializationTypeCode.Type;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 60279, 60286);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 60071, 60309);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(406, 60333, 60339);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 58065, 60354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 60370, 60410);

                throw f_406_60376_60409();
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 56846, 60421);

                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_57378_57411()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 57378, 57411);
                    return return_v;
                }


                int
                f_406_57560_57725(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                sigReader, out System.Reflection.Metadata.SerializationTypeCode
                typeCode, out TypeSymbol
                type, out System.Reflection.Metadata.SerializationTypeCode
                elementTypeCode, out TypeSymbol
                elementType, bool
                isElementType)
                {
                    this_param.DecodeCustomAttributeParameterTypeOrThrow(ref sigReader, out typeCode, out type, out elementTypeCode, out elementType, isElementType: isElementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 57560, 57725);
                    return 0;
                }


                TypeSymbol
                f_406_57751_57852(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.GetSZArrayTypeSymbol(elementType, customModifiers: customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 57751, 57852);
                    return return_v;
                }


                TypeSymbol
                f_406_58179_58220(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 58179, 58220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_406_58981_59010(System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = typeCode.ToSpecialType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 58981, 59010);
                    return return_v;
                }


                TypeSymbol
                f_406_58966_59011(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 58966, 59011);
                    return return_v;
                }


                TypeSymbol
                f_406_59331_59455(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                handle, out bool
                isNoPiaLocalType, bool
                allowTypeSpec, bool
                requireShortForm)
                {
                    var return_v = this_param.GetSymbolForTypeHandleOrThrow(handle, out isNoPiaLocalType, allowTypeSpec: allowTypeSpec, requireShortForm: requireShortForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 59331, 59455);
                    return return_v;
                }


                TypeSymbol
                f_406_59505_59532(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                type)
                {
                    var return_v = this_param.GetEnumUnderlyingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 59505, 59532);
                    return return_v;
                }


                int
                f_406_59773_59804(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 59773, 59804);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_406_59938_59968(TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 59938, 59968);
                    return return_v;
                }


                System.Reflection.Metadata.SerializationTypeCode
                f_406_59938_59990(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.ToSerializationType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 59938, 59990);
                    return return_v;
                }


                TypeSymbol
                f_406_60091_60107()
                {
                    var return_v = SystemTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 60091, 60107);
                    return return_v;
                }


                int
                f_406_60157_60188(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 60157, 60188);
                    return 0;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_60376_60409()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 60376, 60409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 56846, 60421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 56846, 60421);
            }
        }

        /// <summary>
        /// Decodes attribute argument type from attribute blob (called FieldOrPropType in the spec).
        /// </summary>
        /// <exception cref="UnsupportedSignatureContent">If the encoded argument type is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private void DecodeCustomAttributeFieldOrPropTypeOrThrow(ref BlobReader argReader, out SerializationTypeCode typeCode, out TypeSymbol type, out SerializationTypeCode elementTypeCode, out TypeSymbol elementType, bool isElementType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 60797, 64686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 61052, 61101);

                typeCode = argReader.ReadSerializationTypeCode();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 61850, 62561) || true) && (typeCode == SerializationTypeCode.SZArray)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 61850, 62561);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 61929, 62097) || true) && (isElementType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 61929, 62097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62038, 62078);

                        throw f_406_62044_62077();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 61929, 62097);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62117, 62161);

                    SerializationTypeCode
                    unusedElementTypeCode
                    = default(SerializationTypeCode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62179, 62208);

                    TypeSymbol
                    unusedElementType
                    = default(TypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62226, 62394);

                    f_406_62226_62393(this, ref argReader, out elementTypeCode, out elementType, out unusedElementTypeCode, out unusedElementType, isElementType: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62412, 62521);

                    type = f_406_62419_62520(this, elementType, customModifiers: default(ImmutableArray<ModifierInfo<TypeSymbol>>));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62539, 62546);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 61850, 62561);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62577, 62625);

                elementTypeCode = SerializationTypeCode.Invalid;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62639, 62658);

                elementType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62674, 64619);

                switch (typeCode)
                {

                    case SerializationTypeCode.TaggedObject:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 62674, 64619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62786, 62835);

                        type = f_406_62793_62834(this, SpecialType.System_Object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62857, 62864);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 62674, 64619);

                    case SerializationTypeCode.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 62674, 64619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62938, 62958);

                        string
                        enumTypeName
                        = default(string);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 62980, 63167) || true) && (!f_406_62985_63054(out enumTypeName, ref argReader))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 62980, 63167);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 63104, 63144);

                            throw f_406_63110_63143();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 62980, 63167);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 63191, 63243);

                        type = f_406_63198_63242(this, enumTypeName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 63265, 63314);

                        var
                        underlyingType = f_406_63286_63313(this, type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 63336, 63483) || true) && ((object)underlyingType == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 63336, 63483);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 63420, 63460);

                            throw f_406_63426_63459();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 63336, 63483);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 63597, 63657);

                        typeCode = f_406_63608_63656(f_406_63608_63634(underlyingType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 63679, 63686);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 62674, 64619);

                    case SerializationTypeCode.Type:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 62674, 64619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 63760, 63784);

                        type = f_406_63767_63783();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 63806, 63813);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 62674, 64619);

                    case SerializationTypeCode.String:
                    case SerializationTypeCode.Boolean:
                    case SerializationTypeCode.Char:
                    case SerializationTypeCode.SByte:
                    case SerializationTypeCode.Byte:
                    case SerializationTypeCode.Int16:
                    case SerializationTypeCode.UInt16:
                    case SerializationTypeCode.Int32:
                    case SerializationTypeCode.UInt32:
                    case SerializationTypeCode.Int64:
                    case SerializationTypeCode.UInt64:
                    case SerializationTypeCode.Single:
                    case SerializationTypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 62674, 64619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 64506, 64575);

                        type = f_406_64513_64574(this, f_406_64528_64573((typeCode)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 64597, 64604);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 62674, 64619);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 64635, 64675);

                throw f_406_64641_64674();
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 60797, 64686);

                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_62044_62077()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 62044, 62077);
                    return return_v;
                }


                int
                f_406_62226_62393(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader, out System.Reflection.Metadata.SerializationTypeCode
                typeCode, out TypeSymbol
                type, out System.Reflection.Metadata.SerializationTypeCode
                elementTypeCode, out TypeSymbol
                elementType, bool
                isElementType)
                {
                    this_param.DecodeCustomAttributeFieldOrPropTypeOrThrow(ref argReader, out typeCode, out type, out elementTypeCode, out elementType, isElementType: isElementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 62226, 62393);
                    return 0;
                }


                TypeSymbol
                f_406_62419_62520(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.GetSZArrayTypeSymbol(elementType, customModifiers: customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 62419, 62520);
                    return return_v;
                }


                TypeSymbol
                f_406_62793_62834(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 62793, 62834);
                    return return_v;
                }


                bool
                f_406_62985_63054(out string
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = PEModule.CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 62985, 63054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_63110_63143()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 63110, 63143);
                    return return_v;
                }


                TypeSymbol
                f_406_63198_63242(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, string
                s)
                {
                    var return_v = this_param.GetTypeSymbolForSerializedType(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 63198, 63242);
                    return return_v;
                }


                TypeSymbol
                f_406_63286_63313(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                type)
                {
                    var return_v = this_param.GetEnumUnderlyingType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 63286, 63313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_63426_63459()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 63426, 63459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_406_63608_63634(TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 63608, 63634);
                    return return_v;
                }


                System.Reflection.Metadata.SerializationTypeCode
                f_406_63608_63656(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.ToSerializationType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 63608, 63656);
                    return return_v;
                }


                TypeSymbol
                f_406_63767_63783()
                {
                    var return_v = SystemTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 63767, 63783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_406_64528_64573(System.Reflection.Metadata.SerializationTypeCode
                typeCode)
                {
                    var return_v = ((SignatureTypeCode)typeCode).ToSpecialType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 64528, 64573);
                    return return_v;
                }


                TypeSymbol
                f_406_64513_64574(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 64513, 64574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_64641_64674()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 64641, 64674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 60797, 64686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 60797, 64686);
            }
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded attribute argument is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private TypedConstant DecodeCustomAttributeFixedArgumentOrThrow(ref BlobReader sigReader, ref BlobReader argReader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 64917, 65667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 65057, 65105);

                SerializationTypeCode
                typeCode
                = default(SerializationTypeCode),
                elementTypeCode
                = default(SerializationTypeCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 65119, 65148);

                TypeSymbol
                type
                = default(TypeSymbol),
                elementType
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 65162, 65303);

                f_406_65162_65302(this, ref sigReader, out typeCode, out type, out elementTypeCode, out elementType, isElementType: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 65373, 65566) || true) && (typeCode == SerializationTypeCode.SZArray)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 65373, 65566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 65452, 65551);

                    return f_406_65459_65550(this, ref argReader, elementTypeCode, elementType, type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 65373, 65566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 65582, 65656);

                return f_406_65589_65655(this, ref argReader, typeCode, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 64917, 65667);

                int
                f_406_65162_65302(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                sigReader, out System.Reflection.Metadata.SerializationTypeCode
                typeCode, out TypeSymbol
                type, out System.Reflection.Metadata.SerializationTypeCode
                elementTypeCode, out TypeSymbol
                elementType, bool
                isElementType)
                {
                    this_param.DecodeCustomAttributeParameterTypeOrThrow(ref sigReader, out typeCode, out type, out elementTypeCode, out elementType, isElementType: isElementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 65162, 65302);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_65459_65550(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader, System.Reflection.Metadata.SerializationTypeCode
                elementTypeCode, TypeSymbol
                elementType, TypeSymbol
                arrayType)
                {
                    var return_v = this_param.DecodeCustomAttributeElementArrayOrThrow(ref argReader, elementTypeCode, elementType, arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 65459, 65550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_65589_65655(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader, System.Reflection.Metadata.SerializationTypeCode
                typeCode, TypeSymbol
                type)
                {
                    var return_v = this_param.DecodeCustomAttributeElementOrThrow(ref argReader, typeCode, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 65589, 65655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 64917, 65667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 64917, 65667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded attribute argument is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private TypedConstant DecodeCustomAttributeElementOrThrow(ref BlobReader argReader, SerializationTypeCode typeCode, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 65898, 66864);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 66055, 66754) || true) && (typeCode == SerializationTypeCode.TaggedObject)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 66055, 66754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 66274, 66312);

                    SerializationTypeCode
                    elementTypeCode
                    = default(SerializationTypeCode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 66330, 66353);

                    TypeSymbol
                    elementType
                    = default(TypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 66371, 66514);

                    f_406_66371_66513(this, ref argReader, out typeCode, out type, out elementTypeCode, out elementType, isElementType: false);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 66534, 66739) || true) && (typeCode == SerializationTypeCode.SZArray)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 66534, 66739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 66621, 66720);

                        return f_406_66628_66719(this, ref argReader, elementTypeCode, elementType, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 66534, 66739);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 66055, 66754);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 66770, 66853);

                return f_406_66777_66852(this, ref argReader, typeCode, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 65898, 66864);

                int
                f_406_66371_66513(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader, out System.Reflection.Metadata.SerializationTypeCode
                typeCode, out TypeSymbol
                type, out System.Reflection.Metadata.SerializationTypeCode
                elementTypeCode, out TypeSymbol
                elementType, bool
                isElementType)
                {
                    this_param.DecodeCustomAttributeFieldOrPropTypeOrThrow(ref argReader, out typeCode, out type, out elementTypeCode, out elementType, isElementType: isElementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 66371, 66513);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_66628_66719(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader, System.Reflection.Metadata.SerializationTypeCode
                elementTypeCode, TypeSymbol
                elementType, TypeSymbol
                arrayType)
                {
                    var return_v = this_param.DecodeCustomAttributeElementArrayOrThrow(ref argReader, elementTypeCode, elementType, arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 66628, 66719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_66777_66852(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader, System.Reflection.Metadata.SerializationTypeCode
                typeCode, TypeSymbol
                type)
                {
                    var return_v = this_param.DecodeCustomAttributePrimitiveElementOrThrow(ref argReader, typeCode, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 66777, 66852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 65898, 66864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 65898, 66864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded attribute argument is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private TypedConstant DecodeCustomAttributeElementArrayOrThrow(ref BlobReader argReader, SerializationTypeCode elementTypeCode, TypeSymbol elementType, TypeSymbol arrayType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 67095, 67978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67293, 67327);

                int
                count = argReader.ReadInt32()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67341, 67364);

                TypedConstant[]
                values
                = default(TypedConstant[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67380, 67880) || true) && (count == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 67380, 67880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67429, 67443);

                    values = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 67380, 67880);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 67380, 67880);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67477, 67880) || true) && (count == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 67477, 67880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67525, 67563);

                        values = f_406_67534_67562();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 67477, 67880);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 67477, 67880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67629, 67663);

                        values = new TypedConstant[count];
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67690, 67695);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67681, 67865) || true) && (i < count)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67708, 67711)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 67681, 67865))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 67681, 67865);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67753, 67846);

                                values[i] = f_406_67765_67845(this, ref argReader, elementTypeCode, elementType);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 185);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 185);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 67477, 67880);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 67380, 67880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 67896, 67967);

                return f_406_67903_67966(arrayType, f_406_67939_67965(values));
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 67095, 67978);

                Microsoft.CodeAnalysis.TypedConstant[]
                f_406_67534_67562()
                {
                    var return_v = Array.Empty<TypedConstant>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 67534, 67562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_67765_67845(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader, System.Reflection.Metadata.SerializationTypeCode
                typeCode, TypeSymbol
                type)
                {
                    var return_v = this_param.DecodeCustomAttributeElementOrThrow(ref argReader, typeCode, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 67765, 67845);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_406_67939_67965(Microsoft.CodeAnalysis.TypedConstant[]?
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.TypedConstant>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 67939, 67965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_67903_67966(TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                array)
                {
                    var return_v = CreateArrayTypedConstant(type, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 67903, 67966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 67095, 67978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 67095, 67978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="UnsupportedSignatureContent">If the given <paramref name="typeCode"/> is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private TypedConstant DecodeCustomAttributePrimitiveElementOrThrow(ref BlobReader argReader, SerializationTypeCode typeCode, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 68216, 71496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 68382, 68409);

                f_406_68382_68408(type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 68425, 71485);

                switch (typeCode)
                {

                    case SerializationTypeCode.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 68532, 68636);

                        return f_406_68539_68635(type, f_406_68565_68606(type), argReader.ReadSByte() != 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 68711, 68810);

                        return f_406_68718_68809(type, f_406_68744_68785(type), argReader.ReadSByte());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 68884, 68982);

                        return f_406_68891_68981(type, f_406_68917_68958(type), argReader.ReadByte());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 69057, 69156);

                        return f_406_69064_69155(type, f_406_69090_69131(type), argReader.ReadInt16());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 69232, 69332);

                        return f_406_69239_69331(type, f_406_69265_69306(type), argReader.ReadUInt16());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 69407, 69506);

                        return f_406_69414_69505(type, f_406_69440_69481(type), argReader.ReadInt32());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 69582, 69682);

                        return f_406_69589_69681(type, f_406_69615_69656(type), argReader.ReadUInt32());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 69757, 69856);

                        return f_406_69764_69855(type, f_406_69790_69831(type), argReader.ReadInt64());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 69932, 70032);

                        return f_406_69939_70031(type, f_406_69965_70006(type), argReader.ReadUInt64());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 70108, 70208);

                        return f_406_70115_70207(type, f_406_70141_70182(type), argReader.ReadSingle());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 70284, 70384);

                        return f_406_70291_70383(type, f_406_70317_70358(type), argReader.ReadDouble());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 70458, 70556);

                        return f_406_70465_70555(type, f_406_70491_70532(type), argReader.ReadChar());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 70632, 70641);

                        string
                        s
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 70663, 70853);

                        TypedConstantKind
                        kind = (DynAbs.Tracing.TraceSender.Conditional_F1(406, 70688, 70746) || ((f_406_70688_70746(out s, ref argReader) && DynAbs.Tracing.TraceSender.Conditional_F2(406, 70774, 70801)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 70829, 70852))) ? TypedConstantKind.Primitive : TypedConstantKind.Error
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 70877, 70919);

                        return f_406_70884_70918(type, kind, s);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    case SerializationTypeCode.Type:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 70993, 71009);

                        string
                        typeName
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 71031, 71283);

                        TypeSymbol
                        serializedType = (DynAbs.Tracing.TraceSender.Conditional_F1(406, 71059, 71124) || ((f_406_71059_71124(out typeName, ref argReader) && DynAbs.Tracing.TraceSender.Conditional_F2(406, 71152, 71220)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 71248, 71282))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(406, 71153, 71169) || ((typeName != null && DynAbs.Tracing.TraceSender.Conditional_F2(406, 71172, 71212)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 71215, 71219))) ? f_406_71172_71212(this, typeName) : null) : f_406_71248_71282(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 71307, 71380);

                        return f_406_71314_71379(type, TypedConstantKind.Type, serializedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 68425, 71485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 71430, 71470);

                        throw f_406_71436_71469();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 68425, 71485);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 68216, 71496);

                int
                f_406_68382_68408(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 68382, 68408);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_68565_68606(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 68565, 68606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_68539_68635(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, bool
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 68539, 68635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_68744_68785(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 68744, 68785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_68718_68809(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, sbyte
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 68718, 68809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_68917_68958(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 68917, 68958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_68891_68981(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, byte
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 68891, 68981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_69090_69131(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69090, 69131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_69064_69155(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, short
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69064, 69155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_69265_69306(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69265, 69306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_69239_69331(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, ushort
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69239, 69331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_69440_69481(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69440, 69481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_69414_69505(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, int
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69414, 69505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_69615_69656(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69615, 69656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_69589_69681(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, uint
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69589, 69681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_69790_69831(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69790, 69831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_69764_69855(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, long
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69764, 69855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_69965_70006(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69965, 70006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_69939_70031(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, ulong
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 69939, 70031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_70141_70182(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 70141, 70182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_70115_70207(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, float
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 70115, 70207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_70317_70358(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 70317, 70358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_70291_70383(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, double
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 70291, 70383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstantKind
                f_406_70491_70532(TypeSymbol
                type)
                {
                    var return_v = GetPrimitiveOrEnumTypedConstantKind(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 70491, 70532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_70465_70555(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, char
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 70465, 70555);
                    return return_v;
                }


                bool
                f_406_70688_70746(out string
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = PEModule.CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 70688, 70746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_70884_70918(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, string
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 70884, 70918);
                    return return_v;
                }


                bool
                f_406_71059_71124(out string
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = PEModule.CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 71059, 71124);
                    return return_v;
                }


                TypeSymbol
                f_406_71172_71212(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, string
                s)
                {
                    var return_v = this_param.GetTypeSymbolForSerializedType(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 71172, 71212);
                    return return_v;
                }


                TypeSymbol
                f_406_71248_71282(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 71248, 71282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_71314_71379(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, TypeSymbol?
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, (object?)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 71314, 71379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_71436_71469()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 71436, 71469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 68216, 71496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 68216, 71496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypedConstantKind GetPrimitiveOrEnumTypedConstantKind(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(406, 71508, 71724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 71618, 71713);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(406, 71625, 71657) || (((f_406_71626_71639(type) == TypeKind.Enum) && DynAbs.Tracing.TraceSender.Conditional_F2(406, 71660, 71682)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 71685, 71712))) ? TypedConstantKind.Enum : TypedConstantKind.Primitive;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(406, 71508, 71724);

                Microsoft.CodeAnalysis.TypeKind
                f_406_71626_71639(TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 71626, 71639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 71508, 71724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 71508, 71724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="UnsupportedSignatureContent">If the encoded named argument is invalid.</exception>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        public (KeyValuePair<string, TypedConstant> nameValuePair, bool isProperty, SerializationTypeCode typeCode, SerializationTypeCode elementTypeCode) DecodeCustomAttributeNamedArgumentOrThrow(ref BlobReader argReader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 71951, 73778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 72588, 72667);

                var
                kind = (CustomAttributeNamedArgumentKind)argReader.ReadCompressedInteger()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 72681, 72873) || true) && (kind != CustomAttributeNamedArgumentKind.Field && (DynAbs.Tracing.TraceSender.Expression_True(406, 72685, 72784) && kind != CustomAttributeNamedArgumentKind.Property))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 72681, 72873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 72818, 72858);

                    throw f_406_72824_72857();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 72681, 72873);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 72889, 72937);

                SerializationTypeCode
                typeCode
                = default(SerializationTypeCode),
                elementTypeCode
                = default(SerializationTypeCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 72951, 72980);

                TypeSymbol
                type
                = default(TypeSymbol),
                elementType
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 72994, 73137);

                f_406_72994_73136(this, ref argReader, out typeCode, out type, out elementTypeCode, out elementType, isElementType: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 73153, 73165);

                string
                name
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 73179, 73334) || true) && (!f_406_73184_73245(out name, ref argReader))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 73179, 73334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 73279, 73319);

                    throw f_406_73285_73318();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 73179, 73334);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 73350, 73611);

                TypedConstant
                value = (DynAbs.Tracing.TraceSender.Conditional_F1(406, 73372, 73413) || ((typeCode == SerializationTypeCode.SZArray
                && DynAbs.Tracing.TraceSender.Conditional_F2(406, 73433, 73524)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 73544, 73610))) ? f_406_73433_73524(this, ref argReader, elementTypeCode, elementType, type) : f_406_73544_73610(this, ref argReader, typeCode, type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 73627, 73767);

                return (f_406_73635_73687(name, value), kind == CustomAttributeNamedArgumentKind.Property, typeCode, elementTypeCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 71951, 73778);

                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_72824_72857()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 72824, 72857);
                    return return_v;
                }


                int
                f_406_72994_73136(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader, out System.Reflection.Metadata.SerializationTypeCode
                typeCode, out TypeSymbol
                type, out System.Reflection.Metadata.SerializationTypeCode
                elementTypeCode, out TypeSymbol
                elementType, bool
                isElementType)
                {
                    this_param.DecodeCustomAttributeFieldOrPropTypeOrThrow(ref argReader, out typeCode, out type, out elementTypeCode, out elementType, isElementType: isElementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 72994, 73136);
                    return 0;
                }


                bool
                f_406_73184_73245(out string
                value, ref System.Reflection.Metadata.BlobReader
                sig)
                {
                    var return_v = PEModule.CrackStringInAttributeValue(out value, ref sig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 73184, 73245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_73285_73318()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 73285, 73318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_73433_73524(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader, System.Reflection.Metadata.SerializationTypeCode
                elementTypeCode, TypeSymbol
                elementType, TypeSymbol
                arrayType)
                {
                    var return_v = this_param.DecodeCustomAttributeElementArrayOrThrow(ref argReader, elementTypeCode, elementType, arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 73433, 73524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_73544_73610(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader, System.Reflection.Metadata.SerializationTypeCode
                typeCode, TypeSymbol
                type)
                {
                    var return_v = this_param.DecodeCustomAttributeElementOrThrow(ref argReader, typeCode, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 73544, 73610);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>
                f_406_73635_73687(string
                key, Microsoft.CodeAnalysis.TypedConstant
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 73635, 73687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 71951, 73778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 71951, 73778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsTargetAttribute(
                    CustomAttributeHandle customAttribute,
                    string namespaceName,
                    string typeName,
                    bool ignoreCase = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 73790, 74410);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 74038, 74056);

                    EntityHandle
                    ctor
                    = default(EntityHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 74076, 74278);

                    return f_406_74083_74277(Module, customAttribute, namespaceName, typeName, out ctor, ignoreCase);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 74307, 74399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 74371, 74384);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 74307, 74399);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 73790, 74410);

                bool
                f_406_74083_74277(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, string
                namespaceName, string
                typeName, out System.Reflection.Metadata.EntityHandle
                ctor, bool
                ignoreCase)
                {
                    var return_v = this_param.IsTargetAttribute(customAttribute, namespaceName, typeName, out ctor, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 74083, 74277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 73790, 74410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 73790, 74410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetTargetAttributeSignatureIndex(CustomAttributeHandle customAttribute, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 74422, 74807);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 74601, 74678);

                    return f_406_74608_74677(Module, customAttribute, description);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 74707, 74796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 74771, 74781);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 74707, 74796);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 74422, 74807);

                int
                f_406_74608_74677(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex(customAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 74608, 74677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 74422, 74807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 74422, 74807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool GetCustomAttribute(
                    CustomAttributeHandle handle,
                    out TypedConstant[] positionalArgs,
                    out KeyValuePair<string, TypedConstant>[] namedArgs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 74819, 78136);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 75071, 75117);

                    positionalArgs = f_406_75088_75116();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 75135, 75198);

                    namedArgs = f_406_75147_75197();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 75459, 75486);

                    EntityHandle
                    attributeType
                    = default(EntityHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 75504, 75522);

                    EntityHandle
                    ctor
                    = default(EntityHandle);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 75542, 77801) || true) && (f_406_75546_75611(Module, handle, out attributeType, out ctor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 75542, 77801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 75653, 75754);

                        BlobReader
                        argsReader = f_406_75677_75753(Module, f_406_75707_75752(Module, handle))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 75776, 75869);

                        BlobReader
                        sigReader = f_406_75799_75868(Module, f_406_75829_75867(Module, ctor))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 75893, 75931);

                        uint
                        prolog = argsReader.ReadUInt16()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 75953, 76054) || true) && (prolog != 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 75953, 76054);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 76018, 76031);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 75953, 76054);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 76129, 76195);

                        SignatureHeader
                        signatureHeader = sigReader.ReadSignatureHeader()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 76273, 76430) || true) && (signatureHeader.IsGeneric && (DynAbs.Tracing.TraceSender.Expression_True(406, 76277, 76344) && sigReader.ReadCompressedInteger() != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 76273, 76430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 76394, 76407);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 76273, 76430);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 76502, 76553);

                        int
                        paramCount = sigReader.ReadCompressedInteger()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 76627, 76682);

                        var
                        returnTypeCode = sigReader.ReadSignatureTypeCode()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 76704, 76834) || true) && (returnTypeCode != SignatureTypeCode.Void)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 76704, 76834);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 76798, 76811);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 76704, 76834);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 76858, 77248) || true) && (paramCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 76858, 77248);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 76926, 76973);

                            positionalArgs = new TypedConstant[paramCount];
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77010, 77015);

                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77001, 77225) || true) && (i < f_406_77021_77042(positionalArgs))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77044, 77047)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 77001, 77225))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 77001, 77225);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77105, 77198);

                                    positionalArgs[i] = f_406_77125_77197(this, ref sigReader, ref argsReader);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 225);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 225);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 76858, 77248);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77272, 77319);

                        short
                        namedParamCount = argsReader.ReadInt16()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77343, 77746) || true) && (namedParamCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 77343, 77746);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77416, 77485);

                            namedArgs = new KeyValuePair<string, TypedConstant>[namedParamCount];
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77522, 77527);

                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77513, 77723) || true) && (i < f_406_77533_77549(namedArgs))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77551, 77554)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 77513, 77723))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 77513, 77723);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77612, 77696);

                                    (namedArgs[i], _, _, _) = f_406_77638_77695(this, ref argsReader);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 211);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 211);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 77343, 77746);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77770, 77782);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 75542, 77801);
                    }
                }
                catch (Exception e) when (e is UnsupportedSignatureContent || (DynAbs.Tracing.TraceSender.Expression_False(406, 77856, 77920) || e is BadImageFormatException))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 77830, 78096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 77954, 78000);

                    positionalArgs = f_406_77971_77999();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78018, 78081);

                    namedArgs = f_406_78030_78080();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 77830, 78096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78112, 78125);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 74819, 78136);

                Microsoft.CodeAnalysis.TypedConstant[]
                f_406_75088_75116()
                {
                    var return_v = Array.Empty<TypedConstant>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 75088, 75116);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>[]
                f_406_75147_75197()
                {
                    var return_v = Array.Empty<KeyValuePair<string, TypedConstant>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 75147, 75197);
                    return return_v;
                }


                bool
                f_406_75546_75611(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, out System.Reflection.Metadata.EntityHandle
                ctorType, out System.Reflection.Metadata.EntityHandle
                attributeCtor)
                {
                    var return_v = this_param.GetTypeAndConstructor(customAttribute, out ctorType, out attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 75546, 75611);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_406_75707_75752(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = this_param.GetCustomAttributeValueOrThrow(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 75707, 75752);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_406_75677_75753(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.BlobHandle
                blob)
                {
                    var return_v = this_param.GetMemoryReaderOrThrow(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 75677, 75753);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_406_75829_75867(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                methodDefOrRef)
                {
                    var return_v = this_param.GetMethodSignatureOrThrow(methodDefOrRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 75829, 75867);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_406_75799_75868(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.BlobHandle
                blob)
                {
                    var return_v = this_param.GetMemoryReaderOrThrow(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 75799, 75868);
                    return return_v;
                }


                int
                f_406_77021_77042(Microsoft.CodeAnalysis.TypedConstant[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 77021, 77042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_77125_77197(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                sigReader, ref System.Reflection.Metadata.BlobReader
                argReader)
                {
                    var return_v = this_param.DecodeCustomAttributeFixedArgumentOrThrow(ref sigReader, ref argReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 77125, 77197);
                    return return_v;
                }


                int
                f_406_77533_77549(System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 77533, 77549);
                    return return_v;
                }


                (System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant> nameValuePair, bool isProperty, System.Reflection.Metadata.SerializationTypeCode typeCode, System.Reflection.Metadata.SerializationTypeCode elementTypeCode)
                f_406_77638_77695(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                argReader)
                {
                    var return_v = this_param.DecodeCustomAttributeNamedArgumentOrThrow(ref argReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 77638, 77695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant[]
                f_406_77971_77999()
                {
                    var return_v = Array.Empty<TypedConstant>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 77971, 77999);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>[]
                f_406_78030_78080()
                {
                    var return_v = Array.Empty<KeyValuePair<String, TypedConstant>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 78030, 78080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 74819, 78136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 74819, 78136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

#nullable enable
        internal bool GetCustomAttribute(CustomAttributeHandle handle, [NotNullWhen(true)] out TypeSymbol? attributeClass, [NotNullWhen(true)] out MethodSymbol? attributeCtor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 78166, 79091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78358, 78385);

                EntityHandle
                attributeType
                = default(EntityHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78399, 78417);

                EntityHandle
                ctor
                = default(EntityHandle);

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78469, 78700) || true) && (!f_406_78474_78539(Module, handle, out attributeType, out ctor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 78469, 78700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78581, 78603);

                        attributeClass = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78625, 78646);

                        attributeCtor = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78668, 78681);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 78469, 78700);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 78729, 78900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78793, 78815);

                    attributeClass = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78833, 78854);

                    attributeCtor = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78872, 78885);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 78729, 78900);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78916, 78963);

                attributeClass = f_406_78933_78962(this, attributeType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 78977, 79054);

                attributeCtor = f_406_78993_79053(this, ctor, attributeClass);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79068, 79080);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 78166, 79091);

                bool
                f_406_78474_78539(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, out System.Reflection.Metadata.EntityHandle
                ctorType, out System.Reflection.Metadata.EntityHandle
                attributeCtor)
                {
                    var return_v = this_param.GetTypeAndConstructor(customAttribute, out ctorType, out attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 78474, 78539);
                    return return_v;
                }


                TypeSymbol
                f_406_78933_78962(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 78933, 78962);
                    return return_v;
                }


                MethodSymbol
                f_406_78993_79053(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                memberToken, TypeSymbol
                container)
                {
                    var return_v = this_param.GetMethodSymbolForMethodDefOrMemberRef(memberToken, container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 78993, 79053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 78166, 79091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 78166, 79091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool GetCustomAttributeWellKnownType(CustomAttributeHandle handle, out WellKnownType wellKnownAttribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 79122, 80200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79260, 79303);

                wellKnownAttribute = WellKnownType.Unknown;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79355, 79382);

                    EntityHandle
                    attributeType
                    = default(EntityHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79400, 79418);

                    EntityHandle
                    ctor
                    = default(EntityHandle);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79438, 79582) || true) && (!f_406_79443_79508(Module, handle, out attributeType, out ctor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 79438, 79582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79550, 79563);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 79438, 79582);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79602, 79631);

                    StringHandle
                    namespaceHandle
                    = default(StringHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79649, 79673);

                    StringHandle
                    nameHandle
                    = default(StringHandle);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79691, 79857) || true) && (!f_406_79696_79783(Module, attributeType, out namespaceHandle, out nameHandle))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 79691, 79857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79825, 79838);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 79691, 79857);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79877, 79950);

                    string
                    fullName = f_406_79895_79949(Module, namespaceHandle, nameHandle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 79968, 80038);

                    wellKnownAttribute = f_406_79989_80037(fullName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80056, 80068);

                    return true;
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 80097, 80189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80161, 80174);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 80097, 80189);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 79122, 80200);

                bool
                f_406_79443_79508(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, out System.Reflection.Metadata.EntityHandle
                ctorType, out System.Reflection.Metadata.EntityHandle
                attributeCtor)
                {
                    var return_v = this_param.GetTypeAndConstructor(customAttribute, out ctorType, out attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 79443, 79508);
                    return return_v;
                }


                bool
                f_406_79696_79783(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                typeDefOrRef, out System.Reflection.Metadata.StringHandle
                namespaceHandle, out System.Reflection.Metadata.StringHandle
                nameHandle)
                {
                    var return_v = this_param.GetAttributeNamespaceAndName(typeDefOrRef, out namespaceHandle, out nameHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 79696, 79783);
                    return return_v;
                }


                string
                f_406_79895_79949(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.StringHandle
                namespaceHandle, System.Reflection.Metadata.StringHandle
                nameHandle)
                {
                    var return_v = this_param.GetFullNameOrThrow(namespaceHandle, nameHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 79895, 79949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.WellKnownType
                f_406_79989_80037(string
                metadataName)
                {
                    var return_v = WellKnownTypes.GetTypeFromMetadataName(metadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 79989, 80037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 79122, 80200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 79122, 80200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        #endregion

        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private TypeSymbol[] DecodeMethodSpecTypeArgumentsOrThrow(BlobHandle signature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 80336, 81252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80440, 80472);

                SignatureHeader
                signatureHeader
                = default(SignatureHeader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80486, 80569);

                var
                signatureReader = f_406_80508_80568(this, signature, out signatureHeader)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80583, 80729) || true) && (signatureHeader.Kind != SignatureKind.MethodSpecification)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 80583, 80729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80678, 80714);

                    throw f_406_80684_80713();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 80583, 80729);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80745, 80805);

                int
                argumentCount = signatureReader.ReadCompressedInteger()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80819, 80926) || true) && (argumentCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 80819, 80926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80875, 80911);

                    throw f_406_80881_80910();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 80819, 80926);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80942, 80985);

                var
                result = new TypeSymbol[argumentCount]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 81008, 81013);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 80999, 81211) || true) && (i < f_406_81019_81032(result))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 81034, 81037)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 80999, 81211))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 80999, 81211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 81071, 81099);

                        bool
                        refersToNoPiaLocalType
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 81117, 81196);

                        result[i] = f_406_81129_81195(this, ref signatureReader, out refersToNoPiaLocalType);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 81227, 81241);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 80336, 81252);

                System.Reflection.Metadata.BlobReader
                f_406_80508_80568(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.BlobHandle
                signature, out System.Reflection.Metadata.SignatureHeader
                signatureHeader)
                {
                    var return_v = this_param.DecodeSignatureHeaderOrThrow(signature, out signatureHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 80508, 80568);
                    return return_v;
                }


                System.BadImageFormatException
                f_406_80684_80713()
                {
                    var return_v = new System.BadImageFormatException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 80684, 80713);
                    return return_v;
                }


                System.BadImageFormatException
                f_406_80881_80910()
                {
                    var return_v = new System.BadImageFormatException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 80881, 80910);
                    return return_v;
                }


                int
                f_406_81019_81032(TypeSymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 81019, 81032);
                    return return_v;
                }


                TypeSymbol
                f_406_81129_81195(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 81129, 81195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 80336, 81252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 80336, 81252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BlobReader DecodeSignatureHeaderOrThrow(BlobHandle signature, out SignatureHeader signatureHeader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 81366, 81585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 81498, 81574);

                return f_406_81505_81573(Module, signature, out signatureHeader);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 81366, 81585);

                System.Reflection.Metadata.BlobReader
                f_406_81505_81573(Microsoft.CodeAnalysis.PEModule
                module, System.Reflection.Metadata.BlobHandle
                signature, out System.Reflection.Metadata.SignatureHeader
                signatureHeader)
                {
                    var return_v = DecodeSignatureHeaderOrThrow(module, signature, out signatureHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 81505, 81573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 81366, 81585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 81366, 81585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BlobReader DecodeSignatureHeaderOrThrow(PEModule module, BlobHandle signature, out SignatureHeader signatureHeader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(406, 81699, 82016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 81855, 81916);

                BlobReader
                reader = f_406_81875_81915(module, signature)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 81930, 81977);

                signatureHeader = reader.ReadSignatureHeader();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 81991, 82005);

                return reader;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(406, 81699, 82016);

                System.Reflection.Metadata.BlobReader
                f_406_81875_81915(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.BlobHandle
                blob)
                {
                    var return_v = this_param.GetMemoryReaderOrThrow(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 81875, 81915);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 81699, 82016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 81699, 82016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        protected ParamInfo<TypeSymbol>[] DecodeSignatureParametersOrThrow(ref BlobReader signatureReader, SignatureHeader signatureHeader, out int typeParameterCount, bool shouldProcessAllBytes = true, bool isFunctionPointerSignature = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 82130, 83737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 82390, 82405);

                int
                paramCount
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 82419, 82523);

                f_406_82419_82522(ref signatureReader, signatureHeader, out paramCount, out typeParameterCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 82539, 82617);

                ParamInfo<TypeSymbol>[]
                paramInfo = new ParamInfo<TypeSymbol>[paramCount + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 82633, 82653);

                uint
                paramIndex = 0
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 82745, 82807);

                    f_406_82745_82806(this, ref signatureReader, ref paramInfo[0]);
                    try
                    {
                        // Get all of the parameters.
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 82879, 82893)
        , paramIndex = 1; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 82874, 83110) || true) && (paramIndex <= paramCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 82921, 82933)
        , paramIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 82874, 83110))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 82874, 83110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 83020, 83091);

                            f_406_83020_83090(this, ref signatureReader, ref paramInfo[paramIndex]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 237);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 237);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 83130, 83294) || true) && (shouldProcessAllBytes && (DynAbs.Tracing.TraceSender.Expression_True(406, 83134, 83193) && signatureReader.RemainingBytes > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 83130, 83294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 83235, 83275);

                        throw f_406_83241_83274();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 83130, 83294);
                    }
                }
                catch (Exception e) when ((e is UnsupportedSignatureContent || (DynAbs.Tracing.TraceSender.Expression_False(406, 83350, 83414) || e is BadImageFormatException)) && (DynAbs.Tracing.TraceSender.Expression_True(406, 83349, 83446) && !isFunctionPointerSignature))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 83323, 83693);
                    try
                    {
                        for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 83480, 83678) || true) && (paramIndex <= paramCount)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 83513, 83525)
   , paramIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 83480, 83678))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 83480, 83678);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 83567, 83659);

                            paramInfo[paramIndex].Type = f_406_83596_83658(this, e as BadImageFormatException);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 199);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 199);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 83323, 83693);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 83709, 83726);

                return paramInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 82130, 83737);

                int
                f_406_82419_82522(ref System.Reflection.Metadata.BlobReader
                signatureReader, System.Reflection.Metadata.SignatureHeader
                signatureHeader, out int
                parameterCount, out int
                typeParameterCount)
                {
                    GetSignatureCountsOrThrow(ref signatureReader, signatureHeader, out parameterCount, out typeParameterCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 82419, 82522);
                    return 0;
                }


                int
                f_406_82745_82806(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, ref Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>
                info)
                {
                    this_param.DecodeParameterOrThrow(ref signatureReader, ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 82745, 82806);
                    return 0;
                }


                int
                f_406_83020_83090(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, ref Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>
                info)
                {
                    this_param.DecodeParameterOrThrow(ref signatureReader, ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 83020, 83090);
                    return 0;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_406_83241_83274()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 83241, 83274);
                    return return_v;
                }


                TypeSymbol
                f_406_83596_83658(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Exception
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol((System.BadImageFormatException?)exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 83596, 83658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 82130, 83737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 82130, 83737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetSignatureCountsOrThrow(ref BlobReader signatureReader, SignatureHeader signatureHeader, out int parameterCount, out int typeParameterCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(406, 83851, 84301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 84084, 84177);

                typeParameterCount = (DynAbs.Tracing.TraceSender.Conditional_F1(406, 84105, 84130) || ((signatureHeader.IsGeneric && DynAbs.Tracing.TraceSender.Conditional_F2(406, 84133, 84172)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 84175, 84176))) ? signatureReader.ReadCompressedInteger() : 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 84233, 84290);

                parameterCount = signatureReader.ReadCompressedInteger();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(406, 83851, 84301);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 83851, 84301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 83851, 84301);
            }
        }

        internal TypeSymbol DecodeFieldSignature(FieldDefinitionHandle fieldHandle, out ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 84313, 85378);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 84511, 84579);

                    BlobHandle
                    signature = f_406_84534_84578(Module, fieldHandle)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 84599, 84631);

                    SignatureHeader
                    signatureHeader
                    = default(SignatureHeader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 84649, 84739);

                    BlobReader
                    signatureReader = f_406_84678_84738(this, signature, out signatureHeader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 84759, 85032) || true) && (signatureHeader.Kind != SignatureKind.Field)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 84759, 85032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 84848, 84916);

                        customModifiers = default(ImmutableArray<ModifierInfo<TypeSymbol>>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 84938, 84980);

                        return f_406_84945_84979(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 84759, 85032);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 85052, 85122);

                    return f_406_85059_85121(this, ref signatureReader, out customModifiers);
                }
                catch (BadImageFormatException mrEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 85151, 85367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 85220, 85288);

                    customModifiers = default(ImmutableArray<ModifierInfo<TypeSymbol>>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 85306, 85352);

                    return f_406_85313_85351(this, mrEx);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 85151, 85367);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 84313, 85378);

                System.Reflection.Metadata.BlobHandle
                f_406_84534_84578(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.FieldDefinitionHandle
                fieldDef)
                {
                    var return_v = this_param.GetFieldSignatureOrThrow(fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 84534, 84578);
                    return return_v;
                }


                System.Reflection.Metadata.BlobReader
                f_406_84678_84738(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.BlobHandle
                signature, out System.Reflection.Metadata.SignatureHeader
                signatureHeader)
                {
                    var return_v = this_param.DecodeSignatureHeaderOrThrow(signature, out signatureHeader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 84678, 84738);
                    return return_v;
                }


                TypeSymbol
                f_406_84945_84979(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 84945, 84979);
                    return return_v;
                }


                TypeSymbol
                f_406_85059_85121(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.DecodeFieldSignature(ref signatureReader, out customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 85059, 85121);
                    return return_v;
                }


                TypeSymbol
                f_406_85313_85351(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.BadImageFormatException
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 85313, 85351);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 84313, 85378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 84313, 85378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        // MetaImport::DecodeFieldSignature
        protected TypeSymbol DecodeFieldSignature(ref BlobReader signatureReader, out ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 85435, 86262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 85595, 85621);

                customModifiers = default;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 85673, 85700);

                    SignatureTypeCode
                    typeCode
                    = default(SignatureTypeCode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 85718, 85837);

                    customModifiers = f_406_85736_85836(this, ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 85857, 85920);

                    return f_406_85864_85919(this, ref signatureReader, typeCode, out _);
                }
                catch (UnsupportedSignatureContent)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 85949, 86107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 86017, 86059);

                    return f_406_86024_86058(this);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 85949, 86107);
                }
                catch (BadImageFormatException mrEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 86121, 86251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 86190, 86236);

                    return f_406_86197_86235(this, mrEx);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 86121, 86251);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 85435, 86262);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                f_406_85736_85836(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                signatureReader, out System.Reflection.Metadata.SignatureTypeCode
                typeCode)
                {
                    var return_v = this_param.DecodeModifiersOrThrow(ref signatureReader, out typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 85736, 85836);
                    return return_v;
                }


                TypeSymbol
                f_406_85864_85919(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, ref System.Reflection.Metadata.BlobReader
                ppSig, System.Reflection.Metadata.SignatureTypeCode
                typeCode, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.DecodeTypeOrThrow(ref ppSig, typeCode, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 85864, 85919);
                    return return_v;
                }


                TypeSymbol
                f_406_86024_86058(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 86024, 86058);
                    return return_v;
                }


                TypeSymbol
                f_406_86197_86235(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.BadImageFormatException
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 86197, 86235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 85435, 86262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 85435, 86262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Find the methods that a given method explicitly overrides.
        /// </summary>
        /// <remarks>
        /// Methods may be on class or interfaces.
        /// Containing classes/interfaces will be supertypes of the implementing type.
        /// </remarks>
        /// <param name="implementingTypeDef">TypeDef handle of the implementing type.</param>
        /// <param name="implementingMethodDef">MethodDef handle of the implementing method.</param>
        /// <param name="implementingTypeSymbol">The type symbol for the implementing type.</param>
        /// <returns>Array of implemented methods.</returns>
        internal ImmutableArray<MethodSymbol> GetExplicitlyOverriddenMethods(TypeDefinitionHandle implementingTypeDef, MethodDefinitionHandle implementingMethodDef, TypeSymbol implementingTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 86941, 89864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 87157, 87241);

                ArrayBuilder<MethodSymbol>
                resultBuilder = f_406_87200_87240()
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 87293, 89718);
                        foreach (var methodImpl in f_406_87320_87379_I(f_406_87320_87379(Module, implementingTypeDef)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 87293, 89718);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 87421, 87452);

                            EntityHandle
                            methodDebugHandle
                            = default(EntityHandle);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 87474, 87511);

                            EntityHandle
                            implementedMethodHandle
                            = default(EntityHandle);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 87533, 87630);

                            f_406_87533_87629(Module, methodImpl, out methodDebugHandle, out implementedMethodHandle);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 87859, 88508) || true) && (methodDebugHandle.Kind == HandleKind.MemberReference)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 87859, 88508);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 87965, 88091);

                                MethodSymbol
                                methodBodySymbol = f_406_87997_88090(this, methodDebugHandle, implementingTypeSymbol)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 88117, 88485) || true) && (methodBodySymbol != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 88117, 88485);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 88404, 88458);

                                    methodDebugHandle = f_406_88424_88457(this, methodBodySymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 88117, 88485);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 87859, 88508);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 88532, 89699) || true) && (methodDebugHandle == implementingMethodDef)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 88532, 89699);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 88628, 89676) || true) && (f_406_88632_88662_M(!implementedMethodHandle.IsNil))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 88628, 89676);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 88720, 88789);

                                    HandleKind
                                    implementedMethodTokenType = implementedMethodHandle.Kind
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 88821, 88854);

                                    MethodSymbol
                                    methodSymbol = null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 88886, 89464) || true) && (implementedMethodTokenType == HandleKind.MethodDefinition)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 88886, 89464);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 89013, 89126);

                                        methodSymbol = f_406_89028_89125(this, implementingTypeDef, implementedMethodHandle);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 88886, 89464);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 88886, 89464);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 89192, 89464) || true) && (implementedMethodTokenType == HandleKind.MemberReference)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 89192, 89464);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 89318, 89433);

                                            methodSymbol = f_406_89333_89432(this, implementedMethodHandle, implementingTypeSymbol);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 89192, 89464);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 88886, 89464);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 89496, 89649) || true) && (methodSymbol != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 89496, 89649);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 89586, 89618);

                                        f_406_89586_89617(resultBuilder, methodSymbol);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 89496, 89649);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 88628, 89676);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 88532, 89699);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 87293, 89718);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 2426);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 2426);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 89747, 89795);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 89747, 89795);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 89811, 89853);

                return f_406_89818_89852(resultBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 86941, 89864);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<MethodSymbol>
                f_406_87200_87240()
                {
                    var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 87200, 87240);
                    return return_v;
                }


                System.Reflection.Metadata.MethodImplementationHandleCollection
                f_406_87320_87379(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetMethodImplementationsOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 87320, 87379);
                    return return_v;
                }


                int
                f_406_87533_87629(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MethodImplementationHandle
                methodImpl, out System.Reflection.Metadata.EntityHandle
                body, out System.Reflection.Metadata.EntityHandle
                declaration)
                {
                    this_param.GetMethodImplPropsOrThrow(methodImpl, out body, out declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 87533, 87629);
                    return 0;
                }


                MethodSymbol
                f_406_87997_88090(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                methodRef, TypeSymbol
                implementingTypeSymbol)
                {
                    var return_v = this_param.GetMethodSymbolForMemberRef((System.Reflection.Metadata.MemberReferenceHandle)methodRef, implementingTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 87997, 88090);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_406_88424_88457(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, MethodSymbol
                method)
                {
                    var return_v = this_param.GetMethodHandle(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 88424, 88457);
                    return return_v;
                }


                bool
                f_406_88632_88662_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 88632, 88662);
                    return return_v;
                }


                MethodSymbol
                f_406_89028_89125(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                searchTypeDef, System.Reflection.Metadata.EntityHandle
                targetMethodDef)
                {
                    var return_v = this_param.FindMethodSymbolInSuperType(searchTypeDef, (System.Reflection.Metadata.MethodDefinitionHandle)targetMethodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 89028, 89125);
                    return return_v;
                }


                MethodSymbol
                f_406_89333_89432(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                methodRef, TypeSymbol
                implementingTypeSymbol)
                {
                    var return_v = this_param.GetMethodSymbolForMemberRef((System.Reflection.Metadata.MemberReferenceHandle)methodRef, implementingTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 89333, 89432);
                    return return_v;
                }


                int
                f_406_89586_89617(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<MethodSymbol>
                this_param, MethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 89586, 89617);
                    return 0;
                }


                System.Reflection.Metadata.MethodImplementationHandleCollection
                f_406_87320_87379_I(System.Reflection.Metadata.MethodImplementationHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 87320, 87379);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<MethodSymbol>
                f_406_89818_89852(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 89818, 89852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 86941, 89864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 86941, 89864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Search for the <typeparamref name="MethodSymbol"/> corresponding to the given MethodDef token. Search amongst
        /// the supertypes (classes and interfaces) of a designated type.
        /// </summary>
        /// <remarks>
        /// Generally, the type will be a type that explicitly implements an interface and the method will be the
        /// implemented method (i.e. on the interface).
        /// </remarks>
        /// <param name="searchTypeDef">TypeDef token of the type from which the search should begin.</param>
        /// <param name="targetMethodDef">MethodDef token of the target method.</param>
        /// <returns>Corresponding <typeparamref name="MethodSymbol"/> or null, if none is found.</returns>
        private MethodSymbol FindMethodSymbolInSuperType(TypeDefinitionHandle searchTypeDef, MethodDefinitionHandle targetMethodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 90649, 94195);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 91484, 91565);

                    Queue<TypeDefinitionHandle>
                    typeDefsToSearch = f_406_91531_91564()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 91583, 91647);

                    Queue<TypeSymbol>
                    typeSymbolsToSearch = f_406_91623_91646()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 91818, 91915);

                    f_406_91818_91914(this, typeDefsToSearch, typeSymbolsToSearch, searchTypeDef);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 91997, 92086);

                    HashSet<TypeDefinitionHandle>
                    visitedTypeDefTokens = f_406_92050_92085()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92104, 92171);

                    HashSet<TypeSymbol>
                    visitedTypeSymbols = f_406_92145_92170()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92191, 92212);

                    bool
                    hasMoreTypeDefs
                    = default(bool);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92230, 94079) || true) && ((hasMoreTypeDefs = (f_406_92257_92279(typeDefsToSearch) > 0)) || (DynAbs.Tracing.TraceSender.Expression_False(406, 92237, 92318) || f_406_92289_92314(typeSymbolsToSearch) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 92230, 94079);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92360, 94060) || true) && (hasMoreTypeDefs)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 92360, 94060);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92429, 92487);

                                TypeDefinitionHandle
                                typeDef = f_406_92460_92486(typeDefsToSearch)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92513, 92542);

                                f_406_92513_92541(f_406_92526_92540_M(!typeDef.IsNil));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92570, 93359) || true) && (!f_406_92575_92613(visitedTypeDefTokens, typeDef))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 92570, 93359);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92671, 92705);

                                    f_406_92671_92704(visitedTypeDefTokens, typeDef);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92737, 93209);
                                        foreach (MethodDefinitionHandle methodDef in f_406_92782_92821_I(f_406_92782_92821(Module, typeDef)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 92737, 93209);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92887, 93178) || true) && (methodDef == targetMethodDef)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 92887, 93178);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 92993, 93046);

                                                TypeSymbol
                                                typeSymbol = f_406_93017_93045(this, typeDef)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 93084, 93143);

                                                return f_406_93091_93142(this, typeSymbol, targetMethodDef);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 92887, 93178);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 92737, 93209);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 473);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 473);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 93241, 93332);

                                    f_406_93241_93331(this, typeDefsToSearch, typeSymbolsToSearch, typeDef);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 92570, 93359);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 92360, 94060);
                            }

                            else //has more type symbols

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 92360, 94060);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 93481, 93535);

                                TypeSymbol
                                typeSymbol = f_406_93505_93534(typeSymbolsToSearch)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 93561, 93594);

                                f_406_93561_93593(typeSymbol != null);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 93622, 94037) || true) && (!f_406_93627_93666(visitedTypeSymbols, typeSymbol))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 93622, 94037);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 93724, 93759);

                                    f_406_93724_93758(visitedTypeSymbols, typeSymbol);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 93919, 94010);

                                    f_406_93919_94009(this, typeDefsToSearch, typeSymbolsToSearch, typeSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 93622, 94037);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 92360, 94060);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 92230, 94079);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 92230, 94079);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(406, 92230, 94079);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 94108, 94156);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 94108, 94156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 94172, 94184);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 90649, 94195);

                System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                f_406_91531_91564()
                {
                    var return_v = new System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 91531, 91564);
                    return return_v;
                }


                System.Collections.Generic.Queue<TypeSymbol>
                f_406_91623_91646()
                {
                    var return_v = new System.Collections.Generic.Queue<TypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 91623, 91646);
                    return return_v;
                }


                int
                f_406_91818_91914(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                typeDefsToSearch, System.Collections.Generic.Queue<TypeSymbol>
                typeSymbolsToSearch, System.Reflection.Metadata.TypeDefinitionHandle
                searchTypeDef)
                {
                    this_param.EnqueueTypeDefInterfacesAndBaseTypeOrThrow(typeDefsToSearch, typeSymbolsToSearch, searchTypeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 91818, 91914);
                    return 0;
                }


                System.Collections.Generic.HashSet<System.Reflection.Metadata.TypeDefinitionHandle>
                f_406_92050_92085()
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Reflection.Metadata.TypeDefinitionHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 92050, 92085);
                    return return_v;
                }


                System.Collections.Generic.HashSet<TypeSymbol>
                f_406_92145_92170()
                {
                    var return_v = new System.Collections.Generic.HashSet<TypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 92145, 92170);
                    return return_v;
                }


                int
                f_406_92257_92279(System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 92257, 92279);
                    return return_v;
                }


                int
                f_406_92289_92314(System.Collections.Generic.Queue<TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 92289, 92314);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandle
                f_406_92460_92486(System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 92460, 92486);
                    return return_v;
                }


                bool
                f_406_92526_92540_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 92526, 92540);
                    return return_v;
                }


                int
                f_406_92513_92541(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 92513, 92541);
                    return 0;
                }


                bool
                f_406_92575_92613(System.Collections.Generic.HashSet<System.Reflection.Metadata.TypeDefinitionHandle>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 92575, 92613);
                    return return_v;
                }


                bool
                f_406_92671_92704(System.Collections.Generic.HashSet<System.Reflection.Metadata.TypeDefinitionHandle>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 92671, 92704);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_406_92782_92821(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetMethodsOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 92782, 92821);
                    return return_v;
                }


                TypeSymbol
                f_406_93017_93045(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 93017, 93045);
                    return return_v;
                }


                MethodSymbol
                f_406_93091_93142(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                type, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef)
                {
                    var return_v = this_param.FindMethodSymbolInType(type, methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 93091, 93142);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandleCollection
                f_406_92782_92821_I(System.Reflection.Metadata.MethodDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 92782, 92821);
                    return return_v;
                }


                int
                f_406_93241_93331(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                typeDefsToSearch, System.Collections.Generic.Queue<TypeSymbol>
                typeSymbolsToSearch, System.Reflection.Metadata.TypeDefinitionHandle
                searchTypeDef)
                {
                    this_param.EnqueueTypeDefInterfacesAndBaseTypeOrThrow(typeDefsToSearch, typeSymbolsToSearch, searchTypeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 93241, 93331);
                    return 0;
                }


                TypeSymbol
                f_406_93505_93534(System.Collections.Generic.Queue<TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 93505, 93534);
                    return return_v;
                }


                int
                f_406_93561_93593(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 93561, 93593);
                    return 0;
                }


                bool
                f_406_93627_93666(System.Collections.Generic.HashSet<TypeSymbol>
                this_param, TypeSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 93627, 93666);
                    return return_v;
                }


                bool
                f_406_93724_93758(System.Collections.Generic.HashSet<TypeSymbol>
                this_param, TypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 93724, 93758);
                    return return_v;
                }


                int
                f_406_93919_94009(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                typeDefsToSearch, System.Collections.Generic.Queue<TypeSymbol>
                typeSymbolsToSearch, TypeSymbol
                typeSymbol)
                {
                    this_param.EnqueueTypeSymbolInterfacesAndBaseTypes(typeDefsToSearch, typeSymbolsToSearch, typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 93919, 94009);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 90649, 94195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 90649, 94195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Enqueue the interfaces implemented and the type extended by a given TypeDef.
        /// </summary>
        /// <param name="typeDefsToSearch">Queue of TypeDefs to search.</param>
        /// <param name="typeSymbolsToSearch">Queue of TypeSymbols (representing typeRefs to search).</param>
        /// <param name="searchTypeDef">Handle of the TypeDef for which we want to enqueue supertypes.</param>
        /// <exception cref="BadImageFormatException">An exception from metadata reader.</exception>
        private void EnqueueTypeDefInterfacesAndBaseTypeOrThrow(Queue<TypeDefinitionHandle> typeDefsToSearch, Queue<TypeSymbol> typeSymbolsToSearch, TypeDefinitionHandle searchTypeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 94750, 95412);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 94951, 95281);
                    foreach (var interfaceImplHandle in f_406_94987_95043_I(f_406_94987_95043(Module, searchTypeDef)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 94951, 95281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 95077, 95167);

                        var
                        interfaceImpl = f_406_95097_95166(f_406_95097_95118(Module), interfaceImplHandle)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 95185, 95266);

                        f_406_95185_95265(this, typeDefsToSearch, typeSymbolsToSearch, interfaceImpl.Interface);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 94951, 95281);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 331);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 95297, 95401);

                f_406_95297_95400(this, typeDefsToSearch, typeSymbolsToSearch, f_406_95353_95399(Module, searchTypeDef));
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 94750, 95412);

                System.Reflection.Metadata.InterfaceImplementationHandleCollection
                f_406_94987_95043(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetInterfaceImplementationsOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 94987, 95043);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_406_95097_95118(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 95097, 95118);
                    return return_v;
                }


                System.Reflection.Metadata.InterfaceImplementation
                f_406_95097_95166(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.InterfaceImplementationHandle
                handle)
                {
                    var return_v = this_param.GetInterfaceImplementation(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 95097, 95166);
                    return return_v;
                }


                int
                f_406_95185_95265(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                typeDefsToSearch, System.Collections.Generic.Queue<TypeSymbol>
                typeSymbolsToSearch, System.Reflection.Metadata.EntityHandle
                typeToken)
                {
                    this_param.EnqueueTypeToken(typeDefsToSearch, typeSymbolsToSearch, typeToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 95185, 95265);
                    return 0;
                }


                System.Reflection.Metadata.InterfaceImplementationHandleCollection
                f_406_94987_95043_I(System.Reflection.Metadata.InterfaceImplementationHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 94987, 95043);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_406_95353_95399(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetBaseTypeOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 95353, 95399);
                    return return_v;
                }


                int
                f_406_95297_95400(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                typeDefsToSearch, System.Collections.Generic.Queue<TypeSymbol>
                typeSymbolsToSearch, System.Reflection.Metadata.EntityHandle
                typeToken)
                {
                    this_param.EnqueueTypeToken(typeDefsToSearch, typeSymbolsToSearch, typeToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 95297, 95400);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 94750, 95412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 94750, 95412);
            }
        }

        /// <summary>
        /// Helper method for enqueuing a type token in the right queue.
        /// Def -> typeDefsToSearch
        /// Ref -> typeSymbolsToSearch
        /// null -> neither
        /// </summary>
        private void EnqueueTypeToken(Queue<TypeDefinitionHandle> typeDefsToSearch, Queue<TypeSymbol> typeSymbolsToSearch, EntityHandle typeToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 95651, 96231);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 95814, 96220) || true) && (f_406_95818_95834_M(!typeToken.IsNil))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 95814, 96220);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 95868, 96205) || true) && (typeToken.Kind == HandleKind.TypeDefinition)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 95868, 96205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 95957, 96015);

                        f_406_95957_96014(typeDefsToSearch, typeToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 95868, 96205);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 95868, 96205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 96097, 96186);

                        f_406_96097_96185(this, typeDefsToSearch, typeSymbolsToSearch, f_406_96154_96184(this, typeToken));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 95868, 96205);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 95814, 96220);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 95651, 96231);

                bool
                f_406_95818_95834_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 95818, 95834);
                    return return_v;
                }


                int
                f_406_95957_96014(System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                this_param, System.Reflection.Metadata.EntityHandle
                item)
                {
                    this_param.Enqueue((System.Reflection.Metadata.TypeDefinitionHandle)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 95957, 96014);
                    return 0;
                }


                TypeSymbol
                f_406_96154_96184(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 96154, 96184);
                    return return_v;
                }


                int
                f_406_96097_96185(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                typeDefsToSearch, System.Collections.Generic.Queue<TypeSymbol>
                typeSymbolsToSearch, TypeSymbol
                typeSymbol)
                {
                    this_param.EnqueueTypeSymbol(typeDefsToSearch, typeSymbolsToSearch, typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 96097, 96185);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 95651, 96231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 95651, 96231);
            }
        }

        protected abstract void EnqueueTypeSymbolInterfacesAndBaseTypes(Queue<TypeDefinitionHandle> typeDefsToSearch, Queue<TypeSymbol> typeSymbolsToSearch, TypeSymbol typeSymbol);

        protected abstract void EnqueueTypeSymbol(Queue<TypeDefinitionHandle> typeDefsToSearch, Queue<TypeSymbol> typeSymbolsToSearch, TypeSymbol typeSymbol);

        protected abstract MethodSymbol FindMethodSymbolInType(TypeSymbol type, MethodDefinitionHandle methodDef);

        protected abstract FieldSymbol FindFieldSymbolInType(TypeSymbol type, FieldDefinitionHandle fieldDef);

        internal abstract Symbol GetSymbolForMemberRef(MemberReferenceHandle memberRef, TypeSymbol implementingTypeSymbol = null, bool methodsOnly = false);

        internal MethodSymbol GetMethodSymbolForMemberRef(MemberReferenceHandle methodRef, TypeSymbol implementingTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 99089, 99339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 99231, 99328);

                return (MethodSymbol)f_406_99252_99327(this, methodRef, implementingTypeSymbol, methodsOnly: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 99089, 99339);

                Symbol
                f_406_99252_99327(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.MemberReferenceHandle
                memberRef, TypeSymbol
                implementingTypeSymbol, bool
                methodsOnly)
                {
                    var return_v = this_param.GetSymbolForMemberRef(memberRef, implementingTypeSymbol, methodsOnly: methodsOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 99252, 99327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 99089, 99339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 99089, 99339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FieldSymbol GetFieldSymbolForMemberRef(MemberReferenceHandle methodRef, TypeSymbol implementingTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 99351, 99598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 99491, 99587);

                return (FieldSymbol)f_406_99511_99586(this, methodRef, implementingTypeSymbol, methodsOnly: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 99351, 99598);

                Symbol
                f_406_99511_99586(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.MemberReferenceHandle
                memberRef, TypeSymbol
                implementingTypeSymbol, bool
                methodsOnly)
                {
                    var return_v = this_param.GetSymbolForMemberRef(memberRef, implementingTypeSymbol, methodsOnly: methodsOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 99511, 99586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 99351, 99598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 99351, 99598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsContainingAssembly(AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 99610, 99808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 99706, 99797);

                return _containingAssemblyIdentity != null && (DynAbs.Tracing.TraceSender.Expression_True(406, 99713, 99796) && f_406_99752_99796(_containingAssemblyIdentity, identity));
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 99610, 99808);

                bool
                f_406_99752_99796(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 99752, 99796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 99610, 99808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 99610, 99808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract MethodDefinitionHandle GetMethodHandle(MethodSymbol method);

        protected abstract ConcurrentDictionary<TypeDefinitionHandle, TypeSymbol> GetTypeHandleToTypeMap();

        protected abstract ConcurrentDictionary<TypeReferenceHandle, TypeSymbol> GetTypeRefHandleToTypeMap();

        protected abstract TypeSymbol SubstituteNoPiaLocalType(TypeDefinitionHandle typeDef, ref MetadataTypeName name, string interfaceGuid, string scope, string identifier);

        protected abstract TypeSymbol LookupTopLevelTypeDefSymbol(string moduleName, ref MetadataTypeName emittedName, out bool isNoPiaLocalType);

        protected abstract TypeSymbol GetGenericTypeParamSymbol(int position);

        protected abstract TypeSymbol GetGenericMethodTypeParamSymbol(int position);

        private static TypedConstant CreateArrayTypedConstant(TypeSymbol type, ImmutableArray<TypedConstant> array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(406, 100971, 101374);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 101103, 101249) || true) && (f_406_101107_101120(type) == TypeKind.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 101103, 101249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 101172, 101234);

                    return f_406_101179_101233(type, TypedConstantKind.Error, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 101103, 101249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 101265, 101311);

                f_406_101265_101310(f_406_101278_101291(type) == TypeKind.Array);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 101325, 101363);

                return f_406_101332_101362(type, array);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(406, 100971, 101374);

                Microsoft.CodeAnalysis.TypeKind
                f_406_101107_101120(TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 101107, 101120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_101179_101233(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, object?
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 101179, 101233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_406_101278_101291(TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 101278, 101291);
                    return return_v;
                }


                int
                f_406_101265_101310(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 101265, 101310);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_101332_101362(TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 101332, 101362);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 100971, 101374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 100971, 101374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypedConstant CreateTypedConstant(TypeSymbol type, TypedConstantKind kind, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(406, 101386, 101731);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 101514, 101660) || true) && (f_406_101518_101531(type) == TypeKind.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 101514, 101660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 101583, 101645);

                    return f_406_101590_101644(type, TypedConstantKind.Error, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 101514, 101660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 101676, 101720);

                return f_406_101683_101719(type, kind, value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(406, 101386, 101731);

                Microsoft.CodeAnalysis.TypeKind
                f_406_101518_101531(TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 101518, 101531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_101590_101644(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, object?
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 101590, 101644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_101683_101719(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, object
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 101683, 101719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 101386, 101731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 101386, 101731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypedConstant CreateTypedConstant(TypeSymbol type, TypedConstantKind kind, bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(406, 101743, 101937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 101869, 101926);

                return f_406_101876_101925(type, kind, f_406_101908_101924(value));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(406, 101743, 101937);

                object
                f_406_101908_101924(bool
                b)
                {
                    var return_v = Boxes.Box(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 101908, 101924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_406_101876_101925(TypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, object
                value)
                {
                    var return_v = CreateTypedConstant(type, kind, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 101876, 101925);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 101743, 101937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 101743, 101937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Returns a symbol that given token resolves to or null of the token represents an entity that isn't represented by a symbol,
        /// such as vararg MemberRef.
        /// </summary>
        internal Symbol GetSymbolForILToken(EntityHandle token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 102172, 105226);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 102288, 105064);

                    switch (token.Kind)
                    {

                        case HandleKind.TypeDefinition:
                        case HandleKind.TypeSpecification:
                        case HandleKind.TypeReference:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 102288, 105064);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 102513, 102542);

                            return f_406_102520_102541(this, token);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 102288, 105064);

                        case HandleKind.MethodDefinition:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 102288, 105064);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 102656, 102751);

                                TypeDefinitionHandle
                                typeDef = f_406_102687_102750(Module, token)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 102783, 102951) || true) && (typeDef.IsNil)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 102783, 102951);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 102908, 102920);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 102783, 102951);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 102983, 103027);

                                TypeSymbol
                                type = f_406_103001_103026(this, typeDef)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 103057, 103224) || true) && (type == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 103057, 103224);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 103181, 103193);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 103057, 103224);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 103256, 103315);

                                return f_406_103263_103314(this, token, type);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 102288, 105064);

                        case HandleKind.FieldDefinition:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 102288, 105064);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 103455, 103549);

                                TypeDefinitionHandle
                                typeDef = f_406_103486_103548(Module, token)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 103579, 103747) || true) && (typeDef.IsNil)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 103579, 103747);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 103704, 103716);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 103579, 103747);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 103779, 103821);

                                TypeSymbol
                                type = f_406_103797_103820(this, typeDef)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 103851, 104018) || true) && (type == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 103851, 104018);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 103975, 103987);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 103851, 104018);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 104050, 104107);

                                return f_406_104057_104106(this, token, type);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 102288, 105064);

                        case HandleKind.MethodSpecification:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 102288, 105064);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 104220, 104240);

                            EntityHandle
                            method
                            = default(EntityHandle);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 104266, 104291);

                            BlobHandle
                            instantiation
                            = default(BlobHandle);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 104317, 104424);

                            f_406_104317_104423(this.Module, token, out method, out instantiation);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 104452, 104518);

                            var
                            genericDefinition = (MethodSymbol)f_406_104490_104517(this, method)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 104544, 104708) || true) && (genericDefinition == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 104544, 104708);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 104669, 104681);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(406, 104544, 104708);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 104736, 104811);

                            var
                            genericArguments = f_406_104759_104810(this, instantiation)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 104837, 104904);

                            return (MethodSymbol)f_406_104858_104903(genericDefinition, genericArguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 102288, 105064);

                        case HandleKind.MemberReference:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 102288, 105064);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 104986, 105045);

                            return f_406_104993_105044(this, token);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 102288, 105064);
                    }
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 105093, 105141);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 105093, 105141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 105203, 105215);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 102172, 105226);

                TypeSymbol
                f_406_102520_102541(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 102520, 102541);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandle
                f_406_102687_102750(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                methodDef)
                {
                    var return_v = this_param.FindContainingTypeOrThrow((System.Reflection.Metadata.MethodDefinitionHandle)methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 102687, 102750);
                    return return_v;
                }


                TypeSymbol
                f_406_103001_103026(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetTypeOfTypeDef(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 103001, 103026);
                    return return_v;
                }


                MethodSymbol
                f_406_103263_103314(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                memberToken, TypeSymbol
                container)
                {
                    var return_v = this_param.GetMethodSymbolForMethodDefOrMemberRef(memberToken, container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 103263, 103314);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandle
                f_406_103486_103548(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                fieldDef)
                {
                    var return_v = this_param.FindContainingTypeOrThrow((System.Reflection.Metadata.FieldDefinitionHandle)fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 103486, 103548);
                    return return_v;
                }


                TypeSymbol
                f_406_103797_103820(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 103797, 103820);
                    return return_v;
                }


                FieldSymbol
                f_406_104057_104106(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                memberToken, TypeSymbol
                container)
                {
                    var return_v = this_param.GetFieldSymbolForFieldDefOrMemberRef(memberToken, container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 104057, 104106);
                    return return_v;
                }


                int
                f_406_104317_104423(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                handle, out System.Reflection.Metadata.EntityHandle
                method, out System.Reflection.Metadata.BlobHandle
                instantiation)
                {
                    this_param.GetMethodSpecificationOrThrow((System.Reflection.Metadata.MethodSpecificationHandle)handle, out method, out instantiation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 104317, 104423);
                    return 0;
                }


                Symbol
                f_406_104490_104517(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetSymbolForILToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 104490, 104517);
                    return return_v;
                }


                TypeSymbol[]
                f_406_104759_104810(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.BlobHandle
                signature)
                {
                    var return_v = this_param.DecodeMethodSpecTypeArgumentsOrThrow(signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 104759, 104810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                f_406_104858_104903(MethodSymbol
                this_param, params TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal[])typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 104858, 104903);
                    return return_v;
                }


                Symbol
                f_406_104993_105044(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                memberRef)
                {
                    var return_v = this_param.GetSymbolForMemberRef((System.Reflection.Metadata.MemberReferenceHandle)memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 104993, 105044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 102172, 105226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 102172, 105226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Given a MemberRef token, return the TypeSymbol for its Class field.
        /// </summary>
        internal TypeSymbol GetMemberRefTypeSymbol(MemberReferenceHandle memberRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 105366, 106530);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 105502, 105570);

                    EntityHandle
                    container = f_406_105527_105569(Module, memberRef)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 105590, 105632);

                    HandleKind
                    containerType = container.Kind
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 105650, 106002);

                    f_406_105650_106001(containerType == HandleKind.MethodDefinition || (DynAbs.Tracing.TraceSender.Expression_False(406, 105685, 105797) || containerType == HandleKind.ModuleReference) || (DynAbs.Tracing.TraceSender.Expression_False(406, 105685, 105864) || containerType == HandleKind.TypeDefinition) || (DynAbs.Tracing.TraceSender.Expression_False(406, 105685, 105930) || containerType == HandleKind.TypeReference) || (DynAbs.Tracing.TraceSender.Expression_False(406, 105685, 106000) || containerType == HandleKind.TypeSpecification));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 106022, 106341) || true) && (containerType != HandleKind.TypeDefinition && (DynAbs.Tracing.TraceSender.Expression_True(406, 106026, 106134) && containerType != HandleKind.TypeReference) && (DynAbs.Tracing.TraceSender.Expression_True(406, 106026, 106204) && containerType != HandleKind.TypeSpecification))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 106022, 106341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 106310, 106322);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(406, 106022, 106341);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 106361, 106399);

                    return f_406_106368_106398(this, container);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(406, 106428, 106519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 106492, 106504);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(406, 106428, 106519);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 105366, 106530);

                System.Reflection.Metadata.EntityHandle
                f_406_105527_105569(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.MemberReferenceHandle
                memberRef)
                {
                    var return_v = this_param.GetContainingTypeOrThrow(memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 105527, 105569);
                    return return_v;
                }


                int
                f_406_105650_106001(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 105650, 106001);
                    return 0;
                }


                TypeSymbol
                f_406_106368_106398(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 106368, 106398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 105366, 106530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 105366, 106530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MethodSymbol GetMethodSymbolForMethodDefOrMemberRef(EntityHandle memberToken, TypeSymbol container)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 106542, 107066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 106675, 106710);

                HandleKind
                type = memberToken.Kind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 106724, 106812);

                f_406_106724_106811(type == HandleKind.MethodDefinition || (DynAbs.Tracing.TraceSender.Expression_False(406, 106737, 106810) || type == HandleKind.MemberReference));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 106828, 107055);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(406, 106835, 106870) || ((type == HandleKind.MethodDefinition
                && DynAbs.Tracing.TraceSender.Conditional_F2(406, 106890, 106960)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 106980, 107054))) ? f_406_106890_106960(this, container, memberToken) : f_406_106980_107054(this, memberToken, container);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 106542, 107066);

                int
                f_406_106724_106811(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 106724, 106811);
                    return 0;
                }


                MethodSymbol
                f_406_106890_106960(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                type, System.Reflection.Metadata.EntityHandle
                methodDef)
                {
                    var return_v = this_param.FindMethodSymbolInType(type, (System.Reflection.Metadata.MethodDefinitionHandle)methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 106890, 106960);
                    return return_v;
                }


                MethodSymbol
                f_406_106980_107054(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                methodRef, TypeSymbol
                implementingTypeSymbol)
                {
                    var return_v = this_param.GetMethodSymbolForMemberRef((System.Reflection.Metadata.MemberReferenceHandle)methodRef, implementingTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 106980, 107054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 106542, 107066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 106542, 107066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FieldSymbol GetFieldSymbolForFieldDefOrMemberRef(EntityHandle memberToken, TypeSymbol container)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 107078, 107623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 107208, 107243);

                HandleKind
                type = memberToken.Kind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 107257, 107373);

                f_406_107257_107372(type == HandleKind.FieldDefinition || (DynAbs.Tracing.TraceSender.Expression_False(406, 107270, 107371) || type == HandleKind.MemberReference));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 107389, 107612);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(406, 107396, 107430) || ((type == HandleKind.FieldDefinition
                && DynAbs.Tracing.TraceSender.Conditional_F2(406, 107450, 107518)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 107538, 107611))) ? f_406_107450_107518(this, container, memberToken) : f_406_107538_107611(this, memberToken, container);
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 107078, 107623);

                int
                f_406_107257_107372(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 107257, 107372);
                    return 0;
                }


                FieldSymbol
                f_406_107450_107518(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                type, System.Reflection.Metadata.EntityHandle
                fieldDef)
                {
                    var return_v = this_param.FindFieldSymbolInType(type, (System.Reflection.Metadata.FieldDefinitionHandle)fieldDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 107450, 107518);
                    return return_v;
                }


                FieldSymbol
                f_406_107538_107611(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, System.Reflection.Metadata.EntityHandle
                methodRef, TypeSymbol
                implementingTypeSymbol)
                {
                    var return_v = this_param.GetFieldSymbolForMemberRef((System.Reflection.Metadata.MemberReferenceHandle)methodRef, implementingTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 107538, 107611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 107078, 107623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 107078, 107623);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Checks whether signatures match where the signatures are either from a property
        /// and an accessor or two accessors. When comparing a property or getter to setter, the
        /// setter signature must be the second argument and 'comparingToSetter' must be true.
        /// </summary>
        /// <param name="signature1">
        /// Signature of the property containing the accessor, or the getter (type, then parameters).
        /// </param>
        /// <param name="signature2">
        /// Signature of the accessor when comparing property and accessor,
        /// or the setter when comparing getter and setter (return type and then parameters).
        /// </param>
        /// <param name="comparingToSetter">
        /// True when comparing a property or getter to a setter, false otherwise.
        /// </param>
        /// <param name="compareParamByRef">
        /// True if differences in IsByRef for parameters should be treated as significant.
        /// </param>
        /// <param name="compareReturnType">
        /// True if differences in return type (or value parameter for setter) should be treated as significant.
        /// </param>
        /// <returns>True if the accessor signature is appropriate for the containing property.</returns>
        internal bool DoPropertySignaturesMatch(ParamInfo<TypeSymbol>[] signature1, ParamInfo<TypeSymbol>[] signature2, bool comparingToSetter, bool compareParamByRef, bool compareReturnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 108968, 110498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 109176, 109231);

                int
                additionalParamCount = ((DynAbs.Tracing.TraceSender.Conditional_F1(406, 109204, 109221) || ((comparingToSetter && DynAbs.Tracing.TraceSender.Conditional_F2(406, 109224, 109225)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 109228, 109229))) ? 1 : 0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 109295, 109424) || true) && ((f_406_109300_109317(signature2) - additionalParamCount) != f_406_109345_109362(signature1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 109295, 109424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 109396, 109409);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 109295, 109424);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 109490, 109666) || true) && (comparingToSetter && (DynAbs.Tracing.TraceSender.Expression_True(406, 109494, 109604) && (f_406_109533_109573(this, signature2[0].Type) != Cci.PrimitiveTypeCode.Void)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 109490, 109666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 109638, 109651);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 109490, 109666);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 109741, 109780);

                    // Check the type of each parameter.
                    for (int
        paramIndex1 = (DynAbs.Tracing.TraceSender.Conditional_F1(406, 109755, 109772) || ((compareReturnType && DynAbs.Tracing.TraceSender.Conditional_F2(406, 109775, 109776)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 109779, 109780))) ? 0 : 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 109732, 110459) || true) && (paramIndex1 < f_406_109796_109813(signature1))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 109815, 109828)
        , paramIndex1++, DynAbs.Tracing.TraceSender.TraceExitCondition(406, 109732, 110459))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 109732, 110459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 109862, 110019);

                        int
                        paramIndex2 =
                        (DynAbs.Tracing.TraceSender.Conditional_F1(406, 109901, 109942) || ((((paramIndex1 == 0) && (DynAbs.Tracing.TraceSender.Expression_True(406, 109902, 109941) && comparingToSetter)) && DynAbs.Tracing.TraceSender.Conditional_F2(406, 109966, 109983)) || DynAbs.Tracing.TraceSender.Conditional_F3(406, 110007, 110018))) ? f_406_109966_109983(signature1) : paramIndex1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 110037, 110074);

                        var
                        param1 = signature1[paramIndex1]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 110092, 110129);

                        var
                        param2 = signature2[paramIndex2]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 110147, 110280) || true) && (compareParamByRef && (DynAbs.Tracing.TraceSender.Expression_True(406, 110151, 110206) && (param2.IsByRef != param1.IsByRef)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 110147, 110280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 110248, 110261);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 110147, 110280);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 110298, 110444) || true) && (!f_406_110303_110370(param2.Type, param1.Type, TypeCompareKind.ConsiderEverything))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 110298, 110444);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 110412, 110425);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(406, 110298, 110444);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(406, 1, 728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(406, 1, 728);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 110475, 110487);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 108968, 110498);

                int
                f_406_109300_109317(Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 109300, 109317);
                    return return_v;
                }


                int
                f_406_109345_109362(Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 109345, 109362);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_406_109533_109573(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                type)
                {
                    var return_v = this_param.GetPrimitiveTypeCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 109533, 109573);
                    return return_v;
                }


                int
                f_406_109796_109813(Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 109796, 109813);
                    return return_v;
                }


                int
                f_406_109966_109983(Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 109966, 109983);
                    return return_v;
                }


                bool
                f_406_110303_110370(TypeSymbol
                this_param, TypeSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 110303, 110370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 108968, 110498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 108968, 110498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Check whether an event accessor has an appropriate signature.
        /// </summary>
        /// <param name="eventType">Type of the event containing the accessor.</param>
        /// <param name="methodParams">Signature of the accessor (return type and then parameters).</param>
        /// <returns>True if the accessor signature is appropriate for the containing event.</returns>
        internal bool DoesSignatureMatchEvent(TypeSymbol eventType, ParamInfo<TypeSymbol>[] methodParams)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(406, 110933, 111540);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 111103, 111193) || true) && (f_406_111107_111126(methodParams) != 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 111103, 111193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 111165, 111178);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 111103, 111193);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 111261, 111399) || true) && (f_406_111265_111307(this, methodParams[0].Type) != Cci.PrimitiveTypeCode.Void)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(406, 111261, 111399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 111371, 111384);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(406, 111261, 111399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 111415, 111449);

                var
                methodParam = methodParams[1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(406, 111463, 111529);

                return !methodParam.IsByRef && (DynAbs.Tracing.TraceSender.Expression_True(406, 111470, 111528) && f_406_111494_111528(methodParam.Type, eventType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(406, 110933, 111540);

                int
                f_406_111107_111126(Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(406, 111107, 111126);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_406_111265_111307(Microsoft.CodeAnalysis.MetadataDecoder<ModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
                this_param, TypeSymbol
                type)
                {
                    var return_v = this_param.GetPrimitiveTypeCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 111265, 111307);
                    return return_v;
                }


                bool
                f_406_111494_111528(TypeSymbol
                this_param, TypeSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 111494, 111528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(406, 110933, 111540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 110933, 111540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MetadataDecoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(406, 3222, 111547);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(406, 3222, 111547);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(406, 3222, 111547);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(406, 3222, 111547);

        static int
        f_406_4205_4233(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(406, 4205, 4233);
            return 0;
        }


        static Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
        f_406_4158_4165_C<ModuleSymbol, TypeSymbol>(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
        i) where ModuleSymbol : class, IModuleSymbolInternal
                where TypeSymbol : class, Symbol, ITypeSymbolInternal

        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(406, 3975, 4351);
            return return_v;
        }

    }
}
