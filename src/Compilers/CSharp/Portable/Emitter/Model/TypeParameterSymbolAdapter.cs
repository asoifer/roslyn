// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Roslyn.Utilities;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Emit;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class
            TypeParameterSymbolAdapter : SymbolAdapter,
            Cci.IGenericParameterReference,
            Cci.IGenericMethodParameterReference,
            Cci.IGenericTypeParameterReference,
            Cci.IGenericParameter,
            Cci.IGenericMethodParameter,
            Cci.IGenericTypeParameter
    {
        bool Cci.ITypeReference.IsEnum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 983, 1004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 989, 1002);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 983, 1004);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 928, 1015);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 928, 1015);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 1087, 1108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 1093, 1106);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 1087, 1108);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 1027, 1119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 1027, 1119);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.ITypeReference.GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 1131, 1254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 1231, 1243);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 1131, 1254);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 1131, 1254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 1131, 1254);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.PrimitiveTypeCode Cci.ITypeReference.TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 1340, 1390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 1346, 1388);

                    return Cci.PrimitiveTypeCode.NotPrimitive;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 1340, 1390);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 1266, 1401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 1266, 1401);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 1485, 1530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 1491, 1528);

                    return default(TypeDefinitionHandle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 1485, 1530);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 1413, 1541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 1413, 1541);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericMethodParameter Cci.IGenericParameter.AsGenericMethodParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 1652, 1928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 1688, 1715);

                    f_10216_1688_1714(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 1735, 1881) || true) && (f_10216_1739_1787(f_10216_1739_1782(f_10216_1739_1765())) == SymbolKind.Method)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 1735, 1881);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 1850, 1862);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 1735, 1881);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 1901, 1913);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 1652, 1928);

                    int
                    f_10216_1688_1714(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 1688, 1714);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_1739_1765()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 1739, 1765);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10216_1739_1782(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 1739, 1782);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10216_1739_1787(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 1739, 1787);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 1553, 1939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 1553, 1939);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 2065, 2368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 2101, 2155);

                    f_10216_2101_2154(f_10216_2114_2153(f_10216_2114_2140()));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 2175, 2321) || true) && (f_10216_2179_2227(f_10216_2179_2222(f_10216_2179_2205())) == SymbolKind.Method)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 2175, 2321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 2290, 2302);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 2175, 2321);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 2341, 2353);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 2065, 2368);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_2114_2140()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 2114, 2140);
                        return return_v;
                    }


                    bool
                    f_10216_2114_2153(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 2114, 2153);
                        return return_v;
                    }


                    int
                    f_10216_2101_2154(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 2101, 2154);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_2179_2205()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 2179, 2205);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10216_2179_2222(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 2179, 2222);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10216_2179_2227(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 2179, 2227);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 1951, 2379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 1951, 2379);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 2499, 2519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 2505, 2517);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 2499, 2519);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 2391, 2530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 2391, 2530);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericTypeParameter Cci.IGenericParameter.AsGenericTypeParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 2637, 2916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 2673, 2700);

                    f_10216_2673_2699(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 2720, 2869) || true) && (f_10216_2724_2772(f_10216_2724_2767(f_10216_2724_2750())) == SymbolKind.NamedType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 2720, 2869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 2838, 2850);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 2720, 2869);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 2889, 2901);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 2637, 2916);

                    int
                    f_10216_2673_2699(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 2673, 2699);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_2724_2750()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 2724, 2750);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10216_2724_2767(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 2724, 2767);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10216_2724_2772(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 2724, 2772);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 2542, 2927);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 2542, 2927);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 3049, 3355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 3085, 3139);

                    f_10216_3085_3138(f_10216_3098_3137(f_10216_3098_3124()));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 3159, 3308) || true) && (f_10216_3163_3211(f_10216_3163_3206(f_10216_3163_3189())) == SymbolKind.NamedType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 3159, 3308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 3277, 3289);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 3159, 3308);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 3328, 3340);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 3049, 3355);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_3098_3124()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 3098, 3124);
                        return return_v;
                    }


                    bool
                    f_10216_3098_3137(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 3098, 3137);
                        return return_v;
                    }


                    int
                    f_10216_3085_3138(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 3085, 3138);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_3163_3189()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 3163, 3189);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10216_3163_3206(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 3163, 3206);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10216_3163_3211(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 3163, 3211);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 2939, 3366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 2939, 3366);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INamespaceTypeDefinition Cci.ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 3378, 3520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 3497, 3509);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 3378, 3520);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 3378, 3520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 3378, 3520);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INamespaceTypeReference Cci.ITypeReference.AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 3628, 3648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 3634, 3646);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 3628, 3648);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 3532, 3659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 3532, 3659);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INestedTypeDefinition Cci.ITypeReference.AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 3671, 3807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 3784, 3796);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 3671, 3807);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 3671, 3807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 3671, 3807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INestedTypeReference Cci.ITypeReference.AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 3909, 3929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 3915, 3927);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 3909, 3929);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 3819, 3940);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 3819, 3940);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ISpecializedNestedTypeReference Cci.ITypeReference.AsSpecializedNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 4064, 4084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 4070, 4082);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 4064, 4084);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 3952, 4095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 3952, 4095);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.ITypeReference.AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 4107, 4231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 4208, 4220);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 4107, 4231);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 4107, 4231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 4107, 4231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 4243, 5719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 4325, 4362);

                throw f_10216_4331_4361();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 4243, 5719);

                System.Exception
                f_10216_4331_4361()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 4331, 4361);
                    return return_v;
                }

                //We've not yet discovered a scenario in which we need this.
                //If you're hitting this exception, uncomment the code below
                //and add a unit test.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 4243, 5719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 4243, 5719);
            }
        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 5731, 5911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 5820, 5874);

                f_10216_5820_5873(f_10216_5833_5872(f_10216_5833_5859()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 5888, 5900);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 5731, 5911);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10216_5833_5859()
                {
                    var return_v = AdaptedTypeParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 5833, 5859);
                    return return_v;
                }


                bool
                f_10216_5833_5872(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 5833, 5872);
                    return return_v;
                }


                int
                f_10216_5820_5873(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 5820, 5873);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 5731, 5911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 5731, 5911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 5976, 6031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 5982, 6029);

                    return f_10216_5989_6028(f_10216_5989_6015());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 5976, 6031);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_5989_6015()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 5989, 6015);
                        return return_v;
                    }


                    string
                    f_10216_5989_6028(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 5989, 6028);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 5923, 6042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 5923, 6042);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ushort Cci.IParameterListEntry.Index
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 6115, 6216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 6151, 6201);

                    return (ushort)f_10216_6166_6200(f_10216_6166_6192());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 6115, 6216);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_6166_6192()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 6166, 6192);
                        return return_v;
                    }


                    int
                    f_10216_6166_6200(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 6166, 6200);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 6054, 6227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 6054, 6227);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMethodReference Cci.IGenericMethodParameterReference.DefiningMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 6336, 6542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 6372, 6426);

                    f_10216_6372_6425(f_10216_6385_6424(f_10216_6385_6411()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 6444, 6527);

                    return f_10216_6451_6526(((MethodSymbol)f_10216_6466_6509(f_10216_6466_6492())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 6336, 6542);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_6385_6411()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 6385, 6411);
                        return return_v;
                    }


                    bool
                    f_10216_6385_6424(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 6385, 6424);
                        return return_v;
                    }


                    int
                    f_10216_6372_6425(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 6372, 6425);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_6466_6492()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 6466, 6492);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10216_6466_6509(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 6466, 6509);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10216_6451_6526(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 6451, 6526);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 6239, 6553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 6239, 6553);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.IGenericTypeParameterReference.DefiningType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 6656, 6865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 6692, 6746);

                    f_10216_6692_6745(f_10216_6705_6744(f_10216_6705_6731()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 6764, 6850);

                    return f_10216_6771_6849(((NamedTypeSymbol)f_10216_6789_6832(f_10216_6789_6815())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 6656, 6865);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_6705_6731()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 6705, 6731);
                        return return_v;
                    }


                    bool
                    f_10216_6705_6744(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 6705, 6744);
                        return return_v;
                    }


                    int
                    f_10216_6692_6745(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 6692, 6745);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_6789_6815()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 6789, 6815);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10216_6789_6832(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 6789, 6832);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    f_10216_6771_6849(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 6771, 6849);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 6565, 6876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 6565, 6876);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<Cci.TypeReferenceWithAttributes> Cci.IGenericParameter.GetConstraints(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 6888, 9791);

                var listYield = new List<Cci.TypeReferenceWithAttributes>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 7015, 7070);

                var
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 7086, 7112);

                var
                seenValueType = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 7126, 8079) || true) && (f_10216_7130_7183(f_10216_7130_7156()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 7126, 8079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 7217, 7447);

                    var
                    typeRef = f_10216_7231_7446(moduleBeingBuilt, SpecialType.System_ValueType, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 7467, 7647);

                    var
                    modifier = f_10216_7482_7646(f_10216_7540_7645(moduleBeingBuilt.Compilation, WellKnownType.System_Runtime_InteropServices_UnmanagedType))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 7813, 7956);

                    listYield.Add(f_10216_7826_7955(f_10216_7862_7954(typeRef, f_10216_7901_7953(modifier))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 8043, 8064);

                    seenValueType = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 7126, 8079);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 8095, 9190);
                    foreach (var type in f_10216_8116_8178_I(f_10216_8116_8178(f_10216_8116_8142())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 8095, 9190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 8212, 8574);

                        switch (type.SpecialType)
                        {

                            case SpecialType.System_Object:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 8212, 8574);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 8335, 8388);

                                f_10216_8335_8387(!f_10216_8349_8386(type.NullableAnnotation));
                                DynAbs.Tracing.TraceSender.TraceBreak(10216, 8414, 8420);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 8212, 8574);

                            case SpecialType.System_ValueType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 8212, 8574);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 8502, 8523);

                                seenValueType = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10216, 8549, 8555);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 8212, 8574);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 8592, 8856);

                        var
                        typeRef = f_10216_8606_8855(moduleBeingBuilt, type.Type, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 8876, 9175);

                        listYield.Add(type.GetTypeRefWithAttributes(moduleBeingBuilt, declaringSymbol: f_10216_9077_9103(), typeRef));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 8095, 9190);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10216, 1, 1096);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10216, 1, 1096);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 9206, 9780) || true) && (f_10216_9210_9259(f_10216_9210_9236()) && (DynAbs.Tracing.TraceSender.Expression_True(10216, 9210, 9277) && !seenValueType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 9206, 9780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 9391, 9687);

                    var
                    typeRef = f_10216_9405_9686(moduleBeingBuilt, SpecialType.System_ValueType, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 9707, 9765);

                    listYield.Add(f_10216_9720_9764(typeRef));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 9206, 9780);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 6888, 9791);

                return listYield;

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10216_7130_7156()
                {
                    var return_v = AdaptedTypeParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 7130, 7156);
                    return return_v;
                }


                bool
                f_10216_7130_7183(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 7130, 7183);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10216_7231_7446(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetSpecialType(specialType, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 7231, 7446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10216_7540_7645(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 7540, 7645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomModifier
                f_10216_7482_7646(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CSharpCustomModifier.CreateRequired(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 7482, 7646);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_10216_7901_7953(Microsoft.CodeAnalysis.CustomModifier
                item)
                {
                    var return_v = ImmutableArray.Create<Cci.ICustomModifier>((Microsoft.Cci.ICustomModifier)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 7901, 7953);
                    return return_v;
                }


                Microsoft.Cci.ModifiedTypeReference
                f_10216_7862_7954(Microsoft.Cci.INamedTypeReference
                modifiedType, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    var return_v = new Microsoft.Cci.ModifiedTypeReference((Microsoft.Cci.ITypeReference)modifiedType, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 7862, 7954);
                    return return_v;
                }


                Microsoft.Cci.TypeReferenceWithAttributes
                f_10216_7826_7955(Microsoft.Cci.ModifiedTypeReference
                typeRef)
                {
                    var return_v = new Microsoft.Cci.TypeReferenceWithAttributes((Microsoft.Cci.ITypeReference)typeRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 7826, 7955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10216_8116_8142()
                {
                    var return_v = AdaptedTypeParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 8116, 8142);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10216_8116_8178(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 8116, 8178);
                    return return_v;
                }


                bool
                f_10216_8349_8386(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 8349, 8386);
                    return return_v;
                }


                int
                f_10216_8335_8387(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 8335, 8387);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_10216_8606_8855(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 8606, 8855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10216_9077_9103()
                {
                    var return_v = AdaptedTypeParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 9077, 9103);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10216_8116_8178_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 8116, 8178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10216_9210_9236()
                {
                    var return_v = AdaptedTypeParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 9210, 9236);
                    return return_v;
                }


                bool
                f_10216_9210_9259(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 9210, 9259);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10216_9405_9686(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetSpecialType(specialType, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 9405, 9686);
                    return return_v;
                }


                Microsoft.Cci.TypeReferenceWithAttributes
                f_10216_9720_9764(Microsoft.Cci.INamedTypeReference
                typeRef)
                {
                    var return_v = new Microsoft.Cci.TypeReferenceWithAttributes((Microsoft.Cci.ITypeReference)typeRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 9720, 9764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 6888, 9791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 6888, 9791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool Cci.IGenericParameter.MustBeReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 9874, 9986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 9910, 9971);

                    return f_10216_9917_9970(f_10216_9917_9943());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 9874, 9986);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_9917_9943()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 9917, 9943);
                        return return_v;
                    }


                    bool
                    f_10216_9917_9970(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasReferenceTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 9917, 9970);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 9803, 9997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 9803, 9997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IGenericParameter.MustBeValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 10076, 10241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 10112, 10226);

                    return f_10216_10119_10168(f_10216_10119_10145()) || (DynAbs.Tracing.TraceSender.Expression_False(10216, 10119, 10225) || f_10216_10172_10225(f_10216_10172_10198()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 10076, 10241);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_10119_10145()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10119, 10145);
                        return return_v;
                    }


                    bool
                    f_10216_10119_10168(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasValueTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10119, 10168);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_10172_10198()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10172, 10198);
                        return return_v;
                    }


                    bool
                    f_10216_10172_10225(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasUnmanagedTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10172, 10225);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 10009, 10252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 10009, 10252);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IGenericParameter.MustHaveDefaultConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 10342, 10763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 10579, 10748);

                    return f_10216_10586_10637(f_10216_10586_10612()) || (DynAbs.Tracing.TraceSender.Expression_False(10216, 10586, 10690) || f_10216_10641_10690(f_10216_10641_10667())) || (DynAbs.Tracing.TraceSender.Expression_False(10216, 10586, 10747) || f_10216_10694_10747(f_10216_10694_10720()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 10342, 10763);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_10586_10612()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10586, 10612);
                        return return_v;
                    }


                    bool
                    f_10216_10586_10637(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasConstructorConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10586, 10637);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_10641_10667()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10641, 10667);
                        return return_v;
                    }


                    bool
                    f_10216_10641_10690(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasValueTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10641, 10690);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_10694_10720()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10694, 10720);
                        return return_v;
                    }


                    bool
                    f_10216_10694_10747(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasUnmanagedTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10694, 10747);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 10264, 10774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 10264, 10774);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.TypeParameterVariance Cci.IGenericParameter.Variance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 10867, 11478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 10903, 11463);

                    switch (f_10216_10911_10946(f_10216_10911_10937()))
                    {

                        case VarianceKind.None:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 10903, 11463);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 11037, 11081);

                            return Cci.TypeParameterVariance.NonVariant;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 10903, 11463);

                        case VarianceKind.In:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 10903, 11463);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 11150, 11197);

                            return Cci.TypeParameterVariance.Contravariant;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 10903, 11463);

                        case VarianceKind.Out:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 10903, 11463);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 11267, 11310);

                            return Cci.TypeParameterVariance.Covariant;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 10903, 11463);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 10903, 11463);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 11366, 11444);

                            throw f_10216_11372_11443(f_10216_11407_11442(f_10216_11407_11433()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 10903, 11463);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 10867, 11478);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_10911_10937()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10911, 10937);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.VarianceKind
                    f_10216_10911_10946(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Variance;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 10911, 10946);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_11407_11433()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 11407, 11433);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.VarianceKind
                    f_10216_11407_11442(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Variance;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 11407, 11442);
                        return return_v;
                    }


                    System.Exception
                    f_10216_11372_11443(Microsoft.CodeAnalysis.VarianceKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 11372, 11443);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 10786, 11489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 10786, 11489);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IMethodDefinition Cci.IGenericMethodParameter.DefiningMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 11590, 11769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 11626, 11653);

                    f_10216_11626_11652(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 11671, 11754);

                    return f_10216_11678_11753(((MethodSymbol)f_10216_11693_11736(f_10216_11693_11719())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 11590, 11769);

                    int
                    f_10216_11626_11652(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 11626, 11652);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_11693_11719()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 11693, 11719);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10216_11693_11736(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 11693, 11736);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                    f_10216_11678_11753(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 11678, 11753);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 11501, 11780);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 11501, 11780);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.IGenericTypeParameter.DefiningType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 11875, 12057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 11911, 11938);

                    f_10216_11911_11937(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 11956, 12042);

                    return f_10216_11963_12041(((NamedTypeSymbol)f_10216_11981_12024(f_10216_11981_12007())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 11875, 12057);

                    int
                    f_10216_11911_11937(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                    this_param)
                    {
                        this_param.CheckDefinitionInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 11911, 11937);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10216_11981_12007()
                    {
                        var return_v = AdaptedTypeParameterSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 11981, 12007);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10216_11981_12024(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 11981, 12024);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                    f_10216_11963_12041(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 11963, 12041);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 11792, 12068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 11792, 12068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static TypeParameterSymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10216, 540, 12075);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10216, 540, 12075);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 540, 12075);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10216, 540, 12075);
    }
    internal partial class TypeParameterSymbol
    {
        private TypeParameterSymbolAdapter _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 12273, 12291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 12276, 12291);
                return f_10216_12276_12291(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 12273, 12291);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 12273, 12291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 12273, 12291);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
            f_10216_12276_12291(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 12276, 12291);
                return return_v;
            }

        }

        internal new TypeParameterSymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 12304, 12600);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 12384, 12553) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10216, 12384, 12553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 12442, 12538);

                    return f_10216_12449_12537(ref _lazyAdapter, f_10216_12500_12536(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10216, 12384, 12553);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 12569, 12589);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 12304, 12600);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                f_10216_12500_12536(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                underlyingTypeParameterSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter(underlyingTypeParameterSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 12500, 12536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                f_10216_12449_12537(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10216, 12449, 12537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 12304, 12600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 12304, 12600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10216, 12083, 12804);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10216, 12083, 12804);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 12083, 12804);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10216, 12083, 12804);
    }
    internal partial class TypeParameterSymbolAdapter
    {
        internal TypeParameterSymbolAdapter(TypeParameterSymbol underlyingTypeParameterSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10216, 12889, 13070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 13168, 13232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 13000, 13059);

                AdaptedTypeParameterSymbol = underlyingTypeParameterSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10216, 12889, 13070);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 12889, 13070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 12889, 13070);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10216, 13128, 13157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 13131, 13157);
                    return f_10216_13131_13157(); DynAbs.Tracing.TraceSender.TraceExitMethod(10216, 13128, 13157);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10216, 13128, 13157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10216, 13128, 13157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TypeParameterSymbol AdaptedTypeParameterSymbol { get; }

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        f_10216_13131_13157()
        {
            var return_v = AdaptedTypeParameterSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10216, 13131, 13157);
            return return_v;
        }

    }
}
