// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class DocumentationCommentCompiler : CSharpSymbolVisitor
    {
        private class DocumentationCommentWalker : CSharpSyntaxWalker
        {
            private readonly CSharpCompilation _compilation;

            private readonly DiagnosticBag _diagnostics;

            private readonly Symbol _memberSymbol;

            private readonly TextWriter _writer;

            private readonly ArrayBuilder<CSharpSyntaxNode> _includeElementNodes;

            private HashSet<ParameterSymbol> _documentedParameters;

            private HashSet<TypeParameterSymbol> _documentedTypeParameters;

            private DocumentationCommentWalker(
                            CSharpCompilation compilation,
                            DiagnosticBag diagnostics,
                            Symbol memberSymbol,
                            TextWriter writer,
                            ArrayBuilder<CSharpSyntaxNode> includeElementNodes,
                            HashSet<ParameterSymbol> documentedParameters,
                            HashSet<TypeParameterSymbol> documentedTypeParameters)
            : base(f_10622_1999_2033_C(SyntaxWalkerDepth.StructuredTrivia))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10622, 1568, 2433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 1148, 1160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 1206, 1218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 1257, 1270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 1313, 1320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 1383, 1403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 1453, 1474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 1526, 1551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 2067, 2094);

                    _compilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 2112, 2139);

                    _diagnostics = diagnostics;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 2157, 2186);

                    _memberSymbol = memberSymbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 2204, 2221);

                    _writer = writer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 2239, 2282);

                    _includeElementNodes = includeElementNodes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 2302, 2347);

                    _documentedParameters = documentedParameters;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 2365, 2418);

                    _documentedTypeParameters = documentedTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10622, 1568, 2433);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10622, 1568, 2433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10622, 1568, 2433);
                }
            }

            public static string GetSubstitutedText(
                            CSharpCompilation compilation,
                            DiagnosticBag diagnostics,
                            Symbol symbol,
                            DocumentationCommentTriviaSyntax trivia,
                            ArrayBuilder<CSharpSyntaxNode> includeElementNodes,
                            ref HashSet<ParameterSymbol> documentedParameters,
                            ref HashSet<TypeParameterSymbol> documentedTypeParameters)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10622, 2791, 4010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 3259, 3322);

                    PooledStringBuilder
                    pooled = f_10622_3288_3321()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 3340, 3945);
                    using (StringWriter
                    writer = f_10622_3369_3431(pooled.Builder, f_10622_3402_3430())
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 3473, 3651);

                        DocumentationCommentWalker
                        walker = f_10622_3509_3650(compilation, diagnostics, symbol, writer, includeElementNodes, documentedParameters, documentedTypeParameters)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 3673, 3694);

                        f_10622_3673_3693(walker, trivia);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 3792, 3844);

                        documentedParameters = walker._documentedParameters;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 3866, 3926);

                        documentedTypeParameters = walker._documentedTypeParameters;
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10622, 3340, 3945);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 3963, 3995);

                    return f_10622_3970_3994(pooled);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10622, 2791, 4010);

                    Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    f_10622_3288_3321()
                    {
                        var return_v = PooledStringBuilder.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 3288, 3321);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_10622_3402_3430()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 3402, 3430);
                        return return_v;
                    }


                    System.IO.StringWriter
                    f_10622_3369_3431(System.Text.StringBuilder
                    sb, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = new System.IO.StringWriter(sb, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 3369, 3431);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.DocumentationCommentWalker
                    f_10622_3509_3650(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.Symbol
                    memberSymbol, System.IO.StringWriter
                    writer, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                    includeElementNodes, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    documentedParameters, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    documentedTypeParameters)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.DocumentationCommentWalker(compilation, diagnostics, memberSymbol, (System.IO.TextWriter)writer, includeElementNodes, documentedParameters, documentedTypeParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 3509, 3650);
                        return return_v;
                    }


                    int
                    f_10622_3673_3693(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.DocumentationCommentWalker
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 3673, 3693);
                        return 0;
                    }


                    string
                    f_10622_3970_3994(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToStringAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 3970, 3994);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10622, 2791, 4010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10622, 2791, 4010);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override void DefaultVisit(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10622, 4026, 7976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4109, 4143);

                    SyntaxKind
                    nodeKind = f_10622_4131_4142(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4161, 4233);

                    bool
                    diagnose = f_10622_4177_4232(f_10622_4177_4192(node))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4253, 6815) || true) && (nodeKind == SyntaxKind.XmlCrefAttribute)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 4253, 6815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4338, 4401);

                        XmlCrefAttributeSyntax
                        crefAttr = (XmlCrefAttributeSyntax)node
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4423, 4455);

                        CrefSyntax
                        cref = f_10622_4441_4454(crefAttr)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4479, 4550);

                        BinderFactory
                        factory = f_10622_4503_4549(_compilation, f_10622_4533_4548(cref))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4572, 4612);

                        Binder
                        binder = f_10622_4588_4611(factory, cref)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4718, 4778);

                        DiagnosticBag
                        crefDiagnostics = f_10622_4750_4777()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4800, 4879);

                        string
                        docCommentId = f_10622_4822_4878(cref, binder, crefDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4901, 5025) || true) && (diagnose)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 4901, 5025);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 4963, 5002);

                            f_10622_4963_5001(_diagnostics, crefDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 4901, 5025);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 5047, 5070);

                        f_10622_5047_5069(crefDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 5094, 5970) || true) && (_writer != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 5094, 5970);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 5163, 5184);

                            f_10622_5163_5183(this, f_10622_5169_5182(crefAttr));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 5210, 5243);

                            f_10622_5210_5242(this, f_10622_5221_5241(crefAttr));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 5415, 5489);

                            crefAttr.StartQuoteToken.WriteTo(_writer, leading: true, trailing: false);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 5675, 5703);

                            f_10622_5675_5702(
                                                    // We're not going to visit the cref because we want to bind it
                                                    // and write a doc comment ID in its place.
                                                    _writer, docCommentId);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 5875, 5947);

                            crefAttr.EndQuoteToken.WriteTo(_writer, leading: false, trailing: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 5094, 5970);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 6082, 6089);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 4253, 6815);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 4253, 6815);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 6131, 6815) || true) && (diagnose && (DynAbs.Tracing.TraceSender.Expression_True(10622, 6135, 6186) && nodeKind == SyntaxKind.XmlNameAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 6131, 6815);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 6228, 6291);

                            XmlNameAttributeSyntax
                            nameAttr = (XmlNameAttributeSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 6315, 6390);

                            BinderFactory
                            factory = f_10622_6339_6389(_compilation, f_10622_6369_6388(nameAttr))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 6412, 6487);

                            Binder
                            binder = f_10622_6428_6486(factory, nameAttr, f_10622_6456_6485(f_10622_6456_6475(nameAttr)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 6587, 6701);

                            f_10622_6587_6700(nameAttr, binder, _memberSymbol, ref _documentedParameters, ref _documentedTypeParameters, _diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 6131, 6815);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 4253, 6815);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 7062, 7917) || true) && (_includeElementNodes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 7062, 7917);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 7136, 7168);

                        XmlNameSyntax
                        nameSyntax = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 7190, 7549) || true) && (nodeKind == SyntaxKind.XmlEmptyElement)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 7190, 7549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 7282, 7330);

                            nameSyntax = f_10622_7295_7329(((XmlEmptyElementSyntax)node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 7190, 7549);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 7190, 7549);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 7380, 7549) || true) && (nodeKind == SyntaxKind.XmlElementStartTag)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 7380, 7549);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 7475, 7526);

                                nameSyntax = f_10622_7488_7525(((XmlElementStartTagSyntax)node));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 7380, 7549);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 7190, 7549);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 7573, 7898) || true) && (nameSyntax != null && (DynAbs.Tracing.TraceSender.Expression_True(10622, 7577, 7624) && f_10622_7599_7616(nameSyntax) == null) && (DynAbs.Tracing.TraceSender.Expression_True(10622, 7577, 7776) && f_10622_7653_7776(nameSyntax.LocalName.ValueText, DocumentationCommentXmlNames.IncludeElementName)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 7573, 7898);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 7826, 7875);

                            f_10622_7826_7874(_includeElementNodes, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 7573, 7898);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 7062, 7917);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 7937, 7961);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DefaultVisit(node), 10622, 7937, 7960);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10622, 4026, 7976);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10622_4131_4142(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = node.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 4131, 4142);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10622_4177_4192(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 4177, 4192);
                        return return_v;
                    }


                    bool
                    f_10622_4177_4232(Microsoft.CodeAnalysis.SyntaxTree
                    tree)
                    {
                        var return_v = tree.ReportDocumentationCommentDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 4177, 4232);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                    f_10622_4441_4454(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                    this_param)
                    {
                        var return_v = this_param.Cref;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 4441, 4454);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10622_4533_4548(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 4533, 4548);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory
                    f_10622_4503_4549(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SyntaxTree
                    syntaxTree)
                    {
                        var return_v = this_param.GetBinderFactory(syntaxTree);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 4503, 4549);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10622_4588_4611(Microsoft.CodeAnalysis.CSharp.BinderFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                    node)
                    {
                        var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 4588, 4611);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10622_4750_4777()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 4750, 4777);
                        return return_v;
                    }


                    string
                    f_10622_4822_4878(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                    crefSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = GetDocumentationCommentId(crefSyntax, binder, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 4822, 4878);
                        return return_v;
                    }


                    int
                    f_10622_4963_5001(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        this_param.AddRange(bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 4963, 5001);
                        return 0;
                    }


                    int
                    f_10622_5047_5069(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 5047, 5069);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                    f_10622_5169_5182(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 5169, 5182);
                        return return_v;
                    }


                    int
                    f_10622_5163_5183(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.DocumentationCommentWalker
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                    node)
                    {
                        this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 5163, 5183);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10622_5221_5241(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                    this_param)
                    {
                        var return_v = this_param.EqualsToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 5221, 5241);
                        return return_v;
                    }


                    int
                    f_10622_5210_5242(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.DocumentationCommentWalker
                    this_param, Microsoft.CodeAnalysis.SyntaxToken
                    token)
                    {
                        this_param.VisitToken(token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 5210, 5242);
                        return 0;
                    }


                    int
                    f_10622_5675_5702(System.IO.TextWriter
                    this_param, string
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 5675, 5702);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10622_6369_6388(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 6369, 6388);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory
                    f_10622_6339_6389(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SyntaxTree
                    syntaxTree)
                    {
                        var return_v = this_param.GetBinderFactory(syntaxTree);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 6339, 6389);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                    f_10622_6456_6475(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    this_param)
                    {
                        var return_v = this_param.Identifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 6456, 6475);
                        return return_v;
                    }


                    int
                    f_10622_6456_6485(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                    this_param)
                    {
                        var return_v = this_param.SpanStart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 6456, 6485);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10622_6428_6486(Microsoft.CodeAnalysis.CSharp.BinderFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    node, int
                    position)
                    {
                        var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 6428, 6486);
                        return return_v;
                    }


                    int
                    f_10622_6587_6700(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    syntax, Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.Symbol
                    memberSymbol, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    documentedParameters, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    documentedTypeParameters, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        BindName(syntax, binder, memberSymbol, ref documentedParameters, ref documentedTypeParameters, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 6587, 6700);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                    f_10622_7295_7329(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 7295, 7329);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                    f_10622_7488_7525(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 7488, 7525);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax?
                    f_10622_7599_7616(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                    this_param)
                    {
                        var return_v = this_param.Prefix;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10622, 7599, 7616);
                        return return_v;
                    }


                    bool
                    f_10622_7653_7776(string
                    name1, string
                    name2)
                    {
                        var return_v = DocumentationCommentXmlNames.ElementEquals(name1, name2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 7653, 7776);
                        return return_v;
                    }


                    int
                    f_10622_7826_7874(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10622, 7826, 7874);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10622, 4026, 7976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10622, 4026, 7976);
                }
            }

            public override void VisitToken(SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10622, 7992, 8236);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 8075, 8178) || true) && (_writer != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10622, 8075, 8178);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 8136, 8159);

                        token.WriteTo(_writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10622, 8075, 8178);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10622, 8198, 8221);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitToken(token), 10622, 8198, 8220);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10622, 7992, 8236);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10622, 7992, 8236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10622, 7992, 8236);
                }
            }

            static DocumentationCommentWalker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10622, 1027, 8247);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10622, 1027, 8247);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10622, 1027, 8247);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10622, 1027, 8247);

            static Microsoft.CodeAnalysis.SyntaxWalkerDepth
            f_10622_1999_2033_C(Microsoft.CodeAnalysis.SyntaxWalkerDepth
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10622, 1568, 2433);
                return return_v;
            }

        }
    }
}
