// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis
{
    internal abstract class TypeNameDecoder<ModuleSymbol, TypeSymbol>
            where ModuleSymbol : class
            where TypeSymbol : class
    {
        private readonly SymbolFactory<ModuleSymbol, TypeSymbol> _factory;

        protected readonly ModuleSymbol moduleSymbol;

        internal TypeNameDecoder(SymbolFactory<ModuleSymbol, TypeSymbol> factory, ModuleSymbol moduleSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(418, 716, 918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 640, 648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 691, 703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 841, 860);

                _factory = factory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 874, 907);

                this.moduleSymbol = moduleSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(418, 716, 918);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 716, 918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 716, 918);
            }
        }

        protected abstract bool IsContainingAssembly(AssemblyIdentity identity);

        protected abstract TypeSymbol LookupTopLevelTypeDefSymbol(ref MetadataTypeName emittedName, out bool isNoPiaLocalType);

        protected abstract TypeSymbol LookupTopLevelTypeDefSymbol(int referencedAssemblyIndex, ref MetadataTypeName emittedName);

        protected abstract TypeSymbol LookupNestedTypeDefSymbol(TypeSymbol container, ref MetadataTypeName emittedName);

        protected abstract int GetIndexOfReferencedAssembly(AssemblyIdentity identity);

        internal TypeSymbol GetTypeSymbolForSerializedType(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 1935, 2367);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 2020, 2138) || true) && (f_418_2024_2047(s))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 2020, 2138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 2081, 2123);

                    return f_418_2088_2122(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(418, 2020, 2138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 2154, 2241);

                MetadataHelpers.AssemblyQualifiedTypeName
                fullName = f_418_2207_2240(s)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 2255, 2283);

                bool
                refersToNoPiaLocalType
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 2297, 2356);

                return f_418_2304_2355(this, fullName, out refersToNoPiaLocalType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 1935, 2367);

                bool
                f_418_2024_2047(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 2024, 2047);
                    return return_v;
                }


                TypeSymbol
                f_418_2088_2122(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 2088, 2122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName
                f_418_2207_2240(string
                s)
                {
                    var return_v = MetadataHelpers.DecodeTypeName(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 2207, 2240);
                    return return_v;
                }


                TypeSymbol
                f_418_2304_2355(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName
                fullName, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.GetTypeSymbol(fullName, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 2304, 2355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 1935, 2367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 1935, 2367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TypeSymbol GetUnsupportedMetadataTypeSymbol(BadImageFormatException exception = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 2379, 2589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 2499, 2578);

                return f_418_2506_2577(_factory, this.moduleSymbol, exception);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 2379, 2589);

                TypeSymbol
                f_418_2506_2577(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                this_param, ModuleSymbol
                moduleSymbol, System.BadImageFormatException?
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol(moduleSymbol, exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 2506, 2577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 2379, 2589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 2379, 2589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TypeSymbol GetSZArrayTypeSymbol(TypeSymbol elementType, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 2601, 2846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 2749, 2835);

                return f_418_2756_2834(_factory, this.moduleSymbol, elementType, customModifiers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 2601, 2846);

                TypeSymbol
                f_418_2756_2834(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                this_param, ModuleSymbol
                moduleSymbol, TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.GetSZArrayTypeSymbol(moduleSymbol, elementType, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 2756, 2834);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 2601, 2846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 2601, 2846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TypeSymbol GetMDArrayTypeSymbol(int rank, TypeSymbol elementType, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers, ImmutableArray<int> sizes, ImmutableArray<int> lowerBounds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 2858, 3199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 3076, 3188);

                return f_418_3083_3187(_factory, this.moduleSymbol, rank, elementType, customModifiers, sizes, lowerBounds);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 2858, 3199);

                TypeSymbol
                f_418_3083_3187(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                this_param, ModuleSymbol
                moduleSymbol, int
                rank, TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers, System.Collections.Immutable.ImmutableArray<int>
                sizes, System.Collections.Immutable.ImmutableArray<int>
                lowerBounds)
                {
                    var return_v = this_param.GetMDArrayTypeSymbol(moduleSymbol, rank, elementType, customModifiers, sizes, lowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 3083, 3187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 2858, 3199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 2858, 3199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TypeSymbol MakePointerTypeSymbol(TypeSymbol type, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 3211, 3444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 3353, 3433);

                return f_418_3360_3432(_factory, this.moduleSymbol, type, customModifiers);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 3211, 3444);

                TypeSymbol
                f_418_3360_3432(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                this_param, ModuleSymbol
                moduleSymbol, TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.MakePointerTypeSymbol(moduleSymbol, type, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 3360, 3432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 3211, 3444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 3211, 3444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TypeSymbol MakeFunctionPointerTypeSymbol(Cci.CallingConvention callingConvention, ImmutableArray<ParamInfo<TypeSymbol>> retAndParamInfos)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 3456, 3722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 3628, 3711);

                return f_418_3635_3710(_factory, callingConvention, retAndParamInfos);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 3456, 3722);

                TypeSymbol
                f_418_3635_3710(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                this_param, Microsoft.Cci.CallingConvention
                callingConvention, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ParamInfo<TypeSymbol>>
                returnAndParamTypes)
                {
                    var return_v = this_param.MakeFunctionPointerTypeSymbol(callingConvention, returnAndParamTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 3635, 3710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 3456, 3722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 3456, 3722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TypeSymbol GetSpecialType(SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 3734, 3893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 3819, 3882);

                return f_418_3826_3881(_factory, this.moduleSymbol, specialType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 3734, 3893);

                TypeSymbol
                f_418_3826_3881(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                this_param, ModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(moduleSymbol, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 3826, 3881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 3734, 3893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 3734, 3893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TypeSymbol SystemTypeSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 3967, 4030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 3973, 4028);

                    return f_418_3980_4027(_factory, this.moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(418, 3967, 4030);

                    TypeSymbol
                    f_418_3980_4027(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                    this_param, ModuleSymbol
                    moduleSymbol)
                    {
                        var return_v = this_param.GetSystemTypeSymbol(moduleSymbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 3980, 4027);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 3905, 4041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 3905, 4041);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected TypeSymbol GetEnumUnderlyingType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 4053, 4211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 4137, 4200);

                return f_418_4144_4199(_factory, this.moduleSymbol, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 4053, 4211);

                TypeSymbol
                f_418_4144_4199(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                this_param, ModuleSymbol
                moduleSymbol, TypeSymbol
                type)
                {
                    var return_v = this_param.GetEnumUnderlyingType(moduleSymbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 4144, 4199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 4053, 4211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 4053, 4211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected Microsoft.Cci.PrimitiveTypeCode GetPrimitiveTypeCode(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 4223, 4400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 4327, 4389);

                return f_418_4334_4388(_factory, this.moduleSymbol, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 4223, 4400);

                Microsoft.Cci.PrimitiveTypeCode
                f_418_4334_4388(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                this_param, ModuleSymbol
                moduleSymbol, TypeSymbol
                type)
                {
                    var return_v = this_param.GetPrimitiveTypeCode(moduleSymbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 4334, 4388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 4223, 4400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 4223, 4400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        protected TypeSymbol SubstituteWithUnboundIfGeneric(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 4412, 4578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 4505, 4567);

                return f_418_4512_4566(_factory, this.moduleSymbol, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 4412, 4578);

                TypeSymbol
                f_418_4512_4566(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                this_param, ModuleSymbol
                moduleSymbol, TypeSymbol
                type)
                {
                    var return_v = this_param.MakeUnboundIfGeneric(moduleSymbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 4512, 4566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 4412, 4578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 4412, 4578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TypeSymbol SubstituteTypeParameters(TypeSymbol genericType, ImmutableArray<KeyValuePair<TypeSymbol, ImmutableArray<ModifierInfo<TypeSymbol>>>> arguments, ImmutableArray<bool> refersToNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 4590, 4942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 4823, 4931);

                return f_418_4830_4930(_factory, this.moduleSymbol, genericType, arguments, refersToNoPiaLocalType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 4590, 4942);

                TypeSymbol
                f_418_4830_4930(Microsoft.CodeAnalysis.SymbolFactory<ModuleSymbol, TypeSymbol>
                this_param, ModuleSymbol
                moduleSymbol, TypeSymbol
                generic, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                arguments, System.Collections.Immutable.ImmutableArray<bool>
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.SubstituteTypeParameters(moduleSymbol, generic, arguments, refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 4830, 4930);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 4590, 4942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 4590, 4942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeSymbol GetTypeSymbol(MetadataHelpers.AssemblyQualifiedTypeName fullName, out bool refersToNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 4954, 9949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 5867, 5895);

                int
                referencedAssemblyIndex
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 5909, 7084) || true) && (fullName.AssemblyName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 5909, 7084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 5976, 6002);

                    AssemblyIdentity
                    identity
                    = default(AssemblyIdentity);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 6020, 6254) || true) && (!f_418_6025_6098(fullName.AssemblyName, out identity))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 6020, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 6140, 6171);

                        refersToNoPiaLocalType = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 6193, 6235);

                        return f_418_6200_6234(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(418, 6020, 6254);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 6335, 6400);

                    referencedAssemblyIndex = f_418_6361_6399(this, identity);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 6418, 6936) || true) && (referencedAssemblyIndex == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 6418, 6936);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 6705, 6917) || true) && (!f_418_6710_6745(this, identity))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 6705, 6917);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 6795, 6826);

                            refersToNoPiaLocalType = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 6852, 6894);

                            return f_418_6859_6893(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(418, 6705, 6917);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(418, 6418, 6936);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(418, 5909, 7084);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 5909, 7084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7040, 7069);

                    referencedAssemblyIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(418, 5909, 7084);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7140, 7219);

                f_418_7140_7218(f_418_7153_7217(fullName.TopLevelType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7233, 7299);

                var
                mdName = MetadataTypeName.FromFullName(fullName.TopLevelType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7313, 7429);

                TypeSymbol
                container = f_418_7336_7428(this, ref mdName, referencedAssemblyIndex, out refersToNoPiaLocalType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7486, 8263) || true) && (fullName.NestedTypes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 7486, 8263);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7552, 7807) || true) && (refersToNoPiaLocalType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 7552, 7807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7693, 7724);

                        refersToNoPiaLocalType = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7746, 7788);

                        return f_418_7753_7787(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(418, 7552, 7807);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7836, 7841);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7827, 8248) || true) && (i < f_418_7847_7874(fullName.NestedTypes))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7876, 7879)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(418, 7827, 8248))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 7827, 8248);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 7921, 8002);

                            f_418_7921_8001(f_418_7934_8000(fullName.NestedTypes[i]));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 8024, 8088);

                            mdName = MetadataTypeName.FromTypeName(fullName.NestedTypes[i]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 8168, 8229);

                            container = f_418_8180_8228(this, container, ref mdName);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(418, 1, 422);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(418, 1, 422);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(418, 7486, 8263);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 8329, 9092) || true) && (fullName.TypeArguments != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 8329, 9092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 8397, 8449);

                    ImmutableArray<bool>
                    argumentRefersToNoPiaLocalType
                    = default(ImmutableArray<bool>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 8467, 8568);

                    var
                    typeArguments = f_418_8487_8567(this, fullName.TypeArguments, out argumentRefersToNoPiaLocalType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 8586, 8681);

                    container = f_418_8598_8680(this, container, typeArguments, argumentRefersToNoPiaLocalType);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 8701, 8957);
                        foreach (bool flag in f_418_8723_8753_I(argumentRefersToNoPiaLocalType))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 8701, 8957);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 8795, 8938) || true) && (flag)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 8795, 8938);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 8853, 8883);

                                refersToNoPiaLocalType = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(418, 8909, 8915);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(418, 8795, 8938);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(418, 8701, 8957);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(418, 1, 257);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(418, 1, 257);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(418, 8329, 9092);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 8329, 9092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 9023, 9077);

                    container = f_418_9035_9076(this, container);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(418, 8329, 9092);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 9117, 9122);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 9108, 9296) || true) && (i < fullName.PointerCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 9151, 9154)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(418, 9108, 9296))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 9108, 9296);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 9188, 9281);

                        container = f_418_9200_9280(this, container, ImmutableArray<ModifierInfo<TypeSymbol>>.Empty);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(418, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(418, 1, 189);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 9357, 9905) || true) && (fullName.ArrayRanks != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 9357, 9905);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 9422, 9890);
                        foreach (int rank in f_418_9443_9462_I(fullName.ArrayRanks))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 9422, 9890);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 9504, 9528);

                            f_418_9504_9527(rank >= 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 9550, 9871);

                            container = (DynAbs.Tracing.TraceSender.Conditional_F1(418, 9562, 9571) || ((rank == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(418, 9607, 9689)) || DynAbs.Tracing.TraceSender.Conditional_F3(418, 9725, 9870))) ? f_418_9607_9689(this, container, default(ImmutableArray<ModifierInfo<TypeSymbol>>)) : f_418_9725_9870(this, rank, container, default(ImmutableArray<ModifierInfo<TypeSymbol>>), ImmutableArray<int>.Empty, default(ImmutableArray<int>));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(418, 9422, 9890);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(418, 1, 469);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(418, 1, 469);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(418, 9357, 9905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 9921, 9938);

                return container;
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 4954, 9949);

                bool
                f_418_6025_6098(string
                displayName, out Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = AssemblyIdentity.TryParseDisplayName(displayName, out identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 6025, 6098);
                    return return_v;
                }


                TypeSymbol
                f_418_6200_6234(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 6200, 6234);
                    return return_v;
                }


                int
                f_418_6361_6399(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = this_param.GetIndexOfReferencedAssembly(identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 6361, 6399);
                    return return_v;
                }


                bool
                f_418_6710_6745(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = this_param.IsContainingAssembly(identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 6710, 6745);
                    return return_v;
                }


                TypeSymbol
                f_418_6859_6893(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 6859, 6893);
                    return return_v;
                }


                bool
                f_418_7153_7217(string
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 7153, 7217);
                    return return_v;
                }


                int
                f_418_7140_7218(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 7140, 7218);
                    return 0;
                }


                TypeSymbol
                f_418_7336_7428(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, int
                referencedAssemblyIndex, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.LookupTopLevelTypeDefSymbol(ref emittedName, referencedAssemblyIndex, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 7336, 7428);
                    return return_v;
                }


                TypeSymbol
                f_418_7753_7787(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 7753, 7787);
                    return return_v;
                }


                int
                f_418_7847_7874(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(418, 7847, 7874);
                    return return_v;
                }


                bool
                f_418_7934_8000(string
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 7934, 8000);
                    return return_v;
                }


                int
                f_418_7921_8001(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 7921, 8001);
                    return 0;
                }


                TypeSymbol
                f_418_8180_8228(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, TypeSymbol
                container, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupNestedTypeDefSymbol(container, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 8180, 8228);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                f_418_8487_8567(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName[]
                arguments, out System.Collections.Immutable.ImmutableArray<bool>
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.ResolveTypeArguments(arguments, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 8487, 8567);
                    return return_v;
                }


                TypeSymbol
                f_418_8598_8680(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, TypeSymbol
                genericType, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                arguments, System.Collections.Immutable.ImmutableArray<bool>
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.SubstituteTypeParameters(genericType, arguments, refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 8598, 8680);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_418_8723_8753_I(System.Collections.Immutable.ImmutableArray<bool>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 8723, 8753);
                    return return_v;
                }


                TypeSymbol
                f_418_9035_9076(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, TypeSymbol
                type)
                {
                    var return_v = this_param.SubstituteWithUnboundIfGeneric(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 9035, 9076);
                    return return_v;
                }


                TypeSymbol
                f_418_9200_9280(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, TypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.MakePointerTypeSymbol(type, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 9200, 9280);
                    return return_v;
                }


                int
                f_418_9504_9527(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 9504, 9527);
                    return 0;
                }


                TypeSymbol
                f_418_9607_9689(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers)
                {
                    var return_v = this_param.GetSZArrayTypeSymbol(elementType, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 9607, 9689);
                    return return_v;
                }


                TypeSymbol
                f_418_9725_9870(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, int
                rank, TypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                customModifiers, System.Collections.Immutable.ImmutableArray<int>
                sizes, System.Collections.Immutable.ImmutableArray<int>
                lowerBounds)
                {
                    var return_v = this_param.GetMDArrayTypeSymbol(rank, elementType, customModifiers, sizes, lowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 9725, 9870);
                    return return_v;
                }


                int[]
                f_418_9443_9462_I(int[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 9443, 9462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 4954, 9949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 4954, 9949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<KeyValuePair<TypeSymbol, ImmutableArray<ModifierInfo<TypeSymbol>>>> ResolveTypeArguments(MetadataHelpers.AssemblyQualifiedTypeName[] arguments, out ImmutableArray<bool> refersToNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 9961, 10990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 10201, 10230);

                int
                count = f_418_10213_10229(arguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 10244, 10371);

                var
                typeArgumentsBuilder = f_418_10271_10370(count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 10385, 10450);

                var
                refersToNoPiaBuilder = f_418_10412_10449(count)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 10466, 10833);
                    foreach (var argument in f_418_10491_10500_I(arguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 10466, 10833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 10534, 10553);

                        bool
                        refersToNoPia
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 10571, 10760);

                        f_418_10571_10759(typeArgumentsBuilder, f_418_10596_10758(f_418_10667_10709(this, argument, out refersToNoPia), ImmutableArray<ModifierInfo<TypeSymbol>>.Empty));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 10778, 10818);

                        f_418_10778_10817(refersToNoPiaBuilder, refersToNoPia);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(418, 10466, 10833);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(418, 1, 368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(418, 1, 368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 10849, 10916);

                refersToNoPiaLocalType = f_418_10874_10915(refersToNoPiaBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 10930, 10979);

                return f_418_10937_10978(typeArgumentsBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 9961, 10990);

                int
                f_418_10213_10229(Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(418, 10213, 10229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                f_418_10271_10370(int
                capacity)
                {
                    var return_v = ArrayBuilder<KeyValuePair<TypeSymbol, ImmutableArray<ModifierInfo<TypeSymbol>>>>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 10271, 10370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                f_418_10412_10449(int
                capacity)
                {
                    var return_v = ArrayBuilder<bool>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 10412, 10449);
                    return return_v;
                }


                TypeSymbol
                f_418_10667_10709(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName
                fullName, out bool
                refersToNoPiaLocalType)
                {
                    var return_v = this_param.GetTypeSymbol(fullName, out refersToNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 10667, 10709);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>
                f_418_10596_10758(TypeSymbol
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 10596, 10758);
                    return return_v;
                }


                int
                f_418_10571_10759(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                this_param, System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 10571, 10759);
                    return 0;
                }


                int
                f_418_10778_10817(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param, bool
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 10778, 10817);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName[]
                f_418_10491_10500_I(Microsoft.CodeAnalysis.MetadataHelpers.AssemblyQualifiedTypeName[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 10491, 10500);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_418_10874_10915(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 10874, 10915);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                f_418_10937_10978(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<TypeSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<TypeSymbol>>>>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 10937, 10978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 9961, 10990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 9961, 10990);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol LookupTopLevelTypeDefSymbol(ref MetadataTypeName emittedName, int referencedAssemblyIndex, out bool isNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(418, 11002, 11775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 11163, 11184);

                TypeSymbol
                container
                = default(TypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 11200, 11731) || true) && (referencedAssemblyIndex >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 11200, 11731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 11330, 11355);

                    isNoPiaLocalType = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 11373, 11455);

                    container = f_418_11385_11454(this, referencedAssemblyIndex, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(418, 11200, 11731);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(418, 11200, 11731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 11637, 11716);

                    container = f_418_11649_11715(this, ref emittedName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(418, 11200, 11731);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(418, 11747, 11764);

                return container;
                DynAbs.Tracing.TraceSender.TraceExitMethod(418, 11002, 11775);

                TypeSymbol
                f_418_11385_11454(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, int
                referencedAssemblyIndex, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelTypeDefSymbol(referencedAssemblyIndex, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 11385, 11454);
                    return return_v;
                }


                TypeSymbol
                f_418_11649_11715(Microsoft.CodeAnalysis.TypeNameDecoder<ModuleSymbol, TypeSymbol>
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.LookupTopLevelTypeDefSymbol(ref emittedName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(418, 11649, 11715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(418, 11002, 11775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 11002, 11775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeNameDecoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(418, 431, 11782);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(418, 431, 11782);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(418, 431, 11782);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(418, 431, 11782);
    }
}
