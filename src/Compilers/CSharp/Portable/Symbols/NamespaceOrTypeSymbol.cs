// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class NamespaceOrTypeSymbol : Symbol, INamespaceOrTypeSymbolInternal
    {
        internal NamespaceOrTypeSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10053, 1075, 1129);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10053, 1075, 1129);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 1075, 1129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 1075, 1129);
            }
        }

        public bool IsNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 1338, 1425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 1374, 1410);

                    return f_10053_1381_1385() == SymbolKind.Namespace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 1338, 1425);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10053_1381_1385()
                    {
                        var return_v = Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 1381, 1385);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 1290, 1436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 1290, 1436);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 1619, 1690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 1655, 1675);

                    return f_10053_1662_1674_M(!IsNamespace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 1619, 1690);

                    bool
                    f_10053_1662_1674_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 1662, 1674);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 1576, 1701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 1576, 1701);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 2162, 2226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 2198, 2211);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 2162, 2226);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 2100, 2237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 2100, 2237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 2712, 2776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 2748, 2761);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 2712, 2776);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 2649, 2787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 2649, 2787);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 3117, 3181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 3153, 3166);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 3117, 3181);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 3056, 3192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 3056, 3192);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract ImmutableArray<Symbol> GetMembers();

        internal virtual ImmutableArray<Symbol> GetMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 3950, 4249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 4195, 4238);

                return f_10053_4202_4214(this).ConditionallyDeOrder();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 3950, 4249);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10053_4202_4214(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 4202, 4214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 3950, 4249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 3950, 4249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract ImmutableArray<Symbol> GetMembers(string name);

        internal virtual ImmutableArray<NamedTypeSymbol> GetTypeMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 5110, 5426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 5368, 5415);

                return f_10053_5375_5391(this).ConditionallyDeOrder();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 5110, 5426);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10053_5375_5391(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 5375, 5391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 5110, 5426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 5110, 5426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract ImmutableArray<NamedTypeSymbol> GetTypeMembers();

        public abstract ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name);

        public virtual ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 6755, 7118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 7027, 7107);

                return f_10053_7034_7054(this, name).WhereAsArray((t, arity) => t.Arity == arity, arity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 6755, 7118);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10053_7034_7054(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 7034, 7054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 6755, 7118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 6755, 7118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SourceNamedTypeSymbol? GetSourceTypeMember(TypeDeclarationSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 7323, 7533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 7429, 7522);

                return f_10053_7436_7521(this, syntax.Identifier.ValueText, f_10053_7485_7497(syntax), f_10053_7499_7512(syntax), syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 7323, 7533);

                int
                f_10053_7485_7497(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 7485, 7497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10053_7499_7512(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 7499, 7512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                f_10053_7436_7521(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                syntax)
                {
                    var return_v = this_param.GetSourceTypeMember(name, arity, kind, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 7436, 7521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 7323, 7533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 7323, 7533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SourceNamedTypeSymbol? GetSourceTypeMember(DelegateDeclarationSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 7738, 7952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 7848, 7941);

                return f_10053_7855_7940(this, syntax.Identifier.ValueText, f_10053_7904_7916(syntax), f_10053_7918_7931(syntax), syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 7738, 7952);

                int
                f_10053_7904_7916(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 7904, 7916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10053_7918_7931(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 7918, 7931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol?
                f_10053_7855_7940(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                syntax)
                {
                    var return_v = this_param.GetSourceTypeMember(name, arity, kind, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 7855, 7940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 7738, 7952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 7738, 7952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SourceNamedTypeSymbol? GetSourceTypeMember(
                    string name,
                    int arity,
                    SyntaxKind kind,
                    CSharpSyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 8276, 9431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 8471, 8529);

                TypeKind
                typeKind = f_10053_8491_8528(f_10053_8491_8515(kind))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 8545, 9364);
                    foreach (var member in f_10053_8568_8595_I(f_10053_8568_8595(this, name, arity)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 8545, 9364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 8629, 8675);

                        var
                        memberT = member as SourceNamedTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 8693, 9349) || true) && ((object?)memberT != null && (DynAbs.Tracing.TraceSender.Expression_True(10053, 8697, 8753) && f_10053_8725_8741(memberT) == typeKind))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 8693, 9349);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 8795, 9330) || true) && (syntax != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 8795, 9330);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 8863, 9194);
                                    foreach (var loc in f_10053_8883_8900_I(f_10053_8883_8900(memberT)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 8863, 9194);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 8958, 9167) || true) && (f_10053_8962_8976(loc) && (DynAbs.Tracing.TraceSender.Expression_True(10053, 8962, 9015) && f_10053_8980_8994(loc) == f_10053_8998_9015(syntax)) && (DynAbs.Tracing.TraceSender.Expression_True(10053, 8962, 9055) && syntax.Span.Contains(f_10053_9040_9054(loc))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 8958, 9167);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 9121, 9136);

                                            return memberT;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 8958, 9167);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 8863, 9194);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10053, 1, 332);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10053, 1, 332);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 8795, 9330);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 8795, 9330);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 9292, 9307);

                                return memberT;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 8795, 9330);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 8693, 9349);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 8545, 9364);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10053, 1, 820);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10053, 1, 820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 9408, 9420);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 8276, 9431);

                Microsoft.CodeAnalysis.CSharp.DeclarationKind
                f_10053_8491_8515(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = kind.ToDeclarationKind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 8491, 8515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10053_8491_8528(Microsoft.CodeAnalysis.CSharp.DeclarationKind
                kind)
                {
                    var return_v = kind.ToTypeKind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 8491, 8528);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10053_8568_8595(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 8568, 8595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10053_8725_8741(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 8725, 8741);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10053_8883_8900(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 8883, 8900);
                    return return_v;
                }


                bool
                f_10053_8962_8976(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.IsInSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 8962, 8976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10053_8980_8994(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 8980, 8994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10053_8998_9015(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 8998, 9015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10053_9040_9054(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 9040, 9054);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10053_8883_8900_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 8883, 8900);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10053_8568_8595_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 8568, 8595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 8276, 9431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 8276, 9431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual NamedTypeSymbol LookupMetadataType(ref MetadataTypeName emittedTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 9884, 13702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 9998, 10036);

                f_10053_9998_10035(f_10053_10011_10034_M(!emittedTypeName.IsNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 10052, 10087);

                NamespaceOrTypeSymbol
                scope = this
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 10103, 10279) || true) && (f_10053_10107_10117(scope) == SymbolKind.ErrorType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 10103, 10279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 10175, 10264);

                    return f_10053_10182_10263((NamedTypeSymbol)scope, ref emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 10103, 10279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 10295, 10329);

                NamedTypeSymbol?
                namedType = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 10345, 10400);

                ImmutableArray<NamedTypeSymbol>
                namespaceOrTypeMembers
                = default(ImmutableArray<NamedTypeSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 10414, 10450);

                bool
                isTopLevel = f_10053_10432_10449(scope)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 10466, 10595);

                f_10053_10466_10594(!isTopLevel || (DynAbs.Tracing.TraceSender.Expression_False(10053, 10479, 10593) || f_10053_10494_10560(scope, SymbolDisplayFormat.QualifiedNameOnlyFormat) == emittedTypeName.NamespaceName));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 10611, 11852) || true) && (emittedTypeName.IsMangled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 10611, 11852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 10674, 10793);

                    f_10053_10674_10792(!f_10053_10688_10754(emittedTypeName.UnmangledTypeName, emittedTypeName.TypeName) && (DynAbs.Tracing.TraceSender.Expression_True(10053, 10687, 10791) && emittedTypeName.InferredArity > 0));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 10813, 11642) || true) && (emittedTypeName.ForcedArity == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10053, 10817, 10914) || emittedTypeName.ForcedArity == emittedTypeName.InferredArity))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 10813, 11642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 11014, 11095);

                        namespaceOrTypeMembers = f_10053_11039_11094(scope, emittedTypeName.UnmangledTypeName);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 11119, 11623);
                            foreach (var named in f_10053_11141_11163_I(namespaceOrTypeMembers))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 11119, 11623);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 11213, 11600) || true) && (emittedTypeName.InferredArity == f_10053_11250_11261(named) && (DynAbs.Tracing.TraceSender.Expression_True(10053, 11217, 11281) && f_10053_11265_11281(named)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 11213, 11600);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 11339, 11523) || true) && ((object?)namedType != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 11339, 11523);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 11435, 11452);

                                        namedType = null;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10053, 11486, 11492);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 11339, 11523);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 11555, 11573);

                                    namedType = named;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 11213, 11600);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 11119, 11623);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10053, 1, 505);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10053, 1, 505);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 10813, 11642);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 10611, 11852);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 10611, 11852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 11708, 11837);

                    f_10053_11708_11836(f_10053_11721_11797(emittedTypeName.UnmangledTypeName, emittedTypeName.TypeName) && (DynAbs.Tracing.TraceSender.Expression_True(10053, 11721, 11835) && emittedTypeName.InferredArity == 0));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 10611, 11852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 11940, 11986);

                int
                forcedArity = emittedTypeName.ForcedArity
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 12002, 12693) || true) && (emittedTypeName.UseCLSCompliantNameArityEncoding)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 12002, 12693);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 12194, 12678) || true) && (emittedTypeName.InferredArity > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 12194, 12678);

                        goto Done;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 12194, 12678);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 12194, 12678);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 12325, 12678) || true) && (forcedArity == -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 12325, 12678);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 12388, 12404);

                            forcedArity = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 12325, 12678);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 12325, 12678);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 12446, 12678) || true) && (forcedArity != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 12446, 12678);

                                goto Done;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 12446, 12678);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 12446, 12678);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 12600, 12659);

                                f_10053_12600_12658(forcedArity == emittedTypeName.InferredArity);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 12446, 12678);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 12325, 12678);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 12194, 12678);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 12002, 12693);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 12709, 12781);

                namespaceOrTypeMembers = f_10053_12734_12780(scope, emittedTypeName.TypeName);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 12797, 13219);
                    foreach (var named in f_10053_12819_12841_I(namespaceOrTypeMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 12797, 13219);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 12875, 13204) || true) && (f_10053_12879_12896_M(!named.MangleName) && (DynAbs.Tracing.TraceSender.Expression_True(10053, 12879, 12949) && (forcedArity == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10053, 12901, 12948) || forcedArity == f_10053_12937_12948(named)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 12875, 13204);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 12991, 13143) || true) && ((object?)namedType != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 12991, 13143);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 13071, 13088);

                                namedType = null;
                                DynAbs.Tracing.TraceSender.TraceBreak(10053, 13114, 13120);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 12991, 13143);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 13167, 13185);

                            namedType = named;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 12875, 13204);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 12797, 13219);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10053, 1, 423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10053, 1, 423);
                }
Done:

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 13242, 13658) || true) && ((object?)namedType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 13242, 13658);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 13306, 13643) || true) && (isTopLevel)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 13306, 13643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 13362, 13453);

                        return f_10053_13369_13452(f_10053_13408_13430(scope), ref emittedTypeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 13306, 13643);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 13306, 13643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 13535, 13624);

                        return f_10053_13542_13623((NamedTypeSymbol)scope, ref emittedTypeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 13306, 13643);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 13242, 13658);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 13674, 13691);

                return namedType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 9884, 13702);

                bool
                f_10053_10011_10034_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 10011, 10034);
                    return return_v;
                }


                int
                f_10053_9998_10035(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 9998, 10035);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10053_10107_10117(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 10107, 10117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.Nested
                f_10053_10182_10263(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                containingType, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.Nested((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 10182, 10263);
                    return return_v;
                }


                bool
                f_10053_10432_10449(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 10432, 10449);
                    return return_v;
                }


                string
                f_10053_10494_10560(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 10494, 10560);
                    return return_v;
                }


                int
                f_10053_10466_10594(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 10466, 10594);
                    return 0;
                }


                bool
                f_10053_10688_10754(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 10688, 10754);
                    return return_v;
                }


                int
                f_10053_10674_10792(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 10674, 10792);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10053_11039_11094(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 11039, 11094);
                    return return_v;
                }


                int
                f_10053_11250_11261(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 11250, 11261);
                    return return_v;
                }


                bool
                f_10053_11265_11281(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MangleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 11265, 11281);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10053_11141_11163_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 11141, 11163);
                    return return_v;
                }


                bool
                f_10053_11721_11797(string
                objA, string
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 11721, 11797);
                    return return_v;
                }


                int
                f_10053_11708_11836(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 11708, 11836);
                    return 0;
                }


                int
                f_10053_12600_12658(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 12600, 12658);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10053_12734_12780(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 12734, 12780);
                    return return_v;
                }


                bool
                f_10053_12879_12896_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 12879, 12896);
                    return return_v;
                }


                int
                f_10053_12937_12948(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 12937, 12948);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10053_12819_12841_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 12819, 12841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10053_13408_13430(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10053, 13408, 13430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10053_13369_13452(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel(module, ref fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 13369, 13452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.Nested
                f_10053_13542_13623(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                containingType, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.Nested((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 13542, 13623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 9884, 13702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 9884, 13702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<NamespaceOrTypeSymbol>? GetNamespaceOrTypeByQualifiedName(IEnumerable<string> qualifiedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10053, 14317, 15227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 14455, 14500);

                NamespaceOrTypeSymbol
                namespaceOrType = this
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 14514, 14565);

                IEnumerable<NamespaceOrTypeSymbol>?
                symbols = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 14579, 15185);
                    foreach (string name in f_10053_14603_14616_I(qualifiedName))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 14579, 15185);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 14650, 15075) || true) && (symbols != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 14650, 15075);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 14812, 14855);

                            namespaceOrType = f_10053_14830_14854(symbols);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 14877, 15056) || true) && ((object)namespaceOrType == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10053, 14877, 15056);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 14962, 15033);

                                return f_10053_14969_15032();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 14877, 15056);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 14650, 15075);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 15095, 15170);

                        symbols = f_10053_15105_15137(namespaceOrType, name).OfType<NamespaceOrTypeSymbol>();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10053, 14579, 15185);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10053, 1, 607);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10053, 1, 607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10053, 15201, 15216);

                return symbols;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10053, 14317, 15227);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10053_14830_14854(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                symbols)
                {
                    var return_v = symbols.OfMinimalArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 14830, 14854);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                f_10053_14969_15032()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<NamespaceOrTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 14969, 15032);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10053_15105_15137(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 15105, 15137);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10053_14603_14616_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10053, 14603, 14616);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10053, 14317, 15227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 14317, 15227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamespaceOrTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10053, 563, 15234);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10053, 563, 15234);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10053, 563, 15234);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10053, 563, 15234);
    }
}
