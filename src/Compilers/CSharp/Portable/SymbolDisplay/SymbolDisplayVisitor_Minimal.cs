// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class SymbolDisplayVisitor
    {
        private bool TryAddAlias(
                    INamespaceOrTypeSymbol symbol,
                    ArrayBuilder<SymbolDisplayPart> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10959, 644, 1736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 792, 827);

                var
                alias = f_10959_804_826(this, symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 841, 1696) || true) && (alias != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 841, 1696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1116, 1143);

                    var
                    aliasName = f_10959_1132_1142(alias)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1163, 1254);

                    var
                    boundSymbols = f_10959_1182_1253(semanticModelOpt, positionOpt, name: aliasName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1274, 1681) || true) && (boundSymbols.Length == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 1274, 1681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1344, 1393);

                        var
                        boundAlias = boundSymbols[0] as IAliasSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1415, 1662) || true) && ((object)boundAlias != null && (DynAbs.Tracing.TraceSender.Expression_True(10959, 1419, 1476) && f_10959_1449_1476(f_10959_1449_1461(alias), symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 1415, 1662);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1526, 1601);

                            f_10959_1526_1600(builder, f_10959_1538_1599(this, SymbolDisplayPartKind.AliasName, alias, aliasName));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1627, 1639);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 1415, 1662);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 1274, 1681);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 841, 1696);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1712, 1725);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10959, 644, 1736);

                Microsoft.CodeAnalysis.IAliasSymbol
                f_10959_804_826(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetAliasSymbol(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 804, 826);
                    return return_v;
                }


                string
                f_10959_1132_1142(Microsoft.CodeAnalysis.IAliasSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 1132, 1142);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10959_1182_1253(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupNamespacesAndTypes(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 1182, 1253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                f_10959_1449_1461(Microsoft.CodeAnalysis.IAliasSymbol
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 1449, 1461);
                    return return_v;
                }


                bool
                f_10959_1449_1476(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                this_param, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 1449, 1476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10959_1538_1599(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.IAliasSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 1538, 1599);
                    return return_v;
                }


                int
                f_10959_1526_1600(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 1526, 1600);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 644, 1736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 644, 1736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool ShouldRestrictMinimallyQualifyLookupToNamespacesAndTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10959, 1748, 2140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1855, 1928);

                var
                token = f_10959_1867_1927(f_10959_1867_1904(f_10959_1867_1894(semanticModelOpt)), positionOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1942, 1971);

                var
                startNode = token.Parent
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 1987, 2129);

                return f_10959_1994_2063(startNode as ExpressionSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(10959, 1994, 2102) || token.IsKind(SyntaxKind.NewKeyword)) || (DynAbs.Tracing.TraceSender.Expression_False(10959, 1994, 2128) || this.inNamespaceOrType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10959, 1748, 2140);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10959_1867_1894(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 1867, 1894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10959_1867_1904(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 1867, 1904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10959_1867_1927(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindToken(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 1867, 1927);
                    return return_v;
                }


                bool
                f_10959_1994_2063(Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = SyntaxFacts.IsInNamespaceOrTypeContext((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 1994, 2063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 1748, 2140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 1748, 2140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void MinimallyQualify(INamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10959, 2152, 5083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 2310, 2387);

                f_10959_2310_2386(f_10959_2323_2349(symbol) != null || (DynAbs.Tracing.TraceSender.Expression_False(10959, 2323, 2385) || f_10959_2361_2385(symbol)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 2554, 2701) || true) && (f_10959_2558_2582(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 2554, 2701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 2679, 2686);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 2554, 2701);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 2980, 3228);

                var
                symbols = (DynAbs.Tracing.TraceSender.Conditional_F1(10959, 2994, 3052) || ((f_10959_2994_3052(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10959, 3072, 3145)) || DynAbs.Tracing.TraceSender.Conditional_F3(10959, 3165, 3227))) ? f_10959_3072_3145(semanticModelOpt, positionOpt, name: f_10959_3133_3144(symbol)) : f_10959_3165_3227(semanticModelOpt, positionOpt, name: f_10959_3215_3226(symbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 3242, 3303);

                var
                firstSymbol = f_10959_3260_3302(symbols.OfType<ISymbol>())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 3317, 4906) || true) && (symbols.Length != 1 || (DynAbs.Tracing.TraceSender.Expression_False(10959, 3321, 3380) || firstSymbol == null) || (DynAbs.Tracing.TraceSender.Expression_False(10959, 3321, 3428) || !f_10959_3402_3428(firstSymbol, symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 3317, 4906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 3624, 3817);

                    var
                    containingNamespace = (DynAbs.Tracing.TraceSender.Conditional_F1(10959, 3650, 3684) || ((f_10959_3650_3676(symbol) == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10959, 3708, 3712)) || DynAbs.Tracing.TraceSender.Conditional_F3(10959, 3736, 3816))) ? null
                    : f_10959_3736_3816(f_10959_3736_3764(semanticModelOpt), f_10959_3789_3815(symbol))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 3835, 4891) || true) && (containingNamespace != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 3835, 4891);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 3908, 4872) || true) && (f_10959_3912_3949(containingNamespace))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 3908, 4872);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 3999, 4337);

                            f_10959_3999_4336(f_10959_4012_4039(format) == SymbolDisplayGlobalNamespaceStyle.Included || (DynAbs.Tracing.TraceSender.Expression_False(10959, 4012, 4204) || f_10959_4132_4159(format) == SymbolDisplayGlobalNamespaceStyle.Omitted) || (DynAbs.Tracing.TraceSender.Expression_False(10959, 4012, 4335) || f_10959_4251_4278(format) == SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 4365, 4640) || true) && (f_10959_4369_4396(format) == SymbolDisplayGlobalNamespaceStyle.Included)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 4365, 4640);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 4500, 4540);

                                f_10959_4500_4539(this, containingNamespace);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 4570, 4613);

                                f_10959_4570_4612(this, SyntaxKind.ColonColonToken);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 4365, 4640);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 3908, 4872);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 3908, 4872);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 4738, 4787);

                            f_10959_4738_4786(containingNamespace, f_10959_4765_4785(this));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 4813, 4849);

                            f_10959_4813_4848(this, SyntaxKind.DotToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 3908, 4872);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 3835, 4891);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 3317, 4906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 4990, 5072);

                f_10959_4990_5071(
                            // If we bound properly, then we'll just add our name.
                            builder, f_10959_5002_5070(this, SymbolDisplayPartKind.NamespaceName, symbol, f_10959_5058_5069(symbol)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10959, 2152, 5083);

                Microsoft.CodeAnalysis.INamespaceSymbol
                f_10959_2323_2349(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 2323, 2349);
                    return return_v;
                }


                bool
                f_10959_2361_2385(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 2361, 2385);
                    return return_v;
                }


                int
                f_10959_2310_2386(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 2310, 2386);
                    return 0;
                }


                bool
                f_10959_2558_2582(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 2558, 2582);
                    return return_v;
                }


                bool
                f_10959_2994_3052(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.ShouldRestrictMinimallyQualifyLookupToNamespacesAndTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 2994, 3052);
                    return return_v;
                }


                string
                f_10959_3133_3144(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 3133, 3144);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10959_3072_3145(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupNamespacesAndTypes(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 3072, 3145);
                    return return_v;
                }


                string
                f_10959_3215_3226(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 3215, 3226);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10959_3165_3227(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupSymbols(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 3165, 3227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10959_3260_3302(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                source)
                {
                    var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 3260, 3302);
                    return return_v;
                }


                bool
                f_10959_3402_3428(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 3402, 3428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol?
                f_10959_3650_3676(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 3650, 3676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_10959_3736_3764(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 3736, 3764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol
                f_10959_3789_3815(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 3789, 3815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol?
                f_10959_3736_3816(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                namespaceSymbol)
                {
                    var return_v = this_param.GetCompilationNamespace(namespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 3736, 3816);
                    return return_v;
                }


                bool
                f_10959_3912_3949(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 3912, 3949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_10959_4012_4039(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 4012, 4039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_10959_4132_4159(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 4132, 4159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_10959_4251_4278(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 4251, 4278);
                    return return_v;
                }


                int
                f_10959_3999_4336(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 3999, 4336);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
                f_10959_4369_4396(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GlobalNamespaceStyle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 4369, 4396);
                    return return_v;
                }


                int
                f_10959_4500_4539(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                globalNamespace)
                {
                    this_param.AddGlobalNamespace(globalNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 4500, 4539);
                    return 0;
                }


                int
                f_10959_4570_4612(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 4570, 4612);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10959_4765_4785(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 4765, 4785);
                    return return_v;
                }


                int
                f_10959_4738_4786(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 4738, 4786);
                    return 0;
                }


                int
                f_10959_4813_4848(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 4813, 4848);
                    return 0;
                }


                string
                f_10959_5058_5069(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 5058, 5069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10959_5002_5070(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.INamespaceSymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, (Microsoft.CodeAnalysis.ISymbol)symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 5002, 5070);
                    return return_v;
                }


                int
                f_10959_4990_5071(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 4990, 5071);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 2152, 5083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 2152, 5083);
            }
        }

        private void MinimallyQualify(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10959, 5095, 7769);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 5785, 7698) || true) && (!(f_10959_5791_5813(symbol) || (DynAbs.Tracing.TraceSender.Expression_False(10959, 5791, 5835) || f_10959_5817_5835(symbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 5785, 7698);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 5870, 7683) || true) && (!f_10959_5875_5916(this, symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 5870, 7683);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 6128, 7664) || true) && (f_10959_6132_6171(this, f_10959_6149_6170(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 6128, 7664);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 6221, 6272);

                            f_10959_6221_6271(f_10959_6221_6242(symbol), f_10959_6250_6270(this));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 6298, 6334);

                            f_10959_6298_6333(this, SyntaxKind.DotToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 6128, 7664);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 6128, 7664);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 6432, 6641);

                            var
                            containingNamespace = (DynAbs.Tracing.TraceSender.Conditional_F1(10959, 6458, 6492) || ((f_10959_6458_6484(symbol) == null
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10959, 6524, 6528)) || DynAbs.Tracing.TraceSender.Conditional_F3(10959, 6560, 6640))) ? null
                            : f_10959_6560_6640(f_10959_6560_6588(semanticModelOpt), f_10959_6613_6639(symbol))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 6667, 7641) || true) && (containingNamespace != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 6667, 7641);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 6756, 7614) || true) && (f_10959_6760_6797(containingNamespace))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 6756, 7614);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 7070, 7334) || true) && (f_10959_7074_7089(symbol) != TypeKind.Error)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 7070, 7334);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 7181, 7218);

                                        f_10959_7181_7217(this, SyntaxKind.GlobalKeyword);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 7256, 7299);

                                        f_10959_7256_7298(this, SyntaxKind.ColonColonToken);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 7070, 7334);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 6756, 7614);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 6756, 7614);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 7464, 7513);

                                    f_10959_7464_7512(containingNamespace, f_10959_7491_7511(this));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 7547, 7583);

                                    f_10959_7547_7582(this, SyntaxKind.DotToken);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 6756, 7614);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 6667, 7641);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 6128, 7664);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 5870, 7683);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 5785, 7698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 7714, 7758);

                f_10959_7714_7757(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10959, 5095, 7769);

                bool
                f_10959_5791_5813(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 5791, 5813);
                    return return_v;
                }


                bool
                f_10959_5817_5835(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 5817, 5835);
                    return return_v;
                }


                bool
                f_10959_5875_5916(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.NameBoundSuccessfullyToSameSymbol(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 5875, 5916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10959_6149_6170(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 6149, 6170);
                    return return_v;
                }


                bool
                f_10959_6132_6171(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                namedType)
                {
                    var return_v = this_param.IncludeNamedType(namedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 6132, 6171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10959_6221_6242(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 6221, 6242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10959_6250_6270(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 6250, 6270);
                    return return_v;
                }


                int
                f_10959_6221_6271(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 6221, 6271);
                    return 0;
                }


                int
                f_10959_6298_6333(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 6298, 6333);
                    return 0;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol
                f_10959_6458_6484(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 6458, 6484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_10959_6560_6588(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 6560, 6588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol
                f_10959_6613_6639(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 6613, 6639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol?
                f_10959_6560_6640(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                namespaceSymbol)
                {
                    var return_v = this_param.GetCompilationNamespace(namespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 6560, 6640);
                    return return_v;
                }


                bool
                f_10959_6760_6797(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 6760, 6797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10959_7074_7089(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 7074, 7089);
                    return return_v;
                }


                int
                f_10959_7181_7217(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 7181, 7217);
                    return 0;
                }


                int
                f_10959_7256_7298(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 7256, 7298);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10959_7491_7511(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 7491, 7511);
                    return return_v;
                }


                int
                f_10959_7464_7512(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 7464, 7512);
                    return 0;
                }


                int
                f_10959_7547_7582(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 7547, 7582);
                    return 0;
                }


                int
                f_10959_7714_7757(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    this_param.AddNameAndTypeArgumentsOrParameters(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 7714, 7757);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 5095, 7769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 5095, 7769);
            }
        }

        private IDictionary<INamespaceOrTypeSymbol, IAliasSymbol> CreateAliasMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10959, 7781, 10057);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 7880, 8037) || true) && (f_10959_7884_7902_M(!this.IsMinimizing))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 7880, 8037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 7936, 8022);

                    return f_10959_7943_8021();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 7880, 8037);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 8223, 8251);

                SemanticModel
                semanticModel
                = default(SemanticModel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 8265, 8278);

                int
                position
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 8292, 8650) || true) && (f_10959_8296_8339(semanticModelOpt))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 8292, 8650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 8373, 8418);

                    semanticModel = f_10959_8389_8417(semanticModelOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 8436, 8495);

                    position = f_10959_8447_8494(semanticModelOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 8292, 8650);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 8292, 8650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 8561, 8594);

                    semanticModel = semanticModelOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 8612, 8635);

                    position = positionOpt;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 8292, 8650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 8666, 8733);

                var
                token = f_10959_8678_8732(f_10959_8678_8712(f_10959_8678_8702(semanticModel)), position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 8747, 8776);

                var
                startNode = token.Parent
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 9056, 9128);

                var
                usingDirective = f_10959_9077_9127(startNode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 9142, 9258) || true) && (usingDirective != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 9142, 9258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 9202, 9243);

                    startNode = f_10959_9214_9242(f_10959_9214_9235(usingDirective));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 9142, 9258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 9274, 9668);

                var
                usingAliases = f_10959_9293_9667(f_10959_9293_9627(f_10959_9293_9545(f_10959_9293_9499(f_10959_9293_9394(f_10959_9293_9350(startNode), n => n.Usings), f_10959_9420_9498(f_10959_9420_9472(startNode), c => c.Usings)), u => u.Alias != null), u => semanticModel.GetDeclaredSymbol(u) as IAliasSymbol), u => u != null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 9684, 9772);

                var
                builder = f_10959_9698_9771()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 9786, 10001);
                    foreach (var alias in f_10959_9808_9820_I(usingAliases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 9786, 10001);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 9854, 9986) || true) && (!f_10959_9859_9892(builder, f_10959_9879_9891(alias)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 9854, 9986);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 9934, 9967);

                            f_10959_9934_9966(builder, f_10959_9946_9958(alias), alias);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 9854, 9986);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 9786, 10001);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10959, 1, 216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10959, 1, 216);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 10017, 10046);

                return f_10959_10024_10045(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10959, 7781, 10057);

                bool
                f_10959_7884_7902_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 7884, 7902);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>
                f_10959_7943_8021()
                {
                    var return_v = SpecializedCollections.EmptyDictionary<INamespaceOrTypeSymbol, IAliasSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 7943, 8021);
                    return return_v;
                }


                bool
                f_10959_8296_8339(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.IsSpeculativeSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 8296, 8339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_10959_8389_8417(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.ParentModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 8389, 8417);
                    return return_v;
                }


                int
                f_10959_8447_8494(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.OriginalPositionForSpeculation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 8447, 8494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10959_8678_8702(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 8678, 8702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10959_8678_8712(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 8678, 8712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10959_8678_8732(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindToken(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 8678, 8732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                f_10959_9077_9127(Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = GetAncestorOrThis<UsingDirectiveSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9077, 9127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10959_9214_9235(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 9214, 9235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10959_9214_9242(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 9214, 9242);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax>
                f_10959_9293_9350(Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = GetAncestorsOrThis<NamespaceDeclarationSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9293, 9350);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                f_10959_9293_9394(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>>
                selector)
                {
                    var return_v = source.SelectMany<Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9293, 9394);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax>
                f_10959_9420_9472(Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = GetAncestorsOrThis<CompilationUnitSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9420, 9472);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                f_10959_9420_9498(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>>
                selector)
                {
                    var return_v = source.SelectMany<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9420, 9498);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                f_10959_9293_9499(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9293, 9499);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                f_10959_9293_9545(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9293, 9545);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IAliasSymbol?>
                f_10959_9293_9627(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax, Microsoft.CodeAnalysis.IAliasSymbol>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax, Microsoft.CodeAnalysis.IAliasSymbol?>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9293, 9627);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IAliasSymbol?>
                f_10959_9293_9667(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IAliasSymbol?>
                source, System.Func<Microsoft.CodeAnalysis.IAliasSymbol, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.IAliasSymbol?>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9293, 9667);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>.Builder
                f_10959_9698_9771()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<INamespaceOrTypeSymbol, IAliasSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9698, 9771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                f_10959_9879_9891(Microsoft.CodeAnalysis.IAliasSymbol?
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 9879, 9891);
                    return return_v;
                }


                bool
                f_10959_9859_9892(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>.Builder
                this_param, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9859, 9892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                f_10959_9946_9958(Microsoft.CodeAnalysis.IAliasSymbol
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 9946, 9958);
                    return return_v;
                }


                int
                f_10959_9934_9966(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>.Builder
                this_param, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                key, Microsoft.CodeAnalysis.IAliasSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9934, 9966);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IAliasSymbol?>
                f_10959_9808_9820_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IAliasSymbol?>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 9808, 9820);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>
                f_10959_10024_10045(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 10024, 10045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 7781, 10057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 7781, 10057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ITypeSymbol GetRangeVariableType(IRangeVariableSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10959, 10069, 11549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 10163, 10187);

                ITypeSymbol
                type = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 10203, 11510) || true) && (f_10959_10207_10224(this) && (DynAbs.Tracing.TraceSender.Expression_True(10959, 10207, 10253) && f_10959_10228_10253_M(!symbol.Locations.IsEmpty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 10203, 11510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 10287, 10327);

                    var
                    location = symbol.Locations.First()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 10345, 11495) || true) && (f_10959_10349_10368(location) && (DynAbs.Tracing.TraceSender.Expression_True(10959, 10349, 10422) && f_10959_10372_10391(location) == f_10959_10395_10422(semanticModelOpt)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 10345, 11495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 10464, 10529);

                        var
                        token = f_10959_10476_10528(f_10959_10476_10505(f_10959_10476_10495(location)), positionOpt)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 10551, 10587);

                        var
                        queryBody = f_10959_10567_10586(token)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 10609, 11228) || true) && (queryBody != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 10609, 11228);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 10937, 11000);

                            var
                            identifierName = f_10959_10958_10999(f_10959_10987_10998(symbol))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 11026, 11205);

                            type = f_10959_11033_11199(semanticModelOpt, f_10959_11103_11126(queryBody).Span.End - 1, identifierName, SpeculativeBindingOption.BindAsExpression).Type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 10609, 11228);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 11252, 11306);

                        var
                        identifier = token.Parent as IdentifierNameSyntax
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 11328, 11476) || true) && (identifier != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 11328, 11476);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 11400, 11453);

                            type = f_10959_11407_11447(semanticModelOpt, identifier).Type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 11328, 11476);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 10345, 11495);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 10203, 11510);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 11526, 11538);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10959, 10069, 11549);

                bool
                f_10959_10207_10224(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.IsMinimizing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 10207, 10224);
                    return return_v;
                }


                bool
                f_10959_10228_10253_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 10228, 10253);
                    return return_v;
                }


                bool
                f_10959_10349_10368(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.IsInSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 10349, 10368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10959_10372_10391(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 10372, 10391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10959_10395_10422(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 10395, 10422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10959_10476_10495(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 10476, 10495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10959_10476_10505(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 10476, 10505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10959_10476_10528(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindToken(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 10476, 10528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10959_10567_10586(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = GetQueryBody(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 10567, 10586);
                    return return_v;
                }


                string
                f_10959_10987_10998(Microsoft.CodeAnalysis.IRangeVariableSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 10987, 10998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10959_10958_10999(string
                name)
                {
                    var return_v = SyntaxFactory.IdentifierName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 10958, 10999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                f_10959_11103_11126(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.SelectOrGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 11103, 11126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_10959_11033_11199(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeTypeInfo(position, (Microsoft.CodeAnalysis.SyntaxNode)expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 11033, 11199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_10959_11407_11447(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetTypeInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 11407, 11447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 10069, 11549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 10069, 11549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static QueryBodySyntax GetQueryBody(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10959, 11624, 12327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 11640, 12327);
                return token.Parent switch
                {
                    FromClauseSyntax fromClause when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 11720, 11755) || true) && (f_10959_11725_11746(fromClause) == token) && (DynAbs.Tracing.TraceSender.Expression_True(10959, 11720, 11755) || true)
    =>
    f_10959_11780_11797(fromClause) as QueryBodySyntax ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax?>(10959, 11780, 11867) ?? f_10959_11820_11867(((QueryExpressionSyntax)f_10959_11844_11861(fromClause)))),
                    LetClauseSyntax letClause when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 11912, 11946) || true) && (f_10959_11917_11937(letClause) == token) && (DynAbs.Tracing.TraceSender.Expression_True(10959, 11912, 11946) || true)
    =>
    f_10959_11971_11987(letClause) as QueryBodySyntax,
                    JoinClauseSyntax joinClause when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 12053, 12088) || true) && (f_10959_12058_12079(joinClause) == token) && (DynAbs.Tracing.TraceSender.Expression_True(10959, 12053, 12088) || true)
    =>
    f_10959_12113_12130(joinClause) as QueryBodySyntax,
                    QueryContinuationSyntax continuation when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 12205, 12242) || true) && (f_10959_12210_12233(continuation) == token) && (DynAbs.Tracing.TraceSender.Expression_True(10959, 12205, 12242) || true)
    =>
    f_10959_12267_12284(continuation),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 12303, 12312) && DynAbs.Tracing.TraceSender.Expression_True(10959, 12303, 12312))
    => null
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(10959, 11624, 12327);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 11624, 12327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 11624, 12327);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxToken
            f_10959_11725_11746(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
            this_param)
            {
                var return_v = this_param.Identifier;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 11725, 11746);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
            f_10959_11780_11797(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
            this_param)
            {
                var return_v = this_param.Parent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 11780, 11797);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
            f_10959_11844_11861(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
            this_param)
            {
                var return_v = this_param.Parent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 11844, 11861);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
            f_10959_11820_11867(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax?
            this_param)
            {
                var return_v = this_param.Body;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 11820, 11867);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10959_11917_11937(Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax
            this_param)
            {
                var return_v = this_param.Identifier;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 11917, 11937);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
            f_10959_11971_11987(Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax
            this_param)
            {
                var return_v = this_param.Parent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 11971, 11987);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10959_12058_12079(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
            this_param)
            {
                var return_v = this_param.Identifier;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 12058, 12079);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
            f_10959_12113_12130(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
            this_param)
            {
                var return_v = this_param.Parent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 12113, 12130);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10959_12210_12233(Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
            this_param)
            {
                var return_v = this_param.Identifier;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 12210, 12233);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
            f_10959_12267_12284(Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
            this_param)
            {
                var return_v = this_param.Body;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 12267, 12284);
                return return_v;
            }

        }

        private string RemoveAttributeSufficeIfNecessary(INamedTypeSymbol symbol, string symbolName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10959, 12340, 13197);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 12457, 13152) || true) && (f_10959_12461_12478(this) && (DynAbs.Tracing.TraceSender.Expression_True(10959, 12461, 12598) && f_10959_12499_12598(f_10959_12499_12526(format), SymbolDisplayMiscellaneousOptions.RemoveAttributeSuffix)) && (DynAbs.Tracing.TraceSender.Expression_True(10959, 12461, 12671) && f_10959_12619_12671(f_10959_12619_12647(semanticModelOpt), symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 12457, 13152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 12705, 12739);

                    string
                    nameWithoutAttributeSuffix
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 12757, 13137) || true) && (f_10959_12761_12832(symbolName, out nameWithoutAttributeSuffix))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 12757, 13137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 12874, 12939);

                        var
                        token = f_10959_12886_12938(nameWithoutAttributeSuffix)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 12961, 13118) || true) && (token.IsKind(SyntaxKind.IdentifierToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 12961, 13118);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 13055, 13095);

                            symbolName = nameWithoutAttributeSuffix;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 12961, 13118);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 12757, 13137);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 12457, 13152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 13168, 13186);

                return symbolName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10959, 12340, 13197);

                bool
                f_10959_12461_12478(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.IsMinimizing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 12461, 12478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10959_12499_12526(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 12499, 12526);
                    return return_v;
                }


                bool
                f_10959_12499_12598(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 12499, 12598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_10959_12619_12647(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 12619, 12647);
                    return return_v;
                }


                bool
                f_10959_12619_12671(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsAttributeType((Microsoft.CodeAnalysis.ITypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 12619, 12671);
                    return return_v;
                }


                bool
                f_10959_12761_12832(string
                name, out string
                result)
                {
                    var return_v = name.TryGetWithoutAttributeSuffix(out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 12761, 12832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10959_12886_12938(string
                text)
                {
                    var return_v = SyntaxFactory.ParseToken(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 12886, 12938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 12340, 13197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 12340, 13197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static T GetAncestorOrThis<T>(SyntaxNode node) where T : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10959, 13209, 13372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 13309, 13361);

                return f_10959_13316_13360<T>(f_10959_13316_13343<T>(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10959, 13209, 13372);

                System.Collections.Generic.IEnumerable<T>
                f_10959_13316_13343<T>(Microsoft.CodeAnalysis.SyntaxNode
                node) where T : SyntaxNode

                {
                    var return_v = GetAncestorsOrThis<T>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 13316, 13343);
                    return return_v;
                }


                T
                f_10959_13316_13360<T>(System.Collections.Generic.IEnumerable<T>
                source) where T : SyntaxNode

                {
                    var return_v = source.FirstOrDefault<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 13316, 13360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 13209, 13372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 13209, 13372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<T> GetAncestorsOrThis<T>(SyntaxNode node) where T : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10959, 13384, 13647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 13498, 13636);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10959, 13505, 13517) || ((node == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10959, 13537, 13580)) || DynAbs.Tracing.TraceSender.Conditional_F3(10959, 13600, 13635))) ? f_10959_13537_13580<T>() : f_10959_13600_13635<T>(f_10959_13600_13623<T>(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10959, 13384, 13647);

                System.Collections.Generic.IEnumerable<T>
                f_10959_13537_13580<T>() where T : SyntaxNode

                {
                    var return_v = SpecializedCollections.EmptyEnumerable<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 13537, 13580);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10959_13600_13623<T>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where T : SyntaxNode

                {
                    var return_v = this_param.AncestorsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 13600, 13623);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_10959_13600_13635<T>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source) where T : SyntaxNode

                {
                    var return_v = source.OfType<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 13600, 13635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 13384, 13647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 13384, 13647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IDictionary<INamespaceOrTypeSymbol, IAliasSymbol> AliasMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10959, 13750, 14063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 13786, 13810);

                    var
                    map = _lazyAliasMap
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 13828, 13915) || true) && (map != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10959, 13828, 13915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 13885, 13896);

                        return map;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10959, 13828, 13915);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 13935, 13958);

                    map = f_10959_13941_13957(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 13976, 14048);

                    return f_10959_13983_14040(ref _lazyAliasMap, map, null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>>(10959, 13983, 14047) ?? map);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10959, 13750, 14063);

                    System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>
                    f_10959_13941_13957(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                    this_param)
                    {
                        var return_v = this_param.CreateAliasMap();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 13941, 13957);
                        return return_v;
                    }


                    System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>
                    f_10959_13983_14040(ref System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>
                    location1, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>
                    value, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 13983, 14040);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 13659, 14074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 13659, 14074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private IAliasSymbol GetAliasSymbol(INamespaceOrTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10959, 14086, 14286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 14177, 14197);

                IAliasSymbol
                result
                = default(IAliasSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10959, 14211, 14275);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10959, 14218, 14258) || ((f_10959_14218_14258(f_10959_14218_14226(), symbol, out result) && DynAbs.Tracing.TraceSender.Conditional_F2(10959, 14261, 14267)) || DynAbs.Tracing.TraceSender.Conditional_F3(10959, 14270, 14274))) ? result : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10959, 14086, 14286);

                System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>
                f_10959_14218_14226()
                {
                    var return_v = AliasMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10959, 14218, 14226);
                    return return_v;
                }


                bool
                f_10959_14218_14258(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.IAliasSymbol>
                this_param, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                key, out Microsoft.CodeAnalysis.IAliasSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10959, 14218, 14258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10959, 14086, 14286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10959, 14086, 14286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
