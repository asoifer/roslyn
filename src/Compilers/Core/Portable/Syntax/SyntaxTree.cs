// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract class SyntaxTree
    {
        protected internal static readonly ImmutableDictionary<string, ReportDiagnostic> EmptyDiagnosticOptions;

        private ImmutableArray<byte> _lazyChecksum;

        private SourceHashAlgorithm _lazyHashAlgorithm;

        public abstract string FilePath { get; }

        public abstract bool HasCompilationUnitRoot { get; }

        public ParseOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 2732, 2807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 2768, 2792);

                    return f_702_2775_2791(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(702, 2732, 2807);

                    Microsoft.CodeAnalysis.ParseOptions
                    f_702_2775_2791(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.OptionsCore;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(702, 2775, 2791);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 2680, 2818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 2680, 2818);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract ParseOptions OptionsCore { get; }

        [Obsolete("Obsolete due to performance problems, use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        public virtual ImmutableDictionary<string, ReportDiagnostic> DiagnosticOptions
        {
            /// <summary>
            /// Option to specify custom behavior for each warning in this tree.
            /// </summary>
            /// <returns>
            /// A map from diagnostic ID to diagnostic reporting level. The diagnostic
            /// ID string may be case insensitive depending on the language.
            /// </returns>
            [Obsolete("Obsolete due to performance problems, use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 3554, 3579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 3557, 3579);
                    return EmptyDiagnosticOptions; DynAbs.Tracing.TraceSender.TraceExitMethod(702, 3554, 3579);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 3554, 3579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 3554, 3579);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract int Length { get; }

        public abstract bool TryGetText([NotNullWhen(true)] out SourceText? text);

        public abstract SourceText GetText(CancellationToken cancellationToken = default);

        public abstract Encoding? Encoding { get; }

        public virtual Task<SourceText> GetTextAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 4695, 4925);
                Microsoft.CodeAnalysis.Text.SourceText? text = default(Microsoft.CodeAnalysis.Text.SourceText?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 4811, 4914);

                return f_702_4818_4913((DynAbs.Tracing.TraceSender.Conditional_F1(702, 4834, 4871) || ((f_702_4834_4871(this, out text) && DynAbs.Tracing.TraceSender.Conditional_F2(702, 4874, 4878)) || DynAbs.Tracing.TraceSender.Conditional_F3(702, 4881, 4912))) ? text : f_702_4881_4912(this, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 4695, 4925);

                bool
                f_702_4834_4871(Microsoft.CodeAnalysis.SyntaxTree
                this_param, out Microsoft.CodeAnalysis.Text.SourceText?
                text)
                {
                    var return_v = this_param.TryGetText(out text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 4834, 4871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_702_4881_4912(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetText(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 4881, 4912);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Text.SourceText>
                f_702_4818_4913(Microsoft.CodeAnalysis.Text.SourceText
                result)
                {
                    var return_v = Task.FromResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 4818, 4913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 4695, 4925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 4695, 4925);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryGetRoot([NotNullWhen(true)] out SyntaxNode? root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 5050, 5182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 5139, 5171);

                return f_702_5146_5170(this, out root);
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 5050, 5182);

                bool
                f_702_5146_5170(Microsoft.CodeAnalysis.SyntaxTree
                this_param, out Microsoft.CodeAnalysis.SyntaxNode?
                root)
                {
                    var return_v = this_param.TryGetRootCore(out root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 5146, 5170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 5050, 5182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 5050, 5182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract bool TryGetRootCore([NotNullWhen(true)] out SyntaxNode? root);

        public SyntaxNode GetRoot(CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 5533, 5679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 5630, 5668);

                return f_702_5637_5667(this, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 5533, 5679);

                Microsoft.CodeAnalysis.SyntaxNode
                f_702_5637_5667(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRootCore(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 5637, 5667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 5533, 5679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 5533, 5679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract SyntaxNode GetRootCore(CancellationToken cancellationToken);

        public Task<SyntaxNode> GetRootAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 6029, 6191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 6137, 6180);

                return f_702_6144_6179(this, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 6029, 6191);

                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.SyntaxNode>
                f_702_6144_6179(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRootAsyncCore(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 6144, 6179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 6029, 6191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 6029, 6191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "Public API.")]
        protected abstract Task<SyntaxNode> GetRootAsyncCore(CancellationToken cancellationToken);

        public abstract SyntaxTree WithChangedText(SourceText newText);

        public abstract IEnumerable<Diagnostic> GetDiagnostics(CancellationToken cancellationToken = default);

        public abstract IEnumerable<Diagnostic> GetDiagnostics(SyntaxNode node);

        public abstract IEnumerable<Diagnostic> GetDiagnostics(SyntaxToken token);

        public abstract IEnumerable<Diagnostic> GetDiagnostics(SyntaxTrivia trivia);

        public abstract IEnumerable<Diagnostic> GetDiagnostics(SyntaxNodeOrToken nodeOrToken);

        public abstract FileLinePositionSpan GetLineSpan(TextSpan span, CancellationToken cancellationToken = default);

        public abstract FileLinePositionSpan GetMappedLineSpan(TextSpan span, CancellationToken cancellationToken = default);

        public virtual LineVisibility GetLineVisibility(int position, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 10894, 11068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 11027, 11057);

                return LineVisibility.Visible;
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 10894, 11068);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 10894, 11068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 10894, 11068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual FileLinePositionSpan GetMappedLineSpanAndVisibility(TextSpan span, out bool isHiddenPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 11819, 12084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 11954, 12028);

                isHiddenPosition = f_702_11973_12002(this, span.Start) == LineVisibility.Hidden;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 12042, 12073);

                return f_702_12049_12072(this, span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 11819, 12084);

                Microsoft.CodeAnalysis.LineVisibility
                f_702_11973_12002(Microsoft.CodeAnalysis.SyntaxTree
                this_param, int
                position)
                {
                    var return_v = this_param.GetLineVisibility(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 11973, 12002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_702_12049_12072(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetMappedLineSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 12049, 12072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 11819, 12084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 11819, 12084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDisplayPath(TextSpan span, SourceReferenceResolver? resolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 12664, 13096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 12769, 12810);

                var
                mappedSpan = f_702_12786_12809(this, span)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 12824, 12945) || true) && (resolver == null || (DynAbs.Tracing.TraceSender.Expression_False(702, 12828, 12873) || f_702_12848_12873(mappedSpan.Path)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(702, 12824, 12945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 12907, 12930);

                    return mappedSpan.Path;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(702, 12824, 12945);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 12961, 13085);

                return f_702_12968_13065(resolver, mappedSpan.Path, baseFilePath: (DynAbs.Tracing.TraceSender.Conditional_F1(702, 13022, 13046) || ((mappedSpan.HasMappedPath && DynAbs.Tracing.TraceSender.Conditional_F2(702, 13049, 13057)) || DynAbs.Tracing.TraceSender.Conditional_F3(702, 13060, 13064))) ? f_702_13049_13057() : null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(702, 12968, 13084) ?? mappedSpan.Path);
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 12664, 13096);

                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_702_12786_12809(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetMappedLineSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 12786, 12809);
                    return return_v;
                }


                bool
                f_702_12848_12873(string
                source)
                {
                    var return_v = source.IsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 12848, 12873);
                    return return_v;
                }


                string
                f_702_13049_13057()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(702, 13049, 13057);
                    return return_v;
                }


                string?
                f_702_12968_13065(Microsoft.CodeAnalysis.SourceReferenceResolver
                this_param, string
                path, string?
                baseFilePath)
                {
                    var return_v = this_param.NormalizePath(path, baseFilePath: baseFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 12968, 13065);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 12664, 13096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 12664, 13096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetDisplayLineNumber(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 13694, 13885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 13816, 13874);

                return f_702_13823_13846(this, span).StartLinePosition.Line + 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 13694, 13885);

                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_702_13823_13846(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetMappedLineSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 13823, 13846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 13694, 13885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 13694, 13885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract bool HasHiddenRegions();

        public abstract IList<TextSpan> GetChangedSpans(SyntaxTree syntaxTree);

        public abstract Location GetLocation(TextSpan span);

        public abstract bool IsEquivalentTo(SyntaxTree tree, bool topLevel = false);

        public abstract SyntaxReference GetReference(SyntaxNode node);

        public abstract IList<TextChange> GetChanges(SyntaxTree oldTree);

        internal Cci.DebugSourceInfo GetDebugSourceInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 16142, 16831);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 16216, 16433) || true) && (_lazyChecksum.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(702, 16216, 16433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 16277, 16303);

                    var
                    text = f_702_16288_16302(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 16321, 16356);

                    _lazyChecksum = f_702_16337_16355(text);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 16374, 16418);

                    _lazyHashAlgorithm = f_702_16395_16417(text);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(702, 16216, 16433);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 16449, 16488);

                f_702_16449_16487(f_702_16462_16486_M(!_lazyChecksum.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 16502, 16567);

                f_702_16502_16566(_lazyHashAlgorithm != default(SourceHashAlgorithm));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 16754, 16820);

                return f_702_16761_16819(_lazyChecksum, _lazyHashAlgorithm);
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 16142, 16831);

                Microsoft.CodeAnalysis.Text.SourceText
                f_702_16288_16302(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 16288, 16302);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_702_16337_16355(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.GetChecksum();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 16337, 16355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_702_16395_16417(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(702, 16395, 16417);
                    return return_v;
                }


                bool
                f_702_16462_16486_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(702, 16462, 16486);
                    return return_v;
                }


                int
                f_702_16449_16487(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 16449, 16487);
                    return 0;
                }


                int
                f_702_16502_16566(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 16502, 16566);
                    return 0;
                }


                Microsoft.Cci.DebugSourceInfo
                f_702_16761_16819(System.Collections.Immutable.ImmutableArray<byte>
                checksum, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = new Microsoft.Cci.DebugSourceInfo(checksum, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 16761, 16819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 16142, 16831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 16142, 16831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract SyntaxTree WithRootAndOptions(SyntaxNode root, ParseOptions options);

        public abstract SyntaxTree WithFilePath(string path);

        [Obsolete("Obsolete due to performance problems, use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        public virtual SyntaxTree WithDiagnosticOptions(ImmutableDictionary<string, ReportDiagnostic> options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 17785, 18091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 18044, 18080);

                throw f_702_18050_18079();
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 17785, 18091);

                System.NotImplementedException
                f_702_18050_18079()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 18050, 18079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 17785, 18091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 17785, 18091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 18268, 18392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 18326, 18381);

                return f_702_18333_18380(f_702_18333_18369(this, CancellationToken.None));
                DynAbs.Tracing.TraceSender.TraceExitMethod(702, 18268, 18392);

                Microsoft.CodeAnalysis.Text.SourceText
                f_702_18333_18369(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetText(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 18333, 18369);
                    return return_v;
                }


                string
                f_702_18333_18380(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 18333, 18380);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 18268, 18392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 18268, 18392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool SupportsLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(702, 18468, 18511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 18474, 18509);

                    return f_702_18481_18508(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(702, 18468, 18511);

                    bool
                    f_702_18481_18508(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.HasCompilationUnitRoot;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(702, 18481, 18508);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(702, 18404, 18522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 18404, 18522);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxTree()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(702, 638, 18529);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 1104, 1122);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(702, 638, 18529);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 638, 18529);
        }


        static SyntaxTree()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(702, 638, 18529);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(702, 884, 1010);
            EmptyDiagnosticOptions = f_702_922_1010(f_702_975_1009()); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(702, 638, 18529);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(702, 638, 18529);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(702, 638, 18529);

        static System.StringComparer
        f_702_975_1009()
        {
            var return_v = CaseInsensitiveComparison.Comparer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(702, 975, 1009);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
        f_702_922_1010(System.StringComparer
        keyComparer)
        {
            var return_v = ImmutableDictionary.Create<string, ReportDiagnostic>((System.Collections.Generic.IEqualityComparer<string>)keyComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(702, 922, 1010);
            return return_v;
        }

    }
}
