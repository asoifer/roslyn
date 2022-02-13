// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Cci = Microsoft.Cci;


namespace Microsoft.CodeAnalysis.CSharp.Emit.NoPia
{
    internal sealed class EmbeddedMethod : EmbeddedTypesManager.CommonEmbeddedMethod
    {
        public EmbeddedMethod(EmbeddedType containingType, MethodSymbolAdapter underlyingMethod) : base(f_10945_796_810_C(containingType), underlyingMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10945, 687, 851);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10945, 687, 851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 687, 851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 687, 851);
            }
        }

        internal override EmbeddedTypesManager TypeManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 938, 1023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 974, 1008);

                    return ContainingType.TypeManager;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 938, 1023);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 863, 1034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 863, 1034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 1046, 1269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 1179, 1258);

                return f_10945_1186_1257(f_10945_1186_1216(f_10945_1186_1202()), moduleBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 1046, 1269);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10945_1186_1202()
                {
                    var return_v = UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 1186, 1202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10945_1186_1216(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 1186, 1216);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10945_1186_1257(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10945, 1186, 1257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 1046, 1269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 1046, 1269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<EmbeddedParameter> GetParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 1281, 1484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 1374, 1473);

                return f_10945_1381_1472(this, f_10945_1424_1471(f_10945_1424_1460(f_10945_1424_1440())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 1281, 1484);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10945_1424_1440()
                {
                    var return_v = UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 1424, 1440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10945_1424_1460(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 1424, 1460);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10945_1424_1471(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 1424, 1471);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedParameter>
                f_10945_1381_1472(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod
                containingPropertyOrMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                underlyingParameters)
                {
                    var return_v = EmbeddedTypesManager.EmbedParameters((Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder, Microsoft.CodeAnalysis.CSharp.ModuleCompilationState, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager, Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData, Microsoft.CodeAnalysis.CSharp.SymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedField, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedMethod, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedEvent, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedProperty, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedParameter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypeParameter>.CommonEmbeddedMember)containingPropertyOrMethod, underlyingParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10945, 1381, 1472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 1281, 1484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 1281, 1484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<EmbeddedTypeParameter> GetTypeParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 1496, 1746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 1597, 1735);

                return f_10945_1604_1640(f_10945_1604_1620()).TypeParameters.SelectAsArray((t, m) => new EmbeddedTypeParameter(m, t.GetCciAdapter()), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 1496, 1746);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10945_1604_1620()
                {
                    var return_v = UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 1604, 1620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10945_1604_1640(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 1604, 1640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 1496, 1746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 1496, 1746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 1817, 1923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 1853, 1908);

                    return f_10945_1860_1907(f_10945_1860_1896(f_10945_1860_1876()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 1817, 1923);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_1860_1876()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 1860, 1876);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_1860_1896(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 1860, 1896);
                        return return_v;
                    }


                    bool
                    f_10945_1860_1907(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 1860, 1907);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 1758, 1934);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 1758, 1934);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsAccessCheckedOnOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 2020, 2141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 2056, 2126);

                    return f_10945_2063_2125(f_10945_2063_2099(f_10945_2063_2079()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 2020, 2141);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_2063_2079()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2063, 2079);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_2063_2099(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2063, 2099);
                        return return_v;
                    }


                    bool
                    f_10945_2063_2125(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAccessCheckedOnOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2063, 2125);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 1946, 2152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 1946, 2152);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 2226, 2358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 2262, 2343);

                    return f_10945_2269_2316(f_10945_2269_2305(f_10945_2269_2285())) == MethodKind.Constructor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 2226, 2358);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_2269_2285()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2269, 2285);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_2269_2305(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2269, 2305);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10945_2269_2316(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2269, 2316);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 2164, 2369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 2164, 2369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsExternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 2440, 2546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 2476, 2531);

                    return f_10945_2483_2530(f_10945_2483_2519(f_10945_2483_2499()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 2440, 2546);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_2483_2499()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2483, 2499);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_2483_2519(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2483, 2519);
                        return return_v;
                    }


                    bool
                    f_10945_2483_2530(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExternal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2483, 2530);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 2381, 2557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 2381, 2557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsHiddenBySignature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 2637, 2756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 2673, 2741);

                    return f_10945_2680_2740_M(!f_10945_2681_2717(f_10945_2681_2697()).HidesBaseMethodsByName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 2637, 2756);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_2681_2697()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2681, 2697);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_2681_2717(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2681, 2717);
                        return return_v;
                    }


                    bool
                    f_10945_2680_2740_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2680, 2740);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 2569, 2767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 2569, 2767);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsNewSlot
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 2837, 2952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 2873, 2937);

                    return f_10945_2880_2936(f_10945_2880_2916(f_10945_2880_2896()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 2837, 2952);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_2880_2896()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2880, 2896);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_2880_2916(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 2880, 2916);
                        return return_v;
                    }


                    bool
                    f_10945_2880_2936(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataNewSlot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10945, 2880, 2936);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 2779, 2963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 2779, 2963);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.IPlatformInvokeInformation PlatformInvokeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 3068, 3182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 3104, 3167);

                    return f_10945_3111_3166(f_10945_3111_3147(f_10945_3111_3127()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 3068, 3182);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_3111_3127()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3111, 3127);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_3111_3147(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3111, 3147);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DllImportData?
                    f_10945_3111_3166(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetDllImportData();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10945, 3111, 3166);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 2975, 3193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 2975, 3193);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 3270, 3387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 3306, 3372);

                    return f_10945_3313_3371(f_10945_3313_3349(f_10945_3313_3329()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 3270, 3387);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_3313_3329()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3313, 3329);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_3313_3349(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3313, 3349);
                        return return_v;
                    }


                    bool
                    f_10945_3313_3371(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasRuntimeSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3313, 3371);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 3205, 3398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 3205, 3398);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 3472, 3582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 3508, 3567);

                    return f_10945_3515_3566(f_10945_3515_3551(f_10945_3515_3531()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 3472, 3582);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_3515_3531()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3515, 3531);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_3515_3551(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3515, 3551);
                        return return_v;
                    }


                    bool
                    f_10945_3515_3566(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3515, 3566);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 3410, 3593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 3410, 3593);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 3662, 3773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 3698, 3758);

                    return f_10945_3705_3757(f_10945_3705_3741(f_10945_3705_3721()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 3662, 3773);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_3705_3721()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3705, 3721);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_3705_3741(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3705, 3741);
                        return return_v;
                    }


                    bool
                    f_10945_3705_3757(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataFinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3705, 3757);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 3605, 3784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 3605, 3784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 3853, 3957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 3889, 3942);

                    return f_10945_3896_3941(f_10945_3896_3932(f_10945_3896_3912()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 3853, 3957);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_3896_3912()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3896, 3912);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_3896_3932(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3896, 3932);
                        return return_v;
                    }


                    bool
                    f_10945_3896_3941(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 3896, 3941);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 3796, 3968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 3796, 3968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 4038, 4153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 4074, 4138);

                    return f_10945_4081_4137(f_10945_4081_4117(f_10945_4081_4097()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 4038, 4153);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_4081_4097()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4081, 4097);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_4081_4117(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4081, 4117);
                        return return_v;
                    }


                    bool
                    f_10945_4081_4137(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataVirtual();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10945, 4081, 4137);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 3980, 4164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 3980, 4164);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override System.Reflection.MethodImplAttributes GetImplementationAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 4176, 4387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 4307, 4376);

                return f_10945_4314_4375(f_10945_4314_4350(f_10945_4314_4330()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 4176, 4387);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10945_4314_4330()
                {
                    var return_v = UnderlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4314, 4330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10945_4314_4350(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedMethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4314, 4350);
                    return return_v;
                }


                System.Reflection.MethodImplAttributes
                f_10945_4314_4375(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ImplementationAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4314, 4375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 4176, 4387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 4176, 4387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool ReturnValueIsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 4481, 4610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 4517, 4595);

                    return f_10945_4524_4594(f_10945_4524_4560(f_10945_4524_4540()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 4481, 4610);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_4524_4540()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4524, 4540);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_4524_4560(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4524, 4560);
                        return return_v;
                    }


                    bool
                    f_10945_4524_4594(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueIsMarshalledExplicitly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4524, 4594);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 4399, 4621);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 4399, 4621);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.IMarshallingInformation ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 4738, 4867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 4774, 4852);

                    return f_10945_4781_4851(f_10945_4781_4817(f_10945_4781_4797()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 4738, 4867);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_4781_4797()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4781, 4797);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_4781_4817(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4781, 4817);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10945_4781_4851(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 4781, 4851);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 4633, 4878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 4633, 4878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<byte> ReturnValueMarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 4987, 5115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 5023, 5100);

                    return f_10945_5030_5099(f_10945_5030_5066(f_10945_5030_5046()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 4987, 5115);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_5030_5046()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5030, 5046);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_5030_5066(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5030, 5066);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10945_5030_5099(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5030, 5099);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 4890, 5126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 4890, 5126);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.TypeMemberVisibility Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 5217, 5346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 5253, 5331);

                    return f_10945_5260_5330(f_10945_5293_5329(f_10945_5293_5309()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 5217, 5346);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_5293_5309()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5293, 5309);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_5293_5329(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5293, 5329);
                        return return_v;
                    }


                    Microsoft.Cci.TypeMemberVisibility
                    f_10945_5260_5330(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = PEModuleBuilder.MemberVisibility((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10945, 5260, 5330);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 5138, 5357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 5138, 5357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 5424, 5489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 5430, 5487);

                    return f_10945_5437_5486(f_10945_5437_5473(f_10945_5437_5453()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 5424, 5489);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_5437_5453()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5437, 5453);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_5437_5473(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5437, 5473);
                        return return_v;
                    }


                    string
                    f_10945_5437_5486(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5437, 5486);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 5369, 5500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 5369, 5500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool AcceptsExtraArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 5582, 5686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 5618, 5671);

                    return f_10945_5625_5670(f_10945_5625_5661(f_10945_5625_5641()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 5582, 5686);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_5625_5641()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5625, 5641);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_5625_5661(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5625, 5661);
                        return return_v;
                    }


                    bool
                    f_10945_5625_5670(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5625, 5670);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 5512, 5697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 5512, 5697);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.ISignature UnderlyingMethodSignature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 5793, 5884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 5829, 5869);

                    return (Cci.ISignature)f_10945_5852_5868();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 5793, 5884);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_5852_5868()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 5852, 5868);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 5709, 5895);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 5709, 5895);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Cci.INamespace ContainingNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10945, 5985, 6116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10945, 6021, 6101);

                    return f_10945_6028_6100(f_10945_6028_6084(f_10945_6028_6064(f_10945_6028_6044())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10945, 5985, 6116);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10945_6028_6044()
                    {
                        var return_v = UnderlyingMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 6028, 6044);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10945_6028_6064(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.AdaptedMethodSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 6028, 6064);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10945_6028_6084(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10945, 6028, 6084);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter
                    f_10945_6028_6100(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10945, 6028, 6100);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10945, 5907, 6127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 5907, 6127);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static EmbeddedMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10945, 590, 6134);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10945, 590, 6134);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10945, 590, 6134);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10945, 590, 6134);

        static Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
        f_10945_796_810_C(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10945, 687, 851);
            return return_v;
        }

    }
}
