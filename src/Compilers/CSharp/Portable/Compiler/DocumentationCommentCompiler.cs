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
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Xml;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class DocumentationCommentCompiler : CSharpSymbolVisitor
    {
        private readonly string _assemblyName;

        private readonly CSharpCompilation _compilation;

        private readonly TextWriter _writer;

        private readonly SyntaxTree _filterTree;

        private readonly TextSpan? _filterSpanWithinTree;

        private readonly bool _processIncludes;

        private readonly bool _isForSingleSymbol;

        private readonly DiagnosticBag _diagnostics;

        private readonly CancellationToken _cancellationToken;

        private SyntaxNodeLocationComparer _lazyComparer;

        private DocumentationCommentIncludeCache _includedFileCache;

        private int _indentDepth;

        private Stack<TemporaryStringBuilder> _temporaryStringBuilders;

        private DocumentationCommentCompiler(
                    string assemblyName,
                    CSharpCompilation compilation,
                    TextWriter writer,
                    SyntaxTree filterTree,
                    TextSpan? filterSpanWithinTree,
                    bool processIncludes,
                    bool isForSingleSymbol,
                    DiagnosticBag diagnostics,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10069, 2075, 2898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1081, 1094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1140, 1152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1191, 1198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1282, 1293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1392, 1413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1569, 1585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1618, 1636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1743, 1755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1867, 1880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1932, 1950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 1975, 1987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 2038, 2062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 2490, 2519);

                _assemblyName = assemblyName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 2535, 2562);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 2576, 2593);

                _writer = writer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 2607, 2632);

                _filterTree = filterTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 2646, 2691);

                _filterSpanWithinTree = filterSpanWithinTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 2705, 2740);

                _processIncludes = processIncludes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 2754, 2793);

                _isForSingleSymbol = isForSingleSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 2807, 2834);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 2848, 2887);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10069, 2075, 2898);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 2075, 2898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 2075, 2898);
            }
        }

        public static void WriteDocumentationCommentXml(CSharpCompilation compilation, string? assemblyName, Stream? xmlDocStream, DiagnosticBag diagnostics, CancellationToken cancellationToken, SyntaxTree? filterTree = null, TextSpan? filterSpanWithinTree = null)
        {
            try
#nullable disable
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 3972, 6096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 4272, 4299);

                StreamWriter
                writer = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 4313, 4720) || true) && (xmlDocStream != null && (DynAbs.Tracing.TraceSender.Expression_True(10069, 4317, 4362) && f_10069_4341_4362(xmlDocStream)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 4313, 4720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 4396, 4673);

                    writer = f_10069_4405_4672(stream: xmlDocStream, encoding: f_10069_4497_4581(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: false), bufferSize: 0x400, leaveOpen: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 4313, 4720);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 4772, 5318);
                    using (writer)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 4827, 5117);

                        var
                        compiler = f_10069_4842_5116(assemblyName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10069, 4875, 4922) ?? f_10069_4891_4922(f_10069_4891_4917(compilation))), compilation, writer, filterTree, filterSpanWithinTree, processIncludes: true, isForSingleSymbol: false, diagnostics: diagnostics, cancellationToken: cancellationToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 5139, 5198);

                        f_10069_5139_5197(compiler, f_10069_5154_5196(f_10069_5154_5180(compilation)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 5220, 5261);

                        f_10069_5220_5260(compiler._indentDepth == 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 5283, 5299);

                        f_10069_5290_5298(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(writer, 10069, 5283, 5298));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10069, 4772, 5318);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10069, 5347, 5482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 5399, 5467);

                    f_10069_5399_5466(diagnostics, ErrorCode.ERR_DocFileGen, f_10069_5441_5454(), f_10069_5456_5465(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10069, 5347, 5482);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 5498, 6085) || true) && (filterTree != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 5498, 6085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 5610, 5732);

                    f_10069_5610_5731(filterTree, filterSpanWithinTree, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 5498, 6085);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 5498, 6085);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 5798, 6070);
                        foreach (SyntaxTree tree in f_10069_5826_5849_I(f_10069_5826_5849(compilation)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 5798, 6070);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 5951, 6051);

                            f_10069_5951_6050(tree, null, diagnostics, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 5798, 6070);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 273);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 273);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 5498, 6085);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 3972, 6096);

                bool
                f_10069_4341_4362(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.CanWrite;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 4341, 4362);
                    return return_v;
                }


                System.Text.UTF8Encoding
                f_10069_4497_4581(bool
                encoderShouldEmitUTF8Identifier, bool
                throwOnInvalidBytes)
                {
                    var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: encoderShouldEmitUTF8Identifier, throwOnInvalidBytes: throwOnInvalidBytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 4497, 4581);
                    return return_v;
                }


                System.IO.StreamWriter
                f_10069_4405_4672(System.IO.Stream
                stream, System.Text.UTF8Encoding
                encoding, int
                bufferSize, bool
                leaveOpen)
                {
                    var return_v = new System.IO.StreamWriter(stream: stream, encoding: (System.Text.Encoding)encoding, bufferSize: bufferSize, leaveOpen: leaveOpen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 4405, 4672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10069_4891_4917(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 4891, 4917);
                    return return_v;
                }


                string
                f_10069_4891_4922(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 4891, 4922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                f_10069_4842_5116(string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.IO.StreamWriter?
                writer, Microsoft.CodeAnalysis.SyntaxTree?
                filterTree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree, bool
                processIncludes, bool
                isForSingleSymbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler(assemblyName, compilation, (System.IO.TextWriter?)writer, filterTree, filterSpanWithinTree, processIncludes: processIncludes, isForSingleSymbol: isForSingleSymbol, diagnostics: diagnostics, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 4842, 5116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10069_5154_5180(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 5154, 5180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10069_5154_5196(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 5154, 5196);
                    return return_v;
                }


                int
                f_10069_5139_5197(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 5139, 5197);
                    return 0;
                }


                int
                f_10069_5220_5260(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 5220, 5260);
                    return 0;
                }


                int
                f_10069_5290_5298(System.IO.StreamWriter
                this_param)
                {
                    this_param?.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 5290, 5298);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10069_5441_5454()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 5441, 5454);
                    return return_v;
                }


                string
                f_10069_5456_5465(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 5456, 5465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_5399_5466(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 5399, 5466);
                    return return_v;
                }


                int
                f_10069_5610_5731(Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    UnprocessedDocumentationCommentFinder.ReportUnprocessed(tree, filterSpanWithinTree, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 5610, 5731);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_10069_5826_5849(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 5826, 5849);
                    return return_v;
                }


                int
                f_10069_5951_6050(Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    UnprocessedDocumentationCommentFinder.ReportUnprocessed(tree, filterSpanWithinTree, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 5951, 6050);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_10069_5826_5849_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 5826, 5849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 3972, 6096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 3972, 6096);
            }
        }

        internal static string GetDocumentationCommentXml(Symbol symbol, bool processIncludes, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 6609, 8070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 6757, 7037);

                f_10069_6757_7036(f_10069_6788_6799(symbol) == SymbolKind.Event || (DynAbs.Tracing.TraceSender.Expression_False(10069, 6788, 6871) || f_10069_6840_6851(symbol) == SymbolKind.Field) || (DynAbs.Tracing.TraceSender.Expression_False(10069, 6788, 6924) || f_10069_6892_6903(symbol) == SymbolKind.Method) || (DynAbs.Tracing.TraceSender.Expression_False(10069, 6788, 6980) || f_10069_6945_6956(symbol) == SymbolKind.NamedType) || (DynAbs.Tracing.TraceSender.Expression_False(10069, 6788, 7035) || f_10069_7001_7012(symbol) == SymbolKind.Property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 7053, 7113);

                CSharpCompilation
                compilation = f_10069_7085_7112(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 7127, 7161);

                f_10069_7127_7160(compilation != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 7177, 7240);

                PooledStringBuilder
                pooled = f_10069_7206_7239()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 7254, 7309);

                StringWriter
                writer = f_10069_7276_7308(pooled.Builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 7323, 7388);

                DiagnosticBag
                discardedDiagnostics = f_10069_7360_7387()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 7404, 7846);

                var
                compiler = f_10069_7419_7845(assemblyName: null, compilation: compilation, writer: writer, filterTree: null, filterSpanWithinTree: null, processIncludes: processIncludes, isForSingleSymbol: true, diagnostics: discardedDiagnostics, cancellationToken: cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 7860, 7883);

                f_10069_7860_7882(compiler, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 7897, 7938);

                f_10069_7897_7937(compiler._indentDepth == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 7954, 7982);

                f_10069_7954_7981(
                            discardedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 7996, 8013);

                f_10069_7996_8012(writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8027, 8059);

                return f_10069_8034_8058(pooled);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 6609, 8070);

                Microsoft.CodeAnalysis.SymbolKind
                f_10069_6788_6799(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 6788, 6799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10069_6840_6851(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 6840, 6851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10069_6892_6903(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 6892, 6903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10069_6945_6956(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 6945, 6956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10069_7001_7012(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 7001, 7012);
                    return return_v;
                }


                int
                f_10069_6757_7036(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 6757, 7036);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10069_7085_7112(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 7085, 7112);
                    return return_v;
                }


                int
                f_10069_7127_7160(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 7127, 7160);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10069_7206_7239()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 7206, 7239);
                    return return_v;
                }


                System.IO.StringWriter
                f_10069_7276_7308(System.Text.StringBuilder
                sb)
                {
                    var return_v = new System.IO.StringWriter(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 7276, 7308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10069_7360_7387()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 7360, 7387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                f_10069_7419_7845(string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.IO.StringWriter
                writer, Microsoft.CodeAnalysis.SyntaxTree
                filterTree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree, bool
                processIncludes, bool
                isForSingleSymbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler(assemblyName: assemblyName, compilation: compilation, writer: (System.IO.TextWriter)writer, filterTree: filterTree, filterSpanWithinTree: filterSpanWithinTree, processIncludes: processIncludes, isForSingleSymbol: isForSingleSymbol, diagnostics: diagnostics, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 7419, 7845);
                    return return_v;
                }


                int
                f_10069_7860_7882(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.Visit(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 7860, 7882);
                    return 0;
                }


                int
                f_10069_7897_7937(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 7897, 7937);
                    return 0;
                }


                int
                f_10069_7954_7981(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 7954, 7981);
                    return 0;
                }


                int
                f_10069_7996_8012(System.IO.StringWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 7996, 8012);
                    return 0;
                }


                string
                f_10069_8034_8058(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8034, 8058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 6609, 8070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 6609, 8070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void VisitNamespace(NamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 8196, 9440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8280, 8330);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8346, 8983) || true) && (f_10069_8350_8374(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 8346, 8983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8408, 8444);

                    f_10069_8408_8443(_assemblyName != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8464, 8501);

                    f_10069_8464_8500(this, "<?xml version=\"1.0\"?>");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8519, 8538);

                    f_10069_8519_8537(this, "<doc>");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8556, 8565);

                    f_10069_8556_8564(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8585, 8898) || true) && (!f_10069_8590_8635(f_10069_8590_8621(f_10069_8590_8610(_compilation))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 8585, 8898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8677, 8701);

                        f_10069_8677_8700(this, "<assembly>");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8723, 8732);

                        f_10069_8723_8731(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8754, 8799);

                        f_10069_8754_8798(this, "<name>{0}</name>", _assemblyName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8821, 8832);

                        f_10069_8821_8831(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8854, 8879);

                        f_10069_8854_8878(this, "</assembly>");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 8585, 8898);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8918, 8941);

                    f_10069_8918_8940(this, "<members>");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8959, 8968);

                    f_10069_8959_8967(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 8346, 8983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 8999, 9033);

                f_10069_8999_9032(!_isForSingleSymbol);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9047, 9216);
                    foreach (var s in f_10069_9065_9084_I(f_10069_9065_9084(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 9047, 9216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9118, 9168);

                        _cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9186, 9201);

                        f_10069_9186_9200(s, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 9047, 9216);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 170);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9232, 9429) || true) && (f_10069_9236_9260(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 9232, 9429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9294, 9305);

                    f_10069_9294_9304(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9323, 9347);

                    f_10069_9323_9346(this, "</members>");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9365, 9376);

                    f_10069_9365_9375(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9394, 9414);

                    f_10069_9394_9413(this, "</doc>");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 9232, 9429);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 8196, 9440);

                bool
                f_10069_8350_8374(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 8350, 8374);
                    return return_v;
                }


                int
                f_10069_8408_8443(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8408, 8443);
                    return 0;
                }


                int
                f_10069_8464_8500(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8464, 8500);
                    return 0;
                }


                int
                f_10069_8519_8537(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8519, 8537);
                    return 0;
                }


                int
                f_10069_8556_8564(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    this_param.Indent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8556, 8564);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10069_8590_8610(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 8590, 8610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10069_8590_8621(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 8590, 8621);
                    return return_v;
                }


                bool
                f_10069_8590_8635(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8590, 8635);
                    return return_v;
                }


                int
                f_10069_8677_8700(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8677, 8700);
                    return 0;
                }


                int
                f_10069_8723_8731(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    this_param.Indent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8723, 8731);
                    return 0;
                }


                int
                f_10069_8754_8798(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                format, params object[]
                args)
                {
                    this_param.WriteLine(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8754, 8798);
                    return 0;
                }


                int
                f_10069_8821_8831(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    this_param.Unindent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8821, 8831);
                    return 0;
                }


                int
                f_10069_8854_8878(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8854, 8878);
                    return 0;
                }


                int
                f_10069_8918_8940(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8918, 8940);
                    return 0;
                }


                int
                f_10069_8959_8967(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    this_param.Indent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8959, 8967);
                    return 0;
                }


                int
                f_10069_8999_9032(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 8999, 9032);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10069_9065_9084(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 9065, 9084);
                    return return_v;
                }


                int
                f_10069_9186_9200(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 9186, 9200);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10069_9065_9084_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 9065, 9084);
                    return return_v;
                }


                bool
                f_10069_9236_9260(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 9236, 9260);
                    return return_v;
                }


                int
                f_10069_9294_9304(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    this_param.Unindent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 9294, 9304);
                    return 0;
                }


                int
                f_10069_9323_9346(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 9323, 9346);
                    return 0;
                }


                int
                f_10069_9365_9375(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    this_param.Unindent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 9365, 9375);
                    return 0;
                }


                int
                f_10069_9394_9413(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 9394, 9413);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 8196, 9440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 8196, 9440);
            }
        }

        public override void VisitNamedType(NamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 9576, 10208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9660, 9710);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9726, 9874) || true) && (_filterTree != null && (DynAbs.Tracing.TraceSender.Expression_True(10069, 9730, 9818) && !f_10069_9754_9818(symbol, _filterTree, _filterSpanWithinTree)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 9726, 9874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9852, 9859);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 9726, 9874);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9890, 9911);

                f_10069_9890_9910(this, symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9927, 10197) || true) && (!_isForSingleSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 9927, 10197);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 9984, 10182);
                        foreach (Symbol member in f_10069_10010_10029_I(f_10069_10010_10029(symbol)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 9984, 10182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 10071, 10121);

                            _cancellationToken.ThrowIfCancellationRequested();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 10143, 10163);

                            f_10069_10143_10162(member, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 9984, 10182);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 199);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 199);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 9927, 10197);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 9576, 10208);

                bool
                f_10069_9754_9818(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan?
                definedWithinSpan)
                {
                    var return_v = this_param.IsDefinedInSourceTree(tree, definedWithinSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 9754, 9818);
                    return return_v;
                }


                int
                f_10069_9890_9910(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 9890, 9910);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10069_10010_10029(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 10010, 10029);
                    return return_v;
                }


                int
                f_10069_10143_10162(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 10143, 10162);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10069_10010_10029_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 10010, 10029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 9576, 10208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 9576, 10208);
            }
        }

        public override void DefaultVisit(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 10374, 17643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 10447, 10497);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 10513, 10591) || true) && (f_10069_10517_10535(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 10513, 10591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 10569, 10576);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 10513, 10591);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 10607, 10755) || true) && (_filterTree != null && (DynAbs.Tracing.TraceSender.Expression_True(10069, 10611, 10699) && !f_10069_10635_10699(symbol, _filterTree, _filterSpanWithinTree)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 10607, 10755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 10733, 10740);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 10607, 10755);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 10771, 10837);

                bool
                isPartialMethodDefinitionPart = f_10069_10808_10836(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 10898, 11206) || true) && (isPartialMethodDefinitionPart)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 10898, 11206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 10965, 11048);

                    MethodSymbol
                    implementationPart = f_10069_10999_11047(((MethodSymbol)symbol))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 11066, 11191) || true) && ((object)implementationPart != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 11066, 11191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 11146, 11172);

                        f_10069_11146_11171(this, implementationPart);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 11066, 11191);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 10898, 11206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 11222, 11261);

                DocumentationMode
                maxDocumentationMode
                = default(DocumentationMode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 11275, 11340);

                ImmutableArray<DocumentationCommentTriviaSyntax>
                docCommentNodes
                = default(ImmutableArray<DocumentationCommentTriviaSyntax>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 11354, 11937) || true) && (!f_10069_11359_11445(this, symbol, out maxDocumentationMode, out docCommentNodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 11354, 11937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 11684, 11779);

                    string
                    message = f_10069_11701_11778(MessageID.IDS_XMLIGNORED, f_10069_11749_11777())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 11797, 11897);

                    f_10069_11797_11896(this, f_10069_11807_11895(f_10069_11821_11849(), message, f_10069_11860_11894(symbol)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 11915, 11922);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 11354, 11937);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 12088, 12711) || true) && (docCommentNodes.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 12088, 12711);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 12149, 12671) || true) && (maxDocumentationMode >= DocumentationMode.Diagnose && (DynAbs.Tracing.TraceSender.Expression_True(10069, 12153, 12243) && f_10069_12207_12243(symbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 12149, 12671);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 12383, 12469);

                        Location
                        location = f_10069_12403_12468(symbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 12491, 12652) || true) && (location != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 12491, 12652);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 12561, 12629);

                            f_10069_12561_12628(_diagnostics, ErrorCode.WRN_MissingXMLComment, location, symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 12491, 12652);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 12149, 12671);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 12689, 12696);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 12088, 12711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 12727, 12777);

                _cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 12793, 12916);

                bool
                reportParameterOrTypeParameterDiagnostics = f_10069_12842_12907(symbol) != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 12932, 12963);

                string
                withUnprocessedIncludes
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 12977, 12997);

                bool
                haveParseError
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 13011, 13065);

                HashSet<TypeParameterSymbol>
                documentedTypeParameters
                = default(HashSet<TypeParameterSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 13079, 13125);

                HashSet<ParameterSymbol>
                documentedParameters
                = default(HashSet<ParameterSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 13139, 13192);

                ImmutableArray<CSharpSyntaxNode>
                includeElementNodes
                = default(ImmutableArray<CSharpSyntaxNode>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 13206, 13727) || true) && (!f_10069_13211_13671(this, symbol, isPartialMethodDefinitionPart, docCommentNodes, reportParameterOrTypeParameterDiagnostics, out withUnprocessedIncludes, out haveParseError, out documentedTypeParameters, out documentedParameters, out includeElementNodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 13206, 13727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 13705, 13712);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 13206, 13727);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 13743, 14253) || true) && (haveParseError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 13743, 14253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 14000, 14095);

                    string
                    message = f_10069_14017_14094(MessageID.IDS_XMLIGNORED, f_10069_14065_14093())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 14113, 14213);

                    f_10069_14113_14212(this, f_10069_14123_14211(f_10069_14137_14165(), message, f_10069_14176_14210(symbol)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 14231, 14238);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 13743, 14253);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 14351, 15968) || true) && (f_10069_14355_14392_M(!includeElementNodes.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 14351, 15968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 14426, 14476);

                    _cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 14854, 14929);

                    TextWriter
                    expanderWriter = (DynAbs.Tracing.TraceSender.Conditional_F1(10069, 14882, 14911) || ((isPartialMethodDefinitionPart && DynAbs.Tracing.TraceSender.Conditional_F2(10069, 14914, 14918)) || DynAbs.Tracing.TraceSender.Conditional_F3(10069, 14921, 14928))) ? null : _writer
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 15004, 15262);

                    f_10069_15004_15261(withUnprocessedIncludes, symbol, includeElementNodes, _compilation, ref documentedParameters, ref documentedTypeParameters, ref _includedFileCache, expanderWriter, _diagnostics, _cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 14351, 15968);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 14351, 15968);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 15296, 15968) || true) && (_writer != null && (DynAbs.Tracing.TraceSender.Expression_True(10069, 15300, 15349) && !isPartialMethodDefinitionPart))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 15296, 15968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 15922, 15953);

                        f_10069_15922_15952(this, withUnprocessedIncludes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 15296, 15968);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 14351, 15968);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 15984, 17632) || true) && (reportParameterOrTypeParameterDiagnostics)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 15984, 17632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 16063, 16113);

                    _cancellationToken.ThrowIfCancellationRequested();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 16133, 16905) || true) && (documentedParameters != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 16133, 16905);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 16207, 16886);
                            foreach (ParameterSymbol parameter in f_10069_16245_16266_I(f_10069_16245_16266(symbol)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 16207, 16886);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 16316, 16863) || true) && (!f_10069_16321_16361(documentedParameters, parameter))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 16316, 16863);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 16419, 16462);

                                    Location
                                    location = f_10069_16439_16458(parameter)[0]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 16492, 16566);

                                    f_10069_16492_16565(f_10069_16505_16564(f_10069_16505_16524(location)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 16754, 16836);

                                    f_10069_16754_16835(
                                                                // NOTE: parameter name, since the parameter would be displayed as just its type.
                                                                _diagnostics, ErrorCode.WRN_MissingParamTag, location, f_10069_16812_16826(parameter), symbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 16316, 16863);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 16207, 16886);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 680);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 680);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 16133, 16905);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 16925, 17617) || true) && (documentedTypeParameters != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 16925, 17617);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 17003, 17598);
                            foreach (TypeParameterSymbol typeParameter in f_10069_17049_17074_I(f_10069_17049_17074(symbol)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 17003, 17598);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 17124, 17575) || true) && (!f_10069_17129_17177(documentedTypeParameters, typeParameter))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 17124, 17575);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 17235, 17282);

                                    Location
                                    location = f_10069_17255_17278(typeParameter)[0]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 17312, 17386);

                                    f_10069_17312_17385(f_10069_17325_17384(f_10069_17325_17344(location)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 17463, 17548);

                                    f_10069_17463_17547(
                                                                _diagnostics, ErrorCode.WRN_MissingTypeParamTag, location, typeParameter, symbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 17124, 17575);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 17003, 17598);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 596);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 596);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 16925, 17617);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 15984, 17632);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 10374, 17643);

                bool
                f_10069_10517_10535(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = ShouldSkip(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 10517, 10535);
                    return return_v;
                }


                bool
                f_10069_10635_10699(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan?
                definedWithinSpan)
                {
                    var return_v = this_param.IsDefinedInSourceTree(tree, definedWithinSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 10635, 10699);
                    return return_v;
                }


                bool
                f_10069_10808_10836(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.IsPartialDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 10808, 10836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10069_10999_11047(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialImplementationPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 10999, 11047);
                    return return_v;
                }


                int
                f_10069_11146_11171(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 11146, 11171);
                    return 0;
                }


                bool
                f_10069_11359_11445(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, out Microsoft.CodeAnalysis.DocumentationMode
                maxDocumentationMode, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                nodes)
                {
                    var return_v = this_param.TryGetDocumentationCommentNodes(symbol, out maxDocumentationMode, out nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 11359, 11445);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10069_11749_11777()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 11749, 11777);
                    return return_v;
                }


                string
                f_10069_11701_11778(Microsoft.CodeAnalysis.CSharp.MessageID
                code, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = ErrorFacts.GetMessage(code, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 11701, 11778);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10069_11821_11849()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 11821, 11849);
                    return return_v;
                }


                string
                f_10069_11860_11894(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetDocumentationCommentId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 11860, 11894);
                    return return_v;
                }


                string
                f_10069_11807_11895(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 11807, 11895);
                    return return_v;
                }


                int
                f_10069_11797_11896(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 11797, 11896);
                    return 0;
                }


                bool
                f_10069_12207_12243(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = RequiresDocumentationComment(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 12207, 12243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10069_12403_12468(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = GetLocationInTreeReportingDocumentationCommentDiagnostics(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 12403, 12468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_12561_12628(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 12561, 12628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10069_12842_12907(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = GetLocationInTreeReportingDocumentationCommentDiagnostics(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 12842, 12907);
                    return return_v;
                }


                bool
                f_10069_13211_13671(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, bool
                isPartialMethodDefinitionPart, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                docCommentNodes, bool
                reportParameterOrTypeParameterDiagnostics, out string
                withUnprocessedIncludes, out bool
                haveParseError, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                documentedTypeParameters, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                documentedParameters, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                includeElementNodes)
                {
                    var return_v = this_param.TryProcessDocumentationCommentTriviaNodes(symbol, isPartialMethodDefinitionPart, docCommentNodes, reportParameterOrTypeParameterDiagnostics, out withUnprocessedIncludes, out haveParseError, out documentedTypeParameters, out documentedParameters, out includeElementNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 13211, 13671);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10069_14065_14093()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 14065, 14093);
                    return return_v;
                }


                string
                f_10069_14017_14094(Microsoft.CodeAnalysis.CSharp.MessageID
                code, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = ErrorFacts.GetMessage(code, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 14017, 14094);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10069_14137_14165()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 14137, 14165);
                    return return_v;
                }


                string
                f_10069_14176_14210(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetDocumentationCommentId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 14176, 14210);
                    return return_v;
                }


                string
                f_10069_14123_14211(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 14123, 14211);
                    return return_v;
                }


                int
                f_10069_14113_14212(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 14113, 14212);
                    return 0;
                }


                bool
                f_10069_14355_14392_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 14355, 14392);
                    return return_v;
                }


                int
                f_10069_15004_15261(string
                unprocessed, Microsoft.CodeAnalysis.CSharp.Symbol
                memberSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                sourceIncludeElementNodes, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                documentedParameters, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                documentedTypeParameters, ref Microsoft.CodeAnalysis.DocumentationCommentIncludeCache
                includedFileCache, System.IO.TextWriter?
                writer, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    IncludeElementExpander.ProcessIncludes(unprocessed, memberSymbol, sourceIncludeElementNodes, compilation, ref documentedParameters, ref documentedTypeParameters, ref includedFileCache, writer, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 15004, 15261);
                    return 0;
                }


                int
                f_10069_15922_15952(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                indentedAndWrappedString)
                {
                    this_param.Write(indentedAndWrappedString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 15922, 15952);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10069_16245_16266(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = GetParameters(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 16245, 16266);
                    return return_v;
                }


                bool
                f_10069_16321_16361(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 16321, 16361);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10069_16439_16458(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 16439, 16458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10069_16505_16524(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 16505, 16524);
                    return return_v;
                }


                bool
                f_10069_16505_16564(Microsoft.CodeAnalysis.SyntaxTree?
                tree)
                {
                    var return_v = tree.ReportDocumentationCommentDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 16505, 16564);
                    return return_v;
                }


                int
                f_10069_16492_16565(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 16492, 16565);
                    return 0;
                }


                string
                f_10069_16812_16826(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 16812, 16826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_16754_16835(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 16754, 16835);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10069_16245_16266_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 16245, 16266);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10069_17049_17074(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = GetTypeParameters(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 17049, 17074);
                    return return_v;
                }


                bool
                f_10069_17129_17177(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 17129, 17177);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10069_17255_17278(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 17255, 17278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10069_17325_17344(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 17325, 17344);
                    return return_v;
                }


                bool
                f_10069_17325_17384(Microsoft.CodeAnalysis.SyntaxTree?
                tree)
                {
                    var return_v = tree.ReportDocumentationCommentDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 17325, 17384);
                    return return_v;
                }


                int
                f_10069_17312_17385(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 17312, 17385);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_17463_17547(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 17463, 17547);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10069_17049_17074_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 17049, 17074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 10374, 17643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 10374, 17643);
            }
        }

        private static bool ShouldSkip(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 17655, 18003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 17725, 17992);

                return f_10069_17732_17759(symbol) || (DynAbs.Tracing.TraceSender.Expression_False(10069, 17732, 17799) || f_10069_17780_17799(symbol)) || (DynAbs.Tracing.TraceSender.Expression_False(10069, 17732, 17870) || symbol is SynthesizedSimpleProgramEntryPointSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10069, 17732, 17929) || symbol is SimpleProgramNamedTypeSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10069, 17732, 17991) || symbol is SynthesizedRecordPropertySymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 17655, 18003);

                bool
                f_10069_17732_17759(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 17732, 17759);
                    return return_v;
                }


                bool
                f_10069_17780_17799(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 17780, 17799);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 17655, 18003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 17655, 18003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryProcessDocumentationCommentTriviaNodes(
                    Symbol symbol,
                    bool isPartialMethodDefinitionPart,
                    ImmutableArray<DocumentationCommentTriviaSyntax> docCommentNodes,
                    bool reportParameterOrTypeParameterDiagnostics,
                    out string withUnprocessedIncludes,
                    out bool haveParseError,
                    out HashSet<TypeParameterSymbol> documentedTypeParameters,
                    out HashSet<ParameterSymbol> documentedParameters,
                    out ImmutableArray<CSharpSyntaxNode> includeElementNodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 18655, 23594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 19246, 19294);

                f_10069_19246_19293(f_10069_19259_19292_M(!docCommentNodes.IsDefaultOrEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 19310, 19343);

                bool
                processedDocComment = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 19454, 19519);

                ArrayBuilder<CSharpSyntaxNode>
                includeElementNodesBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 19535, 19563);

                documentedParameters = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 19577, 19609);

                documentedTypeParameters = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 19726, 19749);

                haveParseError = false;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 19974, 22838);
                    foreach (DocumentationCommentTriviaSyntax trivia in f_10069_20026_20041_I(docCommentNodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 19974, 22838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 20075, 20125);

                        _cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 20145, 20244);

                        bool
                        reportDiagnosticsForCurrentTrivia = f_10069_20186_20243(f_10069_20186_20203(trivia))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 20264, 21172) || true) && (!processedDocComment)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 20264, 21172);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 20458, 20481);

                            f_10069_20458_20480(this);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 20505, 20672) || true) && (_processIncludes)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 20505, 20672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 20575, 20649);

                                includeElementNodesBuilder = f_10069_20604_20648();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 20505, 20672);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 20869, 21102) || true) && (!isPartialMethodDefinitionPart || (DynAbs.Tracing.TraceSender.Expression_False(10069, 20873, 20923) || _processIncludes))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 20869, 21102);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 20973, 21044);

                                f_10069_20973_21043(this, "<member name=\"{0}\">", f_10069_21008_21042(symbol));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 21070, 21079);

                                f_10069_21070_21078(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 20869, 21102);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 21126, 21153);

                            processedDocComment = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 20264, 21172);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 21248, 21468);

                        string
                        substitutedText = f_10069_21273_21467(_compilation, _diagnostics, symbol, trivia, includeElementNodesBuilder, ref documentedParameters, ref documentedTypeParameters)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 21488, 21541);

                        string
                        formattedXml = f_10069_21510_21540(this, substitutedText)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 21880, 21966);

                        XmlException
                        e = f_10069_21897_21965(formattedXml)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 21984, 22406) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 21984, 22406);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 22039, 22061);

                            haveParseError = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 22083, 22387) || true) && (reportDiagnosticsForCurrentTrivia)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 22083, 22387);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 22170, 22263);

                                Location
                                location = f_10069_22190_22262(f_10069_22209_22226(trivia), f_10069_22228_22261(f_10069_22241_22257(trivia), 0))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 22289, 22364);

                                f_10069_22289_22363(_diagnostics, ErrorCode.WRN_XMLParseError, location, f_10069_22345_22362(e));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 22083, 22387);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 21984, 22406);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 22555, 22823) || true) && (!isPartialMethodDefinitionPart || (DynAbs.Tracing.TraceSender.Expression_False(10069, 22559, 22609) || _processIncludes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 22555, 22823);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 22784, 22804);

                            f_10069_22784_22803(this, formattedXml);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 22555, 22823);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 19974, 22838);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 2865);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 2865);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 22854, 23073) || true) && (!processedDocComment)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 22854, 23073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 22912, 22943);

                    withUnprocessedIncludes = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 22961, 23025);

                    includeElementNodes = default(ImmutableArray<CSharpSyntaxNode>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23045, 23058);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 22854, 23073);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23089, 23244) || true) && (!isPartialMethodDefinitionPart || (DynAbs.Tracing.TraceSender.Expression_False(10069, 23093, 23143) || _processIncludes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 23089, 23244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23177, 23188);

                    f_10069_23177_23187(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23206, 23229);

                    f_10069_23206_23228(this, "</member>");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 23089, 23244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23291, 23344);

                withUnprocessedIncludes = f_10069_23317_23343(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23422, 23555);

                includeElementNodes = (DynAbs.Tracing.TraceSender.Conditional_F1(10069, 23444, 23460) || ((_processIncludes && DynAbs.Tracing.TraceSender.Conditional_F2(10069, 23463, 23510)) || DynAbs.Tracing.TraceSender.Conditional_F3(10069, 23513, 23554))) ? f_10069_23463_23510(includeElementNodesBuilder) : default(ImmutableArray<CSharpSyntaxNode>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23571, 23583);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 18655, 23594);

                bool
                f_10069_19259_19292_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 19259, 19292);
                    return return_v;
                }


                int
                f_10069_19246_19293(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 19246, 19293);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10069_20186_20203(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 20186, 20203);
                    return return_v;
                }


                bool
                f_10069_20186_20243(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = tree.ReportDocumentationCommentDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 20186, 20243);
                    return return_v;
                }


                int
                f_10069_20458_20480(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    this_param.BeginTemporaryString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 20458, 20480);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                f_10069_20604_20648()
                {
                    var return_v = ArrayBuilder<CSharpSyntaxNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 20604, 20648);
                    return return_v;
                }


                string
                f_10069_21008_21042(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetDocumentationCommentId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 21008, 21042);
                    return return_v;
                }


                int
                f_10069_20973_21043(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                format, params object[]
                args)
                {
                    this_param.WriteLine(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 20973, 21043);
                    return 0;
                }


                int
                f_10069_21070_21078(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    this_param.Indent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 21070, 21078);
                    return 0;
                }


                string
                f_10069_21273_21467(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                trivia, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>?
                includeElementNodes, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>?
                documentedParameters, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                documentedTypeParameters)
                {
                    var return_v = DocumentationCommentWalker.GetSubstitutedText(compilation, diagnostics, symbol, trivia, includeElementNodes, ref documentedParameters, ref documentedTypeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 21273, 21467);
                    return return_v;
                }


                string
                f_10069_21510_21540(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                substitutedText)
                {
                    var return_v = this_param.FormatComment(substitutedText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 21510, 21540);
                    return return_v;
                }


                System.Xml.XmlException
                f_10069_21897_21965(string
                text)
                {
                    var return_v = XmlDocumentationCommentTextReader.ParseAndGetException(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 21897, 21965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10069_22209_22226(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 22209, 22226);
                    return return_v;
                }


                int
                f_10069_22241_22257(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 22241, 22257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10069_22228_22261(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 22228, 22261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10069_22190_22262(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 22190, 22262);
                    return return_v;
                }


                string
                f_10069_22345_22362(System.Xml.XmlException
                e)
                {
                    var return_v = GetDescription(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 22345, 22362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_22289_22363(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 22289, 22363);
                    return return_v;
                }


                int
                f_10069_22784_22803(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                indentedAndWrappedString)
                {
                    this_param.Write(indentedAndWrappedString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 22784, 22803);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                f_10069_20026_20041_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 20026, 20041);
                    return return_v;
                }


                int
                f_10069_23177_23187(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    this_param.Unindent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 23177, 23187);
                    return 0;
                }


                int
                f_10069_23206_23228(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 23206, 23228);
                    return 0;
                }


                string
                f_10069_23317_23343(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    var return_v = this_param.GetAndEndTemporaryString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 23317, 23343);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                f_10069_23463_23510(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>?
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 23463, 23510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 18655, 23594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 18655, 23594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Location GetLocationInTreeReportingDocumentationCommentDiagnostics(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 23606, 23999);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23727, 23962);
                    foreach (Location location in f_10069_23757_23773_I(f_10069_23757_23773(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 23727, 23962);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23807, 23947) || true) && (f_10069_23811_23870(f_10069_23811_23830(location)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 23807, 23947);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23912, 23928);

                            return location;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 23807, 23947);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 23727, 23962);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 23976, 23988);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 23606, 23999);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10069_23757_23773(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 23757, 23773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10069_23811_23830(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 23811, 23830);
                    return return_v;
                }


                bool
                f_10069_23811_23870(Microsoft.CodeAnalysis.SyntaxTree?
                tree)
                {
                    var return_v = tree.ReportDocumentationCommentDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 23811, 23870);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10069_23757_23773_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 23757, 23773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 23606, 23999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 23606, 23999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<ParameterSymbol> GetParameters(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 24192, 24923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 24292, 24851);

                switch (f_10069_24300_24311(symbol))
                {

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 24292, 24851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 24393, 24470);

                        MethodSymbol
                        delegateInvoke = f_10069_24423_24469(((NamedTypeSymbol)symbol))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 24492, 24632) || true) && ((object)delegateInvoke != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 24492, 24632);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 24576, 24609);

                            return f_10069_24583_24608(delegateInvoke);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 24492, 24632);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10069, 24654, 24660);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 24292, 24851);

                    case SymbolKind.Method:
                    case SymbolKind.Property:
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 24292, 24851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 24806, 24836);

                        return f_10069_24813_24835(symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 24292, 24851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 24867, 24912);

                return ImmutableArray<ParameterSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 24192, 24923);

                Microsoft.CodeAnalysis.SymbolKind
                f_10069_24300_24311(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 24300, 24311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10069_24423_24469(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 24423, 24469);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10069_24583_24608(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 24583, 24608);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10069_24813_24835(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 24813, 24835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 24192, 24923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 24192, 24923);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<TypeParameterSymbol> GetTypeParameters(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 25091, 25516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 25199, 25440);

                switch (f_10069_25207_25218(symbol))
                {

                    case SymbolKind.Method:
                    case SymbolKind.NamedType:
                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 25199, 25440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 25385, 25425);

                        return f_10069_25392_25424(symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 25199, 25440);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 25456, 25505);

                return ImmutableArray<TypeParameterSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 25091, 25516);

                Microsoft.CodeAnalysis.SymbolKind
                f_10069_25207_25218(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 25207, 25218);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10069_25392_25424(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberTypeParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 25392, 25424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 25091, 25516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 25091, 25516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool RequiresDocumentationComment(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 25816, 26567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 25904, 25941);

                f_10069_25904_25940((object)symbol != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 25957, 26041) || true) && (f_10069_25961_25979(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 25957, 26041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 26013, 26026);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 25957, 26041);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 26057, 26528) || true) && ((object)symbol != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 26057, 26528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 26120, 26513);

                        switch (f_10069_26128_26156(symbol))
                        {

                            case Accessibility.Public:
                            case Accessibility.Protected:
                            case Accessibility.ProtectedOrInternal:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 26120, 26513);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 26362, 26393);

                                symbol = f_10069_26371_26392(symbol);
                                DynAbs.Tracing.TraceSender.TraceBreak(10069, 26419, 26425);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 26120, 26513);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 26120, 26513);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 26481, 26494);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 26120, 26513);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 26057, 26528);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 26057, 26528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 26057, 26528);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 26544, 26556);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 25816, 26567);

                int
                f_10069_25904_25940(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 25904, 25940);
                    return 0;
                }


                bool
                f_10069_25961_25979(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = ShouldSkip(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 25961, 25979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10069_26128_26156(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 26128, 26156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10069_26371_26392(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 26371, 26392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 25816, 26567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 25816, 26567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetDocumentationCommentNodes(Symbol symbol, out DocumentationMode maxDocumentationMode, out ImmutableArray<DocumentationCommentTriviaSyntax> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 26900, 28802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 27088, 27134);

                maxDocumentationMode = DocumentationMode.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 27148, 27214);

                nodes = default(ImmutableArray<DocumentationCommentTriviaSyntax>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 27230, 27292);

                ArrayBuilder<DocumentationCommentTriviaSyntax>
                builder = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 27308, 28472);
                    foreach (SyntaxReference reference in f_10069_27346_27378_I(f_10069_27346_27378(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 27308, 28472);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 27412, 27501);

                        DocumentationMode
                        currDocumentationMode = f_10069_27454_27500(f_10069_27454_27482(f_10069_27454_27474(reference)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 27519, 27634);

                        maxDocumentationMode = (DynAbs.Tracing.TraceSender.Conditional_F1(10069, 27542, 27586) || ((currDocumentationMode > maxDocumentationMode && DynAbs.Tracing.TraceSender.Conditional_F2(10069, 27589, 27610)) || DynAbs.Tracing.TraceSender.Conditional_F3(10069, 27613, 27633))) ? currDocumentationMode : maxDocumentationMode;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 27654, 27847);

                        ImmutableArray<DocumentationCommentTriviaSyntax>
                        triviaList = f_10069_27716_27846(f_10069_27810_27831(reference), _diagnostics)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 27865, 28457);
                            foreach (var trivia in f_10069_27888_27898_I(triviaList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 27865, 28457);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 27940, 28209) || true) && (f_10069_27944_27978(trivia))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 27940, 28209);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28028, 28147) || true) && (builder != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 28028, 28147);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28105, 28120);

                                        f_10069_28105_28119(builder);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 28028, 28147);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28173, 28186);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 27940, 28209);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28233, 28396) || true) && (builder == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 28233, 28396);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28302, 28373);

                                    builder = f_10069_28312_28372();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 28233, 28396);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28418, 28438);

                                f_10069_28418_28437(builder, trivia);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 27865, 28457);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 593);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 593);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 27308, 28472);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 1165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 1165);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28488, 28763) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 28488, 28763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28541, 28604);

                    nodes = ImmutableArray<DocumentationCommentTriviaSyntax>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 28488, 28763);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 28488, 28763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28670, 28693);

                    f_10069_28670_28692(builder, f_10069_28683_28691());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28711, 28748);

                    nodes = f_10069_28719_28747(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 28488, 28763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28779, 28791);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 26900, 28802);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10069_27346_27378(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 27346, 27378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10069_27454_27474(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 27454, 27474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10069_27454_27482(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 27454, 27482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationMode
                f_10069_27454_27500(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.DocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 27454, 27500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10069_27810_27831(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 27810, 27831);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                f_10069_27716_27846(Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = SourceDocumentationCommentUtils.GetDocumentationCommentTriviaFromSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 27716, 27846);
                    return return_v;
                }


                bool
                f_10069_27944_27978(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                node)
                {
                    var return_v = ContainsXmlParseDiagnostic(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 27944, 27978);
                    return return_v;
                }


                int
                f_10069_28105_28119(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 28105, 28119);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                f_10069_28312_28372()
                {
                    var return_v = ArrayBuilder<DocumentationCommentTriviaSyntax>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 28312, 28372);
                    return return_v;
                }


                int
                f_10069_28418_28437(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 28418, 28437);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                f_10069_27888_27898_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 27888, 27898);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10069_27346_27378_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 27346, 27378);
                    return return_v;
                }


                System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                f_10069_28683_28691()
                {
                    var return_v = Comparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 28683, 28691);
                    return return_v;
                }


                int
                f_10069_28670_28692(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                this_param, System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 28670, 28692);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                f_10069_28719_28747(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 28719, 28747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 26900, 28802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 26900, 28802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ContainsXmlParseDiagnostic(DocumentationCommentTriviaSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 28814, 29297);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28924, 29015) || true) && (f_10069_28928_28953_M(!node.ContainsDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 28924, 29015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 28987, 29000);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 28924, 29015);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 29031, 29257);
                    foreach (Diagnostic diag in f_10069_29059_29080_I(f_10069_29059_29080(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 29031, 29257);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 29114, 29242) || true) && ((ErrorCode)f_10069_29129_29138(diag) == ErrorCode.WRN_XMLParseError)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 29114, 29242);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 29211, 29223);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 29114, 29242);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 29031, 29257);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 29273, 29286);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 28814, 29297);

                bool
                f_10069_28928_28953_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 28928, 28953);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10069_29059_29080(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 29059, 29080);
                    return return_v;
                }


                int
                f_10069_29129_29138(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 29129, 29138);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10069_29059_29080_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 29059, 29080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 28814, 29297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 28814, 29297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly string[] s_newLineSequences;

        private string FormatComment(string substitutedText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 29609, 30610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 29686, 29709);

                f_10069_29686_29708(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 29725, 30549) || true) && (f_10069_29729_29776(substitutedText, "///"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 29725, 30549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 29915, 29964);

                    f_10069_29915_29963(this, substitutedText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 29725, 30549);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 29725, 30549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 30030, 30114);

                    string[]
                    lines = f_10069_30047_30113(substitutedText, s_newLineSequences, StringSplitOptions.None)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 30134, 30162);

                    int
                    numLines = f_10069_30149_30161(lines)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 30180, 30207);

                    f_10069_30180_30206(numLines > 0);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 30227, 30393) || true) && (f_10069_30231_30272(lines[numLines - 1]))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 30227, 30393);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 30314, 30325);

                        numLines--;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 30347, 30374);

                        f_10069_30347_30373(numLines > 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 30227, 30393);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 30413, 30468);

                    f_10069_30413_30467(f_10069_30426_30466(lines[0], "/**"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 30486, 30534);

                    f_10069_30486_30533(this, lines, numLines);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 29725, 30549);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 30565, 30599);

                return f_10069_30572_30598(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 29609, 30610);

                int
                f_10069_29686_29708(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    this_param.BeginTemporaryString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 29686, 29708);
                    return 0;
                }


                bool
                f_10069_29729_29776(string
                str, string
                prefix)
                {
                    var return_v = TrimmedStringStartsWith(str, prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 29729, 29776);
                    return return_v;
                }


                int
                f_10069_29915_29963(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                text)
                {
                    this_param.WriteFormattedSingleLineComment(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 29915, 29963);
                    return 0;
                }


                string[]
                f_10069_30047_30113(string
                this_param, string[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 30047, 30113);
                    return return_v;
                }


                int
                f_10069_30149_30161(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 30149, 30161);
                    return return_v;
                }


                int
                f_10069_30180_30206(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 30180, 30206);
                    return 0;
                }


                bool
                f_10069_30231_30272(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 30231, 30272);
                    return return_v;
                }


                int
                f_10069_30347_30373(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 30347, 30373);
                    return 0;
                }


                bool
                f_10069_30426_30466(string
                str, string
                prefix)
                {
                    var return_v = TrimmedStringStartsWith(str, prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 30426, 30466);
                    return return_v;
                }


                int
                f_10069_30413_30467(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 30413, 30467);
                    return 0;
                }


                int
                f_10069_30486_30533(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string[]
                lines, int
                numLines)
                {
                    this_param.WriteFormattedMultiLineComment(lines, numLines);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 30486, 30533);
                    return 0;
                }


                string
                f_10069_30572_30598(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param)
                {
                    var return_v = this_param.GetAndEndTemporaryString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 30572, 30598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 29609, 30610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 29609, 30610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetIndexOfFirstNonWhitespaceChar(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 30896, 31055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 30984, 31044);

                return f_10069_30991_31043(str, 0, f_10069_31032_31042(str));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 30896, 31055);

                int
                f_10069_31032_31042(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 31032, 31042);
                    return return_v;
                }


                int
                f_10069_30991_31043(string
                str, int
                start, int
                end)
                {
                    var return_v = GetIndexOfFirstNonWhitespaceChar(str, start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 30991, 31043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 30896, 31055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 30896, 31055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetIndexOfFirstNonWhitespaceChar(string str, int start, int end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 31522, 32067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 31630, 31655);

                f_10069_31630_31654(start >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 31669, 31703);

                f_10069_31669_31702(start <= f_10069_31691_31701(str));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 31717, 31740);

                f_10069_31717_31739(end >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 31754, 31786);

                f_10069_31754_31785(end <= f_10069_31774_31784(str));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 31800, 31827);

                f_10069_31800_31826(end >= start);
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 31843, 32027) || true) && (start < end)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 31863, 31870)
        , start++, DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 31843, 32027))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 31843, 32027);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 31904, 32012) || true) && (!f_10069_31909_31945(f_10069_31934_31944(str, start)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 31904, 32012);
                            DynAbs.Tracing.TraceSender.TraceBreak(10069, 31987, 31993);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 31904, 32012);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 32043, 32056);

                return start;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 31522, 32067);

                int
                f_10069_31630_31654(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 31630, 31654);
                    return 0;
                }


                int
                f_10069_31691_31701(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 31691, 31701);
                    return return_v;
                }


                int
                f_10069_31669_31702(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 31669, 31702);
                    return 0;
                }


                int
                f_10069_31717_31739(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 31717, 31739);
                    return 0;
                }


                int
                f_10069_31774_31784(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 31774, 31784);
                    return return_v;
                }


                int
                f_10069_31754_31785(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 31754, 31785);
                    return 0;
                }


                int
                f_10069_31800_31826(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 31800, 31826);
                    return 0;
                }


                char
                f_10069_31934_31944(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 31934, 31944);
                    return return_v;
                }


                bool
                f_10069_31909_31945(char
                ch)
                {
                    var return_v = SyntaxFacts.IsWhitespace(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 31909, 31945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 31522, 32067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 31522, 32067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TrimmedStringStartsWith(string str, string prefix)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 32450, 33073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 32634, 32684);

                int
                start = f_10069_32646_32683(str)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 32698, 32727);

                int
                len = f_10069_32708_32718(str) - start
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 32741, 32826) || true) && (len < f_10069_32751_32764(prefix))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 32741, 32826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 32798, 32811);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 32741, 32826);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 32851, 32856);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 32842, 33034) || true) && (i < f_10069_32862_32875(prefix))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 32877, 32880)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 32842, 33034))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 32842, 33034);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 32914, 33019) || true) && (f_10069_32918_32927(prefix, i) != f_10069_32931_32945(str, i + start))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 32914, 33019);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 32987, 33000);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 32914, 33019);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 33050, 33062);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 32450, 33073);

                int
                f_10069_32646_32683(string
                str)
                {
                    var return_v = GetIndexOfFirstNonWhitespaceChar(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 32646, 32683);
                    return return_v;
                }


                int
                f_10069_32708_32718(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 32708, 32718);
                    return return_v;
                }


                int
                f_10069_32751_32764(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 32751, 32764);
                    return return_v;
                }


                int
                f_10069_32862_32875(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 32862, 32875);
                    return return_v;
                }


                char
                f_10069_32918_32927(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 32918, 32927);
                    return return_v;
                }


                char
                f_10069_32931_32945(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 32931, 32945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 32450, 33073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 32450, 33073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int IndexOfNewLine(string str, int start, out int newLineLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 33709, 34528);
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 33813, 34456) || true) && (start < f_10069_33828_33838(str))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 33840, 33847)
   , start++, DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 33813, 34456))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 33813, 34456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 33881, 34441);

                        switch (f_10069_33889_33899(str, start))
                        {

                            case '\r':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 33881, 34441);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 33977, 34266) || true) && ((start + 1) < f_10069_33995_34005(str) && (DynAbs.Tracing.TraceSender.Expression_True(10069, 33981, 34031) && f_10069_34009_34023(str, start + 1) == '\n'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 33977, 34266);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 34089, 34107);

                                    newLineLength = 2;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 33977, 34266);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 33977, 34266);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 34221, 34239);

                                    newLineLength = 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 33977, 34266);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 34292, 34305);

                                return start;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 33881, 34441);

                            case '\n':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 33881, 34441);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 34365, 34383);

                                newLineLength = 1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 34409, 34422);

                                return start;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 33881, 34441);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 34472, 34490);

                newLineLength = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 34504, 34517);

                return start;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 33709, 34528);

                int
                f_10069_33828_33838(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 33828, 33838);
                    return return_v;
                }


                char
                f_10069_33889_33899(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 33889, 33899);
                    return return_v;
                }


                int
                f_10069_33995_34005(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 33995, 34005);
                    return return_v;
                }


                char
                f_10069_34009_34023(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 34009, 34023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 33709, 34528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 33709, 34528);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteFormattedSingleLineComment(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 34768, 36028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 34944, 34966);

                bool
                skipSpace = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 34989, 34998);
                    for (int
        start = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 34980, 35545) || true) && (start < f_10069_35008_35019(text))
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 34980, 35545))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 34980, 35545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35054, 35072);

                        int
                        newLineLength
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35090, 35147);

                        int
                        end = f_10069_35100_35146(text, start, out newLineLength)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35165, 35232);

                        int
                        trimStart = f_10069_35181_35231(text, start, end)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35250, 35286);

                        int
                        trimmedLength = end - trimStart
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35304, 35482) || true) && (trimmedLength < 4 || (DynAbs.Tracing.TraceSender.Expression_False(10069, 35308, 35375) || !f_10069_35330_35375(f_10069_35355_35374(text, trimStart + 3))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 35304, 35482);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35417, 35435);

                            skipSpace = false;
                            DynAbs.Tracing.TraceSender.TraceBreak(10069, 35457, 35463);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 35304, 35482);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35502, 35530);

                        start = end + newLineLength;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 566);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35561, 35600);

                int
                substringStart = (DynAbs.Tracing.TraceSender.Conditional_F1(10069, 35582, 35591) || ((skipSpace && DynAbs.Tracing.TraceSender.Conditional_F2(10069, 35594, 35595)) || DynAbs.Tracing.TraceSender.Conditional_F3(10069, 35598, 35599))) ? 4 : 3
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35625, 35634);

                    for (int
        start = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35616, 36017) || true) && (start < f_10069_35644_35655(text))
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 35616, 36017))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 35616, 36017);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35690, 35708);

                        int
                        newLineLength
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35726, 35783);

                        int
                        end = f_10069_35736_35782(text, start, out newLineLength)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35801, 35885);

                        int
                        trimStart = f_10069_35817_35867(text, start, end) + substringStart
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35903, 35956);

                        f_10069_35903_35955(this, text, trimStart, end - trimStart);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 35974, 36002);

                        start = end + newLineLength;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 402);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 34768, 36028);

                int
                f_10069_35008_35019(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 35008, 35019);
                    return return_v;
                }


                int
                f_10069_35100_35146(string
                str, int
                start, out int
                newLineLength)
                {
                    var return_v = IndexOfNewLine(str, start, out newLineLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 35100, 35146);
                    return return_v;
                }


                int
                f_10069_35181_35231(string
                str, int
                start, int
                end)
                {
                    var return_v = GetIndexOfFirstNonWhitespaceChar(str, start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 35181, 35231);
                    return return_v;
                }


                char
                f_10069_35355_35374(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 35355, 35374);
                    return return_v;
                }


                bool
                f_10069_35330_35375(char
                ch)
                {
                    var return_v = SyntaxFacts.IsWhitespace(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 35330, 35375);
                    return return_v;
                }


                int
                f_10069_35644_35655(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 35644, 35655);
                    return return_v;
                }


                int
                f_10069_35736_35782(string
                str, int
                start, out int
                newLineLength)
                {
                    var return_v = IndexOfNewLine(str, start, out newLineLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 35736, 35782);
                    return return_v;
                }


                int
                f_10069_35817_35867(string
                str, int
                start, int
                end)
                {
                    var return_v = GetIndexOfFirstNonWhitespaceChar(str, start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 35817, 35867);
                    return return_v;
                }


                int
                f_10069_35903_35955(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message, int
                start, int
                length)
                {
                    this_param.WriteSubStringLine(message, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 35903, 35955);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 34768, 36028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 34768, 36028);
            }
        }

        private void WriteFormattedMultiLineComment(string[] lines, int numLines)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 36280, 38442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36378, 36424);

                bool
                skipFirstLine = f_10069_36399_36414(lines[0]) == "/**"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36438, 36493);

                bool
                skipLastLine = f_10069_36458_36484(lines[numLines - 1]) == "*/"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36509, 36630) || true) && (skipLastLine)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 36509, 36630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36559, 36570);

                    numLines--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36588, 36615);

                    f_10069_36588_36614(numLines > 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 36509, 36630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36646, 36665);

                int
                skipLength = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36679, 37627) || true) && (numLines > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 36679, 37627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36729, 36784);

                    string
                    pattern = f_10069_36746_36783(lines[1])
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36804, 37612) || true) && (pattern != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 36804, 37612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36865, 36886);

                        bool
                        allMatch = true
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36919, 36924);

                            for (int
        i = 2
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36910, 37456) || true) && (i < numLines)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36940, 36943)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 36910, 37456))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 36910, 37456);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 36993, 37060);

                                string
                                currentLinePattern = f_10069_37021_37059(pattern, lines[i])
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37086, 37273) || true) && (f_10069_37090_37135(currentLinePattern))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 37086, 37273);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37193, 37210);

                                    allMatch = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10069, 37240, 37246);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 37086, 37273);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37299, 37378);

                                f_10069_37299_37377(f_10069_37312_37376(pattern, currentLinePattern, StringComparison.Ordinal));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37404, 37433);

                                pattern = currentLinePattern;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 547);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 547);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37480, 37593) || true) && (allMatch)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 37480, 37593);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37542, 37570);

                            skipLength = f_10069_37555_37569(pattern);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 37480, 37593);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 36804, 37612);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 36679, 37627);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37643, 38003) || true) && (!skipFirstLine)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 37643, 38003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37695, 37737);

                    string
                    trimmed = f_10069_37712_37736(lines[0], null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37755, 37895) || true) && (!skipLastLine && (DynAbs.Tracing.TraceSender.Expression_True(10069, 37759, 37789) && numLines == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 37755, 37895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37831, 37876);

                        trimmed = f_10069_37841_37875(trimmed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 37755, 37895);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 37913, 37988);

                    f_10069_37913_37987(this, f_10069_37923_37986(trimmed, (DynAbs.Tracing.TraceSender.Conditional_F1(10069, 37941, 37977) || ((f_10069_37941_37977(f_10069_37966_37976(trimmed, 3)) && DynAbs.Tracing.TraceSender.Conditional_F2(10069, 37980, 37981)) || DynAbs.Tracing.TraceSender.Conditional_F3(10069, 37984, 37985))) ? 4 : 3));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 37643, 38003);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38028, 38033);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38019, 38431) || true) && (i < numLines)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38049, 38052)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 38019, 38431))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 38019, 38431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38086, 38134);

                        string
                        trimmed = f_10069_38103_38133(lines[i], skipLength)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38233, 38377) || true) && (!skipLastLine && (DynAbs.Tracing.TraceSender.Expression_True(10069, 38237, 38271) && i == numLines - 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 38233, 38377);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38313, 38358);

                            trimmed = f_10069_38323_38357(trimmed);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 38233, 38377);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38397, 38416);

                        f_10069_38397_38415(this, trimmed);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 413);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 36280, 38442);

                string
                f_10069_36399_36414(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 36399, 36414);
                    return return_v;
                }


                string
                f_10069_36458_36484(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 36458, 36484);
                    return return_v;
                }


                int
                f_10069_36588_36614(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 36588, 36614);
                    return 0;
                }


                string
                f_10069_36746_36783(string
                line)
                {
                    var return_v = FindMultiLineCommentPattern(line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 36746, 36783);
                    return return_v;
                }


                string
                f_10069_37021_37059(string
                str1, string
                str2)
                {
                    var return_v = LongestCommonPrefix(str1, str2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 37021, 37059);
                    return return_v;
                }


                bool
                f_10069_37090_37135(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 37090, 37135);
                    return return_v;
                }


                bool
                f_10069_37312_37376(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 37312, 37376);
                    return return_v;
                }


                int
                f_10069_37299_37377(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 37299, 37377);
                    return 0;
                }


                int
                f_10069_37555_37569(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 37555, 37569);
                    return return_v;
                }


                string
                f_10069_37712_37736(string
                this_param, params char[]?
                trimChars)
                {
                    var return_v = this_param.TrimStart(trimChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 37712, 37736);
                    return return_v;
                }


                string
                f_10069_37841_37875(string
                trimmed)
                {
                    var return_v = TrimEndOfMultiLineComment(trimmed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 37841, 37875);
                    return return_v;
                }


                char
                f_10069_37966_37976(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 37966, 37976);
                    return return_v;
                }


                bool
                f_10069_37941_37977(char
                ch)
                {
                    var return_v = SyntaxFacts.IsWhitespace(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 37941, 37977);
                    return return_v;
                }


                string
                f_10069_37923_37986(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 37923, 37986);
                    return return_v;
                }


                int
                f_10069_37913_37987(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 37913, 37987);
                    return 0;
                }


                string
                f_10069_38103_38133(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 38103, 38133);
                    return return_v;
                }


                string
                f_10069_38323_38357(string
                trimmed)
                {
                    var return_v = TrimEndOfMultiLineComment(trimmed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 38323, 38357);
                    return return_v;
                }


                int
                f_10069_38397_38415(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 38397, 38415);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 36280, 38442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 36280, 38442);
            }
        }

        private static string TrimEndOfMultiLineComment(string trimmed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 38568, 38871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38656, 38716);

                int
                index = f_10069_38668_38715(trimmed, "*/", StringComparison.Ordinal)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38730, 38831) || true) && (index >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 38730, 38831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38778, 38816);

                    trimmed = f_10069_38788_38815(trimmed, 0, index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 38730, 38831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 38845, 38860);

                return trimmed;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 38568, 38871);

                int
                f_10069_38668_38715(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 38668, 38715);
                    return return_v;
                }


                string
                f_10069_38788_38815(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 38788, 38815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 38568, 38871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 38568, 38871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string FindMultiLineCommentPattern(string line)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 39009, 39661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39096, 39111);

                int
                length = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39127, 39149);

                bool
                seenStar = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39163, 39583);
                    foreach (char ch in f_10069_39183_39187_I(line))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 39163, 39583);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39221, 39568) || true) && (f_10069_39225_39253(ch))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 39221, 39568);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39295, 39304);

                            length++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 39221, 39568);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 39221, 39568);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39346, 39568) || true) && (!seenStar && (DynAbs.Tracing.TraceSender.Expression_True(10069, 39350, 39372) && ch == '*'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 39346, 39568);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39414, 39423);

                                length++;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39445, 39461);

                                seenStar = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 39346, 39568);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 39346, 39568);
                                DynAbs.Tracing.TraceSender.TraceBreak(10069, 39543, 39549);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 39346, 39568);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 39221, 39568);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 39163, 39583);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39599, 39650);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10069, 39606, 39614) || ((seenStar && DynAbs.Tracing.TraceSender.Conditional_F2(10069, 39617, 39642)) || DynAbs.Tracing.TraceSender.Conditional_F3(10069, 39645, 39649))) ? f_10069_39617_39642(line, 0, length) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 39009, 39661);

                bool
                f_10069_39225_39253(char
                ch)
                {
                    var return_v = SyntaxFacts.IsWhitespace(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 39225, 39253);
                    return return_v;
                }


                string
                f_10069_39183_39187_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 39183, 39187);
                    return return_v;
                }


                string
                f_10069_39617_39642(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 39617, 39642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 39009, 39661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 39009, 39661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string LongestCommonPrefix(string str1, string str2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 39781, 40109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39873, 39885);

                int
                pos = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39899, 39950);

                int
                minLength = f_10069_39915_39949(f_10069_39924_39935(str1), f_10069_39937_39948(str2))
                ;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 39966, 40052) || true) && (pos < minLength && (DynAbs.Tracing.TraceSender.Expression_True(10069, 39973, 40014) && f_10069_39992_40001(str1, pos) == f_10069_40005_40014(str2, pos)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 40016, 40021)
        , pos++, DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 39966, 40052))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 39966, 40052);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 87);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 87);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 40068, 40098);

                return f_10069_40075_40097(str1, 0, pos);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 39781, 40109);

                int
                f_10069_39924_39935(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 39924, 39935);
                    return return_v;
                }


                int
                f_10069_39937_39948(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 39937, 39948);
                    return return_v;
                }


                int
                f_10069_39915_39949(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 39915, 39949);
                    return return_v;
                }


                char
                f_10069_39992_40001(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 39992, 40001);
                    return return_v;
                }


                char
                f_10069_40005_40014(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 40005, 40014);
                    return return_v;
                }


                string
                f_10069_40075_40097(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 40075, 40097);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 39781, 40109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 39781, 40109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetDocumentationCommentId(CrefSyntax crefSyntax, Binder binder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 40390, 41487);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 40527, 40645) || true) && (f_10069_40531_40561(crefSyntax))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 40527, 40645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 40595, 40630);

                    return f_10069_40602_40629(crefSyntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 40527, 40645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 40661, 40684);

                Symbol
                ambiguityWinner
                = default(Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 40698, 40793);

                ImmutableArray<Symbol>
                symbols = f_10069_40731_40792(binder, crefSyntax, out ambiguityWinner, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 40809, 40823);

                Symbol
                symbol
                = default(Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 40837, 41227);

                switch (symbols.Length)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 40837, 41227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 40922, 40957);

                        return f_10069_40929_40956(crefSyntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 40837, 41227);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 40837, 41227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 41004, 41024);

                        symbol = symbols[0];
                        DynAbs.Tracing.TraceSender.TraceBreak(10069, 41046, 41052);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 40837, 41227);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 40837, 41227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 41100, 41125);

                        symbol = ambiguityWinner;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 41147, 41184);

                        f_10069_41147_41183((object)symbol != null);
                        DynAbs.Tracing.TraceSender.TraceBreak(10069, 41206, 41212);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 40837, 41227);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 41243, 41399) || true) && (f_10069_41247_41258(symbol) == SymbolKind.Alias)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 41243, 41399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 41312, 41384);

                    symbol = f_10069_41321_41383(((AliasSymbol)symbol), basesBeingResolved: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 41243, 41399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 41415, 41476);

                return f_10069_41422_41475(f_10069_41422_41447(symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 40390, 41487);

                bool
                f_10069_40531_40561(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 40531, 40561);
                    return return_v;
                }


                string
                f_10069_40602_40629(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                cref)
                {
                    var return_v = ToBadCrefString(cref);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 40602, 40629);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10069_40731_40792(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                syntax, out Microsoft.CodeAnalysis.CSharp.Symbol
                ambiguityWinner, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindCref(syntax, out ambiguityWinner, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 40731, 40792);
                    return return_v;
                }


                string
                f_10069_40929_40956(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                cref)
                {
                    var return_v = ToBadCrefString(cref);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 40929, 40956);
                    return return_v;
                }


                int
                f_10069_41147_41183(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 41147, 41183);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10069_41247_41258(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 41247, 41258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10069_41321_41383(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetAliasTarget(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 41321, 41383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10069_41422_41447(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 41422, 41447);
                    return return_v;
                }


                string
                f_10069_41422_41475(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetDocumentationCommentId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 41422, 41475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 40390, 41487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 40390, 41487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ToBadCrefString(CrefSyntax cref)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 41719, 42037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 41798, 42026);
                using (StringWriter
                tmp = f_10069_41824_41870(f_10069_41841_41869())
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 41904, 41922);

                    f_10069_41904_41921(cref, tmp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 41940, 42011);

                    return "!:" + f_10069_41954_42010(f_10069_41954_41989(f_10069_41954_41968(tmp), "{", "&lt;"), "}", "&gt;");
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10069, 41798, 42026);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 41719, 42037);

                System.Globalization.CultureInfo
                f_10069_41841_41869()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 41841, 41869);
                    return return_v;
                }


                System.IO.StringWriter
                f_10069_41824_41870(System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = new System.IO.StringWriter((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 41824, 41870);
                    return return_v;
                }


                int
                f_10069_41904_41921(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param, System.IO.StringWriter
                writer)
                {
                    this_param.WriteTo((System.IO.TextWriter)writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 41904, 41921);
                    return 0;
                }


                string
                f_10069_41954_41968(System.IO.StringWriter
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 41954, 41968);
                    return return_v;
                }


                string
                f_10069_41954_41989(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 41954, 41989);
                    return return_v;
                }


                string
                f_10069_41954_42010(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 41954, 42010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 41719, 42037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 41719, 42037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void BindName(
                    XmlNameAttributeSyntax syntax,
                    Binder binder,
                    Symbol memberSymbol,
                    ref HashSet<ParameterSymbol> documentedParameters,
                    ref HashSet<TypeParameterSymbol> documentedTypeParameters,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 42349, 46800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 42685, 42751);

                XmlNameAttributeElementKind
                elementKind = f_10069_42727_42750(syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 42995, 43534) || true) && (elementKind == XmlNameAttributeElementKind.Parameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 42995, 43534);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43085, 43232) || true) && (documentedParameters == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 43085, 43232);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43159, 43213);

                        documentedParameters = f_10069_43182_43212();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 43085, 43232);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 42995, 43534);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 42995, 43534);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43266, 43534) || true) && (elementKind == XmlNameAttributeElementKind.TypeParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 43266, 43534);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43360, 43519) || true) && (documentedTypeParameters == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 43360, 43519);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43438, 43500);

                            documentedTypeParameters = f_10069_43465_43499();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 43360, 43519);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 43266, 43534);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 42995, 43534);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43550, 43602);

                IdentifierNameSyntax
                identifier = f_10069_43584_43601(syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43618, 43708) || true) && (f_10069_43622_43652(identifier))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 43618, 43708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43686, 43693);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 43618, 43708);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43724, 43774);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43788, 43891);

                ImmutableArray<Symbol>
                referencedSymbols = f_10069_43831_43890(binder, syntax, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43905, 43949);

                f_10069_43905_43948(diagnostics, syntax, useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 43965, 46789) || true) && (referencedSymbols.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 43965, 46789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 44028, 45084);

                    switch (elementKind)
                    {

                        case XmlNameAttributeElementKind.Parameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 44028, 45084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 44158, 44240);

                            f_10069_44158_44239(diagnostics, ErrorCode.WRN_UnmatchedParamTag, f_10069_44207_44226(identifier), identifier);
                            DynAbs.Tracing.TraceSender.TraceBreak(10069, 44266, 44272);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 44028, 45084);

                        case XmlNameAttributeElementKind.ParameterReference:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 44028, 45084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 44372, 44471);

                            f_10069_44372_44470(diagnostics, ErrorCode.WRN_UnmatchedParamRefTag, f_10069_44424_44443(identifier), identifier, memberSymbol);
                            DynAbs.Tracing.TraceSender.TraceBreak(10069, 44497, 44503);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 44028, 45084);

                        case XmlNameAttributeElementKind.TypeParameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 44028, 45084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 44598, 44684);

                            f_10069_44598_44683(diagnostics, ErrorCode.WRN_UnmatchedTypeParamTag, f_10069_44651_44670(identifier), identifier);
                            DynAbs.Tracing.TraceSender.TraceBreak(10069, 44710, 44716);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 44028, 45084);

                        case XmlNameAttributeElementKind.TypeParameterReference:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 44028, 45084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 44820, 44923);

                            f_10069_44820_44922(diagnostics, ErrorCode.WRN_UnmatchedTypeParamRefTag, f_10069_44876_44895(identifier), identifier, memberSymbol);
                            DynAbs.Tracing.TraceSender.TraceBreak(10069, 44949, 44955);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 44028, 45084);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 44028, 45084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 45011, 45065);

                            throw f_10069_45017_45064(elementKind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 44028, 45084);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 43965, 46789);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 43965, 46789);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 45150, 46774);
                        foreach (Symbol referencedSymbol in f_10069_45186_45203_I(referencedSymbols))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 45150, 46774);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 45245, 46755) || true) && (elementKind == XmlNameAttributeElementKind.Parameter)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 45245, 46755);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 45351, 45411);

                                f_10069_45351_45410(f_10069_45364_45385(referencedSymbol) == SymbolKind.Parameter);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 45437, 45480);

                                f_10069_45437_45479(documentedParameters != null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 45833, 45895);

                                ParameterSymbol
                                parameter = (ParameterSymbol)referencedSymbol
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 45921, 46168) || true) && (!f_10069_45926_45965(f_10069_45926_45952(parameter)) && (DynAbs.Tracing.TraceSender.Expression_True(10069, 45925, 46005) && !f_10069_45970_46005(documentedParameters, parameter)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 45921, 46168);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 46063, 46141);

                                    f_10069_46063_46140(diagnostics, ErrorCode.WRN_DuplicateParamTag, f_10069_46112_46127(syntax), identifier);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 45921, 46168);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 45245, 46755);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 45245, 46755);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 46218, 46755) || true) && (elementKind == XmlNameAttributeElementKind.TypeParameter)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 46218, 46755);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 46328, 46392);

                                    f_10069_46328_46391(f_10069_46341_46362(referencedSymbol) == SymbolKind.TypeParameter);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 46418, 46465);

                                    f_10069_46418_46464(documentedTypeParameters != null);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 46493, 46732) || true) && (!f_10069_46498_46565(documentedTypeParameters, referencedSymbol))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 46493, 46732);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 46623, 46705);

                                        f_10069_46623_46704(diagnostics, ErrorCode.WRN_DuplicateTypeParamTag, f_10069_46676_46691(syntax), identifier);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 46493, 46732);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 46218, 46755);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 45245, 46755);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 45150, 46774);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 1625);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 1625);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 43965, 46789);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 42349, 46800);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeElementKind
                f_10069_42727_42750(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                attributeSyntax)
                {
                    var return_v = attributeSyntax.GetElementKind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 42727, 42750);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10069_43182_43212()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 43182, 43212);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10069_43465_43499()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 43465, 43499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10069_43584_43601(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 43584, 43601);
                    return return_v;
                }


                bool
                f_10069_43622_43652(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 43622, 43652);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10069_43831_43890(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                syntax, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.BindXmlNameAttribute(syntax, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 43831, 43890);
                    return return_v;
                }


                bool
                f_10069_43905_43948(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 43905, 43948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10069_44207_44226(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 44207, 44226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_44158_44239(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 44158, 44239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10069_44424_44443(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 44424, 44443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_44372_44470(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 44372, 44470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10069_44651_44670(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 44651, 44670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_44598_44683(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 44598, 44683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10069_44876_44895(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 44876, 44895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_44820_44922(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 44820, 44922);
                    return return_v;
                }


                System.Exception
                f_10069_45017_45064(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeElementKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 45017, 45064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10069_45364_45385(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 45364, 45385);
                    return return_v;
                }


                int
                f_10069_45351_45410(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 45351, 45410);
                    return 0;
                }


                int
                f_10069_45437_45479(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 45437, 45479);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10069_45926_45952(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 45926, 45952);
                    return return_v;
                }


                bool
                f_10069_45926_45965(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 45926, 45965);
                    return return_v;
                }


                bool
                f_10069_45970_46005(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 45970, 46005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10069_46112_46127(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 46112, 46127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_46063_46140(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 46063, 46140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10069_46341_46362(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 46341, 46362);
                    return return_v;
                }


                int
                f_10069_46328_46391(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 46328, 46391);
                    return 0;
                }


                int
                f_10069_46418_46464(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 46418, 46464);
                    return 0;
                }


                bool
                f_10069_46498_46565(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 46498, 46565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10069_46676_46691(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 46676, 46691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10069_46623_46704(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 46623, 46704);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10069_45186_45203_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 45186, 45203);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 42349, 46800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 42349, 46800);
            }
        }

        private IComparer<CSharpSyntaxNode> Comparer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 46881, 47118);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 46917, 47064) || true) && (_lazyComparer == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 46917, 47064);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 46984, 47045);

                        _lazyComparer = f_10069_47000_47044(_compilation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 46917, 47064);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 47082, 47103);

                    return _lazyComparer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 46881, 47118);

                    Microsoft.CodeAnalysis.SyntaxNodeLocationComparer
                    f_10069_47000_47044(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxNodeLocationComparer((Microsoft.CodeAnalysis.Compilation)compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 47000, 47044);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 46812, 47129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 46812, 47129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void BeginTemporaryString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 47141, 47448);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 47201, 47349) || true) && (_temporaryStringBuilders == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 47201, 47349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 47271, 47334);

                    _temporaryStringBuilders = f_10069_47298_47333();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 47201, 47349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 47365, 47437);

                f_10069_47365_47436(
                            _temporaryStringBuilders, f_10069_47395_47435(_indentDepth));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 47141, 47448);

                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder>
                f_10069_47298_47333()
                {
                    var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 47298, 47333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder
                f_10069_47395_47435(int
                indentDepth)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder(indentDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 47395, 47435);
                    return return_v;
                }


                int
                f_10069_47365_47436(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder>
                this_param, Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 47365, 47436);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 47141, 47448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 47141, 47448);
            }
        }

        private string GetAndEndTemporaryString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 47460, 47853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 47526, 47584);

                TemporaryStringBuilder
                t = f_10069_47553_47583(_temporaryStringBuilders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 47598, 47744);

                f_10069_47598_47743(_indentDepth == t.InitialIndentDepth, $"Temporary strings should be indent-neutral (was {t.InitialIndentDepth}, is {_indentDepth})");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 47758, 47794);

                _indentDepth = t.InitialIndentDepth;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 47808, 47842);

                return f_10069_47815_47841(t.Pooled);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 47460, 47853);

                Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder
                f_10069_47553_47583(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 47553, 47583);
                    return return_v;
                }


                int
                f_10069_47598_47743(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 47598, 47743);
                    return 0;
                }


                string
                f_10069_47815_47841(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 47815, 47841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 47460, 47853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 47460, 47853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Indent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 47865, 47937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 47911, 47926);

                _indentDepth++;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 47865, 47937);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 47865, 47937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 47865, 47937);
            }
        }

        private void Unindent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 47949, 48069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 47997, 48012);

                _indentDepth--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48026, 48058);

                f_10069_48026_48057(_indentDepth >= 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 47949, 48069);

                int
                f_10069_48026_48057(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 48026, 48057);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 47949, 48069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 47949, 48069);
            }
        }

        private void Write(string indentedAndWrappedString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 48081, 48548);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48157, 48537) || true) && (_temporaryStringBuilders != null && (DynAbs.Tracing.TraceSender.Expression_True(10069, 48161, 48231) && f_10069_48197_48227(_temporaryStringBuilders) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 48157, 48537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48265, 48336);

                    StringBuilder
                    builder = f_10069_48289_48320(_temporaryStringBuilders).Pooled.Builder
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48354, 48395);

                    f_10069_48354_48394(builder, indentedAndWrappedString);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 48157, 48537);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 48157, 48537);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48429, 48537) || true) && (_writer != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 48429, 48537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48482, 48522);

                        f_10069_48482_48521(_writer, indentedAndWrappedString);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 48429, 48537);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 48157, 48537);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 48081, 48548);

                int
                f_10069_48197_48227(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 48197, 48227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder
                f_10069_48289_48320(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 48289, 48320);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10069_48354_48394(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 48354, 48394);
                    return return_v;
                }


                int
                f_10069_48482_48521(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 48482, 48521);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 48081, 48548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 48081, 48548);
            }
        }

        private void WriteLine(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 48560, 49070);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48623, 49059) || true) && (f_10069_48627_48658_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_temporaryStringBuilders, 10069, 48627, 48658)?.Count) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 48623, 49059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48696, 48767);

                    StringBuilder
                    builder = f_10069_48720_48751(_temporaryStringBuilders).Pooled.Builder
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48785, 48826);

                    f_10069_48785_48825(builder, f_10069_48800_48824(_indentDepth));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48844, 48872);

                    f_10069_48844_48871(builder, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 48623, 49059);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 48623, 49059);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48906, 49059) || true) && (_writer != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 48906, 49059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 48959, 48999);

                        f_10069_48959_48998(_writer, f_10069_48973_48997(_indentDepth));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49017, 49044);

                        f_10069_49017_49043(_writer, message);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 48906, 49059);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 48623, 49059);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 48560, 49070);

                int?
                f_10069_48627_48658_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 48627, 48658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder
                f_10069_48720_48751(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 48720, 48751);
                    return return_v;
                }


                string
                f_10069_48800_48824(int
                depth)
                {
                    var return_v = MakeIndent(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 48800, 48824);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10069_48785_48825(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 48785, 48825);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10069_48844_48871(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 48844, 48871);
                    return return_v;
                }


                string
                f_10069_48973_48997(int
                depth)
                {
                    var return_v = MakeIndent(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 48973, 48997);
                    return return_v;
                }


                int
                f_10069_48959_48998(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 48959, 48998);
                    return 0;
                }


                int
                f_10069_49017_49043(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49017, 49043);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 48560, 49070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 48560, 49070);
            }
        }

        private void WriteSubStringLine(string message, int start, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 49082, 49811);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49177, 49800) || true) && (f_10069_49181_49212_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_temporaryStringBuilders, 10069, 49181, 49212)?.Count) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 49177, 49800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49250, 49321);

                    StringBuilder
                    builder = f_10069_49274_49305(_temporaryStringBuilders).Pooled.Builder
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49339, 49380);

                    f_10069_49339_49379(builder, f_10069_49354_49378(_indentDepth));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49398, 49437);

                    f_10069_49398_49436(builder, message, start, length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49455, 49476);

                    f_10069_49455_49475(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 49177, 49800);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 49177, 49800);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49510, 49800) || true) && (_writer != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 49510, 49800);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49563, 49603);

                        f_10069_49563_49602(_writer, f_10069_49577_49601(_indentDepth));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49630, 49635);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49621, 49747) || true) && (i < length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49649, 49652)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 49621, 49747))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 49621, 49747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49694, 49728);

                                f_10069_49694_49727(_writer, f_10069_49708_49726(message, start + i));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10069, 1, 127);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10069, 1, 127);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49765, 49785);

                        f_10069_49765_49784(_writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 49510, 49800);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 49177, 49800);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 49082, 49811);

                int?
                f_10069_49181_49212_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 49181, 49212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder
                f_10069_49274_49305(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler.TemporaryStringBuilder>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49274, 49305);
                    return return_v;
                }


                string
                f_10069_49354_49378(int
                depth)
                {
                    var return_v = MakeIndent(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49354, 49378);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10069_49339_49379(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49339, 49379);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10069_49398_49436(System.Text.StringBuilder
                this_param, string
                value, int
                startIndex, int
                count)
                {
                    var return_v = this_param.Append(value, startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49398, 49436);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10069_49455_49475(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49455, 49475);
                    return return_v;
                }


                string
                f_10069_49577_49601(int
                depth)
                {
                    var return_v = MakeIndent(depth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49577, 49601);
                    return return_v;
                }


                int
                f_10069_49563_49602(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49563, 49602);
                    return 0;
                }


                char
                f_10069_49708_49726(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 49708, 49726);
                    return return_v;
                }


                int
                f_10069_49694_49727(System.IO.TextWriter
                this_param, char
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49694, 49727);
                    return 0;
                }


                int
                f_10069_49765_49784(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49765, 49784);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 49082, 49811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 49082, 49811);
            }
        }

        private void WriteLine(string format, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10069, 49823, 49957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 49907, 49946);

                f_10069_49907_49945(this, f_10069_49917_49944(format, args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10069, 49823, 49957);

                string
                f_10069_49917_49944(string
                format, params object[]
                args)
                {
                    var return_v = string.Format(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49917, 49944);
                    return return_v;
                }


                int
                f_10069_49907_49945(Microsoft.CodeAnalysis.CSharp.DocumentationCommentCompiler
                this_param, string
                message)
                {
                    this_param.WriteLine(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 49907, 49945);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 49823, 49957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 49823, 49957);
            }
        }

        private static string MakeIndent(int depth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 49969, 50735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 50037, 50062);

                f_10069_50037_50061(depth >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 50255, 50724);

                switch (depth)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 50255, 50724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 50331, 50341);

                        return "";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 50255, 50724);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 50255, 50724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 50388, 50402);

                        return "    ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 50255, 50724);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 50255, 50724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 50449, 50467);

                        return "        ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 50255, 50724);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 50255, 50724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 50514, 50536);

                        return "            ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 50255, 50724);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10069, 50255, 50724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 50584, 50653);

                        f_10069_50584_50652(false, "Didn't expect nesting to reach depth " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (depth).ToString(), 10069, 50646, 50651));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 50675, 50709);

                        return f_10069_50682_50708(' ', depth * 4);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10069, 50255, 50724);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 49969, 50735);

                int
                f_10069_50037_50061(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 50037, 50061);
                    return 0;
                }


                int
                f_10069_50584_50652(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 50584, 50652);
                    return 0;
                }


                string
                f_10069_50682_50708(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 50682, 50708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 49969, 50735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 49969, 50735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetDescription(XmlException e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10069, 51901, 53138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 51978, 52005);

                string
                message = f_10069_51995_52004(e)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 52055, 52160);

                    ResourceManager
                    manager = f_10069_52081_52159("System.Xml", f_10069_52115_52158(f_10069_52115_52149(typeof(XmlException))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 52178, 52254);

                    string
                    locationTemplate = f_10069_52204_52253(manager, "Xml_MessageWithErrorPosition")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 52272, 52362);

                    string
                    locationString = f_10069_52296_52361(locationTemplate, "", f_10069_52332_52344(e), f_10069_52346_52360(e))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 52431, 52504);

                    int
                    position = f_10069_52446_52503(message, locationString, StringComparison.Ordinal)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 52544, 52666);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10069, 52551, 52563) || ((position < 0
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10069, 52587, 52594)) || DynAbs.Tracing.TraceSender.Conditional_F3(10069, 52618, 52665))) ? message
                    : f_10069_52618_52665(message, position, f_10069_52643_52664(locationString));
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10069, 52695, 53127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 52733, 52899);

                    f_10069_52733_52898(false, "If we hit this, then we might need to think about a different workaround " +
                                        "for stripping the location out the message.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 53097, 53112);

                    return message;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10069, 52695, 53127);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10069, 51901, 53138);

                string
                f_10069_51995_52004(System.Xml.XmlException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 51995, 52004);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_10069_52115_52149(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 52115, 52149);
                    return return_v;
                }


                System.Reflection.Assembly
                f_10069_52115_52158(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 52115, 52158);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_10069_52081_52159(string
                baseName, System.Reflection.Assembly
                assembly)
                {
                    var return_v = new System.Resources.ResourceManager(baseName, assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 52081, 52159);
                    return return_v;
                }


                string?
                f_10069_52204_52253(System.Resources.ResourceManager
                this_param, string
                name)
                {
                    var return_v = this_param.GetString(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 52204, 52253);
                    return return_v;
                }


                int
                f_10069_52332_52344(System.Xml.XmlException
                this_param)
                {
                    var return_v = this_param.LineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 52332, 52344);
                    return return_v;
                }


                int
                f_10069_52346_52360(System.Xml.XmlException
                this_param)
                {
                    var return_v = this_param.LinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 52346, 52360);
                    return return_v;
                }


                string
                f_10069_52296_52361(string?
                format, string
                arg0, int
                arg1, int
                arg2)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 52296, 52361);
                    return return_v;
                }


                int
                f_10069_52446_52503(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 52446, 52503);
                    return return_v;
                }


                int
                f_10069_52643_52664(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10069, 52643, 52664);
                    return return_v;
                }


                string
                f_10069_52618_52665(string
                this_param, int
                startIndex, int
                count)
                {
                    var return_v = this_param.Remove(startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 52618, 52665);
                    return return_v;
                }


                int
                f_10069_52733_52898(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 52733, 52898);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 51901, 53138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 51901, 53138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct TemporaryStringBuilder
        {

            public readonly PooledStringBuilder Pooled;

            public readonly int InitialIndentDepth;

            public TemporaryStringBuilder(int indentDepth)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10069, 53324, 53522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 53403, 53441);

                    this.InitialIndentDepth = indentDepth;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 53459, 53507);

                    // Lafhis
                    //this.Pooled = f_10069_53473_53506();
                    this.Pooled = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 53473, 53506);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10069, 53324, 53522);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10069, 53324, 53522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 53324, 53522);
                }
            }
            static TemporaryStringBuilder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10069, 53150, 53533);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10069, 53150, 53533);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 53150, 53533);
            }

            Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
            f_10069_53473_53506()
            {
                var return_v = PooledStringBuilder.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10069, 53473, 53506);
                return return_v;
            }

        }

        static DocumentationCommentCompiler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10069, 967, 53540);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10069, 29342, 29391);
            s_newLineSequences = new[] { "\r\n", "\r", "\n" }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10069, 967, 53540);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10069, 967, 53540);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10069, 967, 53540);
    }
}
