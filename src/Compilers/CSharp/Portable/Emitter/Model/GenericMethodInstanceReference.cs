// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class GenericMethodInstanceReference : MethodReference, Cci.IGenericMethodInstanceReference
    {
        public GenericMethodInstanceReference(MethodSymbol underlyingMethod)
        : base(f_10189_820_836_C(underlyingMethod))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10189, 731, 859);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10189, 731, 859);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10189, 731, 859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10189, 731, 859);
            }
        }

        public override void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10189, 871, 1022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10189, 954, 1011);

                f_10189_954_1010(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10189, 871, 1022);

                int
                f_10189_954_1010(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.GenericMethodInstanceReference
                genericMethodInstanceReference)
                {
                    this_param.Visit((Microsoft.Cci.IGenericMethodInstanceReference)genericMethodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10189, 954, 1010);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10189, 871, 1022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10189, 871, 1022);
            }
        }

        IEnumerable<Cci.ITypeReference> Cci.IGenericMethodInstanceReference.GetGenericArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10189, 1034, 1575);

                var listYield = new List<Cci.ITypeReference>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10189, 1167, 1234);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10189, 1250, 1564);
                    foreach (var arg in f_10189_1270_1315_I(f_10189_1270_1315(UnderlyingMethod)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10189, 1250, 1564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10189, 1349, 1391);

                        f_10189_1349_1390(arg.CustomModifiers.IsEmpty);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10189, 1409, 1549);

                        listYield.Add(f_10189_1422_1548(moduleBeingBuilt, arg.Type, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10189, 1250, 1564);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10189, 1, 315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10189, 1, 315);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10189, 1034, 1575);

                return listYield;

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10189_1270_1315(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10189, 1270, 1315);
                    return return_v;
                }


                int
                f_10189_1349_1390(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10189, 1349, 1390);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_10189_1422_1548(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10189, 1422, 1548);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10189_1270_1315_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10189, 1270, 1315);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10189, 1034, 1575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10189, 1034, 1575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IMethodReference Cci.IGenericMethodInstanceReference.GetGenericMethod(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10189, 1587, 2041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10189, 1760, 2030);

                return f_10189_1767_2029(((PEModuleBuilder)context.Module), f_10189_1829_1864(UnderlyingMethod), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics, needDeclaration: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10189, 1587, 2041);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10189_1829_1864(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10189, 1829, 1864);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10189_1767_2029(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(methodSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10189, 1767, 2029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10189, 1587, 2041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10189, 1587, 2041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Cci.IGenericMethodInstanceReference AsGenericMethodInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10189, 2162, 2225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10189, 2198, 2210);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10189, 2162, 2225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10189, 2053, 2236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10189, 2053, 2236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static GenericMethodInstanceReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10189, 607, 2243);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10189, 607, 2243);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10189, 607, 2243);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10189, 607, 2243);

        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10189_820_836_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10189, 731, 859);
            return return_v;
        }

    }
}
