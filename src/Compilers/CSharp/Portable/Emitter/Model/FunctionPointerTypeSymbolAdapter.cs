// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Threading;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class
            FunctionPointerTypeSymbolAdapter : SymbolAdapter,
            IFunctionPointerTypeReference
    {
        private FunctionPointerMethodSignature? _lazySignature;

        ISignature IFunctionPointerTypeReference.Signature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 868, 1182);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 904, 1125) || true) && (_lazySignature is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10188, 904, 1125);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 972, 1106);

                        f_10188_972_1105(ref _lazySignature, f_10188_1020_1098(f_10188_1055_1097(f_10188_1055_1087())), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10188, 904, 1125);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 1145, 1167);

                    return _lazySignature;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 868, 1182);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    f_10188_1055_1087()
                    {
                        var return_v = AdaptedFunctionPointerTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 1055, 1087);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    f_10188_1055_1097(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Signature;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 1055, 1097);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter.FunctionPointerMethodSignature
                    f_10188_1020_1098(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    underlying)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter.FunctionPointerMethodSignature(underlying);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 1020, 1098);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter.FunctionPointerMethodSignature?
                    f_10188_972_1105(ref Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter.FunctionPointerMethodSignature?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter.FunctionPointerMethodSignature
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter.FunctionPointerMethodSignature?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 972, 1105);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 793, 1193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 793, 1193);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void Dispatch(MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 1253, 1306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 1256, 1306);
                f_10188_1256_1306(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 1253, 1306);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 1253, 1306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 1253, 1306);
            }

            int
            f_10188_1256_1306(Microsoft.Cci.MetadataVisitor
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter
            functionPointerTypeReference)
            {
                this_param.Visit((Microsoft.Cci.IFunctionPointerTypeReference)functionPointerTypeReference);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 1256, 1306);
                return 0;
            }

        }

        bool ITypeReference.IsEnum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 1346, 1354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 1349, 1354);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 1346, 1354);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 1346, 1354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 1346, 1354);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.PrimitiveTypeCode ITypeReference.TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 1411, 1451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 1414, 1451);
                    return Cci.PrimitiveTypeCode.FunctionPointer; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 1411, 1451);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 1411, 1451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 1411, 1451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        TypeDefinitionHandle ITypeReference.TypeDef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 1506, 1516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 1509, 1516);
                    return default; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 1506, 1516);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 1506, 1516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 1506, 1516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IGenericMethodParameterReference? ITypeReference.AsGenericMethodParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 1610, 1617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 1613, 1617);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 1610, 1617);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 1610, 1617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 1610, 1617);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IGenericTypeInstanceReference? ITypeReference.AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 1705, 1712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 1708, 1712);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 1705, 1712);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 1705, 1712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 1705, 1712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IGenericTypeParameterReference? ITypeReference.AsGenericTypeParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 1802, 1809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 1805, 1809);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 1802, 1809);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 1802, 1809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 1802, 1809);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamespaceTypeReference? ITypeReference.AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 1885, 1892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 1888, 1892);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 1885, 1892);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 1885, 1892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 1885, 1892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INestedTypeReference? ITypeReference.AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 1962, 1969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 1965, 1969);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 1962, 1969);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 1962, 1969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 1962, 1969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ISpecializedNestedTypeReference? ITypeReference.AsSpecializedNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 2061, 2068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 2064, 2068);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 2061, 2068);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 2061, 2068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 2061, 2068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamespaceTypeDefinition? ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 2167, 2174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 2170, 2174);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 2167, 2174);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 2167, 2174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 2167, 2174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        INestedTypeDefinition? ITypeReference.AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 2267, 2274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 2270, 2274);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 2267, 2274);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 2267, 2274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 2267, 2274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ITypeDefinition? ITypeReference.AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 2355, 2362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 2358, 2362);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 2355, 2362);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 2355, 2362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 2355, 2362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ITypeDefinition? ITypeReference.GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 2442, 2449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 2445, 2449);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 2442, 2449);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 2442, 2449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 2442, 2449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool ITypeReference.IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 2492, 2539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 2495, 2539);
                    return f_10188_2495_2539(f_10188_2495_2527()); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 2492, 2539);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 2492, 2539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 2492, 2539);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<ICustomAttribute> GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 2628, 2689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 2631, 2689);
                return f_10188_2631_2689(); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 2628, 2689);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 2628, 2689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 2628, 2689);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
            f_10188_2631_2689()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<ICustomAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 2631, 2689);
                return return_v;
            }

        }

        IDefinition? AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 2758, 2765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 2761, 2765);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 2758, 2765);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 2758, 2765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 2758, 2765);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class FunctionPointerMethodSignature : ISignature
        {
            private readonly FunctionPointerMethodSymbol _underlying;

            internal ISignature Underlying
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 3362, 3392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 3365, 3392);
                        return f_10188_3365_3392(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 3362, 3392);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 3362, 3392);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 3362, 3392);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal FunctionPointerMethodSignature(FunctionPointerMethodSymbol underlying)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10188, 3409, 3561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 3305, 3316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 3521, 3546);

                    _underlying = underlying;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10188, 3409, 3561);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 3409, 3561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 3409, 3561);
                }
            }

            public CallingConvention CallingConvention
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 3620, 3651);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 3623, 3651);
                        return f_10188_3623_3651(f_10188_3623_3633()); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 3620, 3651);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 3620, 3651);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 3620, 3651);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ushort ParameterCount
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 3695, 3723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 3698, 3723);
                        return f_10188_3698_3723(f_10188_3698_3708()); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 3695, 3723);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 3695, 3723);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 3695, 3723);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ImmutableArray<ICustomModifier> ReturnValueCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 3804, 3844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 3807, 3844);
                        return f_10188_3807_3844(f_10188_3807_3817()); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 3804, 3844);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 3804, 3844);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 3804, 3844);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ImmutableArray<ICustomModifier> RefCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 3917, 3949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 3920, 3949);
                        return f_10188_3920_3949(f_10188_3920_3930()); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 3917, 3949);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 3917, 3949);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 3917, 3949);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool ReturnValueIsByRef
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 3995, 4027);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 3998, 4027);
                        return f_10188_3998_4027(f_10188_3998_4008()); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 3995, 4027);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 3995, 4027);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 3995, 4027);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ImmutableArray<IParameterTypeInformation> GetParameters(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 4145, 4181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 4148, 4181);
                    return f_10188_4148_4181(f_10188_4148_4158(), context); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 4145, 4181);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 4145, 4181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 4145, 4181);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.Cci.ISignature
                f_10188_4148_4158()
                {
                    var return_v = Underlying;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 4148, 4158);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_10188_4148_4181(Microsoft.Cci.ISignature
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetParameters(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 4148, 4181);
                    return return_v;
                }

            }

            public ITypeReference GetType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 4247, 4277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 4250, 4277);
                    return f_10188_4250_4277(f_10188_4250_4260(), context); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 4247, 4277);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 4247, 4277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 4247, 4277);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.Cci.ISignature
                f_10188_4250_4260()
                {
                    var return_v = Underlying;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 4250, 4260);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10188_4250_4277(Microsoft.Cci.ISignature
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 4250, 4277);
                    return return_v;
                }

            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 4294, 4566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 4514, 4551);

                    throw f_10188_4520_4550();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 4294, 4566);

                    System.Exception
                    f_10188_4520_4550()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 4520, 4550);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 4294, 4566);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 4294, 4566);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 4759, 4798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 4762, 4798);
                    throw f_10188_4768_4798(); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 4759, 4798);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 4759, 4798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 4759, 4798);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10188_4768_4798()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 4768, 4798);
                    return return_v;
                }

            }

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 4849, 4922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 4852, 4922);
                    return f_10188_4852_4922(_underlying, SymbolDisplayFormat.ILVisualizationFormat); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 4849, 4922);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 4849, 4922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 4849, 4922);
                }
                throw new System.Exception("Slicer error: unreachable code");

                string
                f_10188_4852_4922(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 4852, 4922);
                    return return_v;
                }

            }

            static FunctionPointerMethodSignature()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10188, 3171, 4934);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10188, 3171, 4934);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 3171, 4934);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10188, 3171, 4934);

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
            f_10188_3365_3392(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 3365, 3392);
                return return_v;
            }


            Microsoft.Cci.ISignature
            f_10188_3623_3633()
            {
                var return_v = Underlying;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 3623, 3633);
                return return_v;
            }


            Microsoft.Cci.CallingConvention
            f_10188_3623_3651(Microsoft.Cci.ISignature
            this_param)
            {
                var return_v = this_param.CallingConvention;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 3623, 3651);
                return return_v;
            }


            Microsoft.Cci.ISignature
            f_10188_3698_3708()
            {
                var return_v = Underlying;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 3698, 3708);
                return return_v;
            }


            ushort
            f_10188_3698_3723(Microsoft.Cci.ISignature
            this_param)
            {
                var return_v = this_param.ParameterCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 3698, 3723);
                return return_v;
            }


            Microsoft.Cci.ISignature
            f_10188_3807_3817()
            {
                var return_v = Underlying;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 3807, 3817);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
            f_10188_3807_3844(Microsoft.Cci.ISignature
            this_param)
            {
                var return_v = this_param.ReturnValueCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 3807, 3844);
                return return_v;
            }


            Microsoft.Cci.ISignature
            f_10188_3920_3930()
            {
                var return_v = Underlying;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 3920, 3930);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
            f_10188_3920_3949(Microsoft.Cci.ISignature
            this_param)
            {
                var return_v = this_param.RefCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 3920, 3949);
                return return_v;
            }


            Microsoft.Cci.ISignature
            f_10188_3998_4008()
            {
                var return_v = Underlying;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 3998, 4008);
                return return_v;
            }


            bool
            f_10188_3998_4027(Microsoft.Cci.ISignature
            this_param)
            {
                var return_v = this_param.ReturnValueIsByRef;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 3998, 4027);
                return return_v;
            }

        }

        static FunctionPointerTypeSymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10188, 520, 4941);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10188, 520, 4941);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 520, 4941);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10188, 520, 4941);

        Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        f_10188_2495_2527()
        {
            var return_v = AdaptedFunctionPointerTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 2495, 2527);
            return return_v;
        }


        bool
        f_10188_2495_2539(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsValueType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 2495, 2539);
            return return_v;
        }

    }
    internal partial class FunctionPointerTypeSymbol
    {
        private FunctionPointerTypeSymbolAdapter? _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 5152, 5170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 5155, 5170);
                return f_10188_5155_5170(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 5152, 5170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 5152, 5170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 5152, 5170);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter
            f_10188_5155_5170(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 5155, 5170);
                return return_v;
            }

        }

        internal new FunctionPointerTypeSymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 5183, 5491);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 5269, 5444) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10188, 5269, 5444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 5327, 5429);

                    return f_10188_5334_5428(ref _lazyAdapter, f_10188_5385_5427(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10188, 5269, 5444);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 5460, 5480);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 5183, 5491);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter
                f_10188_5385_5427(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                underlyingFunctionPointerTypeSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter(underlyingFunctionPointerTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 5385, 5427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter
                f_10188_5334_5428(ref Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10188, 5334, 5428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 5183, 5491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 5183, 5491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FunctionPointerTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10188, 4949, 5714);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10188, 4949, 5714);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 4949, 5714);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10188, 4949, 5714);
    }
    internal partial class FunctionPointerTypeSymbolAdapter
    {
        internal FunctionPointerTypeSymbolAdapter(FunctionPointerTypeSymbol underlyingFunctionPointerTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10188, 5805, 6016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 768, 782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 6120, 6196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 5934, 6005);

                AdaptedFunctionPointerTypeSymbol = underlyingFunctionPointerTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10188, 5805, 6016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 5805, 6016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 5805, 6016);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10188, 6074, 6109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 6077, 6109);
                    return f_10188_6077_6109(); DynAbs.Tracing.TraceSender.TraceExitMethod(10188, 6074, 6109);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10188, 6074, 6109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10188, 6074, 6109);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal FunctionPointerTypeSymbol AdaptedFunctionPointerTypeSymbol { get; }

        Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
        f_10188_6077_6109()
        {
            var return_v = AdaptedFunctionPointerTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10188, 6077, 6109);
            return return_v;
        }

    }
}
