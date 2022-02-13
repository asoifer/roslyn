// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class GenericNestedTypeInstanceReference : GenericTypeInstanceReference, Cci.INestedTypeReference
    {
        public GenericNestedTypeInstanceReference(NamedTypeSymbol underlyingNamedType)
        : base(f_10191_759_778_C(underlyingNamedType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10191, 660, 801);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10191, 660, 801);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10191, 660, 801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10191, 660, 801);
            }
        }

        Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10191, 813, 1108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10191, 920, 1097);

                return f_10191_927_1096(((PEModuleBuilder)context.Module), f_10191_971_1005(UnderlyingNamedType), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10191, 813, 1108);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10191_971_1005(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10191, 971, 1005);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10191_927_1096(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10191, 927, 1096);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10191, 813, 1108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10191, 813, 1108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Cci.IGenericTypeInstanceReference AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10191, 1225, 1245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10191, 1231, 1243);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10191, 1225, 1245);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10191, 1120, 1256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10191, 1120, 1256);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10191, 1361, 1381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10191, 1367, 1379);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10191, 1361, 1381);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10191, 1268, 1392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10191, 1268, 1392);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10191, 1491, 1511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10191, 1497, 1509);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10191, 1491, 1511);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10191, 1404, 1522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10191, 1404, 1522);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10191, 1643, 1663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10191, 1649, 1661);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10191, 1643, 1663);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10191, 1534, 1674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10191, 1534, 1674);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static GenericNestedTypeInstanceReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10191, 530, 1681);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10191, 530, 1681);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10191, 530, 1681);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10191, 530, 1681);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10191_759_778_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10191, 660, 801);
            return return_v;
        }

    }
}
