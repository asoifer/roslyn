// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{

    internal struct NativeIntegerTypeDecoder
    {
        private sealed class ErrorTypeException : Exception
        {
            public ErrorTypeException()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10701, 494, 549);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10701, 494, 549);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 494, 549);
            }


            static ErrorTypeException()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10701, 494, 549);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10701, 494, 549);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 494, 549);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10701, 494, 549);
        }

        internal static TypeSymbol TransformType(TypeSymbol type, EntityHandle handle, PEModuleSymbol containingModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10701, 561, 876);
                System.Collections.Immutable.ImmutableArray<bool> transformFlags = default(System.Collections.Immutable.ImmutableArray<bool>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 697, 865);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10701, 704, 785) || ((f_10701_704_785(f_10701_704_727(containingModule), handle, out transformFlags) && DynAbs.Tracing.TraceSender.Conditional_F2(10701, 805, 840)) || DynAbs.Tracing.TraceSender.Conditional_F3(10701, 860, 864))) ? TransformType(type, transformFlags) : type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10701, 561, 876);

                Microsoft.CodeAnalysis.PEModule
                f_10701_704_727(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 704, 727);
                    return return_v;
                }


                bool
                f_10701_704_785(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, out System.Collections.Immutable.ImmutableArray<bool>
                transformFlags)
                {
                    var return_v = this_param.HasNativeIntegerAttribute(token, out transformFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 704, 785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10701, 561, 876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 561, 876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeSymbol TransformType(TypeSymbol type, ImmutableArray<bool> transformFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10701, 888, 2122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 1007, 1066);

                var
                decoder = f_10701_1021_1065(transformFlags)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 1116, 1157);

                    var
                    result = decoder.TransformType(type)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 1175, 1418) || true) && (decoder._index == transformFlags.Length)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 1175, 1418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 1260, 1274);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 1175, 1418);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 1175, 1418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 1356, 1399);

                        return f_10701_1363_1398();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 1175, 1418);
                    }
                }
                catch (UnsupportedSignatureContent)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10701, 1447, 1573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 1515, 1558);

                    return f_10701_1522_1557();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10701, 1447, 1573);
                }
                catch (ErrorTypeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10701, 1587, 2111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 2027, 2066);

                    f_10701_2027_2065(f_10701_2040_2064(type));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 2084, 2096);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10701, 1587, 2111);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10701, 888, 2122);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.NativeIntegerTypeDecoder
                f_10701_1021_1065(System.Collections.Immutable.ImmutableArray<bool>
                transformFlags)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.NativeIntegerTypeDecoder(transformFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 1021, 1065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10701_1363_1398()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 1363, 1398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10701_1522_1557()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 1522, 1557);
                    return return_v;
                }


                bool
                f_10701_2040_2064(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 2040, 2064);
                    return return_v;
                }


                int
                f_10701_2027_2065(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 2027, 2065);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10701, 888, 2122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 888, 2122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly ImmutableArray<bool> _transformFlags;

        private int _index;

        private NativeIntegerTypeDecoder(ImmutableArray<bool> transformFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10701, 2229, 2392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 2323, 2356);

                _transformFlags = transformFlags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 2370, 2381);

                _index = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10701, 2229, 2392);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10701, 2229, 2392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 2229, 2392);
            }
        }

        private TypeWithAnnotations TransformTypeWithAnnotations(TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10701, 2404, 2603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 2511, 2592);

                return type.WithTypeAndModifiers(TransformType(type.Type), type.CustomModifiers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10701, 2404, 2603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10701, 2404, 2603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 2404, 2603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol TransformType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10701, 2615, 3650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 2689, 3639);

                switch (f_10701_2697_2710(type))
                {

                    case TypeKind.Array:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 2689, 3639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 2786, 2835);

                        return TransformArrayType((ArrayTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 2689, 3639);

                    case TypeKind.Pointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 2689, 3639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 2897, 2950);

                        return TransformPointerType((PointerTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 2689, 3639);

                    case TypeKind.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 2689, 3639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 3020, 3089);

                        return TransformFunctionPointerType((FunctionPointerTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 2689, 3639);

                    case TypeKind.TypeParameter:
                    case TypeKind.Dynamic:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 2689, 3639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 3197, 3209);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 2689, 3639);

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Interface:
                    case TypeKind.Delegate:
                    case TypeKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 2689, 3639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 3428, 3477);

                        return TransformNamedType((NamedTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 2689, 3639);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 2689, 3639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 3525, 3571);

                        f_10701_3525_3570(f_10701_3538_3551(type) == TypeKind.Error);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 3593, 3624);

                        throw f_10701_3599_3623();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 2689, 3639);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10701, 2615, 3650);

                Microsoft.CodeAnalysis.TypeKind
                f_10701_2697_2710(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 2697, 2710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10701_3538_3551(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 3538, 3551);
                    return return_v;
                }


                int
                f_10701_3525_3570(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 3525, 3570);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.NativeIntegerTypeDecoder.ErrorTypeException
                f_10701_3599_3623()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.NativeIntegerTypeDecoder.ErrorTypeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 3599, 3623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10701, 2615, 3650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 2615, 3650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol TransformNamedType(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10701, 3662, 5391);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 3751, 4518) || true) && (f_10701_3755_3774_M(!type.IsGenericType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 3751, 4518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 3808, 4503);

                    switch (f_10701_3816_3832(type))
                    {

                        case SpecialType.System_IntPtr:
                        case SpecialType.System_UIntPtr:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 3808, 4503);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 3985, 4146) || true) && (_index >= _transformFlags.Length)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 3985, 4146);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4079, 4119);

                                throw f_10701_4085_4118();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 3985, 4146);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4172, 4484);

                            return (_transformFlags[_index++], f_10701_4207_4231(type)) switch
                            {
                                (false, true) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4296, 4345) && DynAbs.Tracing.TraceSender.Expression_True(10701, 4296, 4345))
    => f_10701_4313_4345(type),
                                (true, false) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4376, 4415) && DynAbs.Tracing.TraceSender.Expression_True(10701, 4376, 4415))
    => f_10701_4393_4415(type),
                                _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4446, 4455) && DynAbs.Tracing.TraceSender.Expression_True(10701, 4446, 4455))
    => type,
                            };
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 3808, 4503);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 3751, 4518);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4534, 4605);

                var
                allTypeArguments = f_10701_4557_4604()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4619, 4682);

                f_10701_4619_4681(type, allTypeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4698, 4723);

                bool
                haveChanges = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4746, 4751);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4737, 5197) || true) && (i < f_10701_4757_4779(allTypeArguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4781, 4784)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 4737, 5197))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 4737, 5197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4818, 4876);

                        TypeWithAnnotations
                        oldTypeArgument = f_10701_4856_4875(allTypeArguments, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4894, 4978);

                        TypeWithAnnotations
                        newTypeArgument = TransformTypeWithAnnotations(oldTypeArgument)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 4996, 5182) || true) && (!oldTypeArgument.IsSameAs(newTypeArgument))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 4996, 5182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 5084, 5122);

                            allTypeArguments[i] = newTypeArgument;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 5144, 5163);

                            haveChanges = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 4996, 5182);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10701, 1, 461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10701, 1, 461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 5213, 5314);

                NamedTypeSymbol
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10701, 5238, 5249) || ((haveChanges && DynAbs.Tracing.TraceSender.Conditional_F2(10701, 5252, 5306)) || DynAbs.Tracing.TraceSender.Conditional_F3(10701, 5309, 5313))) ? f_10701_5252_5306(type, f_10701_5275_5305(allTypeArguments)) : type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 5328, 5352);

                f_10701_5328_5351(allTypeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 5366, 5380);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10701, 3662, 5391);

                bool
                f_10701_3755_3774_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 3755, 3774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10701_3816_3832(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 3816, 3832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnsupportedSignatureContent
                f_10701_4085_4118()
                {
                    var return_v = new Microsoft.CodeAnalysis.UnsupportedSignatureContent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 4085, 4118);
                    return return_v;
                }


                bool
                f_10701_4207_4231(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 4207, 4231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10701_4313_4345(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.NativeIntegerUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 4313, 4345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10701_4393_4415(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 4393, 4415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10701_4557_4604()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 4557, 4604);
                    return return_v;
                }


                int
                f_10701_4619_4681(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder)
                {
                    this_param.GetAllTypeArgumentsNoUseSiteDiagnostics(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 4619, 4681);
                    return 0;
                }


                int
                f_10701_4757_4779(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 4757, 4779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10701_4856_4875(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 4856, 4875);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10701_5275_5305(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 5275, 5305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10701_5252_5306(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                allTypeArguments)
                {
                    var return_v = this_param.WithTypeArguments(allTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 5252, 5306);
                    return return_v;
                }


                int
                f_10701_5328_5351(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 5328, 5351);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10701, 3662, 5391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 3662, 5391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ArrayTypeSymbol TransformArrayType(ArrayTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10701, 5403, 5594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 5492, 5583);

                return f_10701_5499_5582(type, TransformTypeWithAnnotations(f_10701_5549_5580(type)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10701, 5403, 5594);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10701_5549_5580(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 5549, 5580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10701_5499_5582(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations)
                {
                    var return_v = this_param.WithElementType(elementTypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 5499, 5582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10701, 5403, 5594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 5403, 5594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PointerTypeSymbol TransformPointerType(PointerTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10701, 5606, 5807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 5701, 5796);

                return f_10701_5708_5795(type, TransformTypeWithAnnotations(f_10701_5760_5793(type)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10701, 5606, 5807);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10701_5760_5793(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 5760, 5793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10701_5708_5795(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newPointedAtType)
                {
                    var return_v = this_param.WithPointedAtType(newPointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 5708, 5795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10701, 5606, 5807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 5606, 5807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FunctionPointerTypeSymbol TransformFunctionPointerType(FunctionPointerTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10701, 5819, 7470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 5938, 6037);

                var
                transformedReturnType = TransformTypeWithAnnotations(f_10701_5995_6035(f_10701_5995_6009(type)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6051, 6125);

                var
                transformedParameterTypes = ImmutableArray<TypeWithAnnotations>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6139, 6166);

                var
                paramsModified = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6182, 7075) || true) && (f_10701_6186_6215(f_10701_6186_6200(type)) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 6182, 7075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6253, 6344);

                    var
                    builder = f_10701_6267_6343(f_10701_6313_6342(f_10701_6313_6327(type)))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6362, 6712);
                        foreach (var param in f_10701_6384_6409_I(f_10701_6384_6409(f_10701_6384_6398(type))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 6362, 6712);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6451, 6530);

                            var
                            transformedParam = TransformTypeWithAnnotations(f_10701_6503_6528(param))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6552, 6641);

                            paramsModified = paramsModified || (DynAbs.Tracing.TraceSender.Expression_False(10701, 6569, 6640) || !transformedParam.IsSameAs(f_10701_6614_6639(param)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6663, 6693);

                            f_10701_6663_6692(builder, transformedParam);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 6362, 6712);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10701, 1, 351);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10701, 1, 351);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6732, 7060) || true) && (paramsModified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 6732, 7060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6792, 6849);

                        transformedParameterTypes = f_10701_6820_6848(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 6732, 7060);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 6732, 7060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 6931, 7004);

                        transformedParameterTypes = f_10701_6959_7003(f_10701_6959_6973(type));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 7026, 7041);

                        f_10701_7026_7040(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 6732, 7060);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 6182, 7075);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 7091, 7459) || true) && (paramsModified || (DynAbs.Tracing.TraceSender.Expression_False(10701, 7095, 7186) || !transformedReturnType.IsSameAs(f_10701_7145_7185(f_10701_7145_7159(type)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 7091, 7459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 7220, 7366);

                    return f_10701_7227_7365(type, transformedReturnType, transformedParameterTypes, refCustomModifiers: default, paramRefCustomModifiers: default);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 7091, 7459);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10701, 7091, 7459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10701, 7432, 7444);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10701, 7091, 7459);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10701, 5819, 7470);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10701_5995_6009(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 5995, 6009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10701_5995_6035(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 5995, 6035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10701_6186_6200(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 6186, 6200);
                    return return_v;
                }


                int
                f_10701_6186_6215(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 6186, 6215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10701_6313_6327(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 6313, 6327);
                    return return_v;
                }


                int
                f_10701_6313_6342(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 6313, 6342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10701_6267_6343(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 6267, 6343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10701_6384_6398(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 6384, 6398);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10701_6384_6409(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 6384, 6409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10701_6503_6528(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 6503, 6528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10701_6614_6639(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 6614, 6639);
                    return return_v;
                }


                int
                f_10701_6663_6692(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 6663, 6692);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10701_6384_6409_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 6384, 6409);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10701_6820_6848(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 6820, 6848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10701_6959_6973(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 6959, 6973);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10701_6959_7003(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 6959, 7003);
                    return return_v;
                }


                int
                f_10701_7026_7040(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 7026, 7040);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10701_7145_7159(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 7145, 7159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10701_7145_7185(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10701, 7145, 7185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10701_7227_7365(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                substitutedParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                paramRefCustomModifiers)
                {
                    var return_v = this_param.SubstituteTypeSymbol(substitutedReturnType, substitutedParameterTypes, refCustomModifiers: refCustomModifiers, paramRefCustomModifiers: paramRefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10701, 7227, 7365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10701, 5819, 7470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 5819, 7470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static NativeIntegerTypeDecoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10701, 437, 7477);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10701, 437, 7477);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10701, 437, 7477);
        }
    }
}
