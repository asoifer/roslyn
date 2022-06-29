// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public abstract class AnalysisContext
    {
        public abstract void RegisterCompilationStartAction(Action<CompilationStartAnalysisContext> action);

        public abstract void RegisterCompilationAction(Action<CompilationAnalysisContext> action);

        public abstract void RegisterSemanticModelAction(Action<SemanticModelAnalysisContext> action);

        public void RegisterSymbolAction(Action<SymbolAnalysisContext> action, params SymbolKind[] symbolKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 3733, 3940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 3861, 3929);

                f_256_3861_3928(this, action, f_256_3895_3927(symbolKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 3733, 3940);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                f_256_3895_3927(Microsoft.CodeAnalysis.SymbolKind[]
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.SymbolKind>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 3895, 3927);
                    return return_v;
                }


                int
                f_256_3861_3928(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                symbolKinds)
                {
                    this_param.RegisterSymbolAction(action, symbolKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 3861, 3928);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 3733, 3940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 3733, 3940);
            }
        }

        public abstract void RegisterSymbolAction(Action<SymbolAnalysisContext> action, ImmutableArray<SymbolKind> symbolKinds);

        public virtual void RegisterSymbolStartAction(Action<SymbolStartAnalysisContext> action, SymbolKind symbolKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 5030, 5213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 5166, 5202);

                throw f_256_5172_5201();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 5030, 5213);

                System.NotImplementedException
                f_256_5172_5201()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 5172, 5201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 5030, 5213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 5030, 5213);
            }
        }

        public abstract void RegisterCodeBlockStartAction<TLanguageKindEnum>(Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> action) where TLanguageKindEnum : struct;

        public abstract void RegisterCodeBlockAction(Action<CodeBlockAnalysisContext> action);

        public abstract void RegisterSyntaxTreeAction(Action<SyntaxTreeAnalysisContext> action);

        public virtual void RegisterAdditionalFileAction(Action<AdditionalFileAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 7328, 7494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 7447, 7483);

                throw f_256_7453_7482();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 7328, 7494);

                System.NotImplementedException
                f_256_7453_7482()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 7453, 7482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 7328, 7494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 7328, 7494);
            }
        }

        public void RegisterSyntaxNodeAction<TLanguageKindEnum>(Action<SyntaxNodeAnalysisContext> action, params TLanguageKindEnum[] syntaxKinds) where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 8349, 8627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 8544, 8616);

                f_256_8544_8615(this, action, f_256_8582_8614(syntaxKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 8349, 8627);

                System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                f_256_8582_8614(TLanguageKindEnum[]
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<TLanguageKindEnum>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 8582, 8614);
                    return return_v;
                }


                int
                f_256_8544_8615(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                syntaxKinds)
                {
                    this_param.RegisterSyntaxNodeAction<TLanguageKindEnum>(action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 8544, 8615);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 8349, 8627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 8349, 8627);
            }
        }

        public abstract void RegisterSyntaxNodeAction<TLanguageKindEnum>(Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds) where TLanguageKindEnum : struct;

        public virtual void RegisterOperationBlockStartAction(Action<OperationBlockStartAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 10206, 10382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 10335, 10371);

                throw f_256_10341_10370();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 10206, 10382);

                System.NotImplementedException
                f_256_10341_10370()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 10341, 10370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 10206, 10382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 10206, 10382);
            }
        }

        public virtual void RegisterOperationBlockAction(Action<OperationBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 10769, 10935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 10888, 10924);

                throw f_256_10894_10923();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 10769, 10935);

                System.NotImplementedException
                f_256_10894_10923()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 10894, 10923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 10769, 10935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 10769, 10935);
            }
        }

        public void RegisterOperationAction(Action<OperationAnalysisContext> action, params OperationKind[] operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 11643, 11868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 11783, 11857);

                f_256_11783_11856(this, action, f_256_11820_11855(operationKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 11643, 11868);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                f_256_11820_11855(Microsoft.CodeAnalysis.OperationKind[]
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.OperationKind>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 11820, 11855);
                    return return_v;
                }


                int
                f_256_11783_11856(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 11783, 11856);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 11643, 11868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 11643, 11868);
            }
        }

        public virtual void RegisterOperationAction(Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 12576, 12778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 12731, 12767);

                throw f_256_12737_12766();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 12576, 12778);

                System.NotImplementedException
                f_256_12737_12766()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 12737, 12766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 12576, 12778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 12576, 12778);
            }
        }

        public virtual void EnableConcurrentExecution()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 13685, 13804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 13757, 13793);

                throw f_256_13763_13792();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 13685, 13804);

                System.NotImplementedException
                f_256_13763_13792()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 13763, 13792);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 13685, 13804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 13685, 13804);
            }
        }

        public virtual void ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags analysisMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 14174, 14337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 14290, 14326);

                throw f_256_14296_14325();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 14174, 14337);

                System.NotImplementedException
                f_256_14296_14325()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 14296, 14325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 14174, 14337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 14174, 14337);
            }
        }

        public bool TryGetValue<TValue>(SourceText text, SourceTextValueProvider<TValue> valueProvider, [MaybeNullWhen(false)] out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 15298, 15539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 15459, 15528);

                return f_256_15466_15527(this, text, f_256_15484_15515(valueProvider), out value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 15298, 15539);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.Text.SourceText, TValue>
                f_256_15484_15515(Microsoft.CodeAnalysis.Diagnostics.SourceTextValueProvider<TValue>
                this_param)
                {
                    var return_v = this_param.CoreValueProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 15484, 15515);
                    return return_v;
                }


                bool
                f_256_15466_15527(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                key, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.Text.SourceText, TValue>
                valueProvider, out TValue?
                value)
                {
                    var return_v = this_param.TryGetValue<Microsoft.CodeAnalysis.Text.SourceText, TValue>(key, valueProvider, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 15466, 15527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 15298, 15539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 15298, 15539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetValue<TKey, TValue>(TKey key, AnalysisValueProvider<TKey, TValue> valueProvider, [MaybeNullWhen(false)] out TValue value)
                    where TKey : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 15551, 15891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 15748, 15817);

                f_256_15748_15816(key, valueProvider);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 15831, 15880);

                return f_256_15838_15879(valueProvider, key, out value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 15551, 15891);

                int
                f_256_15748_15816(TKey
                key, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                valueProvider)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(key, valueProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 15748, 15816);
                    return 0;
                }


                bool
                f_256_15838_15879(Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                this_param, TKey
                key, out TValue?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 15838, 15879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 15551, 15891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 15551, 15891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public AnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 1683, 15898);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 1683, 15898);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 1683, 15898);
        }


        static AnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 1683, 15898);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 1683, 15898);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 1683, 15898);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(256, 1683, 15898);
    }

    /// <summary>
    /// Flags to configure mode of generated code analysis.
    /// </summary>
    [Flags]
    public enum GeneratedCodeAnalysisFlags
    {
        /// <summary>
        /// Disable analyzer action callbacks and diagnostic reporting for generated code.
        /// Analyzer driver will not make callbacks into the analyzer for entities (source files, symbols, etc.) that it classifies as generated code.
        /// Additionally, any diagnostic reported by the analyzer with location in generated code will not be reported.
        /// </summary>
        None = 0x00,

        /// <summary>
        /// Enable analyzer action callbacks for generated code.
        /// Analyzer driver will make callbacks into the analyzer for all entities (source files, symbols, etc.) in the compilation, including generated code.
        /// </summary>
        Analyze = 0x01,

        /// <summary>
        /// Enable reporting diagnostics on generated code.
        /// Analyzer driver will not suppress any analyzer diagnostic based on whether or not it's location is in generated code.
        /// </summary>
        ReportDiagnostics = 0x02,
    }
    public abstract class CompilationStartAnalysisContext
    {
        private readonly Compilation _compilation;

        private readonly AnalyzerOptions _options;

        private readonly CancellationToken _cancellationToken;

        public Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 18653, 18681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 18659, 18679);

                    return _compilation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 18653, 18681);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 18620, 18683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 18620, 18683);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 18824, 18848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 18830, 18846);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 18824, 18848);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 18791, 18850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 18791, 18850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 19026, 19060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 19032, 19058);

                    return _cancellationToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 19026, 19060);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 18981, 19062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 18981, 19062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected CompilationStartAnalysisContext(Compilation compilation, AnalyzerOptions options, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 19074, 19351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 18343, 18355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 18399, 18407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 19227, 19254);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 19268, 19287);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 19301, 19340);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 19074, 19351);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 19074, 19351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 19074, 19351);
            }
        }

        public abstract void RegisterCompilationEndAction(Action<CompilationAnalysisContext> action);

        public abstract void RegisterSemanticModelAction(Action<SemanticModelAnalysisContext> action);

        public void RegisterSymbolAction(Action<SymbolAnalysisContext> action, params SymbolKind[] symbolKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 20853, 21060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 20981, 21049);

                f_256_20981_21048(this, action, f_256_21015_21047(symbolKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 20853, 21060);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                f_256_21015_21047(Microsoft.CodeAnalysis.SymbolKind[]
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.SymbolKind>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 21015, 21047);
                    return return_v;
                }


                int
                f_256_20981_21048(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                symbolKinds)
                {
                    this_param.RegisterSymbolAction(action, symbolKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 20981, 21048);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 20853, 21060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 20853, 21060);
            }
        }

        public abstract void RegisterSymbolAction(Action<SymbolAnalysisContext> action, ImmutableArray<SymbolKind> symbolKinds);

        public virtual void RegisterSymbolStartAction(Action<SymbolStartAnalysisContext> action, SymbolKind symbolKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 22150, 22333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 22286, 22322);

                throw f_256_22292_22321();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 22150, 22333);

                System.NotImplementedException
                f_256_22292_22321()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 22292, 22321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 22150, 22333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 22150, 22333);
            }
        }

        public abstract void RegisterCodeBlockStartAction<TLanguageKindEnum>(Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> action) where TLanguageKindEnum : struct;

        public abstract void RegisterCodeBlockAction(Action<CodeBlockAnalysisContext> action);

        public virtual void RegisterOperationBlockStartAction(Action<OperationBlockStartAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 24179, 24355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 24308, 24344);

                throw f_256_24314_24343();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 24179, 24355);

                System.NotImplementedException
                f_256_24314_24343()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 24314, 24343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 24179, 24355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 24179, 24355);
            }
        }

        public virtual void RegisterOperationBlockAction(Action<OperationBlockAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 24742, 24908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 24861, 24897);

                throw f_256_24867_24896();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 24742, 24908);

                System.NotImplementedException
                f_256_24867_24896()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 24867, 24896);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 24742, 24908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 24742, 24908);
            }
        }

        public abstract void RegisterSyntaxTreeAction(Action<SyntaxTreeAnalysisContext> action);

        public virtual void RegisterAdditionalFileAction(Action<AdditionalFileAnalysisContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 25722, 25888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 25841, 25877);

                throw f_256_25847_25876();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 25722, 25888);

                System.NotImplementedException
                f_256_25847_25876()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 25847, 25876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 25722, 25888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 25722, 25888);
            }
        }

        public void RegisterSyntaxNodeAction<TLanguageKindEnum>(Action<SyntaxNodeAnalysisContext> action, params TLanguageKindEnum[] syntaxKinds) where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 26743, 27021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 26938, 27010);

                f_256_26938_27009(this, action, f_256_26976_27008(syntaxKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 26743, 27021);

                System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                f_256_26976_27008(TLanguageKindEnum[]
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<TLanguageKindEnum>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 26976, 27008);
                    return return_v;
                }


                int
                f_256_26938_27009(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                syntaxKinds)
                {
                    this_param.RegisterSyntaxNodeAction<TLanguageKindEnum>(action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 26938, 27009);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 26743, 27021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 26743, 27021);
            }
        }

        public abstract void RegisterSyntaxNodeAction<TLanguageKindEnum>(Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds) where TLanguageKindEnum : struct;

        public void RegisterOperationAction(Action<OperationAnalysisContext> action, params OperationKind[] operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 28771, 28996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 28911, 28985);

                f_256_28911_28984(this, action, f_256_28948_28983(operationKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 28771, 28996);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                f_256_28948_28983(Microsoft.CodeAnalysis.OperationKind[]
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.OperationKind>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 28948, 28983);
                    return return_v;
                }


                int
                f_256_28911_28984(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 28911, 28984);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 28771, 28996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 28771, 28996);
            }
        }

        public virtual void RegisterOperationAction(Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 29704, 29906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 29859, 29895);

                throw f_256_29865_29894();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 29704, 29906);

                System.NotImplementedException
                f_256_29865_29894()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 29865, 29894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 29704, 29906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 29704, 29906);
            }
        }

        public bool TryGetValue<TValue>(SourceText text, SourceTextValueProvider<TValue> valueProvider, [MaybeNullWhen(false)] out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 30867, 31108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 31028, 31097);

                return f_256_31035_31096(this, text, f_256_31053_31084(valueProvider), out value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 30867, 31108);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.Text.SourceText, TValue>
                f_256_31053_31084(Microsoft.CodeAnalysis.Diagnostics.SourceTextValueProvider<TValue>
                this_param)
                {
                    var return_v = this_param.CoreValueProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 31053, 31084);
                    return return_v;
                }


                bool
                f_256_31035_31096(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                key, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.Text.SourceText, TValue>
                valueProvider, out TValue?
                value)
                {
                    var return_v = this_param.TryGetValue<Microsoft.CodeAnalysis.Text.SourceText, TValue>(key, valueProvider, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 31035, 31096);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 30867, 31108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 30867, 31108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryGetValue<TValue>(SyntaxTree tree, SyntaxTreeValueProvider<TValue> valueProvider, [MaybeNullWhen(false)] out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 32078, 32319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 32239, 32308);

                return f_256_32246_32307(this, tree, f_256_32264_32295(valueProvider), out value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 32078, 32319);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.SyntaxTree, TValue>
                f_256_32264_32295(Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeValueProvider<TValue>
                this_param)
                {
                    var return_v = this_param.CoreValueProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 32264, 32295);
                    return return_v;
                }


                bool
                f_256_32246_32307(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.SyntaxTree, TValue>
                valueProvider, out TValue?
                value)
                {
                    var return_v = this_param.TryGetValue<Microsoft.CodeAnalysis.SyntaxTree, TValue>(key, valueProvider, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 32246, 32307);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 32078, 32319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 32078, 32319);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetValue<TKey, TValue>(TKey key, AnalysisValueProvider<TKey, TValue> valueProvider, [MaybeNullWhen(false)] out TValue value)
                    where TKey : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 32331, 32676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 32528, 32597);

                f_256_32528_32596(key, valueProvider);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 32611, 32665);

                return f_256_32618_32664(this, key, valueProvider, out value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 32331, 32676);

                int
                f_256_32528_32596(TKey
                key, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                valueProvider)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(key, valueProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 32528, 32596);
                    return 0;
                }


                bool
                f_256_32618_32664(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext
                this_param, TKey
                key, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                valueProvider, out TValue?
                value)
                {
                    var return_v = this_param.TryGetValueCore<TKey, TValue>(key, valueProvider, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 32618, 32664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 32331, 32676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 32331, 32676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool TryGetValueCore<TKey, TValue>(TKey key, AnalysisValueProvider<TKey, TValue> valueProvider, [MaybeNullWhen(false)] out TValue value)
                    where TKey : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 32688, 32945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 32898, 32934);

                throw f_256_32904_32933();
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 32688, 32945);

                System.NotImplementedException
                f_256_32904_32933()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 32904, 32933);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 32688, 32945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 32688, 32945);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompilationStartAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 18244, 32952);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 18244, 32952);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 18244, 32952);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(256, 18244, 32952);
    }

    public struct CompilationAnalysisContext
    {

        private readonly Compilation _compilation;

        private readonly AnalyzerOptions _options;

        private readonly Action<Diagnostic> _reportDiagnostic;

        private readonly Func<Diagnostic, bool> _isSupportedDiagnostic;

        private readonly CompilationAnalysisValueProviderFactory? _compilationAnalysisValueProviderFactoryOpt;

        private readonly CancellationToken _cancellationToken;

        public Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 33904, 33932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 33910, 33930);

                    return _compilation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 33904, 33932);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 33871, 33934);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 33871, 33934);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 34075, 34099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 34081, 34097);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 34075, 34099);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 34042, 34101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 34042, 34101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 34277, 34311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 34283, 34309);

                    return _cancellationToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 34277, 34311);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 34232, 34313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 34232, 34313);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CompilationAnalysisContext(Compilation compilation, AnalyzerOptions options, Action<Diagnostic> reportDiagnostic, Func<Diagnostic, bool> isSupportedDiagnostic, CancellationToken cancellationToken)
        : this(f_256_34549_34560_C(compilation), options, reportDiagnostic, isSupportedDiagnostic, null, cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 34325, 34658);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 34325, 34658);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 34325, 34658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 34325, 34658);
            }
        }

        internal CompilationAnalysisContext(
                    Compilation compilation,
                    AnalyzerOptions options,
                    Action<Diagnostic> reportDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    CompilationAnalysisValueProviderFactory? compilationAnalysisValueProviderFactoryOpt,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 34670, 35403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 35064, 35091);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 35105, 35124);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 35138, 35175);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 35189, 35236);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 35250, 35339);

                _compilationAnalysisValueProviderFactoryOpt = compilationAnalysisValueProviderFactoryOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 35353, 35392);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 34670, 35403);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 34670, 35403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 34670, 35403);
            }
        }

        public void ReportDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 35644, 35946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 35720, 35819);

                f_256_35720_35818(diagnostic, _compilation, _isSupportedDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 35839, 35856);
                lock (_reportDiagnostic)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 35890, 35920);

                    // LAFHIS
                    // f_256_35890_35919(this, diagnostic);
                    
                    _reportDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 35890, 35919);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 35644, 35946);

                int
                f_256_35720_35818(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(diagnostic, compilation, isSupportedDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 35720, 35818);
                    return 0;
                }


                int
                f_256_35890_35919(ref Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    this_param._reportDiagnostic(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 35890, 35919);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 35644, 35946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 35644, 35946);
            }
        }

        public bool TryGetValue<TValue>(SourceText text, SourceTextValueProvider<TValue> valueProvider, [MaybeNullWhen(false)] out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 36907, 37148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 37068, 37137);

                return TryGetValue(text, f_256_37093_37124(valueProvider), out value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 36907, 37148);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.Text.SourceText, TValue>
                f_256_37093_37124(Microsoft.CodeAnalysis.Diagnostics.SourceTextValueProvider<TValue>
                this_param)
                {
                    var return_v = this_param.CoreValueProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 37093, 37124);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 36907, 37148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 36907, 37148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryGetValue<TValue>(SyntaxTree tree, SyntaxTreeValueProvider<TValue> valueProvider, [MaybeNullWhen(false)] out TValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 38109, 38350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 38270, 38339);

                return TryGetValue(tree, f_256_38295_38326(valueProvider), out value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 38109, 38350);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<Microsoft.CodeAnalysis.SyntaxTree, TValue>
                f_256_38295_38326(Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeValueProvider<TValue>
                this_param)
                {
                    var return_v = this_param.CoreValueProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 38295, 38326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 38109, 38350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 38109, 38350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetValue<TKey, TValue>(TKey key, AnalysisValueProvider<TKey, TValue> valueProvider, [MaybeNullWhen(false)] out TValue value)
                    where TKey : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 38362, 39025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 38559, 38628);

                f_256_38559_38627(key, valueProvider);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 38644, 38949) || true) && (_compilationAnalysisValueProviderFactoryOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(256, 38644, 38949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 38733, 38848);

                    var
                    compilationAnalysisValueProvider = f_256_38772_38847(_compilationAnalysisValueProviderFactoryOpt, valueProvider)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 38866, 38934);

                    return f_256_38873_38933(compilationAnalysisValueProvider, key, out value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(256, 38644, 38949);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 38965, 39014);

                return f_256_38972_39013(valueProvider, key, out value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 38362, 39025);

                int
                f_256_38559_38627(TKey
                key, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                valueProvider)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(key, valueProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 38559, 38627);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProvider<TKey, TValue>
                f_256_38772_38847(Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProviderFactory
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                analysisSharedStateProvider)
                {
                    var return_v = this_param.GetValueProvider<TKey, TValue>(analysisSharedStateProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 38772, 38847);
                    return return_v;
                }


                bool
                f_256_38873_38933(Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProvider<TKey, TValue>
                this_param, TKey
                key, out TValue?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 38873, 38933);
                    return return_v;
                }


                bool
                f_256_38972_39013(Microsoft.CodeAnalysis.Diagnostics.AnalysisValueProvider<TKey, TValue>
                this_param, TKey
                key, out TValue?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 38972, 39013);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 38362, 39025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 38362, 39025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static CompilationAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 33259, 39032);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 33259, 39032);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 33259, 39032);
        }

        static Microsoft.CodeAnalysis.Compilation
        f_256_34549_34560_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(256, 34325, 34658);
            return return_v;
        }

    }

    public struct SemanticModelAnalysisContext
    {

        private readonly SemanticModel _semanticModel;

        private readonly AnalyzerOptions _options;

        private readonly Action<Diagnostic> _reportDiagnostic;

        private readonly Func<Diagnostic, bool> _isSupportedDiagnostic;

        private readonly CancellationToken _cancellationToken;

        public SemanticModel SemanticModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 39890, 39920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 39896, 39918);

                    return _semanticModel;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 39890, 39920);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 39853, 39922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 39853, 39922);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 40063, 40087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 40069, 40085);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 40063, 40087);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 40030, 40089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 40030, 40089);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 40265, 40299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 40271, 40297);

                    return _cancellationToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 40265, 40299);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 40220, 40301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 40220, 40301);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SemanticModelAnalysisContext(SemanticModel semanticModel, AnalyzerOptions options, Action<Diagnostic> reportDiagnostic, Func<Diagnostic, bool> isSupportedDiagnostic, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 40313, 40787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 40547, 40578);

                _semanticModel = semanticModel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 40592, 40611);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 40625, 40662);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 40676, 40723);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 40737, 40776);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 40313, 40787);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 40313, 40787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 40313, 40787);
            }
        }

        public void ReportDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 41030, 41346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 41106, 41219);

                f_256_41106_41218(diagnostic, f_256_41167_41193(_semanticModel), _isSupportedDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 41239, 41256);
                lock (_reportDiagnostic)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 41290, 41320);

                    // LAFHIS
                    //f_256_41290_41319(this, diagnostic);

                    _reportDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 41290, 41319);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 41030, 41346);

                Microsoft.CodeAnalysis.Compilation
                f_256_41167_41193(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 41167, 41193);
                    return return_v;
                }


                int
                f_256_41106_41218(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(diagnostic, compilation, isSupportedDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 41106, 41218);
                    return 0;
                }


                int
                f_256_41290_41319(ref Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    this_param._reportDiagnostic(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 41290, 41319);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 41030, 41346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 41030, 41346);
            }
        }
        static SemanticModelAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 39345, 41353);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 39345, 41353);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 39345, 41353);
        }
    }

    public struct SymbolAnalysisContext
    {

        private readonly ISymbol _symbol;

        private readonly Compilation _compilation;

        private readonly AnalyzerOptions _options;

        private readonly Action<Diagnostic> _reportDiagnostic;

        private readonly Func<Diagnostic, bool> _isSupportedDiagnostic;

        private readonly CancellationToken _cancellationToken;

        public ISymbol Symbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 42122, 42145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 42128, 42143);

                    return _symbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 42122, 42145);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 42098, 42147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 42098, 42147);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 42329, 42357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 42335, 42355);

                    return _compilation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 42329, 42357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 42296, 42359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 42296, 42359);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 42500, 42524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 42506, 42522);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 42500, 42524);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 42467, 42526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 42467, 42526);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 42702, 42736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 42708, 42734);

                    return _cancellationToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 42702, 42736);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 42657, 42738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 42657, 42738);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Func<Diagnostic, bool> IsSupportedDiagnostic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 42804, 42829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 42807, 42829);
                    return _isSupportedDiagnostic; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 42804, 42829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 42804, 42829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 42804, 42829);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SymbolAnalysisContext(ISymbol symbol, Compilation compilation, AnalyzerOptions options, Action<Diagnostic> reportDiagnostic, Func<Diagnostic, bool> isSupportedDiagnostic, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 42842, 43348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 43081, 43098);

                _symbol = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 43112, 43139);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 43153, 43172);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 43186, 43223);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 43237, 43284);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 43298, 43337);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 42842, 43348);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 42842, 43348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 42842, 43348);
            }
        }

        public void ReportDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 43573, 43875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 43649, 43748);

                f_256_43649_43747(diagnostic, _compilation, _isSupportedDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 43768, 43785);
                lock (_reportDiagnostic)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 43819, 43849);

                    // LAFHIS
                    //f_256_43819_43848(this, diagnostic);

                    _reportDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 43819, 43848);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 43573, 43875);

                int
                f_256_43649_43747(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(diagnostic, compilation, isSupportedDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 43649, 43747);
                    return 0;
                }


                int
                f_256_43819_43848(ref Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    this_param._reportDiagnostic(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 43819, 43848);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 43573, 43875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 43573, 43875);
            }
        }
        static SymbolAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 41577, 43882);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 41577, 43882);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 41577, 43882);
        }
    }
    public abstract class SymbolStartAnalysisContext
    {
        public ISymbol Symbol { get; }

        public Compilation Compilation { get; }

        public AnalyzerOptions Options { get; }

        public CancellationToken CancellationToken { get; }

        public SymbolStartAnalysisContext(ISymbol symbol, Compilation compilation, AnalyzerOptions options, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 44933, 45245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 44374, 44404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 44553, 44592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 44700, 44739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 45094, 45110);

                Symbol = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 45124, 45150);

                Compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 45164, 45182);

                Options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 45196, 45234);

                CancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 44933, 45245);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 44933, 45245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 44933, 45245);
            }
        }

        public abstract void RegisterSymbolEndAction(Action<SymbolAnalysisContext> action);

        public abstract void RegisterCodeBlockStartAction<TLanguageKindEnum>(Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> action) where TLanguageKindEnum : struct;

        public abstract void RegisterCodeBlockAction(Action<CodeBlockAnalysisContext> action);

        public void RegisterSyntaxNodeAction<TLanguageKindEnum>(Action<SyntaxNodeAnalysisContext> action, params TLanguageKindEnum[] syntaxKinds) where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 47876, 48154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 48071, 48143);

                f_256_48071_48142(this, action, f_256_48109_48141(syntaxKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 47876, 48154);

                System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                f_256_48109_48141(TLanguageKindEnum[]
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<TLanguageKindEnum>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 48109, 48141);
                    return return_v;
                }


                int
                f_256_48071_48142(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                syntaxKinds)
                {
                    this_param.RegisterSyntaxNodeAction<TLanguageKindEnum>(action, syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 48071, 48142);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 47876, 48154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 47876, 48154);
            }
        }

        public abstract void RegisterSyntaxNodeAction<TLanguageKindEnum>(Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds) where TLanguageKindEnum : struct;

        public abstract void RegisterOperationBlockStartAction(Action<OperationBlockStartAnalysisContext> action);

        public abstract void RegisterOperationBlockAction(Action<OperationBlockAnalysisContext> action);

        public void RegisterOperationAction(Action<OperationAnalysisContext> action, params OperationKind[] operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 51030, 51255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 51170, 51244);

                f_256_51170_51243(this, action, f_256_51207_51242(operationKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 51030, 51255);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                f_256_51207_51242(Microsoft.CodeAnalysis.OperationKind[]
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.OperationKind>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 51207, 51242);
                    return return_v;
                }


                int
                f_256_51170_51243(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 51170, 51243);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 51030, 51255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 51030, 51255);
            }
        }

        public abstract void RegisterOperationAction(Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> operationKinds);

        static SymbolStartAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 44190, 52102);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 44190, 52102);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 44190, 52102);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(256, 44190, 52102);
    }
    public abstract class CodeBlockStartAnalysisContext<TLanguageKindEnum> where TLanguageKindEnum : struct
    {
        private readonly SyntaxNode _codeBlock;

        private readonly ISymbol _owningSymbol;

        private readonly SemanticModel _semanticModel;

        private readonly AnalyzerOptions _options;

        private readonly CancellationToken _cancellationToken;

        public SyntaxNode CodeBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 53226, 53252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 53232, 53250);

                    return _codeBlock;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 53226, 53252);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 53196, 53254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 53196, 53254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ISymbol OwningSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 53435, 53464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 53441, 53462);

                    return _owningSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 53435, 53464);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 53405, 53466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 53405, 53466);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SemanticModel SemanticModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 53709, 53739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 53715, 53737);

                    return _semanticModel;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 53709, 53739);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 53672, 53741);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 53672, 53741);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 53882, 53906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 53888, 53904);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 53882, 53906);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 53849, 53908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 53849, 53908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 54084, 54118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 54090, 54116);

                    return _cancellationToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 54084, 54118);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 54039, 54120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 54039, 54120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected CodeBlockStartAnalysisContext(SyntaxNode codeBlock, ISymbol owningSymbol, SemanticModel semanticModel, AnalyzerOptions options, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 54132, 54539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 52845, 52855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 52891, 52904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 52946, 52960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 53004, 53012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 54331, 54354);

                _codeBlock = codeBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 54368, 54397);

                _owningSymbol = owningSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 54411, 54442);

                _semanticModel = semanticModel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 54456, 54475);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 54489, 54528);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 54132, 54539);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 54132, 54539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 54132, 54539);
            }
        }

        public abstract void RegisterCodeBlockEndAction(Action<CodeBlockAnalysisContext> action);

        /// <summary>
        /// Register an action to be executed at completion of semantic analysis of a <see cref="SyntaxNode"/> with an appropriate Kind.
        /// A syntax node action can report <see cref="Diagnostic"/>s about <see cref="SyntaxNode"/>s, and can also collect
        /// state information to be used by other syntax node actions or code block end actions.
        /// </summary>
        /// <param name="action">Action to be executed at completion of semantic analysis of a <see cref="SyntaxNode"/>.</param>
        /// <param name="syntaxKinds">Action will be executed only if a <see cref="SyntaxNode"/>'s Kind matches one of the syntax kind values.</param>
        public void RegisterSyntaxNodeAction(Action<SyntaxNodeAnalysisContext> action, params TLanguageKindEnum[] syntaxKinds)
        {
            this.RegisterSyntaxNodeAction(action, syntaxKinds.AsImmutableOrEmpty());
        }

        public abstract void RegisterSyntaxNodeAction(Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds);

        static CodeBlockStartAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 52697, 56808);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 52697, 56808);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 52697, 56808);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(256, 52697, 56808);
    }

    public struct CodeBlockAnalysisContext
    {

        private readonly SyntaxNode _codeBlock;

        private readonly ISymbol _owningSymbol;

        private readonly SemanticModel _semanticModel;

        private readonly AnalyzerOptions _options;

        private readonly Action<Diagnostic> _reportDiagnostic;

        private readonly Func<Diagnostic, bool> _isSupportedDiagnostic;

        private readonly CancellationToken _cancellationToken;

        public SyntaxNode CodeBlock
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 57683, 57709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 57689, 57707);

                    return _codeBlock;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 57683, 57709);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 57653, 57711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 57653, 57711);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ISymbol OwningSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 57892, 57921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 57898, 57919);

                    return _owningSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 57892, 57921);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 57862, 57923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 57862, 57923);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SemanticModel SemanticModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 58166, 58196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 58172, 58194);

                    return _semanticModel;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 58166, 58196);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 58129, 58198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 58129, 58198);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 58339, 58363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 58345, 58361);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 58339, 58363);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 58306, 58365);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 58306, 58365);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 58541, 58575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 58547, 58573);

                    return _cancellationToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(256, 58541, 58575);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 58496, 58577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 58496, 58577);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CodeBlockAnalysisContext(SyntaxNode codeBlock, ISymbol owningSymbol, SemanticModel semanticModel, AnalyzerOptions options, Action<Diagnostic> reportDiagnostic, Func<Diagnostic, bool> isSupportedDiagnostic, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 58589, 59183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 58863, 58886);

                _codeBlock = codeBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 58900, 58929);

                _owningSymbol = owningSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 58943, 58974);

                _semanticModel = semanticModel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 58988, 59007);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 59021, 59058);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 59072, 59119);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 59133, 59172);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 58589, 59183);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 58589, 59183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 58589, 59183);
            }
        }

        public void ReportDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 59396, 59712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 59472, 59585);

                f_256_59472_59584(diagnostic, f_256_59533_59559(_semanticModel), _isSupportedDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 59605, 59622);
                lock (_reportDiagnostic)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 59656, 59686);

                    // LAFHIS
                    //f_256_59656_59685(this, diagnostic);

                    _reportDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 59656, 59685);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 59396, 59712);

                Microsoft.CodeAnalysis.Compilation
                f_256_59533_59559(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 59533, 59559);
                    return return_v;
                }


                int
                f_256_59472_59584(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(diagnostic, compilation, isSupportedDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 59472, 59584);
                    return 0;
                }


                int
                f_256_59656_59685(ref Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    this_param._reportDiagnostic(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 59656, 59685);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 59396, 59712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 59396, 59712);
            }
        }
        static CodeBlockAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 57081, 59719);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 57081, 59719);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 57081, 59719);
        }
    }
    public abstract class OperationBlockStartAnalysisContext
    {
        private readonly ImmutableArray<IOperation> _operationBlocks;

        private readonly ISymbol _owningSymbol;

        private readonly Compilation _compilation;

        private readonly AnalyzerOptions _options;

        private readonly Func<IOperation, ControlFlowGraph>? _getControlFlowGraph;

        private readonly CancellationToken _cancellationToken;

        public ImmutableArray<IOperation> OperationBlocks
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 61220, 61239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 61223, 61239);
                    return _operationBlocks; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 61220, 61239);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 61220, 61239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 61220, 61239);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ISymbol OwningSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 61438, 61454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 61441, 61454);
                    return _owningSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 61438, 61454);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 61438, 61454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 61438, 61454);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 61643, 61658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 61646, 61658);
                    return _compilation; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 61643, 61658);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 61643, 61658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 61643, 61658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 61798, 61809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 61801, 61809);
                    return _options; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 61798, 61809);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 61798, 61809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 61798, 61809);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 61984, 62005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 61987, 62005);
                    return _cancellationToken; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 61984, 62005);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 61984, 62005);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 61984, 62005);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected OperationBlockStartAnalysisContext(
                    ImmutableArray<IOperation> operationBlocks,
                    ISymbol owningSymbol,
                    Compilation compilation,
                    AnalyzerOptions options,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 62018, 62564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 60481, 60494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 60534, 60546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 60590, 60598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 60662, 60682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 62306, 62341);

                _operationBlocks = operationBlocks;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 62355, 62384);

                _owningSymbol = owningSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 62398, 62425);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 62439, 62458);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 62472, 62511);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 62525, 62553);

                _getControlFlowGraph = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 62018, 62564);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 62018, 62564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 62018, 62564);
            }
        }

        internal OperationBlockStartAnalysisContext(
                    ImmutableArray<IOperation> operationBlocks,
                    ISymbol owningSymbol,
                    Compilation compilation,
                    AnalyzerOptions options,
                    Func<IOperation, ControlFlowGraph> getControlFlowGraph,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 62576, 63205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 60481, 60494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 60534, 60546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 60590, 60598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 60662, 60682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 62932, 62967);

                _operationBlocks = operationBlocks;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 62981, 63010);

                _owningSymbol = owningSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 63024, 63051);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 63065, 63084);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 63098, 63141);

                _getControlFlowGraph = getControlFlowGraph;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 63155, 63194);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 62576, 63205);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 62576, 63205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 62576, 63205);
            }
        }

        public abstract void RegisterOperationBlockEndAction(Action<OperationBlockAnalysisContext> action);

        public void RegisterOperationAction(Action<OperationAnalysisContext> action, params OperationKind[] operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 64410, 64635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 64550, 64624);

                f_256_64550_64623(this, action, f_256_64587_64622(operationKinds));
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 64410, 64635);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                f_256_64587_64622(Microsoft.CodeAnalysis.OperationKind[]
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.OperationKind>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 64587, 64622);
                    return return_v;
                }


                int
                f_256_64550_64623(Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                action, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    this_param.RegisterOperationAction(action, operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 64550, 64623);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 64410, 64635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 64410, 64635);
            }
        }

        public abstract void RegisterOperationAction(Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> operationKinds);

        public ControlFlowGraph GetControlFlowGraph(IOperation operationBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 65763, 66359);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 65858, 65989) || true) && (operationBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(256, 65858, 65989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 65918, 65974);

                    throw f_256_65924_65973(nameof(operationBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(256, 65858, 65989);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 66005, 66214) || true) && (!f_256_66010_66025().Contains(operationBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(256, 66005, 66214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 66084, 66199);

                    throw f_256_66090_66198(f_256_66112_66173(), nameof(operationBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(256, 66005, 66214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 66230, 66348);

                return f_256_66237_66347(operationBlock, _getControlFlowGraph, _cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 65763, 66359);

                System.ArgumentNullException
                f_256_65924_65973(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 65924, 65973);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_256_66010_66025()
                {
                    var return_v = OperationBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 66010, 66025);
                    return return_v;
                }


                string
                f_256_66112_66173()
                {
                    var return_v = CodeAnalysisResources.InvalidOperationBlockForAnalysisContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 66112, 66173);
                    return return_v;
                }


                System.ArgumentException
                f_256_66090_66198(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 66090, 66198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_256_66237_66347(Microsoft.CodeAnalysis.IOperation
                operation, System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>?
                getControlFlowGraph, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = DiagnosticAnalysisContextHelpers.GetControlFlowGraph(operation, getControlFlowGraph, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 66237, 66347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 65763, 66359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 65763, 66359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OperationBlockStartAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 60312, 66366);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 60312, 66366);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 60312, 66366);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(256, 60312, 66366);
    }

    public struct OperationBlockAnalysisContext
    {

        private readonly ImmutableArray<IOperation> _operationBlocks;

        private readonly ISymbol _owningSymbol;

        private readonly Compilation _compilation;

        private readonly AnalyzerOptions _options;

        private readonly Action<Diagnostic> _reportDiagnostic;

        private readonly Func<Diagnostic, bool> _isSupportedDiagnostic;

        private readonly Func<IOperation, ControlFlowGraph>? _getControlFlowGraph;

        private readonly CancellationToken _cancellationToken;

        public ImmutableArray<IOperation> OperationBlocks
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 67700, 67719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 67703, 67719);
                    return _operationBlocks; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 67700, 67719);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 67700, 67719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 67700, 67719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ISymbol OwningSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 67918, 67934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 67921, 67934);
                    return _owningSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 67918, 67934);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 67918, 67934);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 67918, 67934);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 68123, 68138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 68126, 68138);
                    return _compilation; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 68123, 68138);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 68123, 68138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 68123, 68138);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 68278, 68289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 68281, 68289);
                    return _options; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 68278, 68289);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 68278, 68289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 68278, 68289);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 68464, 68485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 68467, 68485);
                    return _cancellationToken; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 68464, 68485);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 68464, 68485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 68464, 68485);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public OperationBlockAnalysisContext(
                    ImmutableArray<IOperation> operationBlocks,
                    ISymbol owningSymbol,
                    Compilation compilation,
                    AnalyzerOptions options,
                    Action<Diagnostic> reportDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 68498, 69257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 68887, 68922);

                _operationBlocks = operationBlocks;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 68936, 68965);

                _owningSymbol = owningSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 68979, 69006);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69020, 69039);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69053, 69090);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69104, 69151);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69165, 69204);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69218, 69246);

                _getControlFlowGraph = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 68498, 69257);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 68498, 69257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 68498, 69257);
            }
        }

        internal OperationBlockAnalysisContext(
                    ImmutableArray<IOperation> operationBlocks,
                    ISymbol owningSymbol,
                    Compilation compilation,
                    AnalyzerOptions options,
                    Action<Diagnostic> reportDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    Func<IOperation, ControlFlowGraph> getControlFlowGraph,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 69269, 70114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69729, 69764);

                _operationBlocks = operationBlocks;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69778, 69807);

                _owningSymbol = owningSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69821, 69848);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69862, 69881);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69895, 69932);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 69946, 69993);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 70007, 70050);

                _getControlFlowGraph = getControlFlowGraph;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 70064, 70103);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 69269, 70114);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 69269, 70114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 69269, 70114);
            }
        }

        public void ReportDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 70327, 70628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 70403, 70501);

                f_256_70403_70500(diagnostic, Compilation, _isSupportedDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 70521, 70538);
                lock (_reportDiagnostic)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 70572, 70602);

                    // LAFHIS
                    //f_256_70572_70601(this, diagnostic);

                    _reportDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 70572, 70601);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 70327, 70628);

                int
                f_256_70403_70500(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(diagnostic, compilation, isSupportedDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 70403, 70500);
                    return 0;
                }


                int
                f_256_70572_70601(ref Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    this_param._reportDiagnostic(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 70572, 70601);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 70327, 70628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 70327, 70628);
            }
        }

        public ControlFlowGraph GetControlFlowGraph(IOperation operationBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 70911, 71507);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 71006, 71137) || true) && (operationBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(256, 71006, 71137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 71066, 71122);

                    throw f_256_71072_71121(nameof(operationBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(256, 71006, 71137);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 71153, 71362) || true) && (!OperationBlocks.Contains(operationBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(256, 71153, 71362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 71232, 71347);

                    throw f_256_71238_71346(f_256_71260_71321(), nameof(operationBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(256, 71153, 71362);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 71378, 71496);

                return f_256_71385_71495(operationBlock, _getControlFlowGraph, _cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 70911, 71507);

                System.ArgumentNullException
                f_256_71072_71121(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 71072, 71121);
                    return return_v;
                }


                string
                f_256_71260_71321()
                {
                    var return_v = CodeAnalysisResources.InvalidOperationBlockForAnalysisContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 71260, 71321);
                    return return_v;
                }


                System.ArgumentException
                f_256_71238_71346(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 71238, 71346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_256_71385_71495(Microsoft.CodeAnalysis.IOperation
                operation, System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>?
                getControlFlowGraph, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = DiagnosticAnalysisContextHelpers.GetControlFlowGraph(operation, getControlFlowGraph, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 71385, 71495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 70911, 71507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 70911, 71507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static OperationBlockAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 66668, 71514);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 66668, 71514);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 66668, 71514);
        }
    }

    public struct SyntaxTreeAnalysisContext
    {

        private readonly SyntaxTree _tree;

        private readonly Compilation? _compilationOpt;

        private readonly AnalyzerOptions _options;

        private readonly Action<Diagnostic> _reportDiagnostic;

        private readonly Func<Diagnostic, bool> _isSupportedDiagnostic;

        private readonly CancellationToken _cancellationToken;

        public SyntaxTree Tree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 72330, 72338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 72333, 72338);
                    return _tree; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 72330, 72338);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 72330, 72338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 72330, 72338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 72478, 72489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 72481, 72489);
                    return _options; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 72478, 72489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 72478, 72489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 72478, 72489);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 72664, 72685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 72667, 72685);
                    return _cancellationToken; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 72664, 72685);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 72664, 72685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 72664, 72685);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Compilation? Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 72732, 72750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 72735, 72750);
                    return _compilationOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 72732, 72750);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 72732, 72750);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 72732, 72750);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxTreeAnalysisContext(SyntaxTree tree, AnalyzerOptions options, Action<Diagnostic> reportDiagnostic, Func<Diagnostic, bool> isSupportedDiagnostic, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 72763, 73241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 72982, 72995);

                _tree = tree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73009, 73028);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73042, 73079);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73093, 73140);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73154, 73177);

                _compilationOpt = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73191, 73230);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 72763, 73241);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 72763, 73241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 72763, 73241);
            }
        }

        internal SyntaxTreeAnalysisContext(SyntaxTree tree, AnalyzerOptions options, Action<Diagnostic> reportDiagnostic, Func<Diagnostic, bool> isSupportedDiagnostic, Compilation compilation, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 73253, 73765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73499, 73512);

                _tree = tree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73526, 73545);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73559, 73596);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73610, 73657);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73671, 73701);

                _compilationOpt = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 73715, 73754);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 73253, 73765);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 73253, 73765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 73253, 73765);
            }
        }

        public void ReportDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 73992, 74297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 74068, 74170);

                f_256_74068_74169(diagnostic, _compilationOpt, _isSupportedDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 74190, 74207);
                lock (_reportDiagnostic)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 74241, 74271);

                    // LAFHIS
                    //f_256_74241_74270(this, diagnostic);

                    _reportDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 74241, 74270);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 73992, 74297);

                int
                f_256_74068_74169(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation?
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(diagnostic, compilation, isSupportedDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 74068, 74169);
                    return 0;
                }


                int
                f_256_74241_74270(ref Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    this_param._reportDiagnostic(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 74241, 74270);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 73992, 74297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 73992, 74297);
            }
        }
        static SyntaxTreeAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 71774, 74304);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 71774, 74304);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 71774, 74304);
        }
    }

    public readonly struct AdditionalFileAnalysisContext
    {

        private readonly Action<Diagnostic> _reportDiagnostic;

        private readonly Func<Diagnostic, bool> _isSupportedDiagnostic;

        public AdditionalText AdditionalFile { get; }

        public AnalyzerOptions Options { get; }

        public CancellationToken CancellationToken { get; }

        public Compilation Compilation { get; }

        internal AdditionalFileAnalysisContext(
                    AdditionalText additionalFile,
                    AnalyzerOptions options,
                    Action<Diagnostic> reportDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    Compilation compilation,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 75442, 76064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 75785, 75817);

                AdditionalFile = additionalFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 75831, 75849);

                Options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 75863, 75900);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 75914, 75961);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 75975, 76001);

                Compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 76015, 76053);

                CancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 75442, 76064);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 75442, 76064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 75442, 76064);
            }
        }

        public void ReportDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 76422, 76723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 76498, 76596);

                f_256_76498_76595(diagnostic, Compilation, _isSupportedDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 76616, 76633);
                lock (_reportDiagnostic)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 76667, 76697);

                    // LAFHIS
                    //f_256_76667_76696(this, diagnostic);

                    _reportDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 76667, 76696);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 76422, 76723);

                int
                f_256_76498_76595(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(diagnostic, compilation, isSupportedDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 76498, 76595);
                    return 0;
                }


                int
                f_256_76667_76696(ref Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    this_param._reportDiagnostic(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 76667, 76696);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 76422, 76723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 76422, 76723);
            }
        }
        static AdditionalFileAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 74583, 76730);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 74583, 76730);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 74583, 76730);
        }
    }

    public struct SyntaxNodeAnalysisContext
    {

        private readonly SyntaxNode _node;

        private readonly ISymbol? _containingSymbol;

        private readonly SemanticModel _semanticModel;

        private readonly AnalyzerOptions _options;

        private readonly Action<Diagnostic> _reportDiagnostic;

        private readonly Func<Diagnostic, bool> _isSupportedDiagnostic;

        private readonly CancellationToken _cancellationToken;

        public SyntaxNode Node
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 77578, 77586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 77581, 77586);
                    return _node; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 77578, 77586);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 77578, 77586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 77578, 77586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ISymbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 77762, 77782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 77765, 77782);
                    return _containingSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 77762, 77782);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 77762, 77782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 77762, 77782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SemanticModel SemanticModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 78005, 78022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 78008, 78022);
                    return _semanticModel; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 78005, 78022);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 78005, 78022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 78005, 78022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 78206, 78277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 78209, 78277);
                    return f_256_78209_78236_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_semanticModel, 256, 78209, 78236)?.Compilation) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Compilation?>(256, 78209, 78277) ?? throw f_256_78246_78277()); DynAbs.Tracing.TraceSender.TraceExitMethod(256, 78206, 78277);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 78206, 78277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 78206, 78277);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 78417, 78428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 78420, 78428);
                    return _options; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 78417, 78428);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 78417, 78428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 78417, 78428);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 78603, 78624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 78606, 78624);
                    return _cancellationToken; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 78603, 78624);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 78603, 78624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 78603, 78624);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxNodeAnalysisContext(SyntaxNode node, ISymbol? containingSymbol, SemanticModel semanticModel, AnalyzerOptions options, Action<Diagnostic> reportDiagnostic, Func<Diagnostic, bool> isSupportedDiagnostic, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 78637, 79230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 78912, 78925);

                _node = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 78939, 78976);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 78990, 79021);

                _semanticModel = semanticModel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 79035, 79054);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 79068, 79105);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 79119, 79166);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 79180, 79219);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 78637, 79230);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 78637, 79230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 78637, 79230);
            }
        }

        public SyntaxNodeAnalysisContext(SyntaxNode node, SemanticModel semanticModel, AnalyzerOptions options, Action<Diagnostic> reportDiagnostic, Func<Diagnostic, bool> isSupportedDiagnostic, CancellationToken cancellationToken)
        : this(f_256_79485_79489_C(node), null, semanticModel, options, reportDiagnostic, isSupportedDiagnostic, cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 79242, 79602);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 79242, 79602);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 79242, 79602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 79242, 79602);
            }
        }

        public void ReportDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 79829, 80145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 79905, 80018);

                f_256_79905_80017(diagnostic, f_256_79966_79992(_semanticModel), _isSupportedDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 80038, 80055);
                lock (_reportDiagnostic)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 80089, 80119);

                    // LAFHIS
                    //f_256_80089_80118(this, diagnostic);

                    _reportDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 80089, 80118);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 79829, 80145);

                Microsoft.CodeAnalysis.Compilation
                f_256_79966_79992(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 79966, 79992);
                    return return_v;
                }


                int
                f_256_79905_80017(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(diagnostic, compilation, isSupportedDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 79905, 80017);
                    return 0;
                }


                int
                f_256_80089_80118(ref Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    this_param._reportDiagnostic(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 80089, 80118);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 79829, 80145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 79829, 80145);
            }
        }
        static SyntaxNodeAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 76968, 80152);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 76968, 80152);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 76968, 80152);
        }

        Microsoft.CodeAnalysis.Compilation?
        f_256_78209_78236_M(Microsoft.CodeAnalysis.Compilation?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 78209, 78236);
            return return_v;
        }


        System.InvalidOperationException
        f_256_78246_78277()
        {
            var return_v = new System.InvalidOperationException();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 78246, 78277);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_256_79485_79489_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(256, 79242, 79602);
            return return_v;
        }

    }

    public struct OperationAnalysisContext
    {

        private readonly IOperation _operation;

        private readonly ISymbol _containingSymbol;

        private readonly Compilation _compilation;

        private readonly AnalyzerOptions _options;

        private readonly Action<Diagnostic> _reportDiagnostic;

        private readonly Func<Diagnostic, bool> _isSupportedDiagnostic;

        private readonly Func<IOperation, ControlFlowGraph>? _getControlFlowGraph;

        private readonly CancellationToken _cancellationToken;

        public IOperation Operation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 81087, 81100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 81090, 81100);
                    return _operation; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 81087, 81100);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 81087, 81100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 81087, 81100);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ISymbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 81273, 81293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 81276, 81293);
                    return _containingSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 81273, 81293);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 81273, 81293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 81273, 81293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 81477, 81492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 81480, 81492);
                    return _compilation; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 81477, 81492);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 81477, 81492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 81477, 81492);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 81632, 81643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 81635, 81643);
                    return _options; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 81632, 81643);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 81632, 81643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 81632, 81643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 81818, 81839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 81821, 81839);
                    return _cancellationToken; DynAbs.Tracing.TraceSender.TraceExitMethod(256, 81818, 81839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 81818, 81839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 81818, 81839);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public OperationAnalysisContext(
                    IOperation operation,
                    ISymbol containingSymbol,
                    Compilation compilation,
                    AnalyzerOptions options,
                    Action<Diagnostic> reportDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 81852, 82584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 82218, 82241);

                _operation = operation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 82255, 82292);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 82306, 82333);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 82347, 82366);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 82380, 82417);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 82431, 82478);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 82492, 82531);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 82545, 82573);

                _getControlFlowGraph = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 81852, 82584);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 81852, 82584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 81852, 82584);
            }
        }

        internal OperationAnalysisContext(
                    IOperation operation,
                    ISymbol containingSymbol,
                    Compilation compilation,
                    AnalyzerOptions options,
                    Action<Diagnostic> reportDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    Func<IOperation, ControlFlowGraph> getControlFlowGraph,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 82596, 83414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83033, 83056);

                _operation = operation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83070, 83107);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83121, 83148);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83162, 83181);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83195, 83232);

                _reportDiagnostic = reportDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83246, 83293);

                _isSupportedDiagnostic = isSupportedDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83307, 83350);

                _getControlFlowGraph = getControlFlowGraph;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83364, 83403);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 82596, 83414);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 82596, 83414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 82596, 83414);
            }
        }

        public void ReportDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 83641, 83943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83717, 83816);

                f_256_83717_83815(diagnostic, _compilation, _isSupportedDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83836, 83853);
                lock (_reportDiagnostic)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 83887, 83917);

                    // LAFHIS
                    //f_256_83887_83916(this, diagnostic);

                    _reportDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 83887, 83916);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 83641, 83943);

                int
                f_256_83717_83815(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic)
                {
                    DiagnosticAnalysisContextHelpers.VerifyArguments(diagnostic, compilation, isSupportedDiagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 83717, 83815);
                    return 0;
                }


                int
                f_256_83887_83916(ref Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    this_param._reportDiagnostic(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 83887, 83916);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 83641, 83943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 83641, 83943);
            }
        }

        public ControlFlowGraph GetControlFlowGraph()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 84163, 84271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 84166, 84271);
                return f_256_84166_84271(Operation, _getControlFlowGraph, _cancellationToken); DynAbs.Tracing.TraceSender.TraceExitMethod(256, 84163, 84271);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 84163, 84271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 84163, 84271);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
            f_256_84166_84271(Microsoft.CodeAnalysis.IOperation
            operation, System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>?
            getControlFlowGraph, System.Threading.CancellationToken
            cancellationToken)
            {
                var return_v = DiagnosticAnalysisContextHelpers.GetControlFlowGraph(operation, getControlFlowGraph, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 84166, 84271);
                return return_v;
            }

        }
        static OperationAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 80389, 84279);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 80389, 84279);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 80389, 84279);
        }
    }

    public struct SuppressionAnalysisContext
    {

        private readonly Action<Suppression> _addSuppression;

        private readonly Func<SuppressionDescriptor, bool> _isSupportedSuppressionDescriptor;

        private readonly Func<SyntaxTree, SemanticModel> _getSemanticModel;

        public ImmutableArray<Diagnostic> ReportedDiagnostics { get; }

        public Compilation Compilation { get; }

        public AnalyzerOptions Options { get; }

        public CancellationToken CancellationToken { get; }

        internal SuppressionAnalysisContext(
                    Compilation compilation,
                    AnalyzerOptions options,
                    ImmutableArray<Diagnostic> reportedDiagnostics,
                    Action<Suppression> suppressDiagnostic,
                    Func<SuppressionDescriptor, bool> isSupportedSuppressionDescriptor,
                    Func<SyntaxTree, SemanticModel> getSemanticModel,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(256, 86252, 87059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 86697, 86723);

                Compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 86737, 86755);

                Options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 86769, 86811);

                ReportedDiagnostics = reportedDiagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 86825, 86862);

                _addSuppression = suppressDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 86876, 86945);

                _isSupportedSuppressionDescriptor = isSupportedSuppressionDescriptor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 86959, 86996);

                _getSemanticModel = getSemanticModel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 87010, 87048);

                CancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(256, 86252, 87059);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 86252, 87059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 86252, 87059);
            }
        }

        public void ReportSuppression(Suppression suppression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 87193, 88314);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 87272, 87651) || true) && (!ReportedDiagnostics.Contains(suppression.SuppressedDiagnostic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(256, 87272, 87651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 87453, 87581);

                    var
                    message = f_256_87467_87580(f_256_87481_87542(), f_256_87544_87579(suppression.SuppressedDiagnostic))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 87599, 87636);

                    throw f_256_87605_87635(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(256, 87272, 87651);
                }

                // LAFHIS
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 87667, 88033);
                //var temp = !f_256_87672_87729(this, suppression.Descriptor);
                var temp = !_isSupportedSuppressionDescriptor(suppression.Descriptor);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 87672, 87729);

                if (temp)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(256, 87667, 88033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 87854, 87963);

                    var
                    message = f_256_87868_87962(f_256_87882_87934(), f_256_87936_87961(suppression.Descriptor))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 87981, 88018);

                    throw f_256_87987_88017(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(256, 87667, 88033);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 88049, 88258) || true) && (f_256_88053_88107(suppression.Descriptor, f_256_88087_88106(Compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(256, 88049, 88258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 88236, 88243);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(256, 88049, 88258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 88274, 88303);

                // LAFHIS
                //f_256_88274_88302(this, suppression);
                _addSuppression(suppression);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 88274, 88302);

                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 87193, 88314);

                string
                f_256_87481_87542()
                {
                    var return_v = CodeAnalysisResources.NonReportedDiagnosticCannotBeSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 87481, 87542);
                    return return_v;
                }


                string
                f_256_87544_87579(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 87544, 87579);
                    return return_v;
                }


                string
                f_256_87467_87580(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 87467, 87580);
                    return return_v;
                }


                System.ArgumentException
                f_256_87605_87635(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 87605, 87635);
                    return return_v;
                }


                bool
                f_256_87672_87729(ref Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext
                this_param, Microsoft.CodeAnalysis.SuppressionDescriptor
                arg)
                {
                    var return_v = this_param._isSupportedSuppressionDescriptor(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 87672, 87729);
                    return return_v;
                }


                string
                f_256_87882_87934()
                {
                    var return_v = CodeAnalysisResources.UnsupportedSuppressionReported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 87882, 87934);
                    return return_v;
                }


                string
                f_256_87936_87961(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 87936, 87961);
                    return return_v;
                }


                string
                f_256_87868_87962(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 87868, 87962);
                    return return_v;
                }


                System.ArgumentException
                f_256_87987_88017(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 87987, 88017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_256_88087_88106(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(256, 88087, 88106);
                    return return_v;
                }


                bool
                f_256_88053_88107(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param, Microsoft.CodeAnalysis.CompilationOptions
                compilationOptions)
                {
                    var return_v = this_param.IsDisabled(compilationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 88053, 88107);
                    return return_v;
                }


                int
                f_256_88274_88302(ref Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostics.Suppression
                obj)
                {
                    this_param._addSuppression(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 88274, 88302);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 87193, 88314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 87193, 88314);
            }
        }

        public SemanticModel GetSemanticModel(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(256, 88560, 88592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(256, 88563, 88592);
                
                // LAFHIS
                //return f_256_88563_88592(this, syntaxTree); 
                var temp = _getSemanticModel(syntaxTree);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 88563, 88592);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitMethod(256, 88560, 88592);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(256, 88560, 88592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 88560, 88592);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SemanticModel
            f_256_88563_88592(ref Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            arg)
            {
                var return_v = this_param._getSemanticModel(arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(256, 88563, 88592);
                return return_v;
            }

        }
        static SuppressionAnalysisContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(256, 84436, 88600);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(256, 84436, 88600);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(256, 84436, 88600);
        }
    }
}
