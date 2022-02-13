// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal abstract class TypeMemberReference : Cci.ITypeMemberReference
    {
        protected abstract Symbol UnderlyingSymbol { get; }

        public virtual Cci.ITypeReference GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10215, 530, 848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10215, 627, 694);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10215, 708, 837);

                return f_10215_715_836(moduleBeingBuilt, f_10215_742_773(f_10215_742_758()), (CSharpSyntaxNode)context.SyntaxNodeOpt, context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10215, 530, 848);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10215_742_758()
                {
                    var return_v = UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10215, 742, 758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10215_742_773(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10215, 742, 773);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10215_715_836(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10215, 715, 836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10215, 530, 848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10215, 530, 848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10215, 913, 1001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10215, 949, 986);

                    return f_10215_956_985(f_10215_956_972());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10215, 913, 1001);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10215_956_972()
                    {
                        var return_v = UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10215, 956, 972);
                        return return_v;
                    }


                    string
                    f_10215_956_985(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10215, 956, 985);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10215, 860, 1012);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10215, 860, 1012);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10215, 1107, 1259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10215, 1165, 1248);

                return f_10215_1172_1247(f_10215_1172_1188(), SymbolDisplayFormat.ILVisualizationFormat);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10215, 1107, 1259);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10215_1172_1188()
                {
                    var return_v = UnderlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10215, 1172, 1188);
                    return return_v;
                }


                string
                f_10215_1172_1247(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10215, 1172, 1247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10215, 1107, 1259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10215, 1107, 1259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10215, 1271, 1460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10215, 1379, 1449);

                return f_10215_1386_1448();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10215, 1271, 1460);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_10215_1386_1448()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10215, 1386, 1448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10215, 1271, 1460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10215, 1271, 1460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract void Dispatch(Cci.MetadataVisitor visitor);

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10215, 1543, 1655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10215, 1632, 1644);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10215, 1543, 1655);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10215, 1543, 1655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10215, 1543, 1655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10215, 1739, 1758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10215, 1742, 1758);
                return f_10215_1742_1758(); DynAbs.Tracing.TraceSender.TraceExitMethod(10215, 1739, 1758);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10215, 1739, 1758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10215, 1739, 1758);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbol
            f_10215_1742_1758()
            {
                var return_v = UnderlyingSymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10215, 1742, 1758);
                return return_v;
            }

        }

        public sealed override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10215, 1771, 2050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10215, 1985, 2039);

                throw f_10215_1991_2038();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10215, 1771, 2050);

                System.Exception
                f_10215_1991_2038()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10215, 1991, 2038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10215, 1771, 2050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10215, 1771, 2050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10215, 2062, 2335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10215, 2270, 2324);

                throw f_10215_2276_2323();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10215, 2062, 2335);

                System.Exception
                f_10215_2276_2323()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10215, 2276, 2323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10215, 2062, 2335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10215, 2062, 2335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeMemberReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10215, 380, 2342);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10215, 380, 2342);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10215, 380, 2342);
        }


        static TypeMemberReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10215, 380, 2342);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10215, 380, 2342);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10215, 380, 2342);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10215, 380, 2342);
    }
}
