// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class
            ArrayTypeSymbolAdapter : SymbolAdapter,
            Cci.IArrayTypeReference
    {
        Cci.ITypeReference Cci.IArrayTypeReference.GetElementType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 652, 1395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 755, 822);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 838, 922);

                TypeWithAnnotations
                elementType = f_10181_872_921(f_10181_872_894())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 936, 1082);

                var
                type = f_10181_947_1081(moduleBeingBuilt, elementType.Type, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 1098, 1384) || true) && (elementType.CustomModifiers.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10181, 1098, 1384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 1175, 1187);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10181, 1098, 1384);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10181, 1098, 1384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 1253, 1369);

                    return f_10181_1260_1368(type, ImmutableArray<Cci.ICustomModifier>.CastUp(elementType.CustomModifiers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10181, 1098, 1384);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 652, 1395);

                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10181_872_894()
                {
                    var return_v = AdaptedArrayTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 872, 894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10181_872_921(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 872, 921);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10181_947_1081(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10181, 947, 1081);
                    return return_v;
                }


                Microsoft.Cci.ModifiedTypeReference
                f_10181_1260_1368(Microsoft.Cci.ITypeReference
                modifiedType, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    var return_v = new Microsoft.Cci.ModifiedTypeReference(modifiedType, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10181, 1260, 1368);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 652, 1395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 652, 1395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool Cci.IArrayTypeReference.IsSZArray
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 1470, 1561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 1506, 1546);

                    return f_10181_1513_1545(f_10181_1513_1535());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 1470, 1561);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    f_10181_1513_1535()
                    {
                        var return_v = AdaptedArrayTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 1513, 1535);
                        return return_v;
                    }


                    bool
                    f_10181_1513_1545(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSZArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 1513, 1545);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 1407, 1572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 1407, 1572);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<int> Cci.IArrayTypeReference.LowerBounds
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 1640, 1677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 1643, 1677);
                    return f_10181_1643_1677(f_10181_1643_1665()); DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 1640, 1677);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 1640, 1677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 1640, 1677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        int Cci.IArrayTypeReference.Rank
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 1721, 1751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 1724, 1751);
                    return f_10181_1724_1751(f_10181_1724_1746()); DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 1721, 1751);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 1721, 1751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 1721, 1751);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<int> Cci.IArrayTypeReference.Sizes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 1812, 1843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 1815, 1843);
                    return f_10181_1815_1843(f_10181_1815_1837()); DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 1812, 1843);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 1812, 1843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 1812, 1843);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 1856, 1994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 1938, 1983);

                f_10181_1938_1982(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 1856, 1994);

                int
                f_10181_1938_1982(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbolAdapter
                arrayTypeReference)
                {
                    this_param.Visit((Microsoft.Cci.IArrayTypeReference)arrayTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10181, 1938, 1982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 1856, 1994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 1856, 1994);
            }
        }

        bool Cci.ITypeReference.IsEnum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 2037, 2045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 2040, 2045);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 2037, 2045);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 2037, 2045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 2037, 2045);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 2092, 2100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 2095, 2100);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 2092, 2100);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 2092, 2100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 2092, 2100);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 2161, 2193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 2164, 2193);
                    return default(TypeDefinitionHandle); DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 2161, 2193);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 2161, 2193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 2161, 2193);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.PrimitiveTypeCode Cci.ITypeReference.TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 2254, 2291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 2257, 2291);
                    return Cci.PrimitiveTypeCode.NotPrimitive; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 2254, 2291);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 2254, 2291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 2254, 2291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition? Cci.ITypeReference.GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 2381, 2388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 2384, 2388);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 2381, 2388);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 2381, 2388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 2381, 2388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IGenericMethodParameterReference? Cci.ITypeReference.AsGenericMethodParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 2490, 2497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 2493, 2497);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 2490, 2497);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 2490, 2497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 2490, 2497);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericTypeInstanceReference? Cci.ITypeReference.AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 2593, 2600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 2596, 2600);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 2593, 2600);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 2593, 2600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 2593, 2600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IGenericTypeParameterReference? Cci.ITypeReference.AsGenericTypeParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 2698, 2705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 2701, 2705);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 2698, 2705);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 2698, 2705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 2698, 2705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INamespaceTypeDefinition? Cci.ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 2812, 2819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 2815, 2819);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 2812, 2819);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 2812, 2819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 2812, 2819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INamespaceTypeReference? Cci.ITypeReference.AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 2903, 2910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 2906, 2910);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 2903, 2910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 2903, 2910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 2903, 2910);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INestedTypeDefinition? Cci.ITypeReference.AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 3011, 3018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 3014, 3018);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 3011, 3018);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 3011, 3018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 3011, 3018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INestedTypeReference? Cci.ITypeReference.AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 3096, 3103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 3099, 3103);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 3096, 3103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 3096, 3103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 3096, 3103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ISpecializedNestedTypeReference? Cci.ITypeReference.AsSpecializedNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 3203, 3210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 3206, 3210);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 3203, 3210);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 3203, 3210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 3203, 3210);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition? Cci.ITypeReference.AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 3299, 3306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 3302, 3306);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 3299, 3306);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 3299, 3306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 3299, 3306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IDefinition? AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 3383, 3390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 3386, 3390);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 3383, 3390);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 3383, 3390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 3383, 3390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ArrayTypeSymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10181, 477, 3398);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10181, 477, 3398);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 477, 3398);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10181, 477, 3398);

        Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        f_10181_1643_1665()
        {
            var return_v = AdaptedArrayTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 1643, 1665);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<int>
        f_10181_1643_1677(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        this_param)
        {
            var return_v = this_param.LowerBounds;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 1643, 1677);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        f_10181_1724_1746()
        {
            var return_v = AdaptedArrayTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 1724, 1746);
            return return_v;
        }


        int
        f_10181_1724_1751(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        this_param)
        {
            var return_v = this_param.Rank;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 1724, 1751);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        f_10181_1815_1837()
        {
            var return_v = AdaptedArrayTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 1815, 1837);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<int>
        f_10181_1815_1843(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        this_param)
        {
            var return_v = this_param.Sizes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 1815, 1843);
            return return_v;
        }

    }
    internal partial class ArrayTypeSymbol
    {
        private ArrayTypeSymbolAdapter? _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 3589, 3607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 3592, 3607);
                return f_10181_3592_3607(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 3589, 3607);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 3589, 3607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 3589, 3607);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbolAdapter
            f_10181_3592_3607(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10181, 3592, 3607);
                return return_v;
            }

        }

        internal new ArrayTypeSymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 3620, 3908);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 3696, 3861) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10181, 3696, 3861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 3754, 3846);

                    return f_10181_3761_3845(ref _lazyAdapter, f_10181_3812_3844(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10181, 3696, 3861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 3877, 3897);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 3620, 3908);

                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbolAdapter
                f_10181_3812_3844(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                underlyingArrayTypeSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbolAdapter(underlyingArrayTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10181, 3812, 3844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbolAdapter
                f_10181_3761_3845(ref Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10181, 3761, 3845);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 3620, 3908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 3620, 3908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ArrayTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10181, 3406, 4100);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10181, 3406, 4100);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 3406, 4100);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10181, 3406, 4100);
    }
    internal partial class ArrayTypeSymbolAdapter
    {
        internal ArrayTypeSymbolAdapter(ArrayTypeSymbol underlyingArrayTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10181, 4181, 4342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 4436, 4492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 4280, 4331);

                AdaptedArrayTypeSymbol = underlyingArrayTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10181, 4181, 4342);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 4181, 4342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 4181, 4342);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10181, 4400, 4425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10181, 4403, 4425);
                    return f_10181_4403_4425(); DynAbs.Tracing.TraceSender.TraceExitMethod(10181, 4400, 4425);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10181, 4400, 4425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10181, 4400, 4425);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ArrayTypeSymbol AdaptedArrayTypeSymbol { get; }

        Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        f_10181_4403_4425()
        {
            var return_v = AdaptedArrayTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10181, 4403, 4425);
            return return_v;
        }

    }
}
