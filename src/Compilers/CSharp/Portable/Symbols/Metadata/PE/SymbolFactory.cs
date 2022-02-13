// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class SymbolFactory : SymbolFactory<PEModuleSymbol, TypeSymbol>
    {
        internal static readonly SymbolFactory Instance;

        internal override TypeSymbol GetMDArrayTypeSymbol(PEModuleSymbol moduleSymbol, int rank, TypeSymbol elementType, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers,
                                                                  ImmutableArray<int> sizes, ImmutableArray<int> lowerBounds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 591, 1186);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 905, 1021) || true) && (elementType is UnsupportedMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 905, 1021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 987, 1006);

                    return elementType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 905, 1021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 1037, 1175);

                return f_10715_1044_1174(f_10715_1074_1105(moduleSymbol), f_10715_1107_1147(elementType, customModifiers), rank, sizes, lowerBounds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 591, 1186);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10715_1074_1105(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 1074, 1105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10715_1107_1147(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = CreateType(type, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 1107, 1147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10715_1044_1174(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType, int
                rank, System.Collections.Immutable.ImmutableArray<int>
                sizes, System.Collections.Immutable.ImmutableArray<int>
                lowerBounds)
                {
                    var return_v = ArrayTypeSymbol.CreateMDArray(declaringAssembly, elementType, rank, sizes, lowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 1044, 1174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 591, 1186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 591, 1186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetSpecialType(PEModuleSymbol moduleSymbol, SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 1198, 1398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 1320, 1387);

                return f_10715_1327_1386(f_10715_1327_1358(moduleSymbol), specialType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 1198, 1398);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10715_1327_1358(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 1327, 1358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10715_1327_1386(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 1327, 1386);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 1198, 1398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 1198, 1398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetSystemTypeSymbol(PEModuleSymbol moduleSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 1410, 1560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 1512, 1549);

                return f_10715_1519_1548(moduleSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 1410, 1560);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10715_1519_1548(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.SystemTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 1519, 1548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 1410, 1560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 1410, 1560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol MakePointerTypeSymbol(PEModuleSymbol moduleSymbol, TypeSymbol type, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 1572, 1944);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 1751, 1853) || true) && (type is UnsupportedMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 1751, 1853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 1826, 1838);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 1751, 1853);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 1869, 1933);

                return f_10715_1876_1932(f_10715_1898_1931(type, customModifiers));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 1572, 1944);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10715_1898_1931(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = CreateType(type, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 1898, 1931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10715_1876_1932(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 1876, 1932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 1572, 1944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 1572, 1944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol MakeFunctionPointerTypeSymbol(Cci.CallingConvention callingConvention, ImmutableArray<ParamInfo<TypeSymbol>> retAndParamTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 1956, 2236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 2136, 2225);

                return f_10715_2143_2224(callingConvention, retAndParamTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 1956, 2236);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10715_2143_2224(Microsoft.Cci.CallingConvention
                callingConvention, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                retAndParamTypes)
                {
                    var return_v = FunctionPointerTypeSymbol.CreateFromMetadata(callingConvention, retAndParamTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 2143, 2224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 1956, 2236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 1956, 2236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetEnumUnderlyingType(PEModuleSymbol moduleSymbol, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 2248, 2416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 2369, 2405);

                return f_10715_2376_2404(type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 2248, 2416);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10715_2376_2404(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 2376, 2404);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 2248, 2416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 2248, 2416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Cci.PrimitiveTypeCode GetPrimitiveTypeCode(PEModuleSymbol moduleSymbol, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 2428, 2600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 2559, 2589);

                return f_10715_2566_2588(type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 2428, 2600);

                Microsoft.Cci.PrimitiveTypeCode
                f_10715_2566_2588(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 2566, 2588);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 2428, 2600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 2428, 2600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetSZArrayTypeSymbol(PEModuleSymbol moduleSymbol, TypeSymbol elementType, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 2612, 3052);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 2797, 2913) || true) && (elementType is UnsupportedMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 2797, 2913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 2879, 2898);

                    return elementType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 2797, 2913);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 2929, 3041);

                return f_10715_2936_3040(f_10715_2966_2997(moduleSymbol), f_10715_2999_3039(elementType, customModifiers));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 2612, 3052);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10715_2966_2997(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 2966, 2997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10715_2999_3039(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = CreateType(type, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 2999, 3039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10715_2936_3040(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType)
                {
                    var return_v = ArrayTypeSymbol.CreateSZArray(declaringAssembly, elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 2936, 3040);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 2612, 3052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 2612, 3052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetUnsupportedMetadataTypeSymbol(PEModuleSymbol moduleSymbol, BadImageFormatException exception)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 3064, 3277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 3214, 3266);

                return f_10715_3221_3265(exception);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 3064, 3277);

                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10715_3221_3265(System.BadImageFormatException
                mrEx)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol(mrEx);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 3221, 3265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 3064, 3277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 3064, 3277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol SubstituteTypeParameters(
                    PEModuleSymbol moduleSymbol,
                    TypeSymbol genericTypeDef,
                    ImmutableArray<KeyValuePair<TypeSymbol, ImmutableArray<ModifierInfo<TypeSymbol>>>> arguments,
                    ImmutableArray<bool> refersToNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 3289, 6640);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 3615, 3737) || true) && (genericTypeDef is UnsupportedMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 3615, 3737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 3700, 3722);

                    return genericTypeDef;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 3615, 3737);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 3854, 4141);
                    foreach (var arg in f_10715_3874_3883_I(arguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 3854, 4141);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 3917, 4126) || true) && (f_10715_3921_3933(arg.Key) == SymbolKind.ErrorType && (DynAbs.Tracing.TraceSender.Expression_True(10715, 3921, 4022) && arg.Key is UnsupportedMetadataTypeSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 3917, 4126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 4064, 4107);

                            return f_10715_4071_4106();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 3917, 4126);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 3854, 4141);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10715, 1, 288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10715, 1, 288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 4157, 4219);

                NamedTypeSymbol
                genericType = (NamedTypeSymbol)genericTypeDef
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 4337, 4451);

                ImmutableArray<AssemblySymbol>
                linkedAssemblies = f_10715_4387_4450(f_10715_4387_4418(moduleSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 4467, 4513);

                bool
                noPiaIllegalGenericInstantiation = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 4529, 5693) || true) && (f_10715_4533_4567_M(!linkedAssemblies.IsDefaultOrEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(10715, 4533, 4616) || f_10715_4571_4616(f_10715_4571_4590(moduleSymbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 4529, 5693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 4650, 4692);

                    NamedTypeSymbol
                    typeToCheck = genericType
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 4710, 4764);

                    int
                    argumentIndex = refersToNoPiaLocalType.Length - 1
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 4784, 5205);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 4827, 5067) || true) && (f_10715_4831_4855_M(!typeToCheck.IsInterface))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 4827, 5067);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10715, 4905, 4911);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 4827, 5067);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 4827, 5067);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 5009, 5044);

                                    argumentIndex -= f_10715_5026_5043(typeToCheck);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 4827, 5067);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 5091, 5132);

                                typeToCheck = f_10715_5105_5131(typeToCheck);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 4784, 5205);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 4784, 5205) || true) && ((object)typeToCheck != null)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10715, 4784, 5205);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10715, 4784, 5205);
                        }
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 5234, 5251);

                        for (int
        i = argumentIndex
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 5225, 5678) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 5261, 5264)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 5225, 5678))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 5225, 5678);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 5306, 5659) || true) && (refersToNoPiaLocalType[i] || (DynAbs.Tracing.TraceSender.Expression_False(10715, 5310, 5514) || (f_10715_5365_5399_M(!linkedAssemblies.IsDefaultOrEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10715, 5365, 5513) && f_10715_5428_5513(arguments[i].Key, linkedAssemblies)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 5306, 5659);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 5564, 5604);

                                noPiaIllegalGenericInstantiation = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10715, 5630, 5636);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 5306, 5659);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10715, 1, 454);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10715, 1, 454);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 4529, 5693);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 5875, 5963);

                ImmutableArray<TypeParameterSymbol>
                typeParameters = f_10715_5928_5962(genericType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 5977, 6017);

                f_10715_5977_6016(typeParameters.Length > 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 6033, 6170) || true) && (typeParameters.Length != arguments.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 6033, 6170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 6112, 6155);

                    return f_10715_6119_6154();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 6033, 6170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 6186, 6301);

                TypeMap
                substitution = f_10715_6209_6300(typeParameters, arguments.SelectAsArray(arg => CreateType(arg.Key, arg.Value)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 6317, 6397);

                NamedTypeSymbol
                constructedType = f_10715_6351_6396(substitution, genericType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 6413, 6590) || true) && (noPiaIllegalGenericInstantiation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10715, 6413, 6590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 6483, 6575);

                    constructedType = f_10715_6501_6574(moduleSymbol, constructedType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10715, 6413, 6590);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 6606, 6629);

                return constructedType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 3289, 6640);

                Microsoft.CodeAnalysis.SymbolKind
                f_10715_3921_3933(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 3921, 3933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10715_4071_4106()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 4071, 4106);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>>>
                f_10715_3874_3883_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 3874, 3883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10715_4387_4418(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 4387, 4418);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10715_4387_4450(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetLinkedReferencedAssemblies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 4387, 4450);
                    return return_v;
                }


                bool
                f_10715_4533_4567_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 4533, 4567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10715_4571_4590(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 4571, 4590);
                    return return_v;
                }


                bool
                f_10715_4571_4616(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.ContainsNoPiaLocalTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 4571, 4616);
                    return return_v;
                }


                bool
                f_10715_4831_4855_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 4831, 4855);
                    return return_v;
                }


                int
                f_10715_5026_5043(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 5026, 5043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10715_5105_5131(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 5105, 5131);
                    return return_v;
                }


                bool
                f_10715_5365_5399_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 5365, 5399);
                    return return_v;
                }


                bool
                f_10715_5428_5513(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                assemblies)
                {
                    var return_v = MetadataDecoder.IsOrClosedOverATypeFromAssemblies(symbol, assemblies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 5428, 5513);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10715_5928_5962(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.GetAllTypeParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 5928, 5962);
                    return return_v;
                }


                int
                f_10715_5977_6016(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 5977, 6016);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10715_6119_6154()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 6119, 6154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10715_6209_6300(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 6209, 6300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10715_6351_6396(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 6351, 6396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaIllegalGenericInstantiationSymbol
                f_10715_6501_6574(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                exposingModule, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaIllegalGenericInstantiationSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)exposingModule, underlyingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 6501, 6574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 3289, 6640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 3289, 6640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol MakeUnboundIfGeneric(PEModuleSymbol moduleSymbol, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10715, 6652, 6941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 6772, 6812);

                var
                namedType = type as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 6826, 6930);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10715, 6833, 6887) || ((((object)namedType != null && (DynAbs.Tracing.TraceSender.Expression_True(10715, 6834, 6886) && f_10715_6863_6886(namedType))) && DynAbs.Tracing.TraceSender.Conditional_F2(10715, 6890, 6922)) || DynAbs.Tracing.TraceSender.Conditional_F3(10715, 6925, 6929))) ? f_10715_6890_6922(namedType) : type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10715, 6652, 6941);

                bool
                f_10715_6863_6886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10715, 6863, 6886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10715_6890_6922(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.AsUnboundGenericType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 6890, 6922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 6652, 6941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 6652, 6941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeWithAnnotations CreateType(TypeSymbol type, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10715, 6953, 7324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 7196, 7313);

                return TypeWithAnnotations.Create(type, NullableAnnotation.Oblivious, f_10715_7266_7311(customModifiers));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10715, 6953, 7324);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10715_7266_7311(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = CSharpCustomModifier.Convert(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 7266, 7311);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10715, 6953, 7324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 6953, 7324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10715, 413, 7331);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10715, 413, 7331);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 413, 7331);
        }


        static SymbolFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10715, 413, 7331);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10715, 548, 578);
            Instance = f_10715_559_578(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10715, 413, 7331);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10715, 413, 7331);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10715, 413, 7331);

        static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.SymbolFactory
        f_10715_559_578()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.SymbolFactory();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10715, 559, 578);
            return return_v;
        }

    }
}
