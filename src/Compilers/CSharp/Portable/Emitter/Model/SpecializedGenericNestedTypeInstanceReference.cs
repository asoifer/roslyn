// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class SpecializedGenericNestedTypeInstanceReference : SpecializedNestedTypeReference, Cci.IGenericTypeInstanceReference
    {
        public SpecializedGenericNestedTypeInstanceReference(NamedTypeSymbol underlyingNamedType)
        : base(f_10210_989_1008_C(underlyingNamedType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10210, 879, 1299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 1034, 1081);

                f_10210_1034_1080(f_10210_1047_1079(underlyingNamedType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 1170, 1288);

                f_10210_1170_1287(!underlyingNamedType.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.Any(a => a.CustomModifiers.Any()));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10210, 879, 1299);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10210, 879, 1299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10210, 879, 1299);
            }
        }

        public sealed override void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10210, 1311, 1467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 1401, 1456);

                f_10210_1401_1455(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10210, 1311, 1467);

                int
                f_10210_1401_1455(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.SpecializedGenericNestedTypeInstanceReference
                genericTypeInstanceReference)
                {
                    this_param.Visit((Microsoft.Cci.IGenericTypeInstanceReference)genericTypeInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10210, 1401, 1455);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10210, 1311, 1467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10210, 1311, 1467);
            }
        }

        ImmutableArray<Cci.ITypeReference> Cci.IGenericTypeInstanceReference.GetGenericArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10210, 1479, 2127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 1613, 1680);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 1694, 1755);

                var
                builder = f_10210_1708_1754()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 1769, 2064);
                    foreach (TypeWithAnnotations type in f_10210_1806_1874_I(f_10210_1806_1874(UnderlyingNamedType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10210, 1769, 2064);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 1908, 2049);

                        f_10210_1908_2048(builder, f_10210_1920_2047(moduleBeingBuilt, type.Type, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10210, 1769, 2064);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10210, 1, 296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10210, 1, 296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 2080, 2116);

                return f_10210_2087_2115(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10210, 1479, 2127);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                f_10210_1708_1754()
                {
                    var return_v = ArrayBuilder<Cci.ITypeReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10210, 1708, 1754);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10210_1806_1874(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10210, 1806, 1874);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10210_1920_2047(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10210, 1920, 2047);
                    return return_v;
                }


                int
                f_10210_1908_2048(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param, Microsoft.Cci.ITypeReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10210, 1908, 2048);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10210_1806_1874_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10210, 1806, 1874);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                f_10210_2087_2115(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10210, 2087, 2115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10210, 1479, 2127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10210, 1479, 2127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INamedTypeReference Cci.IGenericTypeInstanceReference.GetGenericType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10210, 2139, 2687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 2257, 2342);

                f_10210_2257_2341(f_10210_2289_2340(f_10210_2289_2327(UnderlyingNamedType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 2356, 2423);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 2437, 2676);

                return f_10210_2444_2675(moduleBeingBuilt, f_10210_2471_2514(this.UnderlyingNamedType), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics, needDeclaration: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10210, 2139, 2687);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10210_2289_2327(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10210, 2289, 2327);
                    return return_v;
                }


                bool
                f_10210_2289_2340(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10210, 2289, 2340);
                    return return_v;
                }


                int
                f_10210_2257_2341(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10210, 2257, 2341);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10210_2471_2514(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10210, 2471, 2514);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10210_2444_2675(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10210, 2444, 2675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10210, 2139, 2687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10210, 2139, 2687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Cci.IGenericTypeInstanceReference AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10210, 2804, 2824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 2810, 2822);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10210, 2804, 2824);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10210, 2699, 2835);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10210, 2699, 2835);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Cci.INamespaceTypeReference AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10210, 2940, 2960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 2946, 2958);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10210, 2940, 2960);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10210, 2847, 2971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10210, 2847, 2971);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Cci.INestedTypeReference AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10210, 3070, 3090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 3076, 3088);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10210, 3070, 3090);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10210, 2983, 3101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10210, 2983, 3101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Cci.ISpecializedNestedTypeReference AsSpecializedNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10210, 3222, 3242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10210, 3228, 3240);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10210, 3222, 3242);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10210, 3113, 3253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10210, 3113, 3253);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SpecializedGenericNestedTypeInstanceReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10210, 727, 3260);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10210, 727, 3260);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10210, 727, 3260);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10210, 727, 3260);

        bool
        f_10210_1047_1079(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10210, 1047, 1079);
            return return_v;
        }


        int
        f_10210_1034_1080(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10210, 1034, 1080);
            return 0;
        }


        int
        f_10210_1170_1287(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10210, 1170, 1287);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10210_989_1008_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10210, 879, 1299);
            return return_v;
        }

    }
}
