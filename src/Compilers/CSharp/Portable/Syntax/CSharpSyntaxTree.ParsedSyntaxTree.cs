// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class CSharpSyntaxTree
    {
        private class ParsedSyntaxTree : CSharpSyntaxTree
        {
            private readonly CSharpParseOptions _options;

            private readonly string _path;

            private readonly CSharpSyntaxNode _root;

            private readonly bool _hasCompilationUnitRoot;

            private readonly Encoding? _encodingOpt;

            private readonly SourceHashAlgorithm _checksumAlgorithm;

            private readonly ImmutableDictionary<string, ReportDiagnostic> _diagnosticOptions;

            private SourceText? _lazyText;

            internal ParsedSyntaxTree(
                            SourceText? textOpt,
                            Encoding? encodingOpt,
                            SourceHashAlgorithm checksumAlgorithm,
                            string path,
                            CSharpParseOptions options,
                            CSharpSyntaxNode root,
                            Syntax.InternalSyntax.DirectiveStack directives,
                            ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions,
                            bool cloneRoot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10755, 1149, 2405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 702, 710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 749, 754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 803, 808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 845, 868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 910, 922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 974, 992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 1070, 1088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 1123, 1132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 1639, 1666);

                    f_10755_1639_1665(root != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 1684, 1714);

                    f_10755_1684_1713(options != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 1732, 1847);

                    f_10755_1732_1846(textOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10755, 1745, 1845) || f_10755_1764_1780(textOpt) == encodingOpt && (DynAbs.Tracing.TraceSender.Expression_True(10755, 1764, 1845) && f_10755_1799_1824(textOpt) == checksumAlgorithm)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 1867, 1887);

                    _lazyText = textOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 1905, 1953);

                    _encodingOpt = encodingOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Text.Encoding?>(10755, 1920, 1952) ?? f_10755_1935_1952_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(textOpt, 10755, 1935, 1952)?.Encoding));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 1971, 2010);

                    _checksumAlgorithm = checksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 2028, 2047);

                    _options = options;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 2065, 2094);

                    _path = path ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(10755, 2073, 2093) ?? string.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 2112, 2166);

                    _root = (DynAbs.Tracing.TraceSender.Conditional_F1(10755, 2120, 2129) || ((cloneRoot && DynAbs.Tracing.TraceSender.Conditional_F2(10755, 2132, 2158)) || DynAbs.Tracing.TraceSender.Conditional_F3(10755, 2161, 2165))) ? f_10755_2132_2158(this, root) : root;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 2184, 2252);

                    _hasCompilationUnitRoot = f_10755_2210_2221(root) == SyntaxKind.CompilationUnit;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 2270, 2335);

                    _diagnosticOptions = diagnosticOptions ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?>(10755, 2291, 2334) ?? EmptyDiagnosticOptions);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 2355, 2390);

                    f_10755_2355_2389(
                                    this, directives);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10755, 1149, 2405);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 1149, 2405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 1149, 2405);
                }
            }

            public override string FilePath
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 2485, 2506);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 2491, 2504);

                        return _path;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 2485, 2506);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 2421, 2521);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 2421, 2521);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override SourceText GetText(CancellationToken cancellationToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 2537, 2899);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 2641, 2847) || true) && (_lazyText == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10755, 2641, 2847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 2704, 2828);

                        f_10755_2704_2827(ref _lazyText, f_10755_2747_2820(f_10755_2747_2778(this, cancellationToken), _encodingOpt, _checksumAlgorithm), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10755, 2641, 2847);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 2867, 2884);

                    return _lazyText;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 2537, 2899);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10755_2747_2778(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
                    this_param, System.Threading.CancellationToken
                    cancellationToken)
                    {
                        var return_v = this_param.GetRoot(cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 2747, 2778);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.SourceText
                    f_10755_2747_2820(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param, System.Text.Encoding?
                    encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                    checksumAlgorithm)
                    {
                        var return_v = this_param.GetText(encoding, checksumAlgorithm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 2747, 2820);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.SourceText?
                    f_10755_2704_2827(ref Microsoft.CodeAnalysis.Text.SourceText?
                    location1, Microsoft.CodeAnalysis.Text.SourceText
                    value, Microsoft.CodeAnalysis.Text.SourceText?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 2704, 2827);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 2537, 2899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 2537, 2899);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool TryGetText([NotNullWhen(true)] out SourceText? text)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 2915, 3091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 3021, 3038);

                    text = _lazyText;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 3056, 3076);

                    return text != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 2915, 3091);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 2915, 3091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 2915, 3091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Encoding? Encoding
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 3174, 3202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 3180, 3200);

                        return _encodingOpt;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 3174, 3202);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 3107, 3217);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 3107, 3217);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int Length
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 3292, 3329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 3298, 3327);

                        return _root.FullSpan.Length;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 3292, 3329);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 3233, 3344);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 3233, 3344);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override CSharpSyntaxNode GetRoot(CancellationToken cancellationToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 3360, 3498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 3470, 3483);

                    return _root;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 3360, 3498);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 3360, 3498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 3360, 3498);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool TryGetRoot(out CSharpSyntaxNode root)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 3514, 3663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 3605, 3618);

                    root = _root;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 3636, 3648);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 3514, 3663);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 3514, 3663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 3514, 3663);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool HasCompilationUnitRoot
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 3755, 3849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 3799, 3830);

                        return _hasCompilationUnitRoot;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 3755, 3849);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 3679, 3864);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 3679, 3864);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override CSharpParseOptions Options
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 3955, 4034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 3999, 4015);

                        return _options;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 3955, 4034);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 3880, 4049);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 3880, 4049);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            [Obsolete("Obsolete due to performance problems, use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
            public override ImmutableDictionary<string, ReportDiagnostic> DiagnosticOptions
            {
                [Obsolete("Obsolete due to performance problems, use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 4281, 4302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 4284, 4302);
                        return _diagnosticOptions; DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 4281, 4302);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 4281, 4302);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 4281, 4302);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override SyntaxReference GetReference(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 4319, 4467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 4413, 4452);

                    return f_10755_4420_4451(node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 4319, 4467);

                    Microsoft.CodeAnalysis.CSharp.SimpleSyntaxReference
                    f_10755_4420_4451(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SimpleSyntaxReference(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 4420, 4451);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 4319, 4467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 4319, 4467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxTree WithRootAndOptions(SyntaxNode root, ParseOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 4483, 5155);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 4600, 4743) || true) && (f_10755_4604_4632(_root, root) && (DynAbs.Tracing.TraceSender.Expression_True(10755, 4604, 4670) && f_10755_4636_4670(_options, options)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10755, 4600, 4743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 4712, 4724);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10755, 4600, 4743);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 4763, 5140);

                    return f_10755_4770_5139(textOpt: null, _encodingOpt, _checksumAlgorithm, _path, (CSharpParseOptions)options, (CSharpSyntaxNode)root, _directives, _diagnosticOptions, cloneRoot: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 4483, 5155);

                    bool
                    f_10755_4604_4632(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    objA, Microsoft.CodeAnalysis.SyntaxNode
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 4604, 4632);
                        return return_v;
                    }


                    bool
                    f_10755_4636_4670(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    objA, Microsoft.CodeAnalysis.ParseOptions
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 4636, 4670);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
                    f_10755_4770_5139(Microsoft.CodeAnalysis.Text.SourceText?
                    textOpt, System.Text.Encoding?
                    encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                    checksumAlgorithm, string
                    path, Microsoft.CodeAnalysis.ParseOptions
                    options, Microsoft.CodeAnalysis.SyntaxNode
                    root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                    directives, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                    diagnosticOptions, bool
                    cloneRoot)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree(textOpt: textOpt, encodingOpt, checksumAlgorithm, path, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions)options, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)root, directives, diagnosticOptions, cloneRoot: cloneRoot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 4770, 5139);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 4483, 5155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 4483, 5155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxTree WithFilePath(string path)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 5171, 5717);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 5256, 5346) || true) && (_path == path)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10755, 5256, 5346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 5315, 5327);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10755, 5256, 5346);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 5366, 5702);

                    return f_10755_5373_5701(_lazyText, _encodingOpt, _checksumAlgorithm, path, _options, _root, _directives, _diagnosticOptions, cloneRoot: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 5171, 5717);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
                    f_10755_5373_5701(Microsoft.CodeAnalysis.Text.SourceText?
                    textOpt, System.Text.Encoding?
                    encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                    checksumAlgorithm, string
                    path, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    options, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                    directives, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                    diagnosticOptions, bool
                    cloneRoot)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree(textOpt, encodingOpt, checksumAlgorithm, path, options, root, directives, diagnosticOptions, cloneRoot: cloneRoot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 5373, 5701);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 5171, 5717);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 5171, 5717);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [Obsolete("Obsolete due to performance problems, use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
            public override SyntaxTree WithDiagnosticOptions(ImmutableDictionary<string, ReportDiagnostic> options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10755, 5733, 6620);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 6005, 6118) || true) && (options is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10755, 6005, 6118);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 6066, 6099);

                        options = EmptyDiagnosticOptions;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10755, 6005, 6118);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 6138, 6259) || true) && (f_10755_6142_6186(_diagnosticOptions, options))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10755, 6138, 6259);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 6228, 6240);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10755, 6138, 6259);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10755, 6279, 6605);

                    return f_10755_6286_6604(_lazyText, _encodingOpt, _checksumAlgorithm, _path, _options, _root, _directives, options, cloneRoot: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10755, 5733, 6620);

                    bool
                    f_10755_6142_6186(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                    objA, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 6142, 6186);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
                    f_10755_6286_6604(Microsoft.CodeAnalysis.Text.SourceText?
                    textOpt, System.Text.Encoding?
                    encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                    checksumAlgorithm, string
                    path, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    options, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                    directives, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                    diagnosticOptions, bool
                    cloneRoot)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree(textOpt, encodingOpt, checksumAlgorithm, path, options, root, directives, diagnosticOptions, cloneRoot: cloneRoot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 6286, 6604);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10755, 5733, 6620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 5733, 6620);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ParsedSyntaxTree()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10755, 592, 6631);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10755, 592, 6631);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10755, 592, 6631);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10755, 592, 6631);

            int
            f_10755_1639_1665(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 1639, 1665);
                return 0;
            }


            int
            f_10755_1684_1713(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 1684, 1713);
                return 0;
            }


            System.Text.Encoding?
            f_10755_1764_1780(Microsoft.CodeAnalysis.Text.SourceText
            this_param)
            {
                var return_v = this_param.Encoding;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10755, 1764, 1780);
                return return_v;
            }


            Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
            f_10755_1799_1824(Microsoft.CodeAnalysis.Text.SourceText
            this_param)
            {
                var return_v = this_param.ChecksumAlgorithm;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10755, 1799, 1824);
                return return_v;
            }


            int
            f_10755_1732_1846(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 1732, 1846);
                return 0;
            }


            System.Text.Encoding?
            f_10755_1935_1952_M(System.Text.Encoding?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10755, 1935, 1952);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            f_10755_2132_2158(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
            this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            node)
            {
                var return_v = this_param.CloneNodeAsRoot<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 2132, 2158);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10755_2210_2221(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            this_param)
            {
                var return_v = this_param.Kind();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 2210, 2221);
                return return_v;
            }


            int
            f_10755_2355_2389(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParsedSyntaxTree
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
            directives)
            {
                this_param.SetDirectiveStack(directives);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10755, 2355, 2389);
                return 0;
            }

        }
    }
}
