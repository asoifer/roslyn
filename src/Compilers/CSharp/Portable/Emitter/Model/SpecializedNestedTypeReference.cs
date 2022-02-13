// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal class SpecializedNestedTypeReference : NamedTypeReference, Cci.ISpecializedNestedTypeReference
    {
        public SpecializedNestedTypeReference(NamedTypeSymbol underlyingNamedType)
        : base(f_10212_790_809_C(underlyingNamedType))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10212, 695, 832);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10212, 695, 832);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10212, 695, 832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10212, 695, 832);
            }
        }

        Cci.INestedTypeReference Cci.ISpecializedNestedTypeReference.GetUnspecializedVersion(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10212, 844, 1390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10212, 974, 1040);

                f_10212_974_1039(f_10212_987_1038(f_10212_987_1025(UnderlyingNamedType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10212, 1054, 1306);

                var
                result = f_10212_1067_1305(f_10212_1067_1283(((PEModuleBuilder)context.Module), f_10212_1111_1154(this.UnderlyingNamedType), (CSharpSyntaxNode)context.SyntaxNodeOpt, context.Diagnostics, needDeclaration: true))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10212, 1322, 1351);

                f_10212_1322_1350(result != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10212, 1365, 1379);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10212, 844, 1390);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10212_987_1025(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10212, 987, 1025);
                    return return_v;
                }


                bool
                f_10212_987_1038(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10212, 987, 1038);
                    return return_v;
                }


                int
                f_10212_974_1039(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10212, 974, 1039);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10212_1111_1154(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10212, 1111, 1154);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10212_1067_1283(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10212, 1067, 1283);
                    return return_v;
                }


                Microsoft.Cci.INestedTypeReference?
                f_10212_1067_1305(Microsoft.Cci.INamedTypeReference
                this_param)
                {
                    var return_v = this_param.AsNestedTypeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10212, 1067, 1305);
                    return return_v;
                }


                int
                f_10212_1322_1350(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10212, 1322, 1350);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10212, 844, 1390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10212, 844, 1390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10212, 1402, 1553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10212, 1485, 1542);

                f_10212_1485_1541(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10212, 1402, 1553);

                int
                f_10212_1485_1541(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.Cci.ISpecializedNestedTypeReference
                nestedTypeReference)
                {
                    this_param.Visit((Microsoft.Cci.INestedTypeReference)nestedTypeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10212, 1485, 1541);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10212, 1402, 1553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10212, 1402, 1553);
            }
        }

        Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10212, 1565, 1832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10212, 1672, 1821);

                return f_10212_1679_1820(((PEModuleBuilder)context.Module), f_10212_1723_1757(UnderlyingNamedType), (CSharpSyntaxNode)context.SyntaxNodeOpt, context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10212, 1565, 1832);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10212_1723_1757(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10212, 1723, 1757);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10212_1679_1820(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10212, 1679, 1820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10212, 1565, 1832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10212, 1565, 1832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Cci.IGenericTypeInstanceReference AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10212, 1949, 1969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10212, 1955, 1967);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10212, 1949, 1969);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10212, 1844, 1980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10212, 1844, 1980);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10212, 2085, 2105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10212, 2091, 2103);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10212, 2085, 2105);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10212, 1992, 2116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10212, 1992, 2116);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10212, 2215, 2235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10212, 2221, 2233);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10212, 2215, 2235);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10212, 2128, 2246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10212, 2128, 2246);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10212, 2367, 2387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10212, 2373, 2385);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10212, 2367, 2387);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10212, 2258, 2398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10212, 2258, 2398);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SpecializedNestedTypeReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10212, 575, 2405);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10212, 575, 2405);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10212, 575, 2405);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10212, 575, 2405);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10212_790_809_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10212, 695, 832);
            return return_v;
        }

    }
}
