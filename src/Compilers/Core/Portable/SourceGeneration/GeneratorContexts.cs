// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;
namespace Microsoft.CodeAnalysis
{

    public readonly struct GeneratorExecutionContext
    {

        private readonly DiagnosticBag _diagnostics;

        private readonly AdditionalSourcesCollection _additionalSources;

        internal GeneratorExecutionContext(Compilation compilation, ParseOptions parseOptions, ImmutableArray<AdditionalText> additionalTexts, AnalyzerConfigOptionsProvider optionsProvider, ISyntaxContextReceiver? syntaxReceiver, AdditionalSourcesCollection additionalSources, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(549, 788, 1742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 1128, 1154);

                Compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 1168, 1196);

                ParseOptions = parseOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 1210, 1244);

                AdditionalFiles = additionalTexts;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 1258, 1298);

                AnalyzerConfigOptions = optionsProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 1335, 1466);

                SyntaxReceiver = (DynAbs.Tracing.TraceSender.Conditional_F1(549, 1352, 1400) || (((syntaxReceiver is SyntaxContextReceiverAdaptor) && DynAbs.Tracing.TraceSender.Conditional_F2(549, 1403, 1458)) || DynAbs.Tracing.TraceSender.Conditional_F3(549, 1461, 1465))) ? f_549_1403_1458(((SyntaxContextReceiverAdaptor)syntaxReceiver)) : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 1480, 1577);

                SyntaxContextReceiver = (DynAbs.Tracing.TraceSender.Conditional_F1(549, 1504, 1552) || (((syntaxReceiver is SyntaxContextReceiverAdaptor) && DynAbs.Tracing.TraceSender.Conditional_F2(549, 1555, 1559)) || DynAbs.Tracing.TraceSender.Conditional_F3(549, 1562, 1576))) ? null : syntaxReceiver;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 1591, 1629);

                CancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 1643, 1682);

                _additionalSources = additionalSources;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 1696, 1731);

                _diagnostics = f_549_1711_1730();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(549, 788, 1742);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 788, 1742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 788, 1742);
            }
        }

        public Compilation Compilation { get; }

        public ParseOptions ParseOptions { get; }

        public ImmutableArray<AdditionalText> AdditionalFiles { get; }

        public AnalyzerConfigOptionsProvider AnalyzerConfigOptions { get; }

        public ISyntaxReceiver? SyntaxReceiver { get; }

        public ISyntaxContextReceiver? SyntaxContextReceiver { get; }

        public CancellationToken CancellationToken { get; }

        public void AddSource(string hintName, string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(549, 4049, 4111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 4052, 4111);
                AddSource(hintName, f_549_4072_4110(source, f_549_4096_4109())); DynAbs.Tracing.TraceSender.TraceExitMethod(549, 4049, 4111);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 4049, 4111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 4049, 4111);
            }

            System.Text.Encoding
            f_549_4096_4109()
            {
                var return_v = Encoding.UTF8;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(549, 4096, 4109);
                return return_v;
            }


            Microsoft.CodeAnalysis.Text.SourceText
            f_549_4072_4110(string
            text, System.Text.Encoding
            encoding)
            {
                var return_v = SourceText.From(text, encoding);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 4072, 4110);
                return return_v;
            }

        }

        public void AddSource(string hintName, SourceText sourceText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(549, 4541, 4588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 4544, 4588);
                f_549_4544_4588(_additionalSources, hintName, sourceText); DynAbs.Tracing.TraceSender.TraceExitMethod(549, 4541, 4588);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 4541, 4588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 4541, 4588);
            }

            int
            f_549_4544_4588(Microsoft.CodeAnalysis.AdditionalSourcesCollection
            this_param, string
            hintName, Microsoft.CodeAnalysis.Text.SourceText
            source)
            {
                this_param.Add(hintName, source);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 4544, 4588);
                return 0;
            }

        }

        public void ReportDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(549, 5051, 5082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 5054, 5082);
                f_549_5054_5082(_diagnostics, diagnostic); DynAbs.Tracing.TraceSender.TraceExitMethod(549, 5051, 5082);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 5051, 5082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 5051, 5082);
            }

            int
            f_549_5054_5082(Microsoft.CodeAnalysis.DiagnosticBag
            this_param, Microsoft.CodeAnalysis.Diagnostic
            diag)
            {
                this_param.Add(diag);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 5054, 5082);
                return 0;
            }

        }

        internal (ImmutableArray<GeneratedSourceText> sources, ImmutableArray<Diagnostic> diagnostics) ToImmutableAndFree()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(549, 5224, 5302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 5227, 5302);
                return (f_549_5228_5267(_additionalSources), f_549_5269_5301(_diagnostics)); DynAbs.Tracing.TraceSender.TraceExitMethod(549, 5224, 5302);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 5224, 5302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 5224, 5302);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
            f_549_5228_5267(Microsoft.CodeAnalysis.AdditionalSourcesCollection
            this_param)
            {
                var return_v = this_param.ToImmutableAndFree();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 5228, 5267);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
            f_549_5269_5301(Microsoft.CodeAnalysis.DiagnosticBag
            this_param)
            {
                var return_v = this_param.ToReadOnlyAndFree();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 5269, 5301);
                return return_v;
            }

        }
        static GeneratorExecutionContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(549, 591, 5310);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(549, 591, 5310);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 591, 5310);
        }

        static Microsoft.CodeAnalysis.ISyntaxReceiver
        f_549_1403_1458(Microsoft.CodeAnalysis.SyntaxContextReceiverAdaptor
        this_param)
        {
            var return_v = this_param.Receiver;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(549, 1403, 1458);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticBag
        f_549_1711_1730()
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 1711, 1730);
            return return_v;
        }

    }

    public struct GeneratorInitializationContext
    {

        internal GeneratorInitializationContext(CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(549, 5553, 5769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 5664, 5702);

                CancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 5716, 5758);

                InfoBuilder = f_549_5730_5757();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(549, 5553, 5769);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 5553, 5769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 5553, 5769);
            }
        }

        public CancellationToken CancellationToken { get; }

        internal GeneratorInfo.Builder InfoBuilder { get; }

        internal void RegisterForAdditionalFileChanges(EditCallback<AdditionalFileEdit> callback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(549, 6088, 6302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 6202, 6241);

                CheckIsEmpty(f_549_6215_6239(InfoBuilder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 6255, 6291);

                InfoBuilder.EditCallback = callback;
                DynAbs.Tracing.TraceSender.TraceExitMethod(549, 6088, 6302);

                Microsoft.CodeAnalysis.EditCallback<Microsoft.CodeAnalysis.AdditionalFileEdit>?
                f_549_6215_6239(Microsoft.CodeAnalysis.GeneratorInfo.Builder
                this_param)
                {
                    var return_v = this_param.EditCallback;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(549, 6215, 6239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 6088, 6302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 6088, 6302);
            }
        }

        public void RegisterForSyntaxNotifications(SyntaxReceiverCreator receiverCreator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(549, 7769, 8128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 7875, 8007);

                CheckIsEmpty(f_549_7888_7928(InfoBuilder), $"{nameof(SyntaxReceiverCreator)} / {nameof(SyntaxContextReceiverCreator)}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 8021, 8117);

                InfoBuilder.SyntaxContextReceiverCreator = f_549_8064_8116(receiverCreator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(549, 7769, 8128);

                Microsoft.CodeAnalysis.SyntaxContextReceiverCreator?
                f_549_7888_7928(Microsoft.CodeAnalysis.GeneratorInfo.Builder
                this_param)
                {
                    var return_v = this_param.SyntaxContextReceiverCreator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(549, 7888, 7928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxContextReceiverCreator
                f_549_8064_8116(Microsoft.CodeAnalysis.SyntaxReceiverCreator
                creator)
                {
                    var return_v = SyntaxContextReceiverAdaptor.Create(creator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 8064, 8116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 7769, 8128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 7769, 8128);
            }
        }

        public void RegisterForSyntaxNotifications(SyntaxContextReceiverCreator receiverCreator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(549, 9744, 10073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 9857, 9989);

                CheckIsEmpty(f_549_9870_9910(InfoBuilder), $"{nameof(SyntaxReceiverCreator)} / {nameof(SyntaxContextReceiverCreator)}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 10003, 10062);

                InfoBuilder.SyntaxContextReceiverCreator = receiverCreator;
                DynAbs.Tracing.TraceSender.TraceExitMethod(549, 9744, 10073);

                Microsoft.CodeAnalysis.SyntaxContextReceiverCreator?
                f_549_9870_9910(Microsoft.CodeAnalysis.GeneratorInfo.Builder
                this_param)
                {
                    var return_v = this_param.SyntaxContextReceiverCreator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(549, 9870, 9910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 9744, 10073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 9744, 10073);
            }
        }

        public void RegisterForPostInitialization(Action<GeneratorPostInitializationContext> callback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(549, 11353, 11580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 11472, 11515);

                CheckIsEmpty(f_549_11485_11513(InfoBuilder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 11529, 11569);

                InfoBuilder.PostInitCallback = callback;
                DynAbs.Tracing.TraceSender.TraceExitMethod(549, 11353, 11580);

                System.Action<Microsoft.CodeAnalysis.GeneratorPostInitializationContext>?
                f_549_11485_11513(Microsoft.CodeAnalysis.GeneratorInfo.Builder
                this_param)
                {
                    var return_v = this_param.PostInitCallback;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(549, 11485, 11513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 11353, 11580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 11353, 11580);
            }
        }

        private static void CheckIsEmpty<T>(T x, string? typeName = null) where T : class?
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(549, 11592, 11904);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 11699, 11893) || true) && (x is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(549, 11699, 11893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 11748, 11878);

                    throw f_549_11754_11877(f_549_11784_11876(f_549_11798_11847(), typeName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(549, 11849, 11875) ?? f_549_11861_11875(typeof(T)))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(549, 11699, 11893);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(549, 11592, 11904);

                string
                f_549_11798_11847()
                {
                    var return_v = CodeAnalysisResources.Single_type_per_generator_0;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(549, 11798, 11847);
                    return return_v;
                }


                string
                f_549_11861_11875(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(549, 11861, 11875);
                    return return_v;
                }


                string
                f_549_11784_11876(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 11784, 11876);
                    return return_v;
                }


                System.InvalidOperationException
                f_549_11754_11877(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 11754, 11877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 11592, 11904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 11592, 11904);
            }
        }
        static GeneratorInitializationContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(549, 5492, 11911);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(549, 5492, 11911);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 5492, 11911);
        }

        static Microsoft.CodeAnalysis.GeneratorInfo.Builder
        f_549_5730_5757()
        {
            var return_v = new Microsoft.CodeAnalysis.GeneratorInfo.Builder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 5730, 5757);
            return return_v;
        }

    }

    public readonly struct GeneratorSyntaxContext
    {

        internal GeneratorSyntaxContext(SyntaxNode node, SemanticModel semanticModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(549, 12181, 12350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 12283, 12295);

                Node = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 12309, 12339);

                SemanticModel = semanticModel;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(549, 12181, 12350);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 12181, 12350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 12181, 12350);
            }
        }

        public SyntaxNode Node { get; }

        public SemanticModel SemanticModel { get; }
        static GeneratorSyntaxContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(549, 12119, 12742);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(549, 12119, 12742);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 12119, 12742);
        }
    }

    public readonly struct GeneratorPostInitializationContext
    {

        private readonly AdditionalSourcesCollection _additionalSources;

        internal GeneratorPostInitializationContext(AdditionalSourcesCollection additionalSources, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(549, 13151, 13405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 13303, 13342);

                _additionalSources = additionalSources;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 13356, 13394);

                CancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(549, 13151, 13405);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 13151, 13405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 13151, 13405);
            }
        }

        public CancellationToken CancellationToken { get; }

        public void AddSource(string hintName, string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(549, 14128, 14190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 14131, 14190);
                AddSource(hintName, f_549_14151_14189(source, f_549_14175_14188())); DynAbs.Tracing.TraceSender.TraceExitMethod(549, 14128, 14190);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 14128, 14190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 14128, 14190);
            }

            System.Text.Encoding
            f_549_14175_14188()
            {
                var return_v = Encoding.UTF8;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(549, 14175, 14188);
                return return_v;
            }


            Microsoft.CodeAnalysis.Text.SourceText
            f_549_14151_14189(string
            text, System.Text.Encoding
            encoding)
            {
                var return_v = SourceText.From(text, encoding);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 14151, 14189);
                return return_v;
            }

        }

        public void AddSource(string hintName, SourceText sourceText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(549, 14668, 14715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 14671, 14715);
                f_549_14671_14715(_additionalSources, hintName, sourceText); DynAbs.Tracing.TraceSender.TraceExitMethod(549, 14668, 14715);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 14668, 14715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 14668, 14715);
            }

            int
            f_549_14671_14715(Microsoft.CodeAnalysis.AdditionalSourcesCollection
            this_param, string
            hintName, Microsoft.CodeAnalysis.Text.SourceText
            source)
            {
                this_param.Add(hintName, source);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(549, 14671, 14715);
                return 0;
            }

        }
        static GeneratorPostInitializationContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(549, 13001, 14723);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(549, 13001, 14723);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 13001, 14723);
        }
    }

    internal readonly struct GeneratorEditContext
    {

        internal GeneratorEditContext(AdditionalSourcesCollection sources, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(549, 14793, 15022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 14931, 14959);

                AdditionalSources = sources;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(549, 14973, 15011);

                CancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(549, 14793, 15022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(549, 14793, 15022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 14793, 15022);
            }
        }

        public CancellationToken CancellationToken { get; }

        public AdditionalSourcesCollection AdditionalSources { get; }
        static GeneratorEditContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(549, 14731, 15165);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(549, 14731, 15165);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(549, 14731, 15165);
        }
    }
}
