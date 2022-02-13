// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Emit;
using System.Diagnostics;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal abstract class GenericTypeInstanceReference : NamedTypeReference, Cci.IGenericTypeInstanceReference
    {
        public GenericTypeInstanceReference(NamedTypeSymbol underlyingNamedType)
        : base(f_10192_991_1010_C(underlyingNamedType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10192, 898, 1301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 1036, 1083);

                f_10192_1036_1082(f_10192_1049_1081(underlyingNamedType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 1172, 1290);

                f_10192_1172_1289(!underlyingNamedType.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.Any(a => a.CustomModifiers.Any()));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10192, 898, 1301);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10192, 898, 1301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10192, 898, 1301);
            }
        }

        public sealed override void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10192, 1313, 1469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 1403, 1458);

                f_10192_1403_1457(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10192, 1313, 1469);

                int
                f_10192_1403_1457(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.GenericTypeInstanceReference
                genericTypeInstanceReference)
                {
                    this_param.Visit((Microsoft.Cci.IGenericTypeInstanceReference)genericTypeInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10192, 1403, 1457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10192, 1313, 1469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10192, 1313, 1469);
            }
        }

        ImmutableArray<Cci.ITypeReference> Cci.IGenericTypeInstanceReference.GetGenericArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10192, 1481, 2129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 1615, 1682);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 1696, 1757);

                var
                builder = f_10192_1710_1756()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 1771, 2066);
                    foreach (TypeWithAnnotations type in f_10192_1808_1876_I(f_10192_1808_1876(UnderlyingNamedType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10192, 1771, 2066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 1910, 2051);

                        f_10192_1910_2050(builder, f_10192_1922_2049(moduleBeingBuilt, type.Type, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10192, 1771, 2066);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10192, 1, 296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10192, 1, 296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 2082, 2118);

                return f_10192_2089_2117(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10192, 1481, 2129);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                f_10192_1710_1756()
                {
                    var return_v = ArrayBuilder<Cci.ITypeReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10192, 1710, 1756);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10192_1808_1876(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10192, 1808, 1876);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10192_1922_2049(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10192, 1922, 2049);
                    return return_v;
                }


                int
                f_10192_1910_2050(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param, Microsoft.Cci.ITypeReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10192, 1910, 2050);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10192_1808_1876_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10192, 1808, 1876);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                f_10192_2089_2117(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10192, 2089, 2117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10192, 1481, 2129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10192, 1481, 2129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.INamedTypeReference Cci.IGenericTypeInstanceReference.GetGenericType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10192, 2141, 2684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 2259, 2344);

                f_10192_2259_2343(f_10192_2291_2342(f_10192_2291_2329(UnderlyingNamedType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 2358, 2425);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10192, 2439, 2673);

                return f_10192_2446_2672(moduleBeingBuilt, f_10192_2473_2511(UnderlyingNamedType), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics, needDeclaration: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10192, 2141, 2684);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10192_2291_2329(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10192, 2291, 2329);
                    return return_v;
                }


                bool
                f_10192_2291_2342(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10192, 2291, 2342);
                    return return_v;
                }


                int
                f_10192_2259_2343(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10192, 2259, 2343);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10192_2473_2511(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10192, 2473, 2511);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10192_2446_2672(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10192, 2446, 2672);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10192, 2141, 2684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10192, 2141, 2684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static GenericTypeInstanceReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10192, 773, 2691);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10192, 773, 2691);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10192, 773, 2691);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10192, 773, 2691);

        bool
        f_10192_1049_1081(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10192, 1049, 1081);
            return return_v;
        }


        int
        f_10192_1036_1082(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10192, 1036, 1082);
            return 0;
        }


        int
        f_10192_1172_1289(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10192, 1172, 1289);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10192_991_1010_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10192, 898, 1301);
            return return_v;
        }

    }
}
