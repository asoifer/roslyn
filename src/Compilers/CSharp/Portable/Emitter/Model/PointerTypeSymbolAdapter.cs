// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class
            PointerTypeSymbolAdapter : SymbolAdapter,
            Cci.IPointerTypeReference
    {
        Cci.ITypeReference Cci.IPointerTypeReference.GetTargetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 644, 1330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 748, 933);

                var
                type = f_10205_759_932(((PEModuleBuilder)context.Module), f_10205_803_841(f_10205_803_827()), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 949, 1319) || true) && (f_10205_953_977().PointedAtTypeWithAnnotations.CustomModifiers.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10205, 949, 1319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 1068, 1080);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10205, 949, 1319);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10205, 949, 1319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 1146, 1304);

                    return f_10205_1153_1303(type, ImmutableArray<Cci.ICustomModifier>.CastUp(f_10205_1232_1256().PointedAtTypeWithAnnotations.CustomModifiers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10205, 949, 1319);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 644, 1330);

                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10205_803_827()
                {
                    var return_v = AdaptedPointerTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10205, 803, 827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10205_803_841(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10205, 803, 841);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10205_759_932(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10205, 759, 932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10205_953_977()
                {
                    var return_v = AdaptedPointerTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10205, 953, 977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10205_1232_1256()
                {
                    var return_v = AdaptedPointerTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10205, 1232, 1256);
                    return return_v;
                }


                Microsoft.Cci.ModifiedTypeReference
                f_10205_1153_1303(Microsoft.Cci.ITypeReference
                modifiedType, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                customModifiers)
                {
                    var return_v = new Microsoft.Cci.ModifiedTypeReference(modifiedType, customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10205, 1153, 1303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 644, 1330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 644, 1330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool Cci.ITypeReference.IsEnum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 1397, 1418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 1403, 1416);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 1397, 1418);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 1342, 1429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 1342, 1429);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 1501, 1522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 1507, 1520);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 1501, 1522);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 1441, 1533);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 1441, 1533);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.ITypeReference.GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 1545, 1668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 1645, 1657);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 1545, 1668);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 1545, 1668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 1545, 1668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.PrimitiveTypeCode Cci.ITypeReference.TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 1754, 1799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 1760, 1797);

                    return Cci.PrimitiveTypeCode.Pointer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 1754, 1799);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 1680, 1810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 1680, 1810);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 1894, 1939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 1900, 1937);

                    return default(TypeDefinitionHandle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 1894, 1939);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 1822, 1950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 1822, 1950);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 2076, 2096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 2082, 2094);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 2076, 2096);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 1962, 2107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 1962, 2107);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 2227, 2247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 2233, 2245);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 2227, 2247);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 2119, 2258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 2119, 2258);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 2380, 2400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 2386, 2398);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 2380, 2400);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 2270, 2411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 2270, 2411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INamespaceTypeDefinition Cci.ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 2423, 2565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 2542, 2554);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 2423, 2565);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 2423, 2565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 2423, 2565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INamespaceTypeReference Cci.ITypeReference.AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 2673, 2693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 2679, 2691);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 2673, 2693);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 2577, 2704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 2577, 2704);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.INestedTypeDefinition Cci.ITypeReference.AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 2716, 2852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 2829, 2841);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 2716, 2852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 2716, 2852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 2716, 2852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INestedTypeReference Cci.ITypeReference.AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 2954, 2974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 2960, 2972);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 2954, 2974);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 2864, 2985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 2864, 2985);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 3109, 3129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 3115, 3127);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 3109, 3129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 2997, 3140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 2997, 3140);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeDefinition Cci.ITypeReference.AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 3152, 3276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 3253, 3265);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 3152, 3276);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 3152, 3276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 3152, 3276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 3288, 3428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 3370, 3417);

                f_10205_3370_3416(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 3288, 3428);

                int
                f_10205_3370_3416(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbolAdapter
                pointerTypeReference)
                {
                    this_param.Visit((Microsoft.Cci.IPointerTypeReference)pointerTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10205, 3370, 3416);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 3288, 3428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 3288, 3428);
            }
        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 3440, 3552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 3529, 3541);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 3440, 3552);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 3440, 3552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 3440, 3552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PointerTypeSymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10205, 463, 3559);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10205, 463, 3559);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 463, 3559);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10205, 463, 3559);
    }
    internal partial class PointerTypeSymbol
    {
        private PointerTypeSymbolAdapter _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 3753, 3771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 3756, 3771);
                return f_10205_3756_3771(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 3753, 3771);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 3753, 3771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 3753, 3771);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbolAdapter
            f_10205_3756_3771(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10205, 3756, 3771);
                return return_v;
            }

        }

        internal new PointerTypeSymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 3784, 4076);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 3862, 4029) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10205, 3862, 4029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 3920, 4014);

                    return f_10205_3927_4013(ref _lazyAdapter, f_10205_3978_4012(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10205, 3862, 4029);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 4045, 4065);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 3784, 4076);

                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbolAdapter
                f_10205_3978_4012(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                underlyingPointerTypeSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbolAdapter(underlyingPointerTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10205, 3978, 4012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbolAdapter
                f_10205_3927_4013(ref Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10205, 3927, 4013);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 3784, 4076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 3784, 4076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PointerTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10205, 3567, 4274);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10205, 3567, 4274);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 3567, 4274);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10205, 3567, 4274);
    }
    internal partial class PointerTypeSymbolAdapter
    {
        internal PointerTypeSymbolAdapter(PointerTypeSymbol underlyingPointerTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10205, 4357, 4528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 4624, 4684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 4462, 4517);

                AdaptedPointerTypeSymbol = underlyingPointerTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10205, 4357, 4528);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 4357, 4528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 4357, 4528);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10205, 4586, 4613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10205, 4589, 4613);
                    return f_10205_4589_4613(); DynAbs.Tracing.TraceSender.TraceExitMethod(10205, 4586, 4613);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10205, 4586, 4613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10205, 4586, 4613);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PointerTypeSymbol AdaptedPointerTypeSymbol { get; }

        Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
        f_10205_4589_4613()
        {
            var return_v = AdaptedPointerTypeSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10205, 4589, 4613);
            return return_v;
        }

    }
}
