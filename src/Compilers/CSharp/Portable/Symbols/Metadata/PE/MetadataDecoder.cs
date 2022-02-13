// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal class MetadataDecoder : MetadataDecoder<PEModuleSymbol, TypeSymbol, MethodSymbol, FieldSymbol, Symbol>
    {
        private readonly PENamedTypeSymbol _typeContextOpt;

        private readonly PEMethodSymbol _methodContextOpt;

        public MetadataDecoder(
                    PEModuleSymbol moduleSymbol,
                    PENamedTypeSymbol context) : this(f_10700_1225_1237_C(moduleSymbol), context, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10700, 1099, 1275);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10700, 1099, 1275);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 1099, 1275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 1099, 1275);
            }
        }

        public MetadataDecoder(
                    PEModuleSymbol moduleSymbol,
                    PEMethodSymbol context) : this(f_10700_1410_1422_C(moduleSymbol), (PENamedTypeSymbol)f_10700_1443_1465(context), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10700, 1287, 1497);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10700, 1287, 1497);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 1287, 1497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 1287, 1497);
            }
        }

        public MetadataDecoder(
                    PEModuleSymbol moduleSymbol) : this(f_10700_1595_1607_C(moduleSymbol), null, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10700, 1509, 1642);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10700, 1509, 1642);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 1509, 1642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 1509, 1642);
            }
        }

        private MetadataDecoder(PEModuleSymbol moduleSymbol, PENamedTypeSymbol typeContextOpt, PEMethodSymbol methodContextOpt)
        : base(f_10700_2004_2023_C(f_10700_2004_2023(moduleSymbol)), (DynAbs.Tracing.TraceSender.Conditional_F1(10700, 2025, 2078) || (((f_10700_2026_2057(moduleSymbol) is PEAssemblySymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10700, 2081, 2121)) || DynAbs.Tracing.TraceSender.Conditional_F3(10700, 2124, 2128))) ? f_10700_2081_2121(f_10700_2081_2112(moduleSymbol)) : null, SymbolFactory.Instance, moduleSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10700, 1654, 2346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 889, 904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 1069, 1086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 2192, 2235);

                f_10700_2192_2234((object)moduleSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 2251, 2284);

                _typeContextOpt = typeContextOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 2298, 2335);

                _methodContextOpt = methodContextOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10700, 1654, 2346);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 1654, 2346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 1654, 2346);
            }
        }

        internal PEModuleSymbol ModuleSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 2419, 2447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 2425, 2445);

                    return moduleSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 2419, 2447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 2358, 2458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 2358, 2458);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override TypeSymbol GetGenericMethodTypeParamSymbol(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 2470, 3057);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 2570, 2746) || true) && ((object)_methodContextOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 2570, 2746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 2641, 2684);

                    return f_10700_2648_2683();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 2570, 2746);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 2762, 2816);

                var
                typeParameters = f_10700_2783_2815(_methodContextOpt)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 2832, 2998) || true) && (typeParameters.Length <= position)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 2832, 2998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 2903, 2946);

                    return f_10700_2910_2945();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 2832, 2998);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 3014, 3046);

                return typeParameters[position];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 2470, 3057);

                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10700_2648_2683()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 2648, 2683);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10700_2783_2815(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 2783, 2815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10700_2910_2945()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 2910, 2945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 2470, 3057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 2470, 3057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeSymbol GetGenericTypeParamSymbol(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 3069, 3791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 3163, 3204);

                PENamedTypeSymbol
                type = _typeContextOpt
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 3220, 3394) || true) && ((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10700, 3227, 3295) && (f_10700_3252_3270(type) - f_10700_3273_3283(type)) > position))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 3220, 3394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 3329, 3379);

                        type = f_10700_3336_3357(type) as PENamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 3220, 3394);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10700, 3220, 3394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10700, 3220, 3394);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 3410, 3600) || true) && ((object)type == null || (DynAbs.Tracing.TraceSender.Expression_False(10700, 3414, 3468) || f_10700_3438_3456(type) <= position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 3410, 3600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 3502, 3545);

                    return f_10700_3509_3544();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 3410, 3600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 3616, 3660);

                position -= f_10700_3628_3646(type) - f_10700_3649_3659(type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 3674, 3727);

                f_10700_3674_3726(position >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10700, 3687, 3725) && position < f_10700_3715_3725(type)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 3743, 3780);

                return f_10700_3750_3769(type)[position];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 3069, 3791);

                int
                f_10700_3252_3270(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataArity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 3252, 3270);
                    return return_v;
                }


                int
                f_10700_3273_3283(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 3273, 3283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10700_3336_3357(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 3336, 3357);
                    return return_v;
                }


                int
                f_10700_3438_3456(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataArity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 3438, 3456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10700_3509_3544()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 3509, 3544);
                    return return_v;
                }


                int
                f_10700_3628_3646(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataArity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 3628, 3646);
                    return return_v;
                }


                int
                f_10700_3649_3659(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 3649, 3659);
                    return return_v;
                }


                int
                f_10700_3715_3725(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 3715, 3725);
                    return return_v;
                }


                int
                f_10700_3674_3726(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 3674, 3726);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10700_3750_3769(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 3750, 3769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 3069, 3791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 3069, 3791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ConcurrentDictionary<TypeDefinitionHandle, TypeSymbol> GetTypeHandleToTypeMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 3803, 3977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 3926, 3966);

                return moduleSymbol.TypeHandleToTypeMap;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 3803, 3977);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 3803, 3977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 3803, 3977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ConcurrentDictionary<TypeReferenceHandle, TypeSymbol> GetTypeRefHandleToTypeMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 3989, 4168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 4114, 4157);

                return moduleSymbol.TypeRefHandleToTypeMap;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 3989, 4168);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 3989, 4168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 3989, 4168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeSymbol LookupNestedTypeDefSymbol(TypeSymbol container, ref MetadataTypeName emittedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 4180, 4467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 4316, 4375);

                var
                result = f_10700_4329_4374(container, ref emittedName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 4389, 4426);

                f_10700_4389_4425((object)result != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 4442, 4456);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 4180, 4467);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10700_4329_4374(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedTypeName)
                {
                    var return_v = this_param.LookupMetadataType(ref emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 4329, 4374);
                    return return_v;
                }


                int
                f_10700_4389_4425(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 4389, 4425);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 4180, 4467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 4180, 4467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeSymbol LookupTopLevelTypeDefSymbol(
                    int referencedAssemblyIndex,
                    ref MetadataTypeName emittedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 4693, 5451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 4865, 4946);

                var
                assembly = f_10700_4880_4945(moduleSymbol, referencedAssemblyIndex)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 4960, 5080) || true) && ((object)assembly == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 4960, 5080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 5022, 5065);

                    return f_10700_5029_5064();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 4960, 5080);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 5132, 5224);

                    return f_10700_5139_5223(assembly, ref emittedName, digThroughForwardedTypes: true);
                }
                catch (Exception e) when (f_10700_5279_5311(e)) // Trying to get more useful Watson dumps.
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10700, 5253, 5440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 5388, 5425);

                    throw f_10700_5394_5424();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10700, 5253, 5440);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 4693, 5451);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10700_4880_4945(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, int
                referencedAssemblyIndex)
                {
                    var return_v = this_param.GetReferencedAssemblySymbol(referencedAssemblyIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 4880, 4945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10700_5029_5064()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 5029, 5064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10700_5139_5223(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, bool
                digThroughForwardedTypes)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName, digThroughForwardedTypes: digThroughForwardedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 5139, 5223);
                    return return_v;
                }


                bool
                f_10700_5279_5311(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagate(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 5279, 5311);
                    return return_v;
                }


                System.Exception
                f_10700_5394_5424()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 5394, 5424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 4693, 5451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 4693, 5451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeSymbol LookupTopLevelTypeDefSymbol(string moduleName, ref MetadataTypeName emittedName, out bool isNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 5585, 6619);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 5747, 6394);
                    foreach (ModuleSymbol m in f_10700_5774_5813_I(f_10700_5774_5813(f_10700_5774_5805(moduleSymbol))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 5747, 6394);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 5847, 6379) || true) && (f_10700_5851_5920(f_10700_5865_5871(m), moduleName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 5847, 6379);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 5962, 6360) || true) && ((object)m == (object)moduleSymbol)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 5962, 6360);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 6049, 6135);

                                return f_10700_6056_6134(moduleSymbol, ref emittedName, out isNoPiaLocalType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 5962, 6360);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 5962, 6360);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 6233, 6258);

                                isNoPiaLocalType = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 6284, 6337);

                                return f_10700_6291_6336(m, ref emittedName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 5962, 6360);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 5847, 6379);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 5747, 6394);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10700, 1, 648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10700, 1, 648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 6410, 6435);

                isNoPiaLocalType = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 6449, 6608);

                return f_10700_6456_6607(f_10700_6495_6571(f_10700_6527_6558(moduleSymbol), moduleName), ref emittedName, SpecialType.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 5585, 6619);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10700_5774_5805(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 5774, 5805);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10700_5774_5813(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 5774, 5813);
                    return return_v;
                }


                string
                f_10700_5865_5871(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 5865, 5871);
                    return return_v;
                }


                bool
                f_10700_5851_5920(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 5851, 5920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10700_6056_6134(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 6056, 6134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10700_6291_6336(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 6291, 6336);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10700_5774_5813_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 5774, 5813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10700_6527_6558(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 6527, 6558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbolWithName
                f_10700_6495_6571(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbolWithName(assembly, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 6495, 6571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10700_6456_6607(Microsoft.CodeAnalysis.CSharp.Symbols.MissingModuleSymbolWithName
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)module, ref fullName, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 6456, 6607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 5585, 6619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 5585, 6619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeSymbol LookupTopLevelTypeDefSymbol(ref MetadataTypeName emittedName, out bool isNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 6977, 7217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 7120, 7206);

                return f_10700_7127_7205(moduleSymbol, ref emittedName, out isNoPiaLocalType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 6977, 7217);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10700_7127_7205(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 7127, 7205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 6977, 7217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 6977, 7217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GetIndexOfReferencedAssembly(AssemblyIdentity identity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 7229, 7838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 7533, 7594);

                var
                assemblies = f_10700_7550_7593(this.moduleSymbol)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 7617, 7622);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 7608, 7803) || true) && (i < assemblies.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 7647, 7650)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 7608, 7803))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 7608, 7803);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 7684, 7788) || true) && (f_10700_7688_7718(identity, assemblies[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 7684, 7788);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 7760, 7769);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 7684, 7788);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10700, 1, 196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10700, 1, 196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 7817, 7827);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 7229, 7838);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_10700_7550_7593(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 7550, 7593);
                    return return_v;
                }


                bool
                f_10700_7688_7718(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 7688, 7718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 7229, 7838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 7229, 7838);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Perform a check whether the type or at least one of its generic arguments 
        /// is defined in the specified assemblies. The check is performed recursively. 
        /// </summary>
        public static bool IsOrClosedOverATypeFromAssemblies(TypeSymbol symbol, ImmutableArray<AssemblySymbol> assemblies)
        {
            switch (symbol.Kind)
            {
                case SymbolKind.TypeParameter:
                    return false;

                case SymbolKind.ArrayType:
                    return IsOrClosedOverATypeFromAssemblies(((ArrayTypeSymbol)symbol).ElementType, assemblies);

                case SymbolKind.PointerType:
                    return IsOrClosedOverATypeFromAssemblies(((PointerTypeSymbol)symbol).PointedAtType, assemblies);

                case SymbolKind.DynamicType:
                    return false;

                case SymbolKind.ErrorType:
                    goto case SymbolKind.NamedType;
                case SymbolKind.NamedType:
                    var namedType = (NamedTypeSymbol)symbol;
                    AssemblySymbol containingAssembly = symbol.OriginalDefinition.ContainingAssembly;
                    int i;

                    if ((object)containingAssembly != null)
                    {
                        for (i = 0; i < assemblies.Length; i++)
                        {
                            if (ReferenceEquals(containingAssembly, assemblies[i]))
                            {
                                return true;
                            }
                        }
                    }

                    do
                    {
                        var arguments = namedType.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                        int count = arguments.Length;

                        for (i = 0; i < count; i++)
                        {
                            if (IsOrClosedOverATypeFromAssemblies(arguments[i].Type, assemblies))
                            {
                                return true;
                            }
                        }

                        namedType = namedType.ContainingType;
                    }
                    while ((object)namedType != null);

                    return false;

                default:
                    throw ExceptionUtilities.UnexpectedValue(symbol.Kind);
            }
        }

        protected override TypeSymbol SubstituteNoPiaLocalType(
                    TypeDefinitionHandle typeDef,
                    ref MetadataTypeName name,
                    string interfaceGuid,
                    string scope,
                    string identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 10342, 11969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 10599, 10617);

                TypeSymbol
                result
                = default(TypeSymbol);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 10669, 10723);

                    bool
                    isInterface = f_10700_10688_10722(Module, typeDef)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 10741, 10768);

                    TypeSymbol
                    baseType = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 10788, 11085) || true) && (!isInterface)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 10788, 11085);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 10846, 10912);

                        EntityHandle
                        baseToken = f_10700_10871_10911(Module, typeDef)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 10936, 11066) || true) && (f_10700_10940_10956_M(!baseToken.IsNil))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 10936, 11066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 11006, 11043);

                            baseType = f_10700_11017_11042(this, baseToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 10936, 11066);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 10788, 11085);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 11105, 11387);

                    result = f_10700_11114_11386(ref name, isInterface, baseType, interfaceGuid, scope, identifier, f_10700_11354_11385(moduleSymbol));
                }
                catch (BadImageFormatException mrEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10700, 11416, 11548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 11485, 11533);

                    result = f_10700_11494_11532(this, mrEx);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10700, 11416, 11548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 11564, 11601);

                f_10700_11564_11600((object)result != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 11617, 11705);

                ConcurrentDictionary<TypeDefinitionHandle, TypeSymbol>
                cache = f_10700_11680_11704(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 11719, 11747);

                f_10700_11719_11746(cache != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 11763, 11818);

                TypeSymbol
                newresult = f_10700_11786_11817(cache, typeDef, result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 11832, 11925);

                f_10700_11832_11924(f_10700_11845_11879(newresult, result) || (DynAbs.Tracing.TraceSender.Expression_False(10700, 11845, 11923) || (f_10700_11884_11898(newresult) == SymbolKind.ErrorType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 11941, 11958);

                return newresult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 10342, 11969);

                bool
                f_10700_10688_10722(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.IsInterfaceOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 10688, 10722);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_10700_10871_10911(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetBaseTypeOfTypeOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 10871, 10911);
                    return return_v;
                }


                bool
                f_10700_10940_10956_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 10940, 10956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10700_11017_11042(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.EntityHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 11017, 11042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10700_11354_11385(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 11354, 11385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10700_11114_11386(ref Microsoft.CodeAnalysis.MetadataTypeName
                name, bool
                isInterface, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                baseType, string
                interfaceGuid, string
                scope, string
                identifier, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                referringAssembly)
                {
                    var return_v = SubstituteNoPiaLocalType(ref name, isInterface, baseType, interfaceGuid, scope, identifier, referringAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 11114, 11386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10700_11494_11532(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.BadImageFormatException
                exception)
                {
                    var return_v = this_param.GetUnsupportedMetadataTypeSymbol(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 11494, 11532);
                    return return_v;
                }


                int
                f_10700_11564_11600(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 11564, 11600);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10700_11680_11704(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param)
                {
                    var return_v = this_param.GetTypeHandleToTypeMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 11680, 11704);
                    return return_v;
                }


                int
                f_10700_11719_11746(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 11719, 11746);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10700_11786_11817(System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                key, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 11786, 11817);
                    return return_v;
                }


                bool
                f_10700_11845_11879(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 11845, 11879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10700_11884_11898(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 11884, 11898);
                    return return_v;
                }


                int
                f_10700_11832_11924(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 11832, 11924);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 10342, 11969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 10342, 11969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NamedTypeSymbol SubstituteNoPiaLocalType(
                    ref MetadataTypeName name,
                    bool isInterface,
                    TypeSymbol baseType,
                    string interfaceGuid,
                    string scope,
                    string identifier,
                    AssemblySymbol referringAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10700, 12219, 18434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 12547, 12577);

                NamedTypeSymbol
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 12593, 12630);

                Guid
                interfaceGuidValue = f_10700_12619_12629()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 12644, 12680);

                bool
                haveInterfaceGuidValue = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 12694, 12727);

                Guid
                scopeGuidValue = f_10700_12716_12726()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 12741, 12773);

                bool
                haveScopeGuidValue = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 12789, 13167) || true) && (isInterface && (DynAbs.Tracing.TraceSender.Expression_True(10700, 12793, 12829) && interfaceGuid != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 12789, 13167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 12863, 12941);

                    haveInterfaceGuidValue = Guid.TryParse(interfaceGuid, out interfaceGuidValue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 12961, 13152) || true) && (haveInterfaceGuidValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 12961, 13152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13080, 13093);

                        scope = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13115, 13133);

                        identifier = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 12961, 13152);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 12789, 13167);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13183, 13311) || true) && (scope != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 13183, 13311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13234, 13296);

                    haveScopeGuidValue = Guid.TryParse(scope, out scopeGuidValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 13183, 13311);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13327, 18023);
                    foreach (AssemblySymbol assembly in f_10700_13363_13411_I(f_10700_13363_13411(referringAssembly)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 13327, 18023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13445, 13484);

                        f_10700_13445_13483((object)assembly != null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13502, 13620) || true) && (f_10700_13506_13550(assembly, referringAssembly))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 13502, 13620);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13592, 13601);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 13502, 13620);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13640, 13747);

                        NamedTypeSymbol
                        candidate = f_10700_13668_13746(assembly, ref name, digThroughForwardedTypes: false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13765, 13804);

                        f_10700_13765_13803(f_10700_13778_13802_M(!candidate.IsGenericType));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 13903, 14176) || true) && (f_10700_13907_13921(candidate) == SymbolKind.ErrorType || (DynAbs.Tracing.TraceSender.Expression_False(10700, 13907, 14026) || !f_10700_13971_14026(f_10700_13987_14015(candidate), assembly)) || (DynAbs.Tracing.TraceSender.Expression_False(10700, 13907, 14106) || f_10700_14051_14082(candidate) != Accessibility.Public))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 13903, 14176);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 14148, 14157);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 13903, 14176);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 14658, 14788);

                        f_10700_14658_14787(!(assembly is SourceAssemblySymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10700, 14671, 14786) || !f_10700_14711_14786(f_10700_14711_14756(((SourceAssemblySymbol)assembly)))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 14808, 14829);

                        string
                        candidateGuid
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 14847, 14883);

                        bool
                        haveCandidateGuidValue = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 14901, 14938);

                        Guid
                        candidateGuidValue = f_10700_14927_14937()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 15051, 16512);

                        switch (f_10700_15059_15077(candidate))
                        {

                            case TypeKind.Interface:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 15051, 16512);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 15169, 15279) || true) && (!isInterface)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 15169, 15279);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 15243, 15252);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 15169, 15279);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 15356, 15590) || true) && (f_10700_15360_15402(candidate, out candidateGuid) && (DynAbs.Tracing.TraceSender.Expression_True(10700, 15360, 15427) && candidateGuid != null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 15356, 15590);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 15485, 15563);

                                    haveCandidateGuidValue = Guid.TryParse(candidateGuid, out candidateGuidValue);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 15356, 15590);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10700, 15618, 15624);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 15051, 16512);

                            case TypeKind.Delegate:
                            case TypeKind.Enum:
                            case TypeKind.Struct:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 15051, 16512);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 15783, 15892) || true) && (isInterface)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 15783, 15892);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 15856, 15865);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 15783, 15892);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 16063, 16167);

                                SpecialType
                                baseSpecialType = (f_10700_16094_16145_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10700_16094_16132(candidate), 10700, 16094, 16145)?.SpecialType) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SpecialType?>(10700, 16094, 16165) ?? SpecialType.None))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 16193, 16392) || true) && (baseSpecialType == SpecialType.None || (DynAbs.Tracing.TraceSender.Expression_False(10700, 16197, 16298) || baseSpecialType != (f_10700_16256_16277_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(baseType, 10700, 16256, 16277)?.SpecialType) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SpecialType?>(10700, 16256, 16297) ?? SpecialType.None))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 16193, 16392);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 16356, 16365);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 16193, 16392);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10700, 16420, 16426);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 15051, 16512);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 15051, 16512);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 16484, 16493);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 15051, 16512);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 16532, 17640) || true) && (haveInterfaceGuidValue || (DynAbs.Tracing.TraceSender.Expression_False(10700, 16536, 16584) || haveCandidateGuidValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 16532, 17640);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 16626, 16831) || true) && (!haveInterfaceGuidValue || (DynAbs.Tracing.TraceSender.Expression_False(10700, 16630, 16680) || !haveCandidateGuidValue) || (DynAbs.Tracing.TraceSender.Expression_False(10700, 16630, 16749) || candidateGuidValue != interfaceGuidValue))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 16626, 16831);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 16799, 16808);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 16626, 16831);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 16532, 17640);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 16532, 17640);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 16913, 17077) || true) && (!haveScopeGuidValue || (DynAbs.Tracing.TraceSender.Expression_False(10700, 16917, 16958) || identifier == null) || (DynAbs.Tracing.TraceSender.Expression_False(10700, 16917, 16995) || !f_10700_16963_16995(identifier, name.FullName)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 16913, 17077);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 17045, 17054);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 16913, 17077);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 17174, 17205);

                            haveCandidateGuidValue = false;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 17227, 17448) || true) && (f_10700_17231_17272(assembly, out candidateGuid) && (DynAbs.Tracing.TraceSender.Expression_True(10700, 17231, 17297) && candidateGuid != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 17227, 17448);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 17347, 17425);

                                haveCandidateGuidValue = Guid.TryParse(candidateGuid, out candidateGuidValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 17227, 17448);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 17472, 17621) || true) && (!haveCandidateGuidValue || (DynAbs.Tracing.TraceSender.Expression_False(10700, 17476, 17539) || scopeGuidValue != candidateGuidValue))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 17472, 17621);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 17589, 17598);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 17472, 17621);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 16532, 17640);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 17734, 17969) || true) && ((object)result != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 17734, 17969);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 17837, 17922);

                            result = f_10700_17846_17921(referringAssembly, result, candidate);
                            DynAbs.Tracing.TraceSender.TraceBreak(10700, 17944, 17950);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 17734, 17969);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 17989, 18008);

                        result = candidate;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 13327, 18023);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10700, 1, 4697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10700, 1, 4697);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 18039, 18393) || true) && ((object)result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 18039, 18393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 18099, 18378);

                    result = f_10700_18108_18377(referringAssembly, name.FullName, interfaceGuid, scope, identifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 18039, 18393);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 18409, 18423);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10700, 12219, 18434);

                System.Guid
                f_10700_12619_12629()
                {
                    var return_v = new System.Guid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 12619, 12629);
                    return return_v;
                }


                System.Guid
                f_10700_12716_12726()
                {
                    var return_v = new System.Guid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 12716, 12726);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10700_13363_13411(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetNoPiaResolutionAssemblies();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 13363, 13411);
                    return return_v;
                }


                int
                f_10700_13445_13483(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 13445, 13483);
                    return 0;
                }


                bool
                f_10700_13506_13550(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 13506, 13550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10700_13668_13746(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, bool
                digThroughForwardedTypes)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName, digThroughForwardedTypes: digThroughForwardedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 13668, 13746);
                    return return_v;
                }


                bool
                f_10700_13778_13802_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 13778, 13802);
                    return return_v;
                }


                int
                f_10700_13765_13803(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 13765, 13803);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10700_13907_13921(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 13907, 13921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10700_13987_14015(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 13987, 14015);
                    return return_v;
                }


                bool
                f_10700_13971_14026(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 13971, 14026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10700_14051_14082(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 14051, 14082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                f_10700_14711_14756(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 14711, 14756);
                    return return_v;
                }


                bool
                f_10700_14711_14786(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.MightContainNoPiaLocalTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 14711, 14786);
                    return return_v;
                }


                int
                f_10700_14658_14787(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 14658, 14787);
                    return 0;
                }


                System.Guid
                f_10700_14927_14937()
                {
                    var return_v = new System.Guid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 14927, 14937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10700_15059_15077(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 15059, 15077);
                    return return_v;
                }


                bool
                f_10700_15360_15402(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, out string
                guidString)
                {
                    var return_v = this_param.GetGuidString(out guidString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 15360, 15402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10700_16094_16132(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 16094, 16132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType?
                f_10700_16094_16145_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 16094, 16145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType?
                f_10700_16256_16277_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 16256, 16277);
                    return return_v;
                }


                bool
                f_10700_16963_16995(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 16963, 16995);
                    return return_v;
                }


                bool
                f_10700_17231_17272(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, out string
                guidString)
                {
                    var return_v = this_param.GetGuidString(out guidString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 17231, 17272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaAmbiguousCanonicalTypeSymbol
                f_10700_17846_17921(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                embeddingAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                firstCandidate, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                secondCandidate)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaAmbiguousCanonicalTypeSymbol(embeddingAssembly, firstCandidate, secondCandidate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 17846, 17921);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10700_13363_13411_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 13363, 13411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaMissingCanonicalTypeSymbol
                f_10700_18108_18377(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                embeddingAssembly, string
                fullTypeName, string?
                guid, string?
                scope, string?
                identifier)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaMissingCanonicalTypeSymbol(embeddingAssembly, fullTypeName, guid, scope, identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 18108, 18377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 12219, 18434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 12219, 18434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override MethodSymbol FindMethodSymbolInType(TypeSymbol typeSymbol, MethodDefinitionHandle targetMethodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 18446, 19033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 18588, 18667);

                f_10700_18588_18666(typeSymbol is PENamedTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10700, 18601, 18665) || typeSymbol is ErrorTypeSymbol));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 18683, 18994);
                    foreach (Symbol member in f_10700_18709_18741_I(f_10700_18709_18741(typeSymbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 18683, 18994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 18775, 18824);

                        PEMethodSymbol
                        method = member as PEMethodSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 18842, 18979) || true) && ((object)method != null && (DynAbs.Tracing.TraceSender.Expression_True(10700, 18846, 18904) && f_10700_18872_18885(method) == targetMethodDef))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 18842, 18979);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 18946, 18960);

                            return method;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 18842, 18979);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 18683, 18994);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10700, 1, 312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10700, 1, 312);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19010, 19022);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 18446, 19033);

                int
                f_10700_18588_18666(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 18588, 18666);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10700_18709_18741(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 18709, 18741);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_10700_18872_18885(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 18872, 18885);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10700_18709_18741_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 18709, 18741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 18446, 19033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 18446, 19033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override FieldSymbol FindFieldSymbolInType(TypeSymbol typeSymbol, FieldDefinitionHandle fieldDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 19045, 19609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19177, 19256);

                f_10700_19177_19255(typeSymbol is PENamedTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10700, 19190, 19254) || typeSymbol is ErrorTypeSymbol));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19272, 19570);
                    foreach (Symbol member in f_10700_19298_19330_I(f_10700_19298_19330(typeSymbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 19272, 19570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19364, 19410);

                        PEFieldSymbol
                        field = member as PEFieldSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19428, 19555) || true) && ((object)field != null && (DynAbs.Tracing.TraceSender.Expression_True(10700, 19432, 19481) && f_10700_19457_19469(field) == fieldDef))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 19428, 19555);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19523, 19536);

                            return field;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 19428, 19555);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 19272, 19570);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10700, 1, 299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10700, 1, 299);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19586, 19598);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 19045, 19609);

                int
                f_10700_19177_19255(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 19177, 19255);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10700_19298_19330(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 19298, 19330);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandle
                f_10700_19457_19469(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 19457, 19469);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10700_19298_19330_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 19298, 19330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 19045, 19609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 19045, 19609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Symbol GetSymbolForMemberRef(MemberReferenceHandle memberRef, TypeSymbol scope = null, bool methodsOnly = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 19621, 21535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19776, 19840);

                TypeSymbol
                targetTypeSymbol = f_10700_19806_19839(this, memberRef)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19856, 19945) || true) && (targetTypeSymbol is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 19856, 19945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19918, 19930);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 19856, 19945);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 19961, 20005);

                f_10700_19961_20004(f_10700_19974_20003_M(!targetTypeSymbol.IsTupleType));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 20021, 20903) || true) && ((object)scope != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 20021, 20903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 20080, 20167);

                    f_10700_20080_20166(f_10700_20093_20103(scope) == SymbolKind.NamedType || (DynAbs.Tracing.TraceSender.Expression_False(10700, 20093, 20165) || f_10700_20131_20141(scope) == SymbolKind.ErrorType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 20292, 20342);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 20360, 20888) || true) && (!f_10700_20365_20444(scope, targetTypeSymbol, TypeCompareKind.ConsiderEverything2) && (DynAbs.Tracing.TraceSender.Expression_True(10700, 20364, 20815) && !((DynAbs.Tracing.TraceSender.Conditional_F1(10700, 20471, 20505) || ((f_10700_20471_20505(targetTypeSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10700, 20533, 20661)) || DynAbs.Tracing.TraceSender.Conditional_F3(10700, 20689, 20814))) ? scope.AllInterfacesNoUseSiteDiagnostics.IndexOf((NamedTypeSymbol)targetTypeSymbol, 0, SymbolEqualityComparer.CLRSignature) != -1
                    : f_10700_20689_20814(scope, targetTypeSymbol, TypeCompareKind.CLRSignatureCompareOptions, useSiteDiagnostics: ref useSiteDiagnostics))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 20360, 20888);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 20857, 20869);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 20360, 20888);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 20021, 20903);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 20919, 21107) || true) && (f_10700_20923_20952_M(!targetTypeSymbol.IsTupleType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 20919, 21107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 20986, 21092);

                    targetTypeSymbol = TupleTypeDecoder.DecodeTupleTypesIfApplicable(targetTypeSymbol, elementNames: default);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 20919, 21107);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 21347, 21431);

                var
                memberRefDecoder = f_10700_21370_21430(moduleSymbol, targetTypeSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 21447, 21524);

                return f_10700_21454_21523(memberRefDecoder, targetTypeSymbol, memberRef, methodsOnly);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 19621, 21535);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10700_19806_19839(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.MemberReferenceHandle
                memberRef)
                {
                    var return_v = this_param.GetMemberRefTypeSymbol(memberRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 19806, 19839);
                    return return_v;
                }


                bool
                f_10700_19974_20003_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 19974, 20003);
                    return return_v;
                }


                int
                f_10700_19961_20004(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 19961, 20004);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10700_20093_20103(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 20093, 20103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10700_20131_20141(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 20131, 20141);
                    return return_v;
                }


                int
                f_10700_20080_20166(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 20080, 20166);
                    return 0;
                }


                bool
                f_10700_20365_20444(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 20365, 20444);
                    return return_v;
                }


                bool
                f_10700_20471_20505(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 20471, 20505);
                    return return_v;
                }


                bool
                f_10700_20689_20814(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.TypeCompareKind
                comparison, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsDerivedFrom(type, comparison, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 20689, 20814);
                    return return_v;
                }


                bool
                f_10700_20923_20952_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 20923, 20952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MemberRefMetadataDecoder
                f_10700_21370_21430(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                containingType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MemberRefMetadataDecoder(moduleSymbol, containingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 21370, 21430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10700_21454_21523(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MemberRefMetadataDecoder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetTypeSymbol, System.Reflection.Metadata.MemberReferenceHandle
                memberRef, bool
                methodsOnly)
                {
                    var return_v = this_param.FindMember(targetTypeSymbol, memberRef, methodsOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 21454, 21523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 19621, 21535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 19621, 21535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void EnqueueTypeSymbolInterfacesAndBaseTypes(Queue<TypeDefinitionHandle> typeDefsToSearch, Queue<TypeSymbol> typeSymbolsToSearch, TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 21547, 22068);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 21743, 21943);
                    foreach (NamedTypeSymbol @interface in f_10700_21782_21825_I(f_10700_21782_21825(typeSymbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 21743, 21943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 21859, 21928);

                        f_10700_21859_21927(this, typeDefsToSearch, typeSymbolsToSearch, @interface);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 21743, 21943);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10700, 1, 201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10700, 1, 201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 21959, 22057);

                f_10700_21959_22056(this, typeDefsToSearch, typeSymbolsToSearch, f_10700_22016_22055(typeSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 21547, 22068);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10700_21782_21825(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 21782, 21825);
                    return return_v;
                }


                int
                f_10700_21859_21927(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                typeDefsToSearch, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeSymbolsToSearch, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    this_param.EnqueueTypeSymbol(typeDefsToSearch, typeSymbolsToSearch, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 21859, 21927);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10700_21782_21825_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 21782, 21825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10700_22016_22055(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 22016, 22055);
                    return return_v;
                }


                int
                f_10700_21959_22056(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                typeDefsToSearch, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeSymbolsToSearch, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    this_param.EnqueueTypeSymbol(typeDefsToSearch, typeSymbolsToSearch, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 21959, 22056);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 21547, 22068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 21547, 22068);
            }
        }

        protected override void EnqueueTypeSymbol(Queue<TypeDefinitionHandle> typeDefsToSearch, Queue<TypeSymbol> typeSymbolsToSearch, TypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 22080, 22754);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 22254, 22743) || true) && ((object)typeSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 22254, 22743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 22318, 22383);

                    PENamedTypeSymbol
                    peTypeSymbol = typeSymbol as PENamedTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 22401, 22728) || true) && ((object)peTypeSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10700, 22405, 22499) && f_10700_22437_22499(f_10700_22453_22484(peTypeSymbol), moduleSymbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 22401, 22728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 22541, 22587);

                        f_10700_22541_22586(typeDefsToSearch, f_10700_22566_22585(peTypeSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 22401, 22728);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 22401, 22728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 22669, 22709);

                        f_10700_22669_22708(typeSymbolsToSearch, typeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 22401, 22728);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 22254, 22743);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 22080, 22754);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10700_22453_22484(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 22453, 22484);
                    return return_v;
                }


                bool
                f_10700_22437_22499(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 22437, 22499);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandle
                f_10700_22566_22585(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 22566, 22585);
                    return return_v;
                }


                int
                f_10700_22541_22586(System.Collections.Generic.Queue<System.Reflection.Metadata.TypeDefinitionHandle>
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 22541, 22586);
                    return 0;
                }


                int
                f_10700_22669_22708(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 22669, 22708);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 22080, 22754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 22080, 22754);
            }
        }

        protected override MethodDefinitionHandle GetMethodHandle(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10700, 22766, 23160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 22869, 22920);

                PEMethodSymbol
                peMethod = method as PEMethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 22934, 23094) || true) && ((object)peMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10700, 22938, 23022) && f_10700_22966_23022(f_10700_22982_23007(peMethod), moduleSymbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10700, 22934, 23094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 23056, 23079);

                    return f_10700_23063_23078(peMethod);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10700, 22934, 23094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10700, 23110, 23149);

                return default(MethodDefinitionHandle);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10700, 22766, 23160);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10700_22982_23007(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 22982, 23007);
                    return return_v;
                }


                bool
                f_10700_22966_23022(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 22966, 23022);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_10700_23063_23078(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 23063, 23078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10700, 22766, 23160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 22766, 23160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MetadataDecoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10700, 615, 23167);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10700, 615, 23167);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10700, 615, 23167);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10700, 615, 23167);

        static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10700_1225_1237_C(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10700, 1099, 1275);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10700_1443_1465(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 1443, 1465);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10700_1410_1422_C(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10700, 1287, 1497);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10700_1595_1607_C(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10700, 1509, 1642);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PEModule
        f_10700_2004_2023(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 2004, 2023);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10700_2026_2057(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 2026, 2057);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10700_2081_2112(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 2081, 2112);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AssemblyIdentity
        f_10700_2081_2121(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.Identity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10700, 2081, 2121);
            return return_v;
        }


        int
        f_10700_2192_2234(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10700, 2192, 2234);
            return 0;
        }


        static Microsoft.CodeAnalysis.PEModule
        f_10700_2004_2023_C(Microsoft.CodeAnalysis.PEModule
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10700, 1654, 2346);
            return return_v;
        }

    }
}
