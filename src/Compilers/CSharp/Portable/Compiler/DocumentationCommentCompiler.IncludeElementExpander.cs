// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class DocumentationCommentCompiler : CSharpSymbolVisitor
    {
        private class IncludeElementExpander
        {
            private readonly Symbol _memberSymbol;

            private readonly ImmutableArray<CSharpSyntaxNode> _sourceIncludeElementNodes;

            private readonly CSharpCompilation _compilation;

            private readonly DiagnosticBag _diagnostics;

            private readonly CancellationToken _cancellationToken;

            private int _nextSourceIncludeElementIndex;

            private HashSet<Location> _inProgressIncludeElementNodes;

            private HashSet<ParameterSymbol> _documentedParameters;

            private HashSet<TypeParameterSymbol> _documentedTypeParameters;

            private DocumentationCommentIncludeCache _includedFileCache;

            private IncludeElementExpander(
                            Symbol memberSymbol,
                            ImmutableArray<CSharpSyntaxNode> sourceIncludeElementNodes,
                            CSharpCompilation compilation,
                            HashSet<ParameterSymbol> documentedParameters,
                            HashSet<TypeParameterSymbol> documentedTypeParameters,
                            DocumentationCommentIncludeCache includedFileCache,
                            DiagnosticBag diagnostics,
                            CancellationToken cancellationToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10623, 1654, 2696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 995, 1008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 1149, 1161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 1207, 1219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 1316, 1346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 1387, 1417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 1465, 1486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 1538, 1563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 1619, 1637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 2184, 2213);

                    _memberSymbol = memberSymbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 2231, 2286);

                    _sourceIncludeElementNodes = sourceIncludeElementNodes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 2304, 2331);

                    _compilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 2349, 2376);

                    _diagnostics = diagnostics;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 2394, 2433);

                    _cancellationToken = cancellationToken;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 2453, 2498);

                    _documentedParameters = documentedParameters;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 2516, 2569);

                    _documentedTypeParameters = documentedTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 2587, 2626);

                    _includedFileCache = includedFileCache;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 2646, 2681);

                    _nextSourceIncludeElementIndex = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10623, 1654, 2696);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 1654, 2696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 1654, 2696);
                }
            }

            public static void ProcessIncludes(
                            string unprocessed,
                            Symbol memberSymbol,
                            ImmutableArray<CSharpSyntaxNode> sourceIncludeElementNodes,
                            CSharpCompilation compilation,
                            ref HashSet<ParameterSymbol> documentedParameters,
                            ref HashSet<TypeParameterSymbol> documentedTypeParameters,
                            ref DocumentationCommentIncludeCache includedFileCache,
                            TextWriter writer,
                            DiagnosticBag diagnostics,
                            CancellationToken cancellationToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10623, 2712, 6202);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 3771, 4015) || true) && (sourceIncludeElementNodes.IsEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 3771, 4015);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 3850, 3967) || true) && (writer != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 3850, 3967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 3918, 3944);

                            f_10623_3918_3943(writer, unprocessed);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 3850, 3967);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 3989, 3996);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 3771, 4015);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 4035, 4049);

                    XDocument
                    doc
                    = default(XDocument);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 4254, 4321);

                        doc = f_10623_4260_4320(unprocessed, LoadOptions.PreserveWhitespace);
                    }
                    catch (XmlException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10623, 4358, 5016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 4624, 4829);

                        f_10623_4624_4828(sourceIncludeElementNodes.All(syntax => syntax.SyntaxTree.Options.DocumentationMode < DocumentationMode.Diagnose), "Why didn't our parser catch this exception? " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (e).ToString(), 10623, 4826, 4827));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 4851, 4968) || true) && (writer != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 4851, 4968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 4919, 4945);

                            f_10623_4919_4944(writer, unprocessed);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 4851, 4968);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 4990, 4997);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10623, 4358, 5016);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 5036, 5085);

                    cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 5105, 5488);

                    IncludeElementExpander
                    expander = f_10623_5139_5487(memberSymbol, sourceIncludeElementNodes, compilation, documentedParameters, documentedTypeParameters, includedFileCache, diagnostics, cancellationToken)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 5508, 5847);
                        foreach (XNode node in f_10623_5531_5603_I(f_10623_5531_5603(expander, doc, currentXmlFilePath: null, originatingSyntax: null)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 5508, 5847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 5645, 5694);

                            cancellationToken.ThrowIfCancellationRequested();

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 5718, 5828) || true) && (writer != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 5718, 5828);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 5786, 5805);

                                f_10623_5786_5804(writer, node);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 5718, 5828);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 5508, 5847);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10623, 1, 340);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10623, 1, 340);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 5867, 5967);

                    f_10623_5867_5966(expander._nextSourceIncludeElementIndex == expander._sourceIncludeElementNodes.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 5987, 6041);

                    documentedParameters = expander._documentedParameters;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 6059, 6121);

                    documentedTypeParameters = expander._documentedTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 6139, 6187);

                    includedFileCache = expander._includedFileCache;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10623, 2712, 6202);

                    int
                    f_10623_3918_3943(System.IO.TextWriter
                    this_param, string
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 3918, 3943);
                        return 0;
                    }


                    System.Xml.Linq.XDocument
                    f_10623_4260_4320(string
                    text, System.Xml.Linq.LoadOptions
                    options)
                    {
                        var return_v = XDocument.Parse(text, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 4260, 4320);
                        return return_v;
                    }


                    int
                    f_10623_4624_4828(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 4624, 4828);
                        return 0;
                    }


                    int
                    f_10623_4919_4944(System.IO.TextWriter
                    this_param, string
                    value)
                    {
                        this_param.Write(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 4919, 4944);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    f_10623_5139_5487(Microsoft.CodeAnalysis.CSharp.Symbol
                    memberSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                    sourceIncludeElementNodes, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    documentedParameters, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    documentedTypeParameters, Microsoft.CodeAnalysis.DocumentationCommentIncludeCache
                    includedFileCache, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, System.Threading.CancellationToken
                    cancellationToken)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander(memberSymbol, sourceIncludeElementNodes, compilation, documentedParameters, documentedTypeParameters, includedFileCache, diagnostics, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 5139, 5487);
                        return return_v;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_5531_5603(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, System.Xml.Linq.XDocument
                    node, string
                    currentXmlFilePath, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    originatingSyntax)
                    {
                        var return_v = this_param.Rewrite((System.Xml.Linq.XNode)node, currentXmlFilePath: currentXmlFilePath, originatingSyntax: originatingSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 5531, 5603);
                        return return_v;
                    }


                    int
                    f_10623_5786_5804(System.IO.TextWriter
                    this_param, System.Xml.Linq.XNode
                    value)
                    {
                        this_param.Write((object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 5786, 5804);
                        return 0;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_5531_5603_I(System.Xml.Linq.XNode[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 5531, 5603);
                        return return_v;
                    }


                    int
                    f_10623_5867_5966(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 5867, 5966);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 2712, 6202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 2712, 6202);
                }
            }

            private XNode[] RewriteMany(XNode[] nodes, string currentXmlFilePath, CSharpSyntaxNode originatingSyntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10623, 6569, 7620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 6707, 6735);

                    f_10623_6707_6734(nodes != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 6755, 6790);

                    ArrayBuilder<XNode>
                    builder = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 6808, 7130);
                        foreach (XNode child in f_10623_6832_6837_I(nodes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 6808, 7130);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 6879, 7015) || true) && (builder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 6879, 7015);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 6948, 6992);

                                builder = f_10623_6958_6991();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 6879, 7015);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 7039, 7111);

                            f_10623_7039_7110(
                                                builder, f_10623_7056_7109(this, child, currentXmlFilePath, originatingSyntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 6808, 7130);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10623, 1, 323);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10623, 1, 323);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 7438, 7512);

                    f_10623_7438_7511(builder == null || (DynAbs.Tracing.TraceSender.Expression_False(10623, 7451, 7510) || f_10623_7470_7510(builder, node => node.Parent == null)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 7532, 7605);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10623, 7539, 7554) || ((builder == null && DynAbs.Tracing.TraceSender.Conditional_F2(10623, 7557, 7577)) || DynAbs.Tracing.TraceSender.Conditional_F3(10623, 7580, 7604))) ? f_10623_7557_7577() : f_10623_7580_7604(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10623, 6569, 7620);

                    int
                    f_10623_6707_6734(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 6707, 6734);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Xml.Linq.XNode>
                    f_10623_6958_6991()
                    {
                        var return_v = ArrayBuilder<XNode>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 6958, 6991);
                        return return_v;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_7056_7109(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, System.Xml.Linq.XNode
                    node, string
                    currentXmlFilePath, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    originatingSyntax)
                    {
                        var return_v = this_param.Rewrite(node, currentXmlFilePath, originatingSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 7056, 7109);
                        return return_v;
                    }


                    int
                    f_10623_7039_7110(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Xml.Linq.XNode>
                    this_param, params System.Xml.Linq.XNode[]
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 7039, 7110);
                        return 0;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_6832_6837_I(System.Xml.Linq.XNode[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 6832, 6837);
                        return return_v;
                    }


                    bool
                    f_10623_7470_7510(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Xml.Linq.XNode>
                    builder, System.Func<System.Xml.Linq.XNode, bool>
                    predicate)
                    {
                        var return_v = builder.All<System.Xml.Linq.XNode>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 7470, 7510);
                        return return_v;
                    }


                    int
                    f_10623_7438_7511(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 7438, 7511);
                        return 0;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_7557_7577()
                    {
                        var return_v = Array.Empty<XNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 7557, 7577);
                        return return_v;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_7580_7604(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Xml.Linq.XNode>
                    this_param)
                    {
                        var return_v = this_param.ToArrayAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 7580, 7604);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 6569, 7620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 6569, 7620);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private XNode[] Rewrite(XNode node, string currentXmlFilePath, CSharpSyntaxNode originatingSyntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10623, 7725, 11854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 7856, 7906);

                    _cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 7926, 7955);

                    string
                    commentMessage = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 7975, 8539) || true) && (f_10623_7979_7992(node) == XmlNodeType.Element)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 7975, 8539);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 8057, 8091);

                        XElement
                        element = (XElement)node
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 8113, 8520) || true) && (f_10623_8117_8188(element, DocumentationCommentXmlNames.IncludeElementName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 8113, 8520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 8238, 8348);

                            XNode[]
                            rewritten = f_10623_8258_8347(this, element, currentXmlFilePath, originatingSyntax, out commentMessage)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 8374, 8497) || true) && (rewritten != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 8374, 8497);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 8453, 8470);

                                return rewritten;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 8374, 8497);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 8113, 8520);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 7975, 8539);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 8559, 8601);

                    XContainer
                    container = node as XContainer
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 8619, 8882) || true) && (container == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 8619, 8882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 8682, 8775);

                        f_10623_8682_8774(commentMessage == null, "How did we get an error comment for a non-container?");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 8797, 8863);

                        return new XNode[] { f_10623_8818_8860(node, copyAttributeAnnotations: false) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 8619, 8882);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 8902, 8950);

                    IEnumerable<XNode>
                    oldNodes = f_10623_8932_8949(container)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 9056, 9116);

                    container = f_10623_9068_9115(container, copyAttributeAnnotations: false);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 9244, 9472) || true) && (oldNodes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 9244, 9472);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 9306, 9397);

                        XNode[]
                        rewritten = f_10623_9326_9396(this, f_10623_9338_9356(oldNodes), currentXmlFilePath, originatingSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 9419, 9453);

                        f_10623_9419_9452(container, rewritten);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 9244, 9472);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 9741, 11453) || true) && (f_10623_9745_9763(container) == XmlNodeType.Element && (DynAbs.Tracing.TraceSender.Expression_True(10623, 9745, 9815) && originatingSyntax != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 9741, 11453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 9857, 9896);

                        XElement
                        element = (XElement)container
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 9918, 11434);
                            foreach (XAttribute attribute in f_10623_9951_9971_I(f_10623_9951_9971(element)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 9918, 11434);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 10021, 11411) || true) && (f_10623_10025_10099(attribute, DocumentationCommentXmlNames.CrefAttributeName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 10021, 11411);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 10157, 10206);

                                    f_10623_10157_10205(this, attribute, originatingSyntax);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 10021, 11411);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 10021, 11411);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 10264, 11411) || true) && (f_10623_10268_10342(attribute, DocumentationCommentXmlNames.NameAttributeName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 10264, 11411);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 10400, 11384) || true) && (f_10623_10404_10477(element, DocumentationCommentXmlNames.ParameterElementName) || (DynAbs.Tracing.TraceSender.Expression_False(10623, 10404, 10596) || f_10623_10514_10596(element, DocumentationCommentXmlNames.ParameterReferenceElementName)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 10400, 11384);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 10662, 10747);

                                            f_10623_10662_10746(this, attribute, originatingSyntax, isParameter: true, isTypeParameterRef: false);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 10400, 11384);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 10400, 11384);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 10813, 11384) || true) && (f_10623_10817_10894(element, DocumentationCommentXmlNames.TypeParameterElementName))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 10813, 11384);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 10960, 11046);

                                                f_10623_10960_11045(this, attribute, originatingSyntax, isParameter: false, isTypeParameterRef: false);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 10813, 11384);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 10813, 11384);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 11112, 11384) || true) && (f_10623_11116_11202(element, DocumentationCommentXmlNames.TypeParameterReferenceElementName))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 11112, 11384);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 11268, 11353);

                                                    f_10623_11268_11352(this, attribute, originatingSyntax, isParameter: false, isTypeParameterRef: true);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 11112, 11384);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 10813, 11384);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 10400, 11384);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 10264, 11411);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 10021, 11411);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 9918, 11434);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10623, 1, 1517);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10623, 1, 1517);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 9741, 11453);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 11473, 11839) || true) && (commentMessage == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 11473, 11839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 11541, 11574);

                        return new XNode[] { container };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 11473, 11839);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 11473, 11839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 11675, 11730);

                        XComment
                        failureComment = f_10623_11701_11729(commentMessage)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 11752, 11801);

                        return new XNode[] { failureComment, container };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 11473, 11839);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10623, 7725, 11854);

                    System.Xml.XmlNodeType
                    f_10623_7979_7992(System.Xml.Linq.XNode
                    this_param)
                    {
                        var return_v = this_param.NodeType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 7979, 7992);
                        return return_v;
                    }


                    bool
                    f_10623_8117_8188(System.Xml.Linq.XElement
                    element, string
                    name)
                    {
                        var return_v = ElementNameIs(element, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 8117, 8188);
                        return return_v;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_8258_8347(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, System.Xml.Linq.XElement
                    includeElement, string
                    currentXmlFilePath, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    originatingSyntax, out string
                    commentMessage)
                    {
                        var return_v = this_param.RewriteIncludeElement(includeElement, currentXmlFilePath, originatingSyntax, out commentMessage);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 8258, 8347);
                        return return_v;
                    }


                    int
                    f_10623_8682_8774(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 8682, 8774);
                        return 0;
                    }


                    System.Xml.Linq.XNode
                    f_10623_8818_8860(System.Xml.Linq.XNode
                    node, bool
                    copyAttributeAnnotations)
                    {
                        var return_v = node.Copy<System.Xml.Linq.XNode>(copyAttributeAnnotations: copyAttributeAnnotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 8818, 8860);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>
                    f_10623_8932_8949(System.Xml.Linq.XContainer
                    this_param)
                    {
                        var return_v = this_param.Nodes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 8932, 8949);
                        return return_v;
                    }


                    System.Xml.Linq.XContainer
                    f_10623_9068_9115(System.Xml.Linq.XContainer
                    node, bool
                    copyAttributeAnnotations)
                    {
                        var return_v = node.Copy<System.Xml.Linq.XContainer>(copyAttributeAnnotations: copyAttributeAnnotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 9068, 9115);
                        return return_v;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_9338_9356(System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>
                    source)
                    {
                        var return_v = source.ToArray<System.Xml.Linq.XNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 9338, 9356);
                        return return_v;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_9326_9396(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, System.Xml.Linq.XNode[]
                    nodes, string
                    currentXmlFilePath, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    originatingSyntax)
                    {
                        var return_v = this_param.RewriteMany(nodes, currentXmlFilePath, originatingSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 9326, 9396);
                        return return_v;
                    }


                    int
                    f_10623_9419_9452(System.Xml.Linq.XContainer
                    this_param, params System.Xml.Linq.XNode[]
                    content)
                    {
                        this_param.ReplaceNodes((object[])content);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 9419, 9452);
                        return 0;
                    }


                    System.Xml.XmlNodeType
                    f_10623_9745_9763(System.Xml.Linq.XContainer
                    this_param)
                    {
                        var return_v = this_param.NodeType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 9745, 9763);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                    f_10623_9951_9971(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Attributes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 9951, 9971);
                        return return_v;
                    }


                    bool
                    f_10623_10025_10099(System.Xml.Linq.XAttribute
                    attribute, string
                    name)
                    {
                        var return_v = AttributeNameIs(attribute, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 10025, 10099);
                        return return_v;
                    }


                    int
                    f_10623_10157_10205(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, System.Xml.Linq.XAttribute
                    attribute, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    originatingSyntax)
                    {
                        this_param.BindAndReplaceCref(attribute, originatingSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 10157, 10205);
                        return 0;
                    }


                    bool
                    f_10623_10268_10342(System.Xml.Linq.XAttribute
                    attribute, string
                    name)
                    {
                        var return_v = AttributeNameIs(attribute, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 10268, 10342);
                        return return_v;
                    }


                    bool
                    f_10623_10404_10477(System.Xml.Linq.XElement
                    element, string
                    name)
                    {
                        var return_v = ElementNameIs(element, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 10404, 10477);
                        return return_v;
                    }


                    bool
                    f_10623_10514_10596(System.Xml.Linq.XElement
                    element, string
                    name)
                    {
                        var return_v = ElementNameIs(element, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 10514, 10596);
                        return return_v;
                    }


                    int
                    f_10623_10662_10746(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, System.Xml.Linq.XAttribute
                    attribute, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    originatingSyntax, bool
                    isParameter, bool
                    isTypeParameterRef)
                    {
                        this_param.BindName(attribute, originatingSyntax, isParameter: isParameter, isTypeParameterRef: isTypeParameterRef);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 10662, 10746);
                        return 0;
                    }


                    bool
                    f_10623_10817_10894(System.Xml.Linq.XElement
                    element, string
                    name)
                    {
                        var return_v = ElementNameIs(element, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 10817, 10894);
                        return return_v;
                    }


                    int
                    f_10623_10960_11045(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, System.Xml.Linq.XAttribute
                    attribute, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    originatingSyntax, bool
                    isParameter, bool
                    isTypeParameterRef)
                    {
                        this_param.BindName(attribute, originatingSyntax, isParameter: isParameter, isTypeParameterRef: isTypeParameterRef);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 10960, 11045);
                        return 0;
                    }


                    bool
                    f_10623_11116_11202(System.Xml.Linq.XElement
                    element, string
                    name)
                    {
                        var return_v = ElementNameIs(element, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 11116, 11202);
                        return return_v;
                    }


                    int
                    f_10623_11268_11352(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, System.Xml.Linq.XAttribute
                    attribute, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    originatingSyntax, bool
                    isParameter, bool
                    isTypeParameterRef)
                    {
                        this_param.BindName(attribute, originatingSyntax, isParameter: isParameter, isTypeParameterRef: isTypeParameterRef);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 11268, 11352);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                    f_10623_9951_9971_I(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 9951, 9971);
                        return return_v;
                    }


                    System.Xml.Linq.XComment
                    f_10623_11701_11729(string
                    value)
                    {
                        var return_v = new System.Xml.Linq.XComment(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 11701, 11729);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 7725, 11854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 7725, 11854);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool ElementNameIs(XElement element, string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10623, 11870, 12114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 11967, 12099);

                    return f_10623_11974_12022(f_10623_11995_12021(f_10623_11995_12007(element))) && (DynAbs.Tracing.TraceSender.Expression_True(10623, 11974, 12098) && f_10623_12026_12098(f_10623_12069_12091(f_10623_12069_12081(element)), name));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10623, 11870, 12114);

                    System.Xml.Linq.XName
                    f_10623_11995_12007(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 11995, 12007);
                        return return_v;
                    }


                    string
                    f_10623_11995_12021(System.Xml.Linq.XName
                    this_param)
                    {
                        var return_v = this_param.NamespaceName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 11995, 12021);
                        return return_v;
                    }


                    bool
                    f_10623_11974_12022(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 11974, 12022);
                        return return_v;
                    }


                    System.Xml.Linq.XName
                    f_10623_12069_12081(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 12069, 12081);
                        return return_v;
                    }


                    string
                    f_10623_12069_12091(System.Xml.Linq.XName
                    this_param)
                    {
                        var return_v = this_param.LocalName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 12069, 12091);
                        return return_v;
                    }


                    bool
                    f_10623_12026_12098(string
                    name1, string
                    name2)
                    {
                        var return_v = DocumentationCommentXmlNames.ElementEquals(name1, name2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 12026, 12098);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 11870, 12114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 11870, 12114);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool AttributeNameIs(XAttribute attribute, string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10623, 12130, 12386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 12233, 12371);

                    return f_10623_12240_12290(f_10623_12261_12289(f_10623_12261_12275(attribute))) && (DynAbs.Tracing.TraceSender.Expression_True(10623, 12240, 12370) && f_10623_12294_12370(f_10623_12339_12363(f_10623_12339_12353(attribute)), name));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10623, 12130, 12386);

                    System.Xml.Linq.XName
                    f_10623_12261_12275(System.Xml.Linq.XAttribute
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 12261, 12275);
                        return return_v;
                    }


                    string
                    f_10623_12261_12289(System.Xml.Linq.XName
                    this_param)
                    {
                        var return_v = this_param.NamespaceName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 12261, 12289);
                        return return_v;
                    }


                    bool
                    f_10623_12240_12290(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 12240, 12290);
                        return return_v;
                    }


                    System.Xml.Linq.XName
                    f_10623_12339_12353(System.Xml.Linq.XAttribute
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 12339, 12353);
                        return return_v;
                    }


                    string
                    f_10623_12339_12363(System.Xml.Linq.XName
                    this_param)
                    {
                        var return_v = this_param.LocalName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 12339, 12363);
                        return return_v;
                    }


                    bool
                    f_10623_12294_12370(string
                    name1, string
                    name2)
                    {
                        var return_v = DocumentationCommentXmlNames.AttributeEquals(name1, name2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 12294, 12370);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 12130, 12386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 12130, 12386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private XNode[] RewriteIncludeElement(XElement includeElement, string currentXmlFilePath, CSharpSyntaxNode originatingSyntax, out string commentMessage)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10623, 12629, 21615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 12814, 12923);

                    Location
                    location = f_10623_12834_12922(this, includeElement, ref currentXmlFilePath, ref originatingSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 12941, 12981);

                    f_10623_12941_12980(originatingSyntax != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 13001, 13086);

                    bool
                    diagnose = f_10623_13017_13085(f_10623_13017_13045(originatingSyntax))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 13106, 14264) || true) && (!f_10623_13111_13140(this, location))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 13106, 14264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 13298, 13404);

                        XAttribute
                        fileAttr = f_10623_13320_13403(includeElement, f_10623_13345_13402(DocumentationCommentXmlNames.FileAttributeName))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 13426, 13532);

                        XAttribute
                        pathAttr = f_10623_13448_13531(includeElement, f_10623_13473_13530(DocumentationCommentXmlNames.PathAttributeName))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 13554, 13592);

                        string
                        filePathValue = f_10623_13577_13591(fileAttr)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 13614, 13649);

                        string
                        xpathValue = f_10623_13634_13648(pathAttr)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 13673, 13915) || true) && (diagnose)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 13673, 13915);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 13735, 13892);

                            f_10623_13735_13891(_diagnostics, ErrorCode.WRN_FailedInclude, location, filePathValue, xpathValue, f_10623_13818_13890(MessageID.IDS_OperationCausedStackOverflow));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 13673, 13915);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 13939, 14036);

                        commentMessage = f_10623_13956_14035(MessageID.IDS_XMLNOINCLUDE, f_10623_14006_14034());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 14139, 14245);

                        return new XNode[] { f_10623_14160_14188(commentMessage), f_10623_14190_14242(includeElement, copyAttributeAnnotations: false) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 13106, 14264);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 14284, 14347);

                    DiagnosticBag
                    includeDiagnostics = f_10623_14319_14346()
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 14411, 14517);

                        XAttribute
                        fileAttr = f_10623_14433_14516(includeElement, f_10623_14458_14515(DocumentationCommentXmlNames.FileAttributeName))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 14539, 14645);

                        XAttribute
                        pathAttr = f_10623_14561_14644(includeElement, f_10623_14586_14643(DocumentationCommentXmlNames.PathAttributeName))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 14669, 14710);

                        bool
                        hasFileAttribute = fileAttr != null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 14732, 14773);

                        bool
                        hasPathAttribute = pathAttr != null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 14795, 15282) || true) && (!hasFileAttribute || (DynAbs.Tracing.TraceSender.Expression_False(10623, 14799, 14837) || !hasPathAttribute))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 14795, 15282);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 14887, 15019);

                            var
                            subMessage = (DynAbs.Tracing.TraceSender.Conditional_F1(10623, 14904, 14920) || ((hasFileAttribute && DynAbs.Tracing.TraceSender.Conditional_F2(10623, 14923, 14969)) || DynAbs.Tracing.TraceSender.Conditional_F3(10623, 14972, 15018))) ? f_10623_14923_14969(MessageID.IDS_XMLMISSINGINCLUDEPATH) : f_10623_14972_15018(MessageID.IDS_XMLMISSINGINCLUDEFILE)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15045, 15120);

                            f_10623_15045_15119(includeDiagnostics, ErrorCode.WRN_InvalidInclude, location, subMessage);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15146, 15221);

                            commentMessage = f_10623_15163_15220(location, MessageID.IDS_XMLBADINCLUDE);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15247, 15259);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 14795, 15282);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15306, 15341);

                        string
                        xpathValue = f_10623_15326_15340(pathAttr)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15363, 15401);

                        string
                        filePathValue = f_10623_15386_15400(fileAttr)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15425, 15482);

                        var
                        resolver = f_10623_15440_15481(f_10623_15440_15460(_compilation))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15504, 15936) || true) && (resolver == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 15504, 15936);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15574, 15771);

                            f_10623_15574_15770(includeDiagnostics, ErrorCode.WRN_FailedInclude, location, filePathValue, xpathValue, f_10623_15663_15769(nameof(CodeAnalysisResources.XmlReferencesNotSupported)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15797, 15875);

                            commentMessage = f_10623_15814_15874(location, MessageID.IDS_XMLFAILEDINCLUDE);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15901, 15913);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 15504, 15936);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 15960, 16047);

                        string
                        resolvedFilePath = f_10623_15986_16046(resolver, filePathValue, currentXmlFilePath)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 16071, 16562) || true) && (resolvedFilePath == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 16071, 16562);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 16213, 16397);

                            f_10623_16213_16396(                        // NOTE: same behavior as IOException.
                                                    includeDiagnostics, ErrorCode.WRN_FailedInclude, location, filePathValue, xpathValue, f_10623_16302_16395(nameof(CodeAnalysisResources.FileNotFound)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 16423, 16501);

                            commentMessage = f_10623_16440_16500(location, MessageID.IDS_XMLFAILEDINCLUDE);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 16527, 16539);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 16071, 16562);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 16586, 16757) || true) && (_includedFileCache == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 16586, 16757);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 16666, 16734);

                            _includedFileCache = f_10623_16687_16733(resolver);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 16586, 16757);
                        }

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 16833, 16847);

                            XDocument
                            doc
                            = default(XDocument);

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 16935, 16996);

                                doc = f_10623_16941_16995(_includedFileCache, resolvedFilePath);
                            }
                            catch (IOException e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(10623, 17049, 17485);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 17208, 17308);

                                f_10623_17208_17307(                            // NOTE: same behavior as resolvedFilePath == null.
                                                            includeDiagnostics, ErrorCode.WRN_FailedInclude, location, filePathValue, xpathValue, f_10623_17297_17306(e));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 17338, 17416);

                                commentMessage = f_10623_17355_17415(location, MessageID.IDS_XMLFAILEDINCLUDE);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 17446, 17458);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(10623, 17049, 17485);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 17513, 17539);

                            f_10623_17513_17538(doc != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 17567, 17587);

                            string
                            errorMessage
                            = default(string);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 17613, 17631);

                            bool
                            invalidXPath
                            = default(bool);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 17657, 17769);

                            XElement[]
                            loadedElements = f_10623_17685_17768(doc, xpathValue, out errorMessage, out invalidXPath)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 17795, 18858) || true) && (loadedElements == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 17795, 18858);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 17879, 17982);

                                f_10623_17879_17981(includeDiagnostics, ErrorCode.WRN_FailedInclude, location, filePathValue, xpathValue, errorMessage);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 18014, 18092);

                                commentMessage = f_10623_18031_18091(location, MessageID.IDS_XMLFAILEDINCLUDE);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 18122, 18312) || true) && (invalidXPath)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 18122, 18312);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 18269, 18281);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 18122, 18312);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 18344, 18831) || true) && (f_10623_18348_18367(location))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 18344, 18831);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 18534, 18586);

                                    return new XNode[] { f_10623_18555_18583(commentMessage) };
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 18344, 18831);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 18344, 18831);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 18716, 18738);

                                    commentMessage = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 18772, 18800);

                                    return f_10623_18779_18799();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 18344, 18831);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 17795, 18858);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 18886, 19896) || true) && (loadedElements != null && (DynAbs.Tracing.TraceSender.Expression_True(10623, 18890, 18941) && f_10623_18916_18937(loadedElements) > 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 18886, 19896);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 19101, 19183);

                                XNode[]
                                result = f_10623_19118_19182(this, loadedElements, resolvedFilePath, originatingSyntax)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 19517, 19869) || true) && (f_10623_19521_19534(result) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 19517, 19869);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 19768, 19790);

                                    commentMessage = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 19824, 19838);

                                    return result;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 19517, 19869);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 18886, 19896);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 19924, 19998);

                            commentMessage = f_10623_19941_19997(location, MessageID.IDS_XMLNOINCLUDE);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 20024, 20036);

                            return null;
                        }
                        catch (XmlException e)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(10623, 20081, 21265);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 20380, 20445);

                            Location
                            errorLocation = f_10623_20405_20444(e, resolvedFilePath)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 20471, 20564);

                            f_10623_20471_20563(includeDiagnostics, ErrorCode.WRN_XMLParseIncludeError, errorLocation, f_10623_20545_20562(e));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 20630, 21242) || true) && (f_10623_20634_20653(location))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 20630, 21242);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 20711, 20840);

                                commentMessage = f_10623_20728_20839(f_10623_20742_20820(MessageID.IDS_XMLIGNORED2, f_10623_20791_20819()), resolvedFilePath);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 20969, 21021);

                                return new XNode[] { f_10623_20990_21018(commentMessage) };
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 20630, 21242);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 20630, 21242);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 21135, 21157);

                                commentMessage = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 21187, 21215);

                                return f_10623_21194_21214();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 20630, 21242);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCatch(10623, 20081, 21265);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(10623, 21302, 21600);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 21350, 21477) || true) && (diagnose)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 21350, 21477);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 21412, 21454);

                            f_10623_21412_21453(_diagnostics, includeDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 21350, 21477);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 21501, 21527);

                        f_10623_21501_21526(
                                            includeDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 21551, 21581);

                        f_10623_21551_21580(this, location);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(10623, 21302, 21600);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10623, 12629, 21615);

                    Microsoft.CodeAnalysis.Location
                    f_10623_12834_12922(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, System.Xml.Linq.XElement
                    includeElement, ref string
                    currentXmlFilePath, ref Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    originatingSyntax)
                    {
                        var return_v = this_param.GetIncludeElementLocation(includeElement, ref currentXmlFilePath, ref originatingSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 12834, 12922);
                        return return_v;
                    }


                    int
                    f_10623_12941_12980(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 12941, 12980);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10623_13017_13045(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 13017, 13045);
                        return return_v;
                    }


                    bool
                    f_10623_13017_13085(Microsoft.CodeAnalysis.SyntaxTree
                    tree)
                    {
                        var return_v = tree.ReportDocumentationCommentDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 13017, 13085);
                        return return_v;
                    }


                    bool
                    f_10623_13111_13140(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, Microsoft.CodeAnalysis.Location
                    location)
                    {
                        var return_v = this_param.EnterIncludeElement(location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 13111, 13140);
                        return return_v;
                    }


                    System.Xml.Linq.XName
                    f_10623_13345_13402(string
                    expandedName)
                    {
                        var return_v = XName.Get(expandedName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 13345, 13402);
                        return return_v;
                    }


                    System.Xml.Linq.XAttribute
                    f_10623_13320_13403(System.Xml.Linq.XElement
                    this_param, System.Xml.Linq.XName
                    name)
                    {
                        var return_v = this_param.Attribute(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 13320, 13403);
                        return return_v;
                    }


                    System.Xml.Linq.XName
                    f_10623_13473_13530(string
                    expandedName)
                    {
                        var return_v = XName.Get(expandedName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 13473, 13530);
                        return return_v;
                    }


                    System.Xml.Linq.XAttribute
                    f_10623_13448_13531(System.Xml.Linq.XElement
                    this_param, System.Xml.Linq.XName
                    name)
                    {
                        var return_v = this_param.Attribute(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 13448, 13531);
                        return return_v;
                    }


                    string
                    f_10623_13577_13591(System.Xml.Linq.XAttribute
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 13577, 13591);
                        return return_v;
                    }


                    string
                    f_10623_13634_13648(System.Xml.Linq.XAttribute
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 13634, 13648);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                    f_10623_13818_13890(Microsoft.CodeAnalysis.CSharp.MessageID
                    id)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 13818, 13890);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10623_13735_13891(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 13735, 13891);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_10623_14006_14034()
                    {
                        var return_v = CultureInfo.CurrentUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 14006, 14034);
                        return return_v;
                    }


                    string
                    f_10623_13956_14035(Microsoft.CodeAnalysis.CSharp.MessageID
                    code, System.Globalization.CultureInfo
                    culture)
                    {
                        var return_v = ErrorFacts.GetMessage(code, culture);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 13956, 14035);
                        return return_v;
                    }


                    System.Xml.Linq.XComment
                    f_10623_14160_14188(string
                    value)
                    {
                        var return_v = new System.Xml.Linq.XComment(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 14160, 14188);
                        return return_v;
                    }


                    System.Xml.Linq.XElement
                    f_10623_14190_14242(System.Xml.Linq.XElement
                    node, bool
                    copyAttributeAnnotations)
                    {
                        var return_v = node.Copy<System.Xml.Linq.XElement>(copyAttributeAnnotations: copyAttributeAnnotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 14190, 14242);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10623_14319_14346()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 14319, 14346);
                        return return_v;
                    }


                    System.Xml.Linq.XName
                    f_10623_14458_14515(string
                    expandedName)
                    {
                        var return_v = XName.Get(expandedName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 14458, 14515);
                        return return_v;
                    }


                    System.Xml.Linq.XAttribute
                    f_10623_14433_14516(System.Xml.Linq.XElement
                    this_param, System.Xml.Linq.XName
                    name)
                    {
                        var return_v = this_param.Attribute(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 14433, 14516);
                        return return_v;
                    }


                    System.Xml.Linq.XName
                    f_10623_14586_14643(string
                    expandedName)
                    {
                        var return_v = XName.Get(expandedName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 14586, 14643);
                        return return_v;
                    }


                    System.Xml.Linq.XAttribute
                    f_10623_14561_14644(System.Xml.Linq.XElement
                    this_param, System.Xml.Linq.XName
                    name)
                    {
                        var return_v = this_param.Attribute(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 14561, 14644);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                    f_10623_14923_14969(Microsoft.CodeAnalysis.CSharp.MessageID
                    id)
                    {
                        var return_v = id.Localize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 14923, 14969);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                    f_10623_14972_15018(Microsoft.CodeAnalysis.CSharp.MessageID
                    id)
                    {
                        var return_v = id.Localize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 14972, 15018);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10623_15045_15119(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 15045, 15119);
                        return return_v;
                    }


                    string
                    f_10623_15163_15220(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.CSharp.MessageID
                    messageId)
                    {
                        var return_v = MakeCommentMessage(location, messageId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 15163, 15220);
                        return return_v;
                    }


                    string
                    f_10623_15326_15340(System.Xml.Linq.XAttribute?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 15326, 15340);
                        return return_v;
                    }


                    string
                    f_10623_15386_15400(System.Xml.Linq.XAttribute?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 15386, 15400);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10623_15440_15460(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 15440, 15460);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.XmlReferenceResolver?
                    f_10623_15440_15481(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.XmlReferenceResolver;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 15440, 15481);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                    f_10623_15663_15769(string
                    targetResourceId)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument(targetResourceId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 15663, 15769);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10623_15574_15770(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 15574, 15770);
                        return return_v;
                    }


                    string
                    f_10623_15814_15874(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.CSharp.MessageID
                    messageId)
                    {
                        var return_v = MakeCommentMessage(location, messageId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 15814, 15874);
                        return return_v;
                    }


                    string?
                    f_10623_15986_16046(Microsoft.CodeAnalysis.XmlReferenceResolver
                    this_param, string
                    path, string
                    baseFilePath)
                    {
                        var return_v = this_param.ResolveReference(path, baseFilePath);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 15986, 16046);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                    f_10623_16302_16395(string
                    targetResourceId)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument(targetResourceId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 16302, 16395);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10623_16213_16396(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 16213, 16396);
                        return return_v;
                    }


                    string
                    f_10623_16440_16500(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.CSharp.MessageID
                    messageId)
                    {
                        var return_v = MakeCommentMessage(location, messageId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 16440, 16500);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DocumentationCommentIncludeCache
                    f_10623_16687_16733(Microsoft.CodeAnalysis.XmlReferenceResolver
                    resolver)
                    {
                        var return_v = new Microsoft.CodeAnalysis.DocumentationCommentIncludeCache(resolver);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 16687, 16733);
                        return return_v;
                    }


                    System.Xml.Linq.XDocument
                    f_10623_16941_16995(Microsoft.CodeAnalysis.DocumentationCommentIncludeCache
                    this_param, string
                    resolvedPath)
                    {
                        var return_v = this_param.GetOrMakeDocument(resolvedPath);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 16941, 16995);
                        return return_v;
                    }


                    string
                    f_10623_17297_17306(System.IO.IOException
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 17297, 17306);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10623_17208_17307(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 17208, 17307);
                        return return_v;
                    }


                    string
                    f_10623_17355_17415(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.CSharp.MessageID
                    messageId)
                    {
                        var return_v = MakeCommentMessage(location, messageId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 17355, 17415);
                        return return_v;
                    }


                    int
                    f_10623_17513_17538(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 17513, 17538);
                        return 0;
                    }


                    System.Xml.Linq.XElement[]?
                    f_10623_17685_17768(System.Xml.Linq.XDocument
                    node, string
                    xpath, out string
                    errorMessage, out bool
                    invalidXPath)
                    {
                        var return_v = XmlUtilities.TrySelectElements((System.Xml.Linq.XNode)node, xpath, out errorMessage, out invalidXPath);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 17685, 17768);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10623_17879_17981(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 17879, 17981);
                        return return_v;
                    }


                    string
                    f_10623_18031_18091(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.CSharp.MessageID
                    messageId)
                    {
                        var return_v = MakeCommentMessage(location, messageId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 18031, 18091);
                        return return_v;
                    }


                    bool
                    f_10623_18348_18367(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.IsInSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 18348, 18367);
                        return return_v;
                    }


                    System.Xml.Linq.XComment
                    f_10623_18555_18583(string
                    value)
                    {
                        var return_v = new System.Xml.Linq.XComment(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 18555, 18583);
                        return return_v;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_18779_18799()
                    {
                        var return_v = Array.Empty<XNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 18779, 18799);
                        return return_v;
                    }


                    int
                    f_10623_18916_18937(System.Xml.Linq.XElement[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 18916, 18937);
                        return return_v;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_19118_19182(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, System.Xml.Linq.XElement[]
                    nodes, string
                    currentXmlFilePath, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    originatingSyntax)
                    {
                        var return_v = this_param.RewriteMany((System.Xml.Linq.XNode[])nodes, currentXmlFilePath, originatingSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 19118, 19182);
                        return return_v;
                    }


                    int
                    f_10623_19521_19534(System.Xml.Linq.XNode[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 19521, 19534);
                        return return_v;
                    }


                    string
                    f_10623_19941_19997(Microsoft.CodeAnalysis.Location
                    location, Microsoft.CodeAnalysis.CSharp.MessageID
                    messageId)
                    {
                        var return_v = MakeCommentMessage(location, messageId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 19941, 19997);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.XmlLocation
                    f_10623_20405_20444(System.Xml.XmlException
                    exception, string
                    path)
                    {
                        var return_v = XmlLocation.Create(exception, path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 20405, 20444);
                        return return_v;
                    }


                    string
                    f_10623_20545_20562(System.Xml.XmlException
                    e)
                    {
                        var return_v = GetDescription(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 20545, 20562);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10623_20471_20563(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location, params object[]
                    args)
                    {
                        var return_v = diagnostics.Add(code, location, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 20471, 20563);
                        return return_v;
                    }


                    bool
                    f_10623_20634_20653(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.IsInSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 20634, 20653);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_10623_20791_20819()
                    {
                        var return_v = CultureInfo.CurrentUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 20791, 20819);
                        return return_v;
                    }


                    string
                    f_10623_20742_20820(Microsoft.CodeAnalysis.CSharp.MessageID
                    code, System.Globalization.CultureInfo
                    culture)
                    {
                        var return_v = ErrorFacts.GetMessage(code, culture);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 20742, 20820);
                        return return_v;
                    }


                    string
                    f_10623_20728_20839(string
                    format, string
                    arg0)
                    {
                        var return_v = string.Format(format, (object)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 20728, 20839);
                        return return_v;
                    }


                    System.Xml.Linq.XComment
                    f_10623_20990_21018(string
                    value)
                    {
                        var return_v = new System.Xml.Linq.XComment(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 20990, 21018);
                        return return_v;
                    }


                    System.Xml.Linq.XNode[]
                    f_10623_21194_21214()
                    {
                        var return_v = Array.Empty<XNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 21194, 21214);
                        return return_v;
                    }


                    int
                    f_10623_21412_21453(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        this_param.AddRange(bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 21412, 21453);
                        return 0;
                    }


                    int
                    f_10623_21501_21526(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 21501, 21526);
                        return 0;
                    }


                    bool
                    f_10623_21551_21580(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, Microsoft.CodeAnalysis.Location
                    location)
                    {
                        var return_v = this_param.LeaveIncludeElement(location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 21551, 21580);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 12629, 21615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 12629, 21615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static string MakeCommentMessage(Location location, MessageID messageId)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10623, 21631, 22007);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 21744, 21992) || true) && (f_10623_21748_21767(location))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 21744, 21992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 21809, 21879);

                        return f_10623_21816_21878(messageId, f_10623_21849_21877());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 21744, 21992);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 21744, 21992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 21961, 21973);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 21744, 21992);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10623, 21631, 22007);

                    bool
                    f_10623_21748_21767(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.IsInSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 21748, 21767);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_10623_21849_21877()
                    {
                        var return_v = CultureInfo.CurrentUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 21849, 21877);
                        return return_v;
                    }


                    string
                    f_10623_21816_21878(Microsoft.CodeAnalysis.CSharp.MessageID
                    code, System.Globalization.CultureInfo
                    culture)
                    {
                        var return_v = ErrorFacts.GetMessage(code, culture);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 21816, 21878);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 21631, 22007);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 21631, 22007);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool EnterIncludeElement(Location location)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10623, 22023, 22354);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 22107, 22267) || true) && (_inProgressIncludeElementNodes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 22107, 22267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 22191, 22248);

                        _inProgressIncludeElementNodes = f_10623_22224_22247();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 22107, 22267);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 22287, 22339);

                    return f_10623_22294_22338(_inProgressIncludeElementNodes, location);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10623, 22023, 22354);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Location>
                    f_10623_22224_22247()
                    {
                        var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Location>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 22224, 22247);
                        return return_v;
                    }


                    bool
                    f_10623_22294_22338(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Location>
                    this_param, Microsoft.CodeAnalysis.Location
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 22294, 22338);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 22023, 22354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 22023, 22354);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool LeaveIncludeElement(Location location)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10623, 22370, 22673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 22454, 22507);

                    f_10623_22454_22506(_inProgressIncludeElementNodes != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 22525, 22587);

                    bool
                    result = f_10623_22539_22586(_inProgressIncludeElementNodes, location)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 22605, 22626);

                    f_10623_22605_22625(result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 22644, 22658);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10623, 22370, 22673);

                    int
                    f_10623_22454_22506(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 22454, 22506);
                        return 0;
                    }


                    bool
                    f_10623_22539_22586(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Location>
                    this_param, Microsoft.CodeAnalysis.Location
                    item)
                    {
                        var return_v = this_param.Remove(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 22539, 22586);
                        return return_v;
                    }


                    int
                    f_10623_22605_22625(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 22605, 22625);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 22370, 22673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 22370, 22673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Location GetIncludeElementLocation(XElement includeElement, ref string currentXmlFilePath, ref CSharpSyntaxNode originatingSyntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10623, 22689, 24197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 22860, 22918);

                    Location
                    location = f_10623_22880_22917(includeElement)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 22936, 23033) || true) && (location != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 22936, 23033);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 22998, 23014);

                        return location;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 22936, 23033);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 23307, 24040) || true) && (currentXmlFilePath == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 23307, 24040);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 23379, 23460);

                        f_10623_23379_23459(_nextSourceIncludeElementIndex < _sourceIncludeElementNodes.Length);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 23482, 23522);

                        f_10623_23482_23521(originatingSyntax == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 23544, 23623);

                        originatingSyntax = _sourceIncludeElementNodes[_nextSourceIncludeElementIndex];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 23645, 23683);

                        location = f_10623_23656_23682(originatingSyntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 23705, 23738);

                        _nextSourceIncludeElementIndex++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 23824, 23873);

                        currentXmlFilePath = f_10623_23845_23867(location).Path;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 23307, 24040);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 23307, 24040);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 23955, 24021);

                        location = f_10623_23966_24020(includeElement, currentXmlFilePath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 23307, 24040);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 24060, 24091);

                    f_10623_24060_24090(location != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 24109, 24148);

                    f_10623_24109_24147(includeElement, location);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 24166, 24182);

                    return location;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10623, 22689, 24197);

                    Microsoft.CodeAnalysis.Location
                    f_10623_22880_22917(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Annotation<Microsoft.CodeAnalysis.Location>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 22880, 22917);
                        return return_v;
                    }


                    int
                    f_10623_23379_23459(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 23379, 23459);
                        return 0;
                    }


                    int
                    f_10623_23482_23521(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 23482, 23521);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10623_23656_23682(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 23656, 23682);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.FileLinePositionSpan
                    f_10623_23845_23867(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.GetLineSpan();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 23845, 23867);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.XmlLocation
                    f_10623_23966_24020(System.Xml.Linq.XElement
                    obj, string
                    path)
                    {
                        var return_v = XmlLocation.Create((System.Xml.Linq.XObject)obj, path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 23966, 24020);
                        return return_v;
                    }


                    int
                    f_10623_24060_24090(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 24060, 24090);
                        return 0;
                    }


                    int
                    f_10623_24109_24147(System.Xml.Linq.XElement
                    this_param, Microsoft.CodeAnalysis.Location
                    annotation)
                    {
                        this_param.AddAnnotation((object)annotation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 24109, 24147);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 22689, 24197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 22689, 24197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void BindAndReplaceCref(XAttribute attribute, CSharpSyntaxNode originatingSyntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10623, 24213, 25833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 24335, 24375);

                    string
                    attributeValue = f_10623_24359_24374(attribute)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 24393, 24457);

                    CrefSyntax
                    crefSyntax = f_10623_24417_24456(attributeValue)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 24477, 24645) || true) && (crefSyntax == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 24477, 24645);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 24619, 24626);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 24477, 24645);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 24836, 24889);

                    Location
                    sourceLocation = f_10623_24862_24888(originatingSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 24909, 24961);

                    f_10623_24909_24960(this, crefSyntax, sourceLocation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 25012, 25120);

                    MemberDeclarationSyntax
                    memberDeclSyntax = f_10623_25055_25119(originatingSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 25138, 25293);

                    f_10623_25138_25292(memberDeclSyntax != null, "Why are we processing a documentation comment that is not attached to a member declaration?");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 25313, 25448);

                    Binder
                    binder = f_10623_25329_25447(crefSyntax, memberDeclSyntax, f_10623_25388_25446(_compilation, f_10623_25418_25445(memberDeclSyntax)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 25468, 25528);

                    DiagnosticBag
                    crefDiagnostics = f_10623_25500_25527()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 25546, 25627);

                    attribute.Value = f_10623_25564_25626(crefSyntax, binder, crefDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 25688, 25746);

                    f_10623_25688_25745(this, crefDiagnostics, sourceLocation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 25795, 25818);

                    f_10623_25795_25817(crefDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10623, 24213, 25833);

                    string
                    f_10623_24359_24374(System.Xml.Linq.XAttribute
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 24359, 24374);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax?
                    f_10623_24417_24456(string
                    text)
                    {
                        var return_v = SyntaxFactory.ParseCref(text);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 24417, 24456);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10623_24862_24888(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 24862, 24888);
                        return return_v;
                    }


                    int
                    f_10623_24909_24960(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                    treelessSyntax, Microsoft.CodeAnalysis.Location
                    sourceLocation)
                    {
                        this_param.RecordSyntaxDiagnostics((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)treelessSyntax, sourceLocation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 24909, 24960);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    f_10623_25055_25119(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    xmlSyntax)
                    {
                        var return_v = BinderFactory.GetAssociatedMemberForXmlSyntax(xmlSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 25055, 25119);
                        return return_v;
                    }


                    int
                    f_10623_25138_25292(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 25138, 25292);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10623_25418_25445(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 25418, 25445);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BinderFactory
                    f_10623_25388_25446(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SyntaxTree
                    syntaxTree)
                    {
                        var return_v = this_param.GetBinderFactory(syntaxTree);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 25388, 25446);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10623_25329_25447(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                    crefSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    memberSyntax, Microsoft.CodeAnalysis.CSharp.BinderFactory
                    factory)
                    {
                        var return_v = BinderFactory.MakeCrefBinder(crefSyntax, memberSyntax, factory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 25329, 25447);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10623_25500_25527()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 25500, 25527);
                        return return_v;
                    }


                    string
                    f_10623_25564_25626(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                    crefSyntax, Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = GetDocumentationCommentId(crefSyntax, binder, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 25564, 25626);
                        return return_v;
                    }


                    int
                    f_10623_25688_25745(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    bindingDiagnostics, Microsoft.CodeAnalysis.Location
                    sourceLocation)
                    {
                        this_param.RecordBindingDiagnostics(bindingDiagnostics, sourceLocation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 25688, 25745);
                        return 0;
                    }


                    int
                    f_10623_25795_25817(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 25795, 25817);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 24213, 25833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 24213, 25833);
                }
            }

            private void BindName(XAttribute attribute, CSharpSyntaxNode originatingSyntax, bool isParameter, bool isTypeParameterRef)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10623, 25849, 27282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 26004, 26114);

                    XmlNameAttributeSyntax
                    attrSyntax = f_10623_26040_26113(f_10623_26059_26079(attribute), f_10623_26081_26112(f_10623_26081_26102(f_10623_26081_26097(attribute))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 26305, 26358);

                    Location
                    sourceLocation = f_10623_26331_26357(originatingSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 26378, 26430);

                    f_10623_26378_26429(this, attrSyntax, sourceLocation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 26481, 26589);

                    MemberDeclarationSyntax
                    memberDeclSyntax = f_10623_26524_26588(originatingSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 26607, 26762);

                    f_10623_26607_26761(memberDeclSyntax != null, "Why are we processing a documentation comment that is not attached to a member declaration?");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 26782, 26842);

                    DiagnosticBag
                    nameDiagnostics = f_10623_26814_26841()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 26860, 26953);

                    Binder
                    binder = f_10623_26876_26952(isParameter, isTypeParameterRef, _memberSymbol, _compilation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 26971, 27119);

                    f_10623_26971_27118(attrSyntax, binder, _memberSymbol, ref _documentedParameters, ref _documentedTypeParameters, nameDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 27137, 27195);

                    f_10623_27137_27194(this, nameDiagnostics, sourceLocation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 27244, 27267);

                    f_10623_27244_27266(nameDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10623, 25849, 27282);

                    string
                    f_10623_26059_26079(System.Xml.Linq.XAttribute
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 26059, 26079);
                        return return_v;
                    }


                    System.Xml.Linq.XElement
                    f_10623_26081_26097(System.Xml.Linq.XAttribute
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 26081, 26097);
                        return return_v;
                    }


                    System.Xml.Linq.XName
                    f_10623_26081_26102(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 26081, 26102);
                        return return_v;
                    }


                    string
                    f_10623_26081_26112(System.Xml.Linq.XName
                    this_param)
                    {
                        var return_v = this_param.LocalName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 26081, 26112);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    f_10623_26040_26113(string
                    attributeText, string
                    elementName)
                    {
                        var return_v = ParseNameAttribute(attributeText, elementName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 26040, 26113);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_10623_26331_26357(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 26331, 26357);
                        return return_v;
                    }


                    int
                    f_10623_26378_26429(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    treelessSyntax, Microsoft.CodeAnalysis.Location
                    sourceLocation)
                    {
                        this_param.RecordSyntaxDiagnostics((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)treelessSyntax, sourceLocation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 26378, 26429);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                    f_10623_26524_26588(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    xmlSyntax)
                    {
                        var return_v = BinderFactory.GetAssociatedMemberForXmlSyntax(xmlSyntax);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 26524, 26588);
                        return return_v;
                    }


                    int
                    f_10623_26607_26761(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 26607, 26761);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10623_26814_26841()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 26814, 26841);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10623_26876_26952(bool
                    isParameter, bool
                    isTypeParameterRef, Microsoft.CodeAnalysis.CSharp.Symbol
                    memberSymbol, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = MakeNameBinder(isParameter, isTypeParameterRef, memberSymbol, compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 26876, 26952);
                        return return_v;
                    }


                    int
                    f_10623_26971_27118(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                    syntax, Microsoft.CodeAnalysis.CSharp.Binder
                    binder, Microsoft.CodeAnalysis.CSharp.Symbol
                    memberSymbol, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    documentedParameters, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    documentedTypeParameters, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        DocumentationCommentCompiler.BindName(syntax, binder, memberSymbol, ref documentedParameters, ref documentedTypeParameters, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 26971, 27118);
                        return 0;
                    }


                    int
                    f_10623_27137_27194(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.IncludeElementExpander
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    bindingDiagnostics, Microsoft.CodeAnalysis.Location
                    sourceLocation)
                    {
                        this_param.RecordBindingDiagnostics(bindingDiagnostics, sourceLocation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 27137, 27194);
                        return 0;
                    }


                    int
                    f_10623_27244_27266(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 27244, 27266);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 25849, 27282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 25849, 27282);
                }
            }

            private static Binder MakeNameBinder(bool isParameter, bool isTypeParameterRef, Symbol memberSymbol, CSharpCompilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10623, 27476, 30604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 27640, 27693);

                    Binder
                    binder = f_10623_27656_27692(compilation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 27778, 27834);

                    Symbol
                    containingSymbol = f_10623_27804_27833(memberSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 27852, 27899);

                    f_10623_27852_27898((object)containingSymbol != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 27917, 27980);

                    binder = f_10623_27926_27979(binder, containingSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 28000, 30555) || true) && (isParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 28000, 30555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 28057, 28140);

                        ImmutableArray<ParameterSymbol>
                        parameters = ImmutableArray<ParameterSymbol>.Empty
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 28164, 29019);

                        switch (f_10623_28172_28189(memberSymbol))
                        {

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 28164, 29019);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 28292, 28345);

                                parameters = f_10623_28305_28344(((MethodSymbol)memberSymbol));
                                DynAbs.Tracing.TraceSender.TraceBreak(10623, 28375, 28381);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 28164, 29019);

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 28164, 29019);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 28462, 28517);

                                parameters = f_10623_28475_28516(((PropertySymbol)memberSymbol));
                                DynAbs.Tracing.TraceSender.TraceBreak(10623, 28547, 28553);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 28164, 29019);

                            case SymbolKind.NamedType:
                            case SymbolKind.ErrorType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 28164, 29019);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 28687, 28746);

                                NamedTypeSymbol
                                typeSymbol = (NamedTypeSymbol)memberSymbol
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 28776, 28960) || true) && (f_10623_28780_28807(typeSymbol))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 28776, 28960);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 28873, 28929);

                                    parameters = f_10623_28886_28928(f_10623_28886_28917(typeSymbol));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 28776, 28960);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10623, 28990, 28996);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 28164, 29019);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 29043, 29195) || true) && (parameters.Length > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 29043, 29195);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 29118, 29172);

                            binder = f_10623_29127_29171(parameters, binder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 29043, 29195);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 28000, 30555);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 28000, 30555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 29277, 29313);

                        Symbol
                        currentSymbol = memberSymbol
                        ;
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 29335, 30536);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 29386, 30384);

                                    switch (f_10623_29394_29412(currentSymbol))
                                    {

                                        case SymbolKind.NamedType: // Includes delegates.
                                        case SymbolKind.ErrorType:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 29386, 30384);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 29609, 29669);

                                            NamedTypeSymbol
                                            typeSymbol = (NamedTypeSymbol)currentSymbol
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 29703, 29899) || true) && (f_10623_29707_29723(typeSymbol) > 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 29703, 29899);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 29801, 29864);

                                                binder = f_10623_29810_29863(typeSymbol, binder);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 29703, 29899);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(10623, 29933, 29939);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 29386, 30384);

                                        case SymbolKind.Method:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 29386, 30384);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 30026, 30082);

                                            MethodSymbol
                                            methodSymbol = (MethodSymbol)currentSymbol
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 30116, 30317) || true) && (f_10623_30120_30138(methodSymbol) > 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 30116, 30317);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 30216, 30282);

                                                binder = f_10623_30225_30281(methodSymbol, binder);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 30116, 30317);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(10623, 30351, 30357);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 29386, 30384);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 30410, 30457);

                                    currentSymbol = f_10623_30426_30456(currentSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 29335, 30536);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 29335, 30536) || true) && (isTypeParameterRef && (DynAbs.Tracing.TraceSender.Expression_True(10623, 30488, 30534) && !(currentSymbol is null)))
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10623, 29335, 30536);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10623, 29335, 30536);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 28000, 30555);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 30575, 30589);

                    return binder;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10623, 27476, 30604);

                    Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                    f_10623_27656_27692(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder(compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 27656, 27692);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10623_27804_27833(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 27804, 27833);
                        return return_v;
                    }


                    int
                    f_10623_27852_27898(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 27852, 27898);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Binder
                    f_10623_27926_27979(Microsoft.CodeAnalysis.CSharp.Binder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    containing)
                    {
                        var return_v = this_param.WithContainingMemberOrLambda(containing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 27926, 27979);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10623_28172_28189(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 28172, 28189);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10623_28305_28344(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 28305, 28344);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10623_28475_28516(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 28475, 28516);
                        return return_v;
                    }


                    bool
                    f_10623_28780_28807(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsDelegateType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 28780, 28807);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10623_28886_28917(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.DelegateInvokeMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 28886, 28917);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10623_28886_28928(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 28886, 28928);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithParametersBinder
                    f_10623_29127_29171(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithParametersBinder(parameters, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 29127, 29171);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10623_29394_29412(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 29394, 29412);
                        return return_v;
                    }


                    int
                    f_10623_29707_29723(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 29707, 29723);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder
                    f_10623_29810_29863(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    container, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder(container, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 29810, 29863);
                        return return_v;
                    }


                    int
                    f_10623_30120_30138(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 30120, 30138);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder
                    f_10623_30225_30281(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder(methodSymbol, next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 30225, 30281);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10623_30426_30456(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 30426, 30456);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 27476, 30604);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 27476, 30604);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static XmlNameAttributeSyntax ParseNameAttribute(string attributeText, string elementName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10623, 30620, 31920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 31097, 31179);

                    string
                    commentText = f_10623_31118_31178(@"/// <{0} {1}/>", elementName, attributeText)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 31199, 31356);

                    SyntaxTriviaList
                    leadingTrivia = f_10623_31232_31355(commentText, f_10623_31278_31354(f_10623_31278_31304(), DocumentationMode.Diagnose))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 31374, 31413);

                    f_10623_31374_31412(leadingTrivia.Count == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 31431, 31480);

                    SyntaxTrivia
                    trivia = leadingTrivia.ElementAt(0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 31498, 31599);

                    DocumentationCommentTriviaSyntax
                    structure = (DocumentationCommentTriviaSyntax)trivia.GetStructure()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 31617, 31660);

                    f_10623_31617_31659(structure.Content.Count == 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 31678, 31760);

                    XmlEmptyElementSyntax
                    elementSyntax = (XmlEmptyElementSyntax)f_10623_31739_31756(structure)[1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 31778, 31828);

                    f_10623_31778_31827(elementSyntax.Attributes.Count == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 31846, 31905);

                    return (XmlNameAttributeSyntax)f_10623_31877_31901(elementSyntax)[0];
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10623, 30620, 31920);

                    string
                    f_10623_31118_31178(string
                    format, string
                    arg0, string
                    arg1)
                    {
                        var return_v = string.Format(format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 31118, 31178);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    f_10623_31278_31304()
                    {
                        var return_v = CSharpParseOptions.Default;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 31278, 31304);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    f_10623_31278_31354(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    this_param, Microsoft.CodeAnalysis.DocumentationMode
                    documentationMode)
                    {
                        var return_v = this_param.WithDocumentationMode(documentationMode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 31278, 31354);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10623_31232_31355(string
                    text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    options)
                    {
                        var return_v = SyntaxFactory.ParseLeadingTrivia(text, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 31232, 31355);
                        return return_v;
                    }


                    int
                    f_10623_31374_31412(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 31374, 31412);
                        return 0;
                    }


                    int
                    f_10623_31617_31659(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 31617, 31659);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                    f_10623_31739_31756(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.Content;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 31739, 31756);
                        return return_v;
                    }


                    int
                    f_10623_31778_31827(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 31778, 31827);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax>
                    f_10623_31877_31901(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                    this_param)
                    {
                        var return_v = this_param.Attributes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 31877, 31901);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 30620, 31920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 30620, 31920);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void RecordSyntaxDiagnostics(CSharpSyntaxNode treelessSyntax, Location sourceLocation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10623, 32063, 32764);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 32190, 32749) || true) && (f_10623_32194_32228(treelessSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(10623, 32194, 32311) && f_10623_32232_32311(((SyntaxTree)f_10623_32245_32270(sourceLocation)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 32190, 32749);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 32512, 32730);
                            foreach (Diagnostic diagnostic in f_10623_32546_32599_I(f_10623_32546_32599(CSharpSyntaxTree.Dummy, treelessSyntax)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 32512, 32730);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 32649, 32707);

                                f_10623_32649_32706(_diagnostics, f_10623_32666_32705(diagnostic, sourceLocation));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 32512, 32730);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10623, 1, 219);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10623, 1, 219);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 32190, 32749);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10623, 32063, 32764);

                    bool
                    f_10623_32194_32228(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.ContainsDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 32194, 32228);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree?
                    f_10623_32245_32270(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.SourceTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 32245, 32270);
                        return return_v;
                    }


                    bool
                    f_10623_32232_32311(Microsoft.CodeAnalysis.SyntaxTree?
                    tree)
                    {
                        var return_v = tree.ReportDocumentationCommentDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 32232, 32311);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                    f_10623_32546_32599(Microsoft.CodeAnalysis.SyntaxTree
                    this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node)
                    {
                        var return_v = this_param.GetDiagnostics((Microsoft.CodeAnalysis.SyntaxNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 32546, 32599);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_10623_32666_32705(Microsoft.CodeAnalysis.Diagnostic
                    this_param, Microsoft.CodeAnalysis.Location
                    location)
                    {
                        var return_v = this_param.WithLocation(location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 32666, 32705);
                        return return_v;
                    }


                    int
                    f_10623_32649_32706(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diag)
                    {
                        this_param.Add(diag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 32649, 32706);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                    f_10623_32546_32599_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 32546, 32599);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 32063, 32764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 32063, 32764);
                }
            }

            private void RecordBindingDiagnostics(DiagnosticBag bindingDiagnostics, Location sourceLocation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10623, 32907, 33559);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 33036, 33544) || true) && (f_10623_33040_33084_M(!bindingDiagnostics.IsEmptyWithoutResolution) && (DynAbs.Tracing.TraceSender.Expression_True(10623, 33040, 33167) && f_10623_33088_33167(((SyntaxTree)f_10623_33101_33126(sourceLocation)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 33036, 33544);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 33209, 33525);
                            foreach (Diagnostic diagnostic in f_10623_33243_33276_I(f_10623_33243_33276(bindingDiagnostics)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10623, 33209, 33525);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10623, 33444, 33502);

                                f_10623_33444_33501(                        // CONSIDER: Dev11 actually uses the originating location plus the offset into the cref/name
                                                        _diagnostics, f_10623_33461_33500(diagnostic, sourceLocation));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 33209, 33525);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10623, 1, 317);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10623, 1, 317);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10623, 33036, 33544);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10623, 32907, 33559);

                    bool
                    f_10623_33040_33084_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 33040, 33084);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTree?
                    f_10623_33101_33126(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.SourceTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10623, 33101, 33126);
                        return return_v;
                    }


                    bool
                    f_10623_33088_33167(Microsoft.CodeAnalysis.SyntaxTree?
                    tree)
                    {
                        var return_v = tree.ReportDocumentationCommentDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 33088, 33167);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                    f_10623_33243_33276(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        var return_v = this_param.AsEnumerable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 33243, 33276);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_10623_33461_33500(Microsoft.CodeAnalysis.Diagnostic
                    this_param, Microsoft.CodeAnalysis.Location
                    location)
                    {
                        var return_v = this_param.WithLocation(location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 33461, 33500);
                        return return_v;
                    }


                    int
                    f_10623_33444_33501(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diag)
                    {
                        this_param.Add(diag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 33444, 33501);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                    f_10623_33243_33276_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10623, 33243, 33276);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10623, 32907, 33559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 32907, 33559);
                }
            }

            static IncludeElementExpander()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10623, 910, 33570);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10623, 910, 33570);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10623, 910, 33570);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10623, 910, 33570);
        }
    }
}
