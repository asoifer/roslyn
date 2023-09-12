// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class
            NamedTypeSymbolAdapter : SymbolAdapter,
            Cci.ITypeReference,
            Cci.ITypeDefinition,
            Cci.INamedTypeReference,
            Cci.INamedTypeDefinition,
            Cci.INamespaceTypeReference,
            Cci.INamespaceTypeDefinition,
            Cci.INestedTypeReference,
            Cci.INestedTypeDefinition,
            Cci.IGenericTypeInstanceReference,
            Cci.ISpecializedNestedTypeReference
    {
        bool Cci.ITypeReference.IsEnum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 1266, 1330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 1272, 1328);

                    return f_10198_1279_1310(f_10198_1279_1301()) == TypeKind.Enum;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 1266, 1330);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_1279_1301()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 1279, 1301);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10198_1279_1310(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 1279, 1310);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 1211, 1341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 1211, 1341);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeReference.IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 1413, 1463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 1419, 1461);

                    return f_10198_1426_1460(f_10198_1426_1448());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 1413, 1463);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_1426_1448()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 1426, 1448);
                        return return_v;
                    }


                    bool
                    f_10198_1426_1460(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsValueType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 1426, 1460);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 1353, 1474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 1353, 1474);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.ITypeReference.GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 1486, 1726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 1586, 1653);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 1669, 1715);

                return f_10198_1676_1714(this, moduleBeingBuilt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 1486, 1726);

                Microsoft.Cci.ITypeDefinition
                f_10198_1676_1714(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuilt)
                {
                    var return_v = this_param.AsTypeDefinitionImpl(moduleBeingBuilt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 1676, 1714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 1486, 1726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 1486, 1726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.PrimitiveTypeCode Cci.ITypeReference.TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 1812, 2137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 1848, 1892);

                    f_10198_1848_1891(f_10198_1861_1890(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 1912, 2060) || true) && (f_10198_1916_1951(f_10198_1916_1938()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 1912, 2060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 1993, 2041);

                        return f_10198_2000_2040(f_10198_2000_2022());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 1912, 2060);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 2080, 2122);

                    return Cci.PrimitiveTypeCode.NotPrimitive;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 1812, 2137);

                    bool
                    f_10198_1861_1890(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.IsDefinitionOrDistinct();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 1861, 1890);
                        return return_v;
                    }


                    int
                    f_10198_1848_1891(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 1848, 1891);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_1916_1938()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 1916, 1938);
                        return return_v;
                    }


                    bool
                    f_10198_1916_1951(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 1916, 1951);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_2000_2022()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 2000, 2022);
                        return return_v;
                    }


                    Microsoft.Cci.PrimitiveTypeCode
                    f_10198_2000_2040(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PrimitiveTypeCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 2000, 2040);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 1738, 2148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 1738, 2148);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        TypeDefinitionHandle Cci.ITypeReference.TypeDef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 2232, 2552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 2268, 2344);

                    PENamedTypeSymbol
                    peNamedType = f_10198_2300_2322() as PENamedTypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 2362, 2480) || true) && ((object)peNamedType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 2362, 2480);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 2435, 2461);

                        return f_10198_2442_2460(peNamedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 2362, 2480);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 2500, 2537);

                    return default(TypeDefinitionHandle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 2232, 2552);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_2300_2322()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 2300, 2322);
                        return return_v;
                    }


                    System.Reflection.Metadata.TypeDefinitionHandle
                    f_10198_2442_2460(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Handle;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 2442, 2460);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 2160, 2563);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 2160, 2563);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericMethodParameterReference Cci.ITypeReference.AsGenericMethodParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 2689, 2709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 2695, 2707);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 2689, 2709);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 2575, 2720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 2575, 2720);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericTypeInstanceReference Cci.ITypeReference.AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 2840, 3157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 2876, 2920);

                    f_10198_2876_2919(f_10198_2889_2918(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 2940, 3110) || true) && (f_10198_2944_2980_M(!f_10198_2945_2967().IsDefinition) && (DynAbs.Tracing.TraceSender.Expression_True(10198, 2944, 3037) && f_10198_3005_3033(f_10198_3005_3027()) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 2940, 3110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 3079, 3091);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 2940, 3110);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 3130, 3142);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 2840, 3157);

                    bool
                    f_10198_2889_2918(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.IsDefinitionOrDistinct();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 2889, 2918);
                        return return_v;
                    }


                    int
                    f_10198_2876_2919(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 2876, 2919);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_2945_2967()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 2945, 2967);
                        return return_v;
                    }


                    bool
                    f_10198_2944_2980_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 2944, 2980);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_3005_3027()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 3005, 3027);
                        return return_v;
                    }


                    int
                    f_10198_3005_3033(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 3005, 3033);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 2732, 3168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 2732, 3168);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericTypeParameterReference Cci.ITypeReference.AsGenericTypeParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 3290, 3310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 3296, 3308);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 3290, 3310);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 3180, 3321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 3180, 3321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INamespaceTypeReference Cci.ITypeReference.AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 3429, 3766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 3465, 3509);

                    f_10198_3465_3508(f_10198_3478_3507(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 3529, 3719) || true) && (f_10198_3533_3568(f_10198_3533_3555()) && (DynAbs.Tracing.TraceSender.Expression_True(10198, 3533, 3646) && (object)f_10198_3601_3638(f_10198_3601_3623()) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 3529, 3719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 3688, 3700);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 3529, 3719);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 3739, 3751);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 3429, 3766);

                    bool
                    f_10198_3478_3507(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.IsDefinitionOrDistinct();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 3478, 3507);
                        return return_v;
                    }


                    int
                    f_10198_3465_3508(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 3465, 3508);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_3533_3555()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 3533, 3555);
                        return return_v;
                    }


                    bool
                    f_10198_3533_3568(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 3533, 3568);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_3601_3623()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 3601, 3623);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_3601_3638(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 3601, 3638);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 3333, 3777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 3333, 3777);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INamespaceTypeDefinition Cci.ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 3789, 4357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 3908, 3975);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 3991, 4035);

                f_10198_3991_4034(f_10198_4004_4033(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 4051, 4318) || true) && ((object)f_10198_4063_4100(f_10198_4063_4085()) == null && (DynAbs.Tracing.TraceSender.Expression_True(10198, 4055, 4164) && f_10198_4129_4164(f_10198_4129_4151())) && (DynAbs.Tracing.TraceSender.Expression_True(10198, 4055, 4257) && f_10198_4185_4224(f_10198_4185_4207()) == moduleBeingBuilt.SourceModule))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 4051, 4318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 4291, 4303);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 4051, 4318);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 4334, 4346);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 3789, 4357);

                bool
                f_10198_4004_4033(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 4004, 4033);
                    return return_v;
                }


                int
                f_10198_3991_4034(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 3991, 4034);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_4063_4085()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 4063, 4085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_4063_4100(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 4063, 4100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_4129_4151()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 4129, 4151);
                    return return_v;
                }


                bool
                f_10198_4129_4164(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 4129, 4164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_4185_4207()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 4185, 4207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10198_4185_4224(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 4185, 4224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 3789, 4357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 3789, 4357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INestedTypeReference Cci.ITypeReference.AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 4461, 4674);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 4497, 4627) || true) && ((object)f_10198_4509_4546(f_10198_4509_4531()) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 4497, 4627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 4596, 4608);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 4497, 4627);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 4647, 4659);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 4461, 4674);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_4509_4531()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 4509, 4531);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_4509_4546(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 4509, 4546);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 4371, 4685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 4371, 4685);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INestedTypeDefinition Cci.ITypeReference.AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 4697, 4956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 4810, 4877);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 4893, 4945);

                return f_10198_4900_4944(this, moduleBeingBuilt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 4697, 4956);

                Microsoft.Cci.INestedTypeDefinition
                f_10198_4900_4944(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuilt)
                {
                    var return_v = this_param.AsNestedTypeDefinitionImpl(moduleBeingBuilt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 4900, 4944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 4697, 4956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 4697, 4956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cci.INestedTypeDefinition AsNestedTypeDefinitionImpl(PEModuleBuilder moduleBeingBuilt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 4968, 5453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 5087, 5131);

                f_10198_5087_5130(f_10198_5100_5129(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 5147, 5414) || true) && ((object)f_10198_5159_5196(f_10198_5159_5181()) != null && (DynAbs.Tracing.TraceSender.Expression_True(10198, 5151, 5260) && f_10198_5225_5260(f_10198_5225_5247())) && (DynAbs.Tracing.TraceSender.Expression_True(10198, 5151, 5353) && f_10198_5281_5320(f_10198_5281_5303()) == moduleBeingBuilt.SourceModule))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 5147, 5414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 5387, 5399);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 5147, 5414);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 5430, 5442);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 4968, 5453);

                bool
                f_10198_5100_5129(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 5100, 5129);
                    return return_v;
                }


                int
                f_10198_5087_5130(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 5087, 5130);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_5159_5181()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5159, 5181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_5159_5196(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5159, 5196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_5225_5247()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5225, 5247);
                    return return_v;
                }


                bool
                f_10198_5225_5260(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5225, 5260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_5281_5303()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5281, 5303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10198_5281_5320(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5281, 5320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 4968, 5453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 4968, 5453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.ISpecializedNestedTypeReference Cci.ITypeReference.AsSpecializedNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 5577, 6160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 5613, 5657);

                    f_10198_5613_5656(f_10198_5626_5655(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 5677, 6113) || true) && (f_10198_5681_5717_M(!f_10198_5682_5704().IsDefinition) && (DynAbs.Tracing.TraceSender.Expression_True(10198, 5681, 5849) && (f_10198_5743_5771(f_10198_5743_5765()) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10198, 5743, 5848) || f_10198_5780_5848(f_10198_5810_5847(f_10198_5810_5832()))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 5677, 6113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 5891, 6060);

                        f_10198_5891_6059((object)f_10198_5912_5949(f_10198_5912_5934()) != null && (DynAbs.Tracing.TraceSender.Expression_True(10198, 5904, 6058) && f_10198_5990_6058(f_10198_6020_6057(f_10198_6020_6042()))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 6082, 6094);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 5677, 6113);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 6133, 6145);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 5577, 6160);

                    bool
                    f_10198_5626_5655(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        var return_v = this_param.IsDefinitionOrDistinct();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 5626, 5655);
                        return return_v;
                    }


                    int
                    f_10198_5613_5656(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 5613, 5656);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_5682_5704()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5682, 5704);
                        return return_v;
                    }


                    bool
                    f_10198_5681_5717_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5681, 5717);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_5743_5765()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5743, 5765);
                        return return_v;
                    }


                    int
                    f_10198_5743_5771(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5743, 5771);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_5810_5832()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5810, 5832);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_5810_5847(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5810, 5847);
                        return return_v;
                    }


                    bool
                    f_10198_5780_5848(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    toCheck)
                    {
                        var return_v = PEModuleBuilder.IsGenericType(toCheck);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 5780, 5848);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_5912_5934()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5912, 5934);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_5912_5949(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 5912, 5949);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_6020_6042()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 6020, 6042);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_6020_6057(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 6020, 6057);
                        return return_v;
                    }


                    bool
                    f_10198_5990_6058(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    toCheck)
                    {
                        var return_v = PEModuleBuilder.IsGenericType(toCheck);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 5990, 6058);
                        return return_v;
                    }


                    int
                    f_10198_5891_6059(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 5891, 6059);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 5465, 6171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 5465, 6171);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.ITypeReference.AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 6183, 6424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 6284, 6351);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 6367, 6413);

                return f_10198_6374_6412(this, moduleBeingBuilt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 6183, 6424);

                Microsoft.Cci.ITypeDefinition
                f_10198_6374_6412(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuilt)
                {
                    var return_v = this_param.AsTypeDefinitionImpl(moduleBeingBuilt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 6374, 6412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 6183, 6424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 6183, 6424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cci.ITypeDefinition AsTypeDefinitionImpl(PEModuleBuilder moduleBeingBuilt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 6436, 6919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 6543, 6587);

                f_10198_6543_6586(f_10198_6556_6585(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 6603, 6880) || true) && (f_10198_6607_6642(f_10198_6607_6629()) && (DynAbs.Tracing.TraceSender.Expression_True(10198, 6607, 6769) && f_10198_6697_6736(f_10198_6697_6719()) == moduleBeingBuilt.SourceModule))
                ) // must be declared in the module we are building

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 6603, 6880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 6853, 6865);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 6603, 6880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 6896, 6908);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 6436, 6919);

                bool
                f_10198_6556_6585(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 6556, 6585);
                    return return_v;
                }


                int
                f_10198_6543_6586(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 6543, 6586);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_6607_6629()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 6607, 6629);
                    return return_v;
                }


                bool
                f_10198_6607_6642(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 6607, 6642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_6697_6719()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 6697, 6719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10198_6697_6736(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 6697, 6736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 6436, 6919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 6436, 6919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 6931, 9241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 7013, 7050);

                throw f_10198_7019_7049();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 6931, 9241);

                System.Exception
                f_10198_7019_7049()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 7019, 7049);
                    return return_v;
                }

                //We've not yet discovered a scenario in which we need this.
                //If you're hitting this exception. Uncomment the code below
                //and add a unit test.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 6931, 9241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 6931, 9241);
            }
        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 9253, 9482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 9342, 9409);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 9425, 9471);

                return f_10198_9432_9470(this, moduleBeingBuilt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 9253, 9482);

                Microsoft.Cci.ITypeDefinition
                f_10198_9432_9470(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuilt)
                {
                    var return_v = this_param.AsTypeDefinitionImpl(moduleBeingBuilt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 9432, 9470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 9253, 9482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 9253, 9482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.ITypeReference Cci.ITypeDefinition.GetBaseClass(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 9494, 10575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 9591, 9658);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 9674, 9749);

                f_10198_9674_9748(f_10198_9687_9739(((Cci.ITypeReference)this), context) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 9763, 9842);

                NamedTypeSymbol
                baseType = f_10198_9790_9841(f_10198_9790_9812())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 9858, 10242) || true) && (f_10198_9862_9898(f_10198_9862_9884()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 9858, 10242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 10052, 10091);

                    f_10198_10052_10090((object)baseType == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 10109, 10227);

                    baseType = f_10198_10120_10226(f_10198_10120_10161(f_10198_10120_10142()), Microsoft.CodeAnalysis.SpecialType.System_Object);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 9858, 10242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 10258, 10564);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10198, 10265, 10291) || ((((object)baseType != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10198, 10294, 10556)) || DynAbs.Tracing.TraceSender.Conditional_F3(10198, 10559, 10563))) ? f_10198_10294_10556(moduleBeingBuilt, baseType, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 9494, 10575);

                Microsoft.Cci.ITypeDefinition?
                f_10198_9687_9739(Microsoft.Cci.ITypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.AsTypeDefinition(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 9687, 9739);
                    return return_v;
                }


                int
                f_10198_9674_9748(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 9674, 9748);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_9790_9812()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 9790, 9812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_9790_9841(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 9790, 9841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_9862_9884()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 9862, 9884);
                    return return_v;
                }


                bool
                f_10198_9862_9898(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 9862, 9898);
                    return return_v;
                }


                int
                f_10198_10052_10090(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 10052, 10090);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_10120_10142()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 10120, 10142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10198_10120_10161(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 10120, 10161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_10120_10226(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 10120, 10226);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10198_10294_10556(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 10294, 10556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 9494, 10575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 9494, 10575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.IEventDefinition> Cci.ITypeDefinition.GetEvents(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 10587, 11194);

                var listYield = new List<IEventDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 10696, 10723);

                f_10198_10696_10722(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 10737, 11183);
                    foreach (EventSymbol e in f_10198_10763_10803_I(f_10198_10763_10803(f_10198_10763_10785())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 10737, 11183);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 10837, 10885);

                        IEventDefinition
                        definition = f_10198_10867_10884(e)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 10999, 11168) || true) && 
                            (definition.ShouldInclude(context) || 
                            (DynAbs.Tracing.TraceSender.Expression_False(10198, 11003, 11083) || 
                            !f_10198_11041_11083(f_10198_11041_11073(definition, context))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 10999, 11168);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 11125, 11149);

                            listYield.Add(definition);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 10999, 11168);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 10737, 11183);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 447);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 10587, 11194);

                return listYield;

                int
                f_10198_10696_10722(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 10696, 10722);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_10763_10785()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 10763, 10785);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10198_10763_10803(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetEventsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 10763, 10803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
                f_10198_10867_10884(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 10867, 10884);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                f_10198_11041_11073(Microsoft.Cci.IEventDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAccessors(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 11041, 11073);
                    return return_v;
                }


                bool
                f_10198_11041_11083(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.Cci.IMethodReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 11041, 11083);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10198_10763_10803_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 10763, 10803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 10587, 11194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 10587, 11194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.MethodImplementation> Cci.ITypeDefinition.GetExplicitImplementationOverrides(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 11206, 16264);

                var listYield = new List<Cci.MethodImplementation>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 11344, 11371);

                f_10198_11344_11370(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 11387, 11454);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 11470, 15152);
                    foreach (var member in f_10198_11493_11528_I(f_10198_11493_11528(f_10198_11493_11515())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 11470, 15152);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 11562, 15137) || true) && (f_10198_11566_11577(member) == SymbolKind.Method)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 11562, 15137);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 11640, 11674);

                            var
                            method = (MethodSymbol)member
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 11696, 11755);

                            f_10198_11696_11754((object)f_10198_11717_11745(method) == null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 11801, 11871);

                            var
                            explicitImplementations = f_10198_11831_11870(method)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 11893, 12411) || true) && (explicitImplementations.Length != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 11893, 12411);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 11982, 12019);

                                var
                                adapter = f_10198_11996_12018(method)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 12047, 12388);
                                    foreach (var implemented in f_10198_12075_12114_I(f_10198_12075_12114(method)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 12047, 12388);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 12172, 12361);

                                        listYield.Add(f_10198_12185_12360(adapter, f_10198_12233_12359(moduleBeingBuilt, implemented, context.SyntaxNodeOpt, context.Diagnostics)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 12047, 12388);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 342);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 342);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 11893, 12411);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 12435, 12555) || true) && (f_10198_12439_12473(f_10198_12439_12461()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 12435, 12555);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 12523, 12532);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 12435, 12555);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 12579, 15118) || true) && (f_10198_12583_12621(method, out _))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 12579, 15118);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 13360, 13576);

                                listYield.Add(f_10198_13373_13575(f_10198_13412_13434(method), f_10198_13436_13574(moduleBeingBuilt, f_10198_13488_13511(method), context.SyntaxNodeOpt, context.Diagnostics)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 12579, 15118);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 12579, 15118);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 13626, 15118) || true) && (f_10198_13630_13647(method) == MethodKind.Destructor && (DynAbs.Tracing.TraceSender.Expression_True(10198, 13630, 13739) && f_10198_13676_13710(f_10198_13676_13698()) != SpecialType.System_Object))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 13626, 15118);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 14298, 14421);

                                    TypeSymbol
                                    objectType = f_10198_14322_14420(f_10198_14322_14365(f_10198_14322_14344()), CodeAnalysis.SpecialType.System_Object)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 14447, 15095);
                                        foreach (Symbol objectMember in f_10198_14479_14537_I(f_10198_14479_14537(objectType, WellKnownMemberNames.DestructorName)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 14447, 15095);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 14595, 14652);

                                            MethodSymbol
                                            objectMethod = objectMember as MethodSymbol
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 14682, 15068) || true) && ((object)objectMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10198, 14686, 14766) && f_10198_14718_14741(objectMethod) == MethodKind.Destructor))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 14682, 15068);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 14832, 15037);

                                                listYield.Add(f_10198_14845_15036(f_10198_14884_14906(method), f_10198_14908_15035(moduleBeingBuilt, objectMethod, context.SyntaxNodeOpt, context.Diagnostics)));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 14682, 15068);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 14447, 15095);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 649);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 649);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 13626, 15118);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 12579, 15118);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 11562, 15137);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 11470, 15152);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 3683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 3683);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 15168, 15267) || true) && (f_10198_15172_15206(f_10198_15172_15194()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 15168, 15267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 15240, 15252);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 15168, 15267);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 15283, 15369);

                var
                syntheticMethods = f_10198_15306_15368(moduleBeingBuilt, f_10198_15345_15367())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 15383, 16253) || true) && (syntheticMethods != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 15383, 16253);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 15445, 16238);
                        foreach (var m in f_10198_15463_15479_I(syntheticMethods))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 15445, 16238);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 15521, 15572);

                            var
                            method = f_10198_15534_15555(m) as MethodSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 15594, 16219) || true) && ((object)method != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 15594, 16219);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 15670, 15729);

                                f_10198_15670_15728((object)f_10198_15691_15719(method) == null);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 15779, 16114);
                                    foreach (var implemented in f_10198_15807_15846_I(f_10198_15807_15846(method)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 15779, 16114);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 15904, 16087);

                                        listYield.Add(f_10198_15917_16086(m, f_10198_15959_16085(moduleBeingBuilt, implemented, context.SyntaxNodeOpt, context.Diagnostics)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 15779, 16114);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 336);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 336);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 16142, 16196);

                                f_10198_16142_16195(!f_10198_16156_16194(method, out _));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 15594, 16219);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 15445, 16238);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 794);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 794);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 15383, 16253);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 11206, 16264);

                return listYield;

                int
                f_10198_11344_11370(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 11344, 11370);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_11493_11515()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 11493, 11515);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10198_11493_11528(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 11493, 11528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10198_11566_11577(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 11566, 11577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10198_11717_11745(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 11717, 11745);
                    return return_v;
                }


                int
                f_10198_11696_11754(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 11696, 11754);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10198_11831_11870(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 11831, 11870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10198_11996_12018(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 11996, 12018);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10198_12075_12114(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 12075, 12114);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10198_12233_12359(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TranslateOverriddenMethodReference(methodSymbol, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 12233, 12359);
                    return return_v;
                }


                Microsoft.Cci.MethodImplementation
                f_10198_12185_12360(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                ImplementingMethod, Microsoft.Cci.IMethodReference
                ImplementedMethod)
                {
                    var return_v = new Microsoft.Cci.MethodImplementation((Microsoft.Cci.IMethodDefinition)ImplementingMethod, ImplementedMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 12185, 12360);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10198_12075_12114_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 12075, 12114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_12439_12461()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 12439, 12461);
                    return return_v;
                }


                bool
                f_10198_12439_12473(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 12439, 12473);
                    return return_v;
                }


                bool
                f_10198_12583_12621(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, out bool
                warnAmbiguous)
                {
                    var return_v = method.RequiresExplicitOverride(out warnAmbiguous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 12583, 12621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10198_13412_13434(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 13412, 13434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10198_13488_13511(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 13488, 13511);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10198_13436_13574(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TranslateOverriddenMethodReference(methodSymbol, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 13436, 13574);
                    return return_v;
                }


                Microsoft.Cci.MethodImplementation
                f_10198_13373_13575(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                ImplementingMethod, Microsoft.Cci.IMethodReference
                ImplementedMethod)
                {
                    var return_v = new Microsoft.Cci.MethodImplementation((Microsoft.Cci.IMethodDefinition)ImplementingMethod, ImplementedMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 13373, 13575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10198_13630_13647(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 13630, 13647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_13676_13698()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 13676, 13698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10198_13676_13710(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 13676, 13710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_14322_14344()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 14322, 14344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10198_14322_14365(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 14322, 14365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_14322_14420(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 14322, 14420);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10198_14479_14537(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 14479, 14537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10198_14718_14741(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 14718, 14741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10198_14884_14906(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 14884, 14906);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10198_14908_15035(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TranslateOverriddenMethodReference(methodSymbol, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 14908, 15035);
                    return return_v;
                }


                Microsoft.Cci.MethodImplementation
                f_10198_14845_15036(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                ImplementingMethod, Microsoft.Cci.IMethodReference
                ImplementedMethod)
                {
                    var return_v = new Microsoft.Cci.MethodImplementation((Microsoft.Cci.IMethodDefinition)ImplementingMethod, ImplementedMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 14845, 15036);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10198_14479_14537_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 14479, 14537);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10198_11493_11528_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 11493, 11528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_15172_15194()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 15172, 15194);
                    return return_v;
                }


                bool
                f_10198_15172_15206(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 15172, 15206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_15345_15367()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 15345, 15367);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_10198_15306_15368(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container)
                {
                    var return_v = this_param.GetSynthesizedMethods(container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 15306, 15368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10198_15534_15555(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 15534, 15555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10198_15691_15719(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 15691, 15719);
                    return return_v;
                }


                int
                f_10198_15670_15728(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 15670, 15728);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10198_15807_15846(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 15807, 15846);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10198_15959_16085(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TranslateOverriddenMethodReference(methodSymbol, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 15959, 16085);
                    return return_v;
                }


                Microsoft.Cci.MethodImplementation
                f_10198_15917_16086(Microsoft.Cci.IMethodDefinition
                ImplementingMethod, Microsoft.Cci.IMethodReference
                ImplementedMethod)
                {
                    var return_v = new Microsoft.Cci.MethodImplementation(ImplementingMethod, ImplementedMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 15917, 16086);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10198_15807_15846_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 15807, 15846);
                    return return_v;
                }


                bool
                f_10198_16156_16194(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, out bool
                warnAmbiguous)
                {
                    var return_v = method.RequiresExplicitOverride(out warnAmbiguous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 16156, 16194);
                    return return_v;
                }


                int
                f_10198_16142_16195(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 16142, 16195);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_10198_15463_15479_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 15463, 15479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 11206, 16264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 11206, 16264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.IFieldDefinition> Cci.ITypeDefinition.GetFields(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 16276, 17339);

                var listYield = new List<IFieldDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 16385, 16412);

                f_10198_16385_16411(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 16485, 16539);

                bool
                isStruct = f_10198_16501_16538(f_10198_16501_16523())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 16555, 16885);
                    foreach (var f in f_10198_16573_16613_I(f_10198_16573_16613(f_10198_16573_16595())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 16555, 16885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 16647, 16704);

                        f_10198_16647_16703((object)(f_10198_16669_16691(f) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?>(10198, 16669, 16696) ?? f)) == f);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 16722, 16870) || true) && 
                            (isStruct || (DynAbs.Tracing.TraceSender.Expression_False(10198, 16726, 16778) || 
                            f_10198_16738_16755(f).ShouldInclude(context)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 16722, 16870);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 16820, 16851);

                            listYield.Add(f_10198_16833_16850(f));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 16722, 16870);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 16555, 16885);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 331);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 16901, 17026);

                IEnumerable<Cci.IFieldDefinition>
                generated = f_10198_16947_17025(((PEModuleBuilder)context.Module), f_10198_17002_17024())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 17042, 17328) || true) && (generated != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 17042, 17328);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 17097, 17313);
                        foreach (var f in f_10198_17115_17124_I(generated))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 17097, 17313);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 17166, 17294) || true) && (isStruct || (DynAbs.Tracing.TraceSender.Expression_False(10198, 17170, 17206) || f.ShouldInclude(context)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 17166, 17294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 17256, 17271);

                                listYield.Add(f);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 17166, 17294);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 17097, 17313);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 217);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 217);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 17042, 17328);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 16276, 17339);

                return listYield;

                int
                f_10198_16385_16411(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 16385, 16411);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_16501_16523()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 16501, 16523);
                    return return_v;
                }


                bool
                f_10198_16501_16538(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 16501, 16538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_16573_16595()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 16573, 16595);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10198_16573_16613(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetFieldsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 16573, 16613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10198_16669_16691(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TupleUnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 16669, 16691);
                    return return_v;
                }


                int
                f_10198_16647_16703(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 16647, 16703);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10198_16738_16755(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 16738, 16755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10198_16833_16850(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 16833, 16850);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10198_16573_16613_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 16573, 16613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_17002_17024()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 17002, 17024);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                f_10198_16947_17025(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container)
                {
                    var return_v = this_param.GetSynthesizedFields(container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 16947, 17025);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                f_10198_17115_17124_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 17115, 17124);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 16276, 17339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 16276, 17339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.IGenericTypeParameter> Cci.ITypeDefinition.GenericParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 17452, 17697);

                    var listYield = new List<IGenericTypeParameter>();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 17488, 17515);

                    f_10198_17488_17514(this);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 17535, 17682);
                        foreach (var t in f_10198_17553_17590_I(f_10198_17553_17590(f_10198_17553_17575())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 17535, 17682);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 17632, 17663);

                            listYield.Add(f_10198_17645_17662(t));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 17535, 17682);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 148);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 17452, 17697);

                    return listYield;

                    int
                    f_10198_17488_17514(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 17488, 17514);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_17553_17575()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 17553, 17575);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10198_17553_17590(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 17553, 17590);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    f_10198_17645_17662(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 17645, 17662);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10198_17553_17590_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 17553, 17590);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 17351, 17708);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 17351, 17708);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.ITypeDefinition.GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 17793, 17924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 17829, 17856);

                    f_10198_17829_17855(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 17876, 17909);

                    return f_10198_17883_17908();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 17793, 17924);

                    int
                    f_10198_17829_17855(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 17829, 17855);
                        return 0;
                    }


                    ushort
                    f_10198_17883_17908()
                    {
                        var return_v = GenericParameterCountImpl;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 17883, 17908);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 17720, 17935);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 17720, 17935);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ushort GenericParameterCountImpl
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 18012, 18064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 18018, 18062);

                    return (ushort)f_10198_18033_18061(f_10198_18033_18055());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 18012, 18064);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_18033_18055()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 18033, 18055);
                        return return_v;
                    }


                    int
                    f_10198_18033_18061(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 18033, 18061);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 17947, 18075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 17947, 18075);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<Cci.TypeReferenceWithAttributes> Cci.ITypeDefinition.Interfaces(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 18087, 19038);

                var listYield = new List<TypeReferenceWithAttributes>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 18208, 18283);

                f_10198_18208_18282(f_10198_18221_18273(((Cci.ITypeReference)this), context) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 18299, 18366);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 18382, 19027);
                    foreach (NamedTypeSymbol @interface in f_10198_18421_18465_I(f_10198_18421_18465(f_10198_18421_18443())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 18382, 19027);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 18499, 18749);

                        var
                        typeRef = f_10198_18513_18748(moduleBeingBuilt, @interface, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics, fromImplements: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 18769, 18819);

                        var
                        type = TypeWithAnnotations.Create(@interface)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 18837, 19012);

                        listYield.Add(type.GetTypeRefWithAttributes(moduleBeingBuilt, declaringSymbol: f_10198_18958_18980(), typeRef));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 18382, 19027);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 646);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 18087, 19038);

                return listYield;

                Microsoft.Cci.ITypeDefinition?
                f_10198_18221_18273(Microsoft.Cci.ITypeReference
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.AsTypeDefinition(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 18221, 18273);
                    return return_v;
                }


                int
                f_10198_18208_18282(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 18208, 18282);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_18421_18443()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 18421, 18443);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10198_18421_18465(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetInterfacesToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 18421, 18465);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10198_18513_18748(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                fromImplements)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics, fromImplements: fromImplements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 18513, 18748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_18958_18980()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 18958, 18980);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10198_18421_18465_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 18421, 18465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 18087, 19038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 18087, 19038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool Cci.ITypeDefinition.IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 19110, 19255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 19146, 19173);

                    f_10198_19146_19172(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 19191, 19240);

                    return f_10198_19198_19239(f_10198_19198_19220());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 19110, 19255);

                    int
                    f_10198_19146_19172(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 19146, 19172);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_19198_19220()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 19198, 19220);
                        return return_v;
                    }


                    bool
                    f_10198_19198_19239(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 19198, 19239);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 19050, 19266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 19050, 19266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeDefinition.IsBeforeFieldInit
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 19345, 20246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 19381, 19408);

                    f_10198_19381_19407(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 19428, 19786);

                    switch (f_10198_19436_19467(f_10198_19436_19458()))
                    {

                        case TypeKind.Enum:
                        case TypeKind.Delegate:
                        //C# interfaces don't have fields so the flag doesn't really matter, but Dev10 omits it
                        case TypeKind.Interface:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 19428, 19786);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 19754, 19767);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 19428, 19786);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 19920, 20199);
                        foreach (var member in f_10198_19943_20020_I(f_10198_19943_20020(f_10198_19943_19965(), WellKnownMemberNames.StaticConstructorName)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 19920, 20199);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 20062, 20180) || true) && (f_10198_20066_20094_M(!member.IsImplicitlyDeclared))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 20062, 20180);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 20144, 20157);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 20062, 20180);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 19920, 20199);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 280);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 280);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 20219, 20231);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 19345, 20246);

                    int
                    f_10198_19381_19407(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 19381, 19407);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_19436_19458()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 19436, 19458);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10198_19436_19467(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 19436, 19467);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_19943_19965()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 19943, 19965);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10198_19943_20020(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 19943, 20020);
                        return return_v;
                    }


                    bool
                    f_10198_20066_20094_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 20066, 20094);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10198_19943_20020_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 19943, 20020);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 19278, 20257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 19278, 20257);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeDefinition.IsComObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 20330, 20468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 20366, 20393);

                    f_10198_20366_20392(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 20411, 20453);

                    return f_10198_20418_20452(f_10198_20418_20440());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 20330, 20468);

                    int
                    f_10198_20366_20392(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 20366, 20392);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_20418_20440()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 20418, 20440);
                        return return_v;
                    }


                    bool
                    f_10198_20418_20452(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsComImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 20418, 20452);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 20269, 20479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 20269, 20479);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeDefinition.IsGeneric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 20550, 20687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 20586, 20613);

                    f_10198_20586_20612(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 20631, 20672);

                    return f_10198_20638_20666(f_10198_20638_20660()) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 20550, 20687);

                    int
                    f_10198_20586_20612(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 20586, 20612);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_20638_20660()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 20638, 20660);
                        return return_v;
                    }


                    int
                    f_10198_20638_20666(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 20638, 20666);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 20491, 20698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 20491, 20698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeDefinition.IsInterface
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 20771, 20909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 20807, 20834);

                    f_10198_20807_20833(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 20852, 20894);

                    return f_10198_20859_20893(f_10198_20859_20881());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 20771, 20909);

                    int
                    f_10198_20807_20833(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 20807, 20833);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_20859_20881()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 20859, 20881);
                        return return_v;
                    }


                    bool
                    f_10198_20859_20893(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 20859, 20893);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 20710, 20920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 20710, 20920);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeDefinition.IsDelegate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 20992, 21135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 21028, 21055);

                    f_10198_21028_21054(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 21073, 21120);

                    return f_10198_21080_21119(f_10198_21080_21102());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 20992, 21135);

                    int
                    f_10198_21028_21054(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 21028, 21054);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_21080_21102()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 21080, 21102);
                        return return_v;
                    }


                    bool
                    f_10198_21080_21119(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsDelegateType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 21080, 21119);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 20932, 21146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 20932, 21146);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeDefinition.IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 21224, 21333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 21260, 21287);

                    f_10198_21260_21286(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 21305, 21318);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 21224, 21333);

                    int
                    f_10198_21260_21286(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 21260, 21286);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 21158, 21344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 21158, 21344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeDefinition.IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 21420, 21561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 21456, 21483);

                    f_10198_21456_21482(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 21501, 21546);

                    return f_10198_21508_21545(f_10198_21508_21530());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 21420, 21561);

                    int
                    f_10198_21456_21482(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 21456, 21482);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_21508_21530()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 21508, 21530);
                        return return_v;
                    }


                    bool
                    f_10198_21508_21545(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSerializable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 21508, 21545);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 21356, 21572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 21356, 21572);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeDefinition.IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 21647, 21788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 21683, 21710);

                    f_10198_21683_21709(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 21728, 21773);

                    return f_10198_21735_21772(f_10198_21735_21757());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 21647, 21788);

                    int
                    f_10198_21683_21709(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 21683, 21709);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_21735_21757()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 21735, 21757);
                        return return_v;
                    }


                    bool
                    f_10198_21735_21772(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 21735, 21772);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 21584, 21799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 21584, 21799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeDefinition.IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 21883, 22032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 21919, 21946);

                    f_10198_21919_21945(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 21964, 22017);

                    return f_10198_21971_22016(f_10198_21971_21993());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 21883, 22032);

                    int
                    f_10198_21919_21945(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 21919, 21945);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_21971_21993()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 21971, 21993);
                        return return_v;
                    }


                    bool
                    f_10198_21971_22016(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsWindowsRuntimeImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 21971, 22016);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 21811, 22043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 21811, 22043);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.ITypeDefinition.IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 22113, 22256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 22149, 22176);

                    f_10198_22149_22175(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 22194, 22241);

                    return f_10198_22201_22240(f_10198_22201_22223());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 22113, 22256);

                    int
                    f_10198_22149_22175(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 22149, 22175);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_22201_22223()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 22201, 22223);
                        return return_v;
                    }


                    bool
                    f_10198_22201_22240(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsMetadataSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 22201, 22240);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 22055, 22267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 22055, 22267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<Cci.IMethodDefinition> Cci.ITypeDefinition.GetMethods(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 22279, 23661);

                var listYield = new List<IMethodDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 22390, 22417);

                f_10198_22390_22416(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 22607, 22757);

                bool
                alwaysIncludeConstructors = context.IncludePrivateMembers || (DynAbs.Tracing.TraceSender.Expression_False(10198, 22640, 22756) || f_10198_22673_22756(f_10198_22673_22716(f_10198_22673_22695()), f_10198_22733_22755()))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 22773, 23167);
                    foreach (var method in f_10198_22796_22837_I(f_10198_22796_22837(f_10198_22796_22818())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 22773, 23167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 22871, 22908);

                        f_10198_22871_22907((object)method != null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 22928, 23152) || true) && ((alwaysIncludeConstructors && (DynAbs.Tracing.TraceSender.Expression_True(10198, 22933, 23005) && f_10198_22962_22979(method) == MethodKind.Constructor)) || (DynAbs.Tracing.TraceSender.Expression_False(10198, 22932, 23055) || f_10198_23010_23032(method).ShouldInclude(context)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 22928, 23152);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 23097, 23133);

                            listYield.Add(f_10198_23110_23132(method));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 22928, 23152);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 22773, 23167);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 395);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 23183, 23310);

                IEnumerable<Cci.IMethodDefinition>
                generated = f_10198_23230_23309(((PEModuleBuilder)context.Module), f_10198_23286_23308())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 23326, 23650) || true) && (generated != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 23326, 23650);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 23381, 23635);
                        foreach (var m in f_10198_23399_23408_I(generated))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 23381, 23635);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 23450, 23616) || true) && ((alwaysIncludeConstructors && (DynAbs.Tracing.TraceSender.Expression_True(10198, 23455, 23499) && f_10198_23484_23499(m))) || (DynAbs.Tracing.TraceSender.Expression_False(10198, 23454, 23528) || m.ShouldInclude(context)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 23450, 23616);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 23578, 23593);

                                listYield.Add(m);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 23450, 23616);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 23381, 23635);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 255);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 255);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 23326, 23650);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 22279, 23661);

                return listYield;

                int
                f_10198_22390_22416(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 22390, 22416);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_22673_22695()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 22673, 22695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10198_22673_22716(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 22673, 22716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_22733_22755()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 22733, 22755);
                    return return_v;
                }


                bool
                f_10198_22673_22756(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsAttributeType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 22673, 22756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_22796_22818()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 22796, 22818);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10198_22796_22837(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMethodsToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 22796, 22837);
                    return return_v;
                }


                int
                f_10198_22871_22907(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 22871, 22907);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10198_22962_22979(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 22962, 22979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10198_23010_23032(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 23010, 23032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10198_23110_23132(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 23110, 23132);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10198_22796_22837_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 22796, 22837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_23286_23308()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 23286, 23308);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_10198_23230_23309(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container)
                {
                    var return_v = this_param.GetSynthesizedMethods(container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 23230, 23309);
                    return return_v;
                }


                bool
                f_10198_23484_23499(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.IsConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 23484, 23499);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_10198_23399_23408_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 23399, 23408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 22279, 23661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 22279, 23661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.INestedTypeDefinition> Cci.ITypeDefinition.GetNestedTypes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 23673, 24347);

                var listYield = new List<INestedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 23792, 23819);

                f_10198_23792_23818(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 23835, 24002);
                    foreach (NamedTypeSymbol type in f_10198_23868_23907_I(f_10198_23868_23907(f_10198_23868_23890())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 23835, 24002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 23953, 23987);

                        listYield.Add(f_10198_23966_23986(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 23835, 24002);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 24018, 24147);

                IEnumerable<Cci.INestedTypeDefinition>
                generated = f_10198_24069_24146(((PEModuleBuilder)context.Module), f_10198_24123_24145())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 24163, 24336) || true) && (generated != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 24163, 24336);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 24218, 24321);
                        foreach (var t in f_10198_24236_24245_I(generated))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 24218, 24321);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 24287, 24302);

                            listYield.Add(t);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 24218, 24321);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 104);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 104);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 24163, 24336);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 23673, 24347);

                return listYield;

                int
                f_10198_23792_23818(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 23792, 23818);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_23868_23890()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 23868, 23890);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10198_23868_23907(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 23868, 23907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10198_23966_23986(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 23966, 23986);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10198_23868_23907_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 23868, 23907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_24123_24145()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 24123, 24145);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
                f_10198_24069_24146(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container)
                {
                    var return_v = this_param.GetSynthesizedTypes(container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 24069, 24146);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
                f_10198_24236_24245_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 24236, 24245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 23673, 24347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 23673, 24347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.IPropertyDefinition> Cci.ITypeDefinition.GetProperties(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 24359, 25549);

                var listYield = new List<IPropertyDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 24475, 24502);

                f_10198_24475_24501(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 24518, 25046);
                    foreach (PropertySymbol property in f_10198_24554_24598_I(f_10198_24554_24598(f_10198_24554_24576())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 24518, 25046);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 24632, 24671);

                        f_10198_24632_24670((object)property != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 24689, 24747);

                        IPropertyDefinition
                        definition = f_10198_24722_24746(property)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 24862, 25031) || true) && (definition.ShouldInclude(context) || (DynAbs.Tracing.TraceSender.Expression_False(10198, 24866, 24946) || !f_10198_24904_24946(f_10198_24904_24936(definition, context))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 24862, 25031);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 24988, 25012);

                            listYield.Add(definition);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 24862, 25031);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 24518, 25046);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 25062, 25194);

                IEnumerable<Cci.IPropertyDefinition>
                generated = f_10198_25111_25193(((PEModuleBuilder)context.Module), f_10198_25170_25192())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 25210, 25538) || true) && (generated != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 25210, 25538);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 25265, 25523);
                        foreach (IPropertyDefinition m in f_10198_25299_25308_I(generated))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 25265, 25523);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 25350, 25504) || true) && (m.ShouldInclude(context) || (DynAbs.Tracing.TraceSender.Expression_False(10198, 25354, 25416) || !f_10198_25383_25416(f_10198_25383_25406(m, context))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 25350, 25504);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 25466, 25481);

                                listYield.Add(m);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 25350, 25504);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 25265, 25523);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 259);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 259);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 25210, 25538);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 24359, 25549);

                return listYield;

                int
                f_10198_24475_24501(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 24475, 24501);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_24554_24576()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 24554, 24576);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10198_24554_24598(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetPropertiesToEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 24554, 24598);
                    return return_v;
                }


                int
                f_10198_24632_24670(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 24632, 24670);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
                f_10198_24722_24746(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 24722, 24746);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                f_10198_24904_24936(Microsoft.Cci.IPropertyDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAccessors(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 24904, 24936);
                    return return_v;
                }


                bool
                f_10198_24904_24946(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.Cci.IMethodReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 24904, 24946);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10198_24554_24598_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 24554, 24598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_25170_25192()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 25170, 25192);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                f_10198_25111_25193(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container)
                {
                    var return_v = this_param.GetSynthesizedProperties(container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 25111, 25193);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                f_10198_25383_25406(Microsoft.Cci.IPropertyDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAccessors(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 25383, 25406);
                    return return_v;
                }


                bool
                f_10198_25383_25416(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodReference>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.Cci.IMethodReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 25383, 25416);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                f_10198_25299_25308_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 25299, 25308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 24359, 25549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 24359, 25549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool Cci.ITypeDefinition.HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 25633, 25782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 25669, 25696);

                    f_10198_25669_25695(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 25714, 25767);

                    return f_10198_25721_25766(f_10198_25721_25743());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 25633, 25782);

                    int
                    f_10198_25669_25695(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 25669, 25695);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_25721_25743()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 25721, 25743);
                        return return_v;
                    }


                    bool
                    f_10198_25721_25766(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.HasDeclarativeSecurity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 25721, 25766);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 25561, 25793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 25561, 25793);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<Cci.SecurityAttribute> Cci.ITypeDefinition.SecurityAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 25903, 26121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 25939, 25966);

                    f_10198_25939_25965(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 25984, 26106);

                    return f_10198_25991_26038(f_10198_25991_26013()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>>(10198, 25991, 26105) ?? f_10198_26042_26105());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 25903, 26121);

                    int
                    f_10198_25939_25965(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 25939, 25965);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_25991_26013()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 25991, 26013);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                    f_10198_25991_26038(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetSecurityInformation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 25991, 26038);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                    f_10198_26042_26105()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerable<Cci.SecurityAttribute>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 26042, 26105);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 25805, 26132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 25805, 26132);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.ITypeDefinition.Alignment
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 26205, 26394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 26241, 26268);

                    f_10198_26241_26267(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 26286, 26329);

                    var
                    layout = f_10198_26299_26328(f_10198_26299_26321())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 26347, 26379);

                    return (ushort)layout.Alignment;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 26205, 26394);

                    int
                    f_10198_26241_26267(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 26241, 26267);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_26299_26321()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 26299, 26321);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeLayout
                    f_10198_26299_26328(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Layout;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 26299, 26328);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 26144, 26405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 26144, 26405);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        LayoutKind Cci.ITypeDefinition.Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 26479, 26617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 26515, 26542);

                    f_10198_26515_26541(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 26560, 26602);

                    return f_10198_26567_26589().Layout.Kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 26479, 26617);

                    int
                    f_10198_26515_26541(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 26515, 26541);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_26567_26589()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 26567, 26589);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 26417, 26628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 26417, 26628);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        uint Cci.ITypeDefinition.SizeOf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 26696, 26840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 26732, 26759);

                    f_10198_26732_26758(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 26777, 26825);

                    return (uint)f_10198_26790_26812().Layout.Size;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 26696, 26840);

                    int
                    f_10198_26732_26758(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 26732, 26758);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_26790_26812()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 26790, 26812);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 26640, 26851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 26640, 26851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CharSet Cci.ITypeDefinition.StringFormat
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 26928, 27073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 26964, 26991);

                    f_10198_26964_26990(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 27009, 27058);

                    return f_10198_27016_27057(f_10198_27016_27038());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 26928, 27073);

                    int
                    f_10198_26964_26990(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 26964, 26990);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_27016_27038()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 27016, 27038);
                        return return_v;
                    }


                    System.Runtime.InteropServices.CharSet
                    f_10198_27016_27057(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingCharSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 27016, 27057);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 26863, 27084);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 26863, 27084);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.INamedTypeReference.GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 27173, 27214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 27179, 27212);

                    return f_10198_27186_27211();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 27173, 27214);

                    ushort
                    f_10198_27186_27211()
                    {
                        var return_v = GenericParameterCountImpl;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 27186, 27211);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 27096, 27225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 27096, 27225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.INamedTypeReference.MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 27301, 27393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 27337, 27378);

                    return f_10198_27344_27377(f_10198_27344_27366());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 27301, 27393);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_27344_27366()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 27344, 27366);
                        return return_v;
                    }


                    bool
                    f_10198_27344_27377(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MangleName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 27344, 27377);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 27237, 27404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 27237, 27404);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 27469, 28539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 27505, 27557);

                    string
                    unsuffixedName = f_10198_27529_27556(f_10198_27529_27551())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 28244, 28482);

                    f_10198_28244_28481(f_10198_28257_28293(f_10198_28257_28279()) || (DynAbs.Tracing.TraceSender.Expression_False(10198, 28257, 28347) || !f_10198_28319_28347(unsuffixedName, ".")) || (DynAbs.Tracing.TraceSender.Expression_False(10198, 28257, 28434) || f_10198_28372_28413(f_10198_28372_28394()) is PENamedTypeSymbol), "type name contains dots: " + unsuffixedName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 28502, 28524);

                    return unsuffixedName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 27469, 28539);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_27529_27551()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 27529, 27551);
                        return return_v;
                    }


                    string
                    f_10198_27529_27556(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 27529, 27556);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_28257_28279()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 28257, 28279);
                        return return_v;
                    }


                    bool
                    f_10198_28257_28293(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsErrorType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 28257, 28293);
                        return return_v;
                    }


                    bool
                    f_10198_28319_28347(string
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Contains(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 28319, 28347);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_28372_28394()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 28372, 28394);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_28372_28413(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 28372, 28413);
                        return return_v;
                    }


                    int
                    f_10198_28244_28481(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 28244, 28481);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 27416, 28550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 27416, 28550);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IUnitReference Cci.INamespaceTypeReference.GetUnit(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 28562, 28940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 28662, 28729);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 28745, 28819);

                f_10198_28745_28818(f_10198_28758_28809(((Cci.ITypeReference)this)) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 28833, 28929);

                return f_10198_28840_28928(moduleBeingBuilt, f_10198_28867_28906(f_10198_28867_28889()), context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 28562, 28940);

                Microsoft.Cci.INamespaceTypeReference?
                f_10198_28758_28809(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNamespaceTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 28758, 28809);
                    return return_v;
                }


                int
                f_10198_28745_28818(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 28745, 28818);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_28867_28889()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 28867, 28889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10198_28867_28906(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 28867, 28906);
                    return return_v;
                }


                Microsoft.Cci.IModuleReference
                f_10198_28840_28928(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                module, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(module, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 28840, 28928);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 28562, 28940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 28562, 28940);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string Cci.INamespaceTypeReference.NamespaceName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 29025, 29400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 29227, 29301);

                    f_10198_29227_29300(f_10198_29240_29291(((Cci.ITypeReference)this)) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 29321, 29385);

                    return f_10198_29328_29384(f_10198_29328_29370(f_10198_29328_29350()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 29025, 29400);

                    Microsoft.Cci.INamespaceTypeReference?
                    f_10198_29240_29291(Microsoft.Cci.ITypeReference
                    this_param)
                    {
                        var return_v = this_param.AsNamespaceTypeReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 29240, 29291);
                        return return_v;
                    }


                    int
                    f_10198_29227_29300(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 29227, 29300);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_29328_29350()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 29328, 29350);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10198_29328_29370(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 29328, 29370);
                        return return_v;
                    }


                    string
                    f_10198_29328_29384(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.QualifiedName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 29328, 29384);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 28952, 29411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 28952, 29411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.INamespaceTypeDefinition.IsPublic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 29490, 29793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 29526, 29659);

                    f_10198_29526_29658((object)f_10198_29547_29584(f_10198_29547_29569()) == null && (DynAbs.Tracing.TraceSender.Expression_True(10198, 29539, 29657) && f_10198_29596_29635(f_10198_29596_29618()) is SourceModuleSymbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 29679, 29778);

                    return f_10198_29686_29742(f_10198_29719_29741()) == Cci.TypeMemberVisibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 29490, 29793);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_29547_29569()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 29547, 29569);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_29547_29584(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 29547, 29584);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_29596_29618()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 29596, 29618);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10198_29596_29635(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 29596, 29635);
                        return return_v;
                    }


                    int
                    f_10198_29526_29658(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 29526, 29658);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_29719_29741()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 29719, 29741);
                        return return_v;
                    }


                    Microsoft.Cci.TypeMemberVisibility
                    f_10198_29686_29742(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = PEModuleBuilder.MemberVisibility((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 29686, 29742);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 29423, 29804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 29423, 29804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 29816, 30522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 29923, 29990);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 30006, 30077);

                f_10198_30006_30076(f_10198_30019_30067(((Cci.ITypeReference)this)) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 30093, 30137);

                f_10198_30093_30136(f_10198_30106_30135(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 30153, 30511);

                return f_10198_30160_30510(moduleBeingBuilt, f_10198_30187_30224(f_10198_30187_30209()), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics, needDeclaration: f_10198_30474_30509(f_10198_30474_30496()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 29816, 30522);

                Microsoft.Cci.INestedTypeReference?
                f_10198_30019_30067(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 30019, 30067);
                    return return_v;
                }


                int
                f_10198_30006_30076(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 30006, 30076);
                    return 0;
                }


                bool
                f_10198_30106_30135(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 30106, 30135);
                    return return_v;
                }


                int
                f_10198_30093_30136(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 30093, 30136);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_30187_30209()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 30187, 30209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_30187_30224(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 30187, 30224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_30474_30496()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 30474, 30496);
                    return return_v;
                }


                bool
                f_10198_30474_30509(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 30474, 30509);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10198_30160_30510(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 30160, 30510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 29816, 30522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 29816, 30522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.ITypeDefinition Cci.ITypeDefinitionMember.ContainingTypeDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 30629, 30874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 30665, 30733);

                    f_10198_30665_30732((object)f_10198_30686_30723(f_10198_30686_30708()) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 30751, 30778);

                    f_10198_30751_30777(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 30798, 30859);

                    return f_10198_30805_30858(f_10198_30805_30842(f_10198_30805_30827()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 30629, 30874);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_30686_30708()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 30686, 30708);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_30686_30723(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 30686, 30723);
                        return return_v;
                    }


                    int
                    f_10198_30665_30732(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 30665, 30732);
                        return 0;
                    }


                    int
                    f_10198_30751_30777(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 30751, 30777);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_30805_30827()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 30805, 30827);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_30805_30842(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 30805, 30842);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    f_10198_30805_30858(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 30805, 30858);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 30534, 30885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 30534, 30885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.TypeMemberVisibility Cci.ITypeDefinitionMember.Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 30983, 31231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31019, 31087);

                    f_10198_31019_31086((object)f_10198_31040_31077(f_10198_31040_31062()) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31105, 31132);

                    f_10198_31105_31131(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31152, 31216);

                    return f_10198_31159_31215(f_10198_31192_31214());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 30983, 31231);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_31040_31062()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 31040, 31062);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_31040_31077(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 31040, 31077);
                        return return_v;
                    }


                    int
                    f_10198_31019_31086(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 31019, 31086);
                        return 0;
                    }


                    int
                    f_10198_31105_31131(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 31105, 31131);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10198_31192_31214()
                    {
                        var return_v = AdaptedNamedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 31192, 31214);
                        return return_v;
                    }


                    Microsoft.Cci.TypeMemberVisibility
                    f_10198_31159_31215(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = PEModuleBuilder.MemberVisibility((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 31159, 31215);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 30897, 31242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 30897, 31242);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.ITypeReference> Cci.IGenericTypeInstanceReference.GetGenericArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 31254, 32359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31388, 31455);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31469, 31540);

                var
                builder = f_10198_31483_31539()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31554, 31634);

                f_10198_31554_31633(f_10198_31567_31624(((Cci.ITypeReference)this)) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31650, 31738);

                var
                arguments = f_10198_31666_31737(f_10198_31666_31688())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31763, 31768);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31754, 32296) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31792, 31795)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 31754, 32296))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 31754, 32296);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31829, 31975);

                        var
                        arg = f_10198_31839_31974(moduleBeingBuilt, arguments[i].Type, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 31993, 32038);

                        var
                        modifiers = arguments[i].CustomModifiers
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 32056, 32244) || true) && (f_10198_32060_32087_M(!modifiers.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 32056, 32244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 32129, 32225);

                            arg = f_10198_32135_32224(arg, ImmutableArray<Cci.ICustomModifier>.CastUp(modifiers));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 32056, 32244);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 32264, 32281);

                        f_10198_32264_32280(
                                        builder, arg);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 543);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 32312, 32348);

                return f_10198_32319_32347(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 31254, 32359);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                f_10198_31483_31539()
                {
                    var return_v = ArrayBuilder<Microsoft.Cci.ITypeReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 31483, 31539);
                    return return_v;
                }


                Microsoft.Cci.IGenericTypeInstanceReference?
                f_10198_31567_31624(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsGenericTypeInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 31567, 31624);
                    return return_v;
                }


                int
                f_10198_31554_31633(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 31554, 31633);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_31666_31688()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 31666, 31688);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10198_31666_31737(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 31666, 31737);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10198_31839_31974(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 31839, 31974);
                    return return_v;
                }


                bool
                f_10198_32060_32087_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 32060, 32087);
                    return return_v;
                }


                Microsoft.Cci.ModifiedTypeReference
                f_10198_32135_32224(Microsoft.Cci.ITypeReference
                modifiedType, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    var return_v = new Microsoft.Cci.ModifiedTypeReference(modifiedType, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 32135, 32224);
                    return return_v;
                }


                int
                f_10198_32264_32280(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param, Microsoft.Cci.ITypeReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 32264, 32280);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                f_10198_32319_32347(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 32319, 32347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 31254, 32359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 31254, 32359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INamedTypeReference Cci.IGenericTypeInstanceReference.GetGenericType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 32371, 32626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 32489, 32569);

                f_10198_32489_32568(f_10198_32502_32559(((Cci.ITypeReference)this)) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 32583, 32615);

                return f_10198_32590_32614(this, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 32371, 32626);

                Microsoft.Cci.IGenericTypeInstanceReference?
                f_10198_32502_32559(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsGenericTypeInstanceReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 32502, 32559);
                    return return_v;
                }


                int
                f_10198_32489_32568(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 32489, 32568);
                    return 0;
                }


                Microsoft.Cci.INamedTypeReference
                f_10198_32590_32614(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GenericTypeImpl(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 32590, 32614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 32371, 32626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 32371, 32626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cci.INamedTypeReference GenericTypeImpl(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 32638, 33060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 32731, 32798);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 32812, 33049);

                return f_10198_32819_33048(moduleBeingBuilt, f_10198_32846_32887(f_10198_32846_32868()), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics, needDeclaration: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 32638, 33060);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_32846_32868()
                {
                    var return_v = AdaptedNamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 32846, 32868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10198_32846_32887(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 32846, 32887);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10198_32819_33048(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 32819, 33048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 32638, 33060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 32638, 33060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INestedTypeReference Cci.ISpecializedNestedTypeReference.GetUnspecializedVersion(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 33072, 33442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 33202, 33284);

                f_10198_33202_33283(f_10198_33215_33274(((Cci.ITypeReference)this)) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 33298, 33358);

                var
                result = f_10198_33311_33357(f_10198_33311_33335(this, context))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 33374, 33403);

                f_10198_33374_33402(result != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 33417, 33431);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 33072, 33442);

                Microsoft.Cci.ISpecializedNestedTypeReference?
                f_10198_33215_33274(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.AsSpecializedNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 33215, 33274);
                    return return_v;
                }


                int
                f_10198_33202_33283(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 33202, 33283);
                    return 0;
                }


                Microsoft.Cci.INamedTypeReference
                f_10198_33311_33335(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GenericTypeImpl(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 33311, 33335);
                    return return_v;
                }


                Microsoft.Cci.INestedTypeReference?
                f_10198_33311_33357(Microsoft.Cci.INamedTypeReference
                this_param)
                {
                    var return_v = this_param.AsNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 33311, 33357);
                    return return_v;
                }


                int
                f_10198_33374_33402(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 33374, 33402);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 33072, 33442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 33072, 33442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamedTypeSymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10198, 704, 33449);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10198, 704, 33449);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 704, 33449);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10198, 704, 33449);
    }
    internal partial class NamedTypeSymbol
    {
        private NamedTypeSymbolAdapter _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 33639, 33657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 33642, 33657);
                return f_10198_33642_33657(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 33639, 33657);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 33639, 33657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 33639, 33657);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
            f_10198_33642_33657(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 33642, 33657);
                return return_v;
            }

        }

        internal new NamedTypeSymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 33670, 33958);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 33746, 33911) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 33746, 33911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 33804, 33896);

                    return f_10198_33811_33895(ref _lazyAdapter, f_10198_33862_33894(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 33746, 33911);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 33927, 33947);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 33670, 33958);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10198_33862_33894(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingNamedTypeSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter(underlyingNamedTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 33862, 33894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10198_33811_33895(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 33811, 33895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 33670, 33958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 33670, 33958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual IEnumerable<EventSymbol> GetEventsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 34155, 34496);

                var listYield = new List<EventSymbol>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 34239, 34266);

                f_10198_34239_34265(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 34282, 34485);
                    foreach (var m in f_10198_34300_34317_I(f_10198_34300_34317(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 34282, 34485);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 34351, 34470) || true) && (f_10198_34355_34361(m) == SymbolKind.Event)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 34351, 34470);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 34423, 34451);

                            listYield.Add((EventSymbol)m);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 34351, 34470);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 34282, 34485);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 204);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 34155, 34496);

                return listYield;

                int
                f_10198_34239_34265(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 34239, 34265);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10198_34300_34317(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 34300, 34317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10198_34355_34361(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 34355, 34361);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10198_34300_34317_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 34300, 34317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 34155, 34496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 34155, 34496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract IEnumerable<FieldSymbol> GetFieldsToEmit();

        internal abstract ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit();

        protected ImmutableArray<NamedTypeSymbol> CalculateInterfacesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 34846, 35311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 34940, 34972);

                f_10198_34940_34971(f_10198_34953_34970(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 34986, 35044);

                f_10198_34986_35043(f_10198_34999_35020(this) is SourceModuleSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 35060, 35144);

                ArrayBuilder<NamedTypeSymbol>
                builder = f_10198_35100_35143()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 35158, 35195);

                HashSet<NamedTypeSymbol>
                seen = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 35209, 35250);

                f_10198_35209_35249(this, builder, ref seen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 35264, 35300);

                return f_10198_35271_35299(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 34846, 35311);

                bool
                f_10198_34953_34970(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 34953, 34970);
                    return return_v;
                }


                int
                f_10198_34940_34971(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 34940, 34971);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10198_34999_35020(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 34999, 35020);
                    return return_v;
                }


                int
                f_10198_34986_35043(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 34986, 35043);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10198_35100_35143()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 35100, 35143);
                    return return_v;
                }


                int
                f_10198_35209_35249(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                seen)
                {
                    InterfacesVisit(namedType, builder, ref seen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 35209, 35249);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10198_35271_35299(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 35271, 35299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 34846, 35311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 34846, 35311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void InterfacesVisit(NamedTypeSymbol namedType, ArrayBuilder<NamedTypeSymbol> builder, ref HashSet<NamedTypeSymbol> seen)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10198, 35537, 36557);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 35986, 36546);
                    foreach (NamedTypeSymbol @interface in f_10198_36025_36067_I(f_10198_36025_36067(namedType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 35986, 36546);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 36101, 36335) || true) && (seen == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 36101, 36335);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 36235, 36316);

                            seen = f_10198_36242_36315(Symbols.SymbolEqualityComparer.CLRSignature);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 36101, 36335);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 36353, 36531) || true) && (f_10198_36357_36377(seen, @interface))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 36353, 36531);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 36419, 36443);

                            f_10198_36419_36442(builder, @interface);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 36465, 36512);

                            f_10198_36465_36511(@interface, builder, ref seen);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 36353, 36531);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 35986, 36546);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 561);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10198, 35537, 36557);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10198_36025_36067(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 36025, 36067);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10198_36242_36315(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 36242, 36315);
                    return return_v;
                }


                bool
                f_10198_36357_36377(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 36357, 36377);
                    return return_v;
                }


                int
                f_10198_36419_36442(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 36419, 36442);
                    return 0;
                }


                int
                f_10198_36465_36511(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                seen)
                {
                    InterfacesVisit(namedType, builder, ref seen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 36465, 36511);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10198_36025_36067_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 36025, 36067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 35537, 36557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 35537, 36557);
            }
        }

        internal virtual bool IsMetadataAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 36634, 36770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 36670, 36697);

                    f_10198_36670_36696(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 36715, 36755);

                    return f_10198_36722_36737(this) || (DynAbs.Tracing.TraceSender.Expression_False(10198, 36722, 36754) || f_10198_36741_36754(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 36634, 36770);

                    int
                    f_10198_36670_36696(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 36670, 36696);
                        return 0;
                    }


                    bool
                    f_10198_36722_36737(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 36722, 36737);
                        return return_v;
                    }


                    bool
                    f_10198_36741_36754(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 36741, 36754);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 36569, 36781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 36569, 36781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsMetadataSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 36856, 36990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 36892, 36919);

                    f_10198_36892_36918(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 36937, 36975);

                    return f_10198_36944_36957(this) || (DynAbs.Tracing.TraceSender.Expression_False(10198, 36944, 36974) || f_10198_36961_36974(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 36856, 36990);

                    int
                    f_10198_36892_36918(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 36892, 36918);
                        return 0;
                    }


                    bool
                    f_10198_36944_36957(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 36944, 36957);
                        return return_v;
                    }


                    bool
                    f_10198_36961_36974(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 36961, 36974);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 36793, 37001);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 36793, 37001);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual IEnumerable<MethodSymbol> GetMethodsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 37267, 37750);

                var listYield = new List<MethodSymbol>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 37353, 37380);

                f_10198_37353_37379(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 37396, 37739);
                    foreach (var m in f_10198_37414_37431_I(f_10198_37414_37431(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 37396, 37739);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 37465, 37724) || true) && (f_10198_37469_37475(m) == SymbolKind.Method)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 37465, 37724);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 37538, 37567);

                            var
                            method = (MethodSymbol)m
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 37589, 37705) || true) && (f_10198_37593_37612(method))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 37589, 37705);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 37662, 37682);

                                listYield.Add(method);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 37589, 37705);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 37465, 37724);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 37396, 37739);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 344);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 37267, 37750);

                return listYield;

                int
                f_10198_37353_37379(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 37353, 37379);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10198_37414_37431(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 37414, 37431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10198_37469_37475(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 37469, 37475);
                    return return_v;
                }


                bool
                f_10198_37593_37612(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.ShouldEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 37593, 37612);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10198_37414_37431_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 37414, 37431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 37267, 37750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 37267, 37750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual IEnumerable<PropertySymbol> GetPropertiesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 37762, 38116);

                var listYield = new List<PropertySymbol>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 37853, 37880);

                f_10198_37853_37879(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 37896, 38105);
                    foreach (var m in f_10198_37914_37931_I(f_10198_37914_37931(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 37896, 38105);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 37965, 38090) || true) && (f_10198_37969_37975(m) == SymbolKind.Property)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 37965, 38090);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 38040, 38071);

                            listYield.Add((PropertySymbol)m);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 37965, 38090);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 37896, 38105);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10198, 1, 210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10198, 1, 210);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 37762, 38116);

                return listYield;

                int
                f_10198_37853_37879(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    this_param.CheckDefinitionInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 37853, 37879);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10198_37914_37931(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 37914, 37931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10198_37969_37975(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 37969, 37975);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10198_37914_37931_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10198, 37914, 37931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 37762, 38116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 37762, 38116);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10198, 33457, 38123);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 22676, 23026);
            IsInstanceFieldOrEvent = symbol =>
                    {
                        if (!symbol.IsStatic)
                        {
                            switch (symbol.Kind)
                            {
                                case SymbolKind.Field:
                                case SymbolKind.Event:
                                    return true;
                            }
                        }
                        return false;
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 42412, 42469);
            TypeWithAnnotationsIsNullFunction = type => !type.HasType; 
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 42539, 42619);
            TypeWithAnnotationsIsErrorType = type => type.HasType && type.Type.IsErrorType(); 
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 589, 615);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 682, 730);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 763, 796);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 829, 861);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 15635, 16429);
            tupleTypes = new WellKnownType[]{
                                                            WellKnownType.System_ValueTuple_T1,
                                                            WellKnownType.System_ValueTuple_T2,
                                                            WellKnownType.System_ValueTuple_T3,
                                                            WellKnownType.System_ValueTuple_T4,
                                                            WellKnownType.System_ValueTuple_T5,
                                                            WellKnownType.System_ValueTuple_T6,
                                                            WellKnownType.System_ValueTuple_T7,
                                                            WellKnownType.System_ValueTuple_TRest }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 17067, 17925);
            tupleCtors = new WellKnownMember[]{
                                                            WellKnownMember.System_ValueTuple_T1__ctor,
                                                            WellKnownMember.System_ValueTuple_T2__ctor,
                                                            WellKnownMember.System_ValueTuple_T3__ctor,
                                                            WellKnownMember.System_ValueTuple_T4__ctor,
                                                            WellKnownMember.System_ValueTuple_T5__ctor,
                                                            WellKnownMember.System_ValueTuple_T6__ctor,
                                                            WellKnownMember.System_ValueTuple_T7__ctor,
                                                            WellKnownMember.System_ValueTuple_TRest__ctor }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 18411, 22823);
            tupleMembers = new[]{
                                                        new[]{
                                                            WellKnownMember.System_ValueTuple_T1__Item1 },

                                                        new[]{
                                                            WellKnownMember.System_ValueTuple_T2__Item1,
                                                            WellKnownMember.System_ValueTuple_T2__Item2 },

                                                        new[]{
                                                            WellKnownMember.System_ValueTuple_T3__Item1,
                                                            WellKnownMember.System_ValueTuple_T3__Item2,
                                                            WellKnownMember.System_ValueTuple_T3__Item3 },

                                                        new[]{
                                                            WellKnownMember.System_ValueTuple_T4__Item1,
                                                            WellKnownMember.System_ValueTuple_T4__Item2,
                                                            WellKnownMember.System_ValueTuple_T4__Item3,
                                                            WellKnownMember.System_ValueTuple_T4__Item4 },

                                                        new[]{
                                                            WellKnownMember.System_ValueTuple_T5__Item1,
                                                            WellKnownMember.System_ValueTuple_T5__Item2,
                                                            WellKnownMember.System_ValueTuple_T5__Item3,
                                                            WellKnownMember.System_ValueTuple_T5__Item4,
                                                            WellKnownMember.System_ValueTuple_T5__Item5 },

                                                        new[]{
                                                            WellKnownMember.System_ValueTuple_T6__Item1,
                                                            WellKnownMember.System_ValueTuple_T6__Item2,
                                                            WellKnownMember.System_ValueTuple_T6__Item3,
                                                            WellKnownMember.System_ValueTuple_T6__Item4,
                                                            WellKnownMember.System_ValueTuple_T6__Item5,
                                                            WellKnownMember.System_ValueTuple_T6__Item6 },

                                                        new[]{
                                                            WellKnownMember.System_ValueTuple_T7__Item1,
                                                            WellKnownMember.System_ValueTuple_T7__Item2,
                                                            WellKnownMember.System_ValueTuple_T7__Item3,
                                                            WellKnownMember.System_ValueTuple_T7__Item4,
                                                            WellKnownMember.System_ValueTuple_T7__Item5,
                                                            WellKnownMember.System_ValueTuple_T7__Item6,
                                                            WellKnownMember.System_ValueTuple_T7__Item7 },

                                                        new[]{
                                                            WellKnownMember.System_ValueTuple_TRest__Item1,
                                                            WellKnownMember.System_ValueTuple_TRest__Item2,
                                                            WellKnownMember.System_ValueTuple_TRest__Item3,
                                                            WellKnownMember.System_ValueTuple_TRest__Item4,
                                                            WellKnownMember.System_ValueTuple_TRest__Item5,
                                                            WellKnownMember.System_ValueTuple_TRest__Item6,
                                                            WellKnownMember.System_ValueTuple_TRest__Item7,
                                                            WellKnownMember.System_ValueTuple_TRest__Rest }
        }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10198, 33457, 38123);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 33457, 38123);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10198, 33457, 38123);
    }
    internal partial class NamedTypeSymbolAdapter
    {
        internal NamedTypeSymbolAdapter(NamedTypeSymbol underlyingNamedTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10198, 38204, 38583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 38677, 38733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 38303, 38354);

                AdaptedNamedTypeSymbol = underlyingNamedTypeSymbol;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 38370, 38572) || true) && (underlyingNamedTypeSymbol is NativeIntegerTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10198, 38370, 38572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 38520, 38557);

                    throw f_10198_38526_38556();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10198, 38370, 38572);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10198, 38204, 38583);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 38204, 38583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 38204, 38583);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10198, 38641, 38666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 38644, 38666);
                    return f_10198_38644_38666(); DynAbs.Tracing.TraceSender.TraceExitMethod(10198, 38641, 38666);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10198, 38641, 38666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10198, 38641, 38666);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol AdaptedNamedTypeSymbol { get; }

        System.Exception
        f_10198_38526_38556()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 38526, 38556);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10198_38644_38666()
        {
            var return_v = AdaptedNamedTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10198, 38644, 38666);
            return return_v;
        }

    }
}
